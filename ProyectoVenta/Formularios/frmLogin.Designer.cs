namespace ProyectoVenta.Formularios
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label5 = new System.Windows.Forms.Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnSalir = new System.Windows.Forms.Button();
            btningresar = new System.Windows.Forms.Button();
            txtclave = new System.Windows.Forms.TextBox();
            txtusuario = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.Teal;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(105, 178);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(167, 46);
            label5.TabIndex = 45;
            label5.Text = "INVENTORIO";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = System.Drawing.Color.Teal;
            iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            iconPictureBox1.IconColor = System.Drawing.Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 170;
            iconPictureBox1.Location = new System.Drawing.Point(100, 33);
            iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new System.Drawing.Size(182, 170);
            iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 55;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            iconPictureBox1.MouseLeave += iconPictureBox1_MouseLeave;
            iconPictureBox1.MouseHover += iconPictureBox1_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(91, 515);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(179, 15);
            label4.TabIndex = 46;
            label4.Text = "Todos los derechos reservados Ⓒ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(46, 383);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 17);
            label3.TabIndex = 47;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(46, 318);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 17);
            label2.TabIndex = 48;
            label2.Text = "Usuario";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = System.Drawing.Color.Firebrick;
            btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSalir.ForeColor = System.Drawing.Color.White;
            btnSalir.Location = new System.Drawing.Point(210, 455);
            btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(125, 37);
            btnSalir.TabIndex = 53;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btningresar
            // 
            btningresar.BackColor = System.Drawing.Color.SteelBlue;
            btningresar.Cursor = System.Windows.Forms.Cursors.Hand;
            btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btningresar.ForeColor = System.Drawing.Color.White;
            btningresar.Location = new System.Drawing.Point(49, 455);
            btningresar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btningresar.Name = "btningresar";
            btningresar.Size = new System.Drawing.Size(125, 37);
            btningresar.TabIndex = 52;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // txtclave
            // 
            txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtclave.Location = new System.Drawing.Point(49, 406);
            txtclave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new System.Drawing.Size(285, 23);
            txtclave.TabIndex = 51;
            // 
            // txtusuario
            // 
            txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtusuario.Location = new System.Drawing.Point(49, 342);
            txtusuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new System.Drawing.Size(285, 23);
            txtusuario.TabIndex = 50;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Teal;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(384, 258);
            label1.TabIndex = 49;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(384, 591);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(iconPictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(btningresar);
            Controls.Add(txtclave);
            Controls.Add(txtusuario);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximumSize = new System.Drawing.Size(400, 630);
            MinimumSize = new System.Drawing.Size(400, 630);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = ".: Login :.";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label1;
    }
}