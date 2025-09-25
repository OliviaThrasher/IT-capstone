Imports System.Windows.Forms

Public Class Form1

    ' holds all transactions
    Private ReadOnly transactions As New List(Of Transaction)

    ' form load
    Private Sub Form1Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' If any of these labels/textboxes were accidentally data-bound in the designer,
        ' clear the bindings so our code controls the Text values.
        IncomeOutput.DataBindings.Clear()
        ExpenseOutput.DataBindings.Clear()
        BalanceOutput.DataBindings.Clear()

        ' categories
        CategoryPicker.Items.Clear()
        CategoryPicker.Items.AddRange(New Object() {
            "Groceries", "Entertainment", "Paycheck", "Savings", "Debt", "Bills"
        })
        If CategoryPicker.Items.Count > 0 Then CategoryPicker.SelectedIndex = 0

        ' default to income
        IncomeRadioButton.Checked = True

        ' show starting totals
        UpdateTotals()
    End Sub

    ' add transaction
    Private Sub AddButtonClick(sender As Object, e As EventArgs) Handles AddButton.Click
        ' validate amount
        Dim amount As Decimal
        If Not Decimal.TryParse(MoneyInput.Text, amount) OrElse amount <= 0D Then
            MessageBox.Show("Please enter a positive number.", "Invalid amount")
            MoneyInput.Focus()
            MoneyInput.SelectAll()
            Return
        End If

        ' make sure entry type is chosen
        Dim isIncome As Boolean
        If IncomeRadioButton.Checked Then
            isIncome = True
        ElseIf ExpenseRadioButton.Checked Then
            isIncome = False
        Else
            MessageBox.Show("Please select Income or Expense.", "Entry Type Missing")
            Return
        End If

        ' details
        Dim desc As String = NameInput.Text.Trim()
        Dim cat As String = CategoryPicker.Text

        ' create and add
        Dim txn As New Transaction With {
            .When = DateTime.Now,
            .IsIncome = isIncome,
            .Category = cat,
            .Description = desc,
            .Amount = If(isIncome, amount, -amount) ' expenses stored negative
        }

        transactions.Add(txn)
        ListBox1.Items.Add(txn)

        ' reset inputs
        MoneyInput.Clear()
        NameInput.Clear()
        IncomeRadioButton.Checked = True
        CategoryPicker.SelectedIndex = 0

        ' update totals
        UpdateTotals()
    End Sub

    ' clear all
    Private Sub ClearButtonClick(sender As Object, e As EventArgs) Handles ClearButton.Click
        transactions.Clear()
        ListBox1.Items.Clear()
        MoneyInput.Clear()
        NameInput.Clear()
        IncomeRadioButton.Checked = True
        If CategoryPicker.Items.Count > 0 Then CategoryPicker.SelectedIndex = 0
        UpdateTotals()
    End Sub

    ' delete from the list
    Private Sub ListBox1KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyCode = Keys.Delete AndAlso ListBox1.SelectedIndex >= 0 Then
            Dim txn As Transaction = CType(ListBox1.SelectedItem, Transaction)
            transactions.Remove(txn)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            UpdateTotals()
        End If
    End Sub

    ' totals
    Private Sub UpdateTotals()
        Dim totalIncome As Decimal = 0D
        Dim totalExpense As Decimal = 0D
        Dim balance As Decimal = 0D

        For Each t In transactions
            If t.IsIncome Then
                totalIncome += t.Amount
            Else
                totalExpense += Math.Abs(t.Amount)
            End If
            balance += t.Amount
        Next

        IncomeOutput.Text = totalIncome.ToString("C2")
        ExpenseOutput.Text = totalExpense.ToString("C2")

        ' custom balance formatting (force -$xx.xx instead of parentheses when the balance is negative)
        If balance < 0 Then
            BalanceOutput.Text = "-$" & Math.Abs(balance).ToString("N2")
        Else
            BalanceOutput.Text = balance.ToString("C2")
        End If
    End Sub

    ' model
    Private Class Transaction
        Public Property [When] As DateTime
        Public Property IsIncome As Boolean
        Public Property Category As String = ""
        Public Property Description As String = ""
        Public Property Amount As Decimal

        Public Overrides Function ToString() As String
            Dim kind As String = If(IsIncome, "Income", "Expense")
            Return String.Format("{0:MM/dd} | {1} | {2} | {3} | {4:C2}",
                                 [When], kind, Category, Description, Math.Abs(Amount))
        End Function
    End Class

    Private Sub GroupBox1Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LabelListClick(sender As Object, e As EventArgs) Handles LabelList.Click

    End Sub

    ' save transactions to a text file
    Private Sub SaveButtonClick(sender As Object, e As EventArgs) Handles SaveButton.Click
        If ListBox1.Items.Count = 0 Then
            MessageBox.Show("There are no transactions to save.", "nothing to save")
            Return
        End If

        ' show save dialog
        Using sfd As New SaveFileDialog()
            sfd.Title = "Save Transactions"
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            sfd.FileName = "transactions.txt"

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using writer As New IO.StreamWriter(sfd.FileName)
                        For Each item In ListBox1.Items
                            writer.WriteLine(item.ToString())
                        Next
                    End Using
                    MessageBox.Show("Transactions saved successfully.", "Saved")
                Catch ex As Exception
                    MessageBox.Show("Error saving file: " & ex.Message, "Error")
                End Try
            End If
        End Using
    End Sub

End Class
