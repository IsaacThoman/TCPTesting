Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Dim TCPServer As Socket
    Dim TCPListener1 As TcpListener


    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click
        TCPListener1 = New TcpListener(IPAddress.Any, 1000)
        TCPListener1.Start()
        TCPServer = TCPListener1.AcceptSocket()
        TCPServer.Blocking = False

    End Sub

    Private Sub transmissionBox_TextChanged(sender As Object, e As EventArgs) Handles transmissionBox.TextChanged
        Dim sendBytes() As Byte = System.Text.Encoding.ASCII.GetBytes(transmissionBox.Text)
        TCPServer.Send(sendBytes)
    End Sub
End Class
