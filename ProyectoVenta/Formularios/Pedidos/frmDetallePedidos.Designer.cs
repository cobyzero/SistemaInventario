namespace ProyectoVenta.Formularios.Pedidos
{
    partial class frmDetallePedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetallePedidos));
            btndescargarpdf = new FontAwesome.Sharp.IconButton();
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
            label7 = new System.Windows.Forms.Label();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnsalir = new FontAwesome.Sharp.IconButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label26 = new System.Windows.Forms.Label();
            txtnumerodocumento = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnborrar = new FontAwesome.Sharp.IconButton();
            lblnrodocumento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // btndescargarpdf
            // 
            btndescargarpdf.Cursor = System.Windows.Forms.Cursors.Hand;
            btndescargarpdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btndescargarpdf.IconColor = System.Drawing.Color.Red;
            btndescargarpdf.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btndescargarpdf.IconSize = 18;
            btndescargarpdf.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btndescargarpdf.Location = new System.Drawing.Point(671, 569);
            btndescargarpdf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btndescargarpdf.Name = "btndescargarpdf";
            btndescargarpdf.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            btndescargarpdf.Size = new System.Drawing.Size(158, 32);
            btndescargarpdf.TabIndex = 7;
            btndescargarpdf.Text = "Descargar PDF";
            btndescargarpdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btndescargarpdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btndescargarpdf.UseVisualStyleBackColor = true;
            btndescargarpdf.Click += btndescargarpdf_Click;
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
            dgvdata.Location = new System.Drawing.Point(28, 159);
            dgvdata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dgvdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dgvdata.RowTemplate.Height = 24;
            dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgvdata.Size = new System.Drawing.Size(800, 401);
            dgvdata.TabIndex = 6;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.White;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.Teal;
            label7.Location = new System.Drawing.Point(26, 117);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(132, 15);
            label7.TabIndex = 168;
            label7.Text = "LISTA DE PEDIDOS";
            // 
            // btnbuscar
            // 
            btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = System.Drawing.Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 17;
            btnbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnbuscar.Location = new System.Drawing.Point(300, 68);
            btnbuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new System.Drawing.Size(115, 24);
            btnbuscar.TabIndex = 2;
            btnbuscar.Text = "Buscar";
            btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
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
            btnsalir.Location = new System.Drawing.Point(763, 10);
            btnsalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new System.Drawing.Size(82, 36);
            btnsalir.TabIndex = 166;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.White;
            groupBox2.Location = new System.Drawing.Point(26, 98);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(803, 12);
            groupBox2.TabIndex = 160;
            groupBox2.TabStop = false;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = System.Drawing.Color.White;
            label26.Location = new System.Drawing.Point(29, 72);
            label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(106, 15);
            label26.TabIndex = 158;
            label26.Text = "Nº de Documento:";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new System.Drawing.Point(142, 68);
            txtnumerodocumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new System.Drawing.Size(150, 23);
            txtnumerodocumento.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Teal;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(5, 3);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            label2.Size = new System.Drawing.Size(846, 47);
            label2.TabIndex = 155;
            label2.Text = "Buscar Pedido";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.White;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(5, 51);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(846, 563);
            label1.TabIndex = 154;
            // 
            // btnborrar
            // 
            btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnborrar.IconColor = System.Drawing.Color.Black;
            btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnborrar.IconSize = 20;
            btnborrar.Location = new System.Drawing.Point(422, 68);
            btnborrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new System.Drawing.Size(127, 24);
            btnborrar.TabIndex = 173;
            btnborrar.Text = "Limpiar";
            btnborrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // lblnrodocumento
            // 
            lblnrodocumento.AutoSize = true;
            lblnrodocumento.BackColor = System.Drawing.Color.White;
            lblnrodocumento.ForeColor = System.Drawing.Color.DodgerBlue;
            lblnrodocumento.Location = new System.Drawing.Point(568, 73);
            lblnrodocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblnrodocumento.Name = "lblnrodocumento";
            lblnrodocumento.Size = new System.Drawing.Size(100, 15);
            lblnrodocumento.TabIndex = 174;
            lblnrodocumento.Text = "lblnrodocumento";
            // 
            // frmDetallePedidos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(854, 622);
            ControlBox = false;
            Controls.Add(lblnrodocumento);
            Controls.Add(btnborrar);
            Controls.Add(btndescargarpdf);
            Controls.Add(dgvdata);
            Controls.Add(label7);
            Controls.Add(btnbuscar);
            Controls.Add(btnsalir);
            Controls.Add(groupBox2);
            Controls.Add(label26);
            Controls.Add(txtnumerodocumento);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximumSize = new System.Drawing.Size(870, 661);
            MinimumSize = new System.Drawing.Size(870, 661);
            Name = "frmDetallePedidos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = ".: Buscar Pedido :.";
            Load += frmDetalleEntrada_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btndescargarpdf;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnsalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;



        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presupuesto;

        private FontAwesome.Sharp.IconButton btnborrar;
        private System.Windows.Forms.Label lblnrodocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitud;
    }
}