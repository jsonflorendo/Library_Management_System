﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Btn_cancel = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Txt_issued_to = New TextBox()
        Txt_borrower_id_number = New TextBox()
        Txt_book_name = New TextBox()
        Txt_primary_borrower_id = New TextBox()
        Label5 = New Label()
        Txt_isbn = New TextBox()
        Txt_primary_book_id = New TextBox()
        Lbl_error_msg = New Label()
        Lbl_error_msg_1 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Btn_cancel
        ' 
        Btn_cancel.Font = New Font("Georgia", 9F)
        Btn_cancel.Location = New Point(266, 235)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(110, 39)
        Btn_cancel.TabIndex = 2
        Btn_cancel.Text = "&Cancel"
        Btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlLight
        Label3.Font = New Font("Georgia", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(17, 189)
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
        Label2.Location = New Point(17, 146)
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
        Label1.Location = New Point(17, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 23)
        Label1.TabIndex = 4
        Label1.Text = "Book Name:"
        ' 
        ' Txt_issued_to
        ' 
        Txt_issued_to.Enabled = False
        Txt_issued_to.Font = New Font("Arial", 9F)
        Txt_issued_to.Location = New Point(163, 193)
        Txt_issued_to.Name = "Txt_issued_to"
        Txt_issued_to.Size = New Size(242, 21)
        Txt_issued_to.TabIndex = 2
        Txt_issued_to.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txt_borrower_id_number
        ' 
        Txt_borrower_id_number.Font = New Font("Arial", 9F, FontStyle.Bold)
        Txt_borrower_id_number.Location = New Point(163, 147)
        Txt_borrower_id_number.Name = "Txt_borrower_id_number"
        Txt_borrower_id_number.PlaceholderText = "ID Number"
        Txt_borrower_id_number.Size = New Size(242, 21)
        Txt_borrower_id_number.TabIndex = 1
        Txt_borrower_id_number.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txt_book_name
        ' 
        Txt_book_name.Enabled = False
        Txt_book_name.Font = New Font("Arial", 9F)
        Txt_book_name.Location = New Point(163, 106)
        Txt_book_name.Name = "Txt_book_name"
        Txt_book_name.Size = New Size(242, 21)
        Txt_book_name.TabIndex = 0
        ' 
        ' Txt_primary_borrower_id
        ' 
        Txt_primary_borrower_id.Location = New Point(411, 146)
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
        Label5.Location = New Point(17, 59)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 23)
        Label5.TabIndex = 26
        Label5.Text = "ISBN:"
        ' 
        ' Txt_isbn
        ' 
        Txt_isbn.Enabled = False
        Txt_isbn.Font = New Font("Arial", 9F, FontStyle.Bold)
        Txt_isbn.Location = New Point(163, 59)
        Txt_isbn.Name = "Txt_isbn"
        Txt_isbn.PlaceholderText = "ISBN"
        Txt_isbn.Size = New Size(242, 21)
        Txt_isbn.TabIndex = 25
        Txt_isbn.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txt_primary_book_id
        ' 
        Txt_primary_book_id.Location = New Point(411, 106)
        Txt_primary_book_id.Name = "Txt_primary_book_id"
        Txt_primary_book_id.PlaceholderText = "Primary Book ID"
        Txt_primary_book_id.Size = New Size(114, 23)
        Txt_primary_book_id.TabIndex = 27
        Txt_primary_book_id.Visible = False
        ' 
        ' Lbl_error_msg
        ' 
        Lbl_error_msg.AutoSize = True
        Lbl_error_msg.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_error_msg.ForeColor = Color.Red
        Lbl_error_msg.Location = New Point(161, 171)
        Lbl_error_msg.Name = "Lbl_error_msg"
        Lbl_error_msg.Size = New Size(91, 17)
        Lbl_error_msg.TabIndex = 29
        Lbl_error_msg.Text = "Lbl_error_msg"
        ' 
        ' Lbl_error_msg_1
        ' 
        Lbl_error_msg_1.AutoSize = True
        Lbl_error_msg_1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_error_msg_1.ForeColor = Color.Red
        Lbl_error_msg_1.Location = New Point(161, 83)
        Lbl_error_msg_1.Name = "Lbl_error_msg_1"
        Lbl_error_msg_1.Size = New Size(101, 17)
        Lbl_error_msg_1.TabIndex = 30
        Lbl_error_msg_1.Text = "Lbl_error_msg_1"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(71, 9)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(266, 38)
        Label4.TabIndex = 49
        Label4.Text = "Returned Book"
        ' 
        ' Fm_returned_books
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(421, 290)
        ControlBox = False
        Controls.Add(Label4)
        Controls.Add(Lbl_error_msg_1)
        Controls.Add(Lbl_error_msg)
        Controls.Add(Txt_primary_book_id)
        Controls.Add(Label5)
        Controls.Add(Txt_isbn)
        Controls.Add(Txt_primary_borrower_id)
        Controls.Add(Label3)
        Controls.Add(Btn_cancel)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Txt_book_name)
        Controls.Add(Txt_borrower_id_number)
        Controls.Add(Txt_issued_to)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Fm_returned_books"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Txt_issued_to As TextBox
    Friend WithEvents Txt_borrower_id_number As TextBox
    Friend WithEvents Txt_book_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_primary_borrower_id As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_isbn As TextBox
    Friend WithEvents Txt_primary_book_id As TextBox
    Friend WithEvents Lbl_error_msg As Label
    Friend WithEvents Lbl_error_msg_1 As Label
    Friend WithEvents Label4 As Label
End Class
