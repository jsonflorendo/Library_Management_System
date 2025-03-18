<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_returned_books
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
        Btn_return = New Button()
        Btn_close = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Dtp_returned_date = New DateTimePicker()
        Txt_issued_to = New TextBox()
        Txt_borrower_id_number = New TextBox()
        Txt_book_name = New TextBox()
        Btn_penalty = New Button()
        Txt_primary_borrower_id = New TextBox()
        Label5 = New Label()
        Txt_isbn = New TextBox()
        Txt_primary_book_id = New TextBox()
        Txt_primary_issued_book_id = New TextBox()
        SuspendLayout()
        ' 
        ' Btn_return
        ' 
        Btn_return.Font = New Font("Georgia", 9F)
        Btn_return.Location = New Point(44, 239)
        Btn_return.Name = "Btn_return"
        Btn_return.Size = New Size(115, 39)
        Btn_return.TabIndex = 0
        Btn_return.Text = "&Return"
        Btn_return.UseVisualStyleBackColor = True
        ' 
        ' Btn_close
        ' 
        Btn_close.Font = New Font("Georgia", 9F)
        Btn_close.Location = New Point(311, 239)
        Btn_close.Name = "Btn_close"
        Btn_close.Size = New Size(110, 39)
        Btn_close.TabIndex = 2
        Btn_close.Text = "&Close"
        Btn_close.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlLight
        Label4.Font = New Font("Georgia", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(20, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(162, 23)
        Label4.TabIndex = 7
        Label4.Text = "Returned Date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlLight
        Label3.Font = New Font("Georgia", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(20, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 23)
        Label3.TabIndex = 6
        Label3.Text = "Issued To:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLight
        Label2.Font = New Font("Georgia", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(20, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 23)
        Label2.TabIndex = 5
        Label2.Text = "ID Number:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLight
        Label1.Font = New Font("Georgia", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(20, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 23)
        Label1.TabIndex = 4
        Label1.Text = "Book Name:"
        ' 
        ' Dtp_returned_date
        ' 
        Dtp_returned_date.Enabled = False
        Dtp_returned_date.Font = New Font("Georgia", 9F, FontStyle.Bold)
        Dtp_returned_date.Location = New Point(208, 181)
        Dtp_returned_date.Name = "Dtp_returned_date"
        Dtp_returned_date.Size = New Size(242, 21)
        Dtp_returned_date.TabIndex = 1
        ' 
        ' Txt_issued_to
        ' 
        Txt_issued_to.Enabled = False
        Txt_issued_to.Font = New Font("Georgia", 9F, FontStyle.Bold)
        Txt_issued_to.Location = New Point(208, 140)
        Txt_issued_to.Name = "Txt_issued_to"
        Txt_issued_to.Size = New Size(242, 21)
        Txt_issued_to.TabIndex = 2
        Txt_issued_to.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txt_borrower_id_number
        ' 
        Txt_borrower_id_number.Font = New Font("Georgia", 9F, FontStyle.Bold)
        Txt_borrower_id_number.Location = New Point(208, 98)
        Txt_borrower_id_number.Name = "Txt_borrower_id_number"
        Txt_borrower_id_number.PlaceholderText = "ID Number"
        Txt_borrower_id_number.Size = New Size(242, 21)
        Txt_borrower_id_number.TabIndex = 1
        Txt_borrower_id_number.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txt_book_name
        ' 
        Txt_book_name.Enabled = False
        Txt_book_name.Font = New Font("Georgia", 9F, FontStyle.Bold)
        Txt_book_name.Location = New Point(208, 57)
        Txt_book_name.Name = "Txt_book_name"
        Txt_book_name.Size = New Size(242, 21)
        Txt_book_name.TabIndex = 0
        ' 
        ' Btn_penalty
        ' 
        Btn_penalty.Font = New Font("Georgia", 9F)
        Btn_penalty.Location = New Point(177, 239)
        Btn_penalty.Name = "Btn_penalty"
        Btn_penalty.Size = New Size(110, 39)
        Btn_penalty.TabIndex = 23
        Btn_penalty.Text = "&Penalty"
        Btn_penalty.UseVisualStyleBackColor = True
        ' 
        ' Txt_primary_borrower_id
        ' 
        Txt_primary_borrower_id.Location = New Point(456, 97)
        Txt_primary_borrower_id.Name = "Txt_primary_borrower_id"
        Txt_primary_borrower_id.PlaceholderText = "Primary Borrower ID"
        Txt_primary_borrower_id.Size = New Size(114, 23)
        Txt_primary_borrower_id.TabIndex = 24
        Txt_primary_borrower_id.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlLight
        Label5.Font = New Font("Georgia", 14.25F, FontStyle.Bold)
        Label5.Location = New Point(20, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 23)
        Label5.TabIndex = 26
        Label5.Text = "ISBN:"
        ' 
        ' Txt_isbn
        ' 
        Txt_isbn.Enabled = False
        Txt_isbn.Font = New Font("Georgia", 9F, FontStyle.Bold)
        Txt_isbn.Location = New Point(208, 21)
        Txt_isbn.Name = "Txt_isbn"
        Txt_isbn.PlaceholderText = "ISBN"
        Txt_isbn.Size = New Size(242, 21)
        Txt_isbn.TabIndex = 25
        Txt_isbn.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txt_primary_book_id
        ' 
        Txt_primary_book_id.Location = New Point(456, 57)
        Txt_primary_book_id.Name = "Txt_primary_book_id"
        Txt_primary_book_id.PlaceholderText = "Primary Book ID"
        Txt_primary_book_id.Size = New Size(114, 23)
        Txt_primary_book_id.TabIndex = 27
        Txt_primary_book_id.Visible = False
        ' 
        ' Txt_primary_issued_book_id
        ' 
        Txt_primary_issued_book_id.Location = New Point(266, -1)
        Txt_primary_issued_book_id.Name = "Txt_primary_issued_book_id"
        Txt_primary_issued_book_id.PlaceholderText = "Primary Issued Book ID"
        Txt_primary_issued_book_id.Size = New Size(132, 23)
        Txt_primary_issued_book_id.TabIndex = 28
        Txt_primary_issued_book_id.Visible = False
        ' 
        ' Fm_returned_books
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(469, 307)
        ControlBox = False
        Controls.Add(Txt_primary_issued_book_id)
        Controls.Add(Txt_primary_book_id)
        Controls.Add(Label5)
        Controls.Add(Txt_isbn)
        Controls.Add(Txt_primary_borrower_id)
        Controls.Add(Btn_penalty)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Btn_close)
        Controls.Add(Label2)
        Controls.Add(Btn_return)
        Controls.Add(Label1)
        Controls.Add(Txt_book_name)
        Controls.Add(Dtp_returned_date)
        Controls.Add(Txt_borrower_id_number)
        Controls.Add(Txt_issued_to)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_returned_books"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Btn_return As Button
    Friend WithEvents Btn_close As Button
    Friend WithEvents Dtp_returned_date As DateTimePicker
    Friend WithEvents Txt_issued_to As TextBox
    Friend WithEvents Txt_borrower_id_number As TextBox
    Friend WithEvents Txt_book_name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_penalty As Button
    Friend WithEvents Txt_primary_borrower_id As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_isbn As TextBox
    Friend WithEvents Txt_primary_book_id As TextBox
    Friend WithEvents Txt_primary_issued_book_id As TextBox
End Class
