Imports System.IO

Public Class Form1
    Dim h As New Helper
    Dim dbc As New DbConnector

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_load_picture_Click(sender As Object, e As EventArgs) Handles btn_load_picture.Click
        ' hole den Dateipfad
        Dim filePath As String = h.GetImagePath()

        ' lade das Bild
        Dim image1 = Image.FromFile(filePath)
        PictureBox1.Image = image1
    End Sub

    Private Sub btn_save_picture_Click(sender As Object, e As EventArgs) Handles btn_save_picture.Click
        Dim name As String = TextBox1.Text
        Dim img As Image = PictureBox1.Image


        ' erstelle ein Bytearray aus dem oben geladenen Bild
        Dim imageByteArray = h.ImageToByteArray(img)


        ' Speichere das ByteArray mit Namen in die nötige Tablle ab
        dbc.connect(name, imageByteArray)


    End Sub


    ' Suche
    Private Sub btn_search_picture_Click(sender As Object, e As EventArgs) Handles btn_search_picture.Click
        Dim searchQuery As String = TextBox2.Text

        Dim imgArray As Byte()
        Dim img As Image



        ' Verbinde dich mit der Datenbank und suche nach dem eingegebenen Namen
        'dbc.search(searchQuery)

        'ByteArray wird aus Tabelle ausgelesen wo Name = Textinput
        imgArray = dbc.search(searchQuery)


        ' Konvertiere das ByteArray zurück zu einem Bild
        img = h.ByteArrayToImage(imgArray)

        ' Setze das Bild in die PictureBox
        PictureBox1.Image = img
    End Sub


    'PDF HANDLING


    Private Sub pdf_save_Click(sender As Object, e As EventArgs) Handles pdf_save.Click
        Dim PdfPath As String
        Dim pdfByteArray As Byte()
        Dim name As String

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = Nothing
    End Sub
End Class
