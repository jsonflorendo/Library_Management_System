'Database Connection
Imports System.IO
Imports System.Net.Mail
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


    ' Load login function

    Public Sub Load_login_keypress(e As KeyPressEventArgs, username As String, password As String)

        If e.KeyChar = ChrW(13) Then 'No. 13 is the number code "Enter" from keyboard by ASC code value

            If username = "" And password = "" Then

                Fm_login.Lbl_error_msg_1.Text = ""
                Fm_login.Lbl_error_msg.Text = "Please input your Username and Password"

            ElseIf username = "" Then

                Fm_login.Lbl_error_msg.Text = ""
                Fm_login.Lbl_error_msg_1.Text = "Please input your username"

            ElseIf password = "" Then

                Fm_login.Lbl_error_msg_1.Text = ""
                Fm_login.Lbl_error_msg.Text = "Please input your password"

            Else

                Try

                    con.Open()

                    sql = "SELECT * FROM tbl_admin
                                    WHERE username = '" & username & "'
                                    AND password = '" & password & "'"
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
                            Fm_login.Hide()

                        Else

                            Fm_home_page.Show()
                            Fm_home_page.Lbl_name_logged_in.Text = name
                            Fm_home_page.Lbl_user_type_logged_in.Text = user_type
                            Fm_home_page.Btn_listed_accounts.Visible = False
                            Fm_home_page.Btn_author_category_penalty_publisher_maintenance.Visible = False
                            Fm_home_page.Btn_supplier_maintenance.Visible = False
                            Clear_login_fields()
                            Clear_error_msg()
                            Fm_login.Hide()

                        End If

                    Else

                        Fm_login.Lbl_error_msg_1.Text = ""
                        Fm_login.Lbl_error_msg.Text = "Incorrect username or password"
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

        End If

    End Sub

    Public Sub Load_login_click(username As String, password As String)

        If username = "" And password = "" Then

            Fm_login.Lbl_error_msg_1.Text = ""
            Fm_login.Lbl_error_msg.Text = "Please input your Username and Password"

        ElseIf username = "" Then

            Fm_login.Lbl_error_msg.Text = ""
            Fm_login.Lbl_error_msg_1.Text = "Please input your username"

        ElseIf password = "" Then

            Fm_login.Lbl_error_msg_1.Text = ""
            Fm_login.Lbl_error_msg.Text = "Please input your password"

        Else

            Try

                con.Open()

                sql = "SELECT * FROM tbl_admin
                                WHERE username = '" & username & "'
                                AND password = '" & password & "'"
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
                        Fm_login.Hide()

                    Else

                        Fm_home_page.Show()
                        Fm_home_page.Lbl_name_logged_in.Text = name
                        Fm_home_page.Lbl_user_type_logged_in.Text = user_type
                        Fm_home_page.Btn_listed_accounts.Visible = False
                        Fm_home_page.Btn_author_category_penalty_publisher_maintenance.Visible = False
                        Fm_home_page.Btn_supplier_maintenance.Visible = False
                        Clear_login_fields()
                        Clear_error_msg()
                        Fm_login.Hide()

                    End If

                Else

                    Fm_login.Lbl_error_msg_1.Text = ""
                    Fm_login.Lbl_error_msg.Text = "Incorrect username or password"
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


    ' Load email function

    Public Sub SendBorrowerEmail(id_number As String, first_name As String, last_name As String, email_address As String, barcode_image As Image)

        Try

            ' Save barcode image temporarily
            Dim tempPath As String = Path.Combine(Path.GetTempPath(), $"Barcode_ID_Number_{id_number}.png")
            barcode_image.Save(tempPath, Imaging.ImageFormat.Png)

            ' Prepare email
            Dim mail As New MailMessage()
            mail.From = New MailAddress("LMS <jsonflorendo@gmail.com>")
            mail.To.Add(email_address)
            mail.Subject = "Barcode Details"
            mail.Body = $"Dear Mr/Ms {first_name} {last_name},{vbCrLf}{vbCrLf}" &
                        $"Here is your ID number: {id_number}{vbCrLf}" &
                        $"Attached is your Barcode ID for reference."
            mail.Attachments.Add(New Attachment(tempPath))

            Dim smtp As New SmtpClient("smtp-relay.brevo.com")
            smtp.Port = 587
            smtp.Credentials = New Net.NetworkCredential("8a9275002@smtp-brevo.com", "CSqORnDdxgvYQJsk")
            smtp.EnableSsl = True

            smtp.Send(mail)
            MessageBox.Show("Email sent successfully", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub


    ' Load all Listviews

    Public Sub Load_listed_books_data_table(listed_books_search As String)

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

                    FROM tbl_books

                    INNER JOIN tbl_library_category ON tbl_books.primary_category_id = tbl_library_category.primary_category_id
                    INNER JOIN tbl_library_author ON tbl_books.primary_author_id = tbl_library_author.primary_author_id
                    INNER JOIN tbl_library_publisher ON tbl_books.primary_publisher_id = tbl_library_publisher.primary_publisher_id

                    WHERE   isbn LIKE '%" & listed_books_search & "%' OR
                            book_name LIKE '%" & listed_books_search & "%' OR
                            category_name LIKE '%" & listed_books_search & "%' OR
                            author_name LIKE '%" & listed_books_search & "%' OR
                            publisher_name LIKE '%" & listed_books_search & "%'

                    ORDER BY primary_book_id DESC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_listed_books.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("isbn").ToString(),
                                            dr("book_name").ToString(),
                                            dr("category_name").ToString(),
                                            dr("author_name").ToString(),
                                            dr("publisher_name").ToString(),
                                            dr("publish_year").ToString(),
                                            dr("primary_book_id").ToString(),
                                            dr("primary_category_id")})
                Fm_home_page.Lv_listed_books.Items.Add(lv)

            Loop

            'Listview column header title
            Fm_home_page.Lv_listed_books.Columns(0).Text = "ISBN"
            Fm_home_page.Lv_listed_books.Columns(1).Text = "BOOK NAME"
            Fm_home_page.Lv_listed_books.Columns(2).Text = "GENRE"
            Fm_home_page.Lv_listed_books.Columns(3).Text = "AUTHOR"
            Fm_home_page.Lv_listed_books.Columns(4).Text = "PUBLISHER"
            Fm_home_page.Lv_listed_books.Columns(5).Text = "PUBLISH YEAR"

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

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Public Sub Load_returned_borrowed_books_data_table(returned_borrowed_books_search As String)

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

                    WHERE   CONCAT(transaction_yyyy_mm, '-', LPAD(transaction_series, 5, '0')) LIKE '%" & returned_borrowed_books_search & "%' OR
                            borrower_id LIKE '%" & returned_borrowed_books_search & "%' OR
                            CONCAT (tbl_borrower.last_name, ', ', tbl_borrower.first_name) LIKE '%" & returned_borrowed_books_search & "%' OR
                            book_name LIKE '%" & returned_borrowed_books_search & "%' OR
                            issued_date LIKE '%" & returned_borrowed_books_search & "%' OR
                            due_date LIKE '%" & returned_borrowed_books_search & "%' OR
                            returned_date LIKE '%" & returned_borrowed_books_search & "%'
                            
                    ORDER BY primary_issued_book_id DESC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_returned_borrowed_books.Items.Clear()

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
                Fm_home_page.Lv_returned_borrowed_books.Items.Add(lv)

            Loop

            'Listview column header title
            Fm_home_page.Lv_returned_borrowed_books.Columns(0).Text = "TRANSACTION NO"
            Fm_home_page.Lv_returned_borrowed_books.Columns(1).Text = "ID NUMBER"
            Fm_home_page.Lv_returned_borrowed_books.Columns(2).Text = "ISSUED TO"
            Fm_home_page.Lv_returned_borrowed_books.Columns(3).Text = "BOOK NAME"
            Fm_home_page.Lv_returned_borrowed_books.Columns(4).Text = "ISSUED DATE"
            Fm_home_page.Lv_returned_borrowed_books.Columns(5).Text = "DUE DATE"
            Fm_home_page.Lv_returned_borrowed_books.Columns(6).Text = "RETURNED DATE"

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

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Public Sub Load_penalty_report_data_table(penalty_report_search As String)

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

                    WHERE   borrower_id LIKE '%" & penalty_report_search & "%' OR
                            CONCAT (tbl_borrower.last_name, ', ', tbl_borrower.first_name) LIKE '%" & penalty_report_search & "%' OR
                            book_name LIKE '%" & penalty_report_search & "%' OR                            
                            penalty_description LIKE '%" & penalty_report_search & "%' OR
                            amount LIKE '%" & penalty_report_search & "%' OR
                            penalty_date LIKE '%" & penalty_report_search & "%'
                    
                    ORDER BY primary_penalty_id DESC"

            'GROUP BY tbl_penalty_report.primary_borrower_id,
            '         tbl_penalty_report.primary_book_id,
            '         tbl_penalty_report.penalty_date

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_penalty.Items.Clear()

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
                Fm_home_page.Lv_penalty.Items.Add(lv)

            Loop

            'Listview column header title
            Fm_home_page.Lv_penalty.Columns(0).Text = "ID NUMBER"
            Fm_home_page.Lv_penalty.Columns(1).Text = "NAME"
            Fm_home_page.Lv_penalty.Columns(2).Text = "BOOK NAME"
            Fm_home_page.Lv_penalty.Columns(3).Text = "PENALTY DESCRIPTION"
            Fm_home_page.Lv_penalty.Columns(4).Text = "PENALTY AMOUNT"
            Fm_home_page.Lv_penalty.Columns(5).Text = "DATE"

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

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Public Sub Load_borrower_info_data_table(student_info_search As String)

        Try

            con.Open()

            sql = "SELECT * FROM tbl_borrower

                            WHERE   borrower_id LIKE '%" & student_info_search & "%' OR
                                    last_name LIKE '%" & student_info_search & "%' OR
                                    first_name LIKE '%" & student_info_search & "%' OR
                                    middle_name LIKE '%" & student_info_search & "%' OR
                                    gender = '" & student_info_search & "' OR
                                    borrower_contact_no LIKE '%" & student_info_search & "%' OR
                                    borrower_address LIKE '%" & student_info_search & "%'

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
                                            dr("category_type").ToString(),
                                            dr("gender").ToString(),
                                            dr("borrower_contact_no").ToString(),
                                            dr("email").ToString(),
                                            dr("borrower_address").ToString(),
                                            dr("primary_borrower_id").ToString()})
                Fm_home_page.Lv_borrower_info.Items.Add(lv)

            Loop

            'Listview column header title
            Fm_home_page.Lv_borrower_info.Columns(0).Text = "ID NUMBER"
            Fm_home_page.Lv_borrower_info.Columns(1).Text = "LAST NAME"
            Fm_home_page.Lv_borrower_info.Columns(2).Text = "FIRST NAME"
            Fm_home_page.Lv_borrower_info.Columns(3).Text = "MIDDLE NAME"
            Fm_home_page.Lv_borrower_info.Columns(4).Text = "CATEGORY TYPE"
            Fm_home_page.Lv_borrower_info.Columns(5).Text = "GENDER"
            Fm_home_page.Lv_borrower_info.Columns(6).Text = "CONTACT NO"
            Fm_home_page.Lv_borrower_info.Columns(7).Text = "EMAIL"
            Fm_home_page.Lv_borrower_info.Columns(8).Text = "ADDRESS"

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

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Public Sub Load_listed_accounts_data_table(listed_accounts_search As String)

        Try

            con.Open()

            sql = "SELECT * FROM tbl_admin

                            WHERE   first_name Like '%" & listed_accounts_search & "%' OR
                                    middle_name Like '%" & listed_accounts_search & "%' OR
                                    last_name Like '%" & listed_accounts_search & "%' OR
                                    gender = '" & listed_accounts_search & "' OR
                                    birthday Like '%" & listed_accounts_search & "%' OR
                                    contact_no Like '%" & listed_accounts_search & "%' OR
                                    address Like '%" & listed_accounts_search & "%' OR
                                    username Like '%" & listed_accounts_search & "%' OR
                                    email Like '%" & listed_accounts_search & "%' OR
                                    user_type Like '%" & listed_accounts_search & "%'"

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

            'Listview column header title
            Fm_home_page.Lv_listed_accounts.Columns(0).Text = "FIRST NAME"
            Fm_home_page.Lv_listed_accounts.Columns(1).Text = "MIDDLE NAME"
            Fm_home_page.Lv_listed_accounts.Columns(2).Text = "LAST NAME"
            Fm_home_page.Lv_listed_accounts.Columns(3).Text = "GENDER"
            Fm_home_page.Lv_listed_accounts.Columns(4).Text = "BIRTHDAY"
            Fm_home_page.Lv_listed_accounts.Columns(5).Text = "CONTACT NO"
            Fm_home_page.Lv_listed_accounts.Columns(6).Text = "ADDRESS"
            Fm_home_page.Lv_listed_accounts.Columns(7).Text = "USERNAME"
            Fm_home_page.Lv_listed_accounts.Columns(8).Text = "EMAIL"
            Fm_home_page.Lv_listed_accounts.Columns(9).Text = "USER TYPE"

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

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Public Sub Load_library_supplier_data_table(supplier_search As String)

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_supplier

                            WHERE   supplier_id Like '%" & supplier_search & "%' OR
                                    supplier_name Like '%" & supplier_search & "%' OR
                                    last_name Like '%" & supplier_search & "%' OR
                                    first_name Like '%" & supplier_search & "%' OR
                                    email_address Like '%" & supplier_search & "%' OR
                                    contact Like '%" & supplier_search & "%' OR
                                    address Like '%" & supplier_search & "%' OR
                                    source_type Like '%" & supplier_search & "%'"

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

            'Listview column header title
            Fm_home_page.Lv_supplier.Columns(0).Text = "SUPPLIER ID"
            Fm_home_page.Lv_supplier.Columns(1).Text = "SUPPLIER NAME"
            Fm_home_page.Lv_supplier.Columns(2).Text = "FULL NAME"
            Fm_home_page.Lv_supplier.Columns(3).Text = "EMAIL ADDRESS"
            Fm_home_page.Lv_supplier.Columns(4).Text = "CONTACT NO"
            Fm_home_page.Lv_supplier.Columns(5).Text = "ADDRESS"
            Fm_home_page.Lv_supplier.Columns(6).Text = "SOURCE TYPE"

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

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Public Sub Load_library_author_data_table(author_search As String)

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_author

                            WHERE author_name LIKE '%" & author_search & "%'

                            ORDER BY author_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_author.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("author_name").ToString(),
                                            dr("primary_author_id").ToString()})
                Fm_home_page.Lv_author.Items.Add(lv)

            Loop

            'Listview column header title
            Fm_home_page.Lv_author.Columns(0).Text = "AUTHOR NAME"

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

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Public Sub Load_library_category_data_table(genre_search As String)

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_category

                            WHERE category_name LIKE '%" & genre_search & "%'

                            ORDER BY category_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_category.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("category_name").ToString(),
                                            dr("primary_category_id").ToString()})
                Fm_home_page.Lv_category.Items.Add(lv)

            Loop

            'Listview column header title
            Fm_home_page.Lv_category.Columns(0).Text = "CATEGORY NAME"

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

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Public Sub Load_library_penalty_data_table(penalty_description_search As String)

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_penalty

                            WHERE penalty_description LIKE '%" & penalty_description_search & "%'

                            ORDER BY penalty_description ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_penalty_description.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("penalty_description").ToString(),
                                            dr("amount").ToString(),
                                            dr("primary_penalty_description_id").ToString()})
                Fm_home_page.Lv_penalty_description.Items.Add(lv)

            Loop

            'Listview column header title
            Fm_home_page.Lv_penalty_description.Columns(0).Text = "PENALTY DESCRIPTION"
            Fm_home_page.Lv_penalty_description.Columns(1).Text = "AMOUNT"

            dr.Close()

            For i As Integer = 0 To Fm_home_page.Lv_penalty_description.Items.Count - 1

                If i Mod 2 = 0 Then

                    Fm_home_page.Lv_penalty_description.Items(i).BackColor = Color.Azure
                    Fm_home_page.Lv_penalty_description.Items(i).ForeColor = Color.Black

                Else

                    Fm_home_page.Lv_penalty_description.Items(i).BackColor = Color.GhostWhite
                    Fm_home_page.Lv_penalty_description.Items(i).ForeColor = Color.Black

                End If

            Next



            sql = "SELECT * FROM tbl_library_penalty
                            ORDER BY penalty_description ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_add_penalty.Lv_penalty_description.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("penalty_description").ToString(),
                                            dr("amount").ToString(),
                                            dr("primary_penalty_description_id").ToString()})
                Fm_add_penalty.Lv_penalty_description.Items.Add(lv)

            Loop

            'Listview column header title
            Fm_add_penalty.Lv_penalty_description.Columns(0).Text = "PENALTY DESCRIPTION"
            Fm_add_penalty.Lv_penalty_description.Columns(1).Text = "AMOUNT"

            con.Close()

            For i As Integer = 0 To Fm_add_penalty.Lv_penalty_description.Items.Count - 1

                If i Mod 2 = 0 Then

                    Fm_add_penalty.Lv_penalty_description.Items(i).BackColor = Color.Azure
                    Fm_add_penalty.Lv_penalty_description.Items(i).ForeColor = Color.Black

                Else

                    Fm_add_penalty.Lv_penalty_description.Items(i).BackColor = Color.GhostWhite
                    Fm_add_penalty.Lv_penalty_description.Items(i).ForeColor = Color.Black

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

    Public Sub Load_library_publisher_data_table(publisher_search As String)

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_publisher

                            WHERE publisher_name LIKE '%" & publisher_search & "%'

                            ORDER BY publisher_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_publisher.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("publisher_name").ToString(),
                                            dr("primary_publisher_id").ToString()})
                Fm_home_page.Lv_publisher.Items.Add(lv)

            Loop

            'Listview column header title
            Fm_home_page.Lv_publisher.Columns(0).Text = "PUBLISHER NAME"

            con.Close()

            For i As Integer = 0 To Fm_home_page.Lv_publisher.Items.Count - 1

                If i Mod 2 = 0 Then

                    Fm_home_page.Lv_publisher.Items(i).BackColor = Color.Azure
                    Fm_home_page.Lv_publisher.Items(i).ForeColor = Color.Black

                Else

                    Fm_home_page.Lv_publisher.Items(i).BackColor = Color.GhostWhite
                    Fm_home_page.Lv_publisher.Items(i).ForeColor = Color.Black

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

    Public Sub Load_shelf_data_table(shelf_search As String)

        Try

            con.Open()

            sql = "SELECT * FROM tbl_shelf

                            WHERE shelf_name LIKE '%" & shelf_search & "%' OR
                                  section LIKE '%" & shelf_search & "%' OR
                                  floor_number LIKE '%" & shelf_search & "%' OR
                                  capacity LIKE '%" & shelf_search & "%' OR
                                  current_load LIKE '%" & shelf_search & "%' OR
                                  created_at LIKE '%" & shelf_search & "%' OR
                                  updated_at LIKE '%" & shelf_search & "%'

                            ORDER BY shelf_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_shelf.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("shelf_id").ToString(),
                                            dr("shelf_name").ToString(),
                                            dr("section").ToString(),
                                            dr("floor_number").ToString(),
                                            dr("capacity").ToString(),
                                            dr("current_load").ToString(),
                                            dr("created_at").ToString(),
                                            dr("updated_at").ToString(),
                                            dr("primary_shelf_id").ToString()})
                Fm_home_page.Lv_shelf.Items.Add(lv)

            Loop

            'Listview column header title
            Fm_home_page.Lv_shelf.Columns(0).Text = "SHELF ID"
            Fm_home_page.Lv_shelf.Columns(1).Text = "SHELF NAME"
            Fm_home_page.Lv_shelf.Columns(2).Text = "SECTION"
            Fm_home_page.Lv_shelf.Columns(3).Text = "FLOOR NUMBER"
            Fm_home_page.Lv_shelf.Columns(4).Text = "CAPACITY"
            Fm_home_page.Lv_shelf.Columns(5).Text = "CURRENT LOAD"
            Fm_home_page.Lv_shelf.Columns(6).Text = "CREATED AT"
            Fm_home_page.Lv_shelf.Columns(7).Text = "UPDATED AT"

            con.Close()

            For i As Integer = 0 To Fm_home_page.Lv_shelf.Items.Count - 1

                If i Mod 2 = 0 Then

                    Fm_home_page.Lv_shelf.Items(i).BackColor = Color.Azure
                    Fm_home_page.Lv_shelf.Items(i).ForeColor = Color.Black

                Else

                    Fm_home_page.Lv_shelf.Items(i).BackColor = Color.GhostWhite
                    Fm_home_page.Lv_shelf.Items(i).ForeColor = Color.Black

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


    Public Sub Load_delivery_data_table(delivery_search As String)

        Try

            con.Open()

            sql = "SELECT   tbl_delivery.transaction_number,
                            tbl_books.isbn,
                            tbl_books.book_name,
                            tbl_delivery.quantity,
                            tbl_delivery.delivered_by,
                            tbl_delivery.delivery_date,
                            tbl_delivery.received_by                            

                    FROM tbl_delivery

                    INNER JOIN tbl_books ON tbl_books.primary_book_id = tbl_delivery.primary_book_id

                    WHERE   transaction_number LIKE '%" & delivery_search & "%' OR
                            isbn LIKE '%" & delivery_search & "%' OR
                            book_name LIKE '%" & delivery_search & "%' OR
                            quantity LIKE '%" & delivery_search & "%' OR
                            delivered_by LIKE '%" & delivery_search & "%' OR
                            delivery_date LIKE '%" & delivery_search & "%' OR
                            received_by LIKE '%" & delivery_search & "%'

                    ORDER BY delivery_date DESC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_delivery.Items.Clear()

            Do While dr.Read

                Dim lv As New ListViewItem({dr("transaction_number").ToString(),
                                            dr("isbn").ToString(),
                                            dr("book_name").ToString(),
                                            dr("quantity").ToString(),
                                            dr("delivered_by").ToString(),
                                            dr("delivery_date").ToString(),
                                            dr("received_by").ToString(),
                                            dr("primary_delivery_id")})
                Fm_home_page.Lv_delivery.Items.Add(lv)

            Loop

            'Listview column header title
            Fm_home_page.Lv_delivery.Columns(0).Text = "TRANSACTION NUMBER"
            Fm_home_page.Lv_delivery.Columns(1).Text = "ISBN"
            Fm_home_page.Lv_delivery.Columns(2).Text = "BOOK NAME"
            Fm_home_page.Lv_delivery.Columns(3).Text = "QUANTITY"
            Fm_home_page.Lv_delivery.Columns(4).Text = "DELIVERED BY"
            Fm_home_page.Lv_delivery.Columns(5).Text = "DELIVERY DATE"
            Fm_home_page.Lv_delivery.Columns(6).Text = "RECEIVED BY"

            con.Close()

            For i As Integer = 0 To Fm_home_page.Lv_delivery.Items.Count - 1

                If i Mod 2 = 0 Then

                    Fm_home_page.Lv_delivery.Items(i).BackColor = Color.Azure
                    Fm_home_page.Lv_delivery.Items(i).ForeColor = Color.Black

                Else

                    Fm_home_page.Lv_delivery.Items(i).BackColor = Color.GhostWhite
                    Fm_home_page.Lv_delivery.Items(i).ForeColor = Color.Black

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

    ' Remove items selection on the other listview

    Public Sub Load_all_data_tables()

        Load_listed_books_data_table(Fm_home_page.Txt_listed_books_search.Text)
        Load_returned_borrowed_books_data_table(Fm_home_page.Txt_returned_borrowed_books_search.Text)
        Load_penalty_report_data_table(Fm_home_page.Txt_search_penalty_report.Text)
        Load_borrower_info_data_table(Fm_home_page.Txt_student_info_search.Text)
        Load_listed_accounts_data_table(Fm_home_page.Txt_listed_accounts_search.Text)
        Load_library_supplier_data_table(Fm_home_page.Txt_search_supplier.Text)
        Load_library_author_data_table(Fm_home_page.Txt_search_author.Text)
        Load_library_category_data_table(Fm_home_page.Txt_search_category.Text)
        Load_library_penalty_data_table(Fm_home_page.Txt_search_penalty_description.Text)
        Load_library_publisher_data_table(Fm_home_page.Txt_search_publisher.Text)
        Load_shelf_data_table(Fm_home_page.Txt_search_shelf.Text)
        Load_delivery_data_table(Fm_home_page.Txt_search_delivery.Text)

    End Sub


    ' Load all cb list

    Public Sub Load_library_cb_category()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_category
                            ORDER BY category_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Fm_home_page.Cb_listed_books_category.Items.Clear()
            Fm_home_page.Cb_listed_books_category.Items.Add("All Genre")

            Fm_add_books.Cb_book_category.Items.Clear()

            Do While dr.Read()

                Fm_home_page.Cb_listed_books_category.Items.Add(dr("category_name"))
                Fm_add_books.Cb_book_category.Items.Add(dr("category_name"))

            Loop

            con.Close()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Public Sub Load_library_cb_author()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_author
                            GROUP BY author_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Fm_add_books.Cb_author.Items.Clear()

            Do While dr.Read()

                Fm_add_books.Cb_author.Items.Add(dr("author_name"))

            Loop

            con.Close()

        Catch ex As Exception

            MsgBox("Error:   " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Public Sub Load_library_cb_publisher()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_publisher
                            ORDER BY publisher_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Fm_add_books.Cb_publisher.Items.Clear()

            Do While dr.Read()

                Fm_add_books.Cb_publisher.Items.Add(dr("publisher_name"))

            Loop

            con.Close()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub


    ' Load clear all fields

    Public Sub Clear_login_fields()

        Fm_login.Txt_username.Clear()
        Fm_login.Txt_password.Clear()
        Fm_login.Cb_show_password.Checked = False

    End Sub


    ' Load clear all error messages

    Public Sub Clear_error_msg()

        Fm_login.Lbl_error_msg.Text = ""
        Fm_login.Lbl_error_msg_1.Text = ""

        Fm_add_books.Lbl_error_msg.Text = ""
        Fm_add_books.Lbl_error_msg_1.Text = ""
        Fm_add_books.Lbl_error_msg_2.Text = ""
        Fm_add_books.Lbl_error_msg_3.Text = ""
        Fm_add_books.Lbl_error_msg_4.Text = ""

        Fm_issued_books.Lbl_error_msg.Text = ""
        Fm_issued_books.Lbl_error_msg_1.Text = ""

        Fm_returned_books.Lbl_error_msg.Text = ""
        Fm_returned_books.Lbl_error_msg_1.Text = ""

        Fm_add_penalty.Lbl_error_msg.Text = ""

        Fm_add_borrower.Lbl_error_msg.Text = ""
        Fm_add_borrower.Lbl_error_msg_1.Text = ""
        Fm_add_borrower.Lbl_error_msg_2.Text = ""
        Fm_add_borrower.Lbl_error_msg_3.Text = ""
        Fm_add_borrower.Lbl_error_msg_4.Text = ""
        Fm_add_borrower.Lbl_error_msg_5.Text = ""
        Fm_add_borrower.Lbl_error_msg_6.Text = ""
        Fm_add_borrower.Lbl_error_msg_7.Text = ""
        Fm_add_borrower.Lbl_error_msg_8.Text = ""

        Fm_admin_registration.Lbl_error_msg.Text = ""
        Fm_admin_registration.Lbl_error_msg_1.Text = ""
        Fm_admin_registration.Lbl_error_msg_2.Text = ""
        Fm_admin_registration.Lbl_error_msg_3.Text = ""
        Fm_admin_registration.Lbl_error_msg_4.Text = ""
        Fm_admin_registration.Lbl_error_msg_5.Text = ""
        Fm_admin_registration.Lbl_error_msg_6.Text = ""
        Fm_admin_registration.Lbl_error_msg_7.Text = ""
        Fm_admin_registration.Lbl_error_msg_8.Text = ""
        Fm_admin_registration.Lbl_error_msg_9.Text = ""
        Fm_admin_registration.Lbl_error_msg_10.Text = ""
        Fm_admin_registration.Lbl_error_msg_11.Text = ""
        Fm_admin_registration.Lbl_error_msg_12.Text = ""

        Fm_supplier_maintenance.Lbl_error_msg.Text = ""
        Fm_supplier_maintenance.Lbl_error_msg_1.Text = ""
        Fm_supplier_maintenance.Lbl_error_msg_2.Text = ""
        Fm_supplier_maintenance.Lbl_error_msg_3.Text = ""
        Fm_supplier_maintenance.Lbl_error_msg_4.Text = ""
        Fm_supplier_maintenance.Lbl_error_msg_5.Text = ""
        Fm_supplier_maintenance.Lbl_error_msg_6.Text = ""
        Fm_supplier_maintenance.Lbl_error_msg_7.Text = ""

        Fm_add_author.Lbl_error_msg.Text = ""

        Fm_add_category.Lbl_error_msg.Text = ""

        Fm_penalty_description.Lbl_error_msg.Text = ""
        Fm_penalty_description.Lbl_error_msg_1.Text = ""

        Fm_publisher.Lbl_error_msg.Text = ""

        Fm_add_shelf.Lbl_error_msg.Text = ""
        Fm_add_shelf.Lbl_error_msg_1.Text = ""
        Fm_add_shelf.Lbl_error_msg_2.Text = ""
        Fm_add_shelf.Lbl_error_msg_3.Text = ""
        Fm_add_shelf.Lbl_error_msg_4.Text = ""
        Fm_add_shelf.Lbl_error_msg_5.Text = ""

        Fm_add_delivery.Lbl_error_msg.Text = ""
        Fm_add_delivery.Lbl_error_msg_1.Text = ""
        Fm_add_delivery.Lbl_error_msg_2.Text = ""
        Fm_add_delivery.Lbl_error_msg_3.Text = ""

    End Sub

End Module