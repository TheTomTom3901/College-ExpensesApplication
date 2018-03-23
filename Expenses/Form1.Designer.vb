<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.IncomeLabel = New System.Windows.Forms.Label()
        Me.IncomeText = New System.Windows.Forms.TextBox()
        Me.FoodText = New System.Windows.Forms.TextBox()
        Me.FoodLabel = New System.Windows.Forms.Label()
        Me.RentText = New System.Windows.Forms.TextBox()
        Me.RentLabel = New System.Windows.Forms.Label()
        Me.TravelText = New System.Windows.Forms.TextBox()
        Me.TravelLabel = New System.Windows.Forms.Label()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TotalExpensesLabel = New System.Windows.Forms.Label()
        Me.TotalExpensesText = New System.Windows.Forms.TextBox()
        Me.RemainingText = New System.Windows.Forms.TextBox()
        Me.RemainingLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personal Expenses"
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(30, 71)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(100, 20)
        Me.NameBox.TabIndex = 1
        Me.NameBox.Text = "Enter name"
        '
        'IncomeLabel
        '
        Me.IncomeLabel.AutoSize = True
        Me.IncomeLabel.Location = New System.Drawing.Point(30, 108)
        Me.IncomeLabel.Name = "IncomeLabel"
        Me.IncomeLabel.Size = New System.Drawing.Size(74, 13)
        Me.IncomeLabel.TabIndex = 2
        Me.IncomeLabel.Text = "Yearly Income"
        '
        'IncomeText
        '
        Me.IncomeText.Location = New System.Drawing.Point(121, 105)
        Me.IncomeText.Name = "IncomeText"
        Me.IncomeText.Size = New System.Drawing.Size(100, 20)
        Me.IncomeText.TabIndex = 3
        '
        'FoodText
        '
        Me.FoodText.Location = New System.Drawing.Point(121, 138)
        Me.FoodText.Name = "FoodText"
        Me.FoodText.Size = New System.Drawing.Size(100, 20)
        Me.FoodText.TabIndex = 5
        '
        'FoodLabel
        '
        Me.FoodLabel.AutoSize = True
        Me.FoodLabel.Location = New System.Drawing.Point(30, 141)
        Me.FoodLabel.Name = "FoodLabel"
        Me.FoodLabel.Size = New System.Drawing.Size(31, 13)
        Me.FoodLabel.TabIndex = 4
        Me.FoodLabel.Text = "Food"
        '
        'RentText
        '
        Me.RentText.Location = New System.Drawing.Point(121, 174)
        Me.RentText.Name = "RentText"
        Me.RentText.Size = New System.Drawing.Size(100, 20)
        Me.RentText.TabIndex = 7
        '
        'RentLabel
        '
        Me.RentLabel.AutoSize = True
        Me.RentLabel.Location = New System.Drawing.Point(30, 177)
        Me.RentLabel.Name = "RentLabel"
        Me.RentLabel.Size = New System.Drawing.Size(30, 13)
        Me.RentLabel.TabIndex = 6
        Me.RentLabel.Text = "Rent"
        '
        'TravelText
        '
        Me.TravelText.Location = New System.Drawing.Point(121, 209)
        Me.TravelText.Name = "TravelText"
        Me.TravelText.Size = New System.Drawing.Size(100, 20)
        Me.TravelText.TabIndex = 9
        '
        'TravelLabel
        '
        Me.TravelLabel.AutoSize = True
        Me.TravelLabel.Location = New System.Drawing.Point(30, 212)
        Me.TravelLabel.Name = "TravelLabel"
        Me.TravelLabel.Size = New System.Drawing.Size(37, 13)
        Me.TravelLabel.TabIndex = 8
        Me.TravelLabel.Text = "Travel"
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(40, 329)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 10
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(121, 329)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(202, 329)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TotalExpensesLabel
        '
        Me.TotalExpensesLabel.AutoSize = True
        Me.TotalExpensesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalExpensesLabel.Location = New System.Drawing.Point(12, 243)
        Me.TotalExpensesLabel.Name = "TotalExpensesLabel"
        Me.TotalExpensesLabel.Size = New System.Drawing.Size(155, 24)
        Me.TotalExpensesLabel.TabIndex = 13
        Me.TotalExpensesLabel.Text = "Total Expenses"
        '
        'TotalExpensesText
        '
        Me.TotalExpensesText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalExpensesText.Location = New System.Drawing.Point(35, 270)
        Me.TotalExpensesText.Name = "TotalExpensesText"
        Me.TotalExpensesText.ReadOnly = True
        Me.TotalExpensesText.Size = New System.Drawing.Size(100, 29)
        Me.TotalExpensesText.TabIndex = 14
        '
        'RemainingText
        '
        Me.RemainingText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemainingText.Location = New System.Drawing.Point(189, 270)
        Me.RemainingText.Name = "RemainingText"
        Me.RemainingText.ReadOnly = True
        Me.RemainingText.Size = New System.Drawing.Size(100, 29)
        Me.RemainingText.TabIndex = 16
        '
        'RemainingLabel
        '
        Me.RemainingLabel.AutoSize = True
        Me.RemainingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemainingLabel.Location = New System.Drawing.Point(185, 242)
        Me.RemainingLabel.Name = "RemainingLabel"
        Me.RemainingLabel.Size = New System.Drawing.Size(110, 24)
        Me.RemainingLabel.TabIndex = 15
        Me.RemainingLabel.Text = "Remaining"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 379)
        Me.Controls.Add(Me.RemainingText)
        Me.Controls.Add(Me.RemainingLabel)
        Me.Controls.Add(Me.TotalExpensesText)
        Me.Controls.Add(Me.TotalExpensesLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.TravelText)
        Me.Controls.Add(Me.TravelLabel)
        Me.Controls.Add(Me.RentText)
        Me.Controls.Add(Me.RentLabel)
        Me.Controls.Add(Me.FoodText)
        Me.Controls.Add(Me.FoodLabel)
        Me.Controls.Add(Me.IncomeText)
        Me.Controls.Add(Me.IncomeLabel)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents IncomeLabel As Label
    Friend WithEvents IncomeText As TextBox
    Friend WithEvents FoodText As TextBox
    Friend WithEvents FoodLabel As Label
    Friend WithEvents RentText As TextBox
    Friend WithEvents RentLabel As Label
    Friend WithEvents TravelText As TextBox
    Friend WithEvents TravelLabel As Label
    Friend WithEvents CalcButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents TotalExpensesLabel As Label
    Friend WithEvents TotalExpensesText As TextBox
    Friend WithEvents RemainingText As TextBox
    Friend WithEvents RemainingLabel As Label
End Class
