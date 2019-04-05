Imports System.Data.SqlClient

Partial Class delete
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection("Data Source=LAPTOP-C0HNTSL4;Initial Catalog=scm;Integrated Security=True")
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strquerydelete As String
        strquerydelete = "delete from student where id = '" & TextBox1.Text & "'"
        conn.Open()
        Dim cmd As New SqlCommand(strquerydelete, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Removed Successfully")
    End Sub
End Class
