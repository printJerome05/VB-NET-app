<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox_fname = New TextBox()
        TextBox_lname = New TextBox()
        TextBox_age = New TextBox()
        Button_show = New Button()
        Label4 = New Label()
        Label5 = New Label()
        TextBox_num1 = New TextBox()
        TextBox_num2 = New TextBox()
        Button_add = New Button()
        Button_minus = New Button()
        Button_multi = New Button()
        Button_divide = New Button()
        TextBox_Result = New TextBox()
        Button_back = New Button()
        Button_and = New Button()
        Button_or = New Button()
        Button_not = New Button()
        Label6 = New Label()
        TextBox1 = New TextBox()
        Label_passdata = New Label()
        TextBox_USER = New TextBox()
        TextBox_PASS = New TextBox()
        Button1 = New Button()
        Label7 = New Label()
        Label8 = New Label()
        TextBox_id = New TextBox()
        Label9 = New Label()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(98, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(98, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 1
        Label2.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(133, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 15)
        Label3.TabIndex = 2
        Label3.Text = "Age"
        ' 
        ' TextBox_fname
        ' 
        TextBox_fname.Location = New Point(184, 56)
        TextBox_fname.Name = "TextBox_fname"
        TextBox_fname.Size = New Size(100, 23)
        TextBox_fname.TabIndex = 3
        ' 
        ' TextBox_lname
        ' 
        TextBox_lname.Location = New Point(184, 95)
        TextBox_lname.Name = "TextBox_lname"
        TextBox_lname.Size = New Size(100, 23)
        TextBox_lname.TabIndex = 4
        ' 
        ' TextBox_age
        ' 
        TextBox_age.Location = New Point(184, 134)
        TextBox_age.Name = "TextBox_age"
        TextBox_age.Size = New Size(100, 23)
        TextBox_age.TabIndex = 5
        ' 
        ' Button_show
        ' 
        Button_show.Location = New Point(98, 174)
        Button_show.Name = "Button_show"
        Button_show.Size = New Size(186, 44)
        Button_show.TabIndex = 6
        Button_show.Text = "Show"
        Button_show.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(369, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 7
        Label4.Text = "NUMBER 1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(369, 103)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 15)
        Label5.TabIndex = 8
        Label5.Text = "NUMBER 2"
        ' 
        ' TextBox_num1
        ' 
        TextBox_num1.Location = New Point(461, 56)
        TextBox_num1.Name = "TextBox_num1"
        TextBox_num1.Size = New Size(100, 23)
        TextBox_num1.TabIndex = 9
        ' 
        ' TextBox_num2
        ' 
        TextBox_num2.Location = New Point(461, 95)
        TextBox_num2.Name = "TextBox_num2"
        TextBox_num2.Size = New Size(100, 23)
        TextBox_num2.TabIndex = 10
        ' 
        ' Button_add
        ' 
        Button_add.Location = New Point(369, 125)
        Button_add.Name = "Button_add"
        Button_add.Size = New Size(75, 23)
        Button_add.TabIndex = 11
        Button_add.Text = "+"
        Button_add.UseVisualStyleBackColor = True
        ' 
        ' Button_minus
        ' 
        Button_minus.Location = New Point(486, 125)
        Button_minus.Name = "Button_minus"
        Button_minus.Size = New Size(75, 23)
        Button_minus.TabIndex = 12
        Button_minus.Text = "-"
        Button_minus.UseVisualStyleBackColor = True
        ' 
        ' Button_multi
        ' 
        Button_multi.Location = New Point(369, 154)
        Button_multi.Name = "Button_multi"
        Button_multi.Size = New Size(75, 23)
        Button_multi.TabIndex = 13
        Button_multi.Text = "*"
        Button_multi.UseVisualStyleBackColor = True
        ' 
        ' Button_divide
        ' 
        Button_divide.Location = New Point(486, 154)
        Button_divide.Name = "Button_divide"
        Button_divide.Size = New Size(75, 23)
        Button_divide.TabIndex = 14
        Button_divide.Text = "/"
        Button_divide.UseVisualStyleBackColor = True
        ' 
        ' TextBox_Result
        ' 
        TextBox_Result.Location = New Point(369, 183)
        TextBox_Result.Name = "TextBox_Result"
        TextBox_Result.ReadOnly = True
        TextBox_Result.Size = New Size(192, 23)
        TextBox_Result.TabIndex = 15
        TextBox_Result.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button_back
        ' 
        Button_back.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button_back.Location = New Point(12, 12)
        Button_back.Name = "Button_back"
        Button_back.Size = New Size(75, 23)
        Button_back.TabIndex = 16
        Button_back.Text = "BACK"
        Button_back.UseVisualStyleBackColor = True
        ' 
        ' Button_and
        ' 
        Button_and.Location = New Point(627, 94)
        Button_and.Name = "Button_and"
        Button_and.Size = New Size(75, 23)
        Button_and.TabIndex = 17
        Button_and.Text = "AND"
        Button_and.UseVisualStyleBackColor = True
        ' 
        ' Button_or
        ' 
        Button_or.Location = New Point(627, 137)
        Button_or.Name = "Button_or"
        Button_or.Size = New Size(75, 23)
        Button_or.TabIndex = 18
        Button_or.Text = "OR"
        Button_or.UseVisualStyleBackColor = True
        ' 
        ' Button_not
        ' 
        Button_not.Location = New Point(627, 180)
        Button_not.Name = "Button_not"
        Button_not.Size = New Size(75, 23)
        Button_not.TabIndex = 19
        Button_not.Text = "NOT"
        Button_not.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(642, 64)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 15)
        Label6.TabIndex = 20
        Label6.Text = "IF ELSE"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(859, 97)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 21
        ' 
        ' Label_passdata
        ' 
        Label_passdata.AutoSize = True
        Label_passdata.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label_passdata.Location = New Point(461, 9)
        Label_passdata.Name = "Label_passdata"
        Label_passdata.Size = New Size(214, 32)
        Label_passdata.TabIndex = 22
        Label_passdata.Text = "Data from form 1"
        ' 
        ' TextBox_USER
        ' 
        TextBox_USER.Location = New Point(184, 339)
        TextBox_USER.Name = "TextBox_USER"
        TextBox_USER.Size = New Size(149, 23)
        TextBox_USER.TabIndex = 23
        ' 
        ' TextBox_PASS
        ' 
        TextBox_PASS.Location = New Point(184, 385)
        TextBox_PASS.Name = "TextBox_PASS"
        TextBox_PASS.Size = New Size(149, 23)
        TextBox_PASS.TabIndex = 24
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(184, 426)
        Button1.Name = "Button1"
        Button1.Size = New Size(149, 23)
        Button1.TabIndex = 25
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(120, 347)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 15)
        Label7.TabIndex = 26
        Label7.Text = "username"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(120, 393)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 15)
        Label8.TabIndex = 27
        Label8.Text = "password"
        ' 
        ' TextBox_id
        ' 
        TextBox_id.Location = New Point(184, 298)
        TextBox_id.Name = "TextBox_id"
        TextBox_id.Size = New Size(100, 23)
        TextBox_id.TabIndex = 28
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(120, 298)
        Label9.Name = "Label9"
        Label9.Size = New Size(17, 15)
        Label9.TabIndex = 29
        Label9.Text = "id"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(391, 298)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(394, 150)
        DataGridView1.TabIndex = 30
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(184, 455)
        Button2.Name = "Button2"
        Button2.Size = New Size(149, 23)
        Button2.TabIndex = 31
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(184, 484)
        Button3.Name = "Button3"
        Button3.Size = New Size(149, 23)
        Button3.TabIndex = 32
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' MainPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1153, 606)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Label9)
        Controls.Add(TextBox_id)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(TextBox_PASS)
        Controls.Add(TextBox_USER)
        Controls.Add(Label_passdata)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Button_not)
        Controls.Add(Button_or)
        Controls.Add(Button_and)
        Controls.Add(Button_back)
        Controls.Add(TextBox_Result)
        Controls.Add(Button_divide)
        Controls.Add(Button_multi)
        Controls.Add(Button_minus)
        Controls.Add(Button_add)
        Controls.Add(TextBox_num2)
        Controls.Add(TextBox_num1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button_show)
        Controls.Add(TextBox_age)
        Controls.Add(TextBox_lname)
        Controls.Add(TextBox_fname)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "MainPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainPage"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_fname As TextBox
    Friend WithEvents TextBox_lname As TextBox
    Friend WithEvents TextBox_age As TextBox
    Friend WithEvents Button_show As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_num1 As TextBox
    Friend WithEvents TextBox_num2 As TextBox
    Friend WithEvents Button_add As Button
    Friend WithEvents Button_minus As Button
    Friend WithEvents Button_multi As Button
    Friend WithEvents Button_divide As Button
    Friend WithEvents TextBox_Result As TextBox
    Friend WithEvents Button_back As Button
    Friend WithEvents Button_and As Button
    Friend WithEvents Button_or As Button
    Friend WithEvents Button_not As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label_passdata As Label
    Friend WithEvents TextBox_USER As TextBox
    Friend WithEvents TextBox_PASS As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_id As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
