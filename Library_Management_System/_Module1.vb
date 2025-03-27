'Database Connection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Module Module1

    Public con As New MySqlConnection
    Public sql As String
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader

    Public Sub Connection()

        Try

            con = New MySqlConnection("datasource = localhost; username = root; password =; database = db_lms")
            con.Open()
            con.Close()
            'MessageBox.Show("Connected to Database")

        Catch ex As Exception

            MessageBox.Show("Please configure Database")

        End Try

    End Sub

    Public Sub RoundCorners(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.FromArgb(249, 228, 188)

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()

        'TOP LEFT CORNER
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 80)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'TOP RIGHT CORNER
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'BOTTOM RIGHT CORNER
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'BOTTTOM LEFT CORNER
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub


    'L oad login function

    Public Sub Load_login(e As KeyPressEventArgs)

        If e.KeyChar = ChrW(13) Then 'No. 13 is the number code "Enter" from keyboard by ASC code value

            If Fm_login.Txt_username.Text = "" And Fm_login.Txt_password.Text = "" Then

                MessageBox.Show("Please input your Username and Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Fm_login.Txt_username.Text = "" Then

                MessageBox.Show("Please input your username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf Fm_login.Txt_password.Text = "" Then

                MessageBox.Show("Please input your password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                Try

                    con.Open()

                    sql = "SELECT * FROM tbl_admin
                                    WHERE username = '" & Fm_login.Txt_username.Text & "'
                                    AND password = '" & Fm_login.Txt_password.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    dr = cmd.ExecuteReader()

                    If dr.Read() = True Then

                        If dr("user_type") = "ASSISTANT LIBRARIAN" Then

                            Fm_home_page.Show()
                            Clear_login_fields()
                            Fm_login.Hide()

                        Else

                            Fm_home_page.Show()
                            Fm_home_page.Btn_listed_accounts.Visible = False
                            Fm_home_page.Btn_author_category_penalty_publisher_maintenance.Visible = False
                            Fm_home_page.Btn_supplier_maintenance.Visible = False
                            Clear_login_fields()
                            Fm_login.Hide()

                        End If

                    Else

                        MessageBox.Show("Incorret username or password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Clear_login_fields()

                    End If

                    con.Close()

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

            End If

        End If

    End Sub


    ' Load all Listviews

    Public Sub Load_listed_books_data_table()

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

                    ORDER BY primary_book_id DESC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_listed_books.Items.Clear()

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
                Fm_home_page.Lv_listed_books.Items.Add(lv)

            Loop

            'Fm_home_page.Lv_listed_books.Columns(0).Text = "BOOK NAME" '- create title of column header
            'Fm_home_page.Lv_listed_books.Columns(1).Text = "CATEGORY"
            'Fm_home_page.Lv_listed_books.Columns(2).Text = "QUANTITY"
            'Fm_home_page.Lv_listed_books.Columns(3).Text = "AUTHOR"
            'Fm_home_page.Lv_listed_books.Columns(4).Text = "PUBLISHER"
            'Fm_home_page.Lv_listed_books.Columns(5).Text = "PUBLISH YEAR"
            'Fm_home_page.Lv_listed_books.Columns(6).Text = "SUPPLIER"
            'Fm_home_page.Lv_listed_books.Columns(7).Text = "AQUISITION DATE"
            'Fm_home_page.Lv_listed_books.Columns(8).Text = "STATUS"

            con.Close()

            For i As Integer = 0 To Fm_home_page.Lv_listed_books.Items.Count - 1

                If i Mod 2 = 0 Then

                    Fm_home_page.Lv_listed_books.Items(i).BackColor = Color.Azure
                    Fm_home_page.Lv_listed_books.Items(i).ForeColor = Color.Black

                Else

                    Fm_home_page.Lv_listed_books.Items(i).BackColor = Color.GhostWhite
                    Fm_home_page.Lv_listed_books.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Load_returned_borrowed_books_data_table()

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
                            
                    ORDER BY primary_issued_book_id DESC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_returned_borrowed_books.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("borrower_id").ToString(),
                                            dr("last_name").ToString() + ", " + dr("first_name").ToString(),
                                            dr("book_name").ToString(),
                                            dr("issued_date").ToString(),
                                            dr("due_date").ToString(),
                                            dr("returned_date").ToString(),
                                            dr("primary_issued_book_id").ToString(),
                                            dr("primary_book_id").ToString()})
                Fm_home_page.Lv_returned_borrowed_books.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Fm_home_page.Lv_returned_borrowed_books.Items.Count - 1

                If i Mod 2 = 0 Then

                    Fm_home_page.Lv_returned_borrowed_books.Items(i).BackColor = Color.Azure
                    Fm_home_page.Lv_returned_borrowed_books.Items(i).ForeColor = Color.Black

                Else

                    Fm_home_page.Lv_returned_borrowed_books.Items(i).BackColor = Color.GhostWhite
                    Fm_home_page.Lv_returned_borrowed_books.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Load_borrower_info_data_table()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_borrower
                            ORDER BY last_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_borrower_info.Items.Clear()

            Do While dr.Read

                'dr("student_name").ToString() + ", " + dr("gender").ToString() '/* concatinate of 2 columns in 1 set column on listview */
                Dim lv As New ListViewItem({dr("borrower_id").ToString(),
                                            dr("last_name").ToString(),
                                            dr("first_name").ToString(),
                                            dr("middle_name").ToString(),
                                            dr("gender").ToString(),
                                            dr("borrower_contact_no").ToString(),
                                            dr("borrower_address").ToString(),
                                            dr("primary_borrower_id").ToString()})
                Fm_home_page.Lv_borrower_info.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Fm_home_page.Lv_borrower_info.Items.Count - 1

                If i Mod 2 = 0 Then

                    Fm_home_page.Lv_borrower_info.Items(i).BackColor = Color.Azure
                    Fm_home_page.Lv_borrower_info.Items(i).ForeColor = Color.Black

                Else

                    Fm_home_page.Lv_borrower_info.Items(i).BackColor = Color.GhostWhite
                    Fm_home_page.Lv_borrower_info.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Load_listed_accounts_data_table()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_admin"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_listed_accounts.Items.Clear()

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
                Fm_home_page.Lv_listed_accounts.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Fm_home_page.Lv_listed_accounts.Items.Count - 1

                If i Mod 2 = 0 Then

                    Fm_home_page.Lv_listed_accounts.Items(i).BackColor = Color.Azure
                    Fm_home_page.Lv_listed_accounts.Items(i).ForeColor = Color.Black

                Else

                    Fm_home_page.Lv_listed_accounts.Items(i).BackColor = Color.GhostWhite
                    Fm_home_page.Lv_listed_accounts.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Load_supplier_data_table()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_supplier"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_supplier.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("supplier_id").ToString(),
                                            dr("supplier_name").ToString(),
                                            dr("last_name").ToString() + ", " + dr("first_name").ToString(),
                                            dr("email_address").ToString(),
                                            dr("contact").ToString(),
                                            dr("address").ToString(),
                                            dr("source_type").ToString(),
                                            dr("primary_supplier_id").ToString(),
                                            dr("first_name").ToString(),
                                            dr("last_name").ToString()})
                Fm_home_page.Lv_supplier.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Fm_home_page.Lv_supplier.Items.Count - 1

                If i Mod 2 = 0 Then

                    Fm_home_page.Lv_supplier.Items(i).BackColor = Color.Azure
                    Fm_home_page.Lv_supplier.Items(i).ForeColor = Color.Black

                Else

                    Fm_home_page.Lv_supplier.Items(i).BackColor = Color.GhostWhite
                    Fm_home_page.Lv_supplier.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Load_author_data_table()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_author
                            ORDER BY author_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_author.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("author_name").ToString(),
                                            dr("primary_author_id").ToString()})
                Fm_home_page.Lv_author.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Fm_home_page.Lv_author.Items.Count - 1

                If i Mod 2 = 0 Then

                    Fm_home_page.Lv_author.Items(i).BackColor = Color.Azure
                    Fm_home_page.Lv_author.Items(i).ForeColor = Color.Black

                Else

                    Fm_home_page.Lv_author.Items(i).BackColor = Color.GhostWhite
                    Fm_home_page.Lv_author.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Load_category_data_table()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_category
                            ORDER BY category_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_category.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("category_name").ToString(),
                                            dr("primary_category_id").ToString()})
                Fm_home_page.Lv_category.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Fm_home_page.Lv_category.Items.Count - 1

                If i Mod 2 = 0 Then

                    Fm_home_page.Lv_category.Items(i).BackColor = Color.Azure
                    Fm_home_page.Lv_category.Items(i).ForeColor = Color.Black

                Else

                    Fm_home_page.Lv_category.Items(i).BackColor = Color.GhostWhite
                    Fm_home_page.Lv_category.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Load_penalty_description_data_table()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_penalty
                            ORDER BY penalty_description ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_penalty_description.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("penalty_description").ToString(),
                                            dr("primary_penalty_description_id").ToString()})
                Fm_home_page.Lv_penalty_description.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Fm_home_page.Lv_penalty_description.Items.Count - 1

                If i Mod 2 = 0 Then

                    Fm_home_page.Lv_penalty_description.Items(i).BackColor = Color.Azure
                    Fm_home_page.Lv_penalty_description.Items(i).ForeColor = Color.Black

                Else

                    Fm_home_page.Lv_penalty_description.Items(i).BackColor = Color.GhostWhite
                    Fm_home_page.Lv_penalty_description.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Load_penalty_data_table()

        Try

            con.Open()

            sql = "SELECT   tbl_borrower.borrower_id,
                            tbl_borrower.last_name,
                            tbl_borrower.first_name,
                            tbl_books.book_name,
                            tbl_library_penalty.penalty_description,
                            tbl_penalty.penalty_amount,
                            tbl_penalty.penalty_date,
                            tbl_penalty.primary_penalty_id,
                            tbl_penalty.primary_penalty_description_id,
                            tbl_borrower.primary_borrower_id,
                            tbl_books.primary_book_id

                    FROM tbl_penalty

                    INNER JOIN tbl_borrower ON tbl_penalty.primary_borrower_id = tbl_borrower.primary_borrower_id
                    INNER JOIN tbl_books ON tbl_penalty.primary_book_id = tbl_books.primary_book_id
                    INNER JOIN tbl_library_penalty ON tbl_penalty.primary_penalty_description_id = tbl_library_penalty.primary_penalty_description_id

                    ORDER BY primary_penalty_id DESC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_penalty.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("borrower_id").ToString(),
                                            dr("last_name").ToString() + ", " + dr("first_name").ToString(),
                                            dr("book_name").ToString(),
                                            dr("penalty_amount").ToString(),
                                            dr("penalty_description").ToString(),
                                            dr("penalty_date").ToString(),
                                            dr("primary_penalty_id").ToString(),
                                            dr("primary_penalty_description_id").ToString(),
                                            dr("primary_borrower_id").ToString(),
                                            dr("primary_book_id").ToString()})
                Fm_home_page.Lv_penalty.Items.Add(lv)

            Loop

            con.Close()

            For i As Integer = 0 To Fm_home_page.Lv_penalty.Items.Count - 1

                If i Mod 2 = 0 Then

                    Fm_home_page.Lv_penalty.Items(i).BackColor = Color.Azure
                    Fm_home_page.Lv_penalty.Items(i).ForeColor = Color.Black

                Else

                    Fm_home_page.Lv_penalty.Items(i).BackColor = Color.GhostWhite
                    Fm_home_page.Lv_penalty.Items(i).ForeColor = Color.Black

                End If

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub


    ' Load all cb list

    Public Sub Load_library_cb_supplier()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_supplier"
            'GROUP BY supplier_name"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Fm_add_books.Cb_supplier_name.Items.Clear()

            Do While dr.Read()

                Fm_add_books.Cb_supplier_name.Items.Add(dr("supplier_name"))

            Loop

            con.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Load_library_cb_author()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_author"
            'GROUP BY author_name"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Fm_add_books.Cb_author.Items.Clear()

            Do While dr.Read()

                Fm_add_books.Cb_author.Items.Add(dr("author_name"))

            Loop

            con.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Load_library_cb_category()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_category"
            'GROUP BY author_name"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Fm_home_page.Cb_listed_books_category.Items.Clear()
            Fm_home_page.Cb_listed_books_category.Items.Add("All Category")

            Fm_add_books.Cb_book_category.Items.Clear()

            Do While dr.Read()

                Fm_home_page.Cb_listed_books_category.Items.Add(dr("category_name"))

                Fm_add_books.Cb_book_category.Items.Add(dr("category_name"))

            Loop

            con.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Load_library_cb_penalty_description()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_penalty"
            'GROUP BY author_name"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Fm_home_page.Cb_penalty_description.Items.Clear()

            Fm_add_penalty.Cb_penalty_description.Items.Clear()

            Do While dr.Read()

                Fm_add_penalty.Cb_penalty_description.Items.Add(dr("penalty_description"))

                Fm_add_penalty.Cb_penalty_description.Items.Add(dr("penalty_description"))

            Loop

            con.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub Load_library_cb_publisher()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_publisher"
            'GROUP BY publisher_name"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Fm_add_books.Cb_publisher.Items.Clear()

            Do While dr.Read()

                Fm_add_books.Cb_publisher.Items.Add(dr("publisher_name"))

            Loop

            con.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub


    ' Remove items selection on the other listview

    Public Sub remove_items_selection()

        Load_listed_books_data_table()
        Load_returned_borrowed_books_data_table()
        Load_borrower_info_data_table()
        Load_listed_accounts_data_table()
        Load_supplier_data_table()
        Load_author_data_table()
        Load_category_data_table()
        Load_penalty_description_data_table()
        Load_penalty_data_table()

    End Sub


    ' Load all clear fields

    Public Sub Clear_login_fields()

        Fm_login.Txt_username.Clear()
        Fm_login.Txt_password.Clear()
        Fm_login.Cb_show_password.Checked = False

    End Sub

    Public Sub Clear_penalty_fields()

        Fm_home_page.Txt_primary_student_name_id.Clear()

        Fm_home_page.Txt_penalty_id_number.Clear()
        Fm_home_page.Txt_penalty_name.Clear()
        Fm_home_page.Txt_penalty_book_name.Clear()
        Fm_home_page.Txt_penalty_amount.Clear()

        Fm_home_page.Txt_primary_penalty_description_id.Clear()

        Fm_home_page.Cb_penalty_description.Text = ""

    End Sub

End Module
