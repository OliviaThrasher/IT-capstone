<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        MoneyInput = New TextBox()
        NameInput = New TextBox()
        LabelAmount = New Label()
        LabelName = New Label()
        LabelExpense = New Label()
        LabelIncome = New Label()
        GroupBox1 = New GroupBox()
        ExpenseRadioButton = New RadioButton()
        IncomeRadioButton = New RadioButton()
        AddButton = New Button()
        LabelBalance = New Label()
        ClearButton = New Button()
        LabelCategory = New Label()
        CategoryPicker = New ComboBox()
        Label3 = New Label()
        IncomeOutput = New Label()
        LabelList = New Label()
        ListBox1 = New ListBox()
        ExpenseOutput = New Label()
        BalanceOutput = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(61, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Berlin Sans FB", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(370, 35)
        Label2.TabIndex = 1
        Label2.Text = "Personal Finance Manager"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' MoneyInput
        ' 
        MoneyInput.Location = New Point(154, 62)
        MoneyInput.Name = "MoneyInput"
        MoneyInput.Size = New Size(200, 31)
        MoneyInput.TabIndex = 2
        ' 
        ' NameInput
        ' 
        NameInput.Location = New Point(154, 110)
        NameInput.Name = "NameInput"
        NameInput.Size = New Size(200, 31)
        NameInput.TabIndex = 3
        ' 
        ' LabelAmount
        ' 
        LabelAmount.AutoSize = True
        LabelAmount.Location = New Point(31, 62)
        LabelAmount.Name = "LabelAmount"
        LabelAmount.Size = New Size(81, 25)
        LabelAmount.TabIndex = 4
        LabelAmount.Text = "Amount:"
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Location = New Point(31, 108)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(106, 25)
        LabelName.TabIndex = 5
        LabelName.Text = "Description:"
        ' 
        ' LabelExpense
        ' 
        LabelExpense.AutoSize = True
        LabelExpense.Location = New Point(31, 427)
        LabelExpense.Name = "LabelExpense"
        LabelExpense.Size = New Size(130, 25)
        LabelExpense.TabIndex = 6
        LabelExpense.Text = "Total Expenses:"
        ' 
        ' LabelIncome
        ' 
        LabelIncome.AutoSize = True
        LabelIncome.Location = New Point(31, 383)
        LabelIncome.Name = "LabelIncome"
        LabelIncome.Size = New Size(117, 25)
        LabelIncome.TabIndex = 7
        LabelIncome.Text = "Total Income:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ExpenseRadioButton)
        GroupBox1.Controls.Add(IncomeRadioButton)
        GroupBox1.Location = New Point(31, 218)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(337, 97)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Entry Type"
        ' 
        ' ExpenseRadioButton
        ' 
        ExpenseRadioButton.AutoSize = True
        ExpenseRadioButton.Location = New Point(191, 47)
        ExpenseRadioButton.Name = "ExpenseRadioButton"
        ExpenseRadioButton.Size = New Size(101, 29)
        ExpenseRadioButton.TabIndex = 1
        ExpenseRadioButton.TabStop = True
        ExpenseRadioButton.Text = "Expense"
        ExpenseRadioButton.UseVisualStyleBackColor = True
        ' 
        ' IncomeRadioButton
        ' 
        IncomeRadioButton.AutoSize = True
        IncomeRadioButton.Location = New Point(20, 47)
        IncomeRadioButton.Name = "IncomeRadioButton"
        IncomeRadioButton.Size = New Size(96, 29)
        IncomeRadioButton.TabIndex = 0
        IncomeRadioButton.TabStop = True
        IncomeRadioButton.Text = "Income"
        IncomeRadioButton.UseVisualStyleBackColor = True
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(31, 322)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(337, 48)
        AddButton.TabIndex = 9
        AddButton.Text = "Add Transaction"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' LabelBalance
        ' 
        LabelBalance.AutoSize = True
        LabelBalance.Location = New Point(31, 467)
        LabelBalance.Name = "LabelBalance"
        LabelBalance.Size = New Size(75, 25)
        LabelBalance.TabIndex = 10
        LabelBalance.Text = "Balance:"
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(31, 507)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(337, 48)
        ClearButton.TabIndex = 11
        ClearButton.Text = "Clear Transactions"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' LabelCategory
        ' 
        LabelCategory.AutoSize = True
        LabelCategory.Location = New Point(31, 162)
        LabelCategory.Name = "LabelCategory"
        LabelCategory.Size = New Size(88, 25)
        LabelCategory.TabIndex = 12
        LabelCategory.Text = "Category:"
        ' 
        ' CategoryPicker
        ' 
        CategoryPicker.FormattingEnabled = True
        CategoryPicker.Location = New Point(154, 163)
        CategoryPicker.Name = "CategoryPicker"
        CategoryPicker.Size = New Size(200, 33)
        CategoryPicker.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(191, 387)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 25)
        Label3.TabIndex = 14
        ' 
        ' IncomeOutput
        ' 
        IncomeOutput.AutoSize = True
        IncomeOutput.Location = New Point(167, 387)
        IncomeOutput.Name = "IncomeOutput"
        IncomeOutput.Size = New Size(56, 25)
        IncomeOutput.TabIndex = 15
        IncomeOutput.Text = "$0.00"
        ' 
        ' LabelList
        ' 
        LabelList.AutoSize = True
        LabelList.Location = New Point(443, 62)
        LabelList.Name = "LabelList"
        LabelList.Size = New Size(165, 25)
        LabelList.TabIndex = 19
        LabelList.Text = "List of Transactions:"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(443, 108)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(523, 279)
        ListBox1.TabIndex = 20
        ' 
        ' ExpenseOutput
        ' 
        ExpenseOutput.AutoSize = True
        ExpenseOutput.Location = New Point(167, 427)
        ExpenseOutput.Name = "ExpenseOutput"
        ExpenseOutput.Size = New Size(56, 25)
        ExpenseOutput.TabIndex = 21
        ExpenseOutput.Text = "$0.00"
        ' 
        ' BalanceOutput
        ' 
        BalanceOutput.AutoSize = True
        BalanceOutput.Location = New Point(167, 467)
        BalanceOutput.Name = "BalanceOutput"
        BalanceOutput.Size = New Size(56, 25)
        BalanceOutput.TabIndex = 22
        BalanceOutput.Text = "$0.00"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(989, 595)
        Controls.Add(BalanceOutput)
        Controls.Add(ExpenseOutput)
        Controls.Add(ListBox1)
        Controls.Add(LabelList)
        Controls.Add(IncomeOutput)
        Controls.Add(Label3)
        Controls.Add(CategoryPicker)
        Controls.Add(LabelCategory)
        Controls.Add(ClearButton)
        Controls.Add(LabelBalance)
        Controls.Add(AddButton)
        Controls.Add(GroupBox1)
        Controls.Add(LabelIncome)
        Controls.Add(LabelExpense)
        Controls.Add(LabelName)
        Controls.Add(LabelAmount)
        Controls.Add(NameInput)
        Controls.Add(MoneyInput)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Financial Manager"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MoneyInput As TextBox
    Friend WithEvents NameInput As TextBox
    Friend WithEvents LabelAmount As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelExpense As Label
    Friend WithEvents LabelIncome As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ExpenseRadioButton As RadioButton
    Friend WithEvents IncomeRadioButton As RadioButton
    Friend WithEvents AddButton As Button
    Friend WithEvents LabelBalance As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents LabelCategory As Label
    Friend WithEvents CategoryPicker As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents IncomeOutput As Label
    Friend WithEvents LabelList As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ExpenseOutput As Label
    Friend WithEvents BalanceOutput As Label

End Class
