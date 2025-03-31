Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class Fm_login

    Public selectedButton As Button = Nothing ' Track the currently selected button

    Private Sub Fm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_error_msg()

        RoundCorners(Me)
        Connection()
        Txt_password.UseSystemPasswordChar = True

    End Sub

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click

        If Txt_username.Text = "" And Txt_password.Text = "" Then

            Lbl_error_msg_1.Text = ""
            Lbl_error_msg.Text = "Please input your Username and Password"

        ElseIf Txt_username.Text = "" Then

            Lbl_error_msg.Text = ""
            Lbl_error_msg_1.Text = "Please input your username"

        ElseIf Txt_password.Text = "" Then

            Lbl_error_msg_1.Text = ""
            Lbl_error_msg.Text = "Please input your password"

        Else

            Try

                con.Open()

                sql = "SELECT * FROM tbl_admin
                                WHERE username = '" & Txt_username.Text & "'
                                AND password = '" & Txt_password.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                If dr.Read() = True Then

                    Dim name As String = dr("first_name") + " " + dr("last_name")
                    Dim user_type As String = dr("user_type")

                    If dr("user_type") = "ASSISTANT LIBRARIAN" Then

                        Fm_home_page.Show()
                        Fm_home_page.Lbl_name_logged_in.Text = name
                        Fm_home_page.Lbl_user_type_logged_in.Text = user_type
                        Clear_login_fields()
                        Clear_error_msg()
                        Me.Hide()

                    Else

                        Fm_home_page.Show()
                        Fm_home_page.Lbl_name_logged_in.Text = name
                        Fm_home_page.Lbl_user_type_logged_in.Text = user_type
                        Fm_home_page.Btn_listed_accounts.Visible = False
                        Fm_home_page.Btn_author_category_penalty_publisher_maintenance.Visible = False
                        Fm_home_page.Btn_supplier_maintenance.Visible = False
                        Clear_login_fields()
                        Clear_error_msg()
                        Me.Hide()

                    End If

                Else

                    Lbl_error_msg_1.Text = ""
                    Lbl_error_msg.Text = "Incorrect username or password"
                    Clear_login_fields()

                End If

                con.Close()

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        End If

    End Sub

    Private Sub Btn_login_MouseEnter(sender As Object, e As EventArgs) Handles Btn_login.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_login_MouseLeave(sender As Object, e As EventArgs) Handles Btn_login.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Gainsboro
        End If

    End Sub

    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles Btn_close.Click

        Me.Close()

    End Sub

    Private Sub Btn_close_MouseEnter(sender As Object, e As EventArgs) Handles Btn_close.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_close_MouseLeave(sender As Object, e As EventArgs) Handles Btn_close.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Gainsboro
        End If

    End Sub

    Private Sub Cb_show_password_CheckedChanged(sender As Object, e As EventArgs) Handles Cb_show_password.CheckedChanged

        If Cb_show_password.Checked = True Then

            Txt_password.UseSystemPasswordChar = False

        Else

            Txt_password.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub Txt_username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_username.KeyPress

        Load_login(e)


        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_username.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789~@#$%^&*()_-=+'<>,.?/""" ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_password.KeyPress

        Load_login(e)


        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_password.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789~@#$%^&*()_-=+'<>,.?/""" ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

        'Panel1.BackColor = Color.FromArgb(232, 224, 221)
        Dim panel = DirectCast(sender, Panel)
        Dim cornerRadius = 20 ' You can adjust the corner radius as needed

        ' Draw the background of the panel
        Using brush As New SolidBrush(panel.BackColor)
            e.Graphics.FillRectangle(brush, panel.ClientRectangle)
        End Using

        ' Draw the rounded corners
        Using path As New Drawing2D.GraphicsPath
            path.AddArc(New Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180, 90)
            path.AddArc(New Rectangle(panel.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2), 270, 90)
            path.AddArc(New Rectangle(panel.Width - cornerRadius * 2, panel.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 0, 90)
            path.AddArc(New Rectangle(0, panel.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 90, 90)
            path.CloseFigure()

            panel.Region = New Region(path)
        End Using

    End Sub

End Class
