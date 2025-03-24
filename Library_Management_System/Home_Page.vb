Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Fm_home_page

    Private Sub Fm_home_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connection()

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel5_Author.Visible = False
        Panel6_Supplier.Visible = False
        Panel7_Category.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel9_Penalty.Visible = False

        Load_listed_books_data_table()
        Load_returned_borrowed_books_data_table()
        Load_borrower_info_data_table()
        Load_listed_accounts_data_table()
        Load_author_data_table()
        Load_supplier_data_table()
        Load_category_data_table()
        Load_penalty_description_data_table()
        Load_penalty_data_table()

        Load_library_cb_category()
        Load_library_cb_penalty_description()

        Dtp_penalty_date.Format = DateTimePickerFormat.Custom
        Dtp_penalty_date.CustomFormat = "MMMM dd, yyyy"

    End Sub

    Private Sub Btn_listed_books_Click(sender As Object, e As EventArgs) Handles Btn_listed_books.Click

        Panel1_Books.Visible = True
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel5_Author.Visible = False
        Panel6_Supplier.Visible = False
        Panel7_Category.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel9_Penalty.Visible = False

    End Sub

    Private Sub Btn_returned_books_Click(sender As Object, e As EventArgs) Handles Btn_returned_books.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = True
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel5_Author.Visible = False
        Panel6_Supplier.Visible = False
        Panel7_Category.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel9_Penalty.Visible = False

    End Sub

    Private Sub Btn_student_information_Click(sender As Object, e As EventArgs) Handles Btn_student_information.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = True
        Panel4_User_Acounts.Visible = False
        Panel5_Author.Visible = False
        Panel6_Supplier.Visible = False
        Panel7_Category.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel9_Penalty.Visible = False

    End Sub

    Private Sub Btn_listed_accounts_Click(sender As Object, e As EventArgs) Handles Btn_listed_accounts.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = True
        Panel5_Author.Visible = False
        Panel6_Supplier.Visible = False
        Panel7_Category.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel9_Penalty.Visible = False

    End Sub

    Private Sub Btn_author_maintenance_Click(sender As Object, e As EventArgs) Handles Btn_author_maintenance.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel5_Author.Visible = True
        Panel6_Supplier.Visible = False
        Panel7_Category.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel9_Penalty.Visible = False

    End Sub

    Private Sub Btn_supplier_maintenance_Click(sender As Object, e As EventArgs) Handles Btn_supplier_maintenance.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel5_Author.Visible = False
        Panel6_Supplier.Visible = True
        Panel7_Category.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel9_Penalty.Visible = False

    End Sub

    Private Sub Btn_category_maintenance_Click(sender As Object, e As EventArgs) Handles Btn_category_maintenance.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel5_Author.Visible = False
        Panel6_Supplier.Visible = False
        Panel7_Category.Visible = True
        Panel8_Penalty_Report.Visible = False
        Panel9_Penalty.Visible = False

    End Sub


    Private Sub Btn_penalty_report_Click(sender As Object, e As EventArgs) Handles Btn_penalty_report.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel5_Author.Visible = False
        Panel6_Supplier.Visible = False
        Panel7_Category.Visible = False
        Panel8_Penalty_Report.Visible = True
        Panel9_Penalty.Visible = False

    End Sub

    Private Sub Btn_penalty_Click(sender As Object, e As EventArgs) Handles Btn_penalty.Click

        Panel1_Books.Visible = False
        Panel2_Returned_Issued_Books.Visible = False
        Panel3_Borrower_Info.Visible = False
        Panel4_User_Acounts.Visible = False
        Panel5_Author.Visible = False
        Panel6_Supplier.Visible = False
        Panel7_Category.Visible = False
        Panel8_Penalty_Report.Visible = False
        Panel9_Penalty.Visible = True

    End Sub

    Private Sub Btn_logout_Click_1(sender As Object, e As EventArgs) Handles Btn_logout.Click

        If Btn_logout.Enabled = True Then

            Dim dialog As DialogResult

            dialog = MessageBox.Show("Do you want to logout?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If dialog = DialogResult.Yes Then

                Close()
                Fm_login.Show()

            End If

        End If

    End Sub


    ' /* Listed Books */

    Private Sub Txt_listed_books_search_TextChanged(sender As Object, e As EventArgs) Handles Txt_listed_books_search.TextChanged

        Try

            con.Open()

            sql = "SELECT   tbl_books.isbn,
                            tbl_books.book_name,
                            tbl_library_category.category_name,
                            tbl_books.qty,
                            tbl_library_author.author_name,
                            tbl_library_publisher.publisher_name,
                            tbl_books.publish_year,
                            tbl_library_supplier.supplier_full_name,
                            tbl_books.acquisition_date,
                            tbl_books.status,
                            tbl_books.primary_book_id

                    FROM tbl_books

                    INNER JOIN tbl_library_category ON tbl_books.primary_category_id = tbl_library_category.primary_category_id
                    INNER JOIN tbl_library_author ON tbl_books.primary_author_id = tbl_library_author.primary_author_id
                    INNER JOIN tbl_library_publisher ON tbl_books.primary_publisher_id = tbl_library_publisher.primary_publisher_id
                    INNER JOIN tbl_library_supplier ON tbl_books.primary_supplier_id = tbl_library_supplier.primary_supplier_id

                    WHERE   isbn LIKE '%" & Txt_listed_books_search.Text & "%' OR
                            book_name LIKE '%" & Txt_listed_books_search.Text & "%' OR
                            category_name LIKE '%" & Txt_listed_books_search.Text & "%' OR
                            author_name LIKE '%" & Txt_listed_books_search.Text & "%' OR
                            publisher_name LIKE '%" & Txt_listed_books_search.Text & "%' OR
                            supplier_full_name LIKE '%" & Txt_listed_books_search.Text & "%' OR
                            status LIKE '%" & Txt_listed_books_search.Text & "%'

                    ORDER BY primary_book_id DESC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            Lv_listed_books.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("isbn").ToString(),
                                            dr("book_name").ToString(),
                                            dr("category_name").ToString(),
                                            dr("qty").ToString(),
                                            dr("author_name").ToString(),
                                            dr("publisher_name").ToString(),
                                            dr("publish_year").ToString(),
                                            dr("supplier_full_name").ToString(),
                                            dr("acquisition_date").ToString(),
                                            dr("status").ToString(),
                                            dr("primary_book_id").ToString()})
                Lv_listed_books.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Lv_listed_books.Items.Count - 1

                If i Mod 2 = 0 Then

                    Lv_listed_books.Items(i).BackColor = Color.Azure
                    Lv_listed_books.Items(i).ForeColor = Color.Black

                Else

                    Lv_listed_books.Items(i).BackColor = Color.GhostWhite
                    Lv_listed_books.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Cb_listed_books_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_listed_books_category.SelectedIndexChanged

        Try

            If Cb_listed_books_category.Text = "All Category" Then

                Load_listed_books_data_table()

            Else

                con.Open()

                sql = "SELECT   tbl_books.isbn,
                                tbl_books.book_name,
                                tbl_library_category.category_name,
                                tbl_books.qty,
                                tbl_library_author.author_name,
                                tbl_library_publisher.publisher_name,
                                tbl_books.publish_year,
                                tbl_library_supplier.supplier_full_name,
                                tbl_books.acquisition_date,
                                tbl_books.status,
                                tbl_books.primary_book_id

                        FROM tbl_books

                        INNER JOIN tbl_library_category ON tbl_books.primary_category_id = tbl_library_category.primary_category_id
                        INNER JOIN tbl_library_author ON tbl_books.primary_author_id = tbl_library_author.primary_author_id
                        INNER JOIN tbl_library_publisher ON tbl_books.primary_publisher_id = tbl_library_publisher.primary_publisher_id
                        INNER JOIN tbl_library_supplier ON tbl_books.primary_supplier_id = tbl_library_supplier.primary_supplier_id

                        WHERE category_name LIKE '%" & Cb_listed_books_category.Text & "%'

                        ORDER BY primary_book_id DESC"

                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader
                Lv_listed_books.Items.Clear()

                Do While dr.Read

                    Dim lv As New ListViewItem({dr("isbn").ToString(),
                                                dr("book_name").ToString(),
                                                dr("category_name").ToString(),
                                                dr("qty").ToString(),
                                                dr("author_name").ToString(),
                                                dr("publisher_name").ToString(),
                                                dr("publish_year").ToString(),
                                                dr("supplier_full_name").ToString(),
                                                dr("acquisition_date").ToString(),
                                                dr("status").ToString(),
                                                dr("primary_book_id").ToString()})
                    Lv_listed_books.Items.Add(lv)

                Loop

                con.Close()

                For i As Integer = 0 To Lv_listed_books.Items.Count - 1

                    If i Mod 2 = 0 Then

                        Lv_listed_books.Items(i).BackColor = Color.Azure
                        Lv_listed_books.Items(i).ForeColor = Color.Black

                    Else

                        Lv_listed_books.Items(i).BackColor = Color.GhostWhite
                        Lv_listed_books.Items(i).ForeColor = Color.Black

                    End If

                Next

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Cb_listed_books_category_Click(sender As Object, e As EventArgs) Handles Cb_listed_books_category.Click

        Cb_listed_books_category.DroppedDown = True

    End Sub

    Private Sub Btn_listed_add_books_Click(sender As Object, e As EventArgs) Handles Btn_listed_add_books.Click

        Fm_add_books.update_Txt_isbn.Visible = False
        Fm_add_books.Show()
        Fm_add_books.Btn_update.Visible = False
        Me.Enabled = False

    End Sub

    Private Sub Btn_listed_books_update_Click(sender As Object, e As EventArgs) Handles Btn_listed_books_update.Click

        Fm_add_books.Txt_isbn.Visible = False

        If Lv_listed_books.SelectedItems.Count > 0 Then

            Fm_add_books.update_Txt_isbn.Text = Lv_listed_books.SelectedItems(0).Text
            Fm_add_books.Txt_book_name.Text = Lv_listed_books.SelectedItems(0).SubItems(1).Text
            Fm_add_books.Cb_book_category.Text = Lv_listed_books.SelectedItems(0).SubItems(2).Text
            Fm_add_books.Txt_book_qty.Text = Lv_listed_books.SelectedItems(0).SubItems(3).Text
            Fm_add_books.Txt_author.Text = Lv_listed_books.SelectedItems(0).SubItems(4).Text
            Fm_add_books.Txt_publisher.Text = Lv_listed_books.SelectedItems(0).SubItems(5).Text
            Fm_add_books.Dtp_publish_date.Text = Lv_listed_books.SelectedItems(0).SubItems(6).Text
            Fm_add_books.Txt_supplier_name.Text = Lv_listed_books.SelectedItems(0).SubItems(7).Text
            Fm_add_books.Dtp_acquisition_date.Text = Lv_listed_books.SelectedItems(0).SubItems(8).Text

            Fm_add_books.Show()
            Me.Enabled = False

        Else

            MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_listed_books_delete_Click(sender As Object, e As EventArgs) Handles Btn_listed_books_delete.Click

        Try

            If Lv_listed_books.SelectedItems.Count > 0 Then

                If Lv_listed_books.SelectedItems(0).SubItems(9).Text = "Borrowed" Then

                    MessageBox.Show("This book is unable to delete because the status is Borrowed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_listed_books_data_table()

                Else

                    con.Open()

                    Dim book_name = Lv_listed_books.SelectedItems(0).SubItems(1).Text 'nagkakaroon ng syntax error pag ginamit mismo yung "Lv_listed_books.SelectedItems(0).Text"
                    Dim dialog As DialogResult

                    dialog = MessageBox.Show("Do you want to delete " + Lv_listed_books.SelectedItems(0).SubItems(1).Text + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                    If dialog = DialogResult.Yes Then

                        sql = "DELETE FROM tbl_books
                                      WHERE primary_book_id = '" & Lv_listed_books.SelectedItems(0).SubItems(10).Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader

                        con.Close()

                        Load_listed_books_data_table()
                        MessageBox.Show(book_name + " was deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else

                        con.Close()

                        Load_listed_books_data_table()

                    End If

                End If

            Else

                MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Lv_listed_books_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_listed_books.SelectedIndexChanged

        If Lv_returned_borrowed_books.SelectedItems.Count > 0 Then

            Load_returned_borrowed_books_data_table()

        ElseIf Lv_student_info.SelectedItems.Count > 0 Then

            Load_borrower_info_data_table()

        ElseIf Lv_listed_accounts.SelectedItems.Count > 0 Then

            Load_listed_accounts_data_table()

        End If

    End Sub


    ' /* Returned Borrowed Books */

    Private Sub Txt_returned_borrowed_books_search_TextChanged(sender As Object, e As EventArgs) Handles Txt_returned_borrowed_books_search.TextChanged

        Try

            con.Open()

            sql = "SELECT   tbl_borrower.borrower_id,
                            tbl_borrower.last_name,
                            tbl_borrower.first_name,
                            tbl_books.book_name,
                            tbl_issued_books.issued_date,
                            tbl_issued_books.due_date,
                            tbl_issued_books.returned_date,
                            tbl_issued_books.primary_issued_book_id,
                            tbl_books.primary_book_id
                    
                    FROM tbl_issued_books

                    INNER JOIN tbl_borrower ON tbl_issued_books.primary_borrower_id = tbl_borrower.primary_borrower_id
                    INNER JOIN tbl_books ON tbl_issued_books.primary_book_id = tbl_books.primary_book_id

                    WHERE borrower_id LIKE '%" & Txt_returned_borrowed_books_search.Text & "%' OR
                            last_name LIKE '%" & Txt_returned_borrowed_books_search.Text & "%' OR
                            first_name LIKE '%" & Txt_returned_borrowed_books_search.Text & "%' OR
                            book_name LIKE '%" & Txt_returned_borrowed_books_search.Text & "%' OR
                            issued_date LIKE '%" & Txt_returned_borrowed_books_search.Text & "%' OR
                            due_date LIKE '%" & Txt_returned_borrowed_books_search.Text & "%' OR
                            returned_date LIKE '%" & Txt_returned_borrowed_books_search.Text & "%'

                    ORDER BY primary_issued_book_id DESC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()
            Lv_returned_borrowed_books.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("borrower_id").ToString(),
                                            dr("last_name").ToString() + ", " + dr("first_name").ToString(),
                                            dr("book_name").ToString(),
                                            dr("issued_date").ToString(),
                                            dr("due_date").ToString(),
                                            dr("returned_date").ToString(),
                                            dr("primary_issued_book_id").ToString(),
                                            dr("primary_book_id").ToString()})
                Lv_returned_borrowed_books.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Lv_returned_borrowed_books.Items.Count - 1

                If i Mod 2 = 0 Then

                    Lv_returned_borrowed_books.Items(i).BackColor = Color.Azure
                    Lv_returned_borrowed_books.Items(i).ForeColor = Color.Black

                Else

                    Lv_returned_borrowed_books.Items(i).BackColor = Color.GhostWhite
                    Lv_returned_borrowed_books.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_borrow_books_Click(sender As Object, e As EventArgs) Handles Btn_borrow_books.Click

        Fm_issued_books.Show()
        Me.Enabled = False

    End Sub

    Private Sub Btn_return_books_Click(sender As Object, e As EventArgs) Handles Btn_return_books.Click

        Fm_returned_books.Show()
        Me.Enabled = False

    End Sub

    Private Sub Lv_returned_borrowed_books_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_returned_borrowed_books.SelectedIndexChanged

        If Lv_listed_books.SelectedItems.Count > 0 Then

            Load_listed_books_data_table()

        ElseIf Lv_student_info.SelectedItems.Count > 0 Then

            Load_borrower_info_data_table()

        ElseIf Lv_listed_accounts.SelectedItems.Count > 0 Then

            Load_listed_accounts_data_table()

        End If

    End Sub


    ' /* Student Informaion */

    Private Sub Txt_student_info_search_TextChanged(sender As Object, e As EventArgs) Handles Txt_student_info_search.TextChanged

        Try

            con.Open()

            sql = "SELECT * FROM tbl_borrower
                            WHERE borrower_id LIKE '%" & Txt_student_info_search.Text & "%' OR
                                    last_name LIKE '%" & Txt_student_info_search.Text & "%' OR
                                    first_name LIKE '%" & Txt_student_info_search.Text & "%' OR
                                    middle_name LIKE '%" & Txt_student_info_search.Text & "%' OR
                                    gender = '" & Txt_student_info_search.Text & "' OR
                                    borrower_contact_no LIKE '%" & Txt_student_info_search.Text & "%' OR
                                    borrower_address LIKE '%" & Txt_student_info_search.Text & "%'
                            ORDER BY last_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()
            Lv_student_info.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("borrower_id").ToString(),
                                            dr("last_name").ToString(),
                                            dr("first_name").ToString(),
                                            dr("middle_name").ToString(),
                                            dr("gender").ToString(),
                                            dr("borrower_contact_no").ToString(),
                                            dr("borrower_address").ToString(),
                                            dr("primary_borrower_id").ToString()})
                Lv_student_info.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Lv_student_info.Items.Count - 1

                If i Mod 2 = 0 Then

                    Lv_student_info.Items(i).BackColor = Color.Azure
                    Lv_student_info.Items(i).ForeColor = Color.Black

                Else

                    Lv_student_info.Items(i).BackColor = Color.GhostWhite
                    Lv_student_info.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_student_info_add_Click(sender As Object, e As EventArgs) Handles Btn_student_info_add.Click

        Fm_add_borrower.Show()
        Fm_add_borrower.Btn_update.Visible = False
        Me.Enabled = False

    End Sub

    Private Sub Btn_student_info_delete_Click(sender As Object, e As EventArgs) Handles Btn_student_info_delete.Click

        Try

            If Lv_student_info.SelectedItems.Count > 0 Then

                con.Open()

                Dim student_name As String = Lv_student_info.SelectedItems(0).SubItems(2).Text + " " + Lv_student_info.SelectedItems(0).SubItems(1).Text 'nagkakaroon ng syntax error pag ginamit mismo yung "Lv_student_info.SelectedItems(0).SubItems(1).Text"
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + student_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_borrower
                                  WHERE primary_borrower_id = '" & Lv_student_info.SelectedItems(0).SubItems(7).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    Load_borrower_info_data_table()
                    MessageBox.Show(student_name + " was deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Close()

                    Load_borrower_info_data_table()

                End If

            Else

                MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Lv_student_info_DoubleClick(sender As Object, e As EventArgs) Handles Lv_student_info.DoubleClick

        Dim Gender As String

        If Lv_student_info.SelectedItems.Count > 0 Then

            Fm_add_borrower.Txt_borrower_id_number.Text = Lv_student_info.SelectedItems(0).Text
            Fm_add_borrower.Txt_borrower_last_name.Text = Lv_student_info.SelectedItems(0).SubItems(1).Text
            Fm_add_borrower.Txt_borrower_first_name.Text = Lv_student_info.SelectedItems(0).SubItems(2).Text
            Fm_add_borrower.Txt_borrower_middle_name.Text = Lv_student_info.SelectedItems(0).SubItems(3).Text

            Gender = Lv_student_info.SelectedItems(0).SubItems(4).Text

            If Gender = "MALE" Then
                Fm_add_borrower.Rb_male.Checked = True
            Else
                Fm_add_borrower.Rb_female.Checked = True
            End If

            Fm_add_borrower.Txt_borrower_contact_no.Text = Lv_student_info.SelectedItems(0).SubItems(5).Text
            Fm_add_borrower.Txt_borrower_address.Text = Lv_student_info.SelectedItems(0).SubItems(6).Text


            Fm_add_borrower.Txt_temp_borrower_id_number.Text = Lv_student_info.SelectedItems(0).Text


            Fm_add_borrower.Show()
            Me.Enabled = False

        End If

    End Sub

    Private Sub Lv_student_info_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_student_info.SelectedIndexChanged

        If Lv_listed_books.SelectedItems.Count > 0 Then

            Load_listed_books_data_table()

        ElseIf Lv_returned_borrowed_books.SelectedItems.Count > 0 Then

            Load_returned_borrowed_books_data_table()

        ElseIf Lv_listed_accounts.SelectedItems.Count > 0 Then

            Load_listed_accounts_data_table()

        End If

    End Sub


    ' /* Listed Accounts */

    Private Sub Txt_listed_accounts_search_TextChanged(sender As Object, e As EventArgs) Handles Txt_listed_accounts_search.TextChanged

        Try

            con.Open()

            sql = "SELECT * FROM tbl_admin
                            WHERE first_name LIKE '%" & Txt_listed_accounts_search.Text & "%' OR
                                    middle_name LIKE '%" & Txt_listed_accounts_search.Text & "%' OR
                                    last_name LIKE '%" & Txt_listed_accounts_search.Text & "%' OR
                                    gender = '" & Txt_listed_accounts_search.Text & "' OR
                                    birthday LIKE '%" & Txt_listed_accounts_search.Text & "%' OR
                                    contact_no Like '%" & Txt_listed_accounts_search.Text & "%' OR
                                    address Like '%" & Txt_listed_accounts_search.Text & "%' OR
                                    username Like '%" & Txt_listed_accounts_search.Text & "%' OR
                                    email Like '%" & Txt_listed_accounts_search.Text & "%' OR
                                    user_type Like '%" & Txt_listed_accounts_search.Text & "%'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()
            Lv_listed_accounts.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("first_name").ToString(),
                                            dr("middle_name").ToString(),
                                            dr("last_name").ToString(),
                                            dr("gender").ToString(),
                                            dr("birthday").ToString(),
                                            dr("contact_no").ToString(),
                                            dr("address").ToString(),
                                            dr("username").ToString(),
                                            dr("email").ToString(),
                                            dr("user_type").ToString(),
                                            dr("password").ToString(),
                                            dr("primary_admin_id").ToString()})
                Lv_listed_accounts.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Lv_listed_accounts.Items.Count - 1

                If i Mod 2 = 0 Then

                    Lv_listed_accounts.Items(i).BackColor = Color.Azure
                    Lv_listed_accounts.Items(i).ForeColor = Color.Black

                Else

                    Lv_listed_accounts.Items(i).BackColor = Color.GhostWhite
                    Lv_listed_accounts.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_listed_accounts_add_Click(sender As Object, e As EventArgs) Handles Btn_listed_accounts_add.Click

        Fm_admin_registration.Show()
        Fm_admin_registration.Btn_update.Visible = False
        Me.Enabled = False

    End Sub

    Private Sub Btn_listed_accounts_delete_Click(sender As Object, e As EventArgs) Handles Btn_listed_accounts_delete.Click

        If Lv_listed_accounts.SelectedItems.Count > 0 Then

            con.Open()

            Dim full_name As String = Lv_listed_accounts.SelectedItems(0).Text + " " + Lv_listed_accounts.SelectedItems(0).SubItems(2).Text 'nagkakaroon ng syntax error pag ginamit mismo yung "Lv_listed_accounts.SelectedItems(0).Text + " " + Lv_listed_accounts.SelectedItems(0).SubItems(1).Text + " " + Lv_listed_accounts.SelectedItems(0).SubItems(2).Text"
            Dim dialog As DialogResult

            dialog = MessageBox.Show("Do you want to delete " + Lv_listed_accounts.SelectedItems(0).Text + " " + Lv_listed_accounts.SelectedItems(0).SubItems(2).Text + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If dialog = DialogResult.Yes Then

                Try

                    sql = "DELETE FROM tbl_admin
                                  WHERE primary_admin_id = '" & Lv_listed_accounts.SelectedItems(0).SubItems(11).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    Load_listed_accounts_data_table()
                    MessageBox.Show(full_name + " was deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

            Else

                con.Close()

                Load_listed_accounts_data_table()

            End If

        Else

            MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Lv_listed_accounts_DoubleClick(sender As Object, e As EventArgs) Handles Lv_listed_accounts.DoubleClick

        Dim Gender As String

        If Lv_listed_accounts.SelectedItems.Count > 0 Then

            Fm_admin_registration.Txt_firstname.Text = Lv_listed_accounts.SelectedItems(0).Text
            Fm_admin_registration.Txt_middlename.Text = Lv_listed_accounts.SelectedItems(0).SubItems(1).Text
            Fm_admin_registration.Txt_lastname.Text = Lv_listed_accounts.SelectedItems(0).SubItems(2).Text

            Gender = Lv_listed_accounts.SelectedItems(0).SubItems(3).Text
            If Gender = "MALE" Then
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


            Fm_admin_registration.Txt_temp_username.Text = Lv_listed_accounts.SelectedItems(0).SubItems(7).Text
            Fm_admin_registration.Txt_temp_email.Text = Lv_listed_accounts.SelectedItems(0).SubItems(8).Text


            Fm_admin_registration.Show()
            Fm_admin_registration.Btn_save.Visible = False
            Fm_admin_registration.Txt_confirmpassword.Visible = False
            Me.Enabled = False

        Else

            MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Lv_listed_accounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_listed_accounts.SelectedIndexChanged

        If Lv_listed_books.SelectedItems.Count > 0 Then

            Load_listed_books_data_table()

        ElseIf Lv_returned_borrowed_books.SelectedItems.Count > 0 Then

            Load_returned_borrowed_books_data_table()

        ElseIf Lv_student_info.SelectedItems.Count > 0 Then

            Load_borrower_info_data_table()

        End If

    End Sub


    ' /* Listed Author */

    Private Sub Btn_author_add_Click(sender As Object, e As EventArgs) Handles Btn_author_add.Click

        Try

            If Txt_author_name.Text = "" Then

                MessageBox.Show("Please filled all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                con.Open()

                Dim author_name = Txt_author_name.Text

                sql = "SELECT * FROM tbl_library_author
                                WHERE author_name = '" & Txt_author_name.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                If dr.Read Then

                    MessageBox.Show("Author name already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    con.Close()

                Else

                    dr.Close()

                    sql = "INSERT INTO tbl_library_author (author_name)
                                    VALUE ('" & Txt_author_name.Text & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    Clear_author_fields()
                    Load_author_data_table()
                    MessageBox.Show(author_name + " has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_author_update_Click(sender As Object, e As EventArgs) Handles Btn_author_update.Click

        Try

            If Lv_author.SelectedItems.Count > 0 Then

                If Txt_author_name.Text = "" Then

                    MessageBox.Show("Please filled the field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Open()

                    'to make sure Author Name not exists while in update process
                    sql = "UPDATE tbl_library_author SET 
                                    author_name = '" & "" & "'                                        
                            WHERE primary_author_id = '" & Lv_author.SelectedItems(0).SubItems(1).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader
                    dr.Close()
                    '---------------------------------

                    sql = "SELECT * FROM tbl_library_author
                                    WHERE author_name = '" & Txt_author_name.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    If dr.Read Then

                        'returned previous Author Name
                        sql = "UPDATE tbl_library_author SET 
                                        author_name = '" & Txt_temp_author_name.Text & "'                                       
                               WHERE primary_author_id = '" & Lv_author.SelectedItems(0).SubItems(1).Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader
                        con.Close()
                        '---------------------------------

                        MessageBox.Show("Author Name already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else

                        Dim author_name As String = Txt_author_name.Text
                        Dim dialog As DialogResult

                        dialog = MessageBox.Show("Do you want to update " + author_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                        If dialog = DialogResult.Yes Then

                            dr.Close()

                            sql = "UPDATE tbl_library_author SET
                                            author_name = '" & Txt_author_name.Text & "'
                                    WHERE primary_author_id = '" & Lv_author.SelectedItems(0).SubItems(1).Text & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader

                            con.Close()

                            Clear_author_fields()
                            Load_author_data_table()
                            Load_listed_books_data_table()
                            MessageBox.Show("Author name updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Else

                            dr.Close()

                            'returned previous Author Name
                            sql = "UPDATE tbl_library_author SET 
                                            author_name = '" & Txt_temp_author_name.Text & "'                                       
                                   WHERE primary_author_id = '" & Lv_author.SelectedItems(0).SubItems(1).Text & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader
                            '---------------------------------

                            con.Close()

                            Clear_author_fields()
                            Load_author_data_table()

                        End If

                    End If

                End If

            Else

                MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_author_delete_Click(sender As Object, e As EventArgs) Handles Btn_author_delete.Click

        Try

            If Lv_author.SelectedItems.Count > 0 Then

                Dim author_name = Lv_author.SelectedItems(0).Text
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + author_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    con.Open()

                    sql = "DELETE FROM tbl_library_author
                                  WHERE primary_author_id = '" & Lv_author.SelectedItems(0).SubItems(1).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    Clear_author_fields()
                    Load_author_data_table()
                    MessageBox.Show(author_name + " was deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    Clear_author_fields()
                    Load_author_data_table()

                End If

            Else

                MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Lv_author_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_author.SelectedIndexChanged

        If Lv_author.SelectedItems.Count > 0 Then

            Txt_temp_author_name.Text = Lv_author.SelectedItems(0).Text
            Txt_author_name.Text = Lv_author.SelectedItems(0).Text

        Else

            Txt_author_name.Clear()

        End If

    End Sub

    Private Sub Txt_author_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_author_name.KeyPress

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
        If Txt_author_name.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub


    ' /* Listed Supplier */

    Private Sub Btn_supplier_add_Click(sender As Object, e As EventArgs) Handles Btn_supplier_add.Click

        Try

            If Txt_supplier_id.Text = "" Or
               Txt_supplier_lastname.Text = "" Or
               Txt_supplier_firstname.Text = "" Or
               Txt_supplier_contact.Text = "" Or
               Txt_supplier_email_address.Text = "" Or
               Txt_supplier_address.Text = "" Or
               Cb_supplier_source_type.Text = "--Select Source Type--" Then

                MessageBox.Show("Please filled all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                con.Open()

                sql = "SELECT * FROM tbl_library_supplier
                                WHERE supplier_id = '" & Txt_supplier_id.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                If dr.Read Then

                    con.Close()
                    MessageBox.Show("Supplier ID already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    dr.Close()

                    Dim full_name As String = Txt_supplier_lastname.Text + ", " + Txt_supplier_firstname.Text
                    Dim dialog As DialogResult

                    dialog = MessageBox.Show("Do you want to save " + full_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                    If dialog = DialogResult.Yes Then

                        sql = "INSERT INTO tbl_library_supplier (supplier_id,
                                                                last_name,
                                                                first_name,
                                                                supplier_full_name,
                                                                email_address,
                                                                contact,
                                                                address,
                                                                source_type)
                                        VALUE ('" & Txt_supplier_id.Text & "',
                                                '" & Txt_supplier_lastname.Text & "',
                                                '" & Txt_supplier_firstname.Text & "',
                                                '" & Txt_supplier_firstname.Text + " " + Txt_supplier_lastname.Text & "',
                                                '" & Txt_supplier_email_address.Text & "',
                                                '" & Txt_supplier_contact.Text & "',
                                                '" & Txt_supplier_address.Text & "',
                                                '" & Cb_supplier_source_type.Text & "')"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        con.Close()

                        Clear_supplier_fields()
                        Load_supplier_data_table()
                        MessageBox.Show(full_name + " has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else

                        con.Close()

                    End If

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_supplier_update_Click(sender As Object, e As EventArgs) Handles Btn_supplier_update.Click

        Try

            If Lv_supplier.SelectedItems.Count > 0 Then

                If Txt_supplier_id.Text = "" Or
                   Txt_supplier_lastname.Text = "" Or
                   Txt_supplier_firstname.Text = "" Or
                   Txt_supplier_contact.Text = "" Or
                   Txt_supplier_email_address.Text = "" Or
                   Txt_supplier_address.Text = "" Or
                   Cb_supplier_source_type.Text = "--Select Source Type--" Then

                    MessageBox.Show("Please filled all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Open()

                    'to make sure Supplier ID not exists while in update process
                    sql = "UPDATE tbl_library_supplier SET 
                                        supplier_id = '" & "" & "'                                        
                            WHERE primary_supplier_id = '" & Lv_supplier.SelectedItems(0).SubItems(6).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader
                    dr.Close()
                    '---------------------------------

                    sql = "SELECT * FROM tbl_library_supplier
                                    WHERE supplier_id = '" & Txt_supplier_id.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    If dr.Read Then

                        con.Close()

                        'returned previous Supplier ID
                        con.Open()
                        sql = "UPDATE tbl_library_supplier SET 
                                        supplier_id = '" & Txt_temp_supplier_id.Text & "'                                        
                                WHERE primary_supplier_id = '" & Lv_supplier.SelectedItems(0).SubItems(6).Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader
                        con.Close()
                        '---------------------------------

                        MessageBox.Show("Supplier ID already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else

                        Dim full_name As String = Txt_supplier_lastname.Text + ", " + Txt_supplier_firstname.Text
                        Dim dialog As DialogResult

                        dialog = MessageBox.Show("Do you want to update " + full_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                        If dialog = DialogResult.Yes Then

                            dr.Close()

                            sql = "UPDATE tbl_library_supplier SET 
                                            supplier_id = '" & Txt_supplier_id.Text & "',
                                            last_name = '" & Txt_supplier_lastname.Text & "',
                                            first_name = '" & Txt_supplier_firstname.Text & "',
                                            supplier_full_name = '" & Txt_supplier_firstname.Text + " " + Txt_supplier_lastname.Text & "',
                                            email_address = '" & Txt_supplier_email_address.Text & "',
                                            contact = '" & Txt_supplier_contact.Text & "',
                                            address = '" & Txt_supplier_address.Text & "',
                                            source_type = '" & Cb_supplier_source_type.Text & "'
                                   WHERE primary_supplier_id = '" & Lv_supplier.SelectedItems(0).SubItems(6).Text & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader

                            con.Close()

                            Clear_supplier_fields()
                            Load_supplier_data_table()
                            Load_listed_books_data_table()
                            MessageBox.Show(full_name + " was updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Else

                            dr.Close()

                            'returned previous Supplier ID
                            sql = "UPDATE tbl_library_supplier SET 
                                            supplier_id = '" & Txt_temp_supplier_id.Text & "'                                        
                                    WHERE primary_supplier_id = '" & Lv_supplier.SelectedItems(0).SubItems(6).Text & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader
                            '---------------------------------

                            con.Close()

                            Clear_supplier_fields()
                            Load_supplier_data_table()

                        End If

                    End If

                End If

            Else

                MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_supplier_delete_Click(sender As Object, e As EventArgs) Handles Btn_supplier_delete.Click

        Try

            If Lv_supplier.SelectedItems.Count > 0 Then

                con.Open()

                Dim supplier_name = Lv_supplier.SelectedItems(0).SubItems(1).Text
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + supplier_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_library_supplier
                                  WHERE primary_supplier_id = '" & Lv_supplier.SelectedItems(0).SubItems(6).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    Clear_supplier_fields()
                    Load_supplier_data_table()
                    MessageBox.Show(supplier_name + " was deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Close()

                    Clear_supplier_fields()
                    Load_supplier_data_table()

                End If

            Else

                MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Lv_supplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_supplier.SelectedIndexChanged

        If Lv_supplier.SelectedItems.Count > 0 Then

            Txt_supplier_id.Text = Lv_supplier.SelectedItems(0).Text
            Txt_supplier_email_address.Text = Lv_supplier.SelectedItems(0).SubItems(2).Text
            Txt_supplier_contact.Text = Lv_supplier.SelectedItems(0).SubItems(3).Text
            Txt_supplier_address.Text = Lv_supplier.SelectedItems(0).SubItems(4).Text
            Cb_supplier_source_type.Text = Lv_supplier.SelectedItems(0).SubItems(5).Text

            Txt_supplier_lastname.Text = Lv_supplier.SelectedItems(0).SubItems(7).Text
            Txt_supplier_firstname.Text = Lv_supplier.SelectedItems(0).SubItems(8).Text

            Txt_temp_supplier_id.Text = Lv_supplier.SelectedItems(0).Text

        End If

    End Sub

    Private Sub Cb_supplier_source_type_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_supplier_source_type.KeyPress

        'No input alphanumeric
        e.Handled = True

    End Sub

    Private Sub Cb_supplier_source_type_Click(sender As Object, e As EventArgs) Handles Cb_supplier_source_type.Click

        Cb_supplier_source_type.DroppedDown = True

    End Sub

    Private Sub Txt_supplier_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_supplier_id.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 11 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_id.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789- " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_supplier_firstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_supplier_firstname.KeyPress

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
        If Txt_supplier_firstname.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_supplier_lastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_supplier_lastname.KeyPress

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
        If Txt_supplier_lastname.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

    Private Sub Txt_supplier_email_address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_supplier_email_address.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 100 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_email_address.TextLength >= maxLength Then
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

    Private Sub Txt_supplier_contact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_supplier_contact.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 11 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_contact.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        'Input numeric only
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub Txt_supplier_address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_supplier_address.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Convert the entered character to uppercase
        e.KeyChar = Char.ToUpper(e.KeyChar)

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 200 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_supplier_address.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub


    ' /* Listed Category */

    Private Sub Btn_category_add_Click(sender As Object, e As EventArgs) Handles Btn_category_add.Click

        Try

            If Txt_category_description.Text = "" Then

                MessageBox.Show("Please filled the field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                con.Open()

                Dim category_description = Txt_category_description.Text

                sql = "SELECT * FROM tbl_library_category
                                WHERE category_name = '" & Txt_category_description.Text & "'"
                cmd = New MySqlCommand(sql, con)
                dr = cmd.ExecuteReader()

                If dr.Read Then

                    con.Close()
                    MessageBox.Show("Category Description already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    dr.Close()

                    sql = "INSERT INTO tbl_library_category (category_name)
                                    VALUE ('" & Txt_category_description.Text & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    Clear_category_fields()
                    Load_category_data_table()
                    Load_library_cb_category()
                    MessageBox.Show(category_description + " has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_category_update_Click(sender As Object, e As EventArgs) Handles Btn_category_update.Click

        Try

            If Lv_category.SelectedItems.Count > 0 Then

                If Txt_category_description.Text = "" Then

                    MessageBox.Show("Please filled the field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Open()

                    'to make sure Category Description not exists while in update process
                    sql = "UPDATE tbl_library_category SET
                                    category_name = '" & "" & "'                                        
                            WHERE primary_category_id = '" & Lv_category.SelectedItems(0).SubItems(1).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader
                    dr.Close()
                    '---------------------------------

                    sql = "SELECT * FROM tbl_library_category
                                    WHERE category_name = '" & Txt_category_description.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    If dr.Read Then

                        con.Close()

                        'returned previous Category Description
                        con.Open()
                        sql = "UPDATE tbl_library_category SET
                                        category_name = '" & Txt_temp_category_name.Text & "'                                        
                               WHERE primary_category_id = '" & Lv_category.SelectedItems(0).SubItems(1).Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader
                        con.Close()
                        '---------------------------------

                        MessageBox.Show("Category Description already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else

                        Dim category_description = Txt_category_description.Text
                        Dim dialog As DialogResult

                        dialog = MessageBox.Show("Do you want to update " + category_description + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                        If dialog = DialogResult.Yes Then

                            dr.Close()

                            sql = "UPDATE tbl_library_category SET
                                            category_name = '" & Txt_category_description.Text & "'
                                   WHERE primary_category_id = '" & Lv_category.SelectedItems(0).SubItems(1).Text & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader

                            con.Close()

                            Clear_category_fields()
                            Load_category_data_table()
                            Load_listed_books_data_table()
                            Load_library_cb_category()
                            MessageBox.Show(category_description + " was updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Else

                            dr.Close()

                            'returned previous Category ID
                            sql = "UPDATE tbl_library_category SET
                                            category_name = '" & Txt_temp_category_name.Text & "'                                        
                                   WHERE primary_category_id = '" & Lv_category.SelectedItems(0).SubItems(1).Text & "'"
                            cmd = New MySqlCommand(sql, con)
                            dr = cmd.ExecuteReader
                            '---------------------------------

                            con.Close()

                            Clear_category_fields()
                            Load_category_data_table()

                        End If

                    End If

                End If

            Else

                MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_category_delete_Click(sender As Object, e As EventArgs) Handles Btn_category_delete.Click

        Try

            If Lv_category.SelectedItems.Count > 0 Then

                con.Open()

                Dim category_description = Lv_category.SelectedItems(0).Text
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + category_description + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_library_category
                                  WHERE primary_category_id = '" & Lv_category.SelectedItems(0).SubItems(1).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    Clear_category_fields()
                    Load_category_data_table()
                    Load_library_cb_category()
                    MessageBox.Show(category_description + " was deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Close()

                    Clear_category_fields()
                    Load_category_data_table()

                End If

            Else

                MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Lv_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_category.SelectedIndexChanged

        If Lv_category.SelectedItems.Count > 0 Then

            Txt_temp_category_name.Text = Lv_category.SelectedItems(0).Text
            Txt_category_description.Text = Lv_category.SelectedItems(0).Text

        Else

            Txt_category_description.Clear()

        End If

    End Sub

    Private Sub Txt_category_description_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_category_description.KeyPress

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
        If Txt_category_description.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub


    '/* Library Penalty */

    Private Sub Btn_penalty_description_add_Click(sender As Object, e As EventArgs)

        Try

            If Txt_penalty_description.Text = "" Then

                MessageBox.Show("Please input penalty description", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                con.Open

                Dim penalty_description = Txt_penalty_description.Text
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to save " + penalty_description + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "INSERT INTO tbl_library_penalty (penalty_description)
                                  VALUE ('" & Txt_penalty_description.Text & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery

                    con.Close

                    Txt_penalty_description.Clear
                    Load_penalty_description_data_table
                    Load_library_cb_penalty_description
                    MessageBox.Show(penalty_description + " has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Close

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_penalty_description_update_Click(sender As Object, e As EventArgs)

        Try

            If Lv_penalty_description.SelectedItems.Count > 0 Then

                If Txt_penalty_description.Text = "" Then

                    MessageBox.Show("Please input penalty description", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Open

                    Dim penalty_description = Txt_penalty_description.Text
                    Dim dialog As DialogResult

                    dialog = MessageBox.Show("Do you want to update " + penalty_description + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                    If dialog = DialogResult.Yes Then



                        sql = "UPDATE tbl_library_penalty SET 
                                        penalty_description = '" & Txt_penalty_description.Text & "'                                    
                               WHERE primary_penalty_description_id = '" & Lv_penalty_description.SelectedItems(0).SubItems(1).Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        dr = cmd.ExecuteReader

                        con.Close

                        Txt_penalty_description.Clear
                        Load_penalty_description_data_table
                        Load_library_cb_penalty_description
                        MessageBox.Show(penalty_description + " was updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else

                        con.Close

                        Txt_penalty_description.Clear
                        Load_penalty_description_data_table

                    End If

                End If

            Else

                MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_penalty_description_delete_Click(sender As Object, e As EventArgs)

        Try

            If Lv_penalty_description.SelectedItems.Count > 0 Then

                con.Open

                Dim penalty_description = Lv_penalty_description.SelectedItems(0).Text
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + penalty_description + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_library_penalty
                                  WHERE primary_penalty_description_id = '" & Lv_penalty_description.SelectedItems(0).SubItems(1).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close

                    Txt_penalty_description.Clear
                    Load_penalty_description_data_table
                    Load_library_cb_penalty_description
                    MessageBox.Show(penalty_description + " was deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Close

                    Txt_penalty_description.Clear
                    Load_penalty_description_data_table

                End If

            Else

                MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Lv_penalty_description_SelectedIndexChanged(sender As Object, e As EventArgs)

        If Lv_penalty_description.SelectedItems.Count > 0 Then

            Txt_penalty_description.Text = Lv_penalty_description.SelectedItems(0).Text

        End If

    End Sub

    Private Sub Txt_penalty_description_KeyPress(sender As Object, e As KeyPressEventArgs)

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
        If Txt_category_description.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub


    '/* Penalty */

    Private Sub Cb_penalty_description_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_penalty_description.SelectedIndexChanged

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_penalty
                            WHERE penalty_description = '" & Cb_penalty_description.SelectedItem & "'"
            'GROUP BY author_name"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            If dr.Read() Then

                Txt_primary_penalty_description_id.Text = dr("primary_penalty_description_id")

            End If

            con.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_penalty_update_Click(sender As Object, e As EventArgs) Handles Btn_penalty_update.Click

        Try

            If Lv_penalty.SelectedItems.Count > 0 Then

                If Txt_penalty_id_number.Text = "" Or
                Txt_penalty_name.Text = "" Or
                Txt_penalty_book_name.Text = "" Or
                Txt_penalty_amount.Text = "" Or
                Cb_penalty_description.Text = "" Then

                    MessageBox.Show("Please filled all fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Open()

                    Dim penalty_name = Txt_penalty_name.Text
                    Dim dialog As DialogResult

                    dialog = MessageBox.Show("Do you want to update this penalty for " + penalty_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                    If dialog = DialogResult.Yes Then

                        sql = "UPDATE tbl_penalty SET 
                                        primary_borrower_id = '" & Txt_primary_student_name_id.Text & "',                                                                        
                                        primary_book_id = '" & Txt_primary_book_id.Text & "',
                                        penalty_amount = '" & Txt_penalty_amount.Text & "',
                                        primary_penalty_description_id = '" & Txt_primary_penalty_description_id.Text & "',                                    
                                        penalty_date = '" & Dtp_penalty_date.Value.ToString("MMM-dd-yyyy") & "'
                                WHERE primary_penalty_id = '" & Lv_penalty.SelectedItems(0).SubItems(6).Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        con.Close()

                        Clear_penalty_fields()
                        Load_penalty_data_table()
                        MessageBox.Show("Penalty for " + penalty_name + " has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else

                        con.Close()

                        Clear_penalty_fields()
                        Load_penalty_data_table()

                    End If

                End If

            Else

                MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_penalty_delete_Click(sender As Object, e As EventArgs) Handles Btn_penalty_delete.Click

        Try

            If Lv_penalty.SelectedItems.Count > 0 Then

                con.Open()

                Dim penalty_name = Txt_penalty_name.Text
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete this penalty for " + penalty_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_penalty                                    
                            WHERE primary_penalty_id = '" & Lv_penalty.SelectedItems(0).SubItems(6).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    con.Close()

                    Clear_penalty_fields()
                    Load_penalty_data_table()
                    MessageBox.Show("Penalty for " + penalty_name + " has been deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Close()

                    Clear_penalty_fields()
                    Load_penalty_data_table()

                End If

            Else

                MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Lv_penalty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_penalty.SelectedIndexChanged

        If Lv_penalty.SelectedItems.Count > 0 Then

            Txt_penalty_id_number.Text = Lv_penalty.SelectedItems(0).Text
            Txt_penalty_name.Text = Lv_penalty.SelectedItems(0).SubItems(1).Text
            Txt_penalty_book_name.Text = Lv_penalty.SelectedItems(0).SubItems(2).Text
            Txt_penalty_amount.Text = Lv_penalty.SelectedItems(0).SubItems(3).Text
            Cb_penalty_description.Text = Lv_penalty.SelectedItems(0).SubItems(4).Text
            Dtp_penalty_date.Text = Lv_penalty.SelectedItems(0).SubItems(5).Text

            Txt_primary_penalty_description_id.Text = Lv_penalty.SelectedItems(0).SubItems(7).Text
            Txt_primary_student_name_id.Text = Lv_penalty.SelectedItems(0).SubItems(8).Text
            Txt_primary_book_id.Text = Lv_penalty.SelectedItems(0).SubItems(9).Text

        End If

    End Sub

    Private Sub Cb_penalty_description_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_penalty_description.KeyPress

        'No input alphanumeric
        e.Handled = True

    End Sub

    Private Sub Cb_penalty_description_Click(sender As Object, e As EventArgs) Handles Cb_penalty_description.Click

        Cb_penalty_description.DroppedDown = True

    End Sub

    Private Sub Txt_penalty_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_penalty_amount.KeyPress

        ' Check if the entered key is a control key (e.g., Backspace)
        If Char.IsControl(e.KeyChar) Then
            ' Allow control keys
            Return
        End If

        ' Define the maximum length for the TextBox
        Dim maxLength As Integer = 10 ' Change this to the desired maximum length

        ' Check if the length of the TextBox text exceeds the maximum length
        If Txt_penalty_amount.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        'Input numeric only
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

End Class