<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormObat
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbDataObat = New System.Windows.Forms.GroupBox()
        Me.dtpExpObat = New System.Windows.Forms.DateTimePicker()
        Me.tbIdSupplier = New System.Windows.Forms.TextBox()
        Me.tbHargaObat = New System.Windows.Forms.TextBox()
        Me.tbKeteranganObat = New System.Windows.Forms.TextBox()
        Me.tbStokObat = New System.Windows.Forms.TextBox()
        Me.tbKategoriObat = New System.Windows.Forms.TextBox()
        Me.tbNamaObat = New System.Windows.Forms.TextBox()
        Me.tbIdObat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btCreateObat = New System.Windows.Forms.Button()
        Me.btUpdateObat = New System.Windows.Forms.Button()
        Me.btDeleteObat = New System.Windows.Forms.Button()
        Me.btSearchObat = New System.Windows.Forms.Button()
        Me.tbSearchObat = New System.Windows.Forms.TextBox()
        Me.dgvDataObat = New System.Windows.Forms.DataGridView()
        Me.DataObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataObatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenjualanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSupplierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbDataObat.SuspendLayout()
        CType(Me.dgvDataObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Futura Md BT", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(352, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 81)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Dosis", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(608, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 42)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apotek Sehat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(50, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID Obat"
        '
        'gbDataObat
        '
        Me.gbDataObat.BackColor = System.Drawing.Color.Transparent
        Me.gbDataObat.Controls.Add(Me.dtpExpObat)
        Me.gbDataObat.Controls.Add(Me.tbIdSupplier)
        Me.gbDataObat.Controls.Add(Me.tbHargaObat)
        Me.gbDataObat.Controls.Add(Me.tbKeteranganObat)
        Me.gbDataObat.Controls.Add(Me.tbStokObat)
        Me.gbDataObat.Controls.Add(Me.tbKategoriObat)
        Me.gbDataObat.Controls.Add(Me.tbNamaObat)
        Me.gbDataObat.Controls.Add(Me.tbIdObat)
        Me.gbDataObat.Controls.Add(Me.Label10)
        Me.gbDataObat.Controls.Add(Me.Label9)
        Me.gbDataObat.Controls.Add(Me.Label8)
        Me.gbDataObat.Controls.Add(Me.Label7)
        Me.gbDataObat.Controls.Add(Me.Label6)
        Me.gbDataObat.Controls.Add(Me.Label5)
        Me.gbDataObat.Controls.Add(Me.Label4)
        Me.gbDataObat.Controls.Add(Me.Label3)
        Me.gbDataObat.ForeColor = System.Drawing.Color.White
        Me.gbDataObat.Location = New System.Drawing.Point(111, 143)
        Me.gbDataObat.Name = "gbDataObat"
        Me.gbDataObat.Size = New System.Drawing.Size(962, 247)
        Me.gbDataObat.TabIndex = 5
        Me.gbDataObat.TabStop = False
        Me.gbDataObat.Text = "Obat"
        '
        'dtpExpObat
        '
        Me.dtpExpObat.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpObat.Location = New System.Drawing.Point(163, 198)
        Me.dtpExpObat.Name = "dtpExpObat"
        Me.dtpExpObat.Size = New System.Drawing.Size(287, 29)
        Me.dtpExpObat.TabIndex = 20
        '
        'tbIdSupplier
        '
        Me.tbIdSupplier.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdSupplier.Location = New System.Drawing.Point(640, 26)
        Me.tbIdSupplier.Name = "tbIdSupplier"
        Me.tbIdSupplier.Size = New System.Drawing.Size(154, 29)
        Me.tbIdSupplier.TabIndex = 19
        '
        'tbHargaObat
        '
        Me.tbHargaObat.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHargaObat.Location = New System.Drawing.Point(640, 193)
        Me.tbHargaObat.Name = "tbHargaObat"
        Me.tbHargaObat.Size = New System.Drawing.Size(154, 29)
        Me.tbHargaObat.TabIndex = 18
        '
        'tbKeteranganObat
        '
        Me.tbKeteranganObat.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKeteranganObat.Location = New System.Drawing.Point(640, 66)
        Me.tbKeteranganObat.Multiline = True
        Me.tbKeteranganObat.Name = "tbKeteranganObat"
        Me.tbKeteranganObat.Size = New System.Drawing.Size(287, 115)
        Me.tbKeteranganObat.TabIndex = 17
        '
        'tbStokObat
        '
        Me.tbStokObat.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStokObat.Location = New System.Drawing.Point(163, 152)
        Me.tbStokObat.Name = "tbStokObat"
        Me.tbStokObat.Size = New System.Drawing.Size(154, 29)
        Me.tbStokObat.TabIndex = 15
        '
        'tbKategoriObat
        '
        Me.tbKategoriObat.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKategoriObat.Location = New System.Drawing.Point(163, 110)
        Me.tbKategoriObat.Name = "tbKategoriObat"
        Me.tbKategoriObat.Size = New System.Drawing.Size(287, 29)
        Me.tbKategoriObat.TabIndex = 14
        '
        'tbNamaObat
        '
        Me.tbNamaObat.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNamaObat.Location = New System.Drawing.Point(163, 67)
        Me.tbNamaObat.Name = "tbNamaObat"
        Me.tbNamaObat.Size = New System.Drawing.Size(287, 29)
        Me.tbNamaObat.TabIndex = 13
        '
        'tbIdObat
        '
        Me.tbIdObat.Font = New System.Drawing.Font("Dosis", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdObat.Location = New System.Drawing.Point(163, 27)
        Me.tbIdObat.Name = "tbIdObat"
        Me.tbIdObat.Size = New System.Drawing.Size(154, 29)
        Me.tbIdObat.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(522, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 25)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(522, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Keterangan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(522, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 25)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "ID Supplier"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(50, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Exp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(50, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Stok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(50, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Kategori"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Dosis", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(50, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nama Obat"
        '
        'btCreateObat
        '
        Me.btCreateObat.BackColor = System.Drawing.Color.Teal
        Me.btCreateObat.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCreateObat.ForeColor = System.Drawing.Color.White
        Me.btCreateObat.Location = New System.Drawing.Point(111, 400)
        Me.btCreateObat.Name = "btCreateObat"
        Me.btCreateObat.Size = New System.Drawing.Size(100, 45)
        Me.btCreateObat.TabIndex = 6
        Me.btCreateObat.Text = "CREATE"
        Me.btCreateObat.UseVisualStyleBackColor = False
        '
        'btUpdateObat
        '
        Me.btUpdateObat.BackColor = System.Drawing.Color.Teal
        Me.btUpdateObat.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUpdateObat.ForeColor = System.Drawing.Color.White
        Me.btUpdateObat.Location = New System.Drawing.Point(286, 400)
        Me.btUpdateObat.Name = "btUpdateObat"
        Me.btUpdateObat.Size = New System.Drawing.Size(100, 45)
        Me.btUpdateObat.TabIndex = 7
        Me.btUpdateObat.Text = "UPDATE"
        Me.btUpdateObat.UseVisualStyleBackColor = False
        '
        'btDeleteObat
        '
        Me.btDeleteObat.BackColor = System.Drawing.Color.Teal
        Me.btDeleteObat.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDeleteObat.ForeColor = System.Drawing.Color.White
        Me.btDeleteObat.Location = New System.Drawing.Point(461, 400)
        Me.btDeleteObat.Name = "btDeleteObat"
        Me.btDeleteObat.Size = New System.Drawing.Size(100, 45)
        Me.btDeleteObat.TabIndex = 8
        Me.btDeleteObat.Text = "DELETE"
        Me.btDeleteObat.UseVisualStyleBackColor = False
        '
        'btSearchObat
        '
        Me.btSearchObat.BackColor = System.Drawing.Color.Teal
        Me.btSearchObat.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSearchObat.ForeColor = System.Drawing.Color.White
        Me.btSearchObat.Location = New System.Drawing.Point(629, 400)
        Me.btSearchObat.Name = "btSearchObat"
        Me.btSearchObat.Size = New System.Drawing.Size(100, 45)
        Me.btSearchObat.TabIndex = 9
        Me.btSearchObat.Text = "SEARCH"
        Me.btSearchObat.UseVisualStyleBackColor = False
        '
        'tbSearchObat
        '
        Me.tbSearchObat.Font = New System.Drawing.Font("Dosis", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearchObat.Location = New System.Drawing.Point(751, 400)
        Me.tbSearchObat.Multiline = True
        Me.tbSearchObat.Name = "tbSearchObat"
        Me.tbSearchObat.Size = New System.Drawing.Size(322, 45)
        Me.tbSearchObat.TabIndex = 21
        '
        'dgvDataObat
        '
        Me.dgvDataObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataObat.Location = New System.Drawing.Point(111, 460)
        Me.dgvDataObat.Name = "dgvDataObat"
        Me.dgvDataObat.RowHeadersWidth = 51
        Me.dgvDataObat.RowTemplate.Height = 24
        Me.dgvDataObat.Size = New System.Drawing.Size(968, 251)
        Me.dgvDataObat.TabIndex = 22
        '
        'DataObatToolStripMenuItem
        '
        Me.DataObatToolStripMenuItem.Name = "DataObatToolStripMenuItem"
        Me.DataObatToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DataObatToolStripMenuItem.Text = "Data Obat"
        '
        'DataKustomerToolStripMenuItem
        '
        Me.DataKustomerToolStripMenuItem.Name = "DataKustomerToolStripMenuItem"
        Me.DataKustomerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DataKustomerToolStripMenuItem.Text = "Data Kustomer"
        '
        'DataPenjualanToolStripMenuItem
        '
        Me.DataPenjualanToolStripMenuItem.Name = "DataPenjualanToolStripMenuItem"
        Me.DataPenjualanToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DataPenjualanToolStripMenuItem.Text = "Data Penjualan"
        '
        'DataSupplierToolStripMenuItem
        '
        Me.DataSupplierToolStripMenuItem.Name = "DataSupplierToolStripMenuItem"
        Me.DataSupplierToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DataSupplierToolStripMenuItem.Text = "Data Supplier"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1182, 28)
        Me.MenuStrip1.TabIndex = 24
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
        'FormObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KatanyaMiniProjek.My.Resources.Resources._8767047
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.dgvDataObat)
        Me.Controls.Add(Me.tbSearchObat)
        Me.Controls.Add(Me.btSearchObat)
        Me.Controls.Add(Me.btDeleteObat)
        Me.Controls.Add(Me.btUpdateObat)
        Me.Controls.Add(Me.btCreateObat)
        Me.Controls.Add(Me.gbDataObat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormObat"
        Me.Text = "FormObat"
        Me.gbDataObat.ResumeLayout(False)
        Me.gbDataObat.PerformLayout()
        CType(Me.dgvDataObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbDataObat As GroupBox
    Friend WithEvents dtpExpObat As DateTimePicker
    Friend WithEvents tbIdSupplier As TextBox
    Friend WithEvents tbHargaObat As TextBox
    Friend WithEvents tbKeteranganObat As TextBox
    Friend WithEvents tbStokObat As TextBox
    Friend WithEvents tbKategoriObat As TextBox
    Friend WithEvents tbNamaObat As TextBox
    Friend WithEvents tbIdObat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btCreateObat As Button
    Friend WithEvents btUpdateObat As Button
    Friend WithEvents btDeleteObat As Button
    Friend WithEvents btSearchObat As Button
    Friend WithEvents tbSearchObat As TextBox
    Friend WithEvents dgvDataObat As DataGridView
    Friend WithEvents DataObatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataObatToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataKustomerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataPenjualanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataSupplierToolStripMenuItem1 As ToolStripMenuItem
End Class
