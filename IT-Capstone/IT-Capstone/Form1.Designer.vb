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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
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
        PictureBox1 = New PictureBox()
        SaveButton = New Button()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        menuFile = New ToolStripMenuItem()
        menuFileSave = New ToolStripMenuItem()
        menuFileClear = New ToolStripMenuItem()
        menuFileExit = New ToolStripMenuItem()
        menuHelp = New ToolStripMenuItem()
        menuHelpHowTo = New ToolStripMenuItem()
        menuHelpAbout = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 15)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' MoneyInput
        ' 
        MoneyInput.Location = New Point(108, 37)
        MoneyInput.Margin = New Padding(2)
        MoneyInput.Name = "MoneyInput"
        MoneyInput.Size = New Size(141, 23)
        MoneyInput.TabIndex = 2
        ' 
        ' NameInput
        ' 
        NameInput.Location = New Point(108, 66)
        NameInput.Margin = New Padding(2)
        NameInput.Name = "NameInput"
        NameInput.Size = New Size(141, 23)
        NameInput.TabIndex = 3
        ' 
        ' LabelAmount
        ' 
        LabelAmount.AutoSize = True
        LabelAmount.Location = New Point(22, 38)
        LabelAmount.Margin = New Padding(2, 0, 2, 0)
        LabelAmount.Name = "LabelAmount"
        LabelAmount.Size = New Size(54, 15)
        LabelAmount.TabIndex = 4
        LabelAmount.Text = "Amount:"
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Location = New Point(22, 65)
        LabelName.Margin = New Padding(2, 0, 2, 0)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(70, 15)
        LabelName.TabIndex = 5
        LabelName.Text = "Description:"
        ' 
        ' LabelExpense
        ' 
        LabelExpense.AutoSize = True
        LabelExpense.Location = New Point(22, 268)
        LabelExpense.Margin = New Padding(2, 0, 2, 0)
        LabelExpense.Name = "LabelExpense"
        LabelExpense.Size = New Size(86, 15)
        LabelExpense.TabIndex = 6
        LabelExpense.Text = "Total Expenses:"
        ' 
        ' LabelIncome
        ' 
        LabelIncome.AutoSize = True
        LabelIncome.Location = New Point(22, 230)
        LabelIncome.Margin = New Padding(2, 0, 2, 0)
        LabelIncome.Name = "LabelIncome"
        LabelIncome.Size = New Size(79, 15)
        LabelIncome.TabIndex = 7
        LabelIncome.Text = "Total Income:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Moccasin
        GroupBox1.Controls.Add(ExpenseRadioButton)
        GroupBox1.Controls.Add(IncomeRadioButton)
        GroupBox1.ForeColor = SystemColors.ActiveCaptionText
        GroupBox1.Location = New Point(22, 131)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(236, 58)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Entry Type"
        ' 
        ' ExpenseRadioButton
        ' 
        ExpenseRadioButton.AutoSize = True
        ExpenseRadioButton.Location = New Point(134, 28)
        ExpenseRadioButton.Margin = New Padding(2)
        ExpenseRadioButton.Name = "ExpenseRadioButton"
        ExpenseRadioButton.Size = New Size(67, 19)
        ExpenseRadioButton.TabIndex = 1
        ExpenseRadioButton.TabStop = True
        ExpenseRadioButton.Text = "Expense"
        ExpenseRadioButton.UseVisualStyleBackColor = True
        ' 
        ' IncomeRadioButton
        ' 
        IncomeRadioButton.AutoSize = True
        IncomeRadioButton.Location = New Point(14, 28)
        IncomeRadioButton.Margin = New Padding(2)
        IncomeRadioButton.Name = "IncomeRadioButton"
        IncomeRadioButton.Size = New Size(65, 19)
        IncomeRadioButton.TabIndex = 0
        IncomeRadioButton.TabStop = True
        IncomeRadioButton.Text = "Income"
        IncomeRadioButton.UseVisualStyleBackColor = True
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(22, 193)
        AddButton.Margin = New Padding(2)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(236, 29)
        AddButton.TabIndex = 9
        AddButton.Text = "Add Transaction"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' LabelBalance
        ' 
        LabelBalance.AutoSize = True
        LabelBalance.Location = New Point(22, 303)
        LabelBalance.Margin = New Padding(2, 0, 2, 0)
        LabelBalance.Name = "LabelBalance"
        LabelBalance.Size = New Size(51, 15)
        LabelBalance.TabIndex = 10
        LabelBalance.Text = "Balance:"
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(310, 303)
        ClearButton.Margin = New Padding(2)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(251, 29)
        ClearButton.TabIndex = 11
        ClearButton.Text = "Clear Transactions"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' LabelCategory
        ' 
        LabelCategory.AutoSize = True
        LabelCategory.Location = New Point(22, 97)
        LabelCategory.Margin = New Padding(2, 0, 2, 0)
        LabelCategory.Name = "LabelCategory"
        LabelCategory.Size = New Size(58, 15)
        LabelCategory.TabIndex = 12
        LabelCategory.Text = "Category:"
        ' 
        ' CategoryPicker
        ' 
        CategoryPicker.FormattingEnabled = True
        CategoryPicker.Location = New Point(108, 98)
        CategoryPicker.Margin = New Padding(2)
        CategoryPicker.Name = "CategoryPicker"
        CategoryPicker.Size = New Size(141, 23)
        CategoryPicker.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(134, 232)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 14
        ' 
        ' IncomeOutput
        ' 
        IncomeOutput.AutoSize = True
        IncomeOutput.Location = New Point(117, 232)
        IncomeOutput.Margin = New Padding(2, 0, 2, 0)
        IncomeOutput.Name = "IncomeOutput"
        IncomeOutput.Size = New Size(34, 15)
        IncomeOutput.TabIndex = 15
        IncomeOutput.Text = "$0.00"
        ' 
        ' LabelList
        ' 
        LabelList.AutoSize = True
        LabelList.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LabelList.Location = New Point(310, 37)
        LabelList.Margin = New Padding(2, 0, 2, 0)
        LabelList.Name = "LabelList"
        LabelList.Size = New Size(115, 15)
        LabelList.TabIndex = 19
        LabelList.Text = "List of Transactions:"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(310, 65)
        ListBox1.Margin = New Padding(2)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(367, 169)
        ListBox1.TabIndex = 20
        ' 
        ' ExpenseOutput
        ' 
        ExpenseOutput.AutoSize = True
        ExpenseOutput.Location = New Point(117, 268)
        ExpenseOutput.Margin = New Padding(2, 0, 2, 0)
        ExpenseOutput.Name = "ExpenseOutput"
        ExpenseOutput.Size = New Size(34, 15)
        ExpenseOutput.TabIndex = 21
        ExpenseOutput.Text = "$0.00"
        ' 
        ' BalanceOutput
        ' 
        BalanceOutput.AutoSize = True
        BalanceOutput.Location = New Point(117, 303)
        BalanceOutput.Margin = New Padding(2, 0, 2, 0)
        BalanceOutput.Name = "BalanceOutput"
        BalanceOutput.Size = New Size(34, 15)
        BalanceOutput.TabIndex = 22
        BalanceOutput.Text = "$0.00"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(566, 245)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(111, 89)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' SaveButton
        ' 
        SaveButton.Location = New Point(310, 245)
        SaveButton.Margin = New Padding(2)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(251, 54)
        SaveButton.TabIndex = 24
        SaveButton.Text = "Save Transactions"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, menuFile, menuHelp})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(706, 24)
        MenuStrip1.TabIndex = 25
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(12, 20)
        ' 
        ' menuFile
        ' 
        menuFile.DropDownItems.AddRange(New ToolStripItem() {menuFileSave, menuFileClear, menuFileExit})
        menuFile.Name = "menuFile"
        menuFile.Size = New Size(37, 20)
        menuFile.Text = "File"
        ' 
        ' menuFileSave
        ' 
        menuFileSave.Name = "menuFileSave"
        menuFileSave.Size = New Size(101, 22)
        menuFileSave.Text = "Save"
        ' 
        ' menuFileClear
        ' 
        menuFileClear.Name = "menuFileClear"
        menuFileClear.Size = New Size(101, 22)
        menuFileClear.Text = "Clear"
        ' 
        ' menuFileExit
        ' 
        menuFileExit.Name = "menuFileExit"
        menuFileExit.Size = New Size(101, 22)
        menuFileExit.Text = "Exit"
        ' 
        ' menuHelp
        ' 
        menuHelp.DropDownItems.AddRange(New ToolStripItem() {menuHelpHowTo, menuHelpAbout})
        menuHelp.Name = "menuHelp"
        menuHelp.Size = New Size(44, 20)
        menuHelp.Text = "Help"
        ' 
        ' menuHelpHowTo
        ' 
        menuHelpHowTo.Name = "menuHelpHowTo"
        menuHelpHowTo.Size = New Size(180, 22)
        menuHelpHowTo.Text = "How to Use"
        ' 
        ' menuHelpAbout
        ' 
        menuHelpAbout.Name = "menuHelpAbout"
        menuHelpAbout.Size = New Size(180, 22)
        menuHelpAbout.Text = "About"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Moccasin
        ClientSize = New Size(706, 346)
        Controls.Add(SaveButton)
        Controls.Add(PictureBox1)
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
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(2)
        Name = "Form1"
        Text = "Financial Manager"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents menuFile As ToolStripMenuItem
    Friend WithEvents menuFileSave As ToolStripMenuItem
    Friend WithEvents menuFileClear As ToolStripMenuItem
    Friend WithEvents menuFileExit As ToolStripMenuItem
    Friend WithEvents menuHelp As ToolStripMenuItem
    Friend WithEvents menuHelpHowTo As ToolStripMenuItem
    Friend WithEvents menuHelpAbout As ToolStripMenuItem

End Class
