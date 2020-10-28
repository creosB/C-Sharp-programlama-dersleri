namespace WindowsFormsApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.animator1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.ayarlar = new ns1.BunifuFlatButton();
            this.hakkında = new ns1.BunifuFlatButton();
            this.nedir = new ns1.BunifuFlatButton();
            this.arama = new ns1.BunifuFlatButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.header = new ns1.BunifuGradientPanel();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuImageButton2 = new ns1.BunifuImageButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.animator1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // animator1
            // 
            this.animator1.Controls.Add(this.bunifuGradientPanel1);
            this.animator1.Controls.Add(this.header);
            this.animator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animator1.Location = new System.Drawing.Point(0, 0);
            this.animator1.Name = "animator1";
            this.animator1.Size = new System.Drawing.Size(557, 402);
            this.animator1.TabIndex = 3;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.ayarlar);
            this.bunifuGradientPanel1.Controls.Add(this.hakkında);
            this.bunifuGradientPanel1.Controls.Add(this.nedir);
            this.bunifuGradientPanel1.Controls.Add(this.arama);
            this.bunifuGradientPanel1.Controls.Add(this.Logo);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.BlueViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 39);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(213, 363);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // ayarlar
            // 
            this.ayarlar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ayarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ayarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ayarlar.BorderRadius = 0;
            this.ayarlar.ButtonText = "               Settings";
            this.ayarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ayarlar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ayarlar.Iconcolor = System.Drawing.Color.Transparent;
            this.ayarlar.Iconimage = ((System.Drawing.Image)(resources.GetObject("ayarlar.Iconimage")));
            this.ayarlar.Iconimage_right = null;
            this.ayarlar.Iconimage_right_Selected = null;
            this.ayarlar.Iconimage_Selected = null;
            this.ayarlar.IconMarginLeft = 0;
            this.ayarlar.IconMarginRight = 0;
            this.ayarlar.IconRightVisible = false;
            this.ayarlar.IconRightZoom = 0D;
            this.ayarlar.IconVisible = true;
            this.ayarlar.IconZoom = 60D;
            this.ayarlar.IsTab = false;
            this.ayarlar.Location = new System.Drawing.Point(0, 302);
            this.ayarlar.Name = "ayarlar";
            this.ayarlar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ayarlar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ayarlar.OnHoverTextColor = System.Drawing.Color.White;
            this.ayarlar.selected = false;
            this.ayarlar.Size = new System.Drawing.Size(210, 63);
            this.ayarlar.TabIndex = 9;
            this.ayarlar.Text = "               Settings";
            this.ayarlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ayarlar.Textcolor = System.Drawing.SystemColors.MenuHighlight;
            this.ayarlar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayarlar.Click += new System.EventHandler(this.ayarlar_Click);
            // 
            // hakkında
            // 
            this.hakkında.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.hakkında.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hakkında.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hakkında.BorderRadius = 0;
            this.hakkında.ButtonText = "               About";
            this.hakkında.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hakkında.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hakkında.Iconcolor = System.Drawing.Color.Transparent;
            this.hakkında.Iconimage = ((System.Drawing.Image)(resources.GetObject("hakkında.Iconimage")));
            this.hakkında.Iconimage_right = null;
            this.hakkında.Iconimage_right_Selected = null;
            this.hakkında.Iconimage_Selected = null;
            this.hakkında.IconMarginLeft = 0;
            this.hakkında.IconMarginRight = 0;
            this.hakkında.IconRightVisible = false;
            this.hakkında.IconRightZoom = 0D;
            this.hakkında.IconVisible = true;
            this.hakkında.IconZoom = 60D;
            this.hakkında.IsTab = false;
            this.hakkında.Location = new System.Drawing.Point(0, 243);
            this.hakkında.Name = "hakkında";
            this.hakkında.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hakkında.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hakkında.OnHoverTextColor = System.Drawing.Color.White;
            this.hakkında.selected = false;
            this.hakkında.Size = new System.Drawing.Size(210, 63);
            this.hakkında.TabIndex = 8;
            this.hakkında.Text = "               About";
            this.hakkında.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hakkında.Textcolor = System.Drawing.SystemColors.MenuHighlight;
            this.hakkında.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hakkında.Click += new System.EventHandler(this.hakkında_Click);
            // 
            // nedir
            // 
            this.nedir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.nedir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nedir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nedir.BorderRadius = 0;
            this.nedir.ButtonText = "               What is sar value";
            this.nedir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nedir.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nedir.Iconcolor = System.Drawing.Color.Transparent;
            this.nedir.Iconimage = ((System.Drawing.Image)(resources.GetObject("nedir.Iconimage")));
            this.nedir.Iconimage_right = null;
            this.nedir.Iconimage_right_Selected = null;
            this.nedir.Iconimage_Selected = null;
            this.nedir.IconMarginLeft = 0;
            this.nedir.IconMarginRight = 0;
            this.nedir.IconRightVisible = false;
            this.nedir.IconRightZoom = 0D;
            this.nedir.IconVisible = true;
            this.nedir.IconZoom = 60D;
            this.nedir.IsTab = false;
            this.nedir.Location = new System.Drawing.Point(-1, 174);
            this.nedir.Name = "nedir";
            this.nedir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nedir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nedir.OnHoverTextColor = System.Drawing.Color.White;
            this.nedir.selected = false;
            this.nedir.Size = new System.Drawing.Size(211, 63);
            this.nedir.TabIndex = 7;
            this.nedir.Text = "               What is sar value";
            this.nedir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nedir.Textcolor = System.Drawing.SystemColors.MenuHighlight;
            this.nedir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nedir.Click += new System.EventHandler(this.nedir_Click);
            // 
            // arama
            // 
            this.arama.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.arama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.arama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arama.BorderRadius = 0;
            this.arama.ButtonText = "                Search";
            this.arama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arama.DisabledColor = System.Drawing.Color.Gray;
            this.arama.Iconcolor = System.Drawing.Color.Transparent;
            this.arama.Iconimage = ((System.Drawing.Image)(resources.GetObject("arama.Iconimage")));
            this.arama.Iconimage_right = null;
            this.arama.Iconimage_right_Selected = null;
            this.arama.Iconimage_Selected = null;
            this.arama.IconMarginLeft = 0;
            this.arama.IconMarginRight = 0;
            this.arama.IconRightVisible = false;
            this.arama.IconRightZoom = 0D;
            this.arama.IconVisible = true;
            this.arama.IconZoom = 60D;
            this.arama.IsTab = false;
            this.arama.Location = new System.Drawing.Point(-1, 119);
            this.arama.Name = "arama";
            this.arama.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.arama.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.arama.OnHoverTextColor = System.Drawing.Color.White;
            this.arama.selected = false;
            this.arama.Size = new System.Drawing.Size(211, 63);
            this.arama.TabIndex = 3;
            this.arama.Text = "                Search";
            this.arama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arama.Textcolor = System.Drawing.SystemColors.MenuHighlight;
            this.arama.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arama.Click += new System.EventHandler(this.arama_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(210, 113);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            // 
            // header
            // 
            this.header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("header.BackgroundImage")));
            this.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.pictureBox3);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.GradientBottomLeft = System.Drawing.Color.DarkViolet;
            this.header.GradientBottomRight = System.Drawing.Color.Blue;
            this.header.GradientTopLeft = System.Drawing.Color.Brown;
            this.header.GradientTopRight = System.Drawing.Color.WhiteSmoke;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Quality = 10;
            this.header.Size = new System.Drawing.Size(557, 39);
            this.header.TabIndex = 2;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(525, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(29, 28);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(68, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(262, 37);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Sar Value İnquiry";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(605, 3);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(29, 28);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 402);
            this.Controls.Add(this.animator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.animator1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel animator1;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private ns1.BunifuFlatButton ayarlar;
        private ns1.BunifuFlatButton hakkında;
        private ns1.BunifuFlatButton nedir;
        private ns1.BunifuFlatButton arama;
        private System.Windows.Forms.PictureBox Logo;
        private ns1.BunifuGradientPanel header;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuDragControl bunifuDragControl1;
    }
}