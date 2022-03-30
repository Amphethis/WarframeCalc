<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RelicCalculatorForm
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
        Me.LblInt = New System.Windows.Forms.Label()
        Me.LblRad = New System.Windows.Forms.Label()
        Me.LblFla = New System.Windows.Forms.Label()
        Me.LblExc = New System.Windows.Forms.Label()
        Me.ChkC = New System.Windows.Forms.CheckBox()
        Me.ChkU = New System.Windows.Forms.CheckBox()
        Me.ChkR = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtChance = New System.Windows.Forms.TextBox()
        Me.NumInt = New System.Windows.Forms.NumericUpDown()
        Me.NumExc = New System.Windows.Forms.NumericUpDown()
        Me.NumFla = New System.Windows.Forms.NumericUpDown()
        Me.NumRad = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumExc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumFla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblInt
        '
        Me.LblInt.AutoSize = True
        Me.LblInt.Location = New System.Drawing.Point(40, 28)
        Me.LblInt.Name = "LblInt"
        Me.LblInt.Size = New System.Drawing.Size(34, 13)
        Me.LblInt.TabIndex = 1
        Me.LblInt.Text = "Intact"
        '
        'LblRad
        '
        Me.LblRad.AutoSize = True
        Me.LblRad.Location = New System.Drawing.Point(30, 106)
        Me.LblRad.Name = "LblRad"
        Me.LblRad.Size = New System.Drawing.Size(44, 13)
        Me.LblRad.TabIndex = 5
        Me.LblRad.Text = "Radiant"
        '
        'LblFla
        '
        Me.LblFla.AutoSize = True
        Me.LblFla.Location = New System.Drawing.Point(27, 80)
        Me.LblFla.Name = "LblFla"
        Me.LblFla.Size = New System.Drawing.Size(47, 13)
        Me.LblFla.TabIndex = 6
        Me.LblFla.Text = "Flawless"
        '
        'LblExc
        '
        Me.LblExc.AutoSize = True
        Me.LblExc.Location = New System.Drawing.Point(12, 54)
        Me.LblExc.Name = "LblExc"
        Me.LblExc.Size = New System.Drawing.Size(62, 13)
        Me.LblExc.TabIndex = 7
        Me.LblExc.Text = "Exceptional"
        '
        'ChkC
        '
        Me.ChkC.AutoSize = True
        Me.ChkC.Location = New System.Drawing.Point(133, 27)
        Me.ChkC.Name = "ChkC"
        Me.ChkC.Size = New System.Drawing.Size(67, 17)
        Me.ChkC.TabIndex = 5
        Me.ChkC.Text = "Common"
        Me.ChkC.UseVisualStyleBackColor = True
        '
        'ChkU
        '
        Me.ChkU.AutoSize = True
        Me.ChkU.Location = New System.Drawing.Point(133, 53)
        Me.ChkU.Name = "ChkU"
        Me.ChkU.Size = New System.Drawing.Size(80, 17)
        Me.ChkU.TabIndex = 6
        Me.ChkU.Text = "Uncommon"
        Me.ChkU.UseVisualStyleBackColor = True
        '
        'ChkR
        '
        Me.ChkR.AutoSize = True
        Me.ChkR.Location = New System.Drawing.Point(133, 79)
        Me.ChkR.Name = "ChkR"
        Me.ChkR.Size = New System.Drawing.Size(49, 17)
        Me.ChkR.TabIndex = 7
        Me.ChkR.Text = "Rare"
        Me.ChkR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Count"
        '
        'TxtChance
        '
        Me.TxtChance.Location = New System.Drawing.Point(133, 103)
        Me.TxtChance.Name = "TxtChance"
        Me.TxtChance.ReadOnly = True
        Me.TxtChance.Size = New System.Drawing.Size(80, 20)
        Me.TxtChance.TabIndex = 8
        '
        'NumInt
        '
        Me.NumInt.Location = New System.Drawing.Point(80, 26)
        Me.NumInt.Name = "NumInt"
        Me.NumInt.Size = New System.Drawing.Size(38, 20)
        Me.NumInt.TabIndex = 1
        '
        'NumExc
        '
        Me.NumExc.Location = New System.Drawing.Point(80, 52)
        Me.NumExc.Name = "NumExc"
        Me.NumExc.Size = New System.Drawing.Size(38, 20)
        Me.NumExc.TabIndex = 2
        '
        'NumFla
        '
        Me.NumFla.Location = New System.Drawing.Point(80, 78)
        Me.NumFla.Name = "NumFla"
        Me.NumFla.Size = New System.Drawing.Size(38, 20)
        Me.NumFla.TabIndex = 3
        '
        'NumRad
        '
        Me.NumRad.Location = New System.Drawing.Point(80, 104)
        Me.NumRad.Name = "NumRad"
        Me.NumRad.Size = New System.Drawing.Size(38, 20)
        Me.NumRad.TabIndex = 4
        '
        'RelicCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 135)
        Me.Controls.Add(Me.NumRad)
        Me.Controls.Add(Me.NumFla)
        Me.Controls.Add(Me.NumExc)
        Me.Controls.Add(Me.NumInt)
        Me.Controls.Add(Me.TxtChance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChkR)
        Me.Controls.Add(Me.ChkU)
        Me.Controls.Add(Me.ChkC)
        Me.Controls.Add(Me.LblExc)
        Me.Controls.Add(Me.LblFla)
        Me.Controls.Add(Me.LblRad)
        Me.Controls.Add(Me.LblInt)
        Me.Name = "RelicCalculatorForm"
        Me.ShowIcon = False
        Me.Text = "Relic Calculator"
        CType(Me.NumInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumExc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumFla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblInt As Label
    Friend WithEvents LblRad As Label
    Friend WithEvents LblFla As Label
    Friend WithEvents LblExc As Label
    Friend WithEvents ChkC As CheckBox
    Friend WithEvents ChkU As CheckBox
    Friend WithEvents ChkR As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtChance As TextBox
    Friend WithEvents NumInt As NumericUpDown
    Friend WithEvents NumExc As NumericUpDown
    Friend WithEvents NumFla As NumericUpDown
    Friend WithEvents NumRad As NumericUpDown
End Class
