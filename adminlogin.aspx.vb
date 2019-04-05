
Partial Class adminlogin
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "ADMIN" And TextBox2.Text = "ADMIN" Then
            Response.Redirect("adminhome.aspx")
        Else
            Label3.Visible = True
        End If
    End Sub
End Class
