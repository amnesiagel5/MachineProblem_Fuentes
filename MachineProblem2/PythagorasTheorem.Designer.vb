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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblSideA = New System.Windows.Forms.Label()
        Me.lblSideB = New System.Windows.Forms.Label()
        Me.lblSideC = New System.Windows.Forms.Label()
        Me.txtSideA = New System.Windows.Forms.TextBox()
        Me.txtSideB = New System.Windows.Forms.TextBox()
        Me.btnCalcC = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDisplayC = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSideA
        '
        Me.lblSideA.AutoSize = True
        Me.lblSideA.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSideA.Location = New System.Drawing.Point(345, 132)
        Me.lblSideA.Name = "lblSideA"
        Me.lblSideA.Size = New System.Drawing.Size(43, 17)
        Me.lblSideA.TabIndex = 1
        Me.lblSideA.Text = "Side A"
        '
        'lblSideB
        '
        Me.lblSideB.AutoSize = True
        Me.lblSideB.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSideB.Location = New System.Drawing.Point(345, 181)
        Me.lblSideB.Name = "lblSideB"
        Me.lblSideB.Size = New System.Drawing.Size(43, 17)
        Me.lblSideB.TabIndex = 2
        Me.lblSideB.Text = "Side B"
        '
        'lblSideC
        '
        Me.lblSideC.AutoSize = True
        Me.lblSideC.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSideC.Location = New System.Drawing.Point(345, 235)
        Me.lblSideC.Name = "lblSideC"
        Me.lblSideC.Size = New System.Drawing.Size(40, 17)
        Me.lblSideC.TabIndex = 3
        Me.lblSideC.Text = "SideC"
        '
        'txtSideA
        '
        Me.txtSideA.Location = New System.Drawing.Point(394, 129)
        Me.txtSideA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSideA.Name = "txtSideA"
        Me.txtSideA.Size = New System.Drawing.Size(116, 24)
        Me.txtSideA.TabIndex = 5
        '
        'txtSideB
        '
        Me.txtSideB.Location = New System.Drawing.Point(394, 178)
        Me.txtSideB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSideB.Name = "txtSideB"
        Me.txtSideB.Size = New System.Drawing.Size(116, 24)
        Me.txtSideB.TabIndex = 6
        '
        'btnCalcC
        '
        Me.btnCalcC.BackColor = System.Drawing.Color.SeaShell
        Me.btnCalcC.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcC.Location = New System.Drawing.Point(278, 298)
        Me.btnCalcC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcC.Name = "btnCalcC"
        Me.btnCalcC.Size = New System.Drawing.Size(87, 30)
        Me.btnCalcC.TabIndex = 7
        Me.btnCalcC.Text = "&Calculate C"
        Me.btnCalcC.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.SeaShell
        Me.btnReset.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(394, 298)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(87, 30)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.SeaShell
        Me.btnExit.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(517, 298)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 30)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(273, 47)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(328, 19)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Pythagorean Theorem - Isosceles Triangle"
        '
        'lblDisplayC
        '
        Me.lblDisplayC.AutoSize = True
        Me.lblDisplayC.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayC.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblDisplayC.Location = New System.Drawing.Point(394, 235)
        Me.lblDisplayC.Name = "lblDisplayC"
        Me.lblDisplayC.Size = New System.Drawing.Size(114, 18)
        Me.lblDisplayC.TabIndex = 4
        Me.lblDisplayC.Text = "Display other side"
        Me.lblDisplayC.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(933, 588)
        Me.Controls.Add(Me.lblDisplayC)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalcC)
        Me.Controls.Add(Me.txtSideB)
        Me.Controls.Add(Me.txtSideA)
        Me.Controls.Add(Me.lblSideC)
        Me.Controls.Add(Me.lblSideB)
        Me.Controls.Add(Me.lblSideA)
        Me.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Pythagorean-Theorem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSideA As Label
    Friend WithEvents lblSideB As Label
    Friend WithEvents lblSideC As Label
    Friend WithEvents txtSideA As TextBox
    Friend WithEvents txtSideB As TextBox
    Friend WithEvents btnCalcC As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDisplayC As Label
End Class
