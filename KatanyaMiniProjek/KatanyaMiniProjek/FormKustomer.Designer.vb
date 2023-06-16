<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKustomer
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDataKustomer = New System.Windows.Forms.GroupBox()
        Me.cbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.tbAlamatKustomer = New System.Windows.Forms.TextBox()
        Me.tbNoHpKustomer = New System.Windows.Forms.TextBox()
        Me.tbNamaKustomer = New System.Windows.Forms.TextBox()
        Me.tbIdKustomer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvDataKustomer = New System.Windows.Forms.DataGridView()
        Me.tbSearchKustomer = New System.Windows.Forms.TextBox()
        Me.btSearchKustomer = New System.Windows.Forms.Button()
        Me.btDeleteKustomer = New System.Windows.Forms.Button()
        Me.btUpdateKustomer = New System.Windows.Forms.Button()
        Me.btCreateKustomer = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataObatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenjualanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSupplierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbDataKustomer.SuspendLayout()
        CType(Me.dgvDataKustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Dosis", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(616, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 42)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apotek Sehat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Futura Md BT", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(340, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(549, 81)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Data Kustomer"
        '
        'gbDataKustomer
        '
        Me.gbDataKustomer.BackColor = System.Drawing.Color.Transparent
        Me.gbDataKustomer.Controls.Add(Me.cbJenisKelamin)
        Me.gbDataKustomer.Controls.Add(Me.tbAlamatKustomer)
        Me.gbDataKustomer.Controls.Add(Me.tbNoHpKustomer)
        Me.gbDataKustomer.Controls.Add(Me.tbNamaKustomer)
        Me.gbDataKustomer.Controls.Add(Me.tbIdKustomer)
        Me.gbDataKustomer.Controls.Add(Me.Label9)
        Me.gbDataKustomer.Controls.Add(Me.Label6)
        Me.gbDataKustomer.Controls.Add(Me.Label5)
        Me.gbDataKustomer.Controls.Add(Me.Label4)
        Me.gbDataKustomer.Controls.Add(Me.Label3)
        Me.gbDataKustomer.ForeColor = System.Drawing.Color.White
        Me.gbDataKustomer.Location = New System.Drawing.Point(118, 152)
        Me.gbDataKustomer.Name = "gbDataKustomer"
        Me.gbDataKustomer.Size = New System.Drawing.Size(962, 219)
        Me.gbDataKustomer.TabIndex = 6
        Me.gbDataKustomer.TabStop = False
        Me.gbDataKustomer.Text = "Kustomer"
        '
        'cbJenisKelamin
        '
        Me.cbJenisKelamin.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJenisKelamin.FormattingEnabled = True
        Me.cbJenisKelamin.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.cbJenisKelamin.Location = New System.Drawing.Point(175, 164)
        Me.cbJenisKelamin.Name = "cbJenisKelamin"
        Me.cbJenisKelamin.Size = New System.Drawing.Size(154, 31)
        Me.cbJenisKelamin.TabIndex = 18
        '
        'tbAlamatKustomer
        '
        Me.tbAlamatKustomer.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAlamatKustomer.Location = New System.Drawing.Point(640, 27)
        Me.tbAlamatKustomer.Multiline = True
        Me.tbAlamatKustomer.Name = "tbAlamatKustomer"
        Me.tbAlamatKustomer.Size = New System.Drawing.Size(278, 115)
        Me.tbAlamatKustomer.TabIndex = 17
        '
        'tbNoHpKustomer
        '
        Me.tbNoHpKustomer.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoHpKustomer.Location = New System.Drawing.Point(175, 123)
        Me.tbNoHpKustomer.Name = "tbNoHpKustomer"
        Me.tbNoHpKustomer.Size = New System.Drawing.Size(154, 29)
        Me.tbNoHpKustomer.TabIndex = 14
        '
        'tbNamaKustomer
        '
        Me.tbNamaKustomer.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNamaKustomer.Location = New System.Drawing.Point(175, 70)
        Me.tbNamaKustomer.Multiline = True
        Me.tbNamaKustomer.Name = "tbNamaKustomer"
        Me.tbNamaKustomer.Size = New System.Drawing.Size(287, 44)
        Me.tbNamaKustomer.TabIndex = 13
        '
        'tbIdKustomer
        '
        Me.tbIdKustomer.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdKustomer.Location = New System.Drawing.Point(175, 30)
        Me.tbIdKustomer.Name = "tbIdKustomer"
        Me.tbIdKustomer.Size = New System.Drawing.Size(154, 29)
        Me.tbIdKustomer.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(552, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(50, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(50, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "No HP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(50, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nama "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(50, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID Kustomer"
        '
        'dgvDataKustomer
        '
        Me.dgvDataKustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataKustomer.Location = New System.Drawing.Point(118, 445)
        Me.dgvDataKustomer.Name = "dgvDataKustomer"
        Me.dgvDataKustomer.RowHeadersWidth = 51
        Me.dgvDataKustomer.RowTemplate.Height = 24
        Me.dgvDataKustomer.Size = New System.Drawing.Size(968, 265)
        Me.dgvDataKustomer.TabIndex = 28
        '
        'tbSearchKustomer
        '
        Me.tbSearchKustomer.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearchKustomer.Location = New System.Drawing.Point(758, 385)
        Me.tbSearchKustomer.Multiline = True
        Me.tbSearchKustomer.Name = "tbSearchKustomer"
        Me.tbSearchKustomer.Size = New System.Drawing.Size(322, 45)
        Me.tbSearchKustomer.TabIndex = 27
        '
        'btSearchKustomer
        '
        Me.btSearchKustomer.BackColor = System.Drawing.Color.Teal
        Me.btSearchKustomer.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSearchKustomer.ForeColor = System.Drawing.Color.White
        Me.btSearchKustomer.Location = New System.Drawing.Point(636, 385)
        Me.btSearchKustomer.Name = "btSearchKustomer"
        Me.btSearchKustomer.Size = New System.Drawing.Size(100, 45)
        Me.btSearchKustomer.TabIndex = 26
        Me.btSearchKustomer.Text = "SEARCH"
        Me.btSearchKustomer.UseVisualStyleBackColor = False
        '
        'btDeleteKustomer
        '
        Me.btDeleteKustomer.BackColor = System.Drawing.Color.Teal
        Me.btDeleteKustomer.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDeleteKustomer.ForeColor = System.Drawing.Color.White
        Me.btDeleteKustomer.Location = New System.Drawing.Point(468, 385)
        Me.btDeleteKustomer.Name = "btDeleteKustomer"
        Me.btDeleteKustomer.Size = New System.Drawing.Size(100, 45)
        Me.btDeleteKustomer.TabIndex = 25
        Me.btDeleteKustomer.Text = "DELETE"
        Me.btDeleteKustomer.UseVisualStyleBackColor = False
        '
        'btUpdateKustomer
        '
        Me.btUpdateKustomer.BackColor = System.Drawing.Color.Teal
        Me.btUpdateKustomer.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUpdateKustomer.ForeColor = System.Drawing.Color.White
        Me.btUpdateKustomer.Location = New System.Drawing.Point(293, 385)
        Me.btUpdateKustomer.Name = "btUpdateKustomer"
        Me.btUpdateKustomer.Size = New System.Drawing.Size(100, 45)
        Me.btUpdateKustomer.TabIndex = 24
        Me.btUpdateKustomer.Text = "UPDATE"
        Me.btUpdateKustomer.UseVisualStyleBackColor = False
        '
        'btCreateKustomer
        '
        Me.btCreateKustomer.BackColor = System.Drawing.Color.Teal
        Me.btCreateKustomer.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCreateKustomer.ForeColor = System.Drawing.Color.White
        Me.btCreateKustomer.Location = New System.Drawing.Point(118, 385)
        Me.btCreateKustomer.Name = "btCreateKustomer"
        Me.btCreateKustomer.Size = New System.Drawing.Size(100, 45)
        Me.btCreateKustomer.TabIndex = 23
        Me.btCreateKustomer.Text = "CREATE"
        Me.btCreateKustomer.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1182, 28)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataObatToolStripMenuItem1, Me.DataKustomerToolStripMenuItem1, Me.DataPenjualanToolStripMenuItem1, Me.DataSupplierToolStripMenuItem1})
        Me.MENUToolStripMenuItem.Font = New System.Drawing.Font("Dosis", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MENUToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'DataObatToolStripMenuItem1
        '
        Me.DataObatToolStripMenuItem1.Name = "DataObatToolStripMenuItem1"
        Me.DataObatToolStripMenuItem1.Size = New System.Drawing.Size(183, 26)
        Me.DataObatToolStripMenuItem1.Text = "Data Obat"
        '
        'DataKustomerToolStripMenuItem1
        '
        Me.DataKustomerToolStripMenuItem1.Name = "DataKustomerToolStripMenuItem1"
        Me.DataKustomerToolStripMenuItem1.Size = New System.Drawing.Size(183, 26)
        Me.DataKustomerToolStripMenuItem1.Text = "Data Kustomer"
        '
        'DataPenjualanToolStripMenuItem1
        '
        Me.DataPenjualanToolStripMenuItem1.Name = "DataPenjualanToolStripMenuItem1"
        Me.DataPenjualanToolStripMenuItem1.Size = New System.Drawing.Size(183, 26)
        Me.DataPenjualanToolStripMenuItem1.Text = "Data Penjualan"
        '
        'DataSupplierToolStripMenuItem1
        '
        Me.DataSupplierToolStripMenuItem1.Name = "DataSupplierToolStripMenuItem1"
        Me.DataSupplierToolStripMenuItem1.Size = New System.Drawing.Size(183, 26)
        Me.DataSupplierToolStripMenuItem1.Text = "Data Supplier"
        '
        'FormKustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KatanyaMiniProjek.My.Resources.Resources._8767047
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvDataKustomer)
        Me.Controls.Add(Me.tbSearchKustomer)
        Me.Controls.Add(Me.btSearchKustomer)
        Me.Controls.Add(Me.btDeleteKustomer)
        Me.Controls.Add(Me.btUpdateKustomer)
        Me.Controls.Add(Me.btCreateKustomer)
        Me.Controls.Add(Me.gbDataKustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormKustomer"
        Me.Text = "FormKustomer"
        Me.gbDataKustomer.ResumeLayout(False)
        Me.gbDataKustomer.PerformLayout()
        CType(Me.dgvDataKustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbDataKustomer As GroupBox
    Friend WithEvents cbJenisKelamin As ComboBox
    Friend WithEvents tbAlamatKustomer As TextBox
    Friend WithEvents tbNoHpKustomer As TextBox
    Friend WithEvents tbNamaKustomer As TextBox
    Friend WithEvents tbIdKustomer As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvDataKustomer As DataGridView
    Friend WithEvents tbSearchKustomer As TextBox
    Friend WithEvents btSearchKustomer As Button
    Friend WithEvents btDeleteKustomer As Button
    Friend WithEvents btUpdateKustomer As Button
    Friend WithEvents btCreateKustomer As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataObatToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataKustomerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataPenjualanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataSupplierToolStripMenuItem1 As ToolStripMenuItem
End Class
