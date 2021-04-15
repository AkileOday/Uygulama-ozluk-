Imports System.Data.SqlClient
Public Class Form2
	Dim cnn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Akile ODAY\OneDrive - Eastern Mediterranean University\Desktop\bahar 2019-2020\BTEP210\ders notlari\5-veritabani bilgi girisi\WindowsApplication2(ozluk)\WindowsApplication2\Database1.mdf"";Integrated Security=True")
	Dim cmd As New SqlCommand
	Dim da As New SqlDataAdapter
	Dim rdr As SqlDataReader
	Dim deger As String

	Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
		If cnn.State = ConnectionState.Closed Then
			cnn.Open()
			cmd.Connection = cnn
			cmd.CommandType = CommandType.Text
			cmd.Parameters.Clear()
			cmd.CommandText = "select * from sifre where kadi=@kadi and sifre=@sifre"
			cmd.Parameters.Add("@kadi", SqlDbType.NVarChar).Value = kadiTextBox.Text
			cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = sifreTextBox.Text
			rdr = cmd.ExecuteReader
			If rdr.HasRows() Then
				MsgBox("sifre dogru")
				cnn.Close()
				Form1.Show()
			Else
				MsgBox("sifre yanlis")
			End If
		End If
	End Sub
End Class