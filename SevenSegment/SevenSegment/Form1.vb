Public Class Form1
    Dim x As Integer = 0

    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Private Sub Zero()
        TextBox1.BackColor = Color.Turquoise
        TextBox2.BackColor = Color.Turquoise
        TextBox3.BackColor = Color.Turquoise
        TextBox4.BackColor = Color.Turquoise
        TextBox5.BackColor = Color.Turquoise
        TextBox6.BackColor = Color.Turquoise
        TextBox10.BackColor = Color.Turquoise
        TextBox11.BackColor = Color.Turquoise
        TextBox12.BackColor = Color.White
        TextBox13.BackColor = Color.White
        TextBox14.BackColor = Color.White
        TextBox15.BackColor = Color.Turquoise
        TextBox16.BackColor = Color.Turquoise
        TextBox20.BackColor = Color.Turquoise
        TextBox21.BackColor = Color.Turquoise
        TextBox22.BackColor = Color.Turquoise
        TextBox23.BackColor = Color.Turquoise
        TextBox24.BackColor = Color.Turquoise
        TextBox25.BackColor = Color.Turquoise
        x += 1
    End Sub


    Private Sub One()
        TextBox1.BackColor = Color.White
        TextBox2.BackColor = Color.White
        TextBox3.BackColor = Color.White
        TextBox4.BackColor = Color.White
        TextBox5.BackColor = Color.Turquoise
        TextBox6.BackColor = Color.White
        TextBox10.BackColor = Color.Turquoise
        TextBox11.BackColor = Color.White
        TextBox12.BackColor = Color.White
        TextBox13.BackColor = Color.White
        TextBox14.BackColor = Color.White
        TextBox15.BackColor = Color.Turquoise
        TextBox16.BackColor = Color.White
        TextBox20.BackColor = Color.Turquoise
        TextBox21.BackColor = Color.White
        TextBox22.BackColor = Color.White
        TextBox23.BackColor = Color.White
        TextBox24.BackColor = Color.White
        TextBox25.BackColor = Color.Turquoise
        x += 1
    End Sub
    Private Sub Two()
        TextBox1.BackColor = Color.Turquoise
        TextBox2.BackColor = Color.Turquoise
        TextBox3.BackColor = Color.Turquoise
        TextBox4.BackColor = Color.Turquoise
        TextBox11.BackColor = Color.Turquoise
        TextBox12.BackColor = Color.Turquoise
        TextBox13.BackColor = Color.Turquoise
        TextBox14.BackColor = Color.Turquoise
        TextBox16.BackColor = Color.Turquoise
        TextBox20.BackColor = Color.White
        TextBox21.BackColor = Color.Turquoise
        TextBox22.BackColor = Color.Turquoise
        TextBox23.BackColor = Color.Turquoise
        TextBox24.BackColor = Color.Turquoise
        x += 1
    End Sub

    Private Sub Three()
        TextBox16.BackColor = Color.White
        TextBox20.BackColor = Color.Turquoise
        x += 1
    End Sub

    Private Sub Four()
        TextBox2.BackColor = Color.White
        TextBox3.BackColor = Color.White
        TextBox4.BackColor = Color.White
        TextBox6.BackColor = Color.Turquoise
        TextBox21.BackColor = Color.White
        TextBox22.BackColor = Color.White
        TextBox23.BackColor = Color.White
        TextBox24.BackColor = Color.White
        x += 1
    End Sub
    Private Sub Five()
        TextBox2.BackColor = Color.Turquoise
        TextBox3.BackColor = Color.Turquoise
        TextBox4.BackColor = Color.Turquoise
        TextBox10.BackColor = Color.White
        TextBox20.BackColor = Color.Turquoise
        TextBox21.BackColor = Color.Turquoise
        TextBox22.BackColor = Color.Turquoise
        TextBox23.BackColor = Color.Turquoise
        TextBox24.BackColor = Color.Turquoise
        x += 1
    End Sub
    Private Sub Six()
        TextBox16.BackColor = Color.Turquoise
        x += 1
    End Sub
    Private Sub Seven()
        TextBox6.BackColor = Color.White
        TextBox10.BackColor = Color.Turquoise
        TextBox11.BackColor = Color.White
        TextBox12.BackColor = Color.White
        TextBox13.BackColor = Color.White
        TextBox14.BackColor = Color.White
        TextBox16.BackColor = Color.White
        TextBox21.BackColor = Color.White
        TextBox22.BackColor = Color.White
        TextBox23.BackColor = Color.White
        TextBox24.BackColor = Color.White
        x += 1
    End Sub
    Private Sub Eight()
        TextBox6.BackColor = Color.Turquoise
        TextBox11.BackColor = Color.Turquoise
        TextBox12.BackColor = Color.Turquoise
        TextBox13.BackColor = Color.Turquoise
        TextBox14.BackColor = Color.Turquoise
        TextBox16.BackColor = Color.Turquoise
        TextBox20.BackColor = Color.Turquoise
        TextBox21.BackColor = Color.Turquoise
        TextBox22.BackColor = Color.Turquoise
        TextBox23.BackColor = Color.Turquoise
        TextBox24.BackColor = Color.Turquoise
        x += 1
    End Sub
    Private Sub Nine()
        TextBox16.BackColor = Color.White
        x = 0
    End Sub
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint
        While x < 10
            Zero()
            wait(1000)
            One()
            wait(1000)
            Two()
            wait(1000)
            Three()
            wait(1000)
            Four()
            wait(1000)
            Five()
            wait(1000)
            Six()
            wait(1000)
            Seven()
            wait(1000)
            Eight()
            wait(1000)
            Nine()
            wait(1000)
        End While
    End Sub
End Class
