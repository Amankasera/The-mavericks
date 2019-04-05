Imports System.Data.SqlClient

Partial Class studentdocuments
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection("Data Source=LAPTOP-C0HNTSL4;Initial Catalog=scm;Integrated Security=True")
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String
        str = "SELECT name,email,address,sslc,puc,convocation FROM student  where id='" & TextBox1.Text & "'"
        Dim cmd As New SqlCommand(str, conn)
        Dim dr As SqlDataReader
        conn.Open()
        dr = cmd.ExecuteReader
        Label2.Visible = False
        While dr.Read
            Label3.Text = dr.Item("name")
            Label4.Text = dr.Item("email")
            Label5.Text = dr.Item("address")
            Image1.ImageUrl = "images\" + dr.Item("sslc")
            Image2.ImageUrl = "images\" + dr.Item("puc")
            Image3.ImageUrl = "images\" + dr.Item("convocation")
        End While
        conn.Close()
        TextBox1.Text = ""
    End Sub
End Class
