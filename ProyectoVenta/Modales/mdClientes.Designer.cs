namespace ProyectoVenta.Modales
{
    partial class mdClientes
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
            cbobuscar = new System.Windows.Forms.ComboBox();
            txtbuscar = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnsalir = new FontAwesome.Sharp.IconButton();
            btnborrar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            label1 = new System.Windows.Forms.Label();
            dgvdata = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // cbobuscar
            // 
            cbobuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            cbobuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbobuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new System.Drawing.Point(286, 61);
            cbobuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbobuscar.Name = "cbobuscar";
            cbobuscar.Size = new System.Drawing.Size(168, 21);
            cbobuscar.TabIndex = 140;
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtbuscar.Location = new System.Drawing.Point(462, 61);
            txtbuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new System.Drawing.Size(157, 21);
            txtbuscar.TabIndex = 141;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.White;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(198, 65);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(69, 15);
            label12.TabIndex = 147;
            label12.Text = "Buscar por:";
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Teal;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(2, 2);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            label2.Size = new System.Drawing.Size(729, 47);
            label2.TabIndex = 145;
            label2.Text = "Tecnicos";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            btnsalir.Location = new System.Drawing.Point(645, 8);
            btnsalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new System.Drawing.Size(80, 36);
            btnsalir.TabIndex = 148;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnborrar
            // 
            btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnborrar.IconColor = System.Drawing.Color.Black;
            btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnborrar.IconSize = 20;
            btnborrar.Location = new System.Drawing.Point(674, 61);
            btnborrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnborrar.Name = "btnborrar";
            btnborrar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            btnborrar.Size = new System.Drawing.Size(43, 24);
            btnborrar.TabIndex = 143;
            btnborrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = System.Drawing.Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 18;
            btnbuscar.Location = new System.Drawing.Point(626, 61);
            btnbuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            btnbuscar.Size = new System.Drawing.Size(43, 24);
            btnbuscar.TabIndex = 142;
            btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.White;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(2, 48);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(729, 329);
            label1.TabIndex = 144;
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
            dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, btnseleccionar, NumeroDocumento, NombreCompleto });
            dgvdata.Location = new System.Drawing.Point(16, 96);
            dgvdata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 24;
            dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgvdata.Size = new System.Drawing.Size(701, 267);
            dgvdata.TabIndex = 149;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Id.Visible = false;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            btnseleccionar.Width = 35;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.ReadOnly = true;
            NumeroDocumento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            NumeroDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            NumeroDocumento.Width = 200;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            NombreCompleto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            NombreCompleto.Width = 200;
            // 
            // mdClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(735, 378);
            ControlBox = false;
            Controls.Add(dgvdata);
            Controls.Add(cbobuscar);
            Controls.Add(txtbuscar);
            Controls.Add(label12);
            Controls.Add(btnsalir);
            Controls.Add(btnborrar);
            Controls.Add(btnbuscar);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "mdClientes";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = ".: Tecnicos :.";
            Load += mdClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbobuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
    }
}