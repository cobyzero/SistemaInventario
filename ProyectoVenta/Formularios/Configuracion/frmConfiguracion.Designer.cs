namespace ProyectoVenta.Formularios.Configuracion
{
    partial class frmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            txtruc = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtrazonsocial = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            txtdireccion = new System.Windows.Forms.TextBox();
            btnguardarcambios = new FontAwesome.Sharp.IconButton();
            groupBox3 = new System.Windows.Forms.GroupBox();
            btnguardartipocodigo = new FontAwesome.Sharp.IconButton();
            cbotipobarra = new System.Windows.Forms.ComboBox();
            label12 = new System.Windows.Forms.Label();
            btnsalir = new FontAwesome.Sharp.IconButton();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtruc
            // 
            txtruc.Location = new System.Drawing.Point(18, 95);
            txtruc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtruc.Name = "txtruc";
            txtruc.Size = new System.Drawing.Size(320, 23);
            txtruc.TabIndex = 104;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 77);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 15);
            label2.TabIndex = 103;
            label2.Text = "R.U.C:";
            // 
            // txtrazonsocial
            // 
            txtrazonsocial.Location = new System.Drawing.Point(18, 41);
            txtrazonsocial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtrazonsocial.Name = "txtrazonsocial";
            txtrazonsocial.Size = new System.Drawing.Size(320, 23);
            txtrazonsocial.TabIndex = 102;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 23);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 15);
            label1.TabIndex = 101;
            label1.Text = "Razón Social:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtdireccion);
            groupBox2.Controls.Add(btnguardarcambios);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtrazonsocial);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtruc);
            groupBox2.Location = new System.Drawing.Point(22, 57);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(374, 240);
            groupBox2.TabIndex = 109;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Negocio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(14, 128);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 15);
            label5.TabIndex = 109;
            label5.Text = "Dirección:";
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new System.Drawing.Point(18, 146);
            txtdireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new System.Drawing.Size(320, 23);
            txtdireccion.TabIndex = 110;
            // 
            // btnguardarcambios
            // 
            btnguardarcambios.Cursor = System.Windows.Forms.Cursors.Hand;
            btnguardarcambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnguardarcambios.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardarcambios.IconColor = System.Drawing.Color.Black;
            btnguardarcambios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnguardarcambios.IconSize = 16;
            btnguardarcambios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnguardarcambios.Location = new System.Drawing.Point(18, 187);
            btnguardarcambios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnguardarcambios.Name = "btnguardarcambios";
            btnguardarcambios.Size = new System.Drawing.Size(321, 32);
            btnguardarcambios.TabIndex = 108;
            btnguardarcambios.Text = "Guardar Cambios";
            btnguardarcambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnguardarcambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnguardarcambios.UseVisualStyleBackColor = true;
            btnguardarcambios.Click += btnguardarcambios_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnguardartipocodigo);
            groupBox3.Controls.Add(cbotipobarra);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new System.Drawing.Point(13, 320);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(546, 62);
            groupBox3.TabIndex = 110;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion Codigo Barra";
            // 
            // btnguardartipocodigo
            // 
            btnguardartipocodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            btnguardartipocodigo.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardartipocodigo.IconColor = System.Drawing.Color.Black;
            btnguardartipocodigo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnguardartipocodigo.IconSize = 17;
            btnguardartipocodigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnguardartipocodigo.Location = new System.Drawing.Point(284, 22);
            btnguardartipocodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnguardartipocodigo.Name = "btnguardartipocodigo";
            btnguardartipocodigo.Size = new System.Drawing.Size(161, 27);
            btnguardartipocodigo.TabIndex = 106;
            btnguardartipocodigo.Text = "Guardar Cambios";
            btnguardartipocodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnguardartipocodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnguardartipocodigo.UseVisualStyleBackColor = true;
            btnguardartipocodigo.Click += btnguardartipocodigo_Click;
            // 
            // cbotipobarra
            // 
            cbotipobarra.Cursor = System.Windows.Forms.Cursors.Hand;
            cbotipobarra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbotipobarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbotipobarra.FormattingEnabled = true;
            cbotipobarra.Location = new System.Drawing.Point(56, 24);
            cbotipobarra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbotipobarra.Name = "cbotipobarra";
            cbotipobarra.Size = new System.Drawing.Size(215, 21);
            cbotipobarra.TabIndex = 134;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.White;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(9, 25);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(34, 15);
            label12.TabIndex = 133;
            label12.Text = "Tipo:";
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
            btnsalir.Location = new System.Drawing.Point(486, 7);
            btnsalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new System.Drawing.Size(80, 36);
            btnsalir.TabIndex = 157;
            btnsalir.Text = "Salir";
            btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Teal;
            label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(1, 1);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            label3.Size = new System.Drawing.Size(571, 47);
            label3.TabIndex = 156;
            label3.Text = "Otros";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.White;
            label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(1, 47);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(571, 347);
            label4.TabIndex = 155;
            // 
            // frmConfiguracion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(575, 397);
            ControlBox = false;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnsalir);
            Controls.Add(label3);
            Controls.Add(label4);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximumSize = new System.Drawing.Size(591, 436);
            MinimumSize = new System.Drawing.Size(591, 436);
            Name = "frmConfiguracion";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = ".: Otros :.";
            Load += frmConfiguracion_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrazonsocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnguardartipocodigo;
        private System.Windows.Forms.ComboBox cbotipobarra;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btnsalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnguardarcambios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdireccion;
    }
}