'Client Side
Imports System.Net

Public Class Form1

    Dim TCPClientz As Sockets.TcpClient
    Dim TCPClientStream As Sockets.NetworkStream

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim sendbytes() As Byte = System.Text.Encoding.ASCII.GetBytes(TextBox2.Text)
        TCPClientz.Client.Send(sendbytes)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        TCPClientz = New Sockets.TcpClient(TextBox1.Text, 1000)
        Timer1.Enabled = True
        TCPClientStream = TCPClientz.GetStream()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If TCPClientStream.DataAvailable = True Then
            Dim rcvbytes(TCPClientz.ReceiveBufferSize) As Byte
            TCPClientStream.Read(rcvbytes, 0, CInt(TCPClientz.ReceiveBufferSize))
            TextBox3.Text = System.Text.Encoding.ASCII.GetString(rcvbytes)
        End If

    End Sub
End Class

'Server IP locally 192.168.0.106
'Server IP Globally is 123.456.789.012 wwww.whatismyip.com
'server router > port forward 1000 to 192.168.0.106