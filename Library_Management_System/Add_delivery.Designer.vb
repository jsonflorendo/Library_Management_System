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
        Txt_purchase_book_isbn = New TextBox()
        Btn_update = New Button()
        Btn_cancel = New Button()
        Txt_purchase_delivered_by = New TextBox()
        Txt_purchase_transaction_number = New TextBox()
        Txt_purchase_received_by = New TextBox()
        Txt_purchase_book_title = New TextBox()
        Txt_purchase_book_genre = New TextBox()
        Txt_purchase_book_author = New TextBox()
        Txt_purchase_book_publish_year = New TextBox()
        Txt_purchase_book_publisher = New TextBox()
        Rb_donate = New RadioButton()
        Rb_purchase = New RadioButton()
        Panel_purchase = New Panel()
        Label1 = New Label()
        Btn_purchase_add_supplier = New Button()
        Lbl_error_msg_4 = New Label()
        Dtp_purchase_delivery_date = New DateTimePicker()
        Label11 = New Label()
        Cb_purchase_supplier = New ComboBox()
        Panel_donate = New Panel()
        Lbl_error_msg_10 = New Label()
        Txt_donate_quantity = New TextBox()
        Label2 = New Label()
        Btn_donate_add_supplier = New Button()
        Lbl_error_msg_9 = New Label()
        Dtp_donate_delivery_date = New DateTimePicker()
        Label4 = New Label()
        Cb_donate_supplier = New ComboBox()
        Txt_donate_transaction_number = New TextBox()
        Txt_donate_book_publisher = New TextBox()
        Txt_donate_delivered_by = New TextBox()
        Txt_donate_book_publish_year = New TextBox()
        Txt_donate_book_isbn = New TextBox()
        Txt_donate_book_author = New TextBox()
        Lbl_error_msg_5 = New Label()
        Txt_donate_book_genre = New TextBox()
        Lbl_error_msg_6 = New Label()
        Txt_donate_book_title = New TextBox()
        Lbl_error_msg_7 = New Label()
        Txt_donate_received_by = New TextBox()
        Lbl_error_msg_8 = New Label()
        Label3 = New Label()
        Panel_purchase.SuspendLayout()
        Panel_donate.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lbl_error_msg_3
        ' 
        Lbl_error_msg_3.AutoSize = True
        Lbl_error_msg_3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_3.ForeColor = Color.Red
        Lbl_error_msg_3.Location = New Point(10, 240)
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
        Lbl_error_msg_2.Location = New Point(10, 190)
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
        Lbl_error_msg_1.Location = New Point(10, 89)
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
        Lbl_error_msg.Location = New Point(108, 42)
        Lbl_error_msg.Name = "Lbl_error_msg"
        Lbl_error_msg.Size = New Size(81, 15)
        Lbl_error_msg.TabIndex = 48
        Lbl_error_msg.Text = "Lbl_error_msg"
        ' 
        ' Txt_purchase_book_isbn
        ' 
        Txt_purchase_book_isbn.Font = New Font("Arial", 12.75F)
        Txt_purchase_book_isbn.Location = New Point(10, 258)
        Txt_purchase_book_isbn.Name = "Txt_purchase_book_isbn"
        Txt_purchase_book_isbn.PlaceholderText = "Enter ISBN"
        Txt_purchase_book_isbn.Size = New Size(380, 27)
        Txt_purchase_book_isbn.TabIndex = 5
        ' 
        ' Btn_update
        ' 
        Btn_update.Location = New Point(79, 719)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(125, 30)
        Btn_update.TabIndex = 0
        Btn_update.Text = "&Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.Location = New Point(256, 719)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(125, 30)
        Btn_cancel.TabIndex = 0
        Btn_cancel.Text = "&Cancel"
        Btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Txt_purchase_delivered_by
        ' 
        Txt_purchase_delivered_by.Font = New Font("Arial", 12.75F)
        Txt_purchase_delivered_by.Location = New Point(10, 158)
        Txt_purchase_delivered_by.Name = "Txt_purchase_delivered_by"
        Txt_purchase_delivered_by.PlaceholderText = "Enter Delivered By"
        Txt_purchase_delivered_by.Size = New Size(380, 27)
        Txt_purchase_delivered_by.TabIndex = 3
        ' 
        ' Txt_purchase_transaction_number
        ' 
        Txt_purchase_transaction_number.Font = New Font("Arial", 12.75F)
        Txt_purchase_transaction_number.Location = New Point(10, 60)
        Txt_purchase_transaction_number.Name = "Txt_purchase_transaction_number"
        Txt_purchase_transaction_number.PlaceholderText = "Enter Transaction Number"
        Txt_purchase_transaction_number.Size = New Size(380, 27)
        Txt_purchase_transaction_number.TabIndex = 1
        ' 
        ' Txt_purchase_received_by
        ' 
        Txt_purchase_received_by.Font = New Font("Arial", 12.75F)
        Txt_purchase_received_by.Location = New Point(10, 208)
        Txt_purchase_received_by.Name = "Txt_purchase_received_by"
        Txt_purchase_received_by.PlaceholderText = "Enter Received By"
        Txt_purchase_received_by.Size = New Size(380, 27)
        Txt_purchase_received_by.TabIndex = 4
        ' 
        ' Txt_purchase_book_title
        ' 
        Txt_purchase_book_title.Enabled = False
        Txt_purchase_book_title.Font = New Font("Arial", 12.75F)
        Txt_purchase_book_title.Location = New Point(10, 308)
        Txt_purchase_book_title.Name = "Txt_purchase_book_title"
        Txt_purchase_book_title.Size = New Size(380, 27)
        Txt_purchase_book_title.TabIndex = 60
        ' 
        ' Txt_purchase_book_genre
        ' 
        Txt_purchase_book_genre.Enabled = False
        Txt_purchase_book_genre.Font = New Font("Arial", 12.75F)
        Txt_purchase_book_genre.Location = New Point(10, 359)
        Txt_purchase_book_genre.Name = "Txt_purchase_book_genre"
        Txt_purchase_book_genre.Size = New Size(380, 27)
        Txt_purchase_book_genre.TabIndex = 61
        ' 
        ' Txt_purchase_book_author
        ' 
        Txt_purchase_book_author.Enabled = False
        Txt_purchase_book_author.Font = New Font("Arial", 12.75F)
        Txt_purchase_book_author.Location = New Point(10, 410)
        Txt_purchase_book_author.Name = "Txt_purchase_book_author"
        Txt_purchase_book_author.Size = New Size(380, 27)
        Txt_purchase_book_author.TabIndex = 62
        ' 
        ' Txt_purchase_book_publish_year
        ' 
        Txt_purchase_book_publish_year.Enabled = False
        Txt_purchase_book_publish_year.Font = New Font("Arial", 12.75F)
        Txt_purchase_book_publish_year.Location = New Point(10, 461)
        Txt_purchase_book_publish_year.Name = "Txt_purchase_book_publish_year"
        Txt_purchase_book_publish_year.Size = New Size(380, 27)
        Txt_purchase_book_publish_year.TabIndex = 63
        ' 
        ' Txt_purchase_book_publisher
        ' 
        Txt_purchase_book_publisher.Enabled = False
        Txt_purchase_book_publisher.Font = New Font("Arial", 12.75F)
        Txt_purchase_book_publisher.Location = New Point(10, 512)
        Txt_purchase_book_publisher.Name = "Txt_purchase_book_publisher"
        Txt_purchase_book_publisher.Size = New Size(380, 27)
        Txt_purchase_book_publisher.TabIndex = 64
        ' 
        ' Rb_donate
        ' 
        Rb_donate.AutoSize = True
        Rb_donate.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        Rb_donate.Location = New Point(162, 60)
        Rb_donate.Name = "Rb_donate"
        Rb_donate.Size = New Size(102, 34)
        Rb_donate.TabIndex = 65
        Rb_donate.TabStop = True
        Rb_donate.Text = "&Donate"
        Rb_donate.UseVisualStyleBackColor = True
        ' 
        ' Rb_purchase
        ' 
        Rb_purchase.AutoSize = True
        Rb_purchase.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        Rb_purchase.Location = New Point(28, 60)
        Rb_purchase.Name = "Rb_purchase"
        Rb_purchase.Size = New Size(119, 34)
        Rb_purchase.TabIndex = 66
        Rb_purchase.TabStop = True
        Rb_purchase.Text = "&Purchase"
        Rb_purchase.UseVisualStyleBackColor = True
        ' 
        ' Panel_purchase
        ' 
        Panel_purchase.Controls.Add(Label1)
        Panel_purchase.Controls.Add(Btn_purchase_add_supplier)
        Panel_purchase.Controls.Add(Lbl_error_msg_4)
        Panel_purchase.Controls.Add(Dtp_purchase_delivery_date)
        Panel_purchase.Controls.Add(Label11)
        Panel_purchase.Controls.Add(Cb_purchase_supplier)
        Panel_purchase.Controls.Add(Txt_purchase_transaction_number)
        Panel_purchase.Controls.Add(Txt_purchase_book_publisher)
        Panel_purchase.Controls.Add(Txt_purchase_delivered_by)
        Panel_purchase.Controls.Add(Txt_purchase_book_publish_year)
        Panel_purchase.Controls.Add(Txt_purchase_book_isbn)
        Panel_purchase.Controls.Add(Txt_purchase_book_author)
        Panel_purchase.Controls.Add(Lbl_error_msg)
        Panel_purchase.Controls.Add(Txt_purchase_book_genre)
        Panel_purchase.Controls.Add(Lbl_error_msg_1)
        Panel_purchase.Controls.Add(Txt_purchase_book_title)
        Panel_purchase.Controls.Add(Lbl_error_msg_2)
        Panel_purchase.Controls.Add(Txt_purchase_received_by)
        Panel_purchase.Controls.Add(Lbl_error_msg_3)
        Panel_purchase.Location = New Point(29, 100)
        Panel_purchase.Name = "Panel_purchase"
        Panel_purchase.Size = New Size(401, 560)
        Panel_purchase.TabIndex = 67
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLight
        Label1.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 18)
        Label1.TabIndex = 67
        Label1.Text = "Delivery Date:"
        ' 
        ' Btn_purchase_add_supplier
        ' 
        Btn_purchase_add_supplier.BackColor = Color.Tan
        Btn_purchase_add_supplier.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Btn_purchase_add_supplier.Location = New Point(356, 9)
        Btn_purchase_add_supplier.Margin = New Padding(4, 3, 4, 3)
        Btn_purchase_add_supplier.Name = "Btn_purchase_add_supplier"
        Btn_purchase_add_supplier.Size = New Size(32, 32)
        Btn_purchase_add_supplier.TabIndex = 66
        Btn_purchase_add_supplier.Text = "+"
        Btn_purchase_add_supplier.UseVisualStyleBackColor = False
        ' 
        ' Lbl_error_msg_4
        ' 
        Lbl_error_msg_4.AutoSize = True
        Lbl_error_msg_4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_4.ForeColor = Color.Red
        Lbl_error_msg_4.Location = New Point(10, 290)
        Lbl_error_msg_4.Name = "Lbl_error_msg_4"
        Lbl_error_msg_4.Size = New Size(93, 15)
        Lbl_error_msg_4.TabIndex = 65
        Lbl_error_msg_4.Text = "Lbl_error_msg_4"
        ' 
        ' Dtp_purchase_delivery_date
        ' 
        Dtp_purchase_delivery_date.Font = New Font("Arial", 12.75F)
        Dtp_purchase_delivery_date.Location = New Point(134, 108)
        Dtp_purchase_delivery_date.Margin = New Padding(4, 3, 4, 3)
        Dtp_purchase_delivery_date.Name = "Dtp_purchase_delivery_date"
        Dtp_purchase_delivery_date.Size = New Size(256, 27)
        Dtp_purchase_delivery_date.TabIndex = 2
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.ControlLight
        Label11.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(10, 15)
        Label11.Name = "Label11"
        Label11.Size = New Size(80, 18)
        Label11.TabIndex = 43
        Label11.Text = "Supplier:"
        ' 
        ' Cb_purchase_supplier
        ' 
        Cb_purchase_supplier.Font = New Font("Arial", 12.75F)
        Cb_purchase_supplier.FormattingEnabled = True
        Cb_purchase_supplier.Location = New Point(96, 10)
        Cb_purchase_supplier.Name = "Cb_purchase_supplier"
        Cb_purchase_supplier.Size = New Size(257, 27)
        Cb_purchase_supplier.TabIndex = 0
        ' 
        ' Panel_donate
        ' 
        Panel_donate.Controls.Add(Lbl_error_msg_10)
        Panel_donate.Controls.Add(Txt_donate_quantity)
        Panel_donate.Controls.Add(Label2)
        Panel_donate.Controls.Add(Btn_donate_add_supplier)
        Panel_donate.Controls.Add(Lbl_error_msg_9)
        Panel_donate.Controls.Add(Dtp_donate_delivery_date)
        Panel_donate.Controls.Add(Label4)
        Panel_donate.Controls.Add(Cb_donate_supplier)
        Panel_donate.Controls.Add(Txt_donate_transaction_number)
        Panel_donate.Controls.Add(Txt_donate_book_publisher)
        Panel_donate.Controls.Add(Txt_donate_delivered_by)
        Panel_donate.Controls.Add(Txt_donate_book_publish_year)
        Panel_donate.Controls.Add(Txt_donate_book_isbn)
        Panel_donate.Controls.Add(Txt_donate_book_author)
        Panel_donate.Controls.Add(Lbl_error_msg_5)
        Panel_donate.Controls.Add(Txt_donate_book_genre)
        Panel_donate.Controls.Add(Lbl_error_msg_6)
        Panel_donate.Controls.Add(Txt_donate_book_title)
        Panel_donate.Controls.Add(Lbl_error_msg_7)
        Panel_donate.Controls.Add(Txt_donate_received_by)
        Panel_donate.Controls.Add(Lbl_error_msg_8)
        Panel_donate.Location = New Point(26, 100)
        Panel_donate.Name = "Panel_donate"
        Panel_donate.Size = New Size(407, 613)
        Panel_donate.TabIndex = 68
        ' 
        ' Lbl_error_msg_10
        ' 
        Lbl_error_msg_10.AutoSize = True
        Lbl_error_msg_10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_10.ForeColor = Color.Red
        Lbl_error_msg_10.Location = New Point(13, 591)
        Lbl_error_msg_10.Name = "Lbl_error_msg_10"
        Lbl_error_msg_10.Size = New Size(98, 15)
        Lbl_error_msg_10.TabIndex = 88
        Lbl_error_msg_10.Text = "Lbl_error_msg_10"
        ' 
        ' Txt_donate_quantity
        ' 
        Txt_donate_quantity.Font = New Font("Arial", 12.75F)
        Txt_donate_quantity.Location = New Point(13, 559)
        Txt_donate_quantity.Name = "Txt_donate_quantity"
        Txt_donate_quantity.PlaceholderText = "Quantity"
        Txt_donate_quantity.Size = New Size(380, 27)
        Txt_donate_quantity.TabIndex = 87
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLight
        Label2.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 18)
        Label2.TabIndex = 86
        Label2.Text = "Delivery Date:"
        ' 
        ' Btn_donate_add_supplier
        ' 
        Btn_donate_add_supplier.BackColor = Color.Tan
        Btn_donate_add_supplier.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Btn_donate_add_supplier.Location = New Point(359, 9)
        Btn_donate_add_supplier.Margin = New Padding(4, 3, 4, 3)
        Btn_donate_add_supplier.Name = "Btn_donate_add_supplier"
        Btn_donate_add_supplier.Size = New Size(32, 32)
        Btn_donate_add_supplier.TabIndex = 85
        Btn_donate_add_supplier.Text = "+"
        Btn_donate_add_supplier.UseVisualStyleBackColor = False
        ' 
        ' Lbl_error_msg_9
        ' 
        Lbl_error_msg_9.AutoSize = True
        Lbl_error_msg_9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_9.ForeColor = Color.Red
        Lbl_error_msg_9.Location = New Point(13, 290)
        Lbl_error_msg_9.Name = "Lbl_error_msg_9"
        Lbl_error_msg_9.Size = New Size(93, 15)
        Lbl_error_msg_9.TabIndex = 84
        Lbl_error_msg_9.Text = "Lbl_error_msg_9"
        ' 
        ' Dtp_donate_delivery_date
        ' 
        Dtp_donate_delivery_date.Font = New Font("Arial", 12.75F)
        Dtp_donate_delivery_date.Location = New Point(137, 108)
        Dtp_donate_delivery_date.Margin = New Padding(4, 3, 4, 3)
        Dtp_donate_delivery_date.Name = "Dtp_donate_delivery_date"
        Dtp_donate_delivery_date.Size = New Size(256, 27)
        Dtp_donate_delivery_date.TabIndex = 70
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlLight
        Label4.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(13, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 18)
        Label4.TabIndex = 74
        Label4.Text = "Supplier:"
        ' 
        ' Cb_donate_supplier
        ' 
        Cb_donate_supplier.Font = New Font("Arial", 12.75F)
        Cb_donate_supplier.FormattingEnabled = True
        Cb_donate_supplier.Location = New Point(99, 10)
        Cb_donate_supplier.Name = "Cb_donate_supplier"
        Cb_donate_supplier.Size = New Size(257, 27)
        Cb_donate_supplier.TabIndex = 68
        ' 
        ' Txt_donate_transaction_number
        ' 
        Txt_donate_transaction_number.Font = New Font("Arial", 12.75F)
        Txt_donate_transaction_number.Location = New Point(13, 60)
        Txt_donate_transaction_number.Name = "Txt_donate_transaction_number"
        Txt_donate_transaction_number.PlaceholderText = "Enter Transaction Number"
        Txt_donate_transaction_number.Size = New Size(380, 27)
        Txt_donate_transaction_number.TabIndex = 69
        ' 
        ' Txt_donate_book_publisher
        ' 
        Txt_donate_book_publisher.Enabled = False
        Txt_donate_book_publisher.Font = New Font("Arial", 12.75F)
        Txt_donate_book_publisher.Location = New Point(13, 512)
        Txt_donate_book_publisher.Name = "Txt_donate_book_publisher"
        Txt_donate_book_publisher.Size = New Size(380, 27)
        Txt_donate_book_publisher.TabIndex = 83
        ' 
        ' Txt_donate_delivered_by
        ' 
        Txt_donate_delivered_by.Font = New Font("Arial", 12.75F)
        Txt_donate_delivered_by.Location = New Point(13, 158)
        Txt_donate_delivered_by.Name = "Txt_donate_delivered_by"
        Txt_donate_delivered_by.PlaceholderText = "Enter Delivered By"
        Txt_donate_delivered_by.Size = New Size(380, 27)
        Txt_donate_delivered_by.TabIndex = 71
        ' 
        ' Txt_donate_book_publish_year
        ' 
        Txt_donate_book_publish_year.Enabled = False
        Txt_donate_book_publish_year.Font = New Font("Arial", 12.75F)
        Txt_donate_book_publish_year.Location = New Point(13, 461)
        Txt_donate_book_publish_year.Name = "Txt_donate_book_publish_year"
        Txt_donate_book_publish_year.Size = New Size(380, 27)
        Txt_donate_book_publish_year.TabIndex = 82
        ' 
        ' Txt_donate_book_isbn
        ' 
        Txt_donate_book_isbn.Font = New Font("Arial", 12.75F)
        Txt_donate_book_isbn.Location = New Point(13, 258)
        Txt_donate_book_isbn.Name = "Txt_donate_book_isbn"
        Txt_donate_book_isbn.PlaceholderText = "Enter ISBN"
        Txt_donate_book_isbn.Size = New Size(380, 27)
        Txt_donate_book_isbn.TabIndex = 73
        ' 
        ' Txt_donate_book_author
        ' 
        Txt_donate_book_author.Enabled = False
        Txt_donate_book_author.Font = New Font("Arial", 12.75F)
        Txt_donate_book_author.Location = New Point(13, 410)
        Txt_donate_book_author.Name = "Txt_donate_book_author"
        Txt_donate_book_author.Size = New Size(380, 27)
        Txt_donate_book_author.TabIndex = 81
        ' 
        ' Lbl_error_msg_5
        ' 
        Lbl_error_msg_5.AutoSize = True
        Lbl_error_msg_5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_5.ForeColor = Color.Red
        Lbl_error_msg_5.Location = New Point(99, 42)
        Lbl_error_msg_5.Name = "Lbl_error_msg_5"
        Lbl_error_msg_5.Size = New Size(93, 15)
        Lbl_error_msg_5.TabIndex = 75
        Lbl_error_msg_5.Text = "Lbl_error_msg_5"
        ' 
        ' Txt_donate_book_genre
        ' 
        Txt_donate_book_genre.Enabled = False
        Txt_donate_book_genre.Font = New Font("Arial", 12.75F)
        Txt_donate_book_genre.Location = New Point(13, 359)
        Txt_donate_book_genre.Name = "Txt_donate_book_genre"
        Txt_donate_book_genre.Size = New Size(380, 27)
        Txt_donate_book_genre.TabIndex = 80
        ' 
        ' Lbl_error_msg_6
        ' 
        Lbl_error_msg_6.AutoSize = True
        Lbl_error_msg_6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_6.ForeColor = Color.Red
        Lbl_error_msg_6.Location = New Point(13, 89)
        Lbl_error_msg_6.Name = "Lbl_error_msg_6"
        Lbl_error_msg_6.Size = New Size(93, 15)
        Lbl_error_msg_6.TabIndex = 76
        Lbl_error_msg_6.Text = "Lbl_error_msg_6"
        ' 
        ' Txt_donate_book_title
        ' 
        Txt_donate_book_title.Enabled = False
        Txt_donate_book_title.Font = New Font("Arial", 12.75F)
        Txt_donate_book_title.Location = New Point(13, 308)
        Txt_donate_book_title.Name = "Txt_donate_book_title"
        Txt_donate_book_title.Size = New Size(380, 27)
        Txt_donate_book_title.TabIndex = 79
        ' 
        ' Lbl_error_msg_7
        ' 
        Lbl_error_msg_7.AutoSize = True
        Lbl_error_msg_7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_7.ForeColor = Color.Red
        Lbl_error_msg_7.Location = New Point(13, 190)
        Lbl_error_msg_7.Name = "Lbl_error_msg_7"
        Lbl_error_msg_7.Size = New Size(92, 15)
        Lbl_error_msg_7.TabIndex = 77
        Lbl_error_msg_7.Text = "Lbl_error_msg_7"
        ' 
        ' Txt_donate_received_by
        ' 
        Txt_donate_received_by.Font = New Font("Arial", 12.75F)
        Txt_donate_received_by.Location = New Point(13, 208)
        Txt_donate_received_by.Name = "Txt_donate_received_by"
        Txt_donate_received_by.PlaceholderText = "Enter Received By"
        Txt_donate_received_by.Size = New Size(380, 27)
        Txt_donate_received_by.TabIndex = 72
        ' 
        ' Lbl_error_msg_8
        ' 
        Lbl_error_msg_8.AutoSize = True
        Lbl_error_msg_8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_8.ForeColor = Color.Red
        Lbl_error_msg_8.Location = New Point(13, 240)
        Lbl_error_msg_8.Name = "Lbl_error_msg_8"
        Lbl_error_msg_8.Size = New Size(93, 15)
        Lbl_error_msg_8.TabIndex = 78
        Lbl_error_msg_8.Text = "Lbl_error_msg_8"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(124, 9)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(229, 38)
        Label3.TabIndex = 69
        Label3.Text = "Add Delivery"
        ' 
        ' Fm_add_delivery
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(460, 762)
        ControlBox = False
        Controls.Add(Panel_donate)
        Controls.Add(Label3)
        Controls.Add(Panel_purchase)
        Controls.Add(Rb_purchase)
        Controls.Add(Rb_donate)
        Controls.Add(Btn_update)
        Controls.Add(Btn_cancel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_add_delivery"
        StartPosition = FormStartPosition.CenterScreen
        Panel_purchase.ResumeLayout(False)
        Panel_purchase.PerformLayout()
        Panel_donate.ResumeLayout(False)
        Panel_donate.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Lbl_error_msg_3 As Label
    Friend WithEvents Lbl_error_msg_2 As Label
    Friend WithEvents Lbl_error_msg_1 As Label
    Friend WithEvents Lbl_error_msg As Label
    Friend WithEvents Txt_purchase_book_isbn As TextBox
    Friend WithEvents Btn_update As Button
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Txt_purchase_delivered_by As TextBox
    Friend WithEvents Txt_purchase_transaction_number As TextBox
    Friend WithEvents Txt_purchase_received_by As TextBox
    Friend WithEvents Txt_purchase_book_title As TextBox
    Friend WithEvents Txt_purchase_book_genre As TextBox
    Friend WithEvents Txt_purchase_book_author As TextBox
    Friend WithEvents Txt_purchase_book_publish_year As TextBox
    Friend WithEvents Txt_purchase_book_publisher As TextBox
    Friend WithEvents Rb_donate As RadioButton
    Friend WithEvents Rb_purchase As RadioButton
    Friend WithEvents Panel_purchase As Panel
    Friend WithEvents Cb_purchase_supplier As ComboBox
    Friend WithEvents Panel_donate As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Dtp_purchase_delivery_date As DateTimePicker
    Friend WithEvents Lbl_error_msg_4 As Label
    Friend WithEvents Btn_purchase_add_supplier As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_donate_add_supplier As Button
    Friend WithEvents Lbl_error_msg_9 As Label
    Friend WithEvents Dtp_donate_delivery_date As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Cb_donate_supplier As ComboBox
    Friend WithEvents Txt_donate_transaction_number As TextBox
    Friend WithEvents Txt_donate_book_publisher As TextBox
    Friend WithEvents Txt_donate_delivered_by As TextBox
    Friend WithEvents Txt_donate_book_publish_year As TextBox
    Friend WithEvents Txt_donate_book_isbn As TextBox
    Friend WithEvents Txt_donate_book_author As TextBox
    Friend WithEvents Lbl_error_msg_5 As Label
    Friend WithEvents Txt_donate_book_genre As TextBox
    Friend WithEvents Lbl_error_msg_6 As Label
    Friend WithEvents Txt_donate_book_title As TextBox
    Friend WithEvents Lbl_error_msg_7 As Label
    Friend WithEvents Txt_donate_received_by As TextBox
    Friend WithEvents Lbl_error_msg_8 As Label
    Friend WithEvents Lbl_error_msg_10 As Label
    Friend WithEvents Txt_donate_quantity As TextBox
    Friend WithEvents Label3 As Label
End Class
