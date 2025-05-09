Imports System.IO
Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Module Module1

    'Database Connection

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
                                    WHERE username = @username
                                    AND password = @password"
                    cmd = New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    dr = cmd.ExecuteReader()

                    If dr.Read() Then

                        Dim name As String = dr("first_name") + " " + dr("last_name")
                        Dim user_type As String = dr("user_type")

                        If dr("user_type") = "Assistant Librarian" Then

                            Fm_home_page.Lbl_name_logged_in.Text = name
                            Fm_home_page.Lbl_user_type_logged_in.Text = user_type

                        Else

                            Fm_home_page.Lbl_name_logged_in.Text = name
                            Fm_home_page.Lbl_user_type_logged_in.Text = user_type
                            Fm_home_page.Btn_listed_accounts.Visible = False
                            Fm_home_page.Btn_author_category_penalty_publisher_maintenance.Visible = False
                            Fm_home_page.Btn_supplier_maintenance.Visible = False
                            Fm_home_page.Btn_delivery.Visible = False
                            Fm_home_page.Gb_inventory_maintenance.Visible = False
                            Fm_home_page.Gb_user_maintenance.Visible = False

                        End If

                        Fm_home_page.Show()

                        Clear_login_fields()
                        Clear_error_msg()
                        Fm_login.Hide()

                    Else

                        Fm_login.Lbl_error_msg_1.Text = ""
                        Fm_login.Lbl_error_msg.Text = "Incorrect username or password"
                        Clear_login_fields()

                    End If

                    dr.Close()

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
                                WHERE username = @username
                                AND password = @password"
                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                dr = cmd.ExecuteReader()

                If dr.Read() Then

                    Dim name As String = dr("first_name") + " " + dr("last_name")
                    Dim user_type As String = dr("user_type")

                    If dr("user_type") = "Assistant Librarian" Then

                        Fm_home_page.Lbl_name_logged_in.Text = name
                        Fm_home_page.Lbl_user_type_logged_in.Text = user_type

                    Else

                        Fm_home_page.Lbl_name_logged_in.Text = name
                        Fm_home_page.Lbl_user_type_logged_in.Text = user_type
                        Fm_home_page.Btn_listed_accounts.Visible = False
                        Fm_home_page.Btn_author_category_penalty_publisher_maintenance.Visible = False
                        Fm_home_page.Btn_supplier_maintenance.Visible = False
                        Fm_home_page.Btn_delivery.Visible = False
                        Fm_home_page.Gb_inventory_maintenance.Visible = False
                        Fm_home_page.Gb_user_maintenance.Visible = False

                    End If

                    Fm_home_page.Show()

                    Clear_login_fields()
                    Clear_error_msg()
                    Fm_login.Hide()

                Else

                    Fm_login.Lbl_error_msg_1.Text = ""
                    Fm_login.Lbl_error_msg.Text = "Incorrect username or password"
                    Clear_login_fields()

                End If

                dr.Close()

            Catch ex As Exception

                MsgBox("Error: " & ex.Message)

            Finally

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

            End Try

        End If

    End Sub


    ' Barcode generation function

    ' Mapping Code 39 characters to barcode patterns
    Dim code39Table As New Dictionary(Of Char, String) From {
        {"0"c, "101001101101"}, {"1"c, "110100101011"}, {"2"c, "101100101011"},
        {"3"c, "110110010101"}, {"4"c, "101001101011"}, {"5"c, "110100110101"},
        {"6"c, "101100110101"}, {"7"c, "101001011011"}, {"8"c, "110100101101"},
        {"9"c, "101100101101"}, {"A"c, "110101001011"}, {"B"c, "101101001011"},
        {"C"c, "110110100101"}, {"D"c, "101011001011"}, {"E"c, "110101100101"},
        {"F"c, "101101100101"}, {"G"c, "101010011011"}, {"H"c, "110101001101"},
        {"I"c, "101101001101"}, {"J"c, "101011001101"}, {"K"c, "110101010011"},
        {"L"c, "101101010011"}, {"M"c, "110110101001"}, {"N"c, "101011010011"},
        {"O"c, "110101101001"}, {"P"c, "101101101001"}, {"Q"c, "101010110011"},
        {"R"c, "110101011001"}, {"S"c, "101101011001"}, {"T"c, "101011011001"},
        {"U"c, "110010101011"}, {"V"c, "100110101011"}, {"W"c, "110011010101"},
        {"X"c, "100101101011"}, {"Y"c, "110010110101"}, {"Z"c, "100110110101"},
        {"-"c, "100101011011"}, {"."c, "110010101101"}, {" "c, "100110101101"},
        {"$"c, "100100100101"}, {"/"c, "100100101001"}, {"+"c, "100101001001"},
        {"%"c, "101001001001"}, {"*"c, "100101101101"} ' * is the start/stop character
    }

    Public Sub generate_barcode()

        Dim borrower_id_number As String = Fm_add_borrower.Txt_borrower_id_number.Text.ToUpper()
        Dim encoded As String = "*" & borrower_id_number & "*"

        Dim pattern As String = ""
        For Each ch As Char In encoded
            If code39Table.ContainsKey(ch) Then
                pattern &= code39Table(ch) & "0" ' add narrow space between characters
            End If
        Next

        ' Draw barcode
        Dim widthPerBar As Integer = 2
        Dim height As Integer = 100
        Dim totalWidth As Integer = pattern.Length * widthPerBar
        Dim bmp As New Bitmap(totalWidth, height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
            Dim x As Integer = 0
            For Each bit As Char In pattern
                Dim brush As Brush = If(bit = "1"c, Brushes.Black, Brushes.White)
                g.FillRectangle(brush, x, 0, widthPerBar, height)
                x += widthPerBar
            Next
        End Using

        Fm_add_borrower.Pb_id_no_barcode.Image = bmp

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
            mail.Body = $"Dear Mr/Ms. {first_name} {last_name},{vbCrLf}{vbCrLf}" &
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

                    WHERE    isbn LIKE '%" & listed_books_search & "%'
                        OR   book_name LIKE '%" & listed_books_search & "%'
                        OR   category_name LIKE '%" & listed_books_search & "%'
                        OR   author_name LIKE '%" & listed_books_search & "%'
                        OR   publisher_name LIKE '%" & listed_books_search & "%'

                    ORDER BY primary_book_id DESC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_listed_books.Items.Clear()

            While dr.Read()

                Dim lv As New ListViewItem({dr("isbn").ToString(),
                                            dr("book_name").ToString(),
                                            dr("category_name").ToString(),
                                            dr("author_name").ToString(),
                                            dr("publisher_name").ToString(),
                                            dr("publish_year").ToString(),
                                            dr("primary_book_id").ToString(),
                                            dr("primary_category_id")})
                Fm_home_page.Lv_listed_books.Items.Add(lv)

            End While

            dr.Close()

            ' Set column headers (ideally only once during initialization)
            With Fm_home_page.Lv_listed_books.Columns
                .Item(0).Text = "ISBN"
                .Item(1).Text = "BOOK NAME"
                .Item(2).Text = "GENRE"
                .Item(3).Text = "AUTHOR"
                .Item(4).Text = "PUBLISHER"
                .Item(5).Text = "PUBLISH YEAR"
            End With

            ' Alternate row coloring
            For i As Integer = 0 To Fm_home_page.Lv_listed_books.Items.Count - 1
                With Fm_home_page.Lv_listed_books.Items(i)
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

                    WHERE   CONCAT(transaction_yyyy_mm, '-', LPAD(transaction_series, 5, '0')) LIKE '%" & returned_borrowed_books_search & "%'
                        OR  borrower_id LIKE '%" & returned_borrowed_books_search & "%'
                        OR  CONCAT (tbl_borrower.last_name, ', ', tbl_borrower.first_name) LIKE '%" & returned_borrowed_books_search & "%'
                        OR  book_name LIKE '%" & returned_borrowed_books_search & "%'
                        OR  issued_date LIKE '%" & returned_borrowed_books_search & "%'
                        OR  due_date LIKE '%" & returned_borrowed_books_search & "%'
                        OR  returned_date LIKE '%" & returned_borrowed_books_search & "%'
                            
                    ORDER BY primary_issued_book_id DESC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_returned_borrowed_books.Items.Clear()

            While dr.Read()

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

            End While

            dr.Close()

            ' Set column headers (ideally only once during initialization)
            With Fm_home_page.Lv_returned_borrowed_books.Columns
                .Item(0).Text = "TRANSACTION NO"
                .Item(1).Text = "ID NUMBER"
                .Item(2).Text = "ISSUED TO"
                .Item(3).Text = "BOOK NAME"
                .Item(4).Text = "ISSUED DATE"
                .Item(5).Text = "DUE DATE"
                .Item(6).Text = "RETURNED DATE"
            End With

            ' Alternate row coloring
            For i As Integer = 0 To Fm_home_page.Lv_returned_borrowed_books.Items.Count - 1
                With Fm_home_page.Lv_returned_borrowed_books.Items(i)
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

    End Sub

    Public Sub Load_penalty_report_data_table(penalty_report_search As String)

        Try

            con.Open()

            sql = "SELECT   tbl_borrower.borrower_id,
                            CONCAT (tbl_borrower.last_name, ', ', tbl_borrower.first_name) AS full_name,
                            tbl_books.book_name,
                            tbl_penalty_report.penalty_date,
                            tbl_borrower.primary_borrower_id,
                            tbl_books.primary_book_id,
                            tbl_penalty_report.primary_penalty_description_id,
                            tbl_penalty_report.primary_penalty_id

                    FROM tbl_penalty_report

                    INNER JOIN tbl_borrower ON tbl_penalty_report.primary_borrower_id = tbl_borrower.primary_borrower_id
                    INNER JOIN tbl_books ON tbl_penalty_report.primary_book_id = tbl_books.primary_book_id
                    INNER JOIN tbl_library_penalty ON tbl_penalty_report.primary_penalty_description_id = tbl_library_penalty.primary_penalty_description_id

                    WHERE   borrower_id LIKE '%" & penalty_report_search & "%'
                        OR  CONCAT (tbl_borrower.last_name, ', ', tbl_borrower.first_name) LIKE '%" & penalty_report_search & "%'
                        OR  book_name LIKE '%" & penalty_report_search & "%'
                        OR  penalty_description LIKE '%" & penalty_report_search & "%'
                        OR  amount LIKE '%" & penalty_report_search & "%'
                        OR  penalty_date LIKE '%" & penalty_report_search & "%'
            
                    GROUP BY tbl_penalty_report.primary_borrower_id,
                                tbl_penalty_report.primary_book_id,
                                tbl_penalty_report.penalty_date
                    
                    ORDER BY penalty_date DESC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_penalty.Items.Clear()

            While dr.Read()

                Dim lv As New ListViewItem({dr("borrower_id").ToString(),
                                            dr("full_name").ToString(),
                                            dr("book_name").ToString(),
                                            dr("penalty_date").ToString(),
                                            dr("primary_borrower_id").ToString(),
                                            dr("primary_book_id").ToString(),
                                            dr("primary_penalty_description_id").ToString(),
                                            dr("primary_penalty_id").ToString()})
                Fm_home_page.Lv_penalty.Items.Add(lv)

            End While

            dr.Close()

            ' Set column headers (ideally only once during initialization)
            With Fm_home_page.Lv_penalty.Columns
                .Item(0).Text = "ID NUMBER"
                .Item(1).Text = "NAME"
                .Item(2).Text = "BOOK NAME"
                .Item(3).Text = "DATE"
            End With

            ' Alternate row coloring
            For i As Integer = 0 To Fm_home_page.Lv_penalty.Items.Count - 1
                With Fm_home_page.Lv_penalty.Items(i)
                    .BackColor = If(i Mod 2 = 0, Color.Azure, Color.GhostWhite)
                    .ForeColor = Color.Black
                End With
            Next

            con.Close()
            Load_penalty_report_penalty_description_data_table("", "", "")

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Public Sub Load_penalty_report_penalty_description_data_table(primary_borrower_id As String, primary_book_id As String, penalty_date As String)

        Try

            con.Open()

            sql = "SELECT   tbl_library_penalty.penalty_description,
                                tbl_library_penalty.amount,
                                tbl_penalty_report.primary_penalty_id

                        FROM tbl_penalty_report

                        INNER JOIN tbl_library_penalty ON tbl_penalty_report.primary_penalty_description_id = tbl_library_penalty.primary_penalty_description_id

                        WHERE   primary_borrower_id = '" & primary_borrower_id & "'
                        AND     primary_book_id = '" & primary_book_id & "'
                        AND     penalty_date = '" & penalty_date & "'            
                     
                        ORDER BY penalty_description ASC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_penalty_report_penalty_description.Items.Clear()

            While dr.Read()

                Dim lv As New ListViewItem({dr("penalty_description").ToString(),
                                            dr("amount").ToString(),
                                            dr("primary_penalty_id")})
                Fm_home_page.Lv_penalty_report_penalty_description.Items.Add(lv)

            End While

            dr.Close()

            ' Alternate row coloring
            For i As Integer = 0 To Fm_home_page.Lv_penalty_report_penalty_description.Items.Count - 1
                With Fm_home_page.Lv_penalty_report_penalty_description.Items(i)
                    .BackColor = Color.GhostWhite
                End With
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

                            WHERE   borrower_id LIKE '%" & student_info_search & "%'
                                OR  last_name LIKE '%" & student_info_search & "%'
                                OR  first_name LIKE '%" & student_info_search & "%'
                                OR  middle_name LIKE '%" & student_info_search & "%'
                                OR  gender = '" & student_info_search & "'
                                OR  borrower_contact_no LIKE '%" & student_info_search & "%'
                                OR  borrower_address LIKE '%" & student_info_search & "%'

                            ORDER BY last_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_borrower_info.Items.Clear()

            While dr.Read()

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

            End While

            dr.Close()

            ' Set column headers (ideally only once during initialization)
            With Fm_home_page.Lv_borrower_info.Columns
                .Item(0).Text = "ID NUMBER"
                .Item(1).Text = "LAST NAME"
                .Item(2).Text = "FIRST NAME"
                .Item(3).Text = "MIDDLE NAME"
                .Item(4).Text = "CATEGORY TYPE"
                .Item(5).Text = "GENDER"
                .Item(6).Text = "CONTACT NO"
                .Item(7).Text = "EMAIL"
                .Item(8).Text = "ADDRESS"
            End With

            ' Alternate row coloring
            For i As Integer = 0 To Fm_home_page.Lv_borrower_info.Items.Count - 1
                With Fm_home_page.Lv_borrower_info.Items(i)
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

    End Sub

    Public Sub Load_listed_accounts_data_table(listed_accounts_search As String)

        Try

            con.Open()

            sql = "SELECT * FROM tbl_admin

                            WHERE   first_name Like '%" & listed_accounts_search & "%'
                                OR  middle_name Like '%" & listed_accounts_search & "%'
                                OR  last_name Like '%" & listed_accounts_search & "%'
                                OR  gender = '" & listed_accounts_search & "'
                                OR  birthday Like '%" & listed_accounts_search & "%'
                                OR  contact_no Like '%" & listed_accounts_search & "%'
                                OR  address Like '%" & listed_accounts_search & "%'
                                OR  username Like '%" & listed_accounts_search & "%'
                                OR  email Like '%" & listed_accounts_search & "%'
                                OR  user_type Like '%" & listed_accounts_search & "%'"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_listed_accounts.Items.Clear()

            While dr.Read()

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

            End While

            dr.Close()

            ' Set column headers (ideally only once during initialization)
            With Fm_home_page.Lv_listed_accounts.Columns
                .Item(0).Text = "FIRST NAME"
                .Item(1).Text = "MIDDLE NAME"
                .Item(2).Text = "LAST NAME"
                .Item(3).Text = "GENDER"
                .Item(4).Text = "BIRTHDAY"
                .Item(5).Text = "CONTACT NO"
                .Item(6).Text = "ADDRESS"
                .Item(7).Text = "USERNAME"
                .Item(8).Text = "EMAIL"
                .Item(9).Text = "USER TYPE"
            End With

            ' Alternate row coloring
            For i As Integer = 0 To Fm_home_page.Lv_listed_accounts.Items.Count - 1
                With Fm_home_page.Lv_listed_accounts.Items(i)
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

    End Sub

    Public Sub Load_library_supplier_data_table(supplier_search As String)

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_supplier

                            WHERE   supplier_id Like '%" & supplier_search & "%'
                                OR  supplier_name Like '%" & supplier_search & "%'
                                OR  last_name Like '%" & supplier_search & "%'
                                OR  first_name Like '%" & supplier_search & "%'
                                OR  email_address Like '%" & supplier_search & "%'
                                OR  contact Like '%" & supplier_search & "%'
                                OR  address Like '%" & supplier_search & "%'
                                OR  source_type Like '%" & supplier_search & "%'"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_supplier.Items.Clear()

            While dr.Read()

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

            End While

            dr.Close()

            'Listview column header title
            With Fm_home_page.Lv_supplier.Columns
                .Item(0).Text = "SUPPLIER ID"
                .Item(1).Text = "SUPPLIER NAME"
                .Item(2).Text = "FULL NAME"
                .Item(3).Text = "EMAIL ADDRESS"
                .Item(4).Text = "CONTACT NO"
                .Item(5).Text = "ADDRESS"
                .Item(6).Text = "SOURCE TYPE"
            End With

            ' Alternate row coloring
            For i As Integer = 0 To Fm_home_page.Lv_supplier.Items.Count - 1
                With Fm_home_page.Lv_supplier.Items(i)
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

            While dr.Read()

                Dim lv As New ListViewItem({dr("author_name").ToString(),
                                            dr("primary_author_id").ToString()})
                Fm_home_page.Lv_author.Items.Add(lv)

            End While

            dr.Close()

            'Listview column header title
            Fm_home_page.Lv_author.Columns(0).Text = "AUTHOR NAME"

            ' Alternate row coloring
            For i As Integer = 0 To Fm_home_page.Lv_author.Items.Count - 1
                With Fm_home_page.Lv_author.Items(i)
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

            While dr.Read()

                Dim lv As New ListViewItem({dr("category_name").ToString(),
                                            dr("primary_category_id").ToString()})
                Fm_home_page.Lv_category.Items.Add(lv)

            End While

            dr.Close()

            'Listview column header title
            Fm_home_page.Lv_category.Columns(0).Text = "GENRE"

            ' Alternate row coloring
            For i As Integer = 0 To Fm_home_page.Lv_category.Items.Count - 1
                With Fm_home_page.Lv_category.Items(i)
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

            While dr.Read()

                Dim lv As New ListViewItem({dr("penalty_description").ToString(),
                                            dr("amount").ToString(),
                                            dr("primary_penalty_description_id").ToString()})
                Fm_home_page.Lv_penalty_description.Items.Add(lv)

            End While

            dr.Close()

            ' Set column headers (ideally only once during initialization)
            With Fm_home_page.Lv_penalty_description.Columns
                .Item(0).Text = "PENALTY DESCRIPTION"
                .Item(1).Text = "AMOUNT"
            End With

            ' Alternate row coloring
            For i As Integer = 0 To Fm_home_page.Lv_penalty_description.Items.Count - 1
                With Fm_home_page.Lv_penalty_description.Items(i)
                    .BackColor = If(i Mod 2 = 0, Color.Azure, Color.GhostWhite)
                    .ForeColor = Color.Black
                End With
            Next



            sql = "SELECT * FROM tbl_library_penalty
                            ORDER BY penalty_description ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_add_penalty.Lv_penalty_description.Items.Clear()

            While dr.Read

                Dim lv As New ListViewItem({dr("penalty_description").ToString(),
                                            dr("amount").ToString(),
                                            dr("primary_penalty_description_id").ToString()})
                Fm_add_penalty.Lv_penalty_description.Items.Add(lv)

            End While

            dr.Close()

            ' Set column headers (ideally only once during initialization)
            With Fm_add_penalty.Lv_penalty_description.Columns
                .Item(0).Text = "PENALTY DESCRIPTION"
                .Item(1).Text = "AMOUNT"
            End With

            ' Alternate row coloring
            For i As Integer = 0 To Fm_add_penalty.Lv_penalty_description.Items.Count - 1
                With Fm_add_penalty.Lv_penalty_description.Items(i)
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

            While dr.Read()

                Dim lv As New ListViewItem({dr("publisher_name").ToString(),
                                            dr("primary_publisher_id").ToString()})
                Fm_home_page.Lv_publisher.Items.Add(lv)

            End While

            dr.Close()

            'Listview column header title
            Fm_home_page.Lv_publisher.Columns(0).Text = "PUBLISHER NAME"

            ' Alternate row coloring
            For i As Integer = 0 To Fm_home_page.Lv_publisher.Items.Count - 1
                With Fm_home_page.Lv_publisher.Items(i)
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

    End Sub

    Public Sub Load_shelf_data_table(shelf_search As String)

        Try

            con.Open()

            sql = "SELECT * FROM tbl_shelf

                            WHERE   shelf_name LIKE '%" & shelf_search & "%'
                                OR  section LIKE '%" & shelf_search & "%'
                                OR  floor_number LIKE '%" & shelf_search & "%'
                                OR  capacity LIKE '%" & shelf_search & "%'
                                OR  current_load LIKE '%" & shelf_search & "%'
                                OR  created_at LIKE '%" & shelf_search & "%'
                                OR  updated_at LIKE '%" & shelf_search & "%'

                            ORDER BY shelf_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_shelf.Items.Clear()

            While dr.Read()

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

            End While

            dr.Close()

            ' Set column headers (ideally only once during initialization)
            With Fm_home_page.Lv_shelf.Columns
                .Item(0).Text = "SHELF ID"
                .Item(1).Text = "SHELF NAME"
                .Item(2).Text = "SECTION"
                .Item(3).Text = "FLOOR NUMBER"
                .Item(4).Text = "CAPACITY"
                .Item(5).Text = "CURRENT LOAD"
                .Item(6).Text = "CREATED AT"
                .Item(7).Text = "UPDATED AT"
            End With

            ' Alternate row coloring
            For i As Integer = 0 To Fm_home_page.Lv_shelf.Items.Count - 1
                With Fm_home_page.Lv_shelf.Items(i)
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
                            tbl_delivery.received_by,
                            tbl_delivery.status,
                            tbl_delivery.primary_delivery_id

                    FROM tbl_delivery

                    INNER JOIN tbl_books ON tbl_delivery.primary_book_id = tbl_books.primary_book_id

                    WHERE   transaction_number LIKE '%" & delivery_search & "%'
                        OR  isbn LIKE '%" & delivery_search & "%'
                        OR  book_name LIKE '%" & delivery_search & "%'
                        OR  quantity LIKE '%" & delivery_search & "%'
                        OR  delivered_by LIKE '%" & delivery_search & "%'
                        OR  delivery_date LIKE '%" & delivery_search & "%'
                        OR  received_by LIKE '%" & delivery_search & "%'
                        OR  status LIKE '%" & delivery_search & "%'

                    ORDER BY delivery_date DESC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_delivery.Items.Clear()

            While dr.Read()

                Dim lv As New ListViewItem({dr("transaction_number").ToString(),
                                            dr("isbn").ToString(),
                                            dr("book_name").ToString(),
                                            dr("quantity").ToString(),
                                            dr("delivered_by").ToString(),
                                            dr("delivery_date").ToString(),
                                            dr("received_by").ToString(),
                                            dr("status").ToString(),
                                            dr("primary_delivery_id")})
                Fm_home_page.Lv_delivery.Items.Add(lv)

            End While

            dr.Close()

            ' Set column headers (ideally only once during initialization)
            With Fm_home_page.Lv_delivery.Columns
                .Item(0).Text = "TRANSACTION NUMBER"
                .Item(1).Text = "ISBN"
                .Item(2).Text = "BOOK NAME"
                .Item(3).Text = "QUANTITY"
                .Item(4).Text = "DELIVERED BY"
                .Item(5).Text = "DELIVERY DATE"
                .Item(6).Text = "RECEIVED BY"
                .Item(7).Text = "STATUS"
            End With

            ' Alternate row coloring
            For i As Integer = 0 To Fm_home_page.Lv_delivery.Items.Count - 1
                With Fm_home_page.Lv_delivery.Items(i)
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

    End Sub

    Public Sub Load_book_inventory_data_table(book_inventory_search As String)

        Try

            con.Open()

            sql = "SELECT   tbl_books.isbn,
                            tbl_books.book_name,
                            tbl_library_author.author_name,
                            tbl_library_category.category_name,
                            tbl_books.publish_year,
                            tbl_library_publisher.publisher_name,
                            tbl_book_inventory.quantity,
                            tbl_book_inventory.status,
                            tbl_book_inventory.primary_book_inventory_id,
                            tbl_book_inventory.primary_book_id

                    FROM tbl_book_inventory

                    INNER JOIN tbl_books ON tbl_book_inventory.primary_book_id = tbl_books.primary_book_id
                    INNER JOIN tbl_library_author ON tbl_books.primary_author_id = tbl_library_author.primary_author_id
                    INNER JOIN tbl_library_category ON tbl_books.primary_category_id = tbl_library_category.primary_category_id
                    INNER JOIN tbl_library_publisher ON tbl_books.primary_publisher_id = tbl_library_publisher.primary_publisher_id

                    WHERE   isbn LIKE '%" & book_inventory_search & "%'
                        OR  book_name LIKE '%" & book_inventory_search & "%'
                        OR  author_name LIKE '%" & book_inventory_search & "%'
                        OR  category_name LIKE '%" & book_inventory_search & "%'
                        OR  publish_year LIKE '%" & book_inventory_search & "%'
                        OR  publisher_name LIKE '%" & book_inventory_search & "%'
                        OR  quantity LIKE '%" & book_inventory_search & "%'
                        OR  status LIKE '%" & book_inventory_search & "%'

                    ORDER BY book_name ASC"

            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader()

            Fm_home_page.Lv_book_inventory.Items.Clear()

            While dr.Read()

                Dim lv As New ListViewItem({dr("isbn").ToString(),
                                            dr("book_name").ToString(),
                                            dr("author_name").ToString(),
                                            dr("category_name").ToString(),
                                            dr("publish_year").ToString(),
                                            dr("publisher_name").ToString(),
                                            dr("quantity").ToString(),
                                            dr("status").ToString(),
                                            dr("primary_book_inventory_id").ToString(),
                                            dr("primary_book_id").ToString()})
                Fm_home_page.Lv_book_inventory.Items.Add(lv)

            End While

            dr.Close()

            ' Set column headers (ideally only once during initialization)
            With Fm_home_page.Lv_book_inventory.Columns
                .Item(0).Text = "ISBN"
                .Item(1).Text = "BOOK NAME"
                .Item(2).Text = "AUTHOR"
                .Item(3).Text = "GENRE"
                .Item(4).Text = "PUBLISH YEAR"
                .Item(5).Text = "PUBLISHER"
                .Item(6).Text = "QUANTITY"
                .Item(7).Text = "STATUS"
            End With

            ' Alternate row coloring
            For i As Integer = 0 To Fm_home_page.Lv_book_inventory.Items.Count - 1
                With Fm_home_page.Lv_book_inventory.Items(i)
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
        Load_book_inventory_data_table(Fm_home_page.Txt_book_inventory_search.Text)

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

            Fm_home_page.Cb_book_inventory_category.Items.Clear()
            Fm_home_page.Cb_book_inventory_category.Items.Add("All Genre")

            Fm_add_books.Cb_book_category.Items.Clear()

            While dr.Read()

                Fm_home_page.Cb_listed_books_category.Items.Add(dr("category_name"))
                Fm_home_page.Cb_book_inventory_category.Items.Add(dr("category_name"))
                Fm_add_books.Cb_book_category.Items.Add(dr("category_name"))

            End While

            dr.Close()

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

            While dr.Read()

                Fm_add_books.Cb_author.Items.Add(dr("author_name"))

            End While

            dr.Close()

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

            sql = "SELECT * FROM tbl_library_publisher
                            ORDER BY publisher_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Fm_add_books.Cb_publisher.Items.Clear()

            While dr.Read()

                Fm_add_books.Cb_publisher.Items.Add(dr("publisher_name"))

            End While

            dr.Close()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Public Sub Load_library_cb_purchase_supplier()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_supplier
                            WHERE source_type = 'Supplier'
                            ORDER BY supplier_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Fm_add_delivery.Cb_purchase_supplier.Items.Clear()

            While dr.Read()

                Fm_add_delivery.Cb_purchase_supplier.Items.Add(dr("supplier_name"))

            End While

            dr.Close()

        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub

    Public Sub Load_library_cb_donate_supplier()

        Try

            con.Open()

            sql = "SELECT * FROM tbl_library_supplier
                            WHERE source_type = 'Donator'
                            ORDER BY supplier_name ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader

            Fm_add_delivery.Cb_donate_supplier.Items.Clear()

            While dr.Read()

                Fm_add_delivery.Cb_donate_supplier.Items.Add(dr("supplier_name"))

            End While

            dr.Close()

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
        Fm_login.Btn_login.Focus()

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
        Fm_add_delivery.Lbl_error_msg_4.Text = ""
        Fm_add_delivery.Lbl_error_msg_5.Text = ""
        Fm_add_delivery.Lbl_error_msg_6.Text = ""
        Fm_add_delivery.Lbl_error_msg_7.Text = ""
        Fm_add_delivery.Lbl_error_msg_8.Text = ""
        Fm_add_delivery.Lbl_error_msg_9.Text = ""
        Fm_add_delivery.Lbl_error_msg_10.Text = ""

        Fm_add_book_inventory.Lbl_error_msg.Text = ""
        Fm_add_book_inventory.Lbl_error_msg_1.Text = ""

    End Sub

End Module