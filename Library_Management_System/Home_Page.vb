﻿Imports MySql.Data.MySqlClient

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

        Try

            con.Open()

            sql = "SELECT   tbl_books.isbn,
                            tbl_books.book_name,
                            tbl_library_category.category_name,
                            tbl_books.qty,
                            tbl_library_author.author_name,
                            tbl_library_publisher.publisher_name,
                            tbl_books.publish_year,
                            tbl_library_supplier.supplier_name,
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
                            supplier_name LIKE '%" & Txt_listed_books_search.Text & "%' OR
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
                                            dr("supplier_name").ToString(),
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

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Cb_listed_books_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_listed_books_category.SelectedIndexChanged

        If Cb_listed_books_category.Text = "All Category" Then

            Load_listed_books_data_table()

        Else

            Try

                con.Open()

                sql = "SELECT   tbl_books.isbn,
                                tbl_books.book_name,
                                tbl_library_category.category_name,
                                tbl_books.qty,
                                tbl_library_author.author_name,
                                tbl_library_publisher.publisher_name,
                                tbl_books.publish_year,
                                tbl_library_supplier.supplier_name,
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
                                                dr("supplier_name").ToString(),
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

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        End If

    End Sub

    Private Sub Cb_listed_books_category_Click(sender As Object, e As EventArgs) Handles Cb_listed_books_category.Click

        Cb_listed_books_category.DroppedDown = True

    End Sub

    Private Sub Btn_listed_books_add_Click(sender As Object, e As EventArgs) Handles Btn_listed_books_add.Click

        Fm_add_books.update_Txt_isbn.Visible = False
        Fm_add_books.Show()
        Fm_add_books.Btn_update.Visible = False
        Me.Enabled = False

    End Sub

    Private Sub Btn_listed_books_add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_listed_books_add.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_listed_books_add_MouseLeave(sender As Object, e As EventArgs) Handles Btn_listed_books_add.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_listed_books_edit_Click(sender As Object, e As EventArgs) Handles Btn_listed_books_edit.Click

        Fm_add_books.save_Txt_isbn.Visible = False

        If Lv_listed_books.SelectedItems.Count > 0 Then

            Fm_add_books.update_Txt_isbn.Text = Lv_listed_books.SelectedItems(0).Text
            Fm_add_books.Txt_book_name.Text = Lv_listed_books.SelectedItems(0).SubItems(1).Text
            Fm_add_books.Cb_book_category.Text = Lv_listed_books.SelectedItems(0).SubItems(2).Text
            Fm_add_books.Txt_book_qty.Text = Lv_listed_books.SelectedItems(0).SubItems(3).Text
            Fm_add_books.Txt_author.Text = Lv_listed_books.SelectedItems(0).SubItems(4).Text
            Fm_add_books.Txt_publisher.Text = Lv_listed_books.SelectedItems(0).SubItems(5).Text
            Fm_add_books.Dtp_publish_date.Value = Lv_listed_books.SelectedItems(0).SubItems(6).Text
            Fm_add_books.Txt_supplier_name.Text = Lv_listed_books.SelectedItems(0).SubItems(7).Text
            Fm_add_books.Dtp_acquisition_date.Value = Lv_listed_books.SelectedItems(0).SubItems(8).Text

            Fm_add_books.Txt_primary_category_id.Text = Lv_listed_books.SelectedItems(0).SubItems(11).Text

            Fm_add_books.Show()
            Me.Enabled = False

        Else

            MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_listed_books_edit_MouseEnter(sender As Object, e As EventArgs) Handles Btn_listed_books_edit.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_listed_books_edit_MouseLeave(sender As Object, e As EventArgs) Handles Btn_listed_books_edit.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Btn_listed_books_delete_Click(sender As Object, e As EventArgs) Handles Btn_listed_books_delete.Click

        If Lv_listed_books.SelectedItems.Count > 0 Then

            If Lv_listed_books.SelectedItems(0).SubItems(9).Text = "Borrowed" Then

                MessageBox.Show("This book is unable to delete because the status is Borrowed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Load_listed_books_data_table()

            Else

                Try

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
                        MessageBox.Show(book_name + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else

                        con.Close()

                        Load_listed_books_data_table()

                    End If

                Catch ex As Exception

                    MsgBox("Error: " & ex.Message)

                Finally

                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If

                End Try

            End If

        Else

            MessageBox.Show("Please select data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub Btn_listed_books_delete_MouseEnter(sender As Object, e As EventArgs) Handles Btn_listed_books_delete.MouseEnter

        Dim btn As Button = DirectCast(sender, Button)

        ' Change color on hover only if it's not selected
        If btn IsNot selectedButton Then
            btn.BackColor = Color.RoyalBlue
        End If

    End Sub

    Private Sub Btn_listed_books_delete_MouseLeave(sender As Object, e As EventArgs) Handles Btn_listed_books_delete.MouseLeave

        Dim btn As Button = DirectCast(sender, Button)

        ' Revert color when the mouse leaves, unless it's the selected button
        If btn IsNot selectedButton Then
            btn.BackColor = Color.Tan
        End If

    End Sub

    Private Sub Lv_listed_books_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_listed_books.SelectedIndexChanged

        'Remove items selection on the other listview
        If Lv_returned_borrowed_books.SelectedItems.Count > 0 Then

            Load_returned_borrowed_books_data_table()

        ElseIf Lv_borrower_info.SelectedItems.Count > 0 Then

            Load_borrower_info_data_table()

        ElseIf Lv_penalty.SelectedItems.Count > 0 Then

            Load_penalty_report_data_table()

        ElseIf Lv_listed_accounts.SelectedItems.Count > 0 Then

            Load_listed_accounts_data_table()

        ElseIf Lv_supplier.SelectedItems.Count > 0 Then

            Load_library_supplier_data_table()

        ElseIf Lv_author.SelectedItems.Count > 0 Then

            Load_library_author_data_table()

        ElseIf Lv_category.SelectedItems.Count > 0 Then

            Load_library_category_data_table()

        ElseIf Lv_penalty_description.SelectedItems.Count > 0 Then

            Load_library_penalty_data_table()

        ElseIf Lv_publisher.SelectedItems.Count > 0 Then

            Load_library_publisher_data_table()

        End If

    End Sub


    ' Returned Borrowed Books

    Private Sub Txt_returned_borrowed_books_search_TextChanged(sender As Object, e As EventArgs) Handles Txt_returned_borrowed_books_search.TextChanged

        Try

            con.Open()

            sql = "SELECT   CONCAT (tbl_issued_books.transaction_yyyy_mm, '-', LPAD(tbl_issued_books.transaction_series, 5, '0')) AS transaction_number,
                            tbl_borrower.borrower_id,
                            CONCAT (tbl_borrower.last_name, ', ', tbl_borrower.first_name) AS full_name,
                            tbl_books.book_name,
                            tbl_issued_books.issued_date,
                            tbl_issued_books.due_date,
                            tbl_issued_books.returned_date,
                            tbl_issued_books.primary_issued_book_id,
                            tbl_books.primary_book_id
                    
                    FROM tbl_issued_books

                    INNER JOIN tbl_borrower ON tbl_issued_books.primary_borrower_id = tbl_borrower.primary_borrower_id
                    INNER JOIN tbl_books ON tbl_issued_books.primary_book_id = tbl_books.primary_book_id

                    WHERE   CONCAT(transaction_yyyy_mm, '-', LPAD(transaction_series, 5, '0')) LIKE '%" & Txt_returned_borrowed_books_search.Text & "%' OR
                            borrower_id LIKE '%" & Txt_returned_borrowed_books_search.Text & "%' OR
                            CONCAT (tbl_borrower.last_name, ', ', tbl_borrower.first_name) LIKE '%" & Txt_returned_borrowed_books_search.Text & "%' OR
                            book_name LIKE '%" & Txt_returned_borrowed_books_search.Text & "%' OR
                            issued_date LIKE '%" & Txt_returned_borrowed_books_search.Text & "%' OR
                            due_date LIKE '%" & Txt_returned_borrowed_books_search.Text & "%' OR
                            returned_date LIKE '%" & Txt_returned_borrowed_books_search.Text & "%'

                    ORDER BY primary_issued_book_id DESC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()
            Lv_returned_borrowed_books.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("transaction_number").ToString(),
                                            dr("borrower_id").ToString(),
                                            dr("full_name").ToString(),
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

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

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

    Private Sub Lv_returned_borrowed_books_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_returned_borrowed_books.SelectedIndexChanged

        'Remove items selection on the other listview
        If Lv_listed_books.SelectedItems.Count > 0 Then

            Load_listed_books_data_table()

        ElseIf Lv_borrower_info.SelectedItems.Count > 0 Then

            Load_borrower_info_data_table()

        ElseIf Lv_penalty.SelectedItems.Count > 0 Then

            Load_penalty_report_data_table()

        ElseIf Lv_listed_accounts.SelectedItems.Count > 0 Then

            Load_listed_accounts_data_table()

        ElseIf Lv_supplier.SelectedItems.Count > 0 Then

            Load_library_supplier_data_table()

        ElseIf Lv_author.SelectedItems.Count > 0 Then

            Load_library_author_data_table()

        ElseIf Lv_category.SelectedItems.Count > 0 Then

            Load_library_category_data_table()

        ElseIf Lv_penalty_description.SelectedItems.Count > 0 Then

            Load_library_penalty_data_table()

        ElseIf Lv_publisher.SelectedItems.Count > 0 Then

            Load_library_publisher_data_table()

        End If

    End Sub


    ' Borrower Informaion

    Private Sub Txt_student_info_search_TextChanged(sender As Object, e As EventArgs) Handles Txt_student_info_search.TextChanged

        Try

            con.Open

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
            dr = cmd.ExecuteReader
            Lv_borrower_info.Items.Clear

            Do While dr.Read

                Dim lv As New ListViewItem({dr("borrower_id").ToString,
                                            dr("last_name").ToString,
                                            dr("first_name").ToString,
                                            dr("middle_name").ToString,
                                            dr("category_type").ToString,
                                            dr("gender").ToString,
                                            dr("borrower_contact_no").ToString,
                                            dr("email").ToString,
                                            dr("borrower_address").ToString,
                                            dr("primary_borrower_id").ToString})
                Lv_borrower_info.Items.Add(lv)

            Loop

            con.Close

            For i = 0 To Lv_borrower_info.Items.Count - 1

                If i Mod 2 = 0 Then

                    Lv_borrower_info.Items(i).BackColor = Color.Azure
                    Lv_borrower_info.Items(i).ForeColor = Color.Black

                Else

                    Lv_borrower_info.Items(i).BackColor = Color.GhostWhite
                    Lv_borrower_info.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close
            End If

        End Try

    End Sub

    Private Sub Btn_borrower_info_add_Click(sender As Object, e As EventArgs) Handles Btn_borrower_info_add.Click

        Fm_add_borrower.Show
        Fm_add_borrower.Btn_update.Visible = False
        Enabled = False

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

        Dim Gender As String

        If Lv_borrower_info.SelectedItems.Count > 0 Then

            Fm_add_borrower.Txt_borrower_id_number.Text = Lv_borrower_info.SelectedItems(0).Text
            Fm_add_borrower.Txt_borrower_last_name.Text = Lv_borrower_info.SelectedItems(0).SubItems(1).Text
            Fm_add_borrower.Txt_borrower_first_name.Text = Lv_borrower_info.SelectedItems(0).SubItems(2).Text
            Fm_add_borrower.Txt_borrower_middle_name.Text = Lv_borrower_info.SelectedItems(0).SubItems(3).Text
            Fm_add_borrower.Cb_borrower_category_type.Text = Lv_borrower_info.SelectedItems(0).SubItems(4).Text


            Gender = Lv_borrower_info.SelectedItems(0).SubItems(5).Text

            If Gender = "MALE" Then
                Fm_add_borrower.Rb_male.Checked = True
            Else
                Fm_add_borrower.Rb_female.Checked = True
            End If

            Fm_add_borrower.Txt_borrower_contact_no.Text = Lv_borrower_info.SelectedItems(0).SubItems(6).Text
            Fm_add_borrower.Txt_borrower_email.Text = Lv_borrower_info.SelectedItems(0).SubItems(7).Text
            Fm_add_borrower.Txt_borrower_address.Text = Lv_borrower_info.SelectedItems(0).SubItems(8).Text

            Fm_add_borrower.Show
            Enabled = False

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

                con.Open

                Dim student_name = Lv_borrower_info.SelectedItems(0).SubItems(2).Text + " " + Lv_borrower_info.SelectedItems(0).SubItems(1).Text 'nagkakaroon ng syntax error pag ginamit mismo yung "Lv_student_info.SelectedItems(0).SubItems(1).Text"
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + student_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_borrower
                                  WHERE primary_borrower_id = '" & Lv_borrower_info.SelectedItems(0).SubItems(9).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close

                    Load_borrower_info_data_table
                    MessageBox.Show(student_name + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Close

                    Load_borrower_info_data_table

                End If

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close
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

    Private Sub Lv_borrower_info_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_borrower_info.SelectedIndexChanged

        'Remove items selection on the other listview
        If Lv_listed_books.SelectedItems.Count > 0 Then

            Load_listed_books_data_table

        ElseIf Lv_returned_borrowed_books.SelectedItems.Count > 0 Then

            Load_returned_borrowed_books_data_table

        ElseIf Lv_penalty.SelectedItems.Count > 0 Then

            Load_penalty_report_data_table

        ElseIf Lv_listed_accounts.SelectedItems.Count > 0 Then

            Load_listed_accounts_data_table

        ElseIf Lv_supplier.SelectedItems.Count > 0 Then

            Load_library_supplier_data_table

        ElseIf Lv_author.SelectedItems.Count > 0 Then

            Load_library_author_data_table

        ElseIf Lv_category.SelectedItems.Count > 0 Then

            Load_library_category_data_table

        ElseIf Lv_penalty_description.SelectedItems.Count > 0 Then

            Load_library_penalty_data_table

        ElseIf Lv_publisher.SelectedItems.Count > 0 Then

            Load_library_publisher_data_table

        End If

    End Sub


    ' Penalty Report

    Private Sub Txt_search_penalty_report_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_penalty_report.TextChanged

        Try

            con.Open()

            sql = "SELECT   tbl_borrower.borrower_id,
                            CONCAT (tbl_borrower.last_name, ', ', tbl_borrower.first_name) AS full_name,
                            tbl_books.book_name,
                            tbl_library_penalty.penalty_description,
                            tbl_library_penalty.amount,
                            tbl_penalty_report.penalty_date,
                            tbl_borrower.primary_borrower_id,
                            tbl_books.primary_book_id,
                            tbl_penalty_report.primary_penalty_description_id,
                            tbl_penalty_report.primary_penalty_id

                    FROM tbl_penalty_report

                    INNER JOIN tbl_borrower ON tbl_penalty_report.primary_borrower_id = tbl_borrower.primary_borrower_id
                    INNER JOIN tbl_books ON tbl_penalty_report.primary_book_id = tbl_books.primary_book_id
                    INNER JOIN tbl_library_penalty ON tbl_penalty_report.primary_penalty_description_id = tbl_library_penalty.primary_penalty_description_id

                    WHERE   borrower_id LIKE '%" & Txt_search_penalty_report.Text & "%' OR
                            CONCAT (tbl_borrower.last_name, ', ', tbl_borrower.first_name) LIKE '%" & Txt_search_penalty_report.Text & "%' OR
                            book_name LIKE '%" & Txt_search_penalty_report.Text & "%' OR                            
                            penalty_description LIKE '%" & Txt_search_penalty_report.Text & "%' OR
                            amount LIKE '%" & Txt_search_penalty_report.Text & "%' OR
                            penalty_date LIKE '%" & Txt_search_penalty_report.Text & "%'

                    ORDER BY primary_penalty_id DESC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Lv_penalty.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("borrower_id").ToString(),
                                            dr("full_name").ToString(),
                                            dr("book_name").ToString(),
                                            dr("penalty_description").ToString(),
                                            dr("amount").ToString(),
                                            dr("penalty_date").ToString(),
                                            dr("primary_borrower_id").ToString(),
                                            dr("primary_book_id").ToString(),
                                            dr("primary_penalty_description_id").ToString(),
                                            dr("primary_penalty_id").ToString()})
                Lv_penalty.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Lv_penalty.Items.Count - 1

                If i Mod 2 = 0 Then

                    Lv_penalty.Items(i).BackColor = Color.Azure
                    Lv_penalty.Items(i).ForeColor = Color.Black

                Else

                    Lv_penalty.Items(i).BackColor = Color.GhostWhite
                    Lv_penalty.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Btn_penalty_edit_Click(sender As Object, e As EventArgs) Handles Btn_penalty_report_edit.Click

        If Lv_penalty.SelectedItems.Count > 0 Then

            Fm_add_penalty.Txt_borrower_id.Text = Lv_penalty.SelectedItems(0).Text
            Fm_add_penalty.Txt_borrower_name.Text = Lv_penalty.SelectedItems(0).SubItems(1).Text
            Fm_add_penalty.Txt_book_name.Text = Lv_penalty.SelectedItems(0).SubItems(2).Text

            Fm_add_penalty.Txt_primary_borrower_id.Text = Lv_penalty.SelectedItems(0).SubItems(6).Text
            Fm_add_penalty.Txt_primary_book_id.Text = Lv_penalty.SelectedItems(0).SubItems(7).Text

            Fm_add_penalty.Txt_primary_penalty_report_id.Text = Lv_penalty.SelectedItems(0).SubItems(9).Text

            Fm_add_penalty.Show()
            Fm_add_penalty.Btn_save.Visible = False
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

        If Lv_penalty.SelectedItems.Count > 0 Then

            Try
                con.Open()

                Dim full_name = Lv_penalty.SelectedItems(0).SubItems(1).Text
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete the penalty for " + full_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_penalty_report
                                  WHERE primary_penalty_id = '" & Lv_penalty.SelectedItems(0).SubItems(9).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    Load_penalty_report_data_table()
                    MessageBox.Show("Penalty deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Close()

                    Load_penalty_report_data_table()

                End If

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        Else

            MessageBox.Show("Please select on the list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub Lv_penalty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_penalty.SelectedIndexChanged

        'Remove items selection on the other listview
        If Lv_listed_books.SelectedItems.Count > 0 Then

            Load_listed_books_data_table()

        ElseIf Lv_returned_borrowed_books.SelectedItems.Count > 0 Then

            Load_returned_borrowed_books_data_table()

        ElseIf Lv_borrower_info.SelectedItems.Count > 0 Then

            Load_borrower_info_data_table()

        ElseIf Lv_listed_accounts.SelectedItems.Count > 0 Then

            Load_listed_accounts_data_table()

        ElseIf Lv_supplier.SelectedItems.Count > 0 Then

            Load_library_supplier_data_table()

        ElseIf Lv_author.SelectedItems.Count > 0 Then

            Load_library_author_data_table()

        ElseIf Lv_category.SelectedItems.Count > 0 Then

            Load_library_category_data_table()

        ElseIf Lv_penalty_description.SelectedItems.Count > 0 Then

            Load_library_penalty_data_table()

        ElseIf Lv_publisher.SelectedItems.Count > 0 Then

            Load_library_publisher_data_table()

        End If

    End Sub

    Private Sub Txt_search_penalty_report_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_penalty_report.KeyPress

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
        If Txt_search_penalty_report.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub


    ' Listed Accounts

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

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Btn_listed_accounts_add_Click(sender As Object, e As EventArgs) Handles Btn_listed_accounts_add.Click

        Fm_admin_registration.Show()
        Fm_admin_registration.Btn_update.Visible = False
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

            Fm_admin_registration.Show()
            Fm_admin_registration.Btn_save.Visible = False
            Fm_admin_registration.Txt_confirmpassword.Visible = False
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
                    MessageBox.Show(full_name + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Catch ex As Exception

                    MsgBox("Error: " & ex.Message)

                Finally

                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If

                End Try

            Else

                con.Close()

                Load_listed_accounts_data_table()

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

    Private Sub Lv_listed_accounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_listed_accounts.SelectedIndexChanged

        'Remove items selection on the other listview
        If Lv_listed_books.SelectedItems.Count > 0 Then

            Load_listed_books_data_table()

        ElseIf Lv_returned_borrowed_books.SelectedItems.Count > 0 Then

            Load_returned_borrowed_books_data_table()

        ElseIf Lv_borrower_info.SelectedItems.Count > 0 Then

            Load_borrower_info_data_table()

        ElseIf Lv_penalty.SelectedItems.Count > 0 Then

            Load_penalty_report_data_table()

        ElseIf Lv_supplier.SelectedItems.Count > 0 Then

            Load_library_supplier_data_table()

        ElseIf Lv_author.SelectedItems.Count > 0 Then

            Load_library_author_data_table()

        ElseIf Lv_category.SelectedItems.Count > 0 Then

            Load_library_category_data_table()

        ElseIf Lv_penalty_description.SelectedItems.Count > 0 Then

            Load_library_penalty_data_table()

        ElseIf Lv_publisher.SelectedItems.Count > 0 Then

            Load_library_publisher_data_table()

        End If

    End Sub

    Private Sub Txt_listed_accounts_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_listed_accounts_search.KeyPress

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
        If Txt_listed_accounts_search.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub


    ' Listed Supplier

    Private Sub Txt_search_supplier_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_supplier.TextChanged

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_supplier
                            WHERE supplier_id LIKE '%" & Txt_search_supplier.Text & "%' OR
                                  supplier_name LIKE '%" & Txt_search_supplier.Text & "%' OR
                                  last_name LIKE '%" & Txt_search_supplier.Text & "%' OR
                                  first_name LIKE '%" & Txt_search_supplier.Text & "%' OR
                                  email_address LIKE '%" & Txt_search_supplier.Text & "%' OR
                                  contact LIKE '%" & Txt_search_supplier.Text & "%' OR
                                  address LIKE '%" & Txt_search_supplier.Text & "%' OR
                                  source_type LIKE '%" & Txt_search_supplier.Text & "%'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Lv_supplier.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("supplier_id").ToString,
                                            dr("supplier_name").ToString,
                                            dr("last_name").ToString + ", " + dr("first_name").ToString,
                                            dr("email_address").ToString,
                                            dr("contact").ToString,
                                            dr("address").ToString,
                                            dr("source_type").ToString,
                                            dr("primary_supplier_id").ToString,
                                            dr("first_name").ToString,
                                            dr("last_name").ToString})
                Lv_supplier.Items.Add(lv)

            Loop

            con.Close()

            For i = 0 To Lv_supplier.Items.Count - 1

                If i Mod 2 = 0 Then

                    Lv_supplier.Items(i).BackColor = Color.Azure
                    Lv_supplier.Items(i).ForeColor = Color.Black

                Else

                    Lv_supplier.Items(i).BackColor = Color.GhostWhite
                    Lv_supplier.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Btn_supplier_add_Click(sender As Object, e As EventArgs) Handles Btn_supplier_add.Click

        Fm_supplier_maintenance.Show()
        Fm_supplier_maintenance.Btn_update.Visible = False
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

            Fm_supplier_maintenance.Show()

            Fm_supplier_maintenance.Txt_supplier_id.Text = Lv_supplier.SelectedItems(0).Text
            Fm_supplier_maintenance.Txt_supplier_name.Text = Lv_supplier.SelectedItems(0).SubItems(1).Text
            Fm_supplier_maintenance.Txt_supplier_firstname.Text = Lv_supplier.SelectedItems(0).SubItems(8).Text
            Fm_supplier_maintenance.Txt_supplier_lastname.Text = Lv_supplier.SelectedItems(0).SubItems(9).Text
            Fm_supplier_maintenance.Txt_supplier_email_address.Text = Lv_supplier.SelectedItems(0).SubItems(3).Text
            Fm_supplier_maintenance.Txt_supplier_contact.Text = Lv_supplier.SelectedItems(0).SubItems(4).Text
            Fm_supplier_maintenance.Txt_supplier_address.Text = Lv_supplier.SelectedItems(0).SubItems(5).Text
            Fm_supplier_maintenance.Cb_supplier_source_type.Text = Lv_supplier.SelectedItems(0).SubItems(6).Text

            Fm_supplier_maintenance.Btn_save.Visible = False
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
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + supplier_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_library_supplier
                                  WHERE primary_supplier_id = '" & Lv_supplier.SelectedItems(0).SubItems(7).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    Load_library_supplier_data_table()
                    MessageBox.Show(supplier_name + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    con.Close()

                    Load_library_supplier_data_table()

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

    Private Sub Lv_supplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lv_supplier.SelectedIndexChanged

        'Remove items selection on the other listview
        If Lv_listed_books.SelectedItems.Count > 0 Then

            Load_listed_books_data_table()

        ElseIf Lv_returned_borrowed_books.SelectedItems.Count > 0 Then

            Load_returned_borrowed_books_data_table()

        ElseIf Lv_borrower_info.SelectedItems.Count > 0 Then

            Load_borrower_info_data_table()

        ElseIf Lv_penalty.SelectedItems.Count > 0 Then

            Load_penalty_report_data_table()

        ElseIf Lv_listed_accounts.SelectedItems.Count > 0 Then

            Load_listed_accounts_data_table()

        ElseIf Lv_author.SelectedItems.Count > 0 Then

            Load_library_author_data_table()

        ElseIf Lv_category.SelectedItems.Count > 0 Then

            Load_library_category_data_table()

        ElseIf Lv_penalty_description.SelectedItems.Count > 0 Then

            Load_library_penalty_data_table()

        ElseIf Lv_publisher.SelectedItems.Count > 0 Then

            Load_library_publisher_data_table()

        End If

    End Sub

    Private Sub Txt_search_supplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_supplier.KeyPress

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
        If Txt_search_supplier.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub


    ' Listed Author

    Private Sub Txt_search_author_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_author.TextChanged

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_author
                            WHERE author_name LIKE '%" & Txt_search_author.Text & "%'
                            ORDER BY author_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Lv_author.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("author_name").ToString(),
                                            dr("primary_author_id").ToString()})
                Lv_author.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Lv_author.Items.Count - 1

                If i Mod 2 = 0 Then

                    Lv_author.Items(i).BackColor = Color.Azure
                    Lv_author.Items(i).ForeColor = Color.Black

                Else

                    Lv_author.Items(i).BackColor = Color.GhostWhite
                    Lv_author.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Btn_author_add_Click(sender As Object, e As EventArgs) Handles Btn_author_add.Click

        Fm_add_author.Show()
        Fm_add_author.Btn_update.Visible = False
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

            Fm_add_author.Show()
            Fm_add_author.Txt_author_name.Text = Lv_author.SelectedItems(0).Text
            Fm_add_author.Btn_save.Visible = False
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
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + author_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_library_author
                                  WHERE primary_author_id = '" & Lv_author.SelectedItems(0).SubItems(1).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    MessageBox.Show(author_name + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_library_category_data_table()

                Else

                    con.Close()

                    Load_library_category_data_table()

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
        If Lv_listed_books.SelectedItems.Count > 0 Then

            Load_listed_books_data_table()

        ElseIf Lv_returned_borrowed_books.SelectedItems.Count > 0 Then

            Load_returned_borrowed_books_data_table()

        ElseIf Lv_borrower_info.SelectedItems.Count > 0 Then

            Load_borrower_info_data_table()

        ElseIf Lv_penalty.SelectedItems.Count > 0 Then

            Load_penalty_report_data_table()

        ElseIf Lv_listed_accounts.SelectedItems.Count > 0 Then

            Load_listed_accounts_data_table()

        ElseIf Lv_supplier.SelectedItems.Count > 0 Then

            Load_library_supplier_data_table()

        ElseIf Lv_category.SelectedItems.Count > 0 Then

            Load_library_category_data_table()

        ElseIf Lv_penalty_description.SelectedItems.Count > 0 Then

            Load_library_penalty_data_table()

        ElseIf Lv_publisher.SelectedItems.Count > 0 Then

            Load_library_publisher_data_table()

        End If

    End Sub

    Private Sub Txt_search_author_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_author.KeyPress

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
        If Txt_search_author.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub


    ' Listed Category

    Private Sub Txt_category_description_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_category.TextChanged

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_category
                            WHERE category_name LIKE '%" & Txt_search_category.Text & "%'
                            ORDER BY category_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Lv_category.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("category_name").ToString(),
                                            dr("primary_category_id").ToString()})
                Lv_category.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Lv_category.Items.Count - 1

                If i Mod 2 = 0 Then

                    Lv_category.Items(i).BackColor = Color.Azure
                    Lv_category.Items(i).ForeColor = Color.Black

                Else

                    Lv_category.Items(i).BackColor = Color.GhostWhite
                    Lv_category.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Btn_category_add_Click(sender As Object, e As EventArgs) Handles Btn_category_add.Click

        Fm_add_category.Show()
        Fm_add_category.Btn_update.Visible = False
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

            Fm_add_category.Show()
            Fm_add_category.Txt_category_name.Text = Lv_category.SelectedItems(0).Text
            Fm_add_category.Btn_save.Visible = False
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
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + category_description + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_library_category
                                  WHERE primary_category_id = '" & Lv_category.SelectedItems(0).SubItems(1).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    MessageBox.Show(category_description + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_library_category_data_table()
                    Load_library_cb_category()

                Else

                    con.Close()

                    Load_library_category_data_table()

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
        If Lv_listed_books.SelectedItems.Count > 0 Then

            Load_listed_books_data_table()

        ElseIf Lv_returned_borrowed_books.SelectedItems.Count > 0 Then

            Load_returned_borrowed_books_data_table()

        ElseIf Lv_borrower_info.SelectedItems.Count > 0 Then

            Load_borrower_info_data_table()

        ElseIf Lv_penalty.SelectedItems.Count > 0 Then

            Load_penalty_report_data_table()

        ElseIf Lv_listed_accounts.SelectedItems.Count > 0 Then

            Load_listed_accounts_data_table()

        ElseIf Lv_supplier.SelectedItems.Count > 0 Then

            Load_library_supplier_data_table()

        ElseIf Lv_author.SelectedItems.Count > 0 Then

            Load_library_author_data_table()

        ElseIf Lv_penalty_description.SelectedItems.Count > 0 Then

            Load_library_penalty_data_table()

        ElseIf Lv_publisher.SelectedItems.Count > 0 Then

            Load_library_publisher_data_table()

        End If

    End Sub

    Private Sub Txt_search_category_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_category.KeyPress

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
        If Txt_search_category.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub


    ' Library Penalty

    Private Sub Txt_search_penalty_description_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_penalty_description.TextChanged

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_penalty
                            WHERE penalty_description LIKE '%" & Txt_search_penalty_description.Text & "%'
                            ORDER BY penalty_description ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Lv_penalty_description.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("penalty_description").ToString,
                                            dr("primary_penalty_description_id").ToString})
                Lv_penalty_description.Items.Add(lv)

            Loop

            con.Close()

            For i = 0 To Lv_penalty_description.Items.Count - 1

                If i Mod 2 = 0 Then

                    Lv_penalty_description.Items(i).BackColor = Color.Azure
                    Lv_penalty_description.Items(i).ForeColor = Color.Black

                Else

                    Lv_penalty_description.Items(i).BackColor = Color.GhostWhite
                    Lv_penalty_description.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Btn_penalty_description_add_Click(sender As Object, e As EventArgs) Handles Btn_penalty_description_add.Click

        Fm_penalty_description.Show()
        Fm_penalty_description.Btn_update.Visible = False
        Enabled = False

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

            Fm_penalty_description.Show()
            Fm_penalty_description.Txt_penalty_description.Text = Lv_penalty_description.SelectedItems(0).Text
            Fm_penalty_description.Txt_penalty_amount.Text = Lv_penalty_description.SelectedItems(0).SubItems(1).Text
            Fm_penalty_description.Btn_save.Visible = False
            Enabled = False

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
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + penalty_description + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_library_penalty
                           WHERE primary_penalty_description_id = '" & Lv_penalty_description.SelectedItems(0).SubItems(2).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    MessageBox.Show(penalty_description + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_library_penalty_data_table()

                Else

                    con.Close()

                    Load_library_penalty_data_table()

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
        If Lv_listed_books.SelectedItems.Count > 0 Then

            Load_listed_books_data_table()

        ElseIf Lv_returned_borrowed_books.SelectedItems.Count > 0 Then

            Load_returned_borrowed_books_data_table()

        ElseIf Lv_borrower_info.SelectedItems.Count > 0 Then

            Load_borrower_info_data_table()

        ElseIf Lv_penalty.SelectedItems.Count > 0 Then

            Load_penalty_report_data_table()

        ElseIf Lv_listed_accounts.SelectedItems.Count > 0 Then

            Load_listed_accounts_data_table()

        ElseIf Lv_supplier.SelectedItems.Count > 0 Then

            Load_library_supplier_data_table()

        ElseIf Lv_author.SelectedItems.Count > 0 Then

            Load_library_author_data_table()

        ElseIf Lv_category.SelectedItems.Count > 0 Then

            Load_library_category_data_table()

        ElseIf Lv_publisher.SelectedItems.Count > 0 Then

            Load_library_publisher_data_table()

        End If

    End Sub

    Private Sub Txt_search_penalty_description_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_penalty_description.KeyPress

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
        If Txt_search_penalty_description.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub


    ' Library Publisher

    Private Sub Txt_search_publisher_TextChanged(sender As Object, e As EventArgs) Handles Txt_search_publisher.TextChanged

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_publisher
                            WHERE publisher_name LIKE '%" & Txt_search_publisher.Text & "%'
                            ORDER BY publisher_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Lv_publisher.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("publisher_name").ToString(),
                                            dr("primary_publisher_id").ToString()})
                Lv_publisher.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Lv_publisher.Items.Count - 1

                If i Mod 2 = 0 Then

                    Lv_publisher.Items(i).BackColor = Color.Azure
                    Lv_publisher.Items(i).ForeColor = Color.Black

                Else

                    Lv_publisher.Items(i).BackColor = Color.GhostWhite
                    Lv_publisher.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Private Sub Btn_publisher_add_Click(sender As Object, e As EventArgs) Handles Btn_publisher_add.Click

        Fm_publisher.Show()
        Fm_publisher.Btn_update.Visible = False
        Enabled = False

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

            Fm_publisher.Show()
            Fm_publisher.Txt_publisher_name.Text = Lv_publisher.SelectedItems(0).Text
            Fm_publisher.Txt_publisher_name.Text = Lv_publisher.SelectedItems(0).SubItems(1).Text
            Fm_publisher.Btn_save.Visible = False
            Enabled = False

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
                Dim dialog As DialogResult

                dialog = MessageBox.Show("Do you want to delete " + publisher_name + " ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If dialog = DialogResult.Yes Then

                    sql = "DELETE FROM tbl_library_publisher
                            WHERE primary_publisher_id = '" & Lv_publisher.SelectedItems(0).SubItems(1).Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader

                    con.Close()

                    MessageBox.Show(publisher_name + " deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_library_publisher_data_table()

                Else

                    con.Close()

                    Load_library_publisher_data_table()

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
        If Lv_listed_books.SelectedItems.Count > 0 Then

            Load_listed_books_data_table()

        ElseIf Lv_returned_borrowed_books.SelectedItems.Count > 0 Then

            Load_returned_borrowed_books_data_table()

        ElseIf Lv_borrower_info.SelectedItems.Count > 0 Then

            Load_borrower_info_data_table()

        ElseIf Lv_penalty.SelectedItems.Count > 0 Then

            Load_penalty_report_data_table()

        ElseIf Lv_listed_accounts.SelectedItems.Count > 0 Then

            Load_listed_accounts_data_table()

        ElseIf Lv_supplier.SelectedItems.Count > 0 Then

            Load_library_supplier_data_table()

        ElseIf Lv_author.SelectedItems.Count > 0 Then

            Load_library_author_data_table()

        ElseIf Lv_category.SelectedItems.Count > 0 Then

            Load_library_category_data_table()

        ElseIf Lv_penalty_description.SelectedItems.Count > 0 Then

            Load_library_penalty_data_table()

        End If

    End Sub

    Private Sub Txt_search_publisher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search_publisher.KeyPress

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
        If Txt_search_publisher.TextLength >= maxLength Then
            ' Cancel the key press if the maximum length is reached
            e.Handled = True
            Return
        End If

        ' Define the allowed characters (in this example, only digits are allowed)
        Dim allowedChars = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789`~@#$%^&*()_-=+{}[]|;:'<>,.?/"" " ' Change this to the desired allowed characters

        ' Check if the entered key is an allowed character
        If Not allowedChars.Contains(e.KeyChar) Then
            ' Cancel the key press if the entered character is not allowed
            e.Handled = True
        End If

    End Sub

End Class