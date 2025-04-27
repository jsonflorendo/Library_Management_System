<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_add_borrower
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
        Label7 = New Label()
        Label6 = New Label()
        Txt_borrower_middle_name = New TextBox()
        Txt_borrower_first_name = New TextBox()
        Label5 = New Label()
        Rb_female = New RadioButton()
        Rb_male = New RadioButton()
        Txt_borrower_last_name = New TextBox()
        Txt_borrower_address = New TextBox()
        Txt_borrower_contact_no = New TextBox()
        Txt_borrower_id_number = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Btn_update = New Button()
        Btn_exit = New Button()
        Btn_save = New Button()
        Txt_borrower_email = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Cb_borrower_category_type = New ComboBox()
        Pb_id_no_barcode = New PictureBox()
        Lbl_error_msg = New Label()
        Lbl_error_msg_1 = New Label()
        Lbl_error_msg_2 = New Label()
        Lbl_error_msg_3 = New Label()
        Lbl_error_msg_4 = New Label()
        Lbl_error_msg_5 = New Label()
        Lbl_error_msg_6 = New Label()
        Lbl_error_msg_7 = New Label()
        Lbl_error_msg_8 = New Label()
        Label4 = New Label()
        CType(Pb_id_no_barcode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ControlLight
        Label7.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(37, 214)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 18)
        Label7.TabIndex = 56
        Label7.Text = "Middle Name :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ControlLight
        Label6.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(37, 168)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 18)
        Label6.TabIndex = 55
        Label6.Text = "First Name :"
        ' 
        ' Txt_borrower_middle_name
        ' 
        Txt_borrower_middle_name.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_middle_name.Location = New Point(178, 214)
        Txt_borrower_middle_name.Name = "Txt_borrower_middle_name"
        Txt_borrower_middle_name.PlaceholderText = "Middle Name"
        Txt_borrower_middle_name.Size = New Size(200, 21)
        Txt_borrower_middle_name.TabIndex = 4
        ' 
        ' Txt_borrower_first_name
        ' 
        Txt_borrower_first_name.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_first_name.Location = New Point(178, 168)
        Txt_borrower_first_name.Name = "Txt_borrower_first_name"
        Txt_borrower_first_name.PlaceholderText = "First Name"
        Txt_borrower_first_name.Size = New Size(200, 21)
        Txt_borrower_first_name.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlLight
        Label5.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(37, 310)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 18)
        Label5.TabIndex = 54
        Label5.Text = "Gender:"
        ' 
        ' Rb_female
        ' 
        Rb_female.AutoSize = True
        Rb_female.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Rb_female.Location = New Point(274, 308)
        Rb_female.Name = "Rb_female"
        Rb_female.Size = New Size(81, 22)
        Rb_female.TabIndex = 7
        Rb_female.TabStop = True
        Rb_female.Text = "Female"
        Rb_female.UseVisualStyleBackColor = True
        ' 
        ' Rb_male
        ' 
        Rb_male.AutoSize = True
        Rb_male.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Rb_male.Location = New Point(178, 308)
        Rb_male.Name = "Rb_male"
        Rb_male.Size = New Size(63, 22)
        Rb_male.TabIndex = 6
        Rb_male.TabStop = True
        Rb_male.Text = "Male"
        Rb_male.UseVisualStyleBackColor = True
        ' 
        ' Txt_borrower_last_name
        ' 
        Txt_borrower_last_name.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_last_name.Location = New Point(178, 122)
        Txt_borrower_last_name.Name = "Txt_borrower_last_name"
        Txt_borrower_last_name.PlaceholderText = "Last Name"
        Txt_borrower_last_name.Size = New Size(200, 21)
        Txt_borrower_last_name.TabIndex = 2
        ' 
        ' Txt_borrower_address
        ' 
        Txt_borrower_address.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_address.Location = New Point(178, 447)
        Txt_borrower_address.Name = "Txt_borrower_address"
        Txt_borrower_address.PlaceholderText = "Address"
        Txt_borrower_address.Size = New Size(200, 21)
        Txt_borrower_address.TabIndex = 10
        ' 
        ' Txt_borrower_contact_no
        ' 
        Txt_borrower_contact_no.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_contact_no.Location = New Point(178, 355)
        Txt_borrower_contact_no.Name = "Txt_borrower_contact_no"
        Txt_borrower_contact_no.PlaceholderText = "Contact No."
        Txt_borrower_contact_no.Size = New Size(200, 21)
        Txt_borrower_contact_no.TabIndex = 8
        ' 
        ' Txt_borrower_id_number
        ' 
        Txt_borrower_id_number.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_id_number.Location = New Point(178, 76)
        Txt_borrower_id_number.Name = "Txt_borrower_id_number"
        Txt_borrower_id_number.PlaceholderText = "ID Number"
        Txt_borrower_id_number.Size = New Size(200, 21)
        Txt_borrower_id_number.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ControlLight
        Label8.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(37, 447)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 18)
        Label8.TabIndex = 48
        Label8.Text = "Address :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.ControlLight
        Label9.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(37, 355)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 18)
        Label9.TabIndex = 45
        Label9.Text = "Contact No. :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ControlLight
        Label10.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(37, 122)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 18)
        Label10.TabIndex = 43
        Label10.Text = "Last Name :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.ControlLight
        Label11.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(37, 76)
        Label11.Name = "Label11"
        Label11.Size = New Size(106, 18)
        Label11.TabIndex = 42
        Label11.Text = "ID Number :"
        ' 
        ' Btn_update
        ' 
        Btn_update.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_update.Location = New Point(59, 597)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(124, 44)
        Btn_update.TabIndex = 0
        Btn_update.Text = "&Update"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Btn_exit
        ' 
        Btn_exit.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_exit.Location = New Point(231, 597)
        Btn_exit.Name = "Btn_exit"
        Btn_exit.Size = New Size(124, 44)
        Btn_exit.TabIndex = 59
        Btn_exit.Text = "&Exit"
        Btn_exit.UseVisualStyleBackColor = True
        ' 
        ' Btn_save
        ' 
        Btn_save.Location = New Point(59, 597)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(124, 44)
        Btn_save.TabIndex = 0
        Btn_save.Text = "&Save"
        Btn_save.UseVisualStyleBackColor = True
        ' 
        ' Txt_borrower_email
        ' 
        Txt_borrower_email.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_email.Location = New Point(178, 401)
        Txt_borrower_email.Name = "Txt_borrower_email"
        Txt_borrower_email.PlaceholderText = "Email"
        Txt_borrower_email.Size = New Size(200, 21)
        Txt_borrower_email.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLight
        Label1.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(37, 404)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 18)
        Label1.TabIndex = 61
        Label1.Text = "Email :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLight
        Label2.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(37, 260)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 18)
        Label2.TabIndex = 63
        Label2.Text = "Category Type :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlLight
        Label3.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(37, 493)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 18)
        Label3.TabIndex = 64
        Label3.Text = "Barcode :"
        ' 
        ' Cb_borrower_category_type
        ' 
        Cb_borrower_category_type.FormattingEnabled = True
        Cb_borrower_category_type.Items.AddRange(New Object() {"STUDENT", "TEACHER", "FACULTY MEMBER"})
        Cb_borrower_category_type.Location = New Point(178, 260)
        Cb_borrower_category_type.Name = "Cb_borrower_category_type"
        Cb_borrower_category_type.Size = New Size(200, 23)
        Cb_borrower_category_type.TabIndex = 5
        ' 
        ' Pb_id_no_barcode
        ' 
        Pb_id_no_barcode.Location = New Point(37, 523)
        Pb_id_no_barcode.Name = "Pb_id_no_barcode"
        Pb_id_no_barcode.Size = New Size(341, 59)
        Pb_id_no_barcode.TabIndex = 66
        Pb_id_no_barcode.TabStop = False
        ' 
        ' Lbl_error_msg
        ' 
        Lbl_error_msg.AutoSize = True
        Lbl_error_msg.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Lbl_error_msg.ForeColor = Color.Red
        Lbl_error_msg.Location = New Point(176, 100)
        Lbl_error_msg.Name = "Lbl_error_msg"
        Lbl_error_msg.Size = New Size(91, 17)
        Lbl_error_msg.TabIndex = 67
        Lbl_error_msg.Text = "Lbl_error_msg"
        ' 
        ' Lbl_error_msg_1
        ' 
        Lbl_error_msg_1.AutoSize = True
        Lbl_error_msg_1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Lbl_error_msg_1.ForeColor = Color.Red
        Lbl_error_msg_1.Location = New Point(176, 146)
        Lbl_error_msg_1.Name = "Lbl_error_msg_1"
        Lbl_error_msg_1.Size = New Size(101, 17)
        Lbl_error_msg_1.TabIndex = 68
        Lbl_error_msg_1.Text = "Lbl_error_msg_1"
        ' 
        ' Lbl_error_msg_2
        ' 
        Lbl_error_msg_2.AutoSize = True
        Lbl_error_msg_2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Lbl_error_msg_2.ForeColor = Color.Red
        Lbl_error_msg_2.Location = New Point(176, 192)
        Lbl_error_msg_2.Name = "Lbl_error_msg_2"
        Lbl_error_msg_2.Size = New Size(103, 17)
        Lbl_error_msg_2.TabIndex = 69
        Lbl_error_msg_2.Text = "Lbl_error_msg_2"
        ' 
        ' Lbl_error_msg_3
        ' 
        Lbl_error_msg_3.AutoSize = True
        Lbl_error_msg_3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Lbl_error_msg_3.ForeColor = Color.Red
        Lbl_error_msg_3.Location = New Point(176, 238)
        Lbl_error_msg_3.Name = "Lbl_error_msg_3"
        Lbl_error_msg_3.Size = New Size(103, 17)
        Lbl_error_msg_3.TabIndex = 70
        Lbl_error_msg_3.Text = "Lbl_error_msg_3"
        ' 
        ' Lbl_error_msg_4
        ' 
        Lbl_error_msg_4.AutoSize = True
        Lbl_error_msg_4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Lbl_error_msg_4.ForeColor = Color.Red
        Lbl_error_msg_4.Location = New Point(176, 286)
        Lbl_error_msg_4.Name = "Lbl_error_msg_4"
        Lbl_error_msg_4.Size = New Size(103, 17)
        Lbl_error_msg_4.TabIndex = 71
        Lbl_error_msg_4.Text = "Lbl_error_msg_4"
        ' 
        ' Lbl_error_msg_5
        ' 
        Lbl_error_msg_5.AutoSize = True
        Lbl_error_msg_5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Lbl_error_msg_5.ForeColor = Color.Red
        Lbl_error_msg_5.Location = New Point(176, 333)
        Lbl_error_msg_5.Name = "Lbl_error_msg_5"
        Lbl_error_msg_5.Size = New Size(103, 17)
        Lbl_error_msg_5.TabIndex = 72
        Lbl_error_msg_5.Text = "Lbl_error_msg_5"
        ' 
        ' Lbl_error_msg_6
        ' 
        Lbl_error_msg_6.AutoSize = True
        Lbl_error_msg_6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Lbl_error_msg_6.ForeColor = Color.Red
        Lbl_error_msg_6.Location = New Point(176, 379)
        Lbl_error_msg_6.Name = "Lbl_error_msg_6"
        Lbl_error_msg_6.Size = New Size(103, 17)
        Lbl_error_msg_6.TabIndex = 73
        Lbl_error_msg_6.Text = "Lbl_error_msg_6"
        ' 
        ' Lbl_error_msg_7
        ' 
        Lbl_error_msg_7.AutoSize = True
        Lbl_error_msg_7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Lbl_error_msg_7.ForeColor = Color.Red
        Lbl_error_msg_7.Location = New Point(176, 425)
        Lbl_error_msg_7.Name = "Lbl_error_msg_7"
        Lbl_error_msg_7.Size = New Size(103, 17)
        Lbl_error_msg_7.TabIndex = 74
        Lbl_error_msg_7.Text = "Lbl_error_msg_7"
        ' 
        ' Lbl_error_msg_8
        ' 
        Lbl_error_msg_8.AutoSize = True
        Lbl_error_msg_8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Lbl_error_msg_8.ForeColor = Color.Red
        Lbl_error_msg_8.Location = New Point(176, 471)
        Lbl_error_msg_8.Name = "Lbl_error_msg_8"
        Lbl_error_msg_8.Size = New Size(103, 17)
        Lbl_error_msg_8.TabIndex = 75
        Lbl_error_msg_8.Text = "Lbl_error_msg_8"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(87, 18)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(252, 38)
        Label4.TabIndex = 76
        Label4.Text = "Add Borrower"
        ' 
        ' Fm_add_borrower
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(416, 661)
        ControlBox = False
        Controls.Add(Label4)
        Controls.Add(Lbl_error_msg_8)
        Controls.Add(Lbl_error_msg_7)
        Controls.Add(Lbl_error_msg_6)
        Controls.Add(Lbl_error_msg_5)
        Controls.Add(Lbl_error_msg_4)
        Controls.Add(Lbl_error_msg_3)
        Controls.Add(Lbl_error_msg_2)
        Controls.Add(Lbl_error_msg_1)
        Controls.Add(Lbl_error_msg)
        Controls.Add(Pb_id_no_barcode)
        Controls.Add(Cb_borrower_category_type)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Txt_borrower_email)
        Controls.Add(Btn_exit)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Txt_borrower_middle_name)
        Controls.Add(Txt_borrower_first_name)
        Controls.Add(Label5)
        Controls.Add(Rb_female)
        Controls.Add(Rb_male)
        Controls.Add(Txt_borrower_last_name)
        Controls.Add(Txt_borrower_address)
        Controls.Add(Txt_borrower_contact_no)
        Controls.Add(Txt_borrower_id_number)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(Btn_update)
        Controls.Add(Btn_save)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_add_borrower"
        StartPosition = FormStartPosition.CenterScreen
        CType(Pb_id_no_barcode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_borrower_middle_name As TextBox
    Friend WithEvents Txt_borrower_first_name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Rb_female As RadioButton
    Friend WithEvents Rb_male As RadioButton
    Friend WithEvents Txt_borrower_last_name As TextBox
    Friend WithEvents Txt_borrower_address As TextBox
    Friend WithEvents Txt_borrower_contact_no As TextBox
    Friend WithEvents Txt_borrower_id_number As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Btn_update As Button
    Friend WithEvents Btn_exit As Button
    Friend WithEvents Btn_save As Button
    Friend WithEvents Txt_borrower_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Cb_borrower_category_type As ComboBox
    Friend WithEvents Pb_id_no_barcode As PictureBox
    Friend WithEvents Lbl_error_msg As Label
    Friend WithEvents Lbl_error_msg_1 As Label
    Friend WithEvents Lbl_error_msg_2 As Label
    Friend WithEvents Lbl_error_msg_3 As Label
    Friend WithEvents Lbl_error_msg_4 As Label
    Friend WithEvents Lbl_error_msg_5 As Label
    Friend WithEvents Lbl_error_msg_6 As Label
    Friend WithEvents Lbl_error_msg_7 As Label
    Friend WithEvents Lbl_error_msg_8 As Label
    Friend WithEvents Label4 As Label
End Class
