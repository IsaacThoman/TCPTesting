Imports System.Net

Public Class Form1

    Dim TCPClient1 As Sockets.TcpClient
    Dim TCPClientStream As Sockets.NetworkStream

    Private Sub connectButton_click(sender As Object, e As EventArgs) Handles connectButton.Click
        TCPClient1 = New Sockets.TcpClient(inputServerIP.Text, 1000)
        Timer1.Enabled = True
        TCPClientStream = TCPClient1.GetStream()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If TCPClientStream.DataAvailable = True Then
            Dim rcvBytes(TCPClient1.ReceiveBufferSize) As Byte
            TCPClientStream.Read(rcvBytes, 0, CInt(TCPClient1.ReceiveBufferSize))
            outData.Text = System.Text.Encoding.ASCII.GetString(rcvBytes)
        End If
    End Sub
End Class
