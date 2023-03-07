namespace ProyectoVenta.Modales
{
    partial class mdPedidos
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
            btnaceptar = new FontAwesome.Sharp.IconButton();
            label1 = new System.Windows.Forms.Label();
            txtnumerodocumento = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnaceptar
            // 
            btnaceptar.BackColor = System.Drawing.SystemColors.Control;
            btnaceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnaceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnaceptar.ForeColor = System.Drawing.Color.Black;
            btnaceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnaceptar.IconColor = System.Drawing.Color.Black;
            btnaceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnaceptar.IconSize = 20;
            btnaceptar.Location = new System.Drawing.Point(172, 91);
            btnaceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new System.Drawing.Size(97, 27);
            btnaceptar.TabIndex = 71;
            btnaceptar.Text = "Aceptar";
            btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnaceptar.UseVisualStyleBackColor = false;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(75, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 15);
            label1.TabIndex = 72;
            label1.Text = "Pedido registrado!";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new System.Drawing.Point(78, 60);
            txtnumerodocumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.ReadOnly = true;
            txtnumerodocumento.Size = new System.Drawing.Size(190, 23);
            txtnumerodocumento.TabIndex = 73;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(75, 42);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(188, 15);
            label2.TabIndex = 74;
            label2.Text = "Numero de documento generado:";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = System.Drawing.Color.White;
            iconPictureBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            iconPictureBox1.IconColor = System.Drawing.SystemColors.Highlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 53;
            iconPictureBox1.Location = new System.Drawing.Point(14, 30);
            iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new System.Drawing.Size(54, 53);
            iconPictureBox1.TabIndex = 75;
            iconPictureBox1.TabStop = false;
            // 
            // mdPedidos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(358, 167);
            ControlBox = false;
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(txtnumerodocumento);
            Controls.Add(label1);
            Controls.Add(btnaceptar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "mdPedidos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = ".: Mensaje :.";
            Load += mdSalidaExitosa_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnaceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}