Imports MySql.Data.MySqlClient

Public Class Fm_add_books

    Private Sub Fm_add_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_library_cb_author()
        Load_library_cb_category()
        Load_library_cb_publisher()

        Clear_error_msg()

        Dtp_publish_date.Format = DateTimePickerFormat.Custom
        Dtp_publish_date.CustomFormat = "MMMM dd, yyyy"

        Dim tooltip_add_category As New ToolTip()
        tooltip_add_category.SetToolTip(Btn_add_category, "Add Category")

        Dim tooltip_add_author As New ToolTip()
        tooltip_add_author.SetToolTip(Btn_add_author, "Add Author")

        Dim tooltip_add_publisher As New ToolTip()
        tooltip_add_publisher.SetToolTip(Btn_add_publisher, "Add Publisher")

        save_Txt_isbn.Enabled = False

    End Sub

    Private Sub Fm_add_books_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        If Txt_book_name.Text = "" Or
            Cb_book_category.Text = "-Select Genre-" Or
            Txt_author.Text = "" Or
            Txt_publisher.Text = "" Then

            save_Txt_isbn.Enabled = False

        Else

            save_Txt_isbn.Enabled = True

        End If

    End Sub

    Private Sub save_Txt_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles save_Txt_isbn.KeyPress

        Clear_error_msg()

        If e.KeyChar = ChrW(13) Then

            If save_Txt_isbn.Text = "" Or
                Txt_book_name.Text = "" Or
                Cb_book_category.Text = "-Select Genre-" Or
                Txt_author.Text = "" Or
                Txt_publisher.Text = "" Then

                ' Store TextBoxes and their corresponding Labels
                Dim textBoxes As TextBox() = {save_Txt_isbn, Txt_book_name, Txt_author, Txt_publisher}
                Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_1, Lbl_error_msg_3, Lbl_error_msg_4}

                ' Loop through each TextBox and validate
                For i As Integer = 0 To textBoxes.Length - 1
                    If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                        labels(i).Text = "This field is required"
                    End If
                Next

                ' Validate the ComboBox (Dropdown)
                If Cb_book_category.SelectedIndex = -1 Then
                    Lbl_error_msg_2.Text = "This field is required"
                End If

            ElseIf Txt_primary_author_id.Text = "" Or Txt_primary_publisher_id.Text = "" Then

                If Txt_primary_author_id.Text = "" Then
                    Lbl_error_msg_3.Text = "Invalid Author Name"
                End If

                If Txt_primary_author_id.Text = "" Then
                    Lbl_error_msg_4.Text = "Invalid Publisher Name"
                End If

            Else

                Try

                    con.Open()

                    sql = "SELECT * FROM tbl_books
                                    WHERE isbn = '" & save_Txt_isbn.Text & "' AND book_name = '" & Txt_book_name.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    If dr.Read Then

                        Lbl_error_msg.Text = "ISBN already exists"
                        Lbl_error_msg_1.Text = "Book name already exists"

                    Else

                        dr.Close()

                        sql = "INSERT INTO tbl_books (isbn,
                                                        book_name,
                                                        primary_category_id,
                                                        primary_author_id,
                                                        primary_publisher_id,
                                                        publish_year)
                                        VALUE ('" & save_Txt_isbn.Text & "',
                                                '" & Txt_book_name.Text & "',
                                                '" & Txt_primary_category_id.Text & "',                                            
                                                '" & Txt_primary_author_id.Text & "',
                                                '" & Txt_primary_publisher_id.Text & "',
                                                '" & Dtp_publish_date.Value.ToString("MMMM dd, yyyy") & "')"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        con.Close()

                        MessageBox.Show(Txt_book_name.Text + " added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        If Fm_home_page.Enabled = False And Fm_add_delivery.Enabled = False Then

                            Fm_add_delivery.Enabled = True

                        ElseIf Fm_home_page.Enabled = False And Fm_add_book_inventory.Enabled = False Then

                            Fm_add_book_inventory.Enabled = True

                        Else

                            Load_listed_books_data_table(Fm_home_page.Txt_listed_books_search.Text)
                            Fm_home_page.Enabled = True

                        End If

                        Me.Close()


                    End If

                Catch ex As Exception

                    MsgBox("Error: " & ex.Message)

                Finally

                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If

                End Try

            End If

        End If

    End Sub

    Private Sub Load_update_books_function()

        If update_Txt_isbn.Text = "" Or
               Txt_book_name.Text = "" Or
               Cb_book_category.Text = "-Select Genre-" Or
               Txt_author.Text = "" Or
               Txt_publisher.Text = "" Then

            ' Store TextBoxes and their corresponding Labels
            Dim textBoxes As TextBox() = {update_Txt_isbn, Txt_book_name, Txt_author, Txt_publisher}
            Dim labels As Label() = {Lbl_error_msg, Lbl_error_msg_1, Lbl_error_msg_3, Lbl_error_msg_4}

            ' Loop through each TextBox and validate
            For i As Integer = 0 To textBoxes.Length - 1
                If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                    labels(i).Text = "This field is required"
                End If
            Next

            ' Validate the ComboBox (Dropdown)
            If Cb_book_category.SelectedIndex = -1 Then
                Lbl_error_msg_2.Text = "This field is required"
            End If

        ElseIf Txt_primary_author_id.Text = "" Or Txt_primary_publisher_id.Text = "" Then

            If Txt_primary_author_id.Text = "" Then
                Lbl_error_msg_3.Text = "Invalid Author Name"
            End If

            If Txt_primary_author_id.Text = "" Then
                Lbl_error_msg_4.Text = "Invalid Publisher Name"
            End If

        Else

            Try

                con.Open()

                Dim primary_book_id As String = Fm_home_page.Lv_listed_books.SelectedItems(0).SubItems(6).Text
                Dim isbn As String = Fm_home_page.Lv_listed_books.SelectedItems(0).Text
                Dim book_name As String = Fm_home_page.Lv_listed_books.SelectedItems(0).SubItems(1).Text

                'to make sure ISBN and Book Name are not exists while in update process
                sql = "UPDATE tbl_books SET 
                                  isbn = '" & "" & "',
                                  book_name = '" & "" & "'
                           WHERE primary_book_id = '" & primary_book_id & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                dr.Close()
                '---------------------------------

                sql = "SELECT * FROM tbl_books
                                WHERE isbn = '" & update_Txt_isbn.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader

                If dr.Read Then

                    dr.Close()

                    Lbl_error_msg.Text = "ISBN already exists"
                    Lbl_error_msg_1.Text = "Book name already exists"

                    'returned previous ISBN and Book Name
                    sql = "UPDATE tbl_books SET 
                                  isbn = '" & isbn & "',
                                  book_name = '" & book_name & "'
                           WHERE primary_book_id = '" & primary_book_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader
                    con.Close()
                    '---------------------------------

                Else

                    dr.Close()

                    sql = "UPDATE tbl_books SET
                                    isbn = '" & update_Txt_isbn.Text & "',
                                    book_name = '" & Txt_book_name.Text & "',
                                    primary_category_id = '" & Txt_primary_category_id.Text & "',
                                    primary_author_id = '" & Txt_primary_author_id.Text & "',
                                    primary_publisher_id = '" & Txt_primary_publisher_id.Text & "',
                                    publish_year = '" & Dtp_publish_date.Value.ToString("MMMM dd, yyyy") & "'
                            WHERE primary_book_id = '" & primary_book_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    MessageBox.Show(Txt_book_name.Text + " updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_listed_books_data_table(Fm_home_page.Txt_listed_books_search.Text)
                    Fm_home_page.Enabled = True
                    Me.Close()

                End If

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        End If

    End Sub

    Private Sub update_Txt_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles update_Txt_isbn.KeyPress

        Clear_error_msg()

        If e.KeyChar = ChrW(13) Then

            Load_update_books_function()

        End If

    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click

        Clear_error_msg()

        Load_update_books_function()

    End Sub

    Private Sub Btn_exit_Click(sender As Object, e As EventArgs) Handles Btn_exit.Click

        If Fm_home_page.Enabled = False And Fm_add_delivery.Enabled = False Then

            Fm_add_delivery.Enabled = True

        ElseIf Fm_home_page.Enabled = False And Fm_add_book_inventory.Enabled = False Then

            Fm_add_book_inventory.Enabled = True

        Else

            Load_listed_books_data_table(Fm_home_page.Txt_listed_books_search.Text)
            Fm_home_page.Enabled = True

        End If

        Me.Close()

    End Sub

    Private Sub Cb_book_category_Click(sender As Object, e As EventArgs) Handles Cb_book_category.Click

        Cb_book_category.DroppedDown = True

    End Sub

    Private Sub Txt_author_Click(sender As Object, e As EventArgs) Handles Txt_author.Click

        Cb_author.DroppedDown = True

    End Sub

    Private Sub Txt_publisher_Click(sender As Object, e As EventArgs) Handles Txt_publisher.Click

        Cb_publisher.DroppedDown = True

    End Sub

    Private Sub Cb_author_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_author.SelectedIndexChanged

        Txt_author.Text = Cb_author.Text

    End Sub

    Private Sub Cb_publisher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_publisher.SelectedIndexChanged

        Txt_publisher.Text = Cb_publisher.Text

    End Sub

    Private Sub Cb_book_category_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_book_category.KeyPress

        'No input alphanumeric
        e.Handled = True

    End Sub

    Private Sub Cb_book_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_book_category.SelectedIndexChanged

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_category
                            WHERE category_name = '" & Cb_book_category.SelectedItem & "'
                            ORDER BY category_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            If dr.Read() Then

                Txt_primary_category_id.Text = dr("primary_category_id").ToString()

            End If

            con.Close()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Txt_author_TextChanged(sender As Object, e As EventArgs) Handles Txt_author.TextChanged

        If Txt_author.Text = "" Then

            Load_library_cb_author()
            Cb_author.Items.Add(Txt_author.Text)
            Txt_primary_author_id.Clear()

        Else

            Try

                con.Open()

                sql = "SELECT * FROM tbl_library_author
                                WHERE author_name LIKE '%" & Txt_author.Text & "%'
                                ORDER BY author_name ASC"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                Cb_author.Items.Clear()

                If dr.Read() Then

                    Cb_author.Items.Add(dr("author_name").ToString())
                    Txt_primary_author_id.Text = dr("primary_author_id").ToString()

                Else

                    Cb_author.Items.Add(Txt_author.Text)
                    Txt_primary_author_id.Clear()

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

    Private Sub Txt_publisher_TextChanged(sender As Object, e As EventArgs) Handles Txt_publisher.TextChanged

        If Txt_publisher.Text = "" Then

            Load_library_cb_publisher()
            Cb_publisher.Items.Add(Txt_publisher.Text)
            Txt_primary_publisher_id.Clear()

        Else

            Try

                con.Open()

                sql = "SELECT * FROM tbl_library_publisher
                                WHERE publisher_name LIKE '%" & Txt_publisher.Text & "%'
                                ORDER BY publisher_name ASC"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                Cb_publisher.Items.Clear()

                If dr.Read() Then

                    Cb_publisher.Items.Add(dr("publisher_name").ToString())
                    Txt_primary_publisher_id.Text = dr("primary_publisher_id").ToString()

                Else

                    Cb_publisher.Items.Add(Txt_publisher.Text)
                    Txt_primary_publisher_id.Clear()

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

    Private Sub Txt_book_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_book_name.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_book_name.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_author_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_author.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_author.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_publisher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_publisher.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_publisher.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Public selectedButton As Button = Nothing ' Track the currently selected button

    Private Sub Btn_add_category_Click(sender As Object, e As EventArgs) Handles Btn_add_category.Click

        Fm_add_category.Show()
        Fm_add_category.Btn_update.Visible = False
        Me.Enabled = False

    End Sub

    Private Sub Btn_add_category_MouseEnter(sender As Object, e As EventArgs) Handles Btn_add_category.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_add_category_MouseLeave(sender As Object, e As EventArgs) Handles Btn_add_category.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_add_author_Click(sender As Object, e As EventArgs) Handles Btn_add_author.Click

        Fm_add_author.Show()
        Fm_add_author.Btn_update.Visible = False
        Me.Enabled = False

    End Sub

    Private Sub Btn_add_author_MouseEnter(sender As Object, e As EventArgs) Handles Btn_add_author.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_add_author_MouseLeave(sender As Object, e As EventArgs) Handles Btn_add_author.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_add_publisher_Click(sender As Object, e As EventArgs) Handles Btn_add_publisher.Click

        Fm_publisher.Show()
        Fm_publisher.Btn_update.Visible = False
        Me.Enabled = False

    End Sub

    Private Sub Btn_add_publisher_MouseEnter(sender As Object, e As EventArgs) Handles Btn_add_publisher.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_add_publisher_MouseLeave(sender As Object, e As EventArgs) Handles Btn_add_publisher.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

End Class