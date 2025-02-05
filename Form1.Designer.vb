<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        textsubj = New TextBox()
        txtfirstname = New TextBox()
        txtlastname = New TextBox()
        txtstudnum = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        btnsave = New Button()
        Label9 = New Label()
        txttermgrade = New TextBox()
        btnclear = New Button()
        btncompute = New Button()
        Label8 = New Label()
        txtmajor = New TextBox()
        txtquiz = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        txtpt = New TextBox()
        cboterm = New ComboBox()
        Label5 = New Label()
        Panel3 = New Panel()
        Label13 = New Label()
        txtlettergrade = New TextBox()
        Label12 = New Label()
        txtfinalave = New TextBox()
        btnave = New Button()
        Label11 = New Label()
        txtfinalgrade = New TextBox()
        txtmidtermgrade = New TextBox()
        Label10 = New Label()
        btnadddata = New Button()
        btnupdate = New Button()
        btndel = New Button()
        btnclr = New Button()
        dgvstudents = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvstudents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Chocolate
        Panel1.Controls.Add(textsubj)
        Panel1.Controls.Add(txtfirstname)
        Panel1.Controls.Add(txtlastname)
        Panel1.Controls.Add(txtstudnum)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(13, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(839, 147)
        Panel1.TabIndex = 0
        ' 
        ' textsubj
        ' 
        textsubj.Location = New Point(103, 117)
        textsubj.Name = "textsubj"
        textsubj.Size = New Size(155, 23)
        textsubj.TabIndex = 7
        ' 
        ' txtfirstname
        ' 
        txtfirstname.Location = New Point(103, 82)
        txtfirstname.Name = "txtfirstname"
        txtfirstname.Size = New Size(155, 23)
        txtfirstname.TabIndex = 6
        ' 
        ' txtlastname
        ' 
        txtlastname.Location = New Point(103, 43)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(155, 23)
        txtlastname.TabIndex = 5
        ' 
        ' txtstudnum
        ' 
        txtstudnum.Location = New Point(103, 10)
        txtstudnum.Name = "txtstudnum"
        txtstudnum.Size = New Size(155, 23)
        txtstudnum.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 15)
        Label4.TabIndex = 3
        Label4.Text = "Subject"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 2
        Label3.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 1
        Label2.Text = "Last Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(-1, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 15)
        Label1.TabIndex = 0
        Label1.Text = "Student Number"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Chocolate
        Panel2.Controls.Add(btnsave)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(txttermgrade)
        Panel2.Controls.Add(btnclear)
        Panel2.Controls.Add(btncompute)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(txtmajor)
        Panel2.Controls.Add(txtquiz)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(txtpt)
        Panel2.Controls.Add(cboterm)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(13, 180)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(420, 317)
        Panel2.TabIndex = 1
        ' 
        ' btnsave
        ' 
        btnsave.Location = New Point(103, 275)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(156, 23)
        btnsave.TabIndex = 19
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(25, 246)
        Label9.Name = "Label9"
        Label9.Size = New Size(67, 15)
        Label9.TabIndex = 18
        Label9.Text = "Term Grade"
        ' 
        ' txttermgrade
        ' 
        txttermgrade.Enabled = False
        txttermgrade.Location = New Point(103, 243)
        txttermgrade.Name = "txttermgrade"
        txttermgrade.Size = New Size(155, 23)
        txttermgrade.TabIndex = 17
        ' 
        ' btnclear
        ' 
        btnclear.Location = New Point(184, 199)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(75, 23)
        btnclear.TabIndex = 16
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = True
        ' 
        ' btncompute
        ' 
        btncompute.Location = New Point(103, 199)
        btncompute.Name = "btncompute"
        btncompute.Size = New Size(75, 23)
        btncompute.TabIndex = 15
        btncompute.Text = "Compute"
        btncompute.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(10, 163)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 15)
        Label8.TabIndex = 14
        Label8.Text = "Practical Exam"
        ' 
        ' txtmajor
        ' 
        txtmajor.Location = New Point(103, 160)
        txtmajor.Name = "txtmajor"
        txtmajor.Size = New Size(155, 23)
        txtmajor.TabIndex = 13
        ' 
        ' txtquiz
        ' 
        txtquiz.Location = New Point(103, 115)
        txtquiz.Name = "txtquiz"
        txtquiz.Size = New Size(155, 23)
        txtquiz.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(25, 115)
        Label7.Name = "Label7"
        Label7.Size = New Size(31, 15)
        Label7.TabIndex = 11
        Label7.Text = "Quiz"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(29, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(20, 15)
        Label6.TabIndex = 10
        Label6.Text = "PT"
        ' 
        ' txtpt
        ' 
        txtpt.Location = New Point(103, 67)
        txtpt.Name = "txtpt"
        txtpt.Size = New Size(155, 23)
        txtpt.TabIndex = 8
        ' 
        ' cboterm
        ' 
        cboterm.FormattingEnabled = True
        cboterm.Items.AddRange(New Object() {"First Sem", "Second Sem"})
        cboterm.Location = New Point(103, 22)
        cboterm.Name = "cboterm"
        cboterm.Size = New Size(155, 23)
        cboterm.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 25)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 15)
        Label5.TabIndex = 8
        Label5.Text = "Term"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Chocolate
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(txtlettergrade)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(txtfinalave)
        Panel3.Controls.Add(btnave)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(txtfinalgrade)
        Panel3.Controls.Add(txtmidtermgrade)
        Panel3.Controls.Add(Label10)
        Panel3.Location = New Point(439, 180)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(420, 317)
        Panel3.TabIndex = 2
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(40, 220)
        Label13.Name = "Label13"
        Label13.Size = New Size(74, 15)
        Label13.TabIndex = 26
        Label13.Text = "Letter Grade:"
        ' 
        ' txtlettergrade
        ' 
        txtlettergrade.Location = New Point(194, 212)
        txtlettergrade.Name = "txtlettergrade"
        txtlettergrade.Size = New Size(155, 23)
        txtlettergrade.TabIndex = 25
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(40, 171)
        Label12.Name = "Label12"
        Label12.Size = New Size(81, 15)
        Label12.TabIndex = 24
        Label12.Text = "Final Average:"
        ' 
        ' txtfinalave
        ' 
        txtfinalave.Location = New Point(194, 163)
        txtfinalave.Name = "txtfinalave"
        txtfinalave.Size = New Size(155, 23)
        txtfinalave.TabIndex = 23
        ' 
        ' btnave
        ' 
        btnave.Location = New Point(193, 114)
        btnave.Name = "btnave"
        btnave.Size = New Size(156, 23)
        btnave.TabIndex = 20
        btnave.Text = "Average"
        btnave.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(40, 78)
        Label11.Name = "Label11"
        Label11.Size = New Size(66, 15)
        Label11.TabIndex = 22
        Label11.Text = "Final Grade"
        ' 
        ' txtfinalgrade
        ' 
        txtfinalgrade.Location = New Point(194, 70)
        txtfinalgrade.Name = "txtfinalgrade"
        txtfinalgrade.Size = New Size(155, 23)
        txtfinalgrade.TabIndex = 21
        ' 
        ' txtmidtermgrade
        ' 
        txtmidtermgrade.Location = New Point(194, 27)
        txtmidtermgrade.Name = "txtmidtermgrade"
        txtmidtermgrade.Size = New Size(155, 23)
        txtmidtermgrade.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(40, 30)
        Label10.Name = "Label10"
        Label10.Size = New Size(106, 15)
        Label10.TabIndex = 20
        Label10.Text = "Second Sem Grade"
        ' 
        ' btnadddata
        ' 
        btnadddata.Location = New Point(26, 521)
        btnadddata.Name = "btnadddata"
        btnadddata.Size = New Size(121, 55)
        btnadddata.TabIndex = 20
        btnadddata.Text = "Add Data"
        btnadddata.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(168, 521)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(121, 55)
        btnupdate.TabIndex = 21
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btndel
        ' 
        btndel.Location = New Point(312, 521)
        btndel.Name = "btndel"
        btndel.Size = New Size(121, 55)
        btndel.TabIndex = 22
        btndel.Text = "Delete"
        btndel.UseVisualStyleBackColor = True
        ' 
        ' btnclr
        ' 
        btnclr.Location = New Point(455, 521)
        btnclr.Name = "btnclr"
        btnclr.Size = New Size(121, 55)
        btnclr.TabIndex = 23
        btnclr.Text = "Clear"
        btnclr.UseVisualStyleBackColor = True
        ' 
        ' dgvstudents
        ' 
        dgvstudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvstudents.Location = New Point(26, 582)
        dgvstudents.Name = "dgvstudents"
        dgvstudents.Size = New Size(826, 150)
        dgvstudents.TabIndex = 24
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(864, 753)
        Controls.Add(dgvstudents)
        Controls.Add(btnclr)
        Controls.Add(btndel)
        Controls.Add(btnupdate)
        Controls.Add(btnadddata)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Grading System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvstudents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents textsubj As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtstudnum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtmajor As TextBox
    Friend WithEvents txtquiz As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtpt As TextBox
    Friend WithEvents cboterm As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents btncompute As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txttermgrade As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtlettergrade As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtfinalave As TextBox
    Friend WithEvents btnave As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtfinalgrade As TextBox
    Friend WithEvents txtmidtermgrade As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnadddata As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnclr As Button
    Friend WithEvents dgvstudents As DataGridView

End Class
