Public Class Form1

    Public Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New MyObjectClass
        Dim a, b As Double
        a = 0
        b = 0
        If TextBox1.Text = "" Or TextBox1.Text = "." Then
            a = 0
        Else

            a = TextBox1.Text
        End If
        If TextBox2.Text = "" Or TextBox2.Text = "." Then
            b = 0
        Else
            b = TextBox2.Text
        End If

        If R1.Checked = True Then
            Label1.Text = obj.Plus(a, b)
        ElseIf R2.Checked = True Then
            Label1.Text = obj.Minus(a, b)
        ElseIf R3.Checked = True Then
            Label1.Text = obj.Multiply(a, b)
        ElseIf R4.Checked = True Then
            If b = 0 Then
                Label1.Text = "Error!"
            Else
                Label1.Text = obj.Division(a, b)
            End If
        Else
            MsgBox("Wrong Input")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label1.Text = ""
        If R1.Checked = True Then
            R1.Checked = False
        ElseIf R2.Checked = True Then
            R2.Checked = False
        ElseIf R3.Checked = True Then
            R3.Checked = False
        ElseIf R4.Checked = True Then
            R4.Checked = False
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            MessageBox.Show("Allow only positive numbers")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            MessageBox.Show("Allow only positive numbers")
        End If
    End Sub


End Class
