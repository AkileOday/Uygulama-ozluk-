<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.kadiTextBox = New System.Windows.Forms.TextBox()
		Me.sifreTextBox = New System.Windows.Forms.TextBox()
		Me.OKButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(47, 48)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(111, 20)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Kullanici Adi:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(93, 104)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(52, 20)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Sifre:"
		'
		'kadiTextBox
		'
		Me.kadiTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.kadiTextBox.Location = New System.Drawing.Point(164, 45)
		Me.kadiTextBox.Name = "kadiTextBox"
		Me.kadiTextBox.Size = New System.Drawing.Size(100, 26)
		Me.kadiTextBox.TabIndex = 2
		'
		'sifreTextBox
		'
		Me.sifreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sifreTextBox.Location = New System.Drawing.Point(164, 101)
		Me.sifreTextBox.Name = "sifreTextBox"
		Me.sifreTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.sifreTextBox.Size = New System.Drawing.Size(100, 26)
		Me.sifreTextBox.TabIndex = 3
		'
		'OKButton
		'
		Me.OKButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.OKButton.Location = New System.Drawing.Point(97, 188)
		Me.OKButton.Name = "OKButton"
		Me.OKButton.Size = New System.Drawing.Size(87, 28)
		Me.OKButton.TabIndex = 4
		Me.OKButton.Text = "OK"
		Me.OKButton.UseVisualStyleBackColor = True
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 261)
		Me.Controls.Add(Me.OKButton)
		Me.Controls.Add(Me.sifreTextBox)
		Me.Controls.Add(Me.kadiTextBox)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form2"
		Me.Text = "Form2"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents kadiTextBox As TextBox
	Friend WithEvents sifreTextBox As TextBox
	Friend WithEvents OKButton As Button
End Class
