Imports System.IO
Imports WinFormsApp2
Public Class Helper
    Public Function GetImagePath() As String
        Dim fileContent = String.Empty
        Dim filePath = String.Empty
        Dim result As DialogResult = Form1.OpenFileDialog1.ShowDialog()
        Dim ImagePath As String = ""

        If result = Windows.Forms.DialogResult.OK Then

            ' lese Dateipfad 
            ImagePath = Form1.OpenFileDialog1.FileName

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
