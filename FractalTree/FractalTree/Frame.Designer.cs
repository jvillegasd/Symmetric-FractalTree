namespace FractalTree
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
            this.label1 = new System.Windows.Forms.Label();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud3 = new System.Windows.Forms.NumericUpDown();
            this.drawbt = new System.Windows.Forms.Button();
            this.picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depth:";
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(161, 324);
            this.nud1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(40, 20);
            this.nud1.TabIndex = 1;
            this.nud1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Length:";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(239, 359);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(40, 20);
            this.tb1.TabIndex = 5;
            this.tb1.Text = "1";
            this.tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Angle variation:";
            // 
            // nud3
            // 
            this.nud3.Location = new System.Drawing.Point(322, 325);
            this.nud3.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nud3.Name = "nud3";
            this.nud3.Size = new System.Drawing.Size(40, 20);
            this.nud3.TabIndex = 7;
            this.nud3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // drawbt
            // 
            this.drawbt.Location = new System.Drawing.Point(188, 405);
            this.drawbt.Name = "drawbt";
            this.drawbt.Size = new System.Drawing.Size(75, 23);
            this.drawbt.TabIndex = 8;
            this.drawbt.Text = "Draw";
            this.drawbt.UseVisualStyleBackColor = true;
            this.drawbt.Click += new System.EventHandler(this.drawbt_Click);
            // 
            // picturebox
            // 
            this.picturebox.Location = new System.Drawing.Point(85, 24);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(311, 280);
            this.picturebox.TabIndex = 10;
            this.picturebox.TabStop = false;
            this.picturebox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.drawbt);
            this.Controls.Add(this.nud3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud3;
        private System.Windows.Forms.Button drawbt;
        private System.Windows.Forms.PictureBox picturebox;
    }
}

