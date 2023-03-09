using NPOI.SS.Formula.Functions;

namespace ProyectoVenta.Formularios.Pedidos
{
    partial class frmRegistrarPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarPedidos));
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnbuscarclientes = new FontAwesome.Sharp.IconButton();
            txtdoccliente = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtfecharegistro = new System.Windows.Forms.TextBox();
            label26 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            txtnumerodocumento = new System.Windows.Forms.TextBox();
            txtcodigoproducto = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtcantidad = new System.Windows.Forms.NumericUpDown();
            btnagregar = new FontAwesome.Sharp.IconButton();
            dgvdata = new System.Windows.Forms.DataGridView();
            btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Presupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtprecio = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            btnguardarsalida = new FontAwesome.Sharp.IconButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label10 = new System.Windows.Forms.Label();
            txtnomcliente = new System.Windows.Forms.TextBox();
            btnsalir = new FontAwesome.Sharp.IconButton();
            txtdescripcionproducto = new System.Windows.Forms.TextBox();
            btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Teal;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(1, 1);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            label2.Size = new System.Drawing.Size(885, 47);
            label2.TabIndex = 107;
            label2.Text = "Registrar Pedido";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.White;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(-3, 42);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(885, 579);
            label1.TabIndex = 106;
            // 
            // btnbuscarclientes
            // 
            btnbuscarclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            btnbuscarclientes.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarclientes.IconColor = System.Drawing.Color.Black;
            btnbuscarclientes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnbuscarclientes.IconSize = 16;
            btnbuscarclientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnbuscarclientes.Location = new System.Drawing.Point(434, 134);
            btnbuscarclientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnbuscarclientes.Name = "btnbuscarclientes";
            btnbuscarclientes.Size = new System.Drawing.Size(59, 25);
            btnbuscarclientes.TabIndex = 112;
            btnbuscarclientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnbuscarclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnbuscarclientes.UseVisualStyleBackColor = true;
            btnbuscarclientes.Click += btnbuscarclientes_Click;
            // 
            // txtdoccliente
            // 
            txtdoccliente.Location = new System.Drawing.Point(24, 136);
            txtdoccliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtdoccliente.Name = "txtdoccliente";
            txtdoccliente.Size = new System.Drawing.Size(149, 23);
            txtdoccliente.TabIndex = 111;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(24, 114);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 15);
            label5.TabIndex = 110;
            label5.Text = "Doc. Tecnico:";
            // 
            // txtfecharegistro
            // 
            txtfecharegistro.Location = new System.Drawing.Point(441, 66);
            txtfecharegistro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtfecharegistro.Name = "txtfecharegistro";
            txtfecharegistro.ReadOnly = true;
            txtfecharegistro.Size = new System.Drawing.Size(150, 23);
            txtfecharegistro.TabIndex = 114;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = System.Drawing.Color.White;
            label26.Location = new System.Drawing.Point(23, 69);
            label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(106, 15);
            label26.TabIndex = 115;
            label26.Text = "Nº de Documento:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = System.Drawing.Color.White;
            label27.Location = new System.Drawing.Point(306, 69);
            label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(84, 15);
            label27.TabIndex = 116;
            label27.Text = "Fecha registro:";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtnumerodocumento.Location = new System.Drawing.Point(136, 66);
            txtnumerodocumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new System.Drawing.Size(150, 20);
            txtnumerodocumento.TabIndex = 117;
            // 
            // txtcodigoproducto
            // 
            txtcodigoproducto.Location = new System.Drawing.Point(27, 203);
            txtcodigoproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtcodigoproducto.Name = "txtcodigoproducto";
            txtcodigoproducto.Size = new System.Drawing.Size(146, 23);
            txtcodigoproducto.TabIndex = 119;
            txtcodigoproducto.KeyDown += txtcodigoproducto_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(23, 185);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 15);
            label3.TabIndex = 118;
            label3.Text = "Codigo Producto:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(24, 163);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(839, 12);
            groupBox1.TabIndex = 121;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(184, 185);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(124, 15);
            label4.TabIndex = 122;
            label4.Text = "Descripción Producto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(514, 185);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(58, 15);
            label6.TabIndex = 124;
            label6.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new System.Drawing.Point(517, 204);
            txtcantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtcantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtcantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new System.Drawing.Size(72, 23);
            txtcantidad.TabIndex = 125;
            txtcantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            txtcantidad.KeyPress += txtcantidad_KeyPress;
            // 
            // btnagregar
            // 
            btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnagregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnagregar.IconColor = System.Drawing.Color.Black;
            btnagregar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnagregar.IconSize = 16;
            btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnagregar.Location = new System.Drawing.Point(813, 203);
            btnagregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnagregar.Name = "btnagregar";
            btnagregar.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            btnagregar.Size = new System.Drawing.Size(50, 25);
            btnagregar.TabIndex = 126;
            btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { btneliminar, Id, Codigo, Descripcion, Tecnico, Cantidad, Precio, Subtotal, Presupuesto });
            dgvdata.Location = new System.Drawing.Point(24, 250);
            dgvdata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 24;
            dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgvdata.Size = new System.Drawing.Size(839, 323);
            dgvdata.TabIndex = 127;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // btneliminar
            // 
            btneliminar.HeaderText = "";
            btneliminar.Name = "btneliminar";
            btneliminar.ReadOnly = true;
            btneliminar.Width = 35;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Codigo.Width = 110;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Descripcion.Width = 230;
            // 
            // Tecnico
            // 
            Tecnico.HeaderText = "Tecnico";
            Tecnico.Name = "Tecnico";
            Tecnico.ReadOnly = true;
            Tecnico.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Tecnico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Tecnico.Width = 140;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Cantidad.Width = 70;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Precio.Width = 70;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Subtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Subtotal.Width = 70;
            // 
            // Presupuesto
            // 
            Presupuesto.HeaderText = "Presupuesto";
            Presupuesto.Name = "Presupuesto";
            Presupuesto.ReadOnly = true;
            Presupuesto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Presupuesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Presupuesto.Width = 170;
            // 
            // txtprecio
            // 
            txtprecio.Location = new System.Drawing.Point(602, 204);
            txtprecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new System.Drawing.Size(72, 23);
            txtprecio.TabIndex = 129;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(601, 185);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(43, 15);
            label7.TabIndex = 128;
            label7.Text = "Precio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.White;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(23, 590);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(153, 15);
            label8.TabIndex = 130;
            label8.Text = "Campo de disposicion:";
            // 
            // btnguardarsalida
            // 
            btnguardarsalida.Cursor = System.Windows.Forms.Cursors.Hand;
            btnguardarsalida.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnguardarsalida.IconColor = System.Drawing.Color.Black;
            btnguardarsalida.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnguardarsalida.IconSize = 18;
            btnguardarsalida.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnguardarsalida.Location = new System.Drawing.Point(706, 580);
            btnguardarsalida.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnguardarsalida.Name = "btnguardarsalida";
            btnguardarsalida.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            btnguardarsalida.Size = new System.Drawing.Size(158, 32);
            btnguardarsalida.TabIndex = 132;
            btnguardarsalida.Text = "Guardar Salida";
            btnguardarsalida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnguardarsalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnguardarsalida.UseVisualStyleBackColor = true;
            btnguardarsalida.Click += btnguardarsalida_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.White;
            groupBox2.Location = new System.Drawing.Point(24, 96);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(839, 12);
            groupBox2.TabIndex = 122;
            groupBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(184, 114);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(97, 15);
            label10.TabIndex = 133;
            label10.Text = "Nombre Tecnico:";
            // 
            // txtnomcliente
            // 
            txtnomcliente.Location = new System.Drawing.Point(188, 136);
            txtnomcliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtnomcliente.Name = "txtnomcliente";
            txtnomcliente.Size = new System.Drawing.Size(234, 23);
            txtnomcliente.TabIndex = 134;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = System.Drawing.Color.DarkSlateGray;
            btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnsalir.ForeColor = System.Drawing.Color.White;
            btnsalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            btnsalir.IconColor = System.Drawing.Color.White;
            btnsalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnsalir.IconSize = 24;
            btnsalir.Location = new System.Drawing.Point(785, 8);
            btnsalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new System.Drawing.Size(97, 36);
            btnsalir.TabIndex = 135;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // txtdescripcionproducto
            // 
            txtdescripcionproducto.Location = new System.Drawing.Point(188, 203);
            txtdescripcionproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtdescripcionproducto.Name = "txtdescripcionproducto";
            txtdescripcionproducto.ReadOnly = true;
            txtdescripcionproducto.Size = new System.Drawing.Size(234, 23);
            txtdescripcionproducto.TabIndex = 136;
            // 
            // btnbuscarproducto
            // 
            btnbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarproducto.IconColor = System.Drawing.Color.Black;
            btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnbuscarproducto.IconSize = 16;
            btnbuscarproducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnbuscarproducto.Location = new System.Drawing.Point(434, 202);
            btnbuscarproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnbuscarproducto.Name = "btnbuscarproducto";
            btnbuscarproducto.Size = new System.Drawing.Size(59, 25);
            btnbuscarproducto.TabIndex = 137;
            btnbuscarproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnbuscarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnbuscarproducto.UseVisualStyleBackColor = true;
            btnbuscarproducto.Click += btnbuscarproducto_Click;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(684, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 138;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(682, 183);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(75, 15);
            label9.TabIndex = 139;
            label9.Text = "Presupuesto:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.White;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(190, 591);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(15, 15);
            label11.TabIndex = 140;
            label11.Text = "0";
            // 
            // frmRegistrarPedidos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(887, 630);
            ControlBox = false;
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(btnbuscarproducto);
            Controls.Add(txtdescripcionproducto);
            Controls.Add(btnsalir);
            Controls.Add(txtnomcliente);
            Controls.Add(label10);
            Controls.Add(groupBox2);
            Controls.Add(btnguardarsalida);
            Controls.Add(label8);
            Controls.Add(txtprecio);
            Controls.Add(label7);
            Controls.Add(dgvdata);
            Controls.Add(btnagregar);
            Controls.Add(txtcantidad);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(txtcodigoproducto);
            Controls.Add(label3);
            Controls.Add(txtfecharegistro);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(txtnumerodocumento);
            Controls.Add(btnbuscarclientes);
            Controls.Add(txtdoccliente);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximumSize = new System.Drawing.Size(903, 669);
            MinimumSize = new System.Drawing.Size(903, 669);
            Name = "frmRegistrarPedidos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = ".: Registrar Pedido :.";
            Load += frmRegistrarSalida_Load;
            ((System.ComponentModel.ISupportInitialize)txtcantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnbuscarclientes;
        private System.Windows.Forms.TextBox txtdoccliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfecharegistro;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.TextBox txtcodigoproducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private FontAwesome.Sharp.IconButton btnagregar;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnguardarsalida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnomcliente;
        private FontAwesome.Sharp.IconButton btnsalir;
        private System.Windows.Forms.TextBox txtdescripcionproducto;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;


        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presupuesto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}