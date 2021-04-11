Imports System.Data.SqlClient
Public Class Form1
	Dim cnn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Akile ODAY\OneDrive - Eastern Mediterranean University\Desktop\bahar 2019-2020\BTEP210\ders notlari\5-veritabani bilgi girisi\WindowsApplication2(ozluk)\WindowsApplication2\Database1.mdf"";Integrated Security=True")
	Dim cmd As New SqlCommand
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select isim, yas from [ozluk]"
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
            cmd.CommandText = "insert into [ozluk](isim,yas) values(@isim,@yas)"
            cmd.Parameters.Add("@isim", SqlDbType.NVarChar).Value = TextBox1.Text
            cmd.Parameters.Add("@yas", SqlDbType.NChar).Value = TextBox2.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("kayit eklendi")
            TextBox1.Clear()
            TextBox2.Clear()
            cmd.CommandText = "select isim,yas from [ozluk]"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            cnn.Close()
        End If
    End Sub
End Class
