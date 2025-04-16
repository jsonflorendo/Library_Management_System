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

    Public Sub SendBorrowerEmail(id_number As String, first_name As String, middle_name As String, last_name As String, email_address As String, barcode_image As Image)

        Try

            ' Save barcode image temporarily
            Dim tempPath As String = Path.Combine(Path.GetTempPath(), $"{id_number}_barcode.png")
            barcode_image.Save(tempPath, Imaging.ImageFormat.Png)

            ' Prepare email
            Dim mail As New MailMessage()
            mail.From = New MailAddress("jsonflorendo@gmail.com")
            mail.To.Add(email_address)
            mail.Subject = "Barcode Details"
            mail.Body = $"Hello {first_name} {middle_name} {last_name},{vbCrLf}{vbCrLf}" &
                        $"Here is your borrower ID number: {id_number}{vbCrLf}" &
                        $"Attached is your barcode for reference."

            mail.Attachments.Add(New Attachment(tempPath))

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New Net.NetworkCredential("jsonflorendo@gmail.com", "json0826904")
            smtp.EnableSsl = True

            smtp.Send(mail)
            MessageBox.Show("Email sent successfully!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

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
                            tbl_books.primary_book_id,
                            tbl_books.primary_category_id

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
                                            dr("primary_book_id").ToString(),
                                            dr("primary_category_id")})
                Fm_home_page.Lv_listed_books.Items.Add(lv)

            Loop

            'Listview column header title
            Fm_home_page.Lv_listed_books.Columns(0).Text = "ISBN"
            Fm_home_page.Lv_listed_books.Columns(1).Text = "BOOK NAME"
            Fm_home_page.Lv_listed_books.Columns(2).Text = "GENRE"
            Fm_home_page.Lv_listed_books.Columns(3).Text = "QTY"
            Fm_home_page.Lv_listed_books.Columns(4).Text = "AUTHOR"
            Fm_home_page.Lv_listed_books.Columns(5).Text = "PUBLISH"
            Fm_home_page.Lv_listed_books.Columns(6).Text = "PUBLISH YEAR"
            Fm_home_page.Lv_listed_books.Columns(7).Text = "SUPPLIER"
            Fm_home_page.Lv_listed_books.Columns(8).Text = "AQUISITION DATE"
            Fm_home_page.Lv_listed_books.Columns(9).Text = "STATUS"

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

    Public Sub Load_returned_borrowed_books_data_table()

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

    Public Sub Load_penalty_report_data_table()

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

    Public Sub Load_library_supplier_data_table()

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

    Public Sub Load_library_author_data_table()

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

    Public Sub Load_library_category_data_table()

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

    Public Sub Load_library_penalty_data_table()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_penalty
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

    Public Sub Load_library_publisher_data_table()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_publisher
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


    ' Remove items selection on the other listview

    Public Sub Load_all_data_tables()

        Load_listed_books_data_table()
        Load_returned_borrowed_books_data_table()
        Load_penalty_report_data_table()
        Load_borrower_info_data_table()
        Load_listed_accounts_data_table()
        Load_library_supplier_data_table()
        Load_library_author_data_table()
        Load_library_category_data_table()
        Load_library_penalty_data_table()
        Load_library_publisher_data_table()

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

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

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

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

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
        Fm_add_books.Lbl_error_msg_5.Text = ""
        Fm_add_books.Lbl_error_msg_6.Text = ""

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

    End Sub

End Module