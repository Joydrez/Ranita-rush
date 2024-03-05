namespace Ranita_rush
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
            this.components = new System.ComponentModel.Container();
            this.tmrCar1 = new System.Windows.Forms.Timer(this.components);
            this.pBoxCar6 = new System.Windows.Forms.PictureBox();
            this.pBoxCar5 = new System.Windows.Forms.PictureBox();
            this.pBoxCar4 = new System.Windows.Forms.PictureBox();
            this.pBoxCar3 = new System.Windows.Forms.PictureBox();
            this.pBoxCar2 = new System.Windows.Forms.PictureBox();
            this.pBoxCar1 = new System.Windows.Forms.PictureBox();
            this.pBoxRana = new System.Windows.Forms.PictureBox();
            this.tmrCar2 = new System.Windows.Forms.Timer(this.components);
            this.tmrCar3 = new System.Windows.Forms.Timer(this.components);
            this.tmrCar4 = new System.Windows.Forms.Timer(this.components);
            this.tmrCar5 = new System.Windows.Forms.Timer(this.components);
            this.tmrCar6 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRana)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrCar1
            // 
            this.tmrCar1.Interval = 50;
            this.tmrCar1.Tick += new System.EventHandler(this.tmrCar1_Tick);
            // 
            // pBoxCar6
            // 
            this.pBoxCar6.Image = global::Ranita_rush.Properties.Resources.piteroleft;
            this.pBoxCar6.Location = new System.Drawing.Point(1109, 89);
            this.pBoxCar6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBoxCar6.Name = "pBoxCar6";
            this.pBoxCar6.Size = new System.Drawing.Size(107, 62);
            this.pBoxCar6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCar6.TabIndex = 6;
            this.pBoxCar6.TabStop = false;
            // 
            // pBoxCar5
            // 
            this.pBoxCar5.Image = global::Ranita_rush.Properties.Resources.piteroleft;
            this.pBoxCar5.Location = new System.Drawing.Point(1109, 162);
            this.pBoxCar5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBoxCar5.Name = "pBoxCar5";
            this.pBoxCar5.Size = new System.Drawing.Size(107, 62);
            this.pBoxCar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCar5.TabIndex = 5;
            this.pBoxCar5.TabStop = false;
            // 
            // pBoxCar4
            // 
            this.pBoxCar4.Image = global::Ranita_rush.Properties.Resources.piteroright;
            this.pBoxCar4.Location = new System.Drawing.Point(13, 236);
            this.pBoxCar4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBoxCar4.Name = "pBoxCar4";
            this.pBoxCar4.Size = new System.Drawing.Size(107, 62);
            this.pBoxCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCar4.TabIndex = 4;
            this.pBoxCar4.TabStop = false;
            // 
            // pBoxCar3
            // 
            this.pBoxCar3.Image = global::Ranita_rush.Properties.Resources.piteroright;
            this.pBoxCar3.Location = new System.Drawing.Point(13, 384);
            this.pBoxCar3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBoxCar3.Name = "pBoxCar3";
            this.pBoxCar3.Size = new System.Drawing.Size(107, 62);
            this.pBoxCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCar3.TabIndex = 3;
            this.pBoxCar3.TabStop = false;
            // 
            // pBoxCar2
            // 
            this.pBoxCar2.Image = global::Ranita_rush.Properties.Resources.piteroleft;
            this.pBoxCar2.Location = new System.Drawing.Point(1109, 458);
            this.pBoxCar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBoxCar2.Name = "pBoxCar2";
            this.pBoxCar2.Size = new System.Drawing.Size(107, 62);
            this.pBoxCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCar2.TabIndex = 2;
            this.pBoxCar2.TabStop = false;
            // 
            // pBoxCar1
            // 
            this.pBoxCar1.Image = global::Ranita_rush.Properties.Resources.piteroright;
            this.pBoxCar1.Location = new System.Drawing.Point(13, 532);
            this.pBoxCar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBoxCar1.Name = "pBoxCar1";
            this.pBoxCar1.Size = new System.Drawing.Size(107, 62);
            this.pBoxCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCar1.TabIndex = 1;
            this.pBoxCar1.TabStop = false;
            // 
            // pBoxRana
            // 
            this.pBoxRana.Image = global::Ranita_rush.Properties.Resources.Frog_back;
            this.pBoxRana.Location = new System.Drawing.Point(580, 606);
            this.pBoxRana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBoxRana.Name = "pBoxRana";
            this.pBoxRana.Size = new System.Drawing.Size(80, 62);
            this.pBoxRana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxRana.TabIndex = 0;
            this.pBoxRana.TabStop = false;
            // 
            // tmrCar2
            // 
            this.tmrCar2.Interval = 2;
            this.tmrCar2.Tick += new System.EventHandler(this.tmrCar2_Tick);
            // 
            // tmrCar3
            // 
            this.tmrCar3.Interval = 7;
            this.tmrCar3.Tick += new System.EventHandler(this.tmrCar3_Tick);
            // 
            // tmrCar4
            // 
            this.tmrCar4.Interval = 1;
            this.tmrCar4.Tick += new System.EventHandler(this.tmrCar4_Tick);
            // 
            // tmrCar5
            // 
            this.tmrCar5.Interval = 15;
            this.tmrCar5.Tick += new System.EventHandler(this.tmrCar5_Tick);
            // 
            // tmrCar6
            // 
            this.tmrCar6.Interval = 3;
            this.tmrCar6.Tick += new System.EventHandler(this.tmrCar6_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1232, 690);
            this.Controls.Add(this.pBoxCar6);
            this.Controls.Add(this.pBoxCar5);
            this.Controls.Add(this.pBoxCar4);
            this.Controls.Add(this.pBoxCar3);
            this.Controls.Add(this.pBoxCar2);
            this.Controls.Add(this.pBoxCar1);
            this.Controls.Add(this.pBoxRana);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frogger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxRana;
        private System.Windows.Forms.PictureBox pBoxCar1;
        private System.Windows.Forms.Timer tmrCar1;
        private System.Windows.Forms.PictureBox pBoxCar2;
        private System.Windows.Forms.PictureBox pBoxCar3;
        private System.Windows.Forms.PictureBox pBoxCar4;
        private System.Windows.Forms.PictureBox pBoxCar5;
        private System.Windows.Forms.PictureBox pBoxCar6;
        private System.Windows.Forms.Timer tmrCar2;
        private System.Windows.Forms.Timer tmrCar3;
        private System.Windows.Forms.Timer tmrCar4;
        private System.Windows.Forms.Timer tmrCar5;
        private System.Windows.Forms.Timer tmrCar6;
    }
}

