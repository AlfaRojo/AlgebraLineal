namespace PhotoCookie
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BImportar = new System.Windows.Forms.Button();
            this.PBOriginal = new System.Windows.Forms.PictureBox();
            this.PBFinal = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.BBlancoNegro = new System.Windows.Forms.Button();
            this.Tipos = new System.Windows.Forms.ComboBox();
            this.BAplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // BImportar
            // 
            this.BImportar.BackColor = System.Drawing.Color.Transparent;
            this.BImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BImportar.ForeColor = System.Drawing.Color.White;
            this.BImportar.Location = new System.Drawing.Point(12, 537);
            this.BImportar.Name = "BImportar";
            this.BImportar.Size = new System.Drawing.Size(117, 68);
            this.BImportar.TabIndex = 0;
            this.BImportar.Text = "Importar";
            this.BImportar.UseVisualStyleBackColor = false;
            this.BImportar.Click += new System.EventHandler(this.button1_Click);
            // 
            // PBOriginal
            // 
            this.PBOriginal.BackColor = System.Drawing.Color.Transparent;
            this.PBOriginal.Location = new System.Drawing.Point(10, 10);
            this.PBOriginal.Name = "PBOriginal";
            this.PBOriginal.Size = new System.Drawing.Size(298, 426);
            this.PBOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBOriginal.TabIndex = 1;
            this.PBOriginal.TabStop = false;
            // 
            // PBFinal
            // 
            this.PBFinal.BackColor = System.Drawing.Color.Transparent;
            this.PBFinal.Location = new System.Drawing.Point(376, 10);
            this.PBFinal.Name = "PBFinal";
            this.PBFinal.Size = new System.Drawing.Size(298, 426);
            this.PBFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBFinal.TabIndex = 2;
            this.PBFinal.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(494, 508);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(528, 508);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(28, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "0";
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(562, 508);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(28, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "0";
            this.textBox3.Visible = false;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(562, 537);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(28, 22);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "0";
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(528, 537);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(28, 22);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "0";
            this.textBox5.Visible = false;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(494, 537);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(28, 22);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "0";
            this.textBox6.Visible = false;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(562, 565);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(28, 22);
            this.textBox7.TabIndex = 12;
            this.textBox7.Text = "0";
            this.textBox7.Visible = false;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(528, 565);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(28, 22);
            this.textBox8.TabIndex = 11;
            this.textBox8.Text = "0";
            this.textBox8.Visible = false;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(494, 565);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(28, 22);
            this.textBox9.TabIndex = 10;
            this.textBox9.Text = "0";
            this.textBox9.Visible = false;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Transparent;
            this.Picture.Location = new System.Drawing.Point(741, 12);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(298, 426);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 13;
            this.Picture.TabStop = false;
            // 
            // BBlancoNegro
            // 
            this.BBlancoNegro.BackColor = System.Drawing.Color.Transparent;
            this.BBlancoNegro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBlancoNegro.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBlancoNegro.ForeColor = System.Drawing.Color.White;
            this.BBlancoNegro.Location = new System.Drawing.Point(466, 442);
            this.BBlancoNegro.Name = "BBlancoNegro";
            this.BBlancoNegro.Size = new System.Drawing.Size(146, 33);
            this.BBlancoNegro.TabIndex = 14;
            this.BBlancoNegro.Text = "Blanco-Negro";
            this.BBlancoNegro.UseVisualStyleBackColor = false;
            this.BBlancoNegro.Click += new System.EventHandler(this.button3_Click);
            // 
            // Tipos
            // 
            this.Tipos.FormattingEnabled = true;
            this.Tipos.Items.AddRange(new object[] {
            "Difuminado",
            "Realzar",
            "Sobel Inferior",
            "Sobel Superior",
            "Sobel Izquierdo",
            "Sobel Derecho",
            "Contorno",
            "Afilar",
            "Original",
            "Personalizado"});
            this.Tipos.Location = new System.Drawing.Point(744, 444);
            this.Tipos.Name = "Tipos";
            this.Tipos.Size = new System.Drawing.Size(121, 24);
            this.Tipos.TabIndex = 16;
            this.Tipos.SelectedIndexChanged += new System.EventHandler(this.Tipos_SelectedIndexChanged);
            // 
            // BAplicar
            // 
            this.BAplicar.BackColor = System.Drawing.Color.Transparent;
            this.BAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAplicar.ForeColor = System.Drawing.Color.White;
            this.BAplicar.Location = new System.Drawing.Point(893, 444);
            this.BAplicar.Name = "BAplicar";
            this.BAplicar.Size = new System.Drawing.Size(146, 33);
            this.BAplicar.TabIndex = 17;
            this.BAplicar.Text = "Aplicar";
            this.BAplicar.UseVisualStyleBackColor = false;
            this.BAplicar.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(744, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 125);
            this.label1.TabIndex = 18;
            this.label1.Text = "Función";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1051, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BAplicar);
            this.Controls.Add(this.Tipos);
            this.Controls.Add(this.BBlancoNegro);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PBFinal);
            this.Controls.Add(this.PBOriginal);
            this.Controls.Add(this.BImportar);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Algebra Lineal";
            ((System.ComponentModel.ISupportInitialize)(this.PBOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BImportar;
        private System.Windows.Forms.PictureBox PBOriginal;
        private System.Windows.Forms.PictureBox PBFinal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button BBlancoNegro;
        private System.Windows.Forms.ComboBox Tipos;
        private System.Windows.Forms.Button BAplicar;
        private System.Windows.Forms.Label label1;
    }
}

