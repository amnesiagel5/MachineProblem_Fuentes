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
        Me.lblCaption1 = New System.Windows.Forms.Label()
        Me.lblCaption2 = New System.Windows.Forms.Label()
        Me.lblCaption3 = New System.Windows.Forms.Label()
        Me.lblCaption4 = New System.Windows.Forms.Label()
        Me.lblCaption5 = New System.Windows.Forms.Label()
        Me.lblCaption6 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
        Me.lblDisplaySum = New System.Windows.Forms.Label()
        Me.lblDisplayDif = New System.Windows.Forms.Label()
        Me.lblDisplayProd = New System.Windows.Forms.Label()
        Me.lblDisplayQuo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCaption1
        '
        Me.lblCaption1.AutoSize = True
        Me.lblCaption1.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption1.Location = New System.Drawing.Point(341, 128)
        Me.lblCaption1.Name = "lblCaption1"
        Me.lblCaption1.Size = New System.Drawing.Size(101, 17)
        Me.lblCaption1.TabIndex = 1
        Me.lblCaption1.Text = "Enter a number: "
        '
        'lblCaption2
        '
        Me.lblCaption2.AutoSize = True
        Me.lblCaption2.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption2.Location = New System.Drawing.Point(307, 184)
        Me.lblCaption2.Name = "lblCaption2"
        Me.lblCaption2.Size = New System.Drawing.Size(135, 17)
        Me.lblCaption2.TabIndex = 2
        Me.lblCaption2.Text = "Enter another number:"
        '
        'lblCaption3
        '
        Me.lblCaption3.AutoSize = True
        Me.lblCaption3.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption3.Location = New System.Drawing.Point(194, 302)
        Me.lblCaption3.Name = "lblCaption3"
        Me.lblCaption3.Size = New System.Drawing.Size(34, 17)
        Me.lblCaption3.TabIndex = 3
        Me.lblCaption3.Text = "Sum"
        '
        'lblCaption4
        '
        Me.lblCaption4.AutoSize = True
        Me.lblCaption4.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption4.Location = New System.Drawing.Point(355, 302)
        Me.lblCaption4.Name = "lblCaption4"
        Me.lblCaption4.Size = New System.Drawing.Size(69, 17)
        Me.lblCaption4.TabIndex = 4
        Me.lblCaption4.Text = "Difference"
        '
        'lblCaption5
        '
        Me.lblCaption5.AutoSize = True
        Me.lblCaption5.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption5.Location = New System.Drawing.Point(513, 302)
        Me.lblCaption5.Name = "lblCaption5"
        Me.lblCaption5.Size = New System.Drawing.Size(53, 17)
        Me.lblCaption5.TabIndex = 5
        Me.lblCaption5.Text = "Product"
        '
        'lblCaption6
        '
        Me.lblCaption6.AutoSize = True
        Me.lblCaption6.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption6.Location = New System.Drawing.Point(679, 302)
        Me.lblCaption6.Name = "lblCaption6"
        Me.lblCaption6.Size = New System.Drawing.Size(60, 17)
        Me.lblCaption6.TabIndex = 6
        Me.lblCaption6.Text = "Quotient"
        '
        'txtNum
        '
        Me.txtNum.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtNum.Location = New System.Drawing.Point(448, 125)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(116, 24)
        Me.txtNum.TabIndex = 11
        '
        'txtNum1
        '
        Me.txtNum1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtNum1.Location = New System.Drawing.Point(448, 181)
        Me.txtNum1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(116, 24)
        Me.txtNum1.TabIndex = 12
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(247, 442)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(71, 36)
        Me.btnCalc.TabIndex = 13
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(411, 442)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(71, 36)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(567, 442)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(71, 36)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(324, 40)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(241, 25)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Basic Math Operations"
        '
        'lblDisplaySum
        '
        Me.lblDisplaySum.AutoSize = True
        Me.lblDisplaySum.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblDisplaySum.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDisplaySum.Location = New System.Drawing.Point(194, 330)
        Me.lblDisplaySum.Name = "lblDisplaySum"
        Me.lblDisplaySum.Size = New System.Drawing.Size(48, 17)
        Me.lblDisplaySum.TabIndex = 7
        Me.lblDisplaySum.Text = "________"
        '
        'lblDisplayDif
        '
        Me.lblDisplayDif.AutoSize = True
        Me.lblDisplayDif.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblDisplayDif.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDisplayDif.Location = New System.Drawing.Point(369, 330)
        Me.lblDisplayDif.Name = "lblDisplayDif"
        Me.lblDisplayDif.Size = New System.Drawing.Size(48, 17)
        Me.lblDisplayDif.TabIndex = 8
        Me.lblDisplayDif.Text = "________"
        '
        'lblDisplayProd
        '
        Me.lblDisplayProd.AutoSize = True
        Me.lblDisplayProd.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblDisplayProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDisplayProd.Location = New System.Drawing.Point(520, 330)
        Me.lblDisplayProd.Name = "lblDisplayProd"
        Me.lblDisplayProd.Size = New System.Drawing.Size(48, 17)
        Me.lblDisplayProd.TabIndex = 9
        Me.lblDisplayProd.Text = "________"
        '
        'lblDisplayQuo
        '
        Me.lblDisplayQuo.AutoSize = True
        Me.lblDisplayQuo.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblDisplayQuo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDisplayQuo.Location = New System.Drawing.Point(686, 330)
        Me.lblDisplayQuo.Name = "lblDisplayQuo"
        Me.lblDisplayQuo.Size = New System.Drawing.Size(48, 17)
        Me.lblDisplayQuo.TabIndex = 10
        Me.lblDisplayQuo.Text = "________"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(904, 508)
        Me.Controls.Add(Me.lblDisplayQuo)
        Me.Controls.Add(Me.lblDisplayProd)
        Me.Controls.Add(Me.lblDisplayDif)
        Me.Controls.Add(Me.lblDisplaySum)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblCaption6)
        Me.Controls.Add(Me.lblCaption5)
        Me.Controls.Add(Me.lblCaption4)
        Me.Controls.Add(Me.lblCaption3)
        Me.Controls.Add(Me.lblCaption2)
        Me.Controls.Add(Me.lblCaption1)
        Me.Font = New System.Drawing.Font("Open Sans Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Operations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCaption1 As Label
    Friend WithEvents lblCaption2 As Label
    Friend WithEvents lblCaption3 As Label
    Friend WithEvents lblCaption4 As Label
    Friend WithEvents lblCaption5 As Label
    Friend WithEvents lblCaption6 As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label As Label
    Friend WithEvents lblDisplaySum As Label
    Friend WithEvents lblDisplayDif As Label
    Friend WithEvents lblDisplayProd As Label
    Friend WithEvents lblDisplayQuo As Label
End Class
