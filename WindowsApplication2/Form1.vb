Imports System.Data.SqlClient
Public Class Form1
	Dim cnn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Akile ODAY\OneDrive - Eastern Mediterranean University\Desktop\bahar 2019-2020\BTEP210\ders notlari\5-veritabani bilgi girisi\WindowsApplication2(ozluk)\WindowsApplication2\Database1.mdf"";Integrated Security=True")
	Dim cmd As New SqlCommand
    Dim ds As New DataSet
	Dim da As New SqlDataAdapter
	Dim rdr As SqlDataReader
	Dim uyruk As String = ""
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
			cmd.CommandText = "select * from ozluk"
			da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            cnn.Close()
        End If
    End Sub

    Private Sub ekleButton_Click(sender As Object, e As EventArgs) Handles ekleButton.Click
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
            ds.Clear()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
			cmd.Parameters.Clear()
			If KKTCRadioButton.Checked Then
				uyruk = "KKTC"
			Else
				uyruk = "TC"
			End If
			cmd.CommandText = "insert into [ozluk](isim,yas,uyruk) values(@isim,@yas,@uyruk)"
			cmd.Parameters.Add("@isim", SqlDbType.NVarChar).Value = TextBox1.Text
			cmd.Parameters.Add("@yas", SqlDbType.NChar).Value = TextBox2.Text
			cmd.Parameters.Add("@uyruk", SqlDbType.NVarChar).Value = uyruk
			cmd.ExecuteNonQuery()
			MessageBox.Show("kayit eklendi")
            TextBox1.Clear()
			TextBox2.Clear()
			KKTCRadioButton.Checked = False
			TCRadioButton.Checked = False
			cmd.CommandText = "select * from [ozluk]"
			da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            cnn.Close()
        End If
    End Sub

	Private Sub silButton_Click(sender As Object, e As EventArgs) Handles silButton.Click
		If cnn.State = ConnectionState.Closed Then
			cnn.Open()
		End If
		ds.Clear()
		'rdr.Close()
		cmd.Connection = cnn
			cmd.CommandType = CommandType.Text
		cmd.Parameters.Clear()

		If KKTCRadioButton.Checked Then
				uyruk = "KKTC"
			Else
				uyruk = "TC"
			End If
			cmd.CommandText = "delete from [ozluk] where isim=@isim"
			cmd.Parameters.Add("@isim", SqlDbType.NVarChar).Value = TextBox1.Text

			cmd.ExecuteNonQuery()

			MessageBox.Show("kayit silindi")
			TextBox1.Clear()
			TextBox2.Clear()
			KKTCRadioButton.Checked = False
		TCRadioButton.Checked = False
		IDLabel.Text = "-"
		cmd.CommandText = "select * from [ozluk]"
			da.SelectCommand = cmd
			da.Fill(ds)
			DataGridView1.DataSource = ds.Tables(0)
			cnn.Close()

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If cnn.State = ConnectionState.Closed Then
			cnn.Open()
			cmd.Connection = cnn
			cmd.CommandType = CommandType.Text
			cmd.Parameters.Clear()
			cmd.CommandText = "select * from [ozluk] where isim=@isim"
			cmd.Parameters.Add("@isim", SqlDbType.NVarChar).Value = TextBox1.Text
			rdr = cmd.ExecuteReader()
			If rdr.HasRows Then
				rdr.Read()
				TextBox2.Text = rdr("yas")
				If (rdr("uyruk").ToString.ToUpper = "KKTC") Then
					KKTCRadioButton.Checked = True
				ElseIf (rdr("uyruk").ToString.ToUpper = "TC") Then
					TCRadioButton.Checked = True
				End If
				IDLabel.Text = rdr("Id")
			Else
				IDLabel.Text = "-"
				TextBox2.Clear()
				KKTCRadioButton.Checked = False
				TCRadioButton.Checked = False

			End If
		End If
    End Sub


	Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
		If DataGridView1.RowCount = 0 Then Return

		IDLabel.Text = DataGridView1.SelectedRows(0).Cells("Id").Value
			TextBox1.Text = DataGridView1.SelectedRows(0).Cells("isim").Value
			TextBox2.Text = DataGridView1.SelectedRows(0).Cells("yas").Value
			If (DataGridView1.SelectedRows(0).Cells("uyruk").Value.ToString.ToUpper = "KKTC") Then
				KKTCRadioButton.Checked = True
			ElseIf (DataGridView1.SelectedRows(0).Cells("uyruk").Value.ToString.ToUpper = "TC") Then
				TCRadioButton.Checked = True

			End If

	End Sub
End Class
