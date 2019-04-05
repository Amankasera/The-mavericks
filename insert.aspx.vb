Imports System.Data.SqlClient

Partial Class insert
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection("Data Source=LAPTOP-C0HNTSL4;Initial Catalog=scm;Integrated Security=True")

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim str As String
        str = Server.MapPath("images")
        Dim pic As String = FileUpload1.FileName
        If FileUpload1.HasFile = True Then
            str = str & "/" & FileUpload1.FileName
            FileUpload1.SaveAs(str)
        End If
        TextBox5.Text = FileUpload1.FileName
        Dim str1 As String
        str1 = Server.MapPath("images")
        Dim pic1 As String = FileUpload2.FileName
        If FileUpload2.HasFile = True Then
            str1 = str1 & "/" & FileUpload2.FileName
            FileUpload2.SaveAs(str1)
        End If
        TextBox6.Text = FileUpload2.FileName
        Dim str2 As String
        str2 = Server.MapPath("images")
        Dim pic2 As String = FileUpload3.FileName()
        If FileUpload3.HasFile = True Then
            str2 = str2 & "/" & FileUpload3.FileName
            FileUpload3.SaveAs(str2)
        End If
        TextBox7.Text = FileUpload3.FileName
        MsgBox("Uploaded successfully")

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String
        str = "insert into student Values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
        Dim cmd As New SqlCommand(str, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Record Added")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class
