<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_load_picture = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_save_picture = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_search_picture = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.pdf_save = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.pdf_search = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_load_picture
        '
        Me.btn_load_picture.Location = New System.Drawing.Point(806, 38)
        Me.btn_load_picture.Name = "btn_load_picture"
        Me.btn_load_picture.Size = New System.Drawing.Size(210, 30)
        Me.btn_load_picture.TabIndex = 0
        Me.btn_load_picture.Text = "Bild laden"
        Me.btn_load_picture.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 450)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_save_picture
        '
        Me.btn_save_picture.Location = New System.Drawing.Point(806, 75)
        Me.btn_save_picture.Name = "btn_save_picture"
        Me.btn_save_picture.Size = New System.Drawing.Size(210, 30)
        Me.btn_save_picture.TabIndex = 2
        Me.btn_save_picture.Text = "Bild speichern"
        Me.btn_save_picture.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(807, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(209, 23)
        Me.TextBox1.TabIndex = 3
        '
        'btn_search_picture
        '
        Me.btn_search_picture.Location = New System.Drawing.Point(809, 204)
        Me.btn_search_picture.Name = "btn_search_picture"
        Me.btn_search_picture.Size = New System.Drawing.Size(210, 30)
        Me.btn_search_picture.TabIndex = 4
        Me.btn_search_picture.Text = "Bilder suchen"
        Me.btn_search_picture.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(809, 175)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(209, 23)
        Me.TextBox2.TabIndex = 5
        '
        'pdf_save
        '
        Me.pdf_save.Location = New System.Drawing.Point(808, 374)
        Me.pdf_save.Name = "pdf_save"
        Me.pdf_save.Size = New System.Drawing.Size(210, 30)
        Me.pdf_save.TabIndex = 6
        Me.pdf_save.Text = "PDF speichern"
        Me.pdf_save.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(808, 345)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(209, 23)
        Me.TextBox3.TabIndex = 7
        '
        'pdf_search
        '
        Me.pdf_search.Location = New System.Drawing.Point(808, 410)
        Me.pdf_search.Name = "pdf_search"
        Me.pdf_search.Size = New System.Drawing.Size(210, 30)
        Me.pdf_search.TabIndex = 8
        Me.pdf_search.Text = "PDF suchen"
        Me.pdf_search.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 450)
        Me.Controls.Add(Me.pdf_search)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.pdf_save)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btn_search_picture)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_save_picture)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_load_picture)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_load_picture As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_save_picture As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_search_picture As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents pdf_save As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents pdf_search As Button
End Class
