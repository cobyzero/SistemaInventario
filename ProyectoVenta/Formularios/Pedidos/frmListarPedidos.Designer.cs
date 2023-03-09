namespace ProyectoVenta.Formularios.Pedidos
{
    partial class frmListarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarPedidos));
            dgvdata = new System.Windows.Forms.DataGridView();
            FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Presupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnsalir = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtfechafin = new System.Windows.Forms.DateTimePicker();
            txtfechainicio = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnexportar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnbusqueda = new FontAwesome.Sharp.IconButton();
            cbobuscar = new System.Windows.Forms.ComboBox();
            txtbuscar = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
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
            dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { FechaRegistro, NroDocumento, CodigoProducto, DescripcionProducto, Tecnico, Cantidad, Precio, SubTotal, Presupuesto });
            dgvdata.Location = new System.Drawing.Point(23, 157);
            dgvdata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvdata.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dgvdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dgvdata.RowTemplate.Height = 24;
            dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgvdata.Size = new System.Drawing.Size(1231, 444);
            dgvdata.TabIndex = 113;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            // 
            // NroDocumento
            // 
            NroDocumento.HeaderText = "Nro de Documento";
            NroDocumento.Name = "NroDocumento";
            NroDocumento.ReadOnly = true;
            NroDocumento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            NroDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            NroDocumento.Width = 120;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "CodigoProducto";
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            CodigoProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            CodigoProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DescripcionProducto
            // 
            DescripcionProducto.HeaderText = "DescripcionProducto";
            DescripcionProducto.Name = "DescripcionProducto";
            DescripcionProducto.ReadOnly = true;
            DescripcionProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            DescripcionProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            DescripcionProducto.Width = 230;
            // 
            // Tecnico
            // 
            Tecnico.HeaderText = "Tecnico";
            Tecnico.Name = "Tecnico";
            Tecnico.ReadOnly = true;
            Tecnico.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Tecnico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Tecnico.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Cantidad.Width = 130;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // Presupuesto
            // 
            Presupuesto.HeaderText = "Presupuesto";
            Presupuesto.Name = "Presupuesto";
            Presupuesto.ReadOnly = true;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Teal;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(4, 2);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            label2.Size = new System.Drawing.Size(1269, 47);
            label2.TabIndex = 115;
            label2.Text = "Lista de Pedidos";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.White;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(4, 50);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1269, 601);
            label1.TabIndex = 114;
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
            btnsalir.Location = new System.Drawing.Point(1186, 8);
            btnsalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new System.Drawing.Size(80, 36);
            btnsalir.TabIndex = 130;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = System.Drawing.Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 17;
            btnbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnbuscar.Location = new System.Drawing.Point(464, 63);
            btnbuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new System.Drawing.Size(115, 24);
            btnbuscar.TabIndex = 142;
            btnbuscar.Text = "Buscar";
            btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtfechafin
            // 
            txtfechafin.CustomFormat = "dd/MM/yyyy";
            txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            txtfechafin.Location = new System.Drawing.Point(327, 63);
            txtfechafin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtfechafin.Name = "txtfechafin";
            txtfechafin.Size = new System.Drawing.Size(112, 23);
            txtfechafin.TabIndex = 141;
            // 
            // txtfechainicio
            // 
            txtfechainicio.CustomFormat = "dd/MM/yyyy";
            txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            txtfechainicio.Location = new System.Drawing.Point(107, 63);
            txtfechainicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtfechainicio.Name = "txtfechainicio";
            txtfechainicio.Size = new System.Drawing.Size(112, 23);
            txtfechainicio.TabIndex = 139;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(21, 66);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(73, 15);
            label4.TabIndex = 140;
            label4.Text = "Fecha Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(245, 63);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 15);
            label3.TabIndex = 138;
            label3.Text = "Fecha Fin:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.White;
            groupBox2.Location = new System.Drawing.Point(23, 92);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(1231, 12);
            groupBox2.TabIndex = 137;
            groupBox2.TabStop = false;
            // 
            // btnexportar
            // 
            btnexportar.BackColor = System.Drawing.SystemColors.Control;
            btnexportar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnexportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnexportar.IconColor = System.Drawing.Color.LimeGreen;
            btnexportar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnexportar.IconSize = 17;
            btnexportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnexportar.Location = new System.Drawing.Point(23, 115);
            btnexportar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new System.Drawing.Size(138, 24);
            btnexportar.TabIndex = 136;
            btnexportar.Text = "Descargar Excel";
            btnexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnexportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnexportar.UseVisualStyleBackColor = false;
            btnexportar.Click += btnexportar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnlimpiar.IconColor = System.Drawing.Color.Black;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 17;
            btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnlimpiar.Location = new System.Drawing.Point(1210, 117);
            btnlimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new System.Drawing.Size(43, 24);
            btnlimpiar.TabIndex = 135;
            btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnbusqueda
            // 
            btnbusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            btnbusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnbusqueda.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbusqueda.IconColor = System.Drawing.Color.Black;
            btnbusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbusqueda.IconSize = 17;
            btnbusqueda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnbusqueda.Location = new System.Drawing.Point(1162, 117);
            btnbusqueda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnbusqueda.Name = "btnbusqueda";
            btnbusqueda.Size = new System.Drawing.Size(43, 24);
            btnbusqueda.TabIndex = 134;
            btnbusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnbusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnbusqueda.UseVisualStyleBackColor = true;
            btnbusqueda.Click += btnbusqueda_Click;
            // 
            // cbobuscar
            // 
            cbobuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            cbobuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbobuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new System.Drawing.Point(821, 117);
            cbobuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new System.Drawing.Size(168, 21);
            cbobuscar.TabIndex = 132;
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtbuscar.Location = new System.Drawing.Point(997, 117);
            txtbuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new System.Drawing.Size(157, 21);
            txtbuscar.TabIndex = 133;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.White;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(734, 120);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(69, 15);
            label12.TabIndex = 131;
            label12.Text = "Buscar por:";
            // 
            // frmListarPedidos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1276, 652);
            ControlBox = false;
            Controls.Add(btnbuscar);
            Controls.Add(txtfechafin);
            Controls.Add(txtfechainicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(btnexportar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnbusqueda);
            Controls.Add(cbobuscar);
            Controls.Add(txtbuscar);
            Controls.Add(label12);
            Controls.Add(btnsalir);
            Controls.Add(dgvdata);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximumSize = new System.Drawing.Size(1292, 691);
            MinimumSize = new System.Drawing.Size(1292, 691);
            Name = "frmListarPedidos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = ".: Lista Pedidos :.";
            Load += frmListarEntradas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.DateTimePicker txtfechafin;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnexportar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbusqueda;
        private System.Windows.Forms.ComboBox cbobuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label12;


        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presupuesto;
    }
}