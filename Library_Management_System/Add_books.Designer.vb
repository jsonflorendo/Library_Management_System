﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_add_books
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
        Txt_publisher = New TextBox()
        Txt_author = New TextBox()
        Txt_book_name = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Btn_cancel = New Button()
        Btn_update = New Button()
        Cb_author = New ComboBox()
        Cb_publisher = New ComboBox()
        Label1 = New Label()
        Cb_book_category = New ComboBox()
        Txt_primary_author_id = New TextBox()
        Txt_primary_publisher_id = New TextBox()
        Dtp_publish_date = New DateTimePicker()
        Label9 = New Label()
        save_Txt_isbn = New TextBox()
        Txt_primary_category_id = New TextBox()
        update_Txt_isbn = New TextBox()
        Lbl_error_msg_1 = New Label()
        Lbl_error_msg_3 = New Label()
        Lbl_error_msg_4 = New Label()
        Btn_add_category = New Button()
        Btn_add_author = New Button()
        Btn_add_publisher = New Button()
        Lbl_error_msg = New Label()
        Lbl_error_msg_2 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Txt_publisher
        ' 
        Txt_publisher.BorderStyle = BorderStyle.None
        Txt_publisher.Font = New Font("Arial", 9F)
        Txt_publisher.Location = New Point(175, 279)
        Txt_publisher.Margin = New Padding(4, 3, 4, 3)
        Txt_publisher.Multiline = True
        Txt_publisher.Name = "Txt_publisher"
        Txt_publisher.PlaceholderText = "Pubisher"
        Txt_publisher.Size = New Size(214, 18)
        Txt_publisher.TabIndex = 5
        ' 
        ' Txt_author
        ' 
        Txt_author.BorderStyle = BorderStyle.None
        Txt_author.Font = New Font("Arial", 9F)
        Txt_author.Location = New Point(175, 196)
        Txt_author.Margin = New Padding(4, 3, 4, 3)
        Txt_author.Multiline = True
        Txt_author.Name = "Txt_author"
        Txt_author.PlaceholderText = "Author"
        Txt_author.Size = New Size(214, 20)
        Txt_author.TabIndex = 4
        ' 
        ' Txt_book_name
        ' 
        Txt_book_name.Font = New Font("Arial", 9F)
        Txt_book_name.Location = New Point(173, 105)
        Txt_book_name.Margin = New Padding(4, 3, 4, 3)
        Txt_book_name.Name = "Txt_book_name"
        Txt_book_name.PlaceholderText = "Title"
        Txt_book_name.Size = New Size(264, 21)
        Txt_book_name.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlLight
        Label3.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(28, 107)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 16)
        Label3.TabIndex = 7
        Label3.Text = "Title:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlLight
        Label4.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(28, 244)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 16)
        Label4.TabIndex = 8
        Label4.Text = "Publish Year :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlLight
        Label5.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(28, 280)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 16)
        Label5.TabIndex = 9
        Label5.Text = "Publisher :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ControlLight
        Label6.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(28, 196)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 16)
        Label6.TabIndex = 10
        Label6.Text = "Author :"
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_cancel.Location = New Point(297, 331)
        Btn_cancel.Margin = New Padding(4, 3, 4, 3)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(130, 40)
        Btn_cancel.TabIndex = 8
        Btn_cancel.Text = "&Cancel"
        Btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Btn_update
        ' 
        Btn_update.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_update.Location = New Point(19, 330)
        Btn_update.Margin = New Padding(4, 3, 4, 3)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(130, 40)
        Btn_update.TabIndex = 0
        Btn_update.Text = "&Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Cb_author
        ' 
        Cb_author.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_author.FormattingEnabled = True
        Cb_author.ItemHeight = 15
        Cb_author.Location = New Point(173, 194)
        Cb_author.Margin = New Padding(4, 3, 4, 3)
        Cb_author.Name = "Cb_author"
        Cb_author.Size = New Size(231, 23)
        Cb_author.TabIndex = 0
        ' 
        ' Cb_publisher
        ' 
        Cb_publisher.FormattingEnabled = True
        Cb_publisher.Location = New Point(173, 276)
        Cb_publisher.Margin = New Padding(4, 3, 4, 3)
        Cb_publisher.Name = "Cb_publisher"
        Cb_publisher.Size = New Size(231, 23)
        Cb_publisher.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLight
        Label1.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(28, 151)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 16)
        Label1.TabIndex = 18
        Label1.Text = "Genre:"
        ' 
        ' Cb_book_category
        ' 
        Cb_book_category.Font = New Font("Arial", 9F)
        Cb_book_category.FormattingEnabled = True
        Cb_book_category.Items.AddRange(New Object() {"(1, '1', 'Adventure fiction'),", "(2, '2', 'Biographies'),", "(3, '3', 'Books'),", "(4, '4', 'Chapter books'),", "(5, '5', 'Childrens literature'),", "(6, '6', 'Classics'),", "(7, '7', 'Comics'),", "(8, '8', 'Cooking'),", "(9, '9', 'Fantasy'),", "(10, '10', 'Fiction'),", "(11, '11', 'General fiction'),", "(12, '12', 'History'),", "(13, '13', 'Horror'),", "(14, '14', 'Humor'),", "(15, '15', 'Memoir'),", "(16, '16', 'Mystery'),", "(17, '17', 'Non-fiction'),", "(18, '18', 'Poetry'),", "(19, '19', 'Religion'),", "(20, '20', 'Romance'),", "(21, '21', 'Satire'),", "(22, '22', 'Science fiction'),", "(23, '23', 'Self-help book'),", "(24, '24', 'Thriller');"})
        Cb_book_category.Location = New Point(173, 149)
        Cb_book_category.Margin = New Padding(4, 3, 4, 3)
        Cb_book_category.Name = "Cb_book_category"
        Cb_book_category.Size = New Size(231, 23)
        Cb_book_category.TabIndex = 2
        Cb_book_category.Text = "-Select Genre-"
        ' 
        ' Txt_primary_author_id
        ' 
        Txt_primary_author_id.Location = New Point(442, 194)
        Txt_primary_author_id.Margin = New Padding(4, 3, 4, 3)
        Txt_primary_author_id.Name = "Txt_primary_author_id"
        Txt_primary_author_id.PlaceholderText = "Primary Author ID"
        Txt_primary_author_id.Size = New Size(119, 23)
        Txt_primary_author_id.TabIndex = 24
        Txt_primary_author_id.Visible = False
        ' 
        ' Txt_primary_publisher_id
        ' 
        Txt_primary_publisher_id.Location = New Point(442, 276)
        Txt_primary_publisher_id.Margin = New Padding(4, 3, 4, 3)
        Txt_primary_publisher_id.Name = "Txt_primary_publisher_id"
        Txt_primary_publisher_id.PlaceholderText = "Primary Publisher ID"
        Txt_primary_publisher_id.Size = New Size(119, 23)
        Txt_primary_publisher_id.TabIndex = 25
        Txt_primary_publisher_id.Visible = False
        ' 
        ' Dtp_publish_date
        ' 
        Dtp_publish_date.Font = New Font("Arial", 9F)
        Dtp_publish_date.Location = New Point(173, 240)
        Dtp_publish_date.Margin = New Padding(4, 3, 4, 3)
        Dtp_publish_date.Name = "Dtp_publish_date"
        Dtp_publish_date.Size = New Size(264, 21)
        Dtp_publish_date.TabIndex = 6
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.ControlLight
        Label9.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(28, 64)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(51, 16)
        Label9.TabIndex = 31
        Label9.Text = "ISBN :"
        ' 
        ' save_Txt_isbn
        ' 
        save_Txt_isbn.Font = New Font("Arial", 9F)
        save_Txt_isbn.Location = New Point(173, 61)
        save_Txt_isbn.Margin = New Padding(4, 3, 4, 3)
        save_Txt_isbn.Name = "save_Txt_isbn"
        save_Txt_isbn.PlaceholderText = "ISBN"
        save_Txt_isbn.Size = New Size(264, 21)
        save_Txt_isbn.TabIndex = 32
        ' 
        ' Txt_primary_category_id
        ' 
        Txt_primary_category_id.Location = New Point(442, 149)
        Txt_primary_category_id.Margin = New Padding(4, 3, 4, 3)
        Txt_primary_category_id.Name = "Txt_primary_category_id"
        Txt_primary_category_id.PlaceholderText = "Primary Category ID"
        Txt_primary_category_id.Size = New Size(119, 23)
        Txt_primary_category_id.TabIndex = 33
        Txt_primary_category_id.Visible = False
        ' 
        ' update_Txt_isbn
        ' 
        update_Txt_isbn.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        update_Txt_isbn.Location = New Point(173, 61)
        update_Txt_isbn.Margin = New Padding(4, 3, 4, 3)
        update_Txt_isbn.Name = "update_Txt_isbn"
        update_Txt_isbn.PlaceholderText = "ISBN"
        update_Txt_isbn.Size = New Size(264, 21)
        update_Txt_isbn.TabIndex = 9
        ' 
        ' Lbl_error_msg_1
        ' 
        Lbl_error_msg_1.AutoSize = True
        Lbl_error_msg_1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_1.ForeColor = Color.Red
        Lbl_error_msg_1.Location = New Point(173, 129)
        Lbl_error_msg_1.Margin = New Padding(4, 0, 4, 0)
        Lbl_error_msg_1.Name = "Lbl_error_msg_1"
        Lbl_error_msg_1.Size = New Size(91, 15)
        Lbl_error_msg_1.TabIndex = 35
        Lbl_error_msg_1.Text = "Lbl_error_msg_1"
        ' 
        ' Lbl_error_msg_3
        ' 
        Lbl_error_msg_3.AutoSize = True
        Lbl_error_msg_3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_3.ForeColor = Color.Red
        Lbl_error_msg_3.Location = New Point(173, 220)
        Lbl_error_msg_3.Margin = New Padding(4, 0, 4, 0)
        Lbl_error_msg_3.Name = "Lbl_error_msg_3"
        Lbl_error_msg_3.Size = New Size(93, 15)
        Lbl_error_msg_3.TabIndex = 36
        Lbl_error_msg_3.Text = "Lbl_error_msg_3"
        ' 
        ' Lbl_error_msg_4
        ' 
        Lbl_error_msg_4.AutoSize = True
        Lbl_error_msg_4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_4.ForeColor = Color.Red
        Lbl_error_msg_4.Location = New Point(173, 302)
        Lbl_error_msg_4.Margin = New Padding(4, 0, 4, 0)
        Lbl_error_msg_4.Name = "Lbl_error_msg_4"
        Lbl_error_msg_4.Size = New Size(93, 15)
        Lbl_error_msg_4.TabIndex = 39
        Lbl_error_msg_4.Text = "Lbl_error_msg_4"
        ' 
        ' Btn_add_category
        ' 
        Btn_add_category.BackColor = Color.Tan
        Btn_add_category.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Btn_add_category.Location = New Point(411, 148)
        Btn_add_category.Margin = New Padding(4, 3, 4, 3)
        Btn_add_category.Name = "Btn_add_category"
        Btn_add_category.Size = New Size(24, 25)
        Btn_add_category.TabIndex = 43
        Btn_add_category.Text = "+"
        Btn_add_category.UseVisualStyleBackColor = False
        ' 
        ' Btn_add_author
        ' 
        Btn_add_author.BackColor = Color.Tan
        Btn_add_author.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Btn_add_author.Location = New Point(411, 193)
        Btn_add_author.Margin = New Padding(4, 3, 4, 3)
        Btn_add_author.Name = "Btn_add_author"
        Btn_add_author.Size = New Size(24, 25)
        Btn_add_author.TabIndex = 44
        Btn_add_author.Text = "+"
        Btn_add_author.UseVisualStyleBackColor = False
        ' 
        ' Btn_add_publisher
        ' 
        Btn_add_publisher.BackColor = Color.Tan
        Btn_add_publisher.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Btn_add_publisher.Location = New Point(411, 275)
        Btn_add_publisher.Margin = New Padding(4, 3, 4, 3)
        Btn_add_publisher.Name = "Btn_add_publisher"
        Btn_add_publisher.Size = New Size(24, 25)
        Btn_add_publisher.TabIndex = 45
        Btn_add_publisher.Text = "+"
        Btn_add_publisher.UseVisualStyleBackColor = False
        ' 
        ' Lbl_error_msg
        ' 
        Lbl_error_msg.AutoSize = True
        Lbl_error_msg.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg.ForeColor = Color.Red
        Lbl_error_msg.Location = New Point(173, 85)
        Lbl_error_msg.Margin = New Padding(4, 0, 4, 0)
        Lbl_error_msg.Name = "Lbl_error_msg"
        Lbl_error_msg.Size = New Size(81, 15)
        Lbl_error_msg.TabIndex = 46
        Lbl_error_msg.Text = "Lbl_error_msg"
        ' 
        ' Lbl_error_msg_2
        ' 
        Lbl_error_msg_2.AutoSize = True
        Lbl_error_msg_2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Lbl_error_msg_2.ForeColor = Color.Red
        Lbl_error_msg_2.Location = New Point(173, 175)
        Lbl_error_msg_2.Margin = New Padding(4, 0, 4, 0)
        Lbl_error_msg_2.Name = "Lbl_error_msg_2"
        Lbl_error_msg_2.Size = New Size(93, 15)
        Lbl_error_msg_2.TabIndex = 47
        Lbl_error_msg_2.Text = "Lbl_error_msg_2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(143, 9)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 38)
        Label2.TabIndex = 48
        Label2.Text = "Add Book"
        ' 
        ' Fm_add_books
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(462, 388)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(Lbl_error_msg_2)
        Controls.Add(Lbl_error_msg)
        Controls.Add(Btn_add_publisher)
        Controls.Add(Btn_add_author)
        Controls.Add(Btn_add_category)
        Controls.Add(Lbl_error_msg_4)
        Controls.Add(Lbl_error_msg_3)
        Controls.Add(Lbl_error_msg_1)
        Controls.Add(Txt_primary_category_id)
        Controls.Add(Label9)
        Controls.Add(Dtp_publish_date)
        Controls.Add(Txt_primary_publisher_id)
        Controls.Add(Txt_primary_author_id)
        Controls.Add(Cb_book_category)
        Controls.Add(Label1)
        Controls.Add(Txt_publisher)
        Controls.Add(Txt_author)
        Controls.Add(Cb_publisher)
        Controls.Add(Cb_author)
        Controls.Add(Btn_cancel)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Txt_book_name)
        Controls.Add(Btn_update)
        Controls.Add(save_Txt_isbn)
        Controls.Add(update_Txt_isbn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        Name = "Fm_add_books"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Txt_publisher As TextBox
    Friend WithEvents Txt_author As TextBox
    Friend WithEvents Txt_book_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Btn_update As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents Cb_publisher As ComboBox
    Friend WithEvents Cb_author As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cb_book_category As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_supplier_name As TextBox
    Friend WithEvents Cb_supplier_name As ComboBox
    Friend WithEvents Txt_primary_author_id As TextBox
    Friend WithEvents Txt_primary_publisher_id As TextBox
    Friend WithEvents Txt_primary_supplier_id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Dtp_publish_date As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents save_Txt_isbn As TextBox
    Friend WithEvents Txt_primary_category_id As TextBox
    Friend WithEvents update_Txt_isbn As TextBox
    Friend WithEvents Dtp_acquisition_date As DateTimePicker
    Friend WithEvents Lbl_error_msg As Label
    Friend WithEvents Lbl_error_msg_2 As Label
    Friend WithEvents Lbl_error_msg_3 As Label
    Friend WithEvents Lbl_error_msg_1 As Label
    Friend WithEvents Lbl_error_msg_4 As Label
    Friend WithEvents Lbl_error_msg_5 As Label
    Friend WithEvents Btn_add_category As Button
    Friend WithEvents Btn_add_author As Button
    Friend WithEvents Btn_add_publisher As Button
    Friend WithEvents Btn_add_supplier As Button
    Friend WithEvents Label2 As Label
End Class
