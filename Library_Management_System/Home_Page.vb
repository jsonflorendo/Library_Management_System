Imports MySql.Data.MySqlClient

Public Class Fm_home_page

    Private Sub Fm_home_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connection()

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel6_Supplier.Visible = False
        Panel10_Author_Category_Penalty_Publisher.Visible = False
        Panel12_Shelf.Visible = False
        Panel13_Delivery.Visible = False
        Panel14_Book_Inventory.Visible = False

        Load_library_cb_category()

    End Sub

    Private Sub Tmr_home_page_date_time_Tick(sender As Object, e As EventArgs) Handles Tmr_home_page_date_time.Tick

        Lbl_date_time.Text = Date.Now.ToString("MMMM dd, yyyy | h:mm:ss tt")

    End Sub

    Public selectedButton As Button = Nothing ' Track the currently selected button

    Private Sub Btn_listed_books_Click(sender As Object, e As EventArgs) Handles Btn_listed_books.Click

        Panel1_Books.Visible = True
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel6_Supplier.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel10_Author_Category_Penalty_Publisher.Visible = False
        Panel12_Shelf.Visible = False
        Panel13_Delivery.Visible = False
        Panel14_Book_Inventory.Visible = False

        Load_all_data_tables() 'To load data tables and remove items selection on the listview

        Dim btn = DirectCast(sender, Button)

        ' Reset the previously selected button's color
        If selectedButton IsNot Nothing Then
            selectedButton.BackColor = Color.Sienna
        End If

        ' Set the new selected button and change its color
        btn.BackColor = Color.RoyalBlue
        selectedButton = btn

    End Sub

    Private Sub Btn_listed_books_MouseEnter(sender As Object, e As EventArgs) Handles Btn_listed_books.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_listed_books_MouseLeave(sender As Object, e As EventArgs) Handles Btn_listed_books.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Sienna
        End If

    End Sub

    Private Sub Btn_returned_books_Click(sender As Object, e As EventArgs) Handles Btn_returned_books.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = True
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel6_Supplier.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel10_Author_Category_Penalty_Publisher.Visible = False
        Panel12_Shelf.Visible = False
        Panel13_Delivery.Visible = False
        Panel14_Book_Inventory.Visible = False

        Load_all_data_tables() 'To load data tables and remove items selection on the listview

        Dim btn = DirectCast(sender, Button)

        ' Reset the previously selected button's color
        If selectedButton IsNot Nothing Then
            selectedButton.BackColor = Color.Sienna
        End If

        ' Set the new selected button and change its color
        btn.BackColor = Color.RoyalBlue
        selectedButton = btn

    End Sub

    Private Sub Btn_returned_books_MouseEnter(sender As Object, e As EventArgs) Handles Btn_returned_books.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_returned_books_MouseLeave(sender As Object, e As EventArgs) Handles Btn_returned_books.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Sienna
        End If

    End Sub

    Private Sub Btn_student_information_Click(sender As Object, e As EventArgs) Handles Btn_student_information.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = True
        Panel4_User_Acounts.Visible = False
        Panel6_Supplier.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel10_Author_Category_Penalty_Publisher.Visible = False
        Panel12_Shelf.Visible = False
        Panel13_Delivery.Visible = False
        Panel14_Book_Inventory.Visible = False

        Load_all_data_tables() 'To load data tables and remove items selection on the listview

        Dim btn As Button = DirectCast(sender, Button)

        ' Reset the previously selected button's color
        If selectedButton IsNot Nothing Then
            selectedButton.BackColor = Color.Sienna
        End If

        ' Set the new selected button and change its color
        btn.BackColor = Color.RoyalBlue
        selectedButton = btn

    End Sub

    Private Sub Btn_student_information_MouseEnter(sender As Object, e As EventArgs) Handles Btn_student_information.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_student_information_MouseLeave(sender As Object, e As EventArgs) Handles Btn_student_information.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Sienna
        End If

    End Sub

    Private Sub Btn_penalty_report_Click(sender As Object, e As EventArgs) Handles Btn_penalty_report.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel6_Supplier.Visible = False
        Panel8_Penalty_Report.Visible = True
        Panel10_Author_Category_Penalty_Publisher.Visible = False
        Panel12_Shelf.Visible = False
        Panel13_Delivery.Visible = False
        Panel14_Book_Inventory.Visible = False

        Load_all_data_tables() 'To load data tables and remove items selection on the listview

        Dim btn = DirectCast(sender, Button)

        ' Reset the previously selected button's color
        If selectedButton IsNot Nothing Then
            selectedButton.BackColor = Color.Sienna
        End If

        ' Set the new selected button and change its color
        btn.BackColor = Color.RoyalBlue
        selectedButton = btn

    End Sub

    Private Sub Btn_penalty_report_MouseEnter(sender As Object, e As EventArgs) Handles Btn_penalty_report.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_penalty_report_MouseLeave(sender As Object, e As EventArgs) Handles Btn_penalty_report.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Sienna
        End If

    End Sub

    Private Sub Btn_listed_accounts_Click(sender As Object, e As EventArgs) Handles Btn_listed_accounts.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = True
        Panel6_Supplier.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel10_Author_Category_Penalty_Publisher.Visible = False
        Panel12_Shelf.Visible = False
        Panel13_Delivery.Visible = False
        Panel14_Book_Inventory.Visible = False

        Load_all_data_tables() 'To load data tables and remove items selection on the listview

        Dim btn = DirectCast(sender, Button)

        ' Reset the previously selected button's color
        If selectedButton IsNot Nothing Then
            selectedButton.BackColor = Color.Sienna
        End If

        ' Set the new selected button and change its color
        btn.BackColor = Color.RoyalBlue
        selectedButton = btn

    End Sub

    Private Sub Btn_listed_accounts_MouseEnter(sender As Object, e As EventArgs) Handles Btn_listed_accounts.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_listed_accounts_MouseLeave(sender As Object, e As EventArgs) Handles Btn_listed_accounts.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Sienna
        End If

    End Sub

    Private Sub Btn_supplier_maintenance_Click(sender As Object, e As EventArgs) Handles Btn_supplier_maintenance.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel6_Supplier.Visible = True
        Panel8_Penalty_Report.Visible = False
        Panel10_Author_Category_Penalty_Publisher.Visible = False
        Panel12_Shelf.Visible = False
        Panel13_Delivery.Visible = False
        Panel14_Book_Inventory.Visible = False

        Load_all_data_tables() 'To load data tables and remove items selection on the listview

        Dim btn As Button = DirectCast(sender, Button)

        ' Reset the previously selected button's color
        If selectedButton IsNot Nothing Then
            selectedButton.BackColor = Color.Sienna
        End If

        ' Set the new selected button and change its color
        btn.BackColor = Color.RoyalBlue
        selectedButton = btn

    End Sub

    Private Sub Btn_supplier_maintenance_MouseEnter(sender As Object, e As EventArgs) Handles Btn_supplier_maintenance.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_supplier_maintenance_MouseLeave(sender As Object, e As EventArgs) Handles Btn_supplier_maintenance.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Sienna
        End If

    End Sub

    Private Sub Btn_author_category_penalty_publisher_maintenance_Click(sender As Object, e As EventArgs) Handles Btn_author_category_penalty_publisher_maintenance.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel6_Supplier.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel10_Author_Category_Penalty_Publisher.Visible = True
        Panel12_Shelf.Visible = False
        Panel13_Delivery.Visible = False
        Panel14_Book_Inventory.Visible = False

        Load_all_data_tables() 'To load data tables and remove items selection on the listview

        Dim btn As Button = DirectCast(sender, Button)

        ' Reset the previously selected button's color
        If selectedButton IsNot Nothing Then
            selectedButton.BackColor = Color.Sienna
        End If

        ' Set the new selected button and change its color
        btn.BackColor = Color.RoyalBlue
        selectedButton = btn

    End Sub

    Private Sub Btn_author_category_penalty_publisher_maintenance_MouseEnter(sender As Object, e As EventArgs) Handles Btn_author_category_penalty_publisher_maintenance.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_author_category_penalty_publisher_maintenance_MouseLeave(sender As Object, e As EventArgs) Handles Btn_author_category_penalty_publisher_maintenance.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Sienna
        End If

    End Sub

    Private Sub Btn_shelf_Click(sender As Object, e As EventArgs) Handles Btn_shelf.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel6_Supplier.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel10_Author_Category_Penalty_Publisher.Visible = False
        Panel12_Shelf.Visible = True
        Panel13_Delivery.Visible = False
        Panel14_Book_Inventory.Visible = False

        Load_all_data_tables() 'To load data tables and remove items selection on the listview

        Dim btn As Button = DirectCast(sender, Button)

        ' Reset the previously selected button's color
        If selectedButton IsNot Nothing Then
            selectedButton.BackColor = Color.Sienna
        End If

        ' Set the new selected button and change its color
        btn.BackColor = Color.RoyalBlue
        selectedButton = btn

    End Sub

    Private Sub Btn_shelf_MouseEnter(sender As Object, e As EventArgs) Handles Btn_shelf.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_shelf_MouseLeave(sender As Object, e As EventArgs) Handles Btn_shelf.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Sienna
        End If

    End Sub

    Private Sub Btn_delivery_Click(sender As Object, e As EventArgs) Handles Btn_delivery.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel6_Supplier.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel10_Author_Category_Penalty_Publisher.Visible = False
        Panel12_Shelf.Visible = False
        Panel13_Delivery.Visible = True
        Panel14_Book_Inventory.Visible = False

        Load_all_data_tables() 'To load data tables and remove items selection on the listview

        Dim btn As Button = DirectCast(sender, Button)

        ' Reset the previously selected button's color
        If selectedButton IsNot Nothing Then
            selectedButton.BackColor = Color.Sienna
        End If

        ' Set the new selected button and change its color
        btn.BackColor = Color.RoyalBlue
        selectedButton = btn

    End Sub

    Private Sub Btn_delivery_MouseEnter(sender As Object, e As EventArgs) Handles Btn_delivery.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_delivery_MouseLeave(sender As Object, e As EventArgs) Handles Btn_delivery.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Sienna
        End If

    End Sub

    Private Sub Btn_book_inventory_Click(sender As Object, e As EventArgs) Handles Btn_book_inventory.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel6_Supplier.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel10_Author_Category_Penalty_Publisher.Visible = False
        Panel12_Shelf.Visible = False
        Panel13_Delivery.Visible = False
        Panel14_Book_Inventory.Visible = True

        Load_all_data_tables() 'To load data tables and remove items selection on the listview

        Dim btn As Button = DirectCast(sender, Button)

        ' Reset the previously selected button's color
        If selectedButton IsNot Nothing Then
            selectedButton.BackColor = Color.Sienna
        End If

        ' Set the new selected button and change its color
        btn.BackColor = Color.RoyalBlue
        selectedButton = btn

    End Sub

    Private Sub Btn_book_inventory_MouseEnter(sender As Object, e As EventArgs) Handles Btn_book_inventory.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_book_inventory_MouseLeave(sender As Object, e As EventArgs) Handles Btn_book_inventory.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Sienna
        End If

    End Sub

    Private Sub Btn_logout_Click(sender As Object, e As EventArgs) Handles Btn_logout.Click

        If Btn_logout.Enabled = True Then

            Dim dialog As DialogResult

            dialog = MessageBox.Show("Do you want to logout?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If dialog = DialogResult.Yes Then

                Close()
                Fm_login.Show()

            End If

        End If

    End Sub

    Private Sub Btn_logout_MouseEnter(sender As Object, e As EventArgs) Handles Btn_logout.MouseEnter

        Btn_logout.BackColor = Color.RoyalBlue

    End Sub

    Private Sub Btn_logout_MouseLeave(sender As Object, e As EventArgs) Handles Btn_logout.MouseLeave

        Btn_logout.BackColor = Color.Sienna

    End Sub


    ' Listed Books

    Private Sub Txt_listed_books_search_TextChanged(sender As Object, e As EventArgs) Handles Txt_listed_books_search.TextChanged

        Load_listed_books_data_table(Txt_listed_books_search.Text)

    End Sub

    Private Sub Txt_listed_books_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_listed_books_search.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_listed_books_search.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Cb_listed_books_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_listed_books_category.SelectedIndexChanged

        If Cb_listed_books_category.Text = "All Genre" Then

            Load_listed_books_data_table(Txt_listed_books_search.Text)

        Else

            Try

                con.Open()

                sql = "SELECT   tbl_books.isbn,
                                tbl_books.book_name,
                                tbl_library_category.category_name,
                                tbl_library_author.author_name,
                                tbl_library_publisher.publisher_name,
                                tbl_books.publish_year,
                                tbl_books.primary_book_id,
                                tbl_books.primary_category_id

                        From tbl_books

                        INNER Join tbl_library_category ON tbl_books.primary_category_id = tbl_library_category.primary_category_id
                        INNER Join tbl_library_author ON tbl_books.primary_author_id = tbl_library_author.primary_author_id
                        INNER Join tbl_library_publisher ON tbl_books.primary_publisher_id = tbl_library_publisher.primary_publisher_id

                        WHERE   category_name = '" & Cb_listed_books_category.SelectedItem & "'

                        ORDER BY primary_book_id DESC"

                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                Lv_listed_books.Items.Clear()

                While dr.Read()

                    Dim lv As New ListViewItem({dr("isbn").ToString(),
                                                dr("book_name").ToString(),
                                                dr("category_name").ToString(),
                                                dr("author_name").ToString(),
                                                dr("publisher_name").ToString(),
                                                dr("publish_year").ToString(),
                                                dr("primary_book_id").ToString(),
                                                dr("primary_category_id")})
                    Lv_listed_books.Items.Add(lv)

                End While

                dr.Close()

                ' Alternate row coloring
                For i As Integer = 0 To Lv_listed_books.Items.Count - 1
                    With Lv_listed_books.Items(i)
                        .BackColor = If(i Mod 2 = 0, Color.Azure, Color.GhostWhite)
                        .ForeColor = Color.Black
                    End With
                Next

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        End If

    End Sub

    Private Sub Cb_listed_books_category_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_listed_books_category.KeyPress

        'No input alphanumeric
        e.Handled = True

    End Sub

    Private Sub Cb_listed_books_category_Click(sender As Object, e As EventArgs) Handles Cb_listed_books_category.Click

        Cb_listed_books_category.DroppedDown = True

    End Sub

    Private Sub Btn_listed_books_add_Click(sender As Object, e As EventArgs) Handles Btn_listed_books_add.Click

        Fm_add_books.update_Txt_isbn.Visible = False
        Fm_add_books.Btn_update.Visible = False
        Fm_add_books.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_listed_books_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_listed_books_add.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_listed_books_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_listed_books_add.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_listed_books_edit_Click(sender As Object, e As EventArgs) Handles Btn_listed_books_edit.Click

        If Lv_listed_books.SelectedItems.Count > 0 Then

            Fm_add_books.update_Txt_isbn.Text = Lv_listed_books.SelectedItems(0).Text
            Fm_add_books.Txt_book_name.Text = Lv_listed_books.SelectedItems(0).SubItems(1).Text
            Fm_add_books.Cb_book_category.Text = Lv_listed_books.SelectedItems(0).SubItems(2).Text
            Fm_add_books.Txt_author.Text = Lv_listed_books.SelectedItems(0).SubItems(3).Text
            Fm_add_books.Txt_publisher.Text = Lv_listed_books.SelectedItems(0).SubItems(4).Text
            Fm_add_books.Dtp_publish_date.Value = Lv_listed_books.SelectedItems(0).SubItems(5).Text

            Fm_add_books.Txt_primary_category_id.Text = Lv_listed_books.SelectedItems(0).SubItems(7).Text

            Fm_add_books.save_Txt_isbn.Visible = False
            Fm_add_books.Show()
            Me.Enabled = False

        Else

            MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_listed_books_edit_MouseEnter(sender As Object, e As EventArgs) Handles Btn_listed_books_edit.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_listed_books_edit_MouseLeave(sender As Object, e As EventArgs) Handles Btn_listed_books_edit.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_listed_books_delete_Click(sender As Object, e As EventArgs) Handles Btn_listed_books_delete.Click

        If Lv_listed_books.SelectedItems.Count > 0 Then

            Try

                con.Open()

                Dim book_name As String = Lv_listed_books.SelectedItems(0).SubItems(1).Text
                Dim primary_book_id As String = Lv_listed_books.SelectedItems(0).SubItems(6).Text

                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + book_name + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_books
                                    WHERE primary_book_id = '" & primary_book_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    Load_listed_books_data_table(Txt_listed_books_search.Text)
                    MessageBox.Show(book_name + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Close()

                    Load_listed_books_data_table(Txt_listed_books_search.Text)

                End If

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        Else

            MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_listed_books_delete_MouseEnter(sender As Object, e As EventArgs) Handles Btn_listed_books_delete.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_listed_books_delete_MouseLeave(sender As Object, e As EventArgs) Handles Btn_listed_books_delete.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub


    ' Returned Borrowed Books

    Private Sub Txt_returned_borrowed_books_search_TextChanged(sender As Object, e As EventArgs) Handles Txt_returned_borrowed_books_search.TextChanged

        Load_returned_borrowed_books_data_table(Txt_returned_borrowed_books_search.Text)

    End Sub

    Private Sub Txt_returned_borrowed_books_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_returned_borrowed_books_search.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_returned_borrowed_books_search.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Btn_borrow_books_Click(sender As Object, e As EventArgs) Handles Btn_borrow_books.Click

        Fm_issued_books.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_borrow_books_MouseEnter(sender As Object, e As EventArgs) Handles Btn_borrow_books.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_borrow_books_MouseLeave(sender As Object, e As EventArgs) Handles Btn_borrow_books.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_return_books_Click(sender As Object, e As EventArgs) Handles Btn_return_books.Click

        Fm_returned_books.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_return_books_MouseEnter(sender As Object, e As EventArgs) Handles Btn_return_books.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_return_books_MouseLeave(sender As Object, e As EventArgs) Handles Btn_return_books.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub


    ' Borrower Informaion

    Private Sub Txt_student_info_search_TextChanged(sender As Object, e As EventArgs) Handles Txt_student_info_search.TextChanged

        Load_borrower_info_data_table(Txt_student_info_search.Text)

    End Sub

    Private Sub Txt_student_info_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_student_info_search.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_student_info_search.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Btn_borrower_info_add_Click(sender As Object, e As EventArgs) Handles Btn_borrower_info_add.Click

        Fm_add_borrower.Btn_update.Visible = False
        Fm_add_borrower.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_borrower_info_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_borrower_info_add.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_borrower_info_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_borrower_info_add.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_borrower_info_edit_Click(sender As Object, e As EventArgs) Handles Btn_borrower_info_edit.Click

        If Lv_borrower_info.SelectedItems.Count > 0 Then

            Fm_add_borrower.Txt_borrower_id_number.Text = Lv_borrower_info.SelectedItems(0).Text
            Fm_add_borrower.Txt_borrower_last_name.Text = Lv_borrower_info.SelectedItems(0).SubItems(1).Text
            Fm_add_borrower.Txt_borrower_first_name.Text = Lv_borrower_info.SelectedItems(0).SubItems(2).Text
            Fm_add_borrower.Txt_borrower_middle_name.Text = Lv_borrower_info.SelectedItems(0).SubItems(3).Text
            Fm_add_borrower.Cb_borrower_category_type.Text = Lv_borrower_info.SelectedItems(0).SubItems(4).Text

            Dim gender As String = Lv_borrower_info.SelectedItems(0).SubItems(5).Text

            If gender = "Male" Then
                Fm_add_borrower.Rb_male.Checked = True
            Else
                Fm_add_borrower.Rb_female.Checked = True
            End If

            Fm_add_borrower.Txt_borrower_contact_no.Text = Lv_borrower_info.SelectedItems(0).SubItems(6).Text
            Fm_add_borrower.Txt_borrower_email.Text = Lv_borrower_info.SelectedItems(0).SubItems(7).Text
            Fm_add_borrower.Txt_borrower_address.Text = Lv_borrower_info.SelectedItems(0).SubItems(8).Text

            Fm_add_borrower.Show()
            Me.Enabled = False

        Else

            MessageBox.Show("Please select borrower data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_borrower_info_edit_MouseEnter(sender As Object, e As EventArgs) Handles Btn_borrower_info_edit.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_borrower_info_edit_MouseLeave(sender As Object, e As EventArgs) Handles Btn_borrower_info_edit.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_borrower_info_delete_Click(sender As Object, e As EventArgs) Handles Btn_borrower_info_delete.Click

        If Lv_borrower_info.SelectedItems.Count > 0 Then

            Try

                con.Open()

                Dim first_name As String = Lv_borrower_info.SelectedItems(0).SubItems(2).Text
                Dim last_name As String = Lv_borrower_info.SelectedItems(0).SubItems(1).Text
                Dim primary_borrower_id As String = Lv_borrower_info.SelectedItems(0).SubItems(9).Text

                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + first_name + " " + last_name + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_borrower
                                  WHERE primary_borrower_id = '" & primary_borrower_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    Load_borrower_info_data_table(Txt_student_info_search.Text)
                    MessageBox.Show(first_name + " " + last_name + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Close()

                    Load_borrower_info_data_table(Txt_student_info_search.Text)

                End If

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        Else

            MessageBox.Show("Please select borrower data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_borrower_info_delete_MouseEnter(sender As Object, e As EventArgs) Handles Btn_borrower_info_delete.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_borrower_info_delete_MouseLeave(sender As Object, e As EventArgs) Handles Btn_borrower_info_delete.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub


    ' Penalty Report

    Private Sub Txt_search_penalty_report_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_penalty_report.TextChanged

        Load_penalty_report_data_table(Txt_search_penalty_report.Text)

    End Sub

    Private Sub Txt_search_penalty_report_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_penalty_report.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_search_penalty_report.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Lv_penalty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_penalty.SelectedIndexChanged

        If Lv_penalty.SelectedItems.Count > 0 Then

            Dim primary_borrower_id As String = Lv_penalty.SelectedItems(0).SubItems(4).Text
            Dim primary_book_id As String = Lv_penalty.SelectedItems(0).SubItems(5).Text
            Dim penalty_date As String = Lv_penalty.SelectedItems(0).SubItems(3).Text

            Load_penalty_report_penalty_description_data_table(primary_borrower_id, primary_book_id, penalty_date)

        Else

            Lv_penalty_report_penalty_description.Items.Clear()

        End If

    End Sub

    Private Sub Btn_penalty_edit_Click(sender As Object, e As EventArgs) Handles Btn_penalty_report_edit.Click

        If Lv_penalty.SelectedItems.Count > 0 Then

            Fm_add_penalty.Txt_borrower_id.Text = Lv_penalty.SelectedItems(0).Text
            Fm_add_penalty.Txt_borrower_name.Text = Lv_penalty.SelectedItems(0).SubItems(1).Text
            Fm_add_penalty.Txt_book_name.Text = Lv_penalty.SelectedItems(0).SubItems(2).Text

            Fm_add_penalty.Txt_primary_borrower_id.Text = Lv_penalty.SelectedItems(0).SubItems(4).Text
            Fm_add_penalty.Txt_primary_book_id.Text = Lv_penalty.SelectedItems(0).SubItems(5).Text

            Fm_add_penalty.Txt_primary_penalty_report_id.Text = Lv_penalty.SelectedItems(0).SubItems(7).Text

            Fm_add_penalty.Btn_save.Visible = False
            Fm_add_penalty.Show()
            Me.Enabled = False

        Else

            MessageBox.Show("Please select on the list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_penalty_report_edit_MouseEnter(sender As Object, e As EventArgs) Handles Btn_penalty_report_edit.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_penalty_report_edit_MouseLeave(sender As Object, e As EventArgs) Handles Btn_penalty_report_edit.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_penalty_delete_Click(sender As Object, e As EventArgs) Handles Btn_penalty_report_delete.Click

        If Lv_penalty_report_penalty_description.SelectedItems.Count > 0 Then

            Try
                con.Open()

                Dim full_name = Lv_penalty.SelectedItems(0).SubItems(1).Text
                Dim primary_penalty_id As String = Lv_penalty_report_penalty_description.SelectedItems(0).SubItems(2).Text

                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete the penalty for " + full_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_penalty_report
                                  WHERE primary_penalty_id = '" & primary_penalty_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show("Penalty deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim primary_borrower_id As String = Lv_penalty.SelectedItems(0).SubItems(4).Text
                    Dim primary_book_id As String = Lv_penalty.SelectedItems(0).SubItems(5).Text
                    Dim penalty_date As String = Lv_penalty.SelectedItems(0).SubItems(3).Text
                    Load_penalty_report_penalty_description_data_table(primary_borrower_id, primary_book_id, penalty_date)

                Else

                    con.Close()

                    Dim primary_borrower_id As String = Lv_penalty.SelectedItems(0).SubItems(4).Text
                    Dim primary_book_id As String = Lv_penalty.SelectedItems(0).SubItems(5).Text
                    Dim penalty_date As String = Lv_penalty.SelectedItems(0).SubItems(3).Text
                    Load_penalty_report_penalty_description_data_table(primary_borrower_id, primary_book_id, penalty_date)

                End If

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        Else

            MessageBox.Show("Please select penalty on the list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_penalty_report_delete_MouseEnter(sender As Object, e As EventArgs) Handles Btn_penalty_report_delete.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_penalty_report_delete_MouseLeave(sender As Object, e As EventArgs) Handles Btn_penalty_report_delete.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub


    ' Listed Accounts

    Private Sub Txt_listed_accounts_search_TextChanged(sender As Object, e As EventArgs) Handles Txt_listed_accounts_search.TextChanged

        Load_listed_accounts_data_table(Txt_listed_accounts_search.Text)

    End Sub

    Private Sub Txt_listed_accounts_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_listed_accounts_search.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_listed_accounts_search.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Btn_listed_accounts_add_Click(sender As Object, e As EventArgs) Handles Btn_listed_accounts_add.Click

        Fm_admin_registration.Btn_update.Visible = False
        Fm_admin_registration.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_listed_accounts_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_listed_accounts_add.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_listed_accounts_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_listed_accounts_add.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_listed_accounts_edit_Click(sender As Object, e As EventArgs) Handles Btn_listed_accounts_edit.Click

        If Lv_listed_accounts.SelectedItems.Count > 0 Then

            Fm_admin_registration.Txt_firstname.Text = Lv_listed_accounts.SelectedItems(0).Text
            Fm_admin_registration.Txt_middlename.Text = Lv_listed_accounts.SelectedItems(0).SubItems(1).Text
            Fm_admin_registration.Txt_lastname.Text = Lv_listed_accounts.SelectedItems(0).SubItems(2).Text

            Dim Gender As String = Lv_listed_accounts.SelectedItems(0).SubItems(3).Text

            If Gender = "Male" Then
                Fm_admin_registration.Rb_male.Checked = True
            Else
                Fm_admin_registration.Rb_female.Checked = True
            End If

            Fm_admin_registration.Dtp_birthdate.Text = Lv_listed_accounts.SelectedItems(0).SubItems(4).Text
            Fm_admin_registration.Txt_contact.Text = Lv_listed_accounts.SelectedItems(0).SubItems(5).Text
            Fm_admin_registration.Txt_address.Text = Lv_listed_accounts.SelectedItems(0).SubItems(6).Text
            Fm_admin_registration.Txt_username.Text = Lv_listed_accounts.SelectedItems(0).SubItems(7).Text
            Fm_admin_registration.Txt_email.Text = Lv_listed_accounts.SelectedItems(0).SubItems(8).Text
            Fm_admin_registration.Cb_user_type.Text = Lv_listed_accounts.SelectedItems(0).SubItems(9).Text
            Fm_admin_registration.Txt_password.Text = Lv_listed_accounts.SelectedItems(0).SubItems(10).Text

            Fm_admin_registration.Btn_save.Visible = False
            Fm_admin_registration.Txt_confirmpassword.Visible = False
            Fm_admin_registration.Show()
            Me.Enabled = False

        Else

            MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_listed_accounts_edit_MouseEnter(sender As Object, e As EventArgs) Handles Btn_listed_accounts_edit.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_listed_accounts_edit_MouseLeave(sender As Object, e As EventArgs) Handles Btn_listed_accounts_edit.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_listed_accounts_delete_Click(sender As Object, e As EventArgs) Handles Btn_listed_accounts_delete.Click

        If Lv_listed_accounts.SelectedItems.Count > 0 Then

            con.Open()

            Dim first_name As String = Lv_listed_accounts.SelectedItems(0).Text
            Dim last_name As String = Lv_listed_accounts.SelectedItems(0).SubItems(2).Text
            Dim primary_admin_id As String = Lv_listed_accounts.SelectedItems(0).SubItems(11).Text

            Dim dialog As DialogResult

            dialog = MessageBox.Show("Do you want to delete " + first_name + " " + last_name + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If dialog = DialogResult.Yes Then

                Try

                    sql = "DELETE FROM tbl_admin
                                  WHERE primary_admin_id = '" & primary_admin_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    Load_listed_accounts_data_table(Txt_listed_accounts_search.Text)
                    MessageBox.Show(first_name + " " + last_name + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Catch ex As Exception

                    MsgBox("Error: " & ex.Message)

                Finally

                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If

                End Try

            Else

                con.Close()

                Load_listed_accounts_data_table(Txt_listed_accounts_search.Text)

            End If

        Else

            MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_listed_accounts_delete_MouseEnter(sender As Object, e As EventArgs) Handles Btn_listed_accounts_delete.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_listed_accounts_delete_MouseLeave(sender As Object, e As EventArgs) Handles Btn_listed_accounts_delete.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub


    ' Listed Supplier

    Private Sub Txt_search_supplier_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_supplier.TextChanged

        Load_library_supplier_data_table(Txt_search_supplier.Text)

    End Sub

    Private Sub Txt_search_supplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_supplier.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_search_supplier.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Btn_supplier_add_Click(sender As Object, e As EventArgs) Handles Btn_supplier_add.Click

        Fm_supplier_maintenance.Btn_update.Visible = False
        Fm_supplier_maintenance.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_supplier_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_supplier_add.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_supplier_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_supplier_add.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_supplier_edit_Click(sender As Object, e As EventArgs) Handles Btn_supplier_edit.Click

        If Lv_supplier.SelectedItems.Count > 0 Then

            Fm_supplier_maintenance.Txt_supplier_id.Text = Lv_supplier.SelectedItems(0).Text
            Fm_supplier_maintenance.Txt_supplier_name.Text = Lv_supplier.SelectedItems(0).SubItems(1).Text
            Fm_supplier_maintenance.Txt_supplier_firstname.Text = Lv_supplier.SelectedItems(0).SubItems(8).Text
            Fm_supplier_maintenance.Txt_supplier_lastname.Text = Lv_supplier.SelectedItems(0).SubItems(9).Text
            Fm_supplier_maintenance.Txt_supplier_email_address.Text = Lv_supplier.SelectedItems(0).SubItems(3).Text
            Fm_supplier_maintenance.Txt_supplier_contact.Text = Lv_supplier.SelectedItems(0).SubItems(4).Text
            Fm_supplier_maintenance.Txt_supplier_address.Text = Lv_supplier.SelectedItems(0).SubItems(5).Text
            Fm_supplier_maintenance.Cb_supplier_source_type.Text = Lv_supplier.SelectedItems(0).SubItems(6).Text

            Fm_supplier_maintenance.Btn_save.Visible = False
            Fm_supplier_maintenance.Show()
            Me.Enabled = False

        Else

            MessageBox.Show("Please select supplier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_supplier_edit_MouseEnter(sender As Object, e As EventArgs) Handles Btn_supplier_edit.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_supplier_edit_MouseLeave(sender As Object, e As EventArgs) Handles Btn_supplier_edit.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_supplier_delete_Click(sender As Object, e As EventArgs) Handles Btn_supplier_delete.Click

        If Lv_supplier.SelectedItems.Count > 0 Then

            Try
                con.Open()

                Dim supplier_name = Lv_supplier.SelectedItems(0).SubItems(1).Text
                Dim primary_supplier_id As String = Lv_supplier.SelectedItems(0).SubItems(7).Text

                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + supplier_name + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_library_supplier
                                  WHERE primary_supplier_id = '" & primary_supplier_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    Load_library_supplier_data_table(Txt_search_supplier.Text)
                    MessageBox.Show(supplier_name + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Close()

                    Load_library_supplier_data_table(Txt_search_supplier.Text)

                End If

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        Else

            MessageBox.Show("Please select supplier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_supplier_delete_MouseEnter(sender As Object, e As EventArgs) Handles Btn_supplier_delete.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_supplier_delete_MouseLeave(sender As Object, e As EventArgs) Handles Btn_supplier_delete.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub


    ' Listed Author

    Private Sub Txt_search_author_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_author.TextChanged

        Load_library_author_data_table(Txt_search_author.Text)

    End Sub

    Private Sub Txt_search_author_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_author.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_search_author.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Btn_author_add_Click(sender As Object, e As EventArgs) Handles Btn_author_add.Click

        Fm_add_author.Btn_update.Visible = False
        Fm_add_author.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_author_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_author_add.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_author_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_author_add.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_author_edit_Click(sender As Object, e As EventArgs) Handles Btn_author_edit.Click

        If Lv_author.SelectedItems.Count > 0 Then

            Fm_add_author.Txt_author_name.Text = Lv_author.SelectedItems(0).Text

            Fm_add_author.Btn_save.Visible = False
            Fm_add_author.Show()
            Me.Enabled = False

        Else

            MessageBox.Show("Please select author", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_author_edit_MouseEnter(sender As Object, e As EventArgs) Handles Btn_author_edit.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_author_edit_MouseLeave(sender As Object, e As EventArgs) Handles Btn_author_edit.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_author_delete_Click(sender As Object, e As EventArgs) Handles Btn_author_delete.Click

        If Lv_author.SelectedItems.Count > 0 Then

            Try

                con.Open()

                Dim author_name = Lv_author.SelectedItems(0).Text
                Dim primary_author_id As String = Lv_author.SelectedItems(0).SubItems(1).Text

                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + author_name + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_library_author
                                  WHERE primary_author_id = '" & primary_author_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show(author_name + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_library_author_data_table(Txt_search_author.Text)

                Else

                    con.Close()

                    Load_library_author_data_table(Txt_search_author.Text)

                End If

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        Else

            MessageBox.Show("Please select author", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_author_delete_MouseEnter(sender As Object, e As EventArgs) Handles Btn_author_delete.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_author_delete_MouseLeave(sender As Object, e As EventArgs) Handles Btn_author_delete.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Lv_author_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_author.SelectedIndexChanged

        'Remove items selection on the other listview
        If Lv_category.SelectedItems.Count > 0 Then

            Load_library_category_data_table(Txt_search_category.Text)

        ElseIf Lv_penalty_description.SelectedItems.Count > 0 Then

            Load_library_penalty_data_table(Txt_search_penalty_description.Text)

        ElseIf Lv_publisher.SelectedItems.Count > 0 Then

            Load_library_publisher_data_table(Txt_search_publisher.Text)

        End If

    End Sub


    ' Listed Category

    Private Sub Txt_search_category_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_category.TextChanged

        Load_library_category_data_table(Txt_search_category.Text)

    End Sub

    Private Sub Txt_search_category_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_category.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_search_category.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Btn_category_add_Click(sender As Object, e As EventArgs) Handles Btn_category_add.Click

        Fm_add_category.Btn_update.Visible = False
        Fm_add_category.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_category_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_category_add.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_category_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_category_add.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_category_edit_Click(sender As Object, e As EventArgs) Handles Btn_category_edit.Click

        If Lv_category.SelectedItems.Count > 0 Then

            Fm_add_category.Txt_category_name.Text = Lv_category.SelectedItems(0).Text

            Fm_add_category.Btn_save.Visible = False
            Fm_add_category.Show()
            Me.Enabled = False

        Else

            MessageBox.Show("Please select genre", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_category_edit_MouseEnter(sender As Object, e As EventArgs) Handles Btn_category_edit.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_category_edit_MouseLeave(sender As Object, e As EventArgs) Handles Btn_category_edit.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_category_delete_Click(sender As Object, e As EventArgs) Handles Btn_category_delete.Click

        If Lv_category.SelectedItems.Count > 0 Then

            Try

                con.Open()

                Dim category_description = Lv_category.SelectedItems(0).Text
                Dim primary_category_id As String = Lv_category.SelectedItems(0).SubItems(1).Text

                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + category_description + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_library_category
                                  WHERE primary_category_id = '" & primary_category_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show(category_description + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_library_category_data_table(Txt_search_category.Text)
                    Load_library_cb_category()

                Else

                    con.Close()

                    Load_library_category_data_table(Txt_search_category.Text)

                End If

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        Else

            MessageBox.Show("Please select genre", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_category_delete_MouseEnter(sender As Object, e As EventArgs) Handles Btn_category_delete.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_category_delete_MouseLeave(sender As Object, e As EventArgs) Handles Btn_category_delete.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Lv_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_category.SelectedIndexChanged

        'Remove items selection on the other listview
        If Lv_author.SelectedItems.Count > 0 Then

            Load_library_author_data_table(Txt_search_author.Text)

        ElseIf Lv_penalty_description.SelectedItems.Count > 0 Then

            Load_library_penalty_data_table(Txt_search_penalty_description.Text)

        ElseIf Lv_publisher.SelectedItems.Count > 0 Then

            Load_library_publisher_data_table(Txt_search_publisher.Text)

        End If

    End Sub


    ' Library Penalty

    Private Sub Txt_search_penalty_description_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_penalty_description.TextChanged

        Load_library_penalty_data_table(Txt_search_penalty_description.Text)

    End Sub

    Private Sub Txt_search_penalty_description_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_penalty_description.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_search_penalty_description.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Btn_penalty_description_add_Click(sender As Object, e As EventArgs) Handles Btn_penalty_description_add.Click

        Fm_penalty_description.Btn_update.Visible = False
        Fm_penalty_description.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_penalty_description_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_penalty_description_add.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_penalty_description_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_penalty_description_add.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_penalty_description_edit_Click(sender As Object, e As EventArgs) Handles Btn_penalty_description_edit.Click

        If Lv_penalty_description.SelectedItems.Count > 0 Then

            Fm_penalty_description.Txt_penalty_description.Text = Lv_penalty_description.SelectedItems(0).Text
            Fm_penalty_description.Txt_penalty_amount.Text = Lv_penalty_description.SelectedItems(0).SubItems(1).Text

            Fm_penalty_description.Btn_save.Visible = False
            Fm_penalty_description.Show()
            Me.Enabled = False

        Else

            MessageBox.Show("Please select penalty description", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_penalty_description_edit_MouseEnter(sender As Object, e As EventArgs) Handles Btn_penalty_description_edit.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_penalty_description_edit_MouseLeave(sender As Object, e As EventArgs) Handles Btn_penalty_description_edit.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_penalty_description_delete_Click(sender As Object, e As EventArgs) Handles Btn_penalty_description_delete.Click

        If Lv_penalty_description.SelectedItems.Count > 0 Then

            Try

                con.Open()

                Dim penalty_description = Lv_penalty_description.SelectedItems(0).Text
                Dim primary_penalty_id As String = Lv_penalty_description.SelectedItems(0).SubItems(2).Text

                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + penalty_description + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_library_penalty
                           WHERE primary_penalty_description_id = '" & primary_penalty_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show(penalty_description + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_library_penalty_data_table(Txt_search_penalty_description.Text)

                Else

                    con.Close()

                    Load_library_penalty_data_table(Txt_search_penalty_description.Text)

                End If

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        Else

            MessageBox.Show("Please select penalty description", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_penalty_description_delete_MouseEnter(sender As Object, e As EventArgs) Handles Btn_penalty_description_delete.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_penalty_description_delete_MouseLeave(sender As Object, e As EventArgs) Handles Btn_penalty_description_delete.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Lv_penalty_description_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_penalty_description.SelectedIndexChanged

        'Remove items selection on the other listview
        If Lv_author.SelectedItems.Count > 0 Then

            Load_library_author_data_table(Txt_search_author.Text)

        ElseIf Lv_category.SelectedItems.Count > 0 Then

            Load_library_category_data_table(Txt_search_category.Text)

        ElseIf Lv_publisher.SelectedItems.Count > 0 Then

            Load_library_publisher_data_table(Txt_search_publisher.Text)

        End If

    End Sub


    ' Library Publisher

    Private Sub Txt_search_publisher_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_publisher.TextChanged

        Load_library_publisher_data_table(Txt_search_publisher.Text)

    End Sub

    Private Sub Txt_search_publisher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_publisher.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_search_publisher.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Btn_publisher_add_Click(sender As Object, e As EventArgs) Handles Btn_publisher_add.Click

        Fm_publisher.Btn_update.Visible = False
        Fm_publisher.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_publisher_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_publisher_add.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_publisher_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_publisher_add.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_publisher_edit_Click(sender As Object, e As EventArgs) Handles Btn_publisher_edit.Click

        If Lv_publisher.SelectedItems.Count > 0 Then

            Fm_publisher.Txt_publisher_name.Text = Lv_publisher.SelectedItems(0).Text

            Fm_publisher.Btn_save.Visible = False
            Fm_publisher.Show()
            Me.Enabled = False

        Else

            MessageBox.Show("Please select publisher", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_publisher_edit_MouseEnter(sender As Object, e As EventArgs) Handles Btn_publisher_edit.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_publisher_edit_MouseLeave(sender As Object, e As EventArgs) Handles Btn_publisher_edit.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_publisher_delete_Click(sender As Object, e As EventArgs) Handles Btn_publisher_delete.Click

        If Lv_publisher.SelectedItems.Count > 0 Then

            Try

                con.Open()

                Dim publisher_name = Lv_publisher.SelectedItems(0).Text
                Dim primary_publisher_id As String = Lv_publisher.SelectedItems(0).SubItems(1).Text

                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + publisher_name + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_library_publisher
                            WHERE primary_publisher_id = '" & primary_publisher_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show(publisher_name + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_library_publisher_data_table(Txt_search_publisher.Text)

                Else

                    con.Close()

                    Load_library_publisher_data_table(Txt_search_publisher.Text)

                End If

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        Else

            MessageBox.Show("Please select publisher", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_publisher_delete_MouseEnter(sender As Object, e As EventArgs) Handles Btn_publisher_delete.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_publisher_delete_MouseLeave(sender As Object, e As EventArgs) Handles Btn_publisher_delete.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Lv_publisher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_publisher.SelectedIndexChanged

        'Remove items selection on the other listview
        If Lv_author.SelectedItems.Count > 0 Then

            Load_library_author_data_table(Txt_search_author.Text)

        ElseIf Lv_category.SelectedItems.Count > 0 Then

            Load_library_category_data_table(Txt_search_category.Text)

        ElseIf Lv_penalty_description.SelectedItems.Count > 0 Then

            Load_library_penalty_data_table(Txt_search_penalty_description.Text)

        End If

    End Sub


    ' Shelf

    Private Sub Txt_search_shelf_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_shelf.TextChanged

        Load_shelf_data_table(Txt_search_shelf.Text)

    End Sub

    Private Sub Txt_search_shelf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_shelf.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_search_shelf.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Btn_shelf_add_Click(sender As Object, e As EventArgs) Handles Btn_shelf_add.Click

        Fm_add_shelf.Btn_update.Visible = False
        Fm_add_shelf.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_shelf_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_shelf_add.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_shelf_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_shelf_add.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_shelf_edit_Click(sender As Object, e As EventArgs) Handles Btn_shelf_edit.Click

        If Lv_shelf.SelectedItems.Count > 0 Then

            Fm_add_shelf.Txt_shelf_id.Text = Lv_shelf.SelectedItems(0).Text
            Fm_add_shelf.Txt_shelf_name.Text = Lv_shelf.SelectedItems(0).SubItems(1).Text
            Fm_add_shelf.Txt_shelf_section.Text = Lv_shelf.SelectedItems(0).SubItems(2).Text
            Fm_add_shelf.Txt_shelf_floor_number.Text = Lv_shelf.SelectedItems(0).SubItems(3).Text
            Fm_add_shelf.Txt_shelf_capacity.Text = Lv_shelf.SelectedItems(0).SubItems(4).Text
            Fm_add_shelf.Txt_shelf_current_load.Text = Lv_shelf.SelectedItems(0).SubItems(5).Text

            Fm_add_shelf.Btn_save.Visible = False
            Fm_add_shelf.Show()
            Me.Enabled = False

        Else

            MessageBox.Show("Please select shelf", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_shelf_edit_MouseEnter(sender As Object, e As EventArgs) Handles Btn_shelf_edit.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_shelf_edit_MouseLeave(sender As Object, e As EventArgs) Handles Btn_shelf_edit.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_shelf_delete_Click(sender As Object, e As EventArgs) Handles Btn_shelf_delete.Click

        If Lv_shelf.SelectedItems.Count > 0 Then

            Try

                con.Open()

                Dim shelf_name = Lv_shelf.SelectedItems(0).SubItems(1).Text
                Dim primary_shelf_id As String = Lv_shelf.SelectedItems(0).SubItems(8).Text

                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + shelf_name + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_shelf
                            WHERE primary_shelf_id = '" & primary_shelf_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show(shelf_name + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_shelf_data_table(Txt_search_shelf.Text)

                Else

                    con.Close()

                    Load_shelf_data_table(Txt_search_shelf.Text)

                End If

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        Else

            MessageBox.Show("Please select shelf", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_shelf_delete_MouseEnter(sender As Object, e As EventArgs) Handles Btn_shelf_delete.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_shelf_delete_MouseLeave(sender As Object, e As EventArgs) Handles Btn_shelf_delete.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub


    ' Delivery

    Private Sub Txt_search_delivery_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_delivery.TextChanged

        Load_delivery_data_table(Txt_search_delivery.Text)

    End Sub

    Private Sub Txt_search_delivery_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_delivery.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_search_delivery.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Btn_delivery_add_Click(sender As Object, e As EventArgs) Handles Btn_delivery_add.Click

        Fm_add_delivery.Btn_update.Visible = False
        Fm_add_delivery.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_delivery_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_delivery_add.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_delivery_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_delivery_add.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_delivery_edit_Click(sender As Object, e As EventArgs) Handles Btn_delivery_edit.Click



    End Sub

    Private Sub Btn_delivery_edit_MouseEnter(sender As Object, e As EventArgs) Handles Btn_delivery_edit.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_delivery_edit_MouseLeave(sender As Object, e As EventArgs) Handles Btn_delivery_edit.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_delivery_delete_Click(sender As Object, e As EventArgs) Handles Btn_delivery_delete.Click



    End Sub

    Private Sub Btn_delivery_delete_MouseEnter(sender As Object, e As EventArgs) Handles Btn_delivery_delete.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_delivery_delete_MouseLeave(sender As Object, e As EventArgs) Handles Btn_delivery_delete.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub


    ' Book Inventory

    Private Sub Txt_book_inventory_search_TextChanged(sender As Object, e As EventArgs) Handles Txt_book_inventory_search.TextChanged

        Load_book_inventory_data_table(Txt_book_inventory_search.Text)

    End Sub

    Private Sub Txt_book_inventory_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_book_inventory_search.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_book_inventory_search.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789`~@#$%^&*()_-=+{}[]|;:<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Cb_book_inventory_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_book_inventory_category.SelectedIndexChanged

        If Cb_book_inventory_category.Text = "All Genre" Then

            Load_book_inventory_data_table(Txt_book_inventory_search.Text)

        Else

            Load_book_inventory_data_table(Cb_book_inventory_category.Text)

        End If

    End Sub

    Private Sub Cb_book_inventory_category_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_book_inventory_category.KeyPress

        'No input alphanumeric
        e.Handled = True

    End Sub

    Private Sub Cb_book_inventory_category_Click(sender As Object, e As EventArgs) Handles Cb_book_inventory_category.Click

        Cb_book_inventory_category.DroppedDown = True

    End Sub

    Private Sub Btn_book_inventory_add_Click(sender As Object, e As EventArgs) Handles Btn_book_inventory_add.Click

        Fm_add_book_inventory.Btn_update.Visible = False
        Fm_add_book_inventory.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_book_inventory_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_book_inventory_add.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_book_inventory_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_book_inventory_add.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_book_inventory_edit_Click(sender As Object, e As EventArgs) Handles Btn_book_inventory_edit.Click

        If Lv_book_inventory.SelectedItems.Count > 0 Then

            Fm_add_book_inventory.update_Txt_isbn.Text = Lv_book_inventory.SelectedItems(0).Text
            Fm_add_book_inventory.Txt_book_quantity.Text = Lv_book_inventory.SelectedItems(0).SubItems(6).Text

            Fm_add_book_inventory.update_Txt_isbn.Enabled = False
            Fm_add_book_inventory.save_Txt_isbn.Visible = False
            Fm_add_book_inventory.Show()
            Me.Enabled = False

        Else

            MessageBox.Show("Please select book", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_book_inventory_edit_MouseEnter(sender As Object, e As EventArgs) Handles Btn_book_inventory_edit.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_book_inventory_edit_MouseLeave(sender As Object, e As EventArgs) Handles Btn_book_inventory_edit.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_book_inventory_delete_Click(sender As Object, e As EventArgs) Handles Btn_book_inventory_delete.Click

        If Lv_book_inventory.SelectedItems.Count > 0 Then

            Try

                con.Open()

                Dim book_name = Lv_book_inventory.SelectedItems(0).SubItems(1).Text
                Dim primary_book_inventory_id As String = Lv_book_inventory.SelectedItems(0).SubItems(8).Text

                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + book_name + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_book_inventory
                           WHERE primary_book_inventory_id = '" & primary_book_inventory_id & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    MessageBox.Show(book_name + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_book_inventory_data_table(Txt_book_inventory_search.Text)

                Else

                    con.Close()

                    Load_book_inventory_data_table(Txt_book_inventory_search.Text)

                End If

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        Else

            MessageBox.Show("Please select book", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_book_inventory_delete_MouseEnter(sender As Object, e As EventArgs) Handles Btn_book_inventory_delete.MouseEnter

        Dim btn = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_book_inventory_delete_MouseLeave(sender As Object, e As EventArgs) Handles Btn_book_inventory_delete.MouseLeave

        Dim btn = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

End Class