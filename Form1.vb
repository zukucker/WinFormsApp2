Imports System.IO

Public Class Form1
    Private Sub btn_load_picture_Click(sender As Object, e As EventArgs) Handles btn_load_picture.Click
        ' hole den Dateipfad
        Dim filePath As String = GetImagePath()

        ' lade das Bild
        Dim image1 = Image.FromFile(filePath)
        'PictureBox1.Image = image1
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_save_picture_Click(sender As Object, e As EventArgs) Handles btn_save_picture.Click
        Dim name As String = TextBox1.Text
        Dim img As Image = PictureBox1.Image
        Dim dbc As New DbConnector()

        ' erstelle ein Bytearray aus dem oben geladenen Bild
        Dim imageByteArray = ImageToByteArray(img)


        ' Speichere das ByteArray mit Namen in die nötige Tablle ab
        dbc.connect(name, imageByteArray)


    End Sub


    ' Suche
    Private Sub btn_search_picture_Click(sender As Object, e As EventArgs) Handles btn_search_picture.Click
        Dim searchQuery As String = TextBox2.Text
        Dim dbc As New DbConnector()
        Dim imgArray As Byte()
        Dim img As Image



        ' Verbinde dich mit der Datenbank und suche nach dem eingegebenen Namen
        'dbc.search(searchQuery)

        'ByteArray wird aus Tabelle ausgelesen wo Name = Textinput
        imgArray = dbc.search(searchQuery)


        ' Konvertiere das ByteArray zurück zu einem Bild
        img = ByteArrayToImage(imgArray)

        ' Setze das Bild in die PictureBox
        PictureBox1.Image = img
    End Sub


    'PDF HANDLING


    Private Sub pdf_save_Click(sender As Object, e As EventArgs) Handles pdf_save.Click
        Dim PdfPath As String
        Dim pdfByteArray As Byte()
        Dim name As String
        Dim dbc As New DbConnector
        Try
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()

            name = TextBox3.Text
            If result = Windows.Forms.DialogResult.OK Then

                ' lese Dateipfad 
                PdfPath = OpenFileDialog1.FileName

            End If
            pdfByteArray = File.ReadAllBytes(PdfPath)

            dbc.connect(name, pdfByteArray)
        Catch ex As Exception
            MessageBox.Show("Fehler beim speichern des PDF's " + ex.Message)
        End Try

    End Sub

    Private Sub pdf_search_Click(sender As Object, e As EventArgs) Handles pdf_search.Click
        Dim name As String
        Dim dbc As New DbConnector
        Dim fileName As String = "c:\users\alexb\desktop\test.pdf"
        Dim byteArray As Byte()
        Try
            name = TextBox3.Text
            byteArray = dbc.search(name)

            File.WriteAllBytes(fileName, byteArray)
            MessageBox.Show("Pdf wurde gespeichert")
        Catch ex As Exception
            MessageBox.Show("Fehler beim lesen des PDF's" + ex.Message)
        End Try

    End Sub
End Class
