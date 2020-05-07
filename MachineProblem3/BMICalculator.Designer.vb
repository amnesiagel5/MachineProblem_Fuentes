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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.TxtHeight = New System.Windows.Forms.TextBox()
        Me.TxtWeight = New System.Windows.Forms.TextBox()
        Me.BtnBMICalc = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.lblHUnit = New System.Windows.Forms.Label()
        Me.lblWUnit = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(297, 169)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(304, 222)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(33, 17)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "Age:"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(290, 271)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(50, 17)
        Me.lblHeight.TabIndex = 3
        Me.lblHeight.Text = "Height:"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(290, 327)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(52, 17)
        Me.lblWeight.TabIndex = 4
        Me.lblWeight.Text = "Weight:"
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtName.Location = New System.Drawing.Point(348, 165)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(245, 24)
        Me.TxtName.TabIndex = 7
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtAge.Location = New System.Drawing.Point(348, 218)
        Me.TxtAge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(245, 24)
        Me.TxtAge.TabIndex = 8
        '
        'TxtHeight
        '
        Me.TxtHeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtHeight.Location = New System.Drawing.Point(348, 271)
        Me.TxtHeight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtHeight.Name = "TxtHeight"
        Me.TxtHeight.Size = New System.Drawing.Size(245, 24)
        Me.TxtHeight.TabIndex = 9
        '
        'TxtWeight
        '
        Me.TxtWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtWeight.Location = New System.Drawing.Point(348, 323)
        Me.TxtWeight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtWeight.Name = "TxtWeight"
        Me.TxtWeight.Size = New System.Drawing.Size(245, 24)
        Me.TxtWeight.TabIndex = 10
        '
        'BtnBMICalc
        '
        Me.BtnBMICalc.Location = New System.Drawing.Point(232, 450)
        Me.BtnBMICalc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBMICalc.Name = "BtnBMICalc"
        Me.BtnBMICalc.Size = New System.Drawing.Size(124, 30)
        Me.BtnBMICalc.TabIndex = 11
        Me.BtnBMICalc.Text = "&Calculate BMI"
        Me.BtnBMICalc.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(426, 450)
        Me.BtnReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(87, 30)
        Me.BtnReset.TabIndex = 12
        Me.BtnReset.Text = "&Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(601, 450)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(87, 30)
        Me.BtnExit.TabIndex = 13
        Me.BtnExit.Text = "&Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'lblHUnit
        '
        Me.lblHUnit.AutoSize = True
        Me.lblHUnit.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHUnit.Location = New System.Drawing.Point(597, 275)
        Me.lblHUnit.Name = "lblHUnit"
        Me.lblHUnit.Size = New System.Drawing.Size(122, 17)
        Me.lblHUnit.TabIndex = 5
        Me.lblHUnit.Text = "m (153 cm = 1.53 m)"
        '
        'lblWUnit
        '
        Me.lblWUnit.AutoSize = True
        Me.lblWUnit.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWUnit.Location = New System.Drawing.Point(597, 327)
        Me.lblWUnit.Name = "lblWUnit"
        Me.lblWUnit.Size = New System.Drawing.Size(22, 17)
        Me.lblWUnit.TabIndex = 6
        Me.lblWUnit.Text = "kg"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(330, 60)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitle.Size = New System.Drawing.Size(226, 19)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Body Mass Index  Calculator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 588)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblWUnit)
        Me.Controls.Add(Me.lblHUnit)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnBMICalc)
        Me.Controls.Add(Me.TxtWeight)
        Me.Controls.Add(Me.TxtHeight)
        Me.Controls.Add(Me.TxtAge)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "BMI-Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtAge As TextBox
    Friend WithEvents TxtHeight As TextBox
    Friend WithEvents TxtWeight As TextBox
    Friend WithEvents BtnBMICalc As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents lblHUnit As Label
    Friend WithEvents lblWUnit As Label
    Friend WithEvents lblTitle As Label
End Class
