namespace Managemenntul_Supermarketului
{
    partial class Loader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progresionBar = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.lblLoading = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(271, 27);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(267, 25);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "SUPERMARKET MANAGER 1.0";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Managemenntul_Supermarketului.Properties.Resources.Abandoned_Cart_Featured_Image;
            this.pictureBox1.Location = new System.Drawing.Point(39, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(718, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progresionBar
            // 
            this.progresionBar.AllowAnimations = false;
            this.progresionBar.Animation = 0;
            this.progresionBar.AnimationSpeed = 220;
            this.progresionBar.AnimationStep = 10;
            this.progresionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progresionBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progresionBar.BackgroundImage")));
            this.progresionBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progresionBar.BorderRadius = 9;
            this.progresionBar.BorderThickness = 1;
            this.progresionBar.Location = new System.Drawing.Point(243, 404);
            this.progresionBar.Maximum = 100;
            this.progresionBar.MaximumValue = 100;
            this.progresionBar.Minimum = 0;
            this.progresionBar.MinimumValue = 0;
            this.progresionBar.Name = "progresionBar";
            this.progresionBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progresionBar.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progresionBar.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progresionBar.ProgressColorRight = System.Drawing.Color.DodgerBlue;
            this.progresionBar.Size = new System.Drawing.Size(285, 13);
            this.progresionBar.TabIndex = 2;
            this.progresionBar.Value = 50;
            this.progresionBar.ValueByTransition = 50;
            // 
            // lblLoading
            // 
            this.lblLoading.AllowParentOverrides = false;
            this.lblLoading.AutoEllipsis = false;
            this.lblLoading.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoading.Location = new System.Drawing.Point(357, 359);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoading.Size = new System.Drawing.Size(62, 21);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "Loading";
            this.lblLoading.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblLoading.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progresionBar);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.Load += new System.EventHandler(this.Loader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuProgressBar progresionBar;
        private Bunifu.UI.WinForms.BunifuLabel lblLoading;
    }
}