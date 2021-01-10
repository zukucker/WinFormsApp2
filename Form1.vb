Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filePath As String = GetImagePath()

        Dim image1 = Image.FromFile(filePath)

        Dim imageByteArray = ImageToByteArray(image1)


        PictureBox1.Image = ByteArrayToImage(imageByteArray)


    End Sub

    Public Function GetImagePath() As String
        Dim fileContent = String.Empty
        Dim filePath = String.Empty
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        Dim ImagePath As String = ""
        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then

            ' Get the file name.
            ImagePath = OpenFileDialog1.FileName

        End If

        Return ImagePath
    End Function

    Public Function ImageToByteArray(image1 As Image) As Byte()
        Using ms As New MemoryStream()
            image1.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
        End Using
    End Function

    Public Function ByteArrayToImage(byteArray As Byte()) As Image
        Using ms = New MemoryStream(byteArray)
            Dim returnImage = Image.FromStream(ms)

            Return returnImage

        End Using
    End Function

End Class
