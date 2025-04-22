<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_home_page
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_home_page))
        Panel1_Books = New Panel()
        Lv_listed_books = New ListView()
        Listed_books0 = New ColumnHeader()
        Listed_books1 = New ColumnHeader()
        Listed_books2 = New ColumnHeader()
        Listed_books3 = New ColumnHeader()
        Listed_books4 = New ColumnHeader()
        Listed_books5 = New ColumnHeader()
        Cb_listed_books_category = New ComboBox()
        Btn_listed_books_edit = New Button()
        Btn_listed_books_delete = New Button()
        Btn_listed_books_add = New Button()
        Txt_listed_books_search = New TextBox()
        Panel2_Returned_Issued_Books = New Panel()
        Btn_return_books = New Button()
        Btn_borrow_books = New Button()
        Txt_returned_borrowed_books_search = New RoundCornerTextbox()
        Lv_returned_borrowed_books = New ListView()
        Returned_borrowed_books0 = New ColumnHeader()
        Returned_borrowed_books1 = New ColumnHeader()
        Returned_borrowed_books2 = New ColumnHeader()
        Returned_borrowed_books3 = New ColumnHeader()
        Returned_borrowed_books4 = New ColumnHeader()
        Returned_borrowed_books5 = New ColumnHeader()
        Returned_borrowed_books6 = New ColumnHeader()
        Panel6_Supplier = New Panel()
        Txt_search_supplier = New TextBox()
        Btn_supplier_delete = New Button()
        Btn_supplier_edit = New Button()
        Btn_supplier_add = New Button()
        Lv_supplier = New ListView()
        Listed_supplier_0 = New ColumnHeader()
        Listed_supplier_1 = New ColumnHeader()
        Listed_supplier_2 = New ColumnHeader()
        Listed_supplier_3 = New ColumnHeader()
        Listed_supplier_4 = New ColumnHeader()
        Listed_supplier_5 = New ColumnHeader()
        Listed_supplier_6 = New ColumnHeader()
        Panel3_Borrower_Info = New Panel()
        Btn_borrower_info_edit = New Button()
        Txt_student_info_search = New RoundCornerTextbox()
        Btn_borrower_info_delete = New Button()
        Btn_borrower_info_add = New Button()
        Lv_borrower_info = New ListView()
        Student_info0 = New ColumnHeader()
        Student_info1 = New ColumnHeader()
        Student_info2 = New ColumnHeader()
        Student_info3 = New ColumnHeader()
        Student_info4 = New ColumnHeader()
        Student_info5 = New ColumnHeader()
        Student_info6 = New ColumnHeader()
        Student_info7 = New ColumnHeader()
        Student_info8 = New ColumnHeader()
        Panel12_Shelf = New Panel()
        Btn_shelf_edit = New Button()
        Txt_search_shelf = New RoundCornerTextbox()
        Btn_shelf_delete = New Button()
        Btn_shelf_add = New Button()
        Lv_shelf = New ListView()
        Shelf_table0 = New ColumnHeader()
        Shelf_table1 = New ColumnHeader()
        Shelf_table2 = New ColumnHeader()
        Shelf_table3 = New ColumnHeader()
        Shelf_table4 = New ColumnHeader()
        Shelf_table5 = New ColumnHeader()
        Shelf_table6 = New ColumnHeader()
        Shelf_table7 = New ColumnHeader()
        Panel4_User_Acounts = New Panel()
        Btn_listed_accounts_edit = New Button()
        Lv_listed_accounts = New ListView()
        Listed_accounts0 = New ColumnHeader()
        Listed_accounts1 = New ColumnHeader()
        Listed_accounts2 = New ColumnHeader()
        Listed_accounts3 = New ColumnHeader()
        Listed_accounts4 = New ColumnHeader()
        Listed_accounts5 = New ColumnHeader()
        Listed_accounts6 = New ColumnHeader()
        Listed_accounts7 = New ColumnHeader()
        Listed_accounts8 = New ColumnHeader()
        Listed_accounts9 = New ColumnHeader()
        Btn_listed_accounts_delete = New Button()
        Btn_listed_accounts_add = New Button()
        Txt_listed_accounts_search = New TextBox()
        Btn_logout = New Button()
        Btn_listed_books = New Button()
        Btn_returned_books = New Button()
        Btn_student_information = New Button()
        Btn_listed_accounts = New Button()
        Tmr_home_page_date_time = New Timer(components)
        P_navigation = New Panel()
        GroupBox4 = New GroupBox()
        GroupBox3 = New GroupBox()
        Btn_book_inventory = New Button()
        Btn_shelf = New Button()
        GroupBox2 = New GroupBox()
        Btn_delivery = New Button()
        Btn_penalty_report = New Button()
        GroupBox1 = New GroupBox()
        Btn_supplier_maintenance = New Button()
        Btn_author_category_penalty_publisher_maintenance = New Button()
        Lbl_user_type_logged_in = New Label()
        Lbl_name_logged_in = New Label()
        PictureBox1 = New PictureBox()
        Panel8_Penalty_Report = New Panel()
        Txt_search_penalty_report = New TextBox()
        Btn_penalty_report_delete = New Button()
        Btn_penalty_report_edit = New Button()
        Lv_penalty = New ListView()
        Listed_penalty0 = New ColumnHeader()
        Listed_penalty1 = New ColumnHeader()
        Listed_penalty2 = New ColumnHeader()
        Listed_penalty3 = New ColumnHeader()
        Listed_penalty4 = New ColumnHeader()
        Listed_penalty5 = New ColumnHeader()
        Panel10_Author_Category_Penalty_Publisher = New Panel()
        Panel11_Publisher = New Panel()
        Btn_publisher_delete = New Button()
        Btn_publisher_edit = New Button()
        Txt_search_publisher = New TextBox()
        Btn_publisher_add = New Button()
        Lv_publisher = New ListView()
        ColumnHeader1 = New ColumnHeader()
        Panel5_Author = New Panel()
        Txt_search_author = New TextBox()
        Btn_author_delete = New Button()
        Lv_author = New ListView()
        ColumnHeader = New ColumnHeader()
        Btn_author_add = New Button()
        Btn_author_edit = New Button()
        Panel9_Penalty = New Panel()
        Btn_penalty_description_delete = New Button()
        Btn_penalty_description_edit = New Button()
        Txt_search_penalty_description = New TextBox()
        Btn_penalty_description_add = New Button()
        Lv_penalty_description = New ListView()
        Listed_details0 = New ColumnHeader()
        Listed_details1 = New ColumnHeader()
        Panel7_Category = New Panel()
        Txt_search_category = New TextBox()
        Btn_category_delete = New Button()
        Btn_category_edit = New Button()
        Btn_category_add = New Button()
        Lv_category = New ListView()
        Listed_Category0 = New ColumnHeader()
        Lbl_date_time = New Label()
        Panel13_Delivery = New Panel()
        Btn_delivery_edit = New Button()
        Txt_delivery_search = New RoundCornerTextbox()
        Btn_delivery_delete = New Button()
        Btn_delivery_add = New Button()
        Lv_delivery = New ListView()
        Delivery_table0 = New ColumnHeader()
        Delivery_table1 = New ColumnHeader()
        Delivery_table2 = New ColumnHeader()
        Delivery_table3 = New ColumnHeader()
        Delivery_table4 = New ColumnHeader()
        Delivery_table5 = New ColumnHeader()
        Delivery_table6 = New ColumnHeader()
        Delivery_table7 = New ColumnHeader()
        Delivery_table8 = New ColumnHeader()
        Delivery_table9 = New ColumnHeader()
        Panel14_Book_Inventory = New Panel()
        ListView1 = New ListView()
        Book_inventory0 = New ColumnHeader()
        Book_inventory1 = New ColumnHeader()
        Book_inventory2 = New ColumnHeader()
        Book_inventory3 = New ColumnHeader()
        Book_inventory4 = New ColumnHeader()
        Book_inventory5 = New ColumnHeader()
        Book_inventory6 = New ColumnHeader()
        Book_inventory7 = New ColumnHeader()
        Book_inventory8 = New ColumnHeader()
        Book_inventory9 = New ColumnHeader()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        Panel1_Books.SuspendLayout()
        Panel2_Returned_Issued_Books.SuspendLayout()
        Panel6_Supplier.SuspendLayout()
        Panel3_Borrower_Info.SuspendLayout()
        Panel12_Shelf.SuspendLayout()
        Panel4_User_Acounts.SuspendLayout()
        P_navigation.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel8_Penalty_Report.SuspendLayout()
        Panel10_Author_Category_Penalty_Publisher.SuspendLayout()
        Panel11_Publisher.SuspendLayout()
        Panel5_Author.SuspendLayout()
        Panel9_Penalty.SuspendLayout()
        Panel7_Category.SuspendLayout()
        Panel13_Delivery.SuspendLayout()
        Panel14_Book_Inventory.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1_Books
        ' 
        Panel1_Books.BackgroundImageLayout = ImageLayout.Stretch
        Panel1_Books.Controls.Add(Lv_listed_books)
        Panel1_Books.Controls.Add(Cb_listed_books_category)
        Panel1_Books.Controls.Add(Btn_listed_books_edit)
        Panel1_Books.Controls.Add(Btn_listed_books_delete)
        Panel1_Books.Controls.Add(Btn_listed_books_add)
        Panel1_Books.Controls.Add(Txt_listed_books_search)
        Panel1_Books.Location = New Point(300, 28)
        Panel1_Books.Name = "Panel1_Books"
        Panel1_Books.Size = New Size(1603, 970)
        Panel1_Books.TabIndex = 13
        ' 
        ' Lv_listed_books
        ' 
        Lv_listed_books.BackColor = SystemColors.ActiveCaption
        Lv_listed_books.Columns.AddRange(New ColumnHeader() {Listed_books0, Listed_books1, Listed_books2, Listed_books3, Listed_books4, Listed_books5})
        Lv_listed_books.Font = New Font("Georgia", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lv_listed_books.ForeColor = SystemColors.WindowText
        Lv_listed_books.FullRowSelect = True
        Lv_listed_books.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lv_listed_books.Location = New Point(29, 74)
        Lv_listed_books.Name = "Lv_listed_books"
        Lv_listed_books.Size = New Size(1546, 874)
        Lv_listed_books.TabIndex = 6
        Lv_listed_books.UseCompatibleStateImageBehavior = False
        Lv_listed_books.View = View.Details
        ' 
        ' Listed_books0
        ' 
        Listed_books0.Text = "ISBN"
        Listed_books0.Width = 180
        ' 
        ' Listed_books1
        ' 
        Listed_books1.Text = "Title"
        Listed_books1.TextAlign = HorizontalAlignment.Center
        Listed_books1.Width = 300
        ' 
        ' Listed_books2
        ' 
        Listed_books2.Text = "Genre"
        Listed_books2.TextAlign = HorizontalAlignment.Center
        Listed_books2.Width = 250
        ' 
        ' Listed_books3
        ' 
        Listed_books3.Text = "Author"
        Listed_books3.TextAlign = HorizontalAlignment.Center
        Listed_books3.Width = 250
        ' 
        ' Listed_books4
        ' 
        Listed_books4.Text = "Publish Year"
        Listed_books4.TextAlign = HorizontalAlignment.Center
        Listed_books4.Width = 280
        ' 
        ' Listed_books5
        ' 
        Listed_books5.Text = "Publisher"
        Listed_books5.TextAlign = HorizontalAlignment.Center
        Listed_books5.Width = 280
        ' 
        ' Cb_listed_books_category
        ' 
        Cb_listed_books_category.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cb_listed_books_category.ForeColor = Color.Black
        Cb_listed_books_category.FormattingEnabled = True
        Cb_listed_books_category.Location = New Point(298, 26)
        Cb_listed_books_category.Name = "Cb_listed_books_category"
        Cb_listed_books_category.Size = New Size(273, 26)
        Cb_listed_books_category.TabIndex = 23
        Cb_listed_books_category.Text = "All Genre"
        ' 
        ' Btn_listed_books_edit
        ' 
        Btn_listed_books_edit.BackColor = Color.Tan
        Btn_listed_books_edit.Font = New Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_listed_books_edit.Location = New Point(1336, 29)
        Btn_listed_books_edit.Name = "Btn_listed_books_edit"
        Btn_listed_books_edit.Size = New Size(118, 30)
        Btn_listed_books_edit.TabIndex = 11
        Btn_listed_books_edit.Text = "&Edit"
        Btn_listed_books_edit.UseVisualStyleBackColor = False
        ' 
        ' Btn_listed_books_delete
        ' 
        Btn_listed_books_delete.BackColor = Color.Tan
        Btn_listed_books_delete.Font = New Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_listed_books_delete.Location = New Point(1460, 29)
        Btn_listed_books_delete.Name = "Btn_listed_books_delete"
        Btn_listed_books_delete.Size = New Size(118, 30)
        Btn_listed_books_delete.TabIndex = 10
        Btn_listed_books_delete.Text = "&Delete"
        Btn_listed_books_delete.UseVisualStyleBackColor = False
        ' 
        ' Btn_listed_books_add
        ' 
        Btn_listed_books_add.BackColor = Color.Tan
        Btn_listed_books_add.Font = New Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_listed_books_add.Location = New Point(1212, 29)
        Btn_listed_books_add.Name = "Btn_listed_books_add"
        Btn_listed_books_add.Size = New Size(118, 30)
        Btn_listed_books_add.TabIndex = 9
        Btn_listed_books_add.Text = "&Add"
        Btn_listed_books_add.UseVisualStyleBackColor = False
        ' 
        ' Txt_listed_books_search
        ' 
        Txt_listed_books_search.Font = New Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_listed_books_search.Location = New Point(29, 18)
        Txt_listed_books_search.Name = "Txt_listed_books_search"
        Txt_listed_books_search.PlaceholderText = "Search"
        Txt_listed_books_search.Size = New Size(246, 38)
        Txt_listed_books_search.TabIndex = 7
        ' 
        ' Panel2_Returned_Issued_Books
        ' 
        Panel2_Returned_Issued_Books.BackgroundImageLayout = ImageLayout.Stretch
        Panel2_Returned_Issued_Books.Controls.Add(Btn_return_books)
        Panel2_Returned_Issued_Books.Controls.Add(Btn_borrow_books)
        Panel2_Returned_Issued_Books.Controls.Add(Txt_returned_borrowed_books_search)
        Panel2_Returned_Issued_Books.Controls.Add(Lv_returned_borrowed_books)
        Panel2_Returned_Issued_Books.Location = New Point(300, 28)
        Panel2_Returned_Issued_Books.Name = "Panel2_Returned_Issued_Books"
        Panel2_Returned_Issued_Books.Size = New Size(1603, 970)
        Panel2_Returned_Issued_Books.TabIndex = 14
        ' 
        ' Btn_return_books
        ' 
        Btn_return_books.BackColor = Color.Tan
        Btn_return_books.Font = New Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_return_books.Location = New Point(1385, 26)
        Btn_return_books.Name = "Btn_return_books"
        Btn_return_books.Size = New Size(194, 30)
        Btn_return_books.TabIndex = 19
        Btn_return_books.Text = "&Return Books"
        Btn_return_books.UseVisualStyleBackColor = False
        ' 
        ' Btn_borrow_books
        ' 
        Btn_borrow_books.BackColor = Color.Tan
        Btn_borrow_books.Font = New Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_borrow_books.Location = New Point(1185, 26)
        Btn_borrow_books.Name = "Btn_borrow_books"
        Btn_borrow_books.Size = New Size(194, 30)
        Btn_borrow_books.TabIndex = 18
        Btn_borrow_books.Text = "&Borrow Books"
        Btn_borrow_books.UseVisualStyleBackColor = False
        ' 
        ' Txt_returned_borrowed_books_search
        ' 
        Txt_returned_borrowed_books_search.Font = New Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_returned_borrowed_books_search.Location = New Point(33, 21)
        Txt_returned_borrowed_books_search.Name = "Txt_returned_borrowed_books_search"
        Txt_returned_borrowed_books_search.PlaceholderText = "Search"
        Txt_returned_borrowed_books_search.Size = New Size(246, 38)
        Txt_returned_borrowed_books_search.TabIndex = 17
        ' 
        ' Lv_returned_borrowed_books
        ' 
        Lv_returned_borrowed_books.BackColor = SystemColors.ActiveCaption
        Lv_returned_borrowed_books.Columns.AddRange(New ColumnHeader() {Returned_borrowed_books0, Returned_borrowed_books1, Returned_borrowed_books2, Returned_borrowed_books3, Returned_borrowed_books4, Returned_borrowed_books5, Returned_borrowed_books6})
        Lv_returned_borrowed_books.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lv_returned_borrowed_books.FullRowSelect = True
        Lv_returned_borrowed_books.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lv_returned_borrowed_books.Location = New Point(33, 72)
        Lv_returned_borrowed_books.Name = "Lv_returned_borrowed_books"
        Lv_returned_borrowed_books.Size = New Size(1546, 874)
        Lv_returned_borrowed_books.TabIndex = 3
        Lv_returned_borrowed_books.UseCompatibleStateImageBehavior = False
        Lv_returned_borrowed_books.View = View.Details
        ' 
        ' Returned_borrowed_books0
        ' 
        Returned_borrowed_books0.Text = "Transaction No"
        Returned_borrowed_books0.Width = 175
        ' 
        ' Returned_borrowed_books1
        ' 
        Returned_borrowed_books1.Text = "ID Number"
        Returned_borrowed_books1.TextAlign = HorizontalAlignment.Center
        Returned_borrowed_books1.Width = 150
        ' 
        ' Returned_borrowed_books2
        ' 
        Returned_borrowed_books2.Text = "Issued To"
        Returned_borrowed_books2.TextAlign = HorizontalAlignment.Center
        Returned_borrowed_books2.Width = 267
        ' 
        ' Returned_borrowed_books3
        ' 
        Returned_borrowed_books3.Text = "Book Name"
        Returned_borrowed_books3.TextAlign = HorizontalAlignment.Center
        Returned_borrowed_books3.Width = 300
        ' 
        ' Returned_borrowed_books4
        ' 
        Returned_borrowed_books4.Text = "Issued Date"
        Returned_borrowed_books4.TextAlign = HorizontalAlignment.Center
        Returned_borrowed_books4.Width = 216
        ' 
        ' Returned_borrowed_books5
        ' 
        Returned_borrowed_books5.Text = "Due Date"
        Returned_borrowed_books5.TextAlign = HorizontalAlignment.Center
        Returned_borrowed_books5.Width = 216
        ' 
        ' Returned_borrowed_books6
        ' 
        Returned_borrowed_books6.Text = "Returned Date"
        Returned_borrowed_books6.TextAlign = HorizontalAlignment.Center
        Returned_borrowed_books6.Width = 218
        ' 
        ' Panel6_Supplier
        ' 
        Panel6_Supplier.Controls.Add(Txt_search_supplier)
        Panel6_Supplier.Controls.Add(Btn_supplier_delete)
        Panel6_Supplier.Controls.Add(Btn_supplier_edit)
        Panel6_Supplier.Controls.Add(Btn_supplier_add)
        Panel6_Supplier.Controls.Add(Lv_supplier)
        Panel6_Supplier.Location = New Point(300, 31)
        Panel6_Supplier.Name = "Panel6_Supplier"
        Panel6_Supplier.Size = New Size(1592, 964)
        Panel6_Supplier.TabIndex = 26
        ' 
        ' Txt_search_supplier
        ' 
        Txt_search_supplier.Font = New Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_search_supplier.Location = New Point(22, 14)
        Txt_search_supplier.Name = "Txt_search_supplier"
        Txt_search_supplier.PlaceholderText = "Search"
        Txt_search_supplier.Size = New Size(246, 38)
        Txt_search_supplier.TabIndex = 14
        ' 
        ' Btn_supplier_delete
        ' 
        Btn_supplier_delete.BackColor = Color.Tan
        Btn_supplier_delete.Font = New Font("Georgia", 9F)
        Btn_supplier_delete.Location = New Point(1457, 22)
        Btn_supplier_delete.Name = "Btn_supplier_delete"
        Btn_supplier_delete.Size = New Size(118, 30)
        Btn_supplier_delete.TabIndex = 5
        Btn_supplier_delete.Text = "&Delete"
        Btn_supplier_delete.UseVisualStyleBackColor = False
        ' 
        ' Btn_supplier_edit
        ' 
        Btn_supplier_edit.BackColor = Color.Tan
        Btn_supplier_edit.Font = New Font("Georgia", 9F)
        Btn_supplier_edit.Location = New Point(1315, 22)
        Btn_supplier_edit.Name = "Btn_supplier_edit"
        Btn_supplier_edit.Size = New Size(118, 30)
        Btn_supplier_edit.TabIndex = 4
        Btn_supplier_edit.Text = "&Edit"
        Btn_supplier_edit.UseVisualStyleBackColor = False
        ' 
        ' Btn_supplier_add
        ' 
        Btn_supplier_add.BackColor = Color.Tan
        Btn_supplier_add.Font = New Font("Georgia", 9F)
        Btn_supplier_add.Location = New Point(1170, 22)
        Btn_supplier_add.Name = "Btn_supplier_add"
        Btn_supplier_add.Size = New Size(118, 30)
        Btn_supplier_add.TabIndex = 3
        Btn_supplier_add.Text = "&Add"
        Btn_supplier_add.UseVisualStyleBackColor = False
        ' 
        ' Lv_supplier
        ' 
        Lv_supplier.Columns.AddRange(New ColumnHeader() {Listed_supplier_0, Listed_supplier_1, Listed_supplier_2, Listed_supplier_3, Listed_supplier_4, Listed_supplier_5, Listed_supplier_6})
        Lv_supplier.Font = New Font("Georgia", 13F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lv_supplier.FullRowSelect = True
        Lv_supplier.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lv_supplier.HideSelection = True
        Lv_supplier.Location = New Point(22, 75)
        Lv_supplier.Name = "Lv_supplier"
        Lv_supplier.Size = New Size(1553, 875)
        Lv_supplier.TabIndex = 0
        Lv_supplier.UseCompatibleStateImageBehavior = False
        Lv_supplier.View = View.Details
        ' 
        ' Listed_supplier_0
        ' 
        Listed_supplier_0.Text = "Supplier ID"
        Listed_supplier_0.Width = 150
        ' 
        ' Listed_supplier_1
        ' 
        Listed_supplier_1.Text = "Supplier Name"
        Listed_supplier_1.Width = 250
        ' 
        ' Listed_supplier_2
        ' 
        Listed_supplier_2.Text = "Full Name"
        Listed_supplier_2.Width = 250
        ' 
        ' Listed_supplier_3
        ' 
        Listed_supplier_3.Text = "Email Address"
        Listed_supplier_3.Width = 250
        ' 
        ' Listed_supplier_4
        ' 
        Listed_supplier_4.Text = "Contact No."
        Listed_supplier_4.TextAlign = HorizontalAlignment.Center
        Listed_supplier_4.Width = 180
        ' 
        ' Listed_supplier_5
        ' 
        Listed_supplier_5.Text = "Address"
        Listed_supplier_5.Width = 329
        ' 
        ' Listed_supplier_6
        ' 
        Listed_supplier_6.Text = "Source Type"
        Listed_supplier_6.TextAlign = HorizontalAlignment.Center
        Listed_supplier_6.Width = 140
        ' 
        ' Panel3_Borrower_Info
        ' 
        Panel3_Borrower_Info.BackgroundImageLayout = ImageLayout.Stretch
        Panel3_Borrower_Info.Controls.Add(Btn_borrower_info_edit)
        Panel3_Borrower_Info.Controls.Add(Txt_student_info_search)
        Panel3_Borrower_Info.Controls.Add(Btn_borrower_info_delete)
        Panel3_Borrower_Info.Controls.Add(Btn_borrower_info_add)
        Panel3_Borrower_Info.Controls.Add(Lv_borrower_info)
        Panel3_Borrower_Info.Location = New Point(300, 28)
        Panel3_Borrower_Info.Name = "Panel3_Borrower_Info"
        Panel3_Borrower_Info.Size = New Size(1603, 970)
        Panel3_Borrower_Info.TabIndex = 15
        ' 
        ' Btn_borrower_info_edit
        ' 
        Btn_borrower_info_edit.BackColor = Color.Tan
        Btn_borrower_info_edit.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_borrower_info_edit.Location = New Point(1336, 32)
        Btn_borrower_info_edit.Name = "Btn_borrower_info_edit"
        Btn_borrower_info_edit.Size = New Size(118, 30)
        Btn_borrower_info_edit.TabIndex = 13
        Btn_borrower_info_edit.Text = "&Edit"
        Btn_borrower_info_edit.UseVisualStyleBackColor = False
        ' 
        ' Txt_student_info_search
        ' 
        Txt_student_info_search.Font = New Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_student_info_search.Location = New Point(33, 24)
        Txt_student_info_search.Name = "Txt_student_info_search"
        Txt_student_info_search.PlaceholderText = "Search"
        Txt_student_info_search.Size = New Size(246, 38)
        Txt_student_info_search.TabIndex = 12
        ' 
        ' Btn_borrower_info_delete
        ' 
        Btn_borrower_info_delete.BackColor = Color.Tan
        Btn_borrower_info_delete.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_borrower_info_delete.Location = New Point(1461, 32)
        Btn_borrower_info_delete.Name = "Btn_borrower_info_delete"
        Btn_borrower_info_delete.Size = New Size(118, 30)
        Btn_borrower_info_delete.TabIndex = 10
        Btn_borrower_info_delete.Text = "&Delete"
        Btn_borrower_info_delete.UseVisualStyleBackColor = False
        ' 
        ' Btn_borrower_info_add
        ' 
        Btn_borrower_info_add.BackColor = Color.Tan
        Btn_borrower_info_add.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_borrower_info_add.Location = New Point(1209, 32)
        Btn_borrower_info_add.Name = "Btn_borrower_info_add"
        Btn_borrower_info_add.Size = New Size(118, 30)
        Btn_borrower_info_add.TabIndex = 9
        Btn_borrower_info_add.Text = "&Add"
        Btn_borrower_info_add.UseVisualStyleBackColor = False
        ' 
        ' Lv_borrower_info
        ' 
        Lv_borrower_info.BackColor = SystemColors.ActiveCaption
        Lv_borrower_info.Columns.AddRange(New ColumnHeader() {Student_info0, Student_info1, Student_info2, Student_info3, Student_info4, Student_info5, Student_info6, Student_info7, Student_info8})
        Lv_borrower_info.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lv_borrower_info.FullRowSelect = True
        Lv_borrower_info.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lv_borrower_info.Location = New Point(33, 88)
        Lv_borrower_info.Name = "Lv_borrower_info"
        Lv_borrower_info.Size = New Size(1546, 874)
        Lv_borrower_info.TabIndex = 6
        Lv_borrower_info.UseCompatibleStateImageBehavior = False
        Lv_borrower_info.View = View.Details
        ' 
        ' Student_info0
        ' 
        Student_info0.Text = "ID Number"
        Student_info0.Width = 180
        ' 
        ' Student_info1
        ' 
        Student_info1.Text = "Last Name"
        Student_info1.TextAlign = HorizontalAlignment.Center
        Student_info1.Width = 210
        ' 
        ' Student_info2
        ' 
        Student_info2.Text = "First Name"
        Student_info2.TextAlign = HorizontalAlignment.Center
        Student_info2.Width = 210
        ' 
        ' Student_info3
        ' 
        Student_info3.Text = "Middle Name"
        Student_info3.TextAlign = HorizontalAlignment.Center
        Student_info3.Width = 210
        ' 
        ' Student_info4
        ' 
        Student_info4.Text = "Category Type"
        Student_info4.TextAlign = HorizontalAlignment.Center
        Student_info4.Width = 200
        ' 
        ' Student_info5
        ' 
        Student_info5.Text = "Gender"
        Student_info5.TextAlign = HorizontalAlignment.Center
        Student_info5.Width = 132
        ' 
        ' Student_info6
        ' 
        Student_info6.Text = "Contact No."
        Student_info6.TextAlign = HorizontalAlignment.Center
        Student_info6.Width = 200
        ' 
        ' Student_info7
        ' 
        Student_info7.Text = "Email"
        Student_info7.Width = 400
        ' 
        ' Student_info8
        ' 
        Student_info8.Text = "Address"
        Student_info8.Width = 400
        ' 
        ' Panel12_Shelf
        ' 
        Panel12_Shelf.BackgroundImageLayout = ImageLayout.Stretch
        Panel12_Shelf.Controls.Add(Btn_shelf_edit)
        Panel12_Shelf.Controls.Add(Txt_search_shelf)
        Panel12_Shelf.Controls.Add(Btn_shelf_delete)
        Panel12_Shelf.Controls.Add(Btn_shelf_add)
        Panel12_Shelf.Controls.Add(Lv_shelf)
        Panel12_Shelf.Location = New Point(300, 28)
        Panel12_Shelf.Name = "Panel12_Shelf"
        Panel12_Shelf.Size = New Size(1603, 970)
        Panel12_Shelf.TabIndex = 16
        ' 
        ' Btn_shelf_edit
        ' 
        Btn_shelf_edit.BackColor = Color.Tan
        Btn_shelf_edit.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_shelf_edit.Location = New Point(1336, 32)
        Btn_shelf_edit.Name = "Btn_shelf_edit"
        Btn_shelf_edit.Size = New Size(118, 30)
        Btn_shelf_edit.TabIndex = 13
        Btn_shelf_edit.Text = "&Edit"
        Btn_shelf_edit.UseVisualStyleBackColor = False
        ' 
        ' Txt_search_shelf
        ' 
        Txt_search_shelf.Font = New Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_search_shelf.Location = New Point(33, 24)
        Txt_search_shelf.Name = "Txt_search_shelf"
        Txt_search_shelf.PlaceholderText = "Search"
        Txt_search_shelf.Size = New Size(246, 38)
        Txt_search_shelf.TabIndex = 12
        ' 
        ' Btn_shelf_delete
        ' 
        Btn_shelf_delete.BackColor = Color.Tan
        Btn_shelf_delete.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_shelf_delete.Location = New Point(1461, 32)
        Btn_shelf_delete.Name = "Btn_shelf_delete"
        Btn_shelf_delete.Size = New Size(118, 30)
        Btn_shelf_delete.TabIndex = 10
        Btn_shelf_delete.Text = "&Delete"
        Btn_shelf_delete.UseVisualStyleBackColor = False
        ' 
        ' Btn_shelf_add
        ' 
        Btn_shelf_add.BackColor = Color.Tan
        Btn_shelf_add.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_shelf_add.Location = New Point(1209, 32)
        Btn_shelf_add.Name = "Btn_shelf_add"
        Btn_shelf_add.Size = New Size(118, 30)
        Btn_shelf_add.TabIndex = 9
        Btn_shelf_add.Text = "&Add"
        Btn_shelf_add.UseVisualStyleBackColor = False
        ' 
        ' Lv_shelf
        ' 
        Lv_shelf.BackColor = SystemColors.ActiveCaption
        Lv_shelf.Columns.AddRange(New ColumnHeader() {Shelf_table0, Shelf_table1, Shelf_table2, Shelf_table3, Shelf_table4, Shelf_table5, Shelf_table6, Shelf_table7})
        Lv_shelf.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lv_shelf.FullRowSelect = True
        Lv_shelf.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lv_shelf.Location = New Point(33, 88)
        Lv_shelf.Name = "Lv_shelf"
        Lv_shelf.Size = New Size(1546, 874)
        Lv_shelf.TabIndex = 6
        Lv_shelf.UseCompatibleStateImageBehavior = False
        Lv_shelf.View = View.Details
        ' 
        ' Shelf_table0
        ' 
        Shelf_table0.Text = "Shelf ID"
        Shelf_table0.Width = 200
        ' 
        ' Shelf_table1
        ' 
        Shelf_table1.Text = "Shelf Name"
        Shelf_table1.Width = 200
        ' 
        ' Shelf_table2
        ' 
        Shelf_table2.Text = "Section"
        Shelf_table2.TextAlign = HorizontalAlignment.Center
        Shelf_table2.Width = 250
        ' 
        ' Shelf_table3
        ' 
        Shelf_table3.Text = "Floor Number"
        Shelf_table3.TextAlign = HorizontalAlignment.Center
        Shelf_table3.Width = 210
        ' 
        ' Shelf_table4
        ' 
        Shelf_table4.Text = "Capacity"
        Shelf_table4.TextAlign = HorizontalAlignment.Center
        Shelf_table4.Width = 130
        ' 
        ' Shelf_table5
        ' 
        Shelf_table5.Text = "Current Load"
        Shelf_table5.TextAlign = HorizontalAlignment.Center
        Shelf_table5.Width = 200
        ' 
        ' Shelf_table6
        ' 
        Shelf_table6.Text = "Created At"
        Shelf_table6.TextAlign = HorizontalAlignment.Center
        Shelf_table6.Width = 200
        ' 
        ' Shelf_table7
        ' 
        Shelf_table7.Text = "Updated At"
        Shelf_table7.TextAlign = HorizontalAlignment.Center
        Shelf_table7.Width = 200
        ' 
        ' Panel4_User_Acounts
        ' 
        Panel4_User_Acounts.BackgroundImageLayout = ImageLayout.Stretch
        Panel4_User_Acounts.Controls.Add(Btn_listed_accounts_edit)
        Panel4_User_Acounts.Controls.Add(Lv_listed_accounts)
        Panel4_User_Acounts.Controls.Add(Btn_listed_accounts_delete)
        Panel4_User_Acounts.Controls.Add(Btn_listed_accounts_add)
        Panel4_User_Acounts.Controls.Add(Txt_listed_accounts_search)
        Panel4_User_Acounts.Location = New Point(300, 28)
        Panel4_User_Acounts.Name = "Panel4_User_Acounts"
        Panel4_User_Acounts.Size = New Size(1603, 973)
        Panel4_User_Acounts.TabIndex = 16
        ' 
        ' Btn_listed_accounts_edit
        ' 
        Btn_listed_accounts_edit.BackColor = Color.Tan
        Btn_listed_accounts_edit.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_listed_accounts_edit.Location = New Point(1318, 36)
        Btn_listed_accounts_edit.Name = "Btn_listed_accounts_edit"
        Btn_listed_accounts_edit.Size = New Size(118, 30)
        Btn_listed_accounts_edit.TabIndex = 16
        Btn_listed_accounts_edit.Text = "&Edit"
        Btn_listed_accounts_edit.UseVisualStyleBackColor = False
        ' 
        ' Lv_listed_accounts
        ' 
        Lv_listed_accounts.BackColor = SystemColors.ActiveCaption
        Lv_listed_accounts.Columns.AddRange(New ColumnHeader() {Listed_accounts0, Listed_accounts1, Listed_accounts2, Listed_accounts3, Listed_accounts4, Listed_accounts5, Listed_accounts6, Listed_accounts7, Listed_accounts8, Listed_accounts9})
        Lv_listed_accounts.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lv_listed_accounts.ForeColor = SystemColors.WindowText
        Lv_listed_accounts.FullRowSelect = True
        Lv_listed_accounts.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lv_listed_accounts.Location = New Point(16, 79)
        Lv_listed_accounts.Name = "Lv_listed_accounts"
        Lv_listed_accounts.Size = New Size(1564, 874)
        Lv_listed_accounts.TabIndex = 12
        Lv_listed_accounts.UseCompatibleStateImageBehavior = False
        Lv_listed_accounts.View = View.Details
        ' 
        ' Listed_accounts0
        ' 
        Listed_accounts0.Text = "First Name"
        Listed_accounts0.Width = 150
        ' 
        ' Listed_accounts1
        ' 
        Listed_accounts1.Text = "Middle Name"
        Listed_accounts1.Width = 150
        ' 
        ' Listed_accounts2
        ' 
        Listed_accounts2.Text = "Last Name"
        Listed_accounts2.Width = 150
        ' 
        ' Listed_accounts3
        ' 
        Listed_accounts3.Text = "Gender"
        Listed_accounts3.TextAlign = HorizontalAlignment.Center
        Listed_accounts3.Width = 100
        ' 
        ' Listed_accounts4
        ' 
        Listed_accounts4.Text = "Birthdate"
        Listed_accounts4.TextAlign = HorizontalAlignment.Center
        Listed_accounts4.Width = 120
        ' 
        ' Listed_accounts5
        ' 
        Listed_accounts5.Text = "Contact No."
        Listed_accounts5.TextAlign = HorizontalAlignment.Center
        Listed_accounts5.Width = 140
        ' 
        ' Listed_accounts6
        ' 
        Listed_accounts6.Text = "Address"
        Listed_accounts6.Width = 210
        ' 
        ' Listed_accounts7
        ' 
        Listed_accounts7.Text = "Username"
        Listed_accounts7.Width = 160
        ' 
        ' Listed_accounts8
        ' 
        Listed_accounts8.Text = "Email"
        Listed_accounts8.Width = 180
        ' 
        ' Listed_accounts9
        ' 
        Listed_accounts9.Text = "User Type"
        Listed_accounts9.TextAlign = HorizontalAlignment.Center
        Listed_accounts9.Width = 200
        ' 
        ' Btn_listed_accounts_delete
        ' 
        Btn_listed_accounts_delete.BackColor = Color.Tan
        Btn_listed_accounts_delete.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_listed_accounts_delete.Location = New Point(1462, 36)
        Btn_listed_accounts_delete.Name = "Btn_listed_accounts_delete"
        Btn_listed_accounts_delete.Size = New Size(118, 30)
        Btn_listed_accounts_delete.TabIndex = 15
        Btn_listed_accounts_delete.Text = "&Delete"
        Btn_listed_accounts_delete.UseVisualStyleBackColor = False
        ' 
        ' Btn_listed_accounts_add
        ' 
        Btn_listed_accounts_add.BackColor = Color.Tan
        Btn_listed_accounts_add.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_listed_accounts_add.Location = New Point(1176, 36)
        Btn_listed_accounts_add.Name = "Btn_listed_accounts_add"
        Btn_listed_accounts_add.Size = New Size(118, 30)
        Btn_listed_accounts_add.TabIndex = 14
        Btn_listed_accounts_add.Text = "&Add"
        Btn_listed_accounts_add.UseVisualStyleBackColor = False
        ' 
        ' Txt_listed_accounts_search
        ' 
        Txt_listed_accounts_search.Font = New Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_listed_accounts_search.Location = New Point(16, 28)
        Txt_listed_accounts_search.Name = "Txt_listed_accounts_search"
        Txt_listed_accounts_search.PlaceholderText = "Search"
        Txt_listed_accounts_search.Size = New Size(246, 38)
        Txt_listed_accounts_search.TabIndex = 13
        ' 
        ' Btn_logout
        ' 
        Btn_logout.BackColor = Color.Sienna
        Btn_logout.Font = New Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_logout.ForeColor = SystemColors.ControlLight
        Btn_logout.Location = New Point(4, 936)
        Btn_logout.Name = "Btn_logout"
        Btn_logout.Size = New Size(269, 54)
        Btn_logout.TabIndex = 17
        Btn_logout.Text = "&Logout"
        Btn_logout.UseVisualStyleBackColor = False
        ' 
        ' Btn_listed_books
        ' 
        Btn_listed_books.BackColor = Color.Sienna
        Btn_listed_books.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_listed_books.ForeColor = SystemColors.ControlLight
        Btn_listed_books.Location = New Point(5, 28)
        Btn_listed_books.Name = "Btn_listed_books"
        Btn_listed_books.Size = New Size(260, 30)
        Btn_listed_books.TabIndex = 18
        Btn_listed_books.Text = "Books"
        Btn_listed_books.UseVisualStyleBackColor = False
        ' 
        ' Btn_returned_books
        ' 
        Btn_returned_books.BackColor = Color.Sienna
        Btn_returned_books.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_returned_books.ForeColor = SystemColors.ControlLight
        Btn_returned_books.Location = New Point(5, 28)
        Btn_returned_books.Name = "Btn_returned_books"
        Btn_returned_books.Size = New Size(260, 30)
        Btn_returned_books.TabIndex = 19
        Btn_returned_books.Text = "Borrow and Return"
        Btn_returned_books.UseVisualStyleBackColor = False
        ' 
        ' Btn_student_information
        ' 
        Btn_student_information.BackColor = Color.Sienna
        Btn_student_information.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_student_information.ForeColor = SystemColors.ControlLightLight
        Btn_student_information.Location = New Point(5, 64)
        Btn_student_information.Name = "Btn_student_information"
        Btn_student_information.Size = New Size(260, 30)
        Btn_student_information.TabIndex = 20
        Btn_student_information.Text = "Borrower"
        Btn_student_information.UseVisualStyleBackColor = False
        ' 
        ' Btn_listed_accounts
        ' 
        Btn_listed_accounts.BackColor = Color.Sienna
        Btn_listed_accounts.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_listed_accounts.ForeColor = SystemColors.ControlLight
        Btn_listed_accounts.Location = New Point(5, 28)
        Btn_listed_accounts.Name = "Btn_listed_accounts"
        Btn_listed_accounts.Size = New Size(260, 30)
        Btn_listed_accounts.TabIndex = 21
        Btn_listed_accounts.Text = "Manage User"
        Btn_listed_accounts.UseVisualStyleBackColor = False
        ' 
        ' Tmr_home_page_date_time
        ' 
        Tmr_home_page_date_time.Enabled = True
        Tmr_home_page_date_time.Interval = 1000
        ' 
        ' P_navigation
        ' 
        P_navigation.BackColor = Color.LightGray
        P_navigation.Controls.Add(GroupBox4)
        P_navigation.Controls.Add(GroupBox3)
        P_navigation.Controls.Add(GroupBox2)
        P_navigation.Controls.Add(GroupBox1)
        P_navigation.Controls.Add(Lbl_user_type_logged_in)
        P_navigation.Controls.Add(Lbl_name_logged_in)
        P_navigation.Controls.Add(PictureBox1)
        P_navigation.Controls.Add(Btn_logout)
        P_navigation.Location = New Point(0, 0)
        P_navigation.Name = "P_navigation"
        P_navigation.Size = New Size(285, 1004)
        P_navigation.TabIndex = 23
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Btn_listed_accounts)
        GroupBox4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(8, 771)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(269, 72)
        GroupBox4.TabIndex = 36
        GroupBox4.TabStop = False
        GroupBox4.Text = "User Maintenance"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Btn_book_inventory)
        GroupBox3.Controls.Add(Btn_shelf)
        GroupBox3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(8, 520)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(269, 100)
        GroupBox3.TabIndex = 35
        GroupBox3.TabStop = False
        GroupBox3.Text = "Inventory Maintenance"
        ' 
        ' Btn_book_inventory
        ' 
        Btn_book_inventory.BackColor = Color.Sienna
        Btn_book_inventory.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_book_inventory.ForeColor = SystemColors.ControlLight
        Btn_book_inventory.Location = New Point(5, 64)
        Btn_book_inventory.Name = "Btn_book_inventory"
        Btn_book_inventory.Size = New Size(260, 30)
        Btn_book_inventory.TabIndex = 24
        Btn_book_inventory.Text = "Book Inventory"
        Btn_book_inventory.UseVisualStyleBackColor = False
        ' 
        ' Btn_shelf
        ' 
        Btn_shelf.BackColor = Color.Sienna
        Btn_shelf.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_shelf.ForeColor = SystemColors.ControlLight
        Btn_shelf.Location = New Point(5, 28)
        Btn_shelf.Name = "Btn_shelf"
        Btn_shelf.Size = New Size(260, 30)
        Btn_shelf.TabIndex = 37
        Btn_shelf.Text = "Shelf Maintenance"
        Btn_shelf.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Btn_delivery)
        GroupBox2.Controls.Add(Btn_returned_books)
        GroupBox2.Controls.Add(Btn_penalty_report)
        GroupBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(8, 626)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(269, 139)
        GroupBox2.TabIndex = 34
        GroupBox2.TabStop = False
        GroupBox2.Text = "Transaction"
        ' 
        ' Btn_delivery
        ' 
        Btn_delivery.BackColor = Color.Sienna
        Btn_delivery.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_delivery.ForeColor = SystemColors.ControlLight
        Btn_delivery.Location = New Point(5, 100)
        Btn_delivery.Name = "Btn_delivery"
        Btn_delivery.Size = New Size(260, 30)
        Btn_delivery.TabIndex = 36
        Btn_delivery.Text = "Delivery Maintenance"
        Btn_delivery.UseVisualStyleBackColor = False
        ' 
        ' Btn_penalty_report
        ' 
        Btn_penalty_report.BackColor = Color.Sienna
        Btn_penalty_report.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_penalty_report.ForeColor = SystemColors.ControlLight
        Btn_penalty_report.Location = New Point(5, 64)
        Btn_penalty_report.Name = "Btn_penalty_report"
        Btn_penalty_report.Size = New Size(260, 30)
        Btn_penalty_report.TabIndex = 28
        Btn_penalty_report.Text = "Penalty"
        Btn_penalty_report.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Btn_supplier_maintenance)
        GroupBox1.Controls.Add(Btn_listed_books)
        GroupBox1.Controls.Add(Btn_author_category_penalty_publisher_maintenance)
        GroupBox1.Controls.Add(Btn_student_information)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(8, 310)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(269, 204)
        GroupBox1.TabIndex = 33
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Management"
        ' 
        ' Btn_supplier_maintenance
        ' 
        Btn_supplier_maintenance.BackColor = Color.Sienna
        Btn_supplier_maintenance.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_supplier_maintenance.ForeColor = SystemColors.ControlLight
        Btn_supplier_maintenance.Location = New Point(5, 100)
        Btn_supplier_maintenance.Name = "Btn_supplier_maintenance"
        Btn_supplier_maintenance.Size = New Size(260, 30)
        Btn_supplier_maintenance.TabIndex = 23
        Btn_supplier_maintenance.Text = "Supplier Maintenance"
        Btn_supplier_maintenance.UseVisualStyleBackColor = False
        ' 
        ' Btn_author_category_penalty_publisher_maintenance
        ' 
        Btn_author_category_penalty_publisher_maintenance.BackColor = Color.Sienna
        Btn_author_category_penalty_publisher_maintenance.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_author_category_penalty_publisher_maintenance.ForeColor = SystemColors.ControlLight
        Btn_author_category_penalty_publisher_maintenance.Location = New Point(5, 136)
        Btn_author_category_penalty_publisher_maintenance.Name = "Btn_author_category_penalty_publisher_maintenance"
        Btn_author_category_penalty_publisher_maintenance.Size = New Size(260, 55)
        Btn_author_category_penalty_publisher_maintenance.TabIndex = 22
        Btn_author_category_penalty_publisher_maintenance.Text = "Author / Genre / Penalty / Publisher Maintenance"
        Btn_author_category_penalty_publisher_maintenance.UseVisualStyleBackColor = False
        ' 
        ' Lbl_user_type_logged_in
        ' 
        Lbl_user_type_logged_in.AutoSize = True
        Lbl_user_type_logged_in.Location = New Point(8, 283)
        Lbl_user_type_logged_in.Name = "Lbl_user_type_logged_in"
        Lbl_user_type_logged_in.Size = New Size(57, 15)
        Lbl_user_type_logged_in.TabIndex = 32
        Lbl_user_type_logged_in.Text = "User Type"
        ' 
        ' Lbl_name_logged_in
        ' 
        Lbl_name_logged_in.AutoSize = True
        Lbl_name_logged_in.Location = New Point(8, 261)
        Lbl_name_logged_in.Name = "Lbl_name_logged_in"
        Lbl_name_logged_in.Size = New Size(95, 15)
        Lbl_name_logged_in.TabIndex = 15
        Lbl_name_logged_in.Text = "Name Logged In"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(30, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(226, 226)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' Panel8_Penalty_Report
        ' 
        Panel8_Penalty_Report.Controls.Add(Txt_search_penalty_report)
        Panel8_Penalty_Report.Controls.Add(Btn_penalty_report_delete)
        Panel8_Penalty_Report.Controls.Add(Btn_penalty_report_edit)
        Panel8_Penalty_Report.Controls.Add(Lv_penalty)
        Panel8_Penalty_Report.Location = New Point(379, 56)
        Panel8_Penalty_Report.Name = "Panel8_Penalty_Report"
        Panel8_Penalty_Report.Size = New Size(1421, 901)
        Panel8_Penalty_Report.TabIndex = 28
        ' 
        ' Txt_search_penalty_report
        ' 
        Txt_search_penalty_report.Font = New Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_search_penalty_report.Location = New Point(23, 38)
        Txt_search_penalty_report.Name = "Txt_search_penalty_report"
        Txt_search_penalty_report.PlaceholderText = "Search"
        Txt_search_penalty_report.Size = New Size(246, 38)
        Txt_search_penalty_report.TabIndex = 27
        ' 
        ' Btn_penalty_report_delete
        ' 
        Btn_penalty_report_delete.BackColor = Color.Tan
        Btn_penalty_report_delete.Font = New Font("Georgia", 9F)
        Btn_penalty_report_delete.Location = New Point(1279, 46)
        Btn_penalty_report_delete.Name = "Btn_penalty_report_delete"
        Btn_penalty_report_delete.Size = New Size(118, 30)
        Btn_penalty_report_delete.TabIndex = 10
        Btn_penalty_report_delete.Text = "&Delete"
        Btn_penalty_report_delete.UseVisualStyleBackColor = False
        ' 
        ' Btn_penalty_report_edit
        ' 
        Btn_penalty_report_edit.BackColor = Color.Tan
        Btn_penalty_report_edit.Font = New Font("Georgia", 9F)
        Btn_penalty_report_edit.Location = New Point(1137, 46)
        Btn_penalty_report_edit.Name = "Btn_penalty_report_edit"
        Btn_penalty_report_edit.Size = New Size(118, 30)
        Btn_penalty_report_edit.TabIndex = 9
        Btn_penalty_report_edit.Text = "&Edit"
        Btn_penalty_report_edit.UseVisualStyleBackColor = False
        ' 
        ' Lv_penalty
        ' 
        Lv_penalty.Columns.AddRange(New ColumnHeader() {Listed_penalty0, Listed_penalty1, Listed_penalty2, Listed_penalty3, Listed_penalty4, Listed_penalty5})
        Lv_penalty.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lv_penalty.FullRowSelect = True
        Lv_penalty.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lv_penalty.Location = New Point(23, 99)
        Lv_penalty.Name = "Lv_penalty"
        Lv_penalty.Size = New Size(1374, 779)
        Lv_penalty.TabIndex = 0
        Lv_penalty.UseCompatibleStateImageBehavior = False
        Lv_penalty.View = View.Details
        ' 
        ' Listed_penalty0
        ' 
        Listed_penalty0.Text = "ID Number"
        Listed_penalty0.Width = 150
        ' 
        ' Listed_penalty1
        ' 
        Listed_penalty1.Text = "Name"
        Listed_penalty1.Width = 230
        ' 
        ' Listed_penalty2
        ' 
        Listed_penalty2.Text = "Book Name"
        Listed_penalty2.Width = 250
        ' 
        ' Listed_penalty3
        ' 
        Listed_penalty3.Text = "Penalty Description"
        Listed_penalty3.Width = 260
        ' 
        ' Listed_penalty4
        ' 
        Listed_penalty4.Text = "Penalty Amount"
        Listed_penalty4.TextAlign = HorizontalAlignment.Center
        Listed_penalty4.Width = 210
        ' 
        ' Listed_penalty5
        ' 
        Listed_penalty5.Text = "Date"
        Listed_penalty5.TextAlign = HorizontalAlignment.Center
        Listed_penalty5.Width = 250
        ' 
        ' Panel10_Author_Category_Penalty_Publisher
        ' 
        Panel10_Author_Category_Penalty_Publisher.Controls.Add(Panel11_Publisher)
        Panel10_Author_Category_Penalty_Publisher.Controls.Add(Panel5_Author)
        Panel10_Author_Category_Penalty_Publisher.Controls.Add(Panel9_Penalty)
        Panel10_Author_Category_Penalty_Publisher.Controls.Add(Panel7_Category)
        Panel10_Author_Category_Penalty_Publisher.Location = New Point(300, 28)
        Panel10_Author_Category_Penalty_Publisher.Name = "Panel10_Author_Category_Penalty_Publisher"
        Panel10_Author_Category_Penalty_Publisher.Size = New Size(1603, 973)
        Panel10_Author_Category_Penalty_Publisher.TabIndex = 29
        ' 
        ' Panel11_Publisher
        ' 
        Panel11_Publisher.BorderStyle = BorderStyle.FixedSingle
        Panel11_Publisher.Controls.Add(Btn_publisher_delete)
        Panel11_Publisher.Controls.Add(Btn_publisher_edit)
        Panel11_Publisher.Controls.Add(Txt_search_publisher)
        Panel11_Publisher.Controls.Add(Btn_publisher_add)
        Panel11_Publisher.Controls.Add(Lv_publisher)
        Panel11_Publisher.Location = New Point(815, 493)
        Panel11_Publisher.Name = "Panel11_Publisher"
        Panel11_Publisher.Size = New Size(771, 456)
        Panel11_Publisher.TabIndex = 31
        Panel11_Publisher.Tag = ""
        ' 
        ' Btn_publisher_delete
        ' 
        Btn_publisher_delete.BackColor = Color.Tan
        Btn_publisher_delete.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_publisher_delete.Location = New Point(634, 23)
        Btn_publisher_delete.Name = "Btn_publisher_delete"
        Btn_publisher_delete.Size = New Size(104, 31)
        Btn_publisher_delete.TabIndex = 49
        Btn_publisher_delete.Text = "Delete"
        Btn_publisher_delete.UseVisualStyleBackColor = False
        ' 
        ' Btn_publisher_edit
        ' 
        Btn_publisher_edit.BackColor = Color.Tan
        Btn_publisher_edit.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_publisher_edit.Location = New Point(503, 23)
        Btn_publisher_edit.Name = "Btn_publisher_edit"
        Btn_publisher_edit.Size = New Size(104, 31)
        Btn_publisher_edit.TabIndex = 48
        Btn_publisher_edit.Text = "Edit"
        Btn_publisher_edit.UseVisualStyleBackColor = False
        ' 
        ' Txt_search_publisher
        ' 
        Txt_search_publisher.Font = New Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_search_publisher.Location = New Point(16, 22)
        Txt_search_publisher.Name = "Txt_search_publisher"
        Txt_search_publisher.PlaceholderText = "Search"
        Txt_search_publisher.Size = New Size(256, 29)
        Txt_search_publisher.TabIndex = 47
        ' 
        ' Btn_publisher_add
        ' 
        Btn_publisher_add.BackColor = Color.Tan
        Btn_publisher_add.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_publisher_add.Location = New Point(373, 23)
        Btn_publisher_add.Name = "Btn_publisher_add"
        Btn_publisher_add.Size = New Size(104, 31)
        Btn_publisher_add.TabIndex = 46
        Btn_publisher_add.Text = "Add"
        Btn_publisher_add.UseVisualStyleBackColor = False
        ' 
        ' Lv_publisher
        ' 
        Lv_publisher.Columns.AddRange(New ColumnHeader() {ColumnHeader1})
        Lv_publisher.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lv_publisher.FullRowSelect = True
        Lv_publisher.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lv_publisher.Location = New Point(16, 77)
        Lv_publisher.Name = "Lv_publisher"
        Lv_publisher.Size = New Size(722, 361)
        Lv_publisher.TabIndex = 45
        Lv_publisher.UseCompatibleStateImageBehavior = False
        Lv_publisher.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Publisher Name"
        ColumnHeader1.Width = 718
        ' 
        ' Panel5_Author
        ' 
        Panel5_Author.BorderStyle = BorderStyle.FixedSingle
        Panel5_Author.Controls.Add(Txt_search_author)
        Panel5_Author.Controls.Add(Btn_author_delete)
        Panel5_Author.Controls.Add(Lv_author)
        Panel5_Author.Controls.Add(Btn_author_add)
        Panel5_Author.Controls.Add(Btn_author_edit)
        Panel5_Author.Location = New Point(25, 17)
        Panel5_Author.Name = "Panel5_Author"
        Panel5_Author.Size = New Size(771, 456)
        Panel5_Author.TabIndex = 26
        ' 
        ' Txt_search_author
        ' 
        Txt_search_author.Font = New Font("Georgia", 14.25F)
        Txt_search_author.Location = New Point(16, 22)
        Txt_search_author.Name = "Txt_search_author"
        Txt_search_author.PlaceholderText = "Search"
        Txt_search_author.RightToLeft = RightToLeft.No
        Txt_search_author.Size = New Size(256, 29)
        Txt_search_author.TabIndex = 2
        ' 
        ' Btn_author_delete
        ' 
        Btn_author_delete.BackColor = Color.Tan
        Btn_author_delete.Font = New Font("Georgia", 12F)
        Btn_author_delete.Location = New Point(634, 22)
        Btn_author_delete.Name = "Btn_author_delete"
        Btn_author_delete.Size = New Size(104, 31)
        Btn_author_delete.TabIndex = 5
        Btn_author_delete.Text = "Delete"
        Btn_author_delete.UseVisualStyleBackColor = False
        ' 
        ' Lv_author
        ' 
        Lv_author.BackColor = SystemColors.Window
        Lv_author.Columns.AddRange(New ColumnHeader() {ColumnHeader})
        Lv_author.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lv_author.FullRowSelect = True
        Lv_author.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lv_author.Location = New Point(16, 77)
        Lv_author.Name = "Lv_author"
        Lv_author.RightToLeft = RightToLeft.No
        Lv_author.Size = New Size(722, 361)
        Lv_author.TabIndex = 0
        Lv_author.UseCompatibleStateImageBehavior = False
        Lv_author.View = View.Details
        ' 
        ' ColumnHeader
        ' 
        ColumnHeader.Text = "Author Name"
        ColumnHeader.Width = 718
        ' 
        ' Btn_author_add
        ' 
        Btn_author_add.BackColor = Color.Tan
        Btn_author_add.Font = New Font("Georgia", 12F)
        Btn_author_add.Location = New Point(373, 22)
        Btn_author_add.Name = "Btn_author_add"
        Btn_author_add.Size = New Size(104, 31)
        Btn_author_add.TabIndex = 3
        Btn_author_add.Text = "Add"
        Btn_author_add.UseVisualStyleBackColor = False
        ' 
        ' Btn_author_edit
        ' 
        Btn_author_edit.BackColor = Color.Tan
        Btn_author_edit.Font = New Font("Georgia", 12F)
        Btn_author_edit.Location = New Point(503, 22)
        Btn_author_edit.Name = "Btn_author_edit"
        Btn_author_edit.Size = New Size(104, 31)
        Btn_author_edit.TabIndex = 4
        Btn_author_edit.Text = "Edit"
        Btn_author_edit.UseVisualStyleBackColor = False
        ' 
        ' Panel9_Penalty
        ' 
        Panel9_Penalty.BorderStyle = BorderStyle.FixedSingle
        Panel9_Penalty.Controls.Add(Btn_penalty_description_delete)
        Panel9_Penalty.Controls.Add(Btn_penalty_description_edit)
        Panel9_Penalty.Controls.Add(Txt_search_penalty_description)
        Panel9_Penalty.Controls.Add(Btn_penalty_description_add)
        Panel9_Penalty.Controls.Add(Lv_penalty_description)
        Panel9_Penalty.Location = New Point(25, 493)
        Panel9_Penalty.Name = "Panel9_Penalty"
        Panel9_Penalty.Size = New Size(771, 456)
        Panel9_Penalty.TabIndex = 30
        Panel9_Penalty.Tag = ""
        ' 
        ' Btn_penalty_description_delete
        ' 
        Btn_penalty_description_delete.BackColor = Color.Tan
        Btn_penalty_description_delete.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_penalty_description_delete.Location = New Point(634, 23)
        Btn_penalty_description_delete.Name = "Btn_penalty_description_delete"
        Btn_penalty_description_delete.Size = New Size(104, 31)
        Btn_penalty_description_delete.TabIndex = 49
        Btn_penalty_description_delete.Text = "Delete"
        Btn_penalty_description_delete.UseVisualStyleBackColor = False
        ' 
        ' Btn_penalty_description_edit
        ' 
        Btn_penalty_description_edit.BackColor = Color.Tan
        Btn_penalty_description_edit.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_penalty_description_edit.Location = New Point(503, 23)
        Btn_penalty_description_edit.Name = "Btn_penalty_description_edit"
        Btn_penalty_description_edit.Size = New Size(104, 31)
        Btn_penalty_description_edit.TabIndex = 48
        Btn_penalty_description_edit.Text = "Edit"
        Btn_penalty_description_edit.UseVisualStyleBackColor = False
        ' 
        ' Txt_search_penalty_description
        ' 
        Txt_search_penalty_description.Font = New Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_search_penalty_description.Location = New Point(16, 22)
        Txt_search_penalty_description.Name = "Txt_search_penalty_description"
        Txt_search_penalty_description.PlaceholderText = "Search"
        Txt_search_penalty_description.Size = New Size(256, 29)
        Txt_search_penalty_description.TabIndex = 47
        ' 
        ' Btn_penalty_description_add
        ' 
        Btn_penalty_description_add.BackColor = Color.Tan
        Btn_penalty_description_add.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_penalty_description_add.Location = New Point(373, 23)
        Btn_penalty_description_add.Name = "Btn_penalty_description_add"
        Btn_penalty_description_add.Size = New Size(104, 31)
        Btn_penalty_description_add.TabIndex = 46
        Btn_penalty_description_add.Text = "Add"
        Btn_penalty_description_add.UseVisualStyleBackColor = False
        ' 
        ' Lv_penalty_description
        ' 
        Lv_penalty_description.Columns.AddRange(New ColumnHeader() {Listed_details0, Listed_details1})
        Lv_penalty_description.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lv_penalty_description.FullRowSelect = True
        Lv_penalty_description.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lv_penalty_description.Location = New Point(16, 77)
        Lv_penalty_description.Name = "Lv_penalty_description"
        Lv_penalty_description.Size = New Size(722, 361)
        Lv_penalty_description.TabIndex = 45
        Lv_penalty_description.UseCompatibleStateImageBehavior = False
        Lv_penalty_description.View = View.Details
        ' 
        ' Listed_details0
        ' 
        Listed_details0.Text = "Penalty Description"
        Listed_details0.Width = 503
        ' 
        ' Listed_details1
        ' 
        Listed_details1.Text = "Amount"
        Listed_details1.TextAlign = HorizontalAlignment.Center
        Listed_details1.Width = 215
        ' 
        ' Panel7_Category
        ' 
        Panel7_Category.BorderStyle = BorderStyle.FixedSingle
        Panel7_Category.Controls.Add(Txt_search_category)
        Panel7_Category.Controls.Add(Btn_category_delete)
        Panel7_Category.Controls.Add(Btn_category_edit)
        Panel7_Category.Controls.Add(Btn_category_add)
        Panel7_Category.Controls.Add(Lv_category)
        Panel7_Category.Location = New Point(815, 17)
        Panel7_Category.Name = "Panel7_Category"
        Panel7_Category.Size = New Size(771, 456)
        Panel7_Category.TabIndex = 28
        ' 
        ' Txt_search_category
        ' 
        Txt_search_category.Font = New Font("Georgia", 14.25F)
        Txt_search_category.Location = New Point(16, 22)
        Txt_search_category.Name = "Txt_search_category"
        Txt_search_category.PlaceholderText = "Search"
        Txt_search_category.Size = New Size(256, 29)
        Txt_search_category.TabIndex = 6
        ' 
        ' Btn_category_delete
        ' 
        Btn_category_delete.BackColor = Color.Tan
        Btn_category_delete.Font = New Font("Georgia", 12F)
        Btn_category_delete.Location = New Point(634, 23)
        Btn_category_delete.Name = "Btn_category_delete"
        Btn_category_delete.Size = New Size(104, 31)
        Btn_category_delete.TabIndex = 5
        Btn_category_delete.Text = "Delete"
        Btn_category_delete.UseVisualStyleBackColor = False
        ' 
        ' Btn_category_edit
        ' 
        Btn_category_edit.BackColor = Color.Tan
        Btn_category_edit.Font = New Font("Georgia", 12F)
        Btn_category_edit.Location = New Point(503, 23)
        Btn_category_edit.Name = "Btn_category_edit"
        Btn_category_edit.Size = New Size(104, 31)
        Btn_category_edit.TabIndex = 4
        Btn_category_edit.Text = "Edit"
        Btn_category_edit.UseVisualStyleBackColor = False
        ' 
        ' Btn_category_add
        ' 
        Btn_category_add.BackColor = Color.Tan
        Btn_category_add.Font = New Font("Georgia", 12F)
        Btn_category_add.Location = New Point(373, 23)
        Btn_category_add.Name = "Btn_category_add"
        Btn_category_add.Size = New Size(104, 31)
        Btn_category_add.TabIndex = 3
        Btn_category_add.Text = "Add"
        Btn_category_add.UseVisualStyleBackColor = False
        ' 
        ' Lv_category
        ' 
        Lv_category.Columns.AddRange(New ColumnHeader() {Listed_Category0})
        Lv_category.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lv_category.FullRowSelect = True
        Lv_category.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lv_category.Location = New Point(16, 77)
        Lv_category.Name = "Lv_category"
        Lv_category.Size = New Size(722, 361)
        Lv_category.TabIndex = 0
        Lv_category.UseCompatibleStateImageBehavior = False
        Lv_category.View = View.Details
        ' 
        ' Listed_Category0
        ' 
        Listed_Category0.Text = "Genre"
        Listed_Category0.Width = 718
        ' 
        ' Lbl_date_time
        ' 
        Lbl_date_time.AutoSize = True
        Lbl_date_time.Font = New Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_date_time.Location = New Point(1657, 3)
        Lbl_date_time.Name = "Lbl_date_time"
        Lbl_date_time.Size = New Size(243, 24)
        Lbl_date_time.TabIndex = 30
        Lbl_date_time.Text = "December 31, 2025 | 12:59 PM"
        Lbl_date_time.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Panel13_Delivery
        ' 
        Panel13_Delivery.BackgroundImageLayout = ImageLayout.Stretch
        Panel13_Delivery.Controls.Add(Btn_delivery_edit)
        Panel13_Delivery.Controls.Add(Txt_delivery_search)
        Panel13_Delivery.Controls.Add(Btn_delivery_delete)
        Panel13_Delivery.Controls.Add(Btn_delivery_add)
        Panel13_Delivery.Controls.Add(Lv_delivery)
        Panel13_Delivery.Location = New Point(300, 28)
        Panel13_Delivery.Name = "Panel13_Delivery"
        Panel13_Delivery.Size = New Size(1603, 970)
        Panel13_Delivery.TabIndex = 17
        ' 
        ' Btn_delivery_edit
        ' 
        Btn_delivery_edit.BackColor = Color.Tan
        Btn_delivery_edit.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_delivery_edit.Location = New Point(1336, 32)
        Btn_delivery_edit.Name = "Btn_delivery_edit"
        Btn_delivery_edit.Size = New Size(118, 30)
        Btn_delivery_edit.TabIndex = 13
        Btn_delivery_edit.Text = "&Edit"
        Btn_delivery_edit.UseVisualStyleBackColor = False
        ' 
        ' Txt_delivery_search
        ' 
        Txt_delivery_search.Font = New Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_delivery_search.Location = New Point(33, 24)
        Txt_delivery_search.Name = "Txt_delivery_search"
        Txt_delivery_search.PlaceholderText = "Search"
        Txt_delivery_search.Size = New Size(246, 38)
        Txt_delivery_search.TabIndex = 12
        ' 
        ' Btn_delivery_delete
        ' 
        Btn_delivery_delete.BackColor = Color.Tan
        Btn_delivery_delete.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_delivery_delete.Location = New Point(1461, 32)
        Btn_delivery_delete.Name = "Btn_delivery_delete"
        Btn_delivery_delete.Size = New Size(118, 30)
        Btn_delivery_delete.TabIndex = 10
        Btn_delivery_delete.Text = "&Delete"
        Btn_delivery_delete.UseVisualStyleBackColor = False
        ' 
        ' Btn_delivery_add
        ' 
        Btn_delivery_add.BackColor = Color.Tan
        Btn_delivery_add.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_delivery_add.Location = New Point(1209, 32)
        Btn_delivery_add.Name = "Btn_delivery_add"
        Btn_delivery_add.Size = New Size(118, 30)
        Btn_delivery_add.TabIndex = 9
        Btn_delivery_add.Text = "&Add"
        Btn_delivery_add.UseVisualStyleBackColor = False
        ' 
        ' Lv_delivery
        ' 
        Lv_delivery.BackColor = SystemColors.ActiveCaption
        Lv_delivery.Columns.AddRange(New ColumnHeader() {Delivery_table0, Delivery_table1, Delivery_table2, Delivery_table3, Delivery_table4, Delivery_table5, Delivery_table6, Delivery_table7, Delivery_table8, Delivery_table9})
        Lv_delivery.Font = New Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lv_delivery.FullRowSelect = True
        Lv_delivery.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lv_delivery.Location = New Point(33, 88)
        Lv_delivery.Name = "Lv_delivery"
        Lv_delivery.Size = New Size(1546, 874)
        Lv_delivery.TabIndex = 6
        Lv_delivery.UseCompatibleStateImageBehavior = False
        Lv_delivery.View = View.Details
        ' 
        ' Delivery_table0
        ' 
        Delivery_table0.Text = "Transaction Number"
        Delivery_table0.Width = 250
        ' 
        ' Delivery_table1
        ' 
        Delivery_table1.Text = "ISBN"
        Delivery_table1.TextAlign = HorizontalAlignment.Center
        Delivery_table1.Width = 300
        ' 
        ' Delivery_table2
        ' 
        Delivery_table2.Text = "Book Name"
        Delivery_table2.TextAlign = HorizontalAlignment.Center
        Delivery_table2.Width = 300
        ' 
        ' Delivery_table3
        ' 
        Delivery_table3.Text = "Quantity"
        Delivery_table3.TextAlign = HorizontalAlignment.Center
        Delivery_table3.Width = 100
        ' 
        ' Delivery_table4
        ' 
        Delivery_table4.Text = "From Location"
        Delivery_table4.TextAlign = HorizontalAlignment.Center
        Delivery_table4.Width = 300
        ' 
        ' Delivery_table5
        ' 
        Delivery_table5.Text = "To Location"
        Delivery_table5.TextAlign = HorizontalAlignment.Center
        Delivery_table5.Width = 300
        ' 
        ' Delivery_table6
        ' 
        Delivery_table6.Text = "Delivered By"
        Delivery_table6.TextAlign = HorizontalAlignment.Center
        Delivery_table6.Width = 300
        ' 
        ' Delivery_table7
        ' 
        Delivery_table7.Text = "Delivery Date"
        Delivery_table7.TextAlign = HorizontalAlignment.Center
        Delivery_table7.Width = 150
        ' 
        ' Delivery_table8
        ' 
        Delivery_table8.Text = "Status"
        Delivery_table8.TextAlign = HorizontalAlignment.Center
        Delivery_table8.Width = 200
        ' 
        ' Delivery_table9
        ' 
        Delivery_table9.Text = "Received By"
        Delivery_table9.TextAlign = HorizontalAlignment.Center
        Delivery_table9.Width = 120
        ' 
        ' Panel14_Book_Inventory
        ' 
        Panel14_Book_Inventory.BackgroundImageLayout = ImageLayout.Stretch
        Panel14_Book_Inventory.Controls.Add(ListView1)
        Panel14_Book_Inventory.Controls.Add(ComboBox1)
        Panel14_Book_Inventory.Controls.Add(Button1)
        Panel14_Book_Inventory.Controls.Add(Button2)
        Panel14_Book_Inventory.Controls.Add(Button4)
        Panel14_Book_Inventory.Controls.Add(TextBox1)
        Panel14_Book_Inventory.Location = New Point(300, 28)
        Panel14_Book_Inventory.Name = "Panel14_Book_Inventory"
        Panel14_Book_Inventory.Size = New Size(1603, 973)
        Panel14_Book_Inventory.TabIndex = 24
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = SystemColors.ActiveCaption
        ListView1.Columns.AddRange(New ColumnHeader() {Book_inventory0, Book_inventory1, Book_inventory2, Book_inventory3, Book_inventory4, Book_inventory5, Book_inventory6, Book_inventory7, Book_inventory8, Book_inventory9})
        ListView1.Font = New Font("Georgia", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView1.ForeColor = SystemColors.WindowText
        ListView1.FullRowSelect = True
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ListView1.Location = New Point(29, 74)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1546, 874)
        ListView1.TabIndex = 6
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Book_inventory0
        ' 
        Book_inventory0.Text = "ISBN"
        Book_inventory0.Width = 180
        ' 
        ' Book_inventory1
        ' 
        Book_inventory1.Text = "Title"
        Book_inventory1.TextAlign = HorizontalAlignment.Center
        Book_inventory1.Width = 300
        ' 
        ' Book_inventory2
        ' 
        Book_inventory2.Text = "Author"
        Book_inventory2.TextAlign = HorizontalAlignment.Center
        Book_inventory2.Width = 250
        ' 
        ' Book_inventory3
        ' 
        Book_inventory3.Text = "Genre"
        Book_inventory3.TextAlign = HorizontalAlignment.Center
        Book_inventory3.Width = 250
        ' 
        ' Book_inventory4
        ' 
        Book_inventory4.Text = "Publication Year"
        Book_inventory4.TextAlign = HorizontalAlignment.Center
        Book_inventory4.Width = 280
        ' 
        ' Book_inventory5
        ' 
        Book_inventory5.Text = "Publisher"
        Book_inventory5.TextAlign = HorizontalAlignment.Center
        Book_inventory5.Width = 280
        ' 
        ' Book_inventory6
        ' 
        Book_inventory6.Text = "Quantity"
        Book_inventory6.TextAlign = HorizontalAlignment.Center
        ' 
        ' Book_inventory7
        ' 
        Book_inventory7.Text = "Acquisition Date"
        Book_inventory7.TextAlign = HorizontalAlignment.Center
        ' 
        ' Book_inventory8
        ' 
        Book_inventory8.Text = "Supplier"
        Book_inventory8.TextAlign = HorizontalAlignment.Center
        ' 
        ' Book_inventory9
        ' 
        Book_inventory9.Text = "Status"
        Book_inventory9.TextAlign = HorizontalAlignment.Center
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.ForeColor = Color.Black
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Adventure fiction", "Biographies", "Books", "Chapter books", "Childrens literature", "Classics", "Comics", "Cooking", "Fantasy", "Fiction", "General fiction", "History", "Horror", "Humor", "Memoir", "Mystery", "Non-fiction", "Poetry", "Religion", "Romance", "Satire", "Science fiction", "Self-help book", "Thriller"})
        ComboBox1.Location = New Point(298, 26)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(273, 26)
        ComboBox1.TabIndex = 23
        ComboBox1.Text = "All Genre"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Tan
        Button1.Font = New Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1336, 29)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 30)
        Button1.TabIndex = 11
        Button1.Text = "&Edit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Tan
        Button2.Font = New Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(1460, 29)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 30)
        Button2.TabIndex = 10
        Button2.Text = "&Delete"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Tan
        Button4.Font = New Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(1212, 29)
        Button4.Name = "Button4"
        Button4.Size = New Size(118, 30)
        Button4.TabIndex = 9
        Button4.Text = "&Add"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(29, 18)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search"
        TextBox1.Size = New Size(246, 38)
        TextBox1.TabIndex = 7
        ' 
        ' Fm_home_page
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1904, 1003)
        ControlBox = False
        Controls.Add(Panel10_Author_Category_Penalty_Publisher)
        Controls.Add(Panel6_Supplier)
        Controls.Add(Panel4_User_Acounts)
        Controls.Add(Panel3_Borrower_Info)
        Controls.Add(Panel8_Penalty_Report)
        Controls.Add(Panel2_Returned_Issued_Books)
        Controls.Add(Panel1_Books)
        Controls.Add(Panel13_Delivery)
        Controls.Add(Panel14_Book_Inventory)
        Controls.Add(Panel12_Shelf)
        Controls.Add(Lbl_date_time)
        Controls.Add(P_navigation)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(1920, 1042)
        Name = "Fm_home_page"
        StartPosition = FormStartPosition.CenterScreen
        Tag = ""
        Text = "STS Library Management System"
        Panel1_Books.ResumeLayout(False)
        Panel1_Books.PerformLayout()
        Panel2_Returned_Issued_Books.ResumeLayout(False)
        Panel2_Returned_Issued_Books.PerformLayout()
        Panel6_Supplier.ResumeLayout(False)
        Panel6_Supplier.PerformLayout()
        Panel3_Borrower_Info.ResumeLayout(False)
        Panel3_Borrower_Info.PerformLayout()
        Panel12_Shelf.ResumeLayout(False)
        Panel12_Shelf.PerformLayout()
        Panel4_User_Acounts.ResumeLayout(False)
        Panel4_User_Acounts.PerformLayout()
        P_navigation.ResumeLayout(False)
        P_navigation.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel8_Penalty_Report.ResumeLayout(False)
        Panel8_Penalty_Report.PerformLayout()
        Panel10_Author_Category_Penalty_Publisher.ResumeLayout(False)
        Panel11_Publisher.ResumeLayout(False)
        Panel11_Publisher.PerformLayout()
        Panel5_Author.ResumeLayout(False)
        Panel5_Author.PerformLayout()
        Panel9_Penalty.ResumeLayout(False)
        Panel9_Penalty.PerformLayout()
        Panel7_Category.ResumeLayout(False)
        Panel7_Category.PerformLayout()
        Panel13_Delivery.ResumeLayout(False)
        Panel13_Delivery.PerformLayout()
        Panel14_Book_Inventory.ResumeLayout(False)
        Panel14_Book_Inventory.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1_Books As Panel
    Friend WithEvents Btn_listed_books_edit As Button
    Friend WithEvents Btn_listed_books_delete As Button
    Friend WithEvents Btn_listed_books_add As Button
    Friend WithEvents Txt_listed_books_search As TextBox
    Friend WithEvents Lv_listed_books As ListView
    Friend WithEvents Listed_books1 As ColumnHeader
    Friend WithEvents Listed_books4 As ColumnHeader
    Friend WithEvents Listed_books5 As ColumnHeader
    Friend WithEvents Panel2_Returned_Issued_Books As Panel
    Friend WithEvents Lv_returned_borrowed_books As ListView
    Friend WithEvents Returned_borrowed_books1 As ColumnHeader
    Friend WithEvents Returned_borrowed_books2 As ColumnHeader
    Friend WithEvents Returned_borrowed_books3 As ColumnHeader
    Friend WithEvents Returned_borrowed_books4 As ColumnHeader
    Friend WithEvents Returned_borrowed_books5 As ColumnHeader
    Friend WithEvents Returned_borrowed_books6 As ColumnHeader
    Friend WithEvents Panel3_Borrower_Info As Panel
    Friend WithEvents Btn_borrower_info_delete As Button
    Friend WithEvents Btn_borrower_info_add As Button
    Friend WithEvents Lv_borrower_info As ListView
    Friend WithEvents Student_info0 As ColumnHeader
    Friend WithEvents Student_info1 As ColumnHeader
    Friend WithEvents Student_info5 As ColumnHeader
    Friend WithEvents Student_info6 As ColumnHeader
    Friend WithEvents Student_info8 As ColumnHeader
    Friend WithEvents Panel4_User_Acounts As Panel
    Friend WithEvents Btn_logout As Button
    Friend WithEvents Btn_listed_accounts_delete As Button
    Friend WithEvents Btn_listed_accounts_add As Button
    Friend WithEvents Txt_listed_accounts_search As TextBox
    Friend WithEvents Lv_listed_accounts As ListView
    Friend WithEvents Listed_accounts0 As ColumnHeader
    Friend WithEvents Listed_accounts1 As ColumnHeader
    Friend WithEvents Listed_accounts2 As ColumnHeader
    Friend WithEvents Listed_accounts3 As ColumnHeader
    Friend WithEvents Listed_accounts4 As ColumnHeader
    Friend WithEvents Listed_accounts5 As ColumnHeader
    Friend WithEvents Listed_accounts6 As ColumnHeader
    Friend WithEvents Listed_accounts7 As ColumnHeader
    Friend WithEvents Listed_accounts8 As ColumnHeader
    Friend WithEvents Listed_accounts9 As ColumnHeader
    Friend WithEvents Btn_listed_books As Button
    Friend WithEvents Btn_returned_books As Button
    Friend WithEvents Btn_student_information As Button
    Friend WithEvents Btn_listed_accounts As Button
    Friend WithEvents Cb_listed_books_category As ComboBox
    Friend WithEvents Listed_books3 As ColumnHeader
    Friend WithEvents Student_info2 As ColumnHeader
    Friend WithEvents Student_info3 As ColumnHeader
    Friend WithEvents Listed_books2 As ColumnHeader
    Friend WithEvents Tmr_home_page_date_time As Timer
    Friend WithEvents P_navigation As Panel
    Friend WithEvents Txt_student_info_search As RoundCornerTextbox
    Friend WithEvents Txt_returned_borrowed_books_search As RoundCornerTextbox
    Friend WithEvents Btn_author_category_penalty_publisher_maintenance As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Btn_supplier_maintenance As Button
    Friend WithEvents Panel6_Supplier As Panel
    Friend WithEvents Btn_supplier_delete As Button
    Friend WithEvents Btn_supplier_edit As Button
    Friend WithEvents Btn_supplier_add As Button
    Friend WithEvents Lv_supplier As ListView
    Friend WithEvents Listed_supplier_0 As ColumnHeader
    Friend WithEvents Listed_supplier_2 As ColumnHeader
    Friend WithEvents Listed_supplier_3 As ColumnHeader
    Friend WithEvents Listed_supplier_4 As ColumnHeader
    Friend WithEvents Listed_supplier_5 As ColumnHeader
    Friend WithEvents Listed_supplier_6 As ColumnHeader
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Btn_penalty_report As Button
    Friend WithEvents Panel8_Penalty_Report As Panel
    Friend WithEvents Lv_penalty As ListView
    Friend WithEvents Listed_penalty0 As ColumnHeader
    Friend WithEvents Listed_penalty2 As ColumnHeader
    Friend WithEvents Listed_penalty4 As ColumnHeader
    Friend WithEvents Listed_penalty3 As ColumnHeader
    Friend WithEvents Listed_penalty5 As ColumnHeader
    Friend WithEvents Listed_penalty1 As ColumnHeader
    Friend WithEvents Btn_penalty_report_delete As Button
    Friend WithEvents Btn_penalty_report_edit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Listed_books0 As ColumnHeader
    Friend WithEvents Btn_borrow_books As Button
    Friend WithEvents Btn_return_books As Button
    Friend WithEvents Panel10_Author_Category_Penalty_Publisher As Panel
    Friend WithEvents Panel5_Author As Panel
    Friend WithEvents Btn_author_delete As Button
    Friend WithEvents Lv_author As ListView
    Friend WithEvents ColumnHeader As ColumnHeader
    Friend WithEvents Btn_author_add As Button
    Friend WithEvents Btn_author_edit As Button
    Friend WithEvents Txt_search_author As TextBox
    Friend WithEvents Panel9_Penalty As Panel
    Friend WithEvents Btn_penalty_description_delete As Button
    Friend WithEvents Btn_penalty_description_edit As Button
    Friend WithEvents Txt_search_penalty_description As TextBox
    Friend WithEvents Btn_penalty_description_add As Button
    Friend WithEvents Lv_penalty_description As ListView
    Friend WithEvents Listed_details0 As ColumnHeader
    Friend WithEvents Panel7_Category As Panel
    Friend WithEvents Txt_search_category As TextBox
    Friend WithEvents Btn_category_delete As Button
    Friend WithEvents Btn_category_edit As Button
    Friend WithEvents Btn_category_add As Button
    Friend WithEvents Lv_category As ListView
    Friend WithEvents Listed_Category0 As ColumnHeader
    Friend WithEvents Btn_listed_accounts_edit As Button
    Friend WithEvents Txt_search_supplier As TextBox
    Friend WithEvents Listed_supplier_1 As ColumnHeader
    Friend WithEvents Lbl_user_type_logged_in As Label
    Friend WithEvents Lbl_name_logged_in As Label
    Friend WithEvents Lbl_date_time As Label
    Friend WithEvents Txt_search_penalty_report As TextBox
    Friend WithEvents Panel11_Publisher As Panel
    Friend WithEvents Btn_publisher_delete As Button
    Friend WithEvents Btn_publisher_edit As Button
    Friend WithEvents Txt_search_publisher As TextBox
    Friend WithEvents Btn_publisher_add As Button
    Friend WithEvents Lv_publisher As ListView
    Friend WithEvents Listed_details1 As ColumnHeader
    Friend WithEvents Returned_borrowed_books0 As ColumnHeader
    Friend WithEvents Btn_borrower_info_edit As Button
    Friend WithEvents Student_info7 As ColumnHeader
    Friend WithEvents Student_info4 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Btn_shelf As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Btn_delivery As Button
    Friend WithEvents Btn_book_inventory As Button
    Friend WithEvents Panel12_Shelf As Panel
    Friend WithEvents Btn_shelf_edit As Button
    Friend WithEvents Txt_search_shelf As RoundCornerTextbox
    Friend WithEvents Btn_shelf_delete As Button
    Friend WithEvents Btn_shelf_add As Button
    Friend WithEvents Lv_shelf As ListView
    Friend WithEvents Shelf_table1 As ColumnHeader
    Friend WithEvents Shelf_table2 As ColumnHeader
    Friend WithEvents Shelf_table3 As ColumnHeader
    Friend WithEvents Shelf_table4 As ColumnHeader
    Friend WithEvents Shelf_table5 As ColumnHeader
    Friend WithEvents Shelf_table6 As ColumnHeader
    Friend WithEvents Shelf_table7 As ColumnHeader
    Friend WithEvents Panel13_Delivery As Panel
    Friend WithEvents Btn_delivery_edit As Button
    Friend WithEvents Txt_delivery_search As RoundCornerTextbox
    Friend WithEvents Btn_delivery_delete As Button
    Friend WithEvents Btn_delivery_add As Button
    Friend WithEvents Lv_delivery As ListView
    Friend WithEvents Delivery_table0 As ColumnHeader
    Friend WithEvents Delivery_table1 As ColumnHeader
    Friend WithEvents Delivery_table4 As ColumnHeader
    Friend WithEvents Delivery_table5 As ColumnHeader
    Friend WithEvents Delivery_table6 As ColumnHeader
    Friend WithEvents Delivery_table7 As ColumnHeader
    Friend WithEvents Delivery_table8 As ColumnHeader
    Friend WithEvents Delivery_table9 As ColumnHeader
    Friend WithEvents Delivery_table10 As ColumnHeader
    Friend WithEvents Shelf_table0 As ColumnHeader
    Friend WithEvents Delivery_table2 As ColumnHeader
    Friend WithEvents Delivery_table3 As ColumnHeader
    Friend WithEvents Panel14_Book_Inventory As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Book_inventory0 As ColumnHeader
    Friend WithEvents Book_inventory1 As ColumnHeader
    Friend WithEvents Book_inventory2 As ColumnHeader
    Friend WithEvents Book_inventory3 As ColumnHeader
    Friend WithEvents Book_inventory4 As ColumnHeader
    Friend WithEvents Book_inventory5 As ColumnHeader
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Book_inventory6 As ColumnHeader
    Friend WithEvents Book_inventory7 As ColumnHeader
    Friend WithEvents Book_inventory8 As ColumnHeader
    Friend WithEvents Book_inventory9 As ColumnHeader
End Class
