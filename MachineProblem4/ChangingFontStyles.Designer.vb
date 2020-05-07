<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangingFontStyles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangingFontStyles))
        Me.txtWords = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.chkboxBold = New System.Windows.Forms.CheckBox()
        Me.chkboxItalic = New System.Windows.Forms.CheckBox()
        Me.chkboxUnderline = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GrpboxFontstyle = New System.Windows.Forms.GroupBox()
        Me.GrpboxFontstyle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtWords
        '
        Me.txtWords.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtWords.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWords.Location = New System.Drawing.Point(232, 111)
        Me.txtWords.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtWords.Name = "txtWords"
        Me.txtWords.Size = New System.Drawing.Size(551, 24)
        Me.txtWords.TabIndex = 1
        Me.txtWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(330, 42)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(322, 19)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Machine Problem - Changing Font Styles"
        '
        'chkboxBold
        '
        Me.chkboxBold.AutoSize = True
        Me.chkboxBold.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkboxBold.Location = New System.Drawing.Point(136, 44)
        Me.chkboxBold.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkboxBold.Name = "chkboxBold"
        Me.chkboxBold.Size = New System.Drawing.Size(52, 21)
        Me.chkboxBold.TabIndex = 3
        Me.chkboxBold.Text = "&Bold"
        Me.chkboxBold.UseVisualStyleBackColor = True
        '
        'chkboxItalic
        '
        Me.chkboxItalic.AutoSize = True
        Me.chkboxItalic.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkboxItalic.Location = New System.Drawing.Point(136, 92)
        Me.chkboxItalic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkboxItalic.Name = "chkboxItalic"
        Me.chkboxItalic.Size = New System.Drawing.Size(53, 21)
        Me.chkboxItalic.TabIndex = 4
        Me.chkboxItalic.Text = "&Italic"
        Me.chkboxItalic.UseVisualStyleBackColor = True
        '
        'chkboxUnderline
        '
        Me.chkboxUnderline.AutoSize = True
        Me.chkboxUnderline.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkboxUnderline.Location = New System.Drawing.Point(136, 141)
        Me.chkboxUnderline.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkboxUnderline.Name = "chkboxUnderline"
        Me.chkboxUnderline.Size = New System.Drawing.Size(82, 21)
        Me.chkboxUnderline.TabIndex = 5
        Me.chkboxUnderline.Text = "&Underline"
        Me.chkboxUnderline.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(335, 403)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 30)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(586, 403)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 30)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GrpboxFontstyle
        '
        Me.GrpboxFontstyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GrpboxFontstyle.Controls.Add(Me.chkboxItalic)
        Me.GrpboxFontstyle.Controls.Add(Me.chkboxUnderline)
        Me.GrpboxFontstyle.Controls.Add(Me.chkboxBold)
        Me.GrpboxFontstyle.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpboxFontstyle.Location = New System.Drawing.Point(334, 170)
        Me.GrpboxFontstyle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrpboxFontstyle.Name = "GrpboxFontstyle"
        Me.GrpboxFontstyle.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GrpboxFontstyle.Size = New System.Drawing.Size(331, 198)
        Me.GrpboxFontstyle.TabIndex = 2
        Me.GrpboxFontstyle.TabStop = False
        Me.GrpboxFontstyle.Text = "Font Styles"
        '
        'ChangingFontStyles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1000, 588)
        Me.Controls.Add(Me.GrpboxFontstyle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtWords)
        Me.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ChangingFontStyles"
        Me.Text = "Changing Font Styles"
        Me.GrpboxFontstyle.ResumeLayout(False)
        Me.GrpboxFontstyle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtWords As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents chkboxBold As CheckBox
    Friend WithEvents chkboxItalic As CheckBox
    Friend WithEvents chkboxUnderline As CheckBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GrpboxFontstyle As GroupBox
End Class
