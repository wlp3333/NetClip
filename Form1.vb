Public Class Form1
    Dim np As Int16
    Dim fd As Int16
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsL2.Text = "Waiting..."
        np = Val(txtDetectFreq.Text())
        fd = Val(txtNetworkPort.Text())
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        tsL2.Text = "Button SEND clicked..."
    End Sub

    Private Sub btnReceive_Click(sender As Object, e As EventArgs) Handles btnReceive.Click
        tsL2.Text = "Button RECEIVE clicked..."
    End Sub
End Class
