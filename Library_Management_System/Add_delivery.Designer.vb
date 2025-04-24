<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_add_delivery
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
        Lbl_error_msg_3 = New Label()
        Lbl_error_msg_2 = New Label()
        Lbl_error_msg_1 = New Label()
        Lbl_error_msg = New Label()
        Txt_book_isbn = New TextBox()
        Btn_update = New Button()
        Btn_cancel = New Button()
        Txt_delivery_delivered_by = New TextBox()
        Txt_delivery_transaction_number = New TextBox()
        Txt_delivery_received_by = New TextBox()
        Txt_book_title = New TextBox()
        Txt_book_genre = New TextBox()
        Txt_book_author = New TextBox()
        Txt_book_publish_year = New TextBox()
        Txt_book_publisher = New TextBox()
        SuspendLayout()
        ' 
        ' Lbl_error_msg_3
        ' 
        Lbl_error_msg_3.AutoSize = True
        Lbl_error_msg_3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_3.ForeColor = Color.Red
        Lbl_error_msg_3.Location = New Point(30, 202)
        Lbl_error_msg_3.Name = "Lbl_error_msg_3"
        Lbl_error_msg_3.Size = New Size(93, 15)
        Lbl_error_msg_3.TabIndex = 53
        Lbl_error_msg_3.Text = "Lbl_error_msg_3"
        ' 
        ' Lbl_error_msg_2
        ' 
        Lbl_error_msg_2.AutoSize = True
        Lbl_error_msg_2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_2.ForeColor = Color.Red
        Lbl_error_msg_2.Location = New Point(30, 152)
        Lbl_error_msg_2.Name = "Lbl_error_msg_2"
        Lbl_error_msg_2.Size = New Size(93, 15)
        Lbl_error_msg_2.TabIndex = 50
        Lbl_error_msg_2.Text = "Lbl_error_msg_2"
        ' 
        ' Lbl_error_msg_1
        ' 
        Lbl_error_msg_1.AutoSize = True
        Lbl_error_msg_1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_1.ForeColor = Color.Red
        Lbl_error_msg_1.Location = New Point(30, 102)
        Lbl_error_msg_1.Name = "Lbl_error_msg_1"
        Lbl_error_msg_1.Size = New Size(91, 15)
        Lbl_error_msg_1.TabIndex = 49
        Lbl_error_msg_1.Text = "Lbl_error_msg_1"
        ' 
        ' Lbl_error_msg
        ' 
        Lbl_error_msg.AutoSize = True
        Lbl_error_msg.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg.ForeColor = Color.Red
        Lbl_error_msg.Location = New Point(30, 52)
        Lbl_error_msg.Name = "Lbl_error_msg"
        Lbl_error_msg.Size = New Size(81, 15)
        Lbl_error_msg.TabIndex = 48
        Lbl_error_msg.Text = "Lbl_error_msg"
        ' 
        ' Txt_book_isbn
        ' 
        Txt_book_isbn.Font = New Font("Georgia", 14.25F)
        Txt_book_isbn.Location = New Point(30, 170)
        Txt_book_isbn.Name = "Txt_book_isbn"
        Txt_book_isbn.PlaceholderText = "Enter ISBN"
        Txt_book_isbn.Size = New Size(302, 29)
        Txt_book_isbn.TabIndex = 4
        ' 
        ' Btn_update
        ' 
        Btn_update.Location = New Point(30, 474)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(125, 30)
        Btn_update.TabIndex = 0
        Btn_update.Text = "&Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.Location = New Point(207, 474)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(125, 30)
        Btn_cancel.TabIndex = 0
        Btn_cancel.Text = "&Cancel"
        Btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Txt_delivery_delivered_by
        ' 
        Txt_delivery_delivered_by.Font = New Font("Georgia", 14.25F)
        Txt_delivery_delivered_by.Location = New Point(30, 70)
        Txt_delivery_delivered_by.Name = "Txt_delivery_delivered_by"
        Txt_delivery_delivered_by.PlaceholderText = "Enter Delivered By"
        Txt_delivery_delivered_by.Size = New Size(302, 29)
        Txt_delivery_delivered_by.TabIndex = 2
        ' 
        ' Txt_delivery_transaction_number
        ' 
        Txt_delivery_transaction_number.Font = New Font("Georgia", 14.25F)
        Txt_delivery_transaction_number.Location = New Point(30, 20)
        Txt_delivery_transaction_number.Name = "Txt_delivery_transaction_number"
        Txt_delivery_transaction_number.PlaceholderText = "Enter Transaction Number"
        Txt_delivery_transaction_number.Size = New Size(302, 29)
        Txt_delivery_transaction_number.TabIndex = 1
        ' 
        ' Txt_delivery_received_by
        ' 
        Txt_delivery_received_by.Font = New Font("Georgia", 14.25F)
        Txt_delivery_received_by.Location = New Point(30, 120)
        Txt_delivery_received_by.Name = "Txt_delivery_received_by"
        Txt_delivery_received_by.PlaceholderText = "Enter Received By"
        Txt_delivery_received_by.Size = New Size(302, 29)
        Txt_delivery_received_by.TabIndex = 3
        ' 
        ' Txt_book_title
        ' 
        Txt_book_title.Enabled = False
        Txt_book_title.Font = New Font("Georgia", 14.25F)
        Txt_book_title.Location = New Point(30, 220)
        Txt_book_title.Name = "Txt_book_title"
        Txt_book_title.PlaceholderText = "Book Title"
        Txt_book_title.Size = New Size(302, 29)
        Txt_book_title.TabIndex = 60
        ' 
        ' Txt_book_genre
        ' 
        Txt_book_genre.Enabled = False
        Txt_book_genre.Font = New Font("Georgia", 14.25F)
        Txt_book_genre.Location = New Point(30, 271)
        Txt_book_genre.Name = "Txt_book_genre"
        Txt_book_genre.PlaceholderText = "Book Genre"
        Txt_book_genre.Size = New Size(302, 29)
        Txt_book_genre.TabIndex = 61
        ' 
        ' Txt_book_author
        ' 
        Txt_book_author.Enabled = False
        Txt_book_author.Font = New Font("Georgia", 14.25F)
        Txt_book_author.Location = New Point(30, 322)
        Txt_book_author.Name = "Txt_book_author"
        Txt_book_author.PlaceholderText = "Book Author"
        Txt_book_author.Size = New Size(302, 29)
        Txt_book_author.TabIndex = 62
        ' 
        ' Txt_book_publish_year
        ' 
        Txt_book_publish_year.Enabled = False
        Txt_book_publish_year.Font = New Font("Georgia", 14.25F)
        Txt_book_publish_year.Location = New Point(30, 373)
        Txt_book_publish_year.Name = "Txt_book_publish_year"
        Txt_book_publish_year.PlaceholderText = "Book Publish Year"
        Txt_book_publish_year.Size = New Size(302, 29)
        Txt_book_publish_year.TabIndex = 63
        ' 
        ' Txt_book_publisher
        ' 
        Txt_book_publisher.Enabled = False
        Txt_book_publisher.Font = New Font("Georgia", 14.25F)
        Txt_book_publisher.Location = New Point(30, 424)
        Txt_book_publisher.Name = "Txt_book_publisher"
        Txt_book_publisher.PlaceholderText = "Book Publisher"
        Txt_book_publisher.Size = New Size(302, 29)
        Txt_book_publisher.TabIndex = 64
        ' 
        ' Fm_add_delivery
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(364, 520)
        ControlBox = False
        Controls.Add(Txt_book_publisher)
        Controls.Add(Txt_book_publish_year)
        Controls.Add(Txt_book_author)
        Controls.Add(Txt_book_genre)
        Controls.Add(Txt_book_title)
        Controls.Add(Txt_delivery_received_by)
        Controls.Add(Lbl_error_msg_3)
        Controls.Add(Lbl_error_msg_2)
        Controls.Add(Lbl_error_msg_1)
        Controls.Add(Lbl_error_msg)
        Controls.Add(Txt_book_isbn)
        Controls.Add(Btn_update)
        Controls.Add(Btn_cancel)
        Controls.Add(Txt_delivery_delivered_by)
        Controls.Add(Txt_delivery_transaction_number)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_add_delivery"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Lbl_error_msg_3 As Label
    Friend WithEvents Lbl_error_msg_2 As Label
    Friend WithEvents Lbl_error_msg_1 As Label
    Friend WithEvents Lbl_error_msg As Label
    Friend WithEvents Txt_book_isbn As TextBox
    Friend WithEvents Btn_update As Button
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Txt_delivery_delivered_by As TextBox
    Friend WithEvents Txt_delivery_transaction_number As TextBox
    Friend WithEvents Txt_delivery_received_by As TextBox
    Friend WithEvents Txt_book_title As TextBox
    Friend WithEvents Txt_book_genre As TextBox
    Friend WithEvents Txt_book_author As TextBox
    Friend WithEvents Txt_book_publish_year As TextBox
    Friend WithEvents Txt_book_publisher As TextBox
End Class
