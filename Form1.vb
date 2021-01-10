Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' hole den Dateipfad
        Dim filePath As String = GetImagePath()

        ' lade das Bild
        Dim image1 = Image.FromFile(filePath)


        ' erstelle ein Bytearray aus dem oben geladenen Bild
        Dim imageByteArray = ImageToByteArray(image1)

        ' hier kann jetzt eingegriffen werden und das ByteArray in die Datenbank geschrieben
        ' werden um es später wieder auslesen zu können


        ' baue aus dem Bytearray wieder das vollständige Bild und lade es in die PictureBox
        PictureBox1.Image = ByteArrayToImage(imageByteArray)


    End Sub

    Public Function GetImagePath() As String
        Dim fileContent = String.Empty
        Dim filePath = String.Empty
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        Dim ImagePath As String = ""

        If result = Windows.Forms.DialogResult.OK Then

            ' lese Dateipfad 
            ImagePath = OpenFileDialog1.FileName

        End If

        ' gebe Dateipfad zurück
        Return ImagePath
    End Function


    'zerlege das bild in bytes und schreibe es in ein array
    Public Function ImageToByteArray(image1 As Image) As Byte()
        Using ms As New MemoryStream()
            image1.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
        End Using
    End Function


    ' lese das array an bytes und mache daraus wieder ein bild
    Public Function ByteArrayToImage(byteArray As Byte()) As Image
        Using ms = New MemoryStream(byteArray)
            Dim returnImage = Image.FromStream(ms)
            Return returnImage
        End Using
    End Function

End Class
