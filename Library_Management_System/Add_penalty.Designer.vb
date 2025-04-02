<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_add_penalty
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
        Txt_borrower_id = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Txt_penalty_amount = New TextBox()
        Txt_borrower_name = New TextBox()
        Btn_save = New Button()
        Btn_cancel = New Button()
        Cb_penalty_description = New ComboBox()
        Txt_primary_borrower_id = New TextBox()
        Txt_primary_penalty_description_id = New TextBox()
        Txt_book_name = New TextBox()
        Label6 = New Label()
        Txt_primary_book_id = New TextBox()
        Btn_update = New Button()
        Lbl_error_msg = New Label()
        SuspendLayout()
        ' 
        ' Txt_borrower_id
        ' 
        Txt_borrower_id.BackColor = SystemColors.Window
        Txt_borrower_id.Enabled = False
        Txt_borrower_id.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_id.Location = New Point(207, 8)
        Txt_borrower_id.Name = "Txt_borrower_id"
        Txt_borrower_id.PlaceholderText = "ID Number"
        Txt_borrower_id.Size = New Size(229, 21)
        Txt_borrower_id.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlLight
        Label3.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 16)
        Label3.TabIndex = 8
        Label3.Text = "ID Number :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlLight
        Label1.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 16)
        Label1.TabIndex = 9
        Label1.Text = "Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlLight
        Label2.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 16)
        Label2.TabIndex = 10
        Label2.Text = "Penalty Amount :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlLight
        Label4.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 101)
        Label4.Name = "Label4"
        Label4.Size = New Size(158, 16)
        Label4.TabIndex = 11
        Label4.Text = "Penalty Description :"
        ' 
        ' Txt_penalty_amount
        ' 
        Txt_penalty_amount.Enabled = False
        Txt_penalty_amount.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_penalty_amount.Location = New Point(207, 148)
        Txt_penalty_amount.Name = "Txt_penalty_amount"
        Txt_penalty_amount.PlaceholderText = "Penalty Amount"
        Txt_penalty_amount.Size = New Size(229, 21)
        Txt_penalty_amount.TabIndex = 15
        ' 
        ' Txt_borrower_name
        ' 
        Txt_borrower_name.Enabled = False
        Txt_borrower_name.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_borrower_name.Location = New Point(207, 39)
        Txt_borrower_name.Name = "Txt_borrower_name"
        Txt_borrower_name.PlaceholderText = "Name"
        Txt_borrower_name.Size = New Size(229, 21)
        Txt_borrower_name.TabIndex = 16
        ' 
        ' Btn_save
        ' 
        Btn_save.BackColor = SystemColors.AppWorkspace
        Btn_save.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_save.Location = New Point(41, 183)
        Btn_save.Name = "Btn_save"
        Btn_save.Size = New Size(129, 40)
        Btn_save.TabIndex = 19
        Btn_save.Text = "&Save"
        Btn_save.UseVisualStyleBackColor = False
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.BackColor = SystemColors.AppWorkspace
        Btn_cancel.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_cancel.Location = New Point(270, 183)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(129, 40)
        Btn_cancel.TabIndex = 20
        Btn_cancel.Text = "&Cancel"
        Btn_cancel.UseVisualStyleBackColor = False
        ' 
        ' Cb_penalty_description
        ' 
        Cb_penalty_description.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cb_penalty_description.FormattingEnabled = True
        Cb_penalty_description.Location = New Point(207, 100)
        Cb_penalty_description.Name = "Cb_penalty_description"
        Cb_penalty_description.Size = New Size(229, 23)
        Cb_penalty_description.TabIndex = 21
        Cb_penalty_description.Text = "-Select Description-"
        ' 
        ' Txt_primary_borrower_id
        ' 
        Txt_primary_borrower_id.Location = New Point(442, 8)
        Txt_primary_borrower_id.Name = "Txt_primary_borrower_id"
        Txt_primary_borrower_id.PlaceholderText = "Primary Borrower ID"
        Txt_primary_borrower_id.Size = New Size(168, 23)
        Txt_primary_borrower_id.TabIndex = 28
        ' 
        ' Txt_primary_penalty_description_id
        ' 
        Txt_primary_penalty_description_id.Location = New Point(442, 100)
        Txt_primary_penalty_description_id.Name = "Txt_primary_penalty_description_id"
        Txt_primary_penalty_description_id.PlaceholderText = "Primary Penalty Description ID"
        Txt_primary_penalty_description_id.Size = New Size(168, 23)
        Txt_primary_penalty_description_id.TabIndex = 25
        ' 
        ' Txt_book_name
        ' 
        Txt_book_name.Enabled = False
        Txt_book_name.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_book_name.Location = New Point(207, 70)
        Txt_book_name.Name = "Txt_book_name"
        Txt_book_name.PlaceholderText = "Book Name"
        Txt_book_name.Size = New Size(229, 21)
        Txt_book_name.TabIndex = 29
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ControlLight
        Label6.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 72)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 16)
        Label6.TabIndex = 30
        Label6.Text = "Book Name :"
        ' 
        ' Txt_primary_book_id
        ' 
        Txt_primary_book_id.Location = New Point(442, 70)
        Txt_primary_book_id.Name = "Txt_primary_book_id"
        Txt_primary_book_id.PlaceholderText = "Primary Book ID"
        Txt_primary_book_id.Size = New Size(168, 23)
        Txt_primary_book_id.TabIndex = 31
        ' 
        ' Btn_update
        ' 
        Btn_update.BackColor = SystemColors.AppWorkspace
        Btn_update.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_update.Location = New Point(41, 183)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(129, 40)
        Btn_update.TabIndex = 32
        Btn_update.Text = "&Update"
        Btn_update.UseVisualStyleBackColor = False
        ' 
        ' Lbl_error_msg
        ' 
        Lbl_error_msg.AutoSize = True
        Lbl_error_msg.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_error_msg.ForeColor = Color.Red
        Lbl_error_msg.Location = New Point(204, 126)
        Lbl_error_msg.Name = "Lbl_error_msg"
        Lbl_error_msg.Size = New Size(91, 17)
        Lbl_error_msg.TabIndex = 33
        Lbl_error_msg.Text = "Lbl_error_msg"
        ' 
        ' Fm_add_penalty
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(618, 235)
        ControlBox = False
        Controls.Add(Lbl_error_msg)
        Controls.Add(Btn_update)
        Controls.Add(Txt_primary_book_id)
        Controls.Add(Label6)
        Controls.Add(Txt_book_name)
        Controls.Add(Txt_primary_borrower_id)
        Controls.Add(Txt_primary_penalty_description_id)
        Controls.Add(Cb_penalty_description)
        Controls.Add(Btn_cancel)
        Controls.Add(Btn_save)
        Controls.Add(Txt_borrower_name)
        Controls.Add(Txt_penalty_amount)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Txt_borrower_id)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_add_penalty"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txt_borrower_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_penalty_amount As TextBox
    Friend WithEvents Txt_borrower_name As TextBox
    Friend WithEvents Btn_save As Button
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Cb_penalty_description As ComboBox
    Friend WithEvents Txt_primary_borrower_id As TextBox
    Friend WithEvents Txt_primary_penalty_description_id As TextBox
    Friend WithEvents Txt_book_name As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_primary_book_id As TextBox
    Friend WithEvents Btn_update As Button
    Friend WithEvents Lbl_error_msg As Label
End Class
