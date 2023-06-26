Public Class FrmTest
    Dim A As Integer
    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        'Dim ObjTest As New Form2
        'ObjTest.ShowDialog()
        TextBox1.BackColor = Color.Black
        TextBox1.ForeColor = Color.White
        TextBox3.ReadOnly = False

    End Sub
    Public Function Demo()

        Return 0
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseDown

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TextBox2.Focus()
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TextBox1.Focus()
        End If

    End Sub

    Private Sub FrmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblCount.Text = "Count :" + LstMonth.Items.Count.ToString()
    End Sub

    Private Sub LstMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstMonth.SelectedIndexChanged

    End Sub

    Private Sub LstMonth_Click(sender As Object, e As EventArgs) Handles LstMonth.Click
        LblSI.Text = "Selected Index : " + LstMonth.SelectedIndex.ToString()
        If LstMonth.SelectedValue IsNot Nothing Then
            LblSV.Text = "Selected Value : " + LstMonth.SelectedValue.ToString()
        End If

        TxtMonth.Text = LstMonth.SelectedItem.ToString()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim Ans
        Ans = MsgBox("Do you Wish to add Empty record ?", vbQuestion + vbYesNo, "Confirmation")
        If Ans = vbYes Then
            CbMonth.Items.Add(TxtMonth.Text)
            LstMonth.Items.Add(TxtMonth.Text)
            TxtMonth.Clear()
            LblCount.Text = "Count :" + LstMonth.Items.Count.ToString()
        End If

    End Sub

    Private Sub TxtMonth_TextChanged(sender As Object, e As EventArgs) Handles TxtMonth.TextChanged

    End Sub

    Private Sub TxtMonth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMonth.KeyPress
        If (Asc(e.KeyChar) = 13) Then
            If (TxtMonth.Text.Length > 0) Then
                LstMonth.Items.Add(TxtMonth.Text)
                TxtMonth.Clear()
                LblCount.Text = "Count :" + LstMonth.Items.Count.ToString()
            Else
                MsgBox("Please Enter a value to add", vbInformation, "Data Validation Error!")
            End If

        End If
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        LstMonth.Items.Remove(LstMonth.SelectedItem)
        LblSI.Text = "Selected Index : "
        LblCount.Text = "Count :" + LstMonth.Items.Count.ToString()
    End Sub
End Class
