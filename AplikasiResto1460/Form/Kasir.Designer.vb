<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kasir))
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.DGKasir = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtIDKasir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        CType(Me.DGKasir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCari.BackgroundImage = CType(resources.GetObject("btnCari.BackgroundImage"), System.Drawing.Image)
        Me.btnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCari.FlatAppearance.BorderSize = 0
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Location = New System.Drawing.Point(194, 22)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(30, 31)
        Me.btnCari.TabIndex = 11
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(6, 27)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(182, 23)
        Me.txtCari.TabIndex = 10
        '
        'DGKasir
        '
        Me.DGKasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKasir.Location = New System.Drawing.Point(62, 306)
        Me.DGKasir.Name = "DGKasir"
        Me.DGKasir.RowTemplate.Height = 25
        Me.DGKasir.Size = New System.Drawing.Size(262, 110)
        Me.DGKasir.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 59)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan Nama Kategori yang di cari"
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnHapus.BackgroundImage = CType(resources.GetObject("btnHapus.BackgroundImage"), System.Drawing.Image)
        Me.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Location = New System.Drawing.Point(347, 266)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(45, 43)
        Me.btnHapus.TabIndex = 29
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnBatal.BackgroundImage = CType(resources.GetObject("btnBatal.BackgroundImage"), System.Drawing.Image)
        Me.btnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Location = New System.Drawing.Point(347, 217)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(45, 43)
        Me.btnBatal.TabIndex = 28
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSimpan.BackgroundImage = CType(resources.GetObject("btnSimpan.BackgroundImage"), System.Drawing.Image)
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Location = New System.Drawing.Point(347, 168)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(45, 43)
        Me.btnSimpan.TabIndex = 27
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnUbah.BackgroundImage = CType(resources.GetObject("btnUbah.BackgroundImage"), System.Drawing.Image)
        Me.btnUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUbah.FlatAppearance.BorderSize = 0
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.Location = New System.Drawing.Point(347, 119)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(45, 43)
        Me.btnUbah.TabIndex = 26
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnTambah.BackgroundImage = CType(resources.GetObject("btnTambah.BackgroundImage"), System.Drawing.Image)
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Location = New System.Drawing.Point(347, 69)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(45, 43)
        Me.btnTambah.TabIndex = 25
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(145, 156)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(179, 23)
        Me.txtPassword.TabIndex = 23
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(145, 127)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(179, 23)
        Me.txtUserID.TabIndex = 22
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(145, 98)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(179, 23)
        Me.txtNama.TabIndex = 21
        '
        'txtIDKasir
        '
        Me.txtIDKasir.Location = New System.Drawing.Point(145, 69)
        Me.txtIDKasir.Name = "txtIDKasir"
        Me.txtIDKasir.Size = New System.Drawing.Size(179, 23)
        Me.txtIDKasir.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(62, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(62, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "User ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(62, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nama Kasir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(62, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ID Kasir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(62, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Level Kasir"
        '
        'cmbLevel
        '
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Location = New System.Drawing.Point(145, 185)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(179, 23)
        Me.cmbLevel.TabIndex = 33
        '
        'Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 450)
        Me.Controls.Add(Me.cmbLevel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGKasir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtIDKasir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Kasir"
        Me.Text = "Form Kasir"
        CType(Me.DGKasir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents DGKasir As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtIDKasir As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbLevel As ComboBox
End Class
