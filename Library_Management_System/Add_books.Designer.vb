<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Btn_exit = New Button()
        Btn_update = New Button()
        Cb_author = New ComboBox()
        Cb_publisher = New ComboBox()
        Label1 = New Label()
        Cb_book_category = New ComboBox()
        Txt_book_qty = New TextBox()
        Label2 = New Label()
        Label7 = New Label()
        Txt_supplier_name = New TextBox()
        Cb_supplier_name = New ComboBox()
        Txt_primary_author_id = New TextBox()
        Txt_primary_publisher_id = New TextBox()
        Txt_primary_supplier_id = New TextBox()
        Label8 = New Label()
        Dtp_acquisition_date = New DateTimePicker()
        Dtp_publish_date = New DateTimePicker()
        Label9 = New Label()
        Txt_isbn = New TextBox()
        Txt_primary_category_id = New TextBox()
        update_Txt_isbn = New TextBox()
        SuspendLayout()
        ' 
        ' Txt_publisher
        ' 
        Txt_publisher.BorderStyle = BorderStyle.None
        Txt_publisher.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_publisher.Location = New Point(159, 131)
        Txt_publisher.Multiline = True
        Txt_publisher.Name = "Txt_publisher"
        Txt_publisher.PlaceholderText = "Pubisher"
        Txt_publisher.Size = New Size(243, 19)
        Txt_publisher.TabIndex = 5
        ' 
        ' Txt_author
        ' 
        Txt_author.BorderStyle = BorderStyle.None
        Txt_author.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_author.Location = New Point(159, 101)
        Txt_author.Multiline = True
        Txt_author.Name = "Txt_author"
        Txt_author.PlaceholderText = "Author"
        Txt_author.Size = New Size(243, 20)
        Txt_author.TabIndex = 4
        ' 
        ' Txt_book_name
        ' 
        Txt_book_name.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_book_name.Location = New Point(157, 9)
        Txt_book_name.Name = "Txt_book_name"
        Txt_book_name.PlaceholderText = "Book Name"
        Txt_book_name.Size = New Size(264, 21)
        Txt_book_name.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlLight
        Label3.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 16)
        Label3.TabIndex = 7
        Label3.Text = "Book Name :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlLight
        Label4.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 16)
        Label4.TabIndex = 8
        Label4.Text = "Publish Date :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlLight
        Label5.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 129)
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
        Label6.Location = New Point(12, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 16)
        Label6.TabIndex = 10
        Label6.Text = "Author :"
        ' 
        ' Btn_exit
        ' 
        Btn_exit.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_exit.Location = New Point(292, 280)
        Btn_exit.Name = "Btn_exit"
        Btn_exit.Size = New Size(129, 40)
        Btn_exit.TabIndex = 8
        Btn_exit.Text = "&Exit"
        Btn_exit.UseVisualStyleBackColor = True
        ' 
        ' Btn_update
        ' 
        Btn_update.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_update.Location = New Point(12, 279)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(129, 40)
        Btn_update.TabIndex = 0
        Btn_update.Text = "&Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Cb_author
        ' 
        Cb_author.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_author.FormattingEnabled = True
        Cb_author.ItemHeight = 15
        Cb_author.Location = New Point(157, 99)
        Cb_author.Name = "Cb_author"
        Cb_author.Size = New Size(264, 23)
        Cb_author.TabIndex = 0
        ' 
        ' Cb_publisher
        ' 
        Cb_publisher.FormattingEnabled = True
        Cb_publisher.Location = New Point(157, 128)
        Cb_publisher.Name = "Cb_publisher"
        Cb_publisher.Size = New Size(264, 23)
        Cb_publisher.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLight
        Label1.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 16)
        Label1.TabIndex = 18
        Label1.Text = "Category :"
        ' 
        ' Cb_book_category
        ' 
        Cb_book_category.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cb_book_category.FormattingEnabled = True
        Cb_book_category.Items.AddRange(New Object() {"(1, '1', 'Adventure fiction'),", "(2, '2', 'Biographies'),", "(3, '3', 'Books'),", "(4, '4', 'Chapter books'),", "(5, '5', 'Childrens literature'),", "(6, '6', 'Classics'),", "(7, '7', 'Comics'),", "(8, '8', 'Cooking'),", "(9, '9', 'Fantasy'),", "(10, '10', 'Fiction'),", "(11, '11', 'General fiction'),", "(12, '12', 'History'),", "(13, '13', 'Horror'),", "(14, '14', 'Humor'),", "(15, '15', 'Memoir'),", "(16, '16', 'Mystery'),", "(17, '17', 'Non-fiction'),", "(18, '18', 'Poetry'),", "(19, '19', 'Religion'),", "(20, '20', 'Romance'),", "(21, '21', 'Satire'),", "(22, '22', 'Science fiction'),", "(23, '23', 'Self-help book'),", "(24, '24', 'Thriller');"})
        Cb_book_category.Location = New Point(157, 39)
        Cb_book_category.Name = "Cb_book_category"
        Cb_book_category.Size = New Size(264, 23)
        Cb_book_category.TabIndex = 2
        Cb_book_category.Text = "-Select Category-"
        ' 
        ' Txt_book_qty
        ' 
        Txt_book_qty.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_book_qty.Location = New Point(157, 70)
        Txt_book_qty.Name = "Txt_book_qty"
        Txt_book_qty.PlaceholderText = "Quantity"
        Txt_book_qty.Size = New Size(264, 21)
        Txt_book_qty.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLight
        Label2.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 16)
        Label2.TabIndex = 20
        Label2.Text = "Quantity :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ControlLight
        Label7.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 188)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 16)
        Label7.TabIndex = 22
        Label7.Text = "Supplier Name :"
        ' 
        ' Txt_supplier_name
        ' 
        Txt_supplier_name.BorderStyle = BorderStyle.None
        Txt_supplier_name.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_supplier_name.Location = New Point(159, 189)
        Txt_supplier_name.Multiline = True
        Txt_supplier_name.Name = "Txt_supplier_name"
        Txt_supplier_name.PlaceholderText = "Supplier Name"
        Txt_supplier_name.Size = New Size(243, 20)
        Txt_supplier_name.TabIndex = 7
        ' 
        ' Cb_supplier_name
        ' 
        Cb_supplier_name.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_supplier_name.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cb_supplier_name.FormattingEnabled = True
        Cb_supplier_name.ItemHeight = 15
        Cb_supplier_name.Location = New Point(157, 187)
        Cb_supplier_name.Name = "Cb_supplier_name"
        Cb_supplier_name.Size = New Size(264, 23)
        Cb_supplier_name.TabIndex = 0
        ' 
        ' Txt_primary_author_id
        ' 
        Txt_primary_author_id.Location = New Point(426, 99)
        Txt_primary_author_id.Name = "Txt_primary_author_id"
        Txt_primary_author_id.PlaceholderText = "Primary Author ID"
        Txt_primary_author_id.Size = New Size(120, 23)
        Txt_primary_author_id.TabIndex = 24
        Txt_primary_author_id.Visible = False
        ' 
        ' Txt_primary_publisher_id
        ' 
        Txt_primary_publisher_id.Location = New Point(426, 128)
        Txt_primary_publisher_id.Name = "Txt_primary_publisher_id"
        Txt_primary_publisher_id.PlaceholderText = "Primary Publisher ID"
        Txt_primary_publisher_id.Size = New Size(120, 23)
        Txt_primary_publisher_id.TabIndex = 25
        Txt_primary_publisher_id.Visible = False
        ' 
        ' Txt_primary_supplier_id
        ' 
        Txt_primary_supplier_id.Location = New Point(426, 187)
        Txt_primary_supplier_id.Name = "Txt_primary_supplier_id"
        Txt_primary_supplier_id.PlaceholderText = "Primary Supplier ID"
        Txt_primary_supplier_id.Size = New Size(120, 23)
        Txt_primary_supplier_id.TabIndex = 26
        Txt_primary_supplier_id.Visible = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ControlLight
        Label8.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(12, 221)
        Label8.Name = "Label8"
        Label8.Size = New Size(136, 16)
        Label8.TabIndex = 28
        Label8.Text = "Acquisition Date :"
        ' 
        ' Dtp_acquisition_date
        ' 
        Dtp_acquisition_date.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Dtp_acquisition_date.Format = DateTimePickerFormat.Short
        Dtp_acquisition_date.Location = New Point(157, 219)
        Dtp_acquisition_date.Name = "Dtp_acquisition_date"
        Dtp_acquisition_date.Size = New Size(263, 21)
        Dtp_acquisition_date.TabIndex = 8
        Dtp_acquisition_date.Value = New Date(2024, 5, 8, 0, 53, 43, 0)
        ' 
        ' Dtp_publish_date
        ' 
        Dtp_publish_date.Format = DateTimePickerFormat.Short
        Dtp_publish_date.Location = New Point(157, 157)
        Dtp_publish_date.Name = "Dtp_publish_date"
        Dtp_publish_date.Size = New Size(264, 23)
        Dtp_publish_date.TabIndex = 6
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.ControlLight
        Label9.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(12, 253)
        Label9.Name = "Label9"
        Label9.Size = New Size(51, 16)
        Label9.TabIndex = 31
        Label9.Text = "ISBN :"
        ' 
        ' Txt_isbn
        ' 
        Txt_isbn.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_isbn.Location = New Point(157, 248)
        Txt_isbn.Name = "Txt_isbn"
        Txt_isbn.PlaceholderText = "ISBN"
        Txt_isbn.Size = New Size(263, 21)
        Txt_isbn.TabIndex = 32
        ' 
        ' Txt_primary_category_id
        ' 
        Txt_primary_category_id.Location = New Point(426, 39)
        Txt_primary_category_id.Name = "Txt_primary_category_id"
        Txt_primary_category_id.PlaceholderText = "Primary Category ID"
        Txt_primary_category_id.Size = New Size(120, 23)
        Txt_primary_category_id.TabIndex = 33
        Txt_primary_category_id.Visible = False
        ' 
        ' update_Txt_isbn
        ' 
        update_Txt_isbn.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        update_Txt_isbn.Location = New Point(157, 248)
        update_Txt_isbn.Name = "update_Txt_isbn"
        update_Txt_isbn.PlaceholderText = "ISBN"
        update_Txt_isbn.Size = New Size(263, 21)
        update_Txt_isbn.TabIndex = 9
        ' 
        ' Fm_add_books
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(434, 328)
        ControlBox = False
        Controls.Add(Txt_primary_category_id)
        Controls.Add(update_Txt_isbn)
        Controls.Add(Txt_isbn)
        Controls.Add(Label9)
        Controls.Add(Dtp_publish_date)
        Controls.Add(Dtp_acquisition_date)
        Controls.Add(Label8)
        Controls.Add(Txt_primary_supplier_id)
        Controls.Add(Txt_primary_publisher_id)
        Controls.Add(Txt_primary_author_id)
        Controls.Add(Label7)
        Controls.Add(Txt_supplier_name)
        Controls.Add(Label2)
        Controls.Add(Txt_book_qty)
        Controls.Add(Cb_book_category)
        Controls.Add(Label1)
        Controls.Add(Txt_publisher)
        Controls.Add(Txt_author)
        Controls.Add(Cb_publisher)
        Controls.Add(Cb_author)
        Controls.Add(Btn_exit)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Txt_book_name)
        Controls.Add(Cb_supplier_name)
        Controls.Add(Btn_update)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximumSize = New Size(816, 386)
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
    Friend WithEvents Btn_exit As Button
    Friend WithEvents Btn_update As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents Cb_publisher As ComboBox
    Friend WithEvents Cb_author As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cb_book_category As ComboBox
    Friend WithEvents Txt_book_qty As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_supplier_name As TextBox
    Friend WithEvents Cb_supplier_name As ComboBox
    Friend WithEvents Txt_primary_author_id As TextBox
    Friend WithEvents Txt_primary_publisher_id As TextBox
    Friend WithEvents Txt_primary_supplier_id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Dtp_acquisition_date As DateTimePicker
    Friend WithEvents Dtp_publish_date As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_isbn As TextBox
    Friend WithEvents Txt_primary_category_id As TextBox
    Friend WithEvents update_Txt_isbn As TextBox
End Class
