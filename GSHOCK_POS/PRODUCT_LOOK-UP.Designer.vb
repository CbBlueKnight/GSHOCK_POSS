<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PRODUCT_LOOK_UP
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRODUCT_LOOK_UP))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GshockDataSet = New GSHOCK_POS.gshockDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.LookupBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GshockDataSet2 = New GSHOCK_POS.gshockDataSet2()
        Me.LookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GshockDataSet1 = New GSHOCK_POS.gshockDataSet1()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProductsTableAdapter = New GSHOCK_POS.gshockDataSetTableAdapters.productsTableAdapter()
        Me.LookupTableAdapter = New GSHOCK_POS.gshockDataSet1TableAdapters.lookupTableAdapter()
        Me.LookupTableAdapter1 = New GSHOCK_POS.gshockDataSet2TableAdapters.lookupTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LookupBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GshockDataSet3 = New GSHOCK_POS.gshockDataSet3()
        Me.LookupTableAdapter2 = New GSHOCK_POS.gshockDataSet3TableAdapters.lookupTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GshockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GshockDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GshockDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GshockDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(292, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(641, 79)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRODUCT LOOK-UP"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Gray
        Me.TextBox1.Location = New System.Drawing.Point(171, 419)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(246, 26)
        Me.TextBox1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(520, 236)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(671, 184)
        Me.DataGridView1.TabIndex = 2
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "products"
        Me.ProductsBindingSource.DataSource = Me.GshockDataSet
        '
        'GshockDataSet
        '
        Me.GshockDataSet.DataSetName = "gshockDataSet"
        Me.GshockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(48, 419)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity:"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(192, 470)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(56, 19)
        Me.btnadd.TabIndex = 5
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(711, 684)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Reset:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(803, 680)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(194, 26)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "NEW TRANSACTION"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.Gray
        Me.TextBox5.Location = New System.Drawing.Point(171, 206)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(246, 26)
        Me.TextBox5.TabIndex = 13
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.Gray
        Me.TextBox6.Location = New System.Drawing.Point(171, 255)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(246, 26)
        Me.TextBox6.TabIndex = 14
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.Gray
        Me.TextBox7.Location = New System.Drawing.Point(171, 309)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(246, 26)
        Me.TextBox7.TabIndex = 15
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.Gray
        Me.TextBox8.Location = New System.Drawing.Point(171, 365)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(246, 26)
        Me.TextBox8.TabIndex = 16
        '
        'LookupBindingSource1
        '
        Me.LookupBindingSource1.DataMember = "lookup"
        Me.LookupBindingSource1.DataSource = Me.GshockDataSet2
        '
        'GshockDataSet2
        '
        Me.GshockDataSet2.DataSetName = "gshockDataSet2"
        Me.GshockDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LookupBindingSource
        '
        Me.LookupBindingSource.DataMember = "lookup"
        Me.LookupBindingSource.DataSource = Me.GshockDataSet1
        '
        'GshockDataSet1
        '
        Me.GshockDataSet1.DataSetName = "gshockDataSet1"
        Me.GshockDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(49, 211)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Reference #:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(49, 260)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 19)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Product Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(49, 314)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 19)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Series:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(-52, 345)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 19)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Price:"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.Black
        Me.TextBox9.Location = New System.Drawing.Point(689, 157)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(326, 26)
        Me.TextBox9.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(458, 161)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(210, 19)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "  Search (REFERENCE #) :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(49, 370)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 19)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Price:"
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'LookupTableAdapter
        '
        Me.LookupTableAdapter.ClearBeforeFill = True
        '
        'LookupTableAdapter1
        '
        Me.LookupTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(520, 470)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(671, 150)
        Me.DataGridView2.TabIndex = 27
        '
        'LookupBindingSource2
        '
        Me.LookupBindingSource2.DataMember = "lookup"
        Me.LookupBindingSource2.DataSource = Me.GshockDataSet3
        '
        'GshockDataSet3
        '
        Me.GshockDataSet3.DataSetName = "gshockDataSet3"
        Me.GshockDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LookupTableAdapter2
        '
        Me.LookupTableAdapter2.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1386, 47)
        Me.Panel3.TabIndex = 28
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(1274, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 24)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(516, 206)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 19)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "INVENTORY:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(516, 438)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 19)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "CART:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(803, 639)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 26)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "PAYMEENT OPTION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PRODUCT_LOOK_UP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PRODUCT_LOOK_UP"
        Me.Text = "PRODUCT_LOOK_UP"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GshockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GshockDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GshockDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GshockDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GshockDataSet As gshockDataSet
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As gshockDataSetTableAdapters.productsTableAdapter
    Friend WithEvents GshockDataSet1 As gshockDataSet1
    Friend WithEvents LookupBindingSource As BindingSource
    Friend WithEvents LookupTableAdapter As gshockDataSet1TableAdapters.lookupTableAdapter
    Friend WithEvents GshockDataSet2 As gshockDataSet2
    Friend WithEvents LookupBindingSource1 As BindingSource
    Friend WithEvents LookupTableAdapter1 As gshockDataSet2TableAdapters.lookupTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GshockDataSet3 As gshockDataSet3
    Friend WithEvents LookupBindingSource2 As BindingSource
    Friend WithEvents LookupTableAdapter2 As gshockDataSet3TableAdapters.lookupTableAdapter
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
End Class
