<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_issued_books
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Btn_exit = New Button()
        Txt_primary_borrower_id = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label8 = New Label()
        Txt_borrower_id_number = New TextBox()
        Txt_issued_to = New TextBox()
        Dtp_due_date = New DateTimePicker()
        Label2 = New Label()
        Txt_book_name = New TextBox()
        Txt_isbn = New TextBox()
        Label1 = New Label()
        Txt_primary_book_id = New TextBox()
        Lbl_error_msg = New Label()
        Lbl_error_msg_1 = New Label()
        Lbl_transaction_yyyy_mm = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Lbl_transaction_series = New Label()
        SuspendLayout()
        ' 
        ' Btn_exit
        ' 
        Btn_exit.Font = New Font("Georgia", 9F)
        Btn_exit.Location = New Point(293, 247)
        Btn_exit.Name = "Btn_exit"
        Btn_exit.Size = New Size(119, 32)
        Btn_exit.TabIndex = 6
        Btn_exit.Text = "&Exit"
        Btn_exit.UseVisualStyleBackColor = True
        ' 
        ' Txt_primary_borrower_id
        ' 
        Txt_primary_borrower_id.Location = New Point(418, 124)
        Txt_primary_borrower_id.Name = "Txt_primary_borrower_id"
        Txt_primary_borrower_id.PlaceholderText = "Primary Borrower ID"
        Txt_primary_borrower_id.Size = New Size(114, 23)
        Txt_primary_borrower_id.TabIndex = 8
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.ControlLight
        Label11.Font = New Font("Georgia", 14.25F, FontStyle.Bold)
        Label11.Location = New Point(18, 170)
        Label11.Name = "Label11"
        Label11.Size = New Size(112, 23)
        Label11.TabIndex = 21
        Label11.Text = "Issued To:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ControlLight
        Label10.Font = New Font("Georgia", 14.25F, FontStyle.Bold)
        Label10.Location = New Point(18, 124)
        Label10.Name = "Label10"
        Label10.Size = New Size(127, 23)
        Label10.TabIndex = 20
        Label10.Text = "ID Number:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ControlLight
        Label8.Font = New Font("Georgia", 14.25F, FontStyle.Bold)
        Label8.Location = New Point(18, 204)
        Label8.Name = "Label8"
        Label8.Size = New Size(108, 23)
        Label8.TabIndex = 18
        Label8.Text = "Due Date:"
        ' 
        ' Txt_borrower_id_number
        ' 
        Txt_borrower_id_number.Font = New Font("Georgia", 9F)
        Txt_borrower_id_number.Location = New Point(182, 124)
        Txt_borrower_id_number.Name = "Txt_borrower_id_number"
        Txt_borrower_id_number.PlaceholderText = "ID Number"
        Txt_borrower_id_number.Size = New Size(230, 21)
        Txt_borrower_id_number.TabIndex = 1
        Txt_borrower_id_number.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txt_issued_to
        ' 
        Txt_issued_to.Enabled = False
        Txt_issued_to.Font = New Font("Georgia", 9F)
        Txt_issued_to.Location = New Point(182, 170)
        Txt_issued_to.Name = "Txt_issued_to"
        Txt_issued_to.Size = New Size(230, 21)
        Txt_issued_to.TabIndex = 5
        Txt_issued_to.TextAlign = HorizontalAlignment.Center
        ' 
        ' Dtp_due_date
        ' 
        Dtp_due_date.Font = New Font("Georgia", 9F)
        Dtp_due_date.Location = New Point(182, 206)
        Dtp_due_date.Name = "Dtp_due_date"
        Dtp_due_date.Size = New Size(230, 21)
        Dtp_due_date.TabIndex = 3
        Dtp_due_date.Value = New Date(2025, 3, 16, 22, 57, 51, 0)
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLight
        Label2.Font = New Font("Georgia", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(18, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 23)
        Label2.TabIndex = 1
        Label2.Text = "Book Name:"
        ' 
        ' Txt_book_name
        ' 
        Txt_book_name.Enabled = False
        Txt_book_name.Font = New Font("Georgia", 9F)
        Txt_book_name.Location = New Point(182, 89)
        Txt_book_name.Name = "Txt_book_name"
        Txt_book_name.Size = New Size(230, 21)
        Txt_book_name.TabIndex = 4
        ' 
        ' Txt_isbn
        ' 
        Txt_isbn.Font = New Font("Georgia", 9F)
        Txt_isbn.Location = New Point(182, 43)
        Txt_isbn.Name = "Txt_isbn"
        Txt_isbn.PlaceholderText = "ISBN"
        Txt_isbn.Size = New Size(230, 21)
        Txt_isbn.TabIndex = 22
        Txt_isbn.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLight
        Label1.Font = New Font("Georgia", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(18, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 23)
        Label1.TabIndex = 23
        Label1.Text = "ISBN:"
        ' 
        ' Txt_primary_book_id
        ' 
        Txt_primary_book_id.Location = New Point(418, 89)
        Txt_primary_book_id.Name = "Txt_primary_book_id"
        Txt_primary_book_id.PlaceholderText = "Primary Book ID"
        Txt_primary_book_id.Size = New Size(114, 23)
        Txt_primary_book_id.TabIndex = 24
        ' 
        ' Lbl_error_msg
        ' 
        Lbl_error_msg.AutoSize = True
        Lbl_error_msg.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_error_msg.ForeColor = Color.Red
        Lbl_error_msg.Location = New Point(179, 148)
        Lbl_error_msg.Name = "Lbl_error_msg"
        Lbl_error_msg.Size = New Size(91, 17)
        Lbl_error_msg.TabIndex = 25
        Lbl_error_msg.Text = "Lbl_error_msg"
        ' 
        ' Lbl_error_msg_1
        ' 
        Lbl_error_msg_1.AutoSize = True
        Lbl_error_msg_1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_error_msg_1.ForeColor = Color.Red
        Lbl_error_msg_1.Location = New Point(179, 67)
        Lbl_error_msg_1.Name = "Lbl_error_msg_1"
        Lbl_error_msg_1.Size = New Size(101, 17)
        Lbl_error_msg_1.TabIndex = 26
        Lbl_error_msg_1.Text = "Lbl_error_msg_1"
        ' 
        ' Lbl_transaction_yyyy_mm
        ' 
        Lbl_transaction_yyyy_mm.AutoSize = True
        Lbl_transaction_yyyy_mm.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Lbl_transaction_yyyy_mm.Location = New Point(182, 7)
        Lbl_transaction_yyyy_mm.Name = "Lbl_transaction_yyyy_mm"
        Lbl_transaction_yyyy_mm.Size = New Size(90, 21)
        Lbl_transaction_yyyy_mm.TabIndex = 27
        Lbl_transaction_yyyy_mm.Text = "BB2025-12"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlLight
        Label4.Font = New Font("Georgia", 12F, FontStyle.Bold)
        Label4.Location = New Point(18, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 18)
        Label4.TabIndex = 28
        Label4.Text = "Transaction No.:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(268, 7)
        Label3.Name = "Label3"
        Label3.Size = New Size(16, 21)
        Label3.TabIndex = 29
        Label3.Text = "-"
        ' 
        ' Lbl_transaction_series
        ' 
        Lbl_transaction_series.AutoSize = True
        Lbl_transaction_series.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Lbl_transaction_series.Location = New Point(280, 7)
        Lbl_transaction_series.Name = "Lbl_transaction_series"
        Lbl_transaction_series.Size = New Size(55, 21)
        Lbl_transaction_series.TabIndex = 30
        Lbl_transaction_series.Text = "00000"
        ' 
        ' Fm_issued_books
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(548, 292)
        ControlBox = False
        Controls.Add(Lbl_transaction_series)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Lbl_transaction_yyyy_mm)
        Controls.Add(Lbl_error_msg_1)
        Controls.Add(Lbl_error_msg)
        Controls.Add(Txt_primary_book_id)
        Controls.Add(Label1)
        Controls.Add(Txt_isbn)
        Controls.Add(Txt_book_name)
        Controls.Add(Label2)
        Controls.Add(Dtp_due_date)
        Controls.Add(Txt_primary_borrower_id)
        Controls.Add(Txt_issued_to)
        Controls.Add(Btn_exit)
        Controls.Add(Txt_borrower_id_number)
        Controls.Add(Label8)
        Controls.Add(Label11)
        Controls.Add(Label10)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_issued_books"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Btn_exit As Button
    Friend WithEvents Txt_primary_borrower_id As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_borrower_id_number As TextBox
    Friend WithEvents Txt_issued_to As TextBox
    Friend WithEvents Dtp_due_date As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_book_name As TextBox
    Friend WithEvents Txt_isbn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_primary_book_id As TextBox
    Friend WithEvents Lbl_error_msg As Label
    Friend WithEvents Lbl_error_msg_1 As Label
    Friend WithEvents Lbl_transaction_yyyy_mm As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_transaction_series As Label
End Class
