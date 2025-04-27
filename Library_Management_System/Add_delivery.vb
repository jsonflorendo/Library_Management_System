Imports MySql.Data.MySqlClient

Public Class Fm_add_delivery

    Private Sub Fm_add_delivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_library_cb_purchase_supplier()
        Load_library_cb_donate_supplier()

        Clear_error_msg()

        Txt_purchase_book_isbn.Enabled = False
        Txt_donate_book_isbn.Enabled = False

        Panel_purchase.Visible = False
        Panel_donate.Visible = False

    End Sub

    Private Sub Rb_purchase_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_purchase.CheckedChanged

        Panel_purchase.Visible = True
        Panel_donate.Visible = False

    End Sub

    Private Sub Rb_donate_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_donate.CheckedChanged

        Panel_purchase.Visible = False
        Panel_donate.Visible = True

    End Sub

    Private Sub Cb_purchase_supplier_Click(sender As Object, e As EventArgs) Handles Cb_purchase_supplier.Click

        Cb_purchase_supplier.DroppedDown = True

    End Sub

    Private Sub Cb_purchase_supplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_purchase_supplier.KeyPress

        'No input alphanumeric
        e.Handled = True

    End Sub

    Private Sub Cb_donate_supplier_Click(sender As Object, e As EventArgs) Handles Cb_donate_supplier.Click

        Cb_donate_supplier.DroppedDown = True

    End Sub

    Private Sub Cb_donate_supplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_donate_supplier.KeyPress

        'No input alphanumeric
        e.Handled = True

    End Sub

    Public selectedButton As Button = Nothing ' Track the currently selected button

    Private Sub Btn_purchase_add_supplier_Click(sender As Object, e As EventArgs) Handles Btn_purchase_add_supplier.Click

        Fm_supplier_maintenance.Show()
        Fm_supplier_maintenance.Cb_supplier_source_type.Text = "Supplier"
        Fm_supplier_maintenance.Cb_supplier_source_type.Enabled = False
        Fm_supplier_maintenance.Btn_update.Visible = False
        Me.Enabled = False

    End Sub

    Private Sub Btn_purchase_add_supplier_MouseEnter(sender As Object, e As EventArgs) Handles Btn_purchase_add_supplier.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_purchase_add_supplier_MouseLeave(sender As Object, e As EventArgs) Handles Btn_purchase_add_supplier.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_donate_add_supplier_Click(sender As Object, e As EventArgs) Handles Btn_donate_add_supplier.Click

        Fm_supplier_maintenance.Show()
        Fm_supplier_maintenance.Cb_supplier_source_type.Text = "Donator"
        Fm_supplier_maintenance.Cb_supplier_source_type.Enabled = False
        Fm_supplier_maintenance.Btn_update.Visible = False
        Me.Enabled = False

    End Sub

    Private Sub Btn_donate_add_supplier_MouseEnter(sender As Object, e As EventArgs) Handles Btn_donate_add_supplier.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_donate_add_supplier_MouseLeave(sender As Object, e As EventArgs) Handles Btn_donate_add_supplier.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Fm_add_delivery_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        If Cb_purchase_supplier.Text = "" Or
            Txt_purchase_transaction_number.Text = "" Or
            Txt_purchase_delivered_by.Text = "" Or
            Txt_purchase_received_by.Text = "" Then

            Txt_purchase_book_isbn.Enabled = False

        Else

            Txt_purchase_book_isbn.Enabled = True

        End If

        If Cb_donate_supplier.Text = "" Or
            Txt_donate_transaction_number.Text = "" Or
            Txt_donate_delivered_by.Text = "" Or
            Txt_donate_received_by.Text = "" Or
            Txt_donate_quantity.Text = "" Then

            Txt_donate_book_isbn.Enabled = False

        Else

            Txt_donate_book_isbn.Enabled = True

        End If

    End Sub

    Private Sub Txt_purchase_book_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_purchase_book_isbn.KeyPress

        Clear_error_msg()

        If e.KeyChar = ChrW(13) Then

            If Cb_purchase_supplier.Text = "" Or
                Txt_purchase_transaction_number.Text = "" Or
                Txt_purchase_delivered_by.Text = "" Or
                Txt_purchase_received_by.Text = "" Or
                Txt_purchase_book_isbn.Text = "" Then

                ' Store TextBoxes and their corresponding Labels
                Dim textBoxes = {Txt_purchase_transaction_number, Txt_purchase_delivered_by, Txt_purchase_received_by, Txt_purchase_book_isbn}
                Dim labels = {Lbl_error_msg_1, Lbl_error_msg_2, Lbl_error_msg_3, Lbl_error_msg_4}

                ' Loop through each TextBox and validate
                For i = 0 To textBoxes.Length - 1
                    If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                        labels(i).Text = "This field is required"
                    End If
                Next

                ' Validate the ComboBox (Dropdown)
                If Cb_purchase_supplier.SelectedIndex = -1 Then
                    Lbl_error_msg.Text = "This field is required"
                End If

            Else

                Try

                    con.Open()


                    ' Search book details and display them in the TextBoxes
                    sql = "SELECT   tbl_books.isbn,
                                    tbl_books.book_name,
                                    tbl_library_category.category_name,
                                    tbl_library_author.author_name,
                                    tbl_library_publisher.publisher_name,
                                    tbl_books.publish_year,
                                    tbl_books.primary_book_id

                            FROM tbl_books

                            INNER JOIN tbl_library_category ON tbl_books.primary_category_id = tbl_library_category.primary_category_id
                            INNER JOIN tbl_library_author ON tbl_books.primary_author_id = tbl_library_author.primary_author_id
                            INNER JOIN tbl_library_publisher ON tbl_books.primary_publisher_id = tbl_library_publisher.primary_publisher_id

                            WHERE isbn = '" & Txt_purchase_book_isbn.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    If dr.Read Then

                        Dim primary_book_id = dr("primary_book_id").ToString
                        Dim isbn = dr("isbn").ToString

                        Txt_purchase_book_title.Text = dr("book_name").ToString
                        Txt_purchase_book_genre.Text = dr("category_name").ToString
                        Txt_purchase_book_author.Text = dr("author_name").ToString
                        Txt_purchase_book_publisher.Text = dr("publisher_name").ToString
                        Txt_purchase_book_publish_year.Text = dr("publish_year").ToString

                        Txt_purchase_book_isbn.Clear()

                        dr.Close()


                        ' Check if the Transaction Number, ISBN, and Date are exists on the database, if so, update quantity, if not, insert new record
                        sql = "SELECT   tbl_delivery.transaction_number,
                                        tbl_books.isbn,
                                        tbl_delivery.quantity,
                                        tbl_delivery.delivery_date,
                                        tbl_delivery.primary_delivery_id

                                FROM tbl_delivery

                                INNER JOIN tbl_books ON tbl_delivery.primary_book_id = tbl_books.primary_book_id

                                WHERE    transaction_number = '" & Txt_purchase_transaction_number.Text & "' AND
                                        isbn = '" & isbn & "' AND
                                        delivery_date = '" & Dtp_purchase_delivery_date.Value.ToString("MMMM dd, yyyy") & "'"

                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader

                        If dr.Read Then

                            Dim primary_delivery_id = dr("primary_delivery_id").ToString
                            Dim total_quantity As Integer = dr("quantity").ToString + 1

                            dr.Close()

                            sql = "UPDATE tbl_delivery
                                    SET quantity = '" & total_quantity & "'
                                    WHERE primary_delivery_id = '" & primary_delivery_id & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader

                        Else

                            dr.Close()

                            sql = "INSERT INTO tbl_delivery (transaction_number,
                                                            primary_book_id,
                                                            quantity,
                                                            delivered_by,
                                                            delivery_date,
                                                            received_by,
                                                            status)
                                    VALUE  ('" & Txt_purchase_transaction_number.Text & "',
                                            '" & primary_book_id & "',
                                            '1',
                                            '" & Txt_purchase_delivered_by.Text & "',
                                            '" & Dtp_purchase_delivery_date.Value.ToString("MMMM dd, yyyy") & "',
                                            '" & Txt_purchase_received_by.Text & "',
                                            'Purchased')"

                            cmd = New MySqlCommand(sql, con)
                            cmd.ExecuteNonQuery()

                        End If


                        ' Check book details exists on the database, if so, update quantity, else add new data on the book inventory
                        dr.Close()

                        sql = "SELECT * FROM tbl_book_inventory
                                        WHERE primary_book_id = '" & primary_book_id & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader

                        If dr.Read Then

                            Dim total_quantity As Integer = dr("quantity").ToString + 1

                            dr.Close()

                            sql = "UPDATE tbl_book_inventory
                                    SET quantity = '" & total_quantity & "',
                                        status = 'On Stock'
                                    WHERE primary_book_id = '" & primary_book_id & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader

                        Else

                            dr.Close()

                            sql = "INSERT INTO tbl_book_inventory  (primary_book_id,
                                                                    quantity,
                                                                    status)
                                    VALUE  ('" & primary_book_id & "',
                                            '1',
                                            'On Stock')"
                            cmd = New MySqlCommand(sql, con)
                            cmd.ExecuteNonQuery()

                        End If


                        con.Close()

                        Load_delivery_data_table(Fm_home_page.Txt_search_delivery.Text)

                    Else

                        con.Close()

                        Txt_purchase_book_isbn.Clear()

                        MessageBox.Show("Book details not found, click OK to add new book details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Enabled = False
                        Fm_add_books.Show()
                        Fm_add_books.Btn_update.Visible = False

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

    Private Sub Txt_donate_book_isbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_donate_book_isbn.KeyPress

        Clear_error_msg()

        If e.KeyChar = ChrW(13) Then

            If Cb_donate_supplier.Text = "" Or
                Txt_donate_transaction_number.Text = "" Or
                Txt_donate_delivered_by.Text = "" Or
                Txt_donate_received_by.Text = "" Or
                Txt_donate_book_isbn.Text = "" Or
                Txt_donate_quantity.Text = "" Then

                ' Store TextBoxes and their corresponding Labels
                Dim textBoxes = {Txt_donate_transaction_number, Txt_donate_delivered_by, Txt_donate_received_by, Txt_donate_book_isbn, Txt_donate_quantity}
                Dim labels = {Lbl_error_msg_6, Lbl_error_msg_7, Lbl_error_msg_8, Lbl_error_msg_9, Lbl_error_msg_10}

                ' Loop through each TextBox and validate
                For i = 0 To textBoxes.Length - 1
                    If String.IsNullOrWhiteSpace(textBoxes(i).Text) Then
                        labels(i).Text = "This field is required"
                    End If
                Next

                ' Validate the ComboBox (Dropdown)
                If Cb_donate_supplier.SelectedIndex = -1 Then
                    Lbl_error_msg_5.Text = "This field is required"
                End If

            Else

                Try

                    con.Open()


                    ' Search book details and display them in the TextBoxes
                    sql = "SELECT   tbl_books.isbn,
                                    tbl_books.book_name,
                                    tbl_library_category.category_name,
                                    tbl_library_author.author_name,
                                    tbl_library_publisher.publisher_name,
                                    tbl_books.publish_year,
                                    tbl_books.primary_book_id

                            FROM tbl_books

                            INNER JOIN tbl_library_category ON tbl_books.primary_category_id = tbl_library_category.primary_category_id
                            INNER JOIN tbl_library_author ON tbl_books.primary_author_id = tbl_library_author.primary_author_id
                            INNER JOIN tbl_library_publisher ON tbl_books.primary_publisher_id = tbl_library_publisher.primary_publisher_id

                            WHERE isbn = '" & Txt_donate_book_isbn.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    If dr.Read Then

                        Dim primary_book_id = dr("primary_book_id").ToString
                        Dim isbn = dr("isbn").ToString

                        Txt_donate_book_title.Text = dr("book_name").ToString
                        Txt_donate_book_genre.Text = dr("category_name").ToString
                        Txt_donate_book_author.Text = dr("author_name").ToString
                        Txt_donate_book_publisher.Text = dr("publisher_name").ToString
                        Txt_donate_book_publish_year.Text = dr("publish_year").ToString

                        Txt_donate_book_isbn.Clear()

                        dr.Close()


                        ' Check if the Transaction Number, ISBN, and Date are exists on the database, if so, update quantity, if not, insert new record
                        sql = "SELECT   tbl_delivery.transaction_number,
                                        tbl_books.isbn,
                                        tbl_delivery.quantity,
                                        tbl_delivery.delivery_date,
                                        tbl_delivery.primary_delivery_id

                                FROM tbl_delivery

                                INNER JOIN tbl_books ON tbl_delivery.primary_book_id = tbl_books.primary_book_id

                                WHERE    transaction_number = '" & Txt_donate_transaction_number.Text & "' AND
                                        isbn = '" & isbn & "' AND
                                        delivery_date = '" & Dtp_donate_delivery_date.Value.ToString("MMMM dd, yyyy") & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader

                        If dr.Read Then

                            Dim primary_delivery_id = dr("primary_delivery_id").ToString
                            Dim donate_quantity As Integer = Txt_donate_quantity.Text
                            Dim total_quantity As Integer = dr("quantity").ToString + donate_quantity

                            dr.Close()

                            sql = "UPDATE tbl_delivery
                                    SET quantity = '" & total_quantity & "'
                                    WHERE primary_delivery_id = '" & primary_delivery_id & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader

                        Else

                            dr.Close()

                            sql = "INSERT INTO tbl_delivery (transaction_number,
                                                            primary_book_id,
                                                            quantity,
                                                            delivered_by,
                                                            delivery_date,
                                                            received_by,
                                                            status)
                                    VALUE  ('" & Txt_donate_transaction_number.Text & "',
                                            '" & primary_book_id & "',
                                            '" & Txt_donate_quantity.Text & "',
                                            '" & Txt_donate_delivered_by.Text & "',
                                            '" & Dtp_donate_delivery_date.Value.ToString("MMMM dd, yyyy") & "',
                                            '" & Txt_donate_received_by.Text & "',
                                            'Donated')"
                            cmd = New MySqlCommand(sql, con)
                            cmd.ExecuteNonQuery()

                        End If


                        ' Check book details exists on the database, if so, update quantity, else add new data on the book inventory
                        dr.Close()

                        sql = "SELECT * FROM tbl_book_inventory
                                        WHERE primary_book_id = '" & primary_book_id & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader

                        If dr.Read Then

                            Dim donate_quantity As Integer = Txt_donate_quantity.Text
                            Dim total_quantity As Integer = dr("quantity").ToString + donate_quantity

                            dr.Close()

                            sql = "UPDATE tbl_book_inventory
                                    SET quantity = '" & total_quantity & "',
                                        status = 'On Stock'
                                    WHERE primary_book_id = '" & primary_book_id & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader

                        Else

                            dr.Close()

                            sql = "INSERT INTO tbl_book_inventory  (primary_book_id,
                                                                    quantity,
                                                                    status)
                                    VALUE  ('" & primary_book_id & "',
                                            '" & Txt_donate_quantity.Text & "',
                                            'On Stock')"
                            cmd = New MySqlCommand(sql, con)
                            cmd.ExecuteNonQuery()

                        End If


                        con.Close()

                        Load_delivery_data_table(Fm_home_page.Txt_search_delivery.Text)

                    Else

                        con.Close()

                        Txt_donate_book_isbn.Clear()

                        MessageBox.Show("Book details not found, click OK to add new book details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Enabled = False
                        Fm_add_books.Show()
                        Fm_add_books.Btn_update.Visible = False

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

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click



    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click

        Load_delivery_data_table(Fm_home_page.Txt_search_delivery.Text)
        Fm_home_page.Enabled = True
        Me.Close()

    End Sub

    Private Sub Txt_delivery_transaction_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_purchase_transaction_number.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_purchase_transaction_number.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_delivery_delivered_by_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_purchase_delivered_by.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_purchase_delivered_by.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_delivery_received_by_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_purchase_received_by.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_purchase_received_by.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_donate_transaction_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_donate_transaction_number.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_donate_transaction_number.TextLength >= maxLength Then
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

    Private Sub Txt_donate_delivered_by_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_donate_delivered_by.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_donate_delivered_by.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_donate_received_by_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_donate_received_by.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_donate_received_by.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_donate_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_donate_quantity.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 10 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_donate_quantity.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "0123456789" ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

End Class