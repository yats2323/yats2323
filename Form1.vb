Public Class Form1
    Dim tb1 As New DataTable("tb1")

    Private Sub btncompute_Click(sender As Object, e As EventArgs) Handles btncompute.Click
        Dim pt As Double
        Dim quiz As Double
        Dim practicalexam As Double
        Dim termgrade As Double

        pt = txtpt.Text
        quiz = txtquiz.Text
        practicalexam = txtmajor.Text

        termgrade = (pt * 0.2) + (quiz * 0.3) + (practicalexam * 0.5)
        txttermgrade.Text = termgrade

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtpt.Clear()
        txtquiz.Clear()
        txtmajor.Clear()
        txttermgrade.Clear()


    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim msg As String
        msg = MessageBox.Show("Do you want to save this grade?", "GRADING SYSTEM")
        If msg = DialogResult.Yes Then
            If cboterm.Text = "First Sem" Then
                txtmidtermgrade.Text = txttermgrade.Text
            ElseIf cboterm.Text = "Second Sem" Then
                txtfinalgrade.Text = txttermgrade.Text
            Else
                MsgBox("Please select term", MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnave_Click(sender As Object, e As EventArgs) Handles btnave.Click
        Dim mtgrade As Double
        Dim fgrade As Double
        Dim finalave As Double

        mtgrade = txtmidtermgrade.Text
        fgrade = txtfinalgrade.Text

        finalave = (mtgrade * 0.5) + (fgrade * 0.5)
        txtfinalave.Text = finalave

        If txtfinalave.Text >= 96 And txtfinalave.Text <= 100 Then
            txtlettergrade.Text = "A+"
        ElseIf txtfinalave.Text >= 91 And txtfinalave.Text <= 95 Then
            txtlettergrade.Text = "A"
        ElseIf txtfinalave.Text >= 86 And txtfinalave.Text <= 90 Then
            txtlettergrade.Text = "A-"
        ElseIf txtfinalave.Text >= 81 And txtfinalave.Text <= 85 Then
            txtlettergrade.Text = "B"
        ElseIf txtfinalave.Text >= 76 And txtfinalave.Text <= 80 Then
            txtlettergrade.Text = "B-"
        ElseIf txtfinalave.Text >= 71 And txtfinalave.Text <= 75 Then
            txtlettergrade.Text = "C+"
        ElseIf txtfinalave.Text >= 66 And txtfinalave.Text <= 70 Then
            txtlettergrade.Text = "C"
        ElseIf txtfinalave.Text >= 50 And txtfinalave.Text <= 60 Then
            txtlettergrade.Text = "C-"
        ElseIf txtfinalave.Text >= 50 And txtfinalave.Text <= 60 Then
            txtlettergrade.Text = "F"



        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb1.Columns.Add("StudentNumber", Type.GetType("System.Int32"))
        tb1.Columns.Add("LastName", Type.GetType("System.String"))
        tb1.Columns.Add("FirstName", Type.GetType("System.String"))
        tb1.Columns.Add("Subject", Type.GetType("System.String"))
        tb1.Columns.Add("Grade", Type.GetType("System.Double"))
        tb1.Columns.Add("Equivalent", Type.GetType("System.String"))
        dgvstudents.DataSource = tb1
    End Sub

    Private Sub btnadddata_Click(sender As Object, e As EventArgs) Handles btnadddata.Click
        tb1.Rows.Add(txtstudnum.Text, txtlastname.Text, txtfirstname.Text, textsubj.Text, txtfinalave.Text, txtlettergrade.Text)
        dgvstudents.DataSource = tb1
    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtstudnum.Clear()
        txtlastname.Clear()
        txtfirstname.Clear()
        textsubj.Clear()
        txtpt.Clear()
        txtquiz.Clear()
        txtmajor.Clear()
        txttermgrade.Clear()
        txtmidtermgrade.Clear()
        txtfinalgrade.Clear()
        txtfinalave.Clear()
        txtlettergrade.Clear()
    End Sub

    Private Sub dgvstudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvstudents.CellClick
        Dim index As Integer = e.RowIndex
        If index >= 0 Then
            Dim selected As DataGridViewRow = dgvstudents.Rows(index)
            txtstudnum.Text = selected.Cells(0).Value.ToString()
            txtlastname.Text = selected.Cells(1).Value.ToString()
            txtfirstname.Text = selected.Cells(2).Value.ToString()
            textsubj.Text = selected.Cells(3).Value.ToString()
            txtfinalave.Text = selected.Cells(4).Value.ToString()
            txtlettergrade.Text = selected.Cells(5).Value.ToString()
        End If
    End Sub



    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        ' Ensure a row is selected
        If dgvstudents.SelectedRows.Count > 0 Then
            Dim index As Integer = dgvstudents.SelectedRows(0).Index

            ' Get the selected row
            Dim newdata As DataGridViewRow = dgvstudents.Rows(index)

            ' Update the selected row with new values
            newdata.Cells(0).Value = txtstudnum.Text
            newdata.Cells(1).Value = txtlastname.Text
            newdata.Cells(2).Value = txtfirstname.Text
            newdata.Cells(3).Value = textsubj.Text
            newdata.Cells(4).Value = txtfinalave.Text
            newdata.Cells(5).Value = txtlettergrade.Text

        End If

    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        If dgvstudents.SelectedRows.Count > 0 Then
            Dim index As Integer = dgvstudents.SelectedRows(0).Index

        End If
    End Sub
End Class
