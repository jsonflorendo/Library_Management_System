﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Txt_borrower_name = New TextBox()
        Btn_save = New Button()
        Btn_cancel = New Button()
        Txt_primary_borrower_id = New TextBox()
        Txt_book_name = New TextBox()
        Label6 = New Label()
        Txt_primary_book_id = New TextBox()
        Btn_update = New Button()
        Lbl_error_msg = New Label()
        Lv_penalty_description = New ListView()
        Listed_details0 = New ColumnHeader()
        Listed_details1 = New ColumnHeader()
        Txt_search_penalty_description = New TextBox()
        Txt_primary_penalty_report_id = New TextBox()
        Lv_penalty_description_selected = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Txt_borrower_id
        ' 
        Txt_borrower_id.BackColor = SystemColors.Window
        Txt_borrower_id.Enabled = False
        Txt_borrower_id.Font = New Font("Arial", 9F)
        Txt_borrower_id.Location = New Point(207, 64)
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
        Label3.Location = New Point(12, 65)
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
        Label1.Location = New Point(12, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 16)
        Label1.TabIndex = 9
        Label1.Text = "Name :"
        ' 
        ' Txt_borrower_name
        ' 
        Txt_borrower_name.Enabled = False
        Txt_borrower_name.Font = New Font("Arial", 9F)
        Txt_borrower_name.Location = New Point(207, 95)
        Txt_borrower_name.Name = "Txt_borrower_name"
        Txt_borrower_name.PlaceholderText = "Name"
        Txt_borrower_name.Size = New Size(229, 21)
        Txt_borrower_name.TabIndex = 16
        ' 
        ' Btn_save
        ' 
        Btn_save.BackColor = SystemColors.AppWorkspace
        Btn_save.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_save.Location = New Point(41, 456)
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
        Btn_cancel.Location = New Point(270, 456)
        Btn_cancel.Name = "Btn_cancel"
        Btn_cancel.Size = New Size(129, 40)
        Btn_cancel.TabIndex = 20
        Btn_cancel.Text = "&Cancel"
        Btn_cancel.UseVisualStyleBackColor = False
        ' 
        ' Txt_primary_borrower_id
        ' 
        Txt_primary_borrower_id.Font = New Font("Georgia", 9F)
        Txt_primary_borrower_id.Location = New Point(442, 64)
        Txt_primary_borrower_id.Name = "Txt_primary_borrower_id"
        Txt_primary_borrower_id.PlaceholderText = "Primary Borrower ID"
        Txt_primary_borrower_id.Size = New Size(168, 21)
        Txt_primary_borrower_id.TabIndex = 28
        ' 
        ' Txt_book_name
        ' 
        Txt_book_name.Enabled = False
        Txt_book_name.Font = New Font("Arial", 9F)
        Txt_book_name.Location = New Point(207, 126)
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
        Label6.Location = New Point(12, 128)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 16)
        Label6.TabIndex = 30
        Label6.Text = "Book Name :"
        ' 
        ' Txt_primary_book_id
        ' 
        Txt_primary_book_id.Font = New Font("Georgia", 9F)
        Txt_primary_book_id.Location = New Point(442, 126)
        Txt_primary_book_id.Name = "Txt_primary_book_id"
        Txt_primary_book_id.PlaceholderText = "Primary Book ID"
        Txt_primary_book_id.Size = New Size(168, 21)
        Txt_primary_book_id.TabIndex = 31
        ' 
        ' Btn_update
        ' 
        Btn_update.BackColor = SystemColors.AppWorkspace
        Btn_update.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_update.Location = New Point(41, 456)
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
        Lbl_error_msg.Location = New Point(11, 429)
        Lbl_error_msg.Name = "Lbl_error_msg"
        Lbl_error_msg.Size = New Size(91, 17)
        Lbl_error_msg.TabIndex = 33
        Lbl_error_msg.Text = "Lbl_error_msg"
        ' 
        ' Lv_penalty_description
        ' 
        Lv_penalty_description.CheckBoxes = True
        Lv_penalty_description.Columns.AddRange(New ColumnHeader() {Listed_details0, Listed_details1})
        Lv_penalty_description.Font = New Font("Arial", 9F)
        Lv_penalty_description.FullRowSelect = True
        Lv_penalty_description.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lv_penalty_description.Location = New Point(12, 200)
        Lv_penalty_description.Name = "Lv_penalty_description"
        Lv_penalty_description.Size = New Size(424, 226)
        Lv_penalty_description.TabIndex = 46
        Lv_penalty_description.UseCompatibleStateImageBehavior = False
        Lv_penalty_description.View = View.Details
        ' 
        ' Listed_details0
        ' 
        Listed_details0.Text = "Penalty Description"
        Listed_details0.Width = 320
        ' 
        ' Listed_details1
        ' 
        Listed_details1.Text = "Amount"
        Listed_details1.TextAlign = HorizontalAlignment.Center
        Listed_details1.Width = 100
        ' 
        ' Txt_search_penalty_description
        ' 
        Txt_search_penalty_description.Font = New Font("Arial", 9F)
        Txt_search_penalty_description.Location = New Point(12, 171)
        Txt_search_penalty_description.Name = "Txt_search_penalty_description"
        Txt_search_penalty_description.PlaceholderText = "Search Penalty Description"
        Txt_search_penalty_description.Size = New Size(158, 21)
        Txt_search_penalty_description.TabIndex = 47
        ' 
        ' Txt_primary_penalty_report_id
        ' 
        Txt_primary_penalty_report_id.Location = New Point(442, 171)
        Txt_primary_penalty_report_id.Name = "Txt_primary_penalty_report_id"
        Txt_primary_penalty_report_id.PlaceholderText = "Primary Penalty Report ID"
        Txt_primary_penalty_report_id.Size = New Size(168, 23)
        Txt_primary_penalty_report_id.TabIndex = 48
        ' 
        ' Lv_penalty_description_selected
        ' 
        Lv_penalty_description_selected.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        Lv_penalty_description_selected.FullRowSelect = True
        Lv_penalty_description_selected.HeaderStyle = ColumnHeaderStyle.Nonclickable
        Lv_penalty_description_selected.Location = New Point(442, 200)
        Lv_penalty_description_selected.Name = "Lv_penalty_description_selected"
        Lv_penalty_description_selected.Size = New Size(505, 226)
        Lv_penalty_description_selected.TabIndex = 49
        Lv_penalty_description_selected.UseCompatibleStateImageBehavior = False
        Lv_penalty_description_selected.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "PENALTY DESCRIPTION"
        ColumnHeader1.Width = 200
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "AMOUNT"
        ColumnHeader2.TextAlign = HorizontalAlignment.Center
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "DAYS DELAYED"
        ColumnHeader3.TextAlign = HorizontalAlignment.Center
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "TOTAL AMOUNT"
        ColumnHeader4.TextAlign = HorizontalAlignment.Center
        ColumnHeader4.Width = 100
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(109, 9)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(214, 38)
        Label2.TabIndex = 50
        Label2.Text = "Add Penalty"
        ' 
        ' Fm_add_penalty
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(954, 517)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(Lv_penalty_description_selected)
        Controls.Add(Txt_primary_penalty_report_id)
        Controls.Add(Txt_search_penalty_description)
        Controls.Add(Lv_penalty_description)
        Controls.Add(Lbl_error_msg)
        Controls.Add(Btn_update)
        Controls.Add(Txt_primary_book_id)
        Controls.Add(Label6)
        Controls.Add(Txt_book_name)
        Controls.Add(Txt_primary_borrower_id)
        Controls.Add(Btn_cancel)
        Controls.Add(Btn_save)
        Controls.Add(Txt_borrower_name)
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
    Friend WithEvents Txt_borrower_name As TextBox
    Friend WithEvents Btn_save As Button
    Friend WithEvents Btn_cancel As Button
    Friend WithEvents Txt_primary_borrower_id As TextBox
    Friend WithEvents Txt_book_name As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_primary_book_id As TextBox
    Friend WithEvents Btn_update As Button
    Friend WithEvents Lbl_error_msg As Label
    Friend WithEvents Lv_penalty_description As ListView
    Friend WithEvents Listed_details0 As ColumnHeader
    Friend WithEvents Listed_details1 As ColumnHeader
    Friend WithEvents Txt_search_penalty_description As TextBox
    Friend WithEvents Txt_primary_penalty_report_id As TextBox
    Friend WithEvents Lv_penalty_description_selected As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label2 As Label
End Class
