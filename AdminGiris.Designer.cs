
namespace urunotomasyon
{
    partial class FrmAdmin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtKadi = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtSifre = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.DarkRed;
            this.BtnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGiris.BackgroundImage")));
            this.BtnGiris.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnGiris.Location = new System.Drawing.Point(358, 218);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(137, 35);
            this.BtnGiris.TabIndex = 11;
            this.BtnGiris.Text = "Giris Yap";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.DarkRed;
            this.BtnCikis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCikis.Location = new System.Drawing.Point(199, 218);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(137, 35);
            this.BtnCikis.TabIndex = 12;
            this.BtnCikis.Text = "Çıkıs";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(846, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtKadi
            // 
            this.txtKadi.AcceptsReturn = false;
            this.txtKadi.AcceptsTab = false;
            this.txtKadi.AnimationSpeed = 200;
            this.txtKadi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtKadi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtKadi.AutoSizeHeight = true;
            this.txtKadi.BackColor = System.Drawing.Color.White;
            this.txtKadi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtKadi.BackgroundImage")));
            this.txtKadi.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtKadi.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtKadi.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtKadi.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtKadi.BorderRadius = 1;
            this.txtKadi.BorderThickness = 1;
            this.txtKadi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtKadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKadi.DefaultFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKadi.DefaultText = "";
            this.txtKadi.FillColor = System.Drawing.Color.White;
            this.txtKadi.HideSelection = true;
            this.txtKadi.IconLeft = null;
            this.txtKadi.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKadi.IconPadding = 10;
            this.txtKadi.IconRight = null;
            this.txtKadi.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKadi.Lines = new string[0];
            this.txtKadi.Location = new System.Drawing.Point(216, 98);
            this.txtKadi.MaxLength = 32767;
            this.txtKadi.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtKadi.Modified = false;
            this.txtKadi.Multiline = false;
            this.txtKadi.Name = "txtKadi";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtKadi.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtKadi.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtKadi.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtKadi.OnIdleState = stateProperties4;
            this.txtKadi.Padding = new System.Windows.Forms.Padding(3);
            this.txtKadi.PasswordChar = '\0';
            this.txtKadi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtKadi.PlaceholderText = "Kullanıcı Adı";
            this.txtKadi.ReadOnly = false;
            this.txtKadi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKadi.SelectedText = "";
            this.txtKadi.SelectionLength = 0;
            this.txtKadi.SelectionStart = 0;
            this.txtKadi.ShortcutsEnabled = true;
            this.txtKadi.Size = new System.Drawing.Size(260, 40);
            this.txtKadi.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtKadi.TabIndex = 0;
            this.txtKadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKadi.TextMarginBottom = 0;
            this.txtKadi.TextMarginLeft = 3;
            this.txtKadi.TextMarginTop = 1;
            this.txtKadi.TextPlaceholder = "Kullanıcı Adı";
            this.txtKadi.UseSystemPasswordChar = false;
            this.txtKadi.WordWrap = true;
            this.txtKadi.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.AcceptsReturn = false;
            this.txtSifre.AcceptsTab = false;
            this.txtSifre.AnimationSpeed = 200;
            this.txtSifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSifre.AutoSizeHeight = true;
            this.txtSifre.BackColor = System.Drawing.Color.Transparent;
            this.txtSifre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSifre.BackgroundImage")));
            this.txtSifre.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSifre.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSifre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSifre.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSifre.BorderRadius = 1;
            this.txtSifre.BorderThickness = 1;
            this.txtSifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.DefaultFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.DefaultText = "";
            this.txtSifre.FillColor = System.Drawing.Color.White;
            this.txtSifre.HideSelection = true;
            this.txtSifre.IconLeft = null;
            this.txtSifre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.IconPadding = 10;
            this.txtSifre.IconRight = null;
            this.txtSifre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Lines = new string[0];
            this.txtSifre.Location = new System.Drawing.Point(216, 154);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSifre.Modified = false;
            this.txtSifre.Multiline = false;
            this.txtSifre.Name = "txtSifre";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSifre.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSifre.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSifre.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSifre.OnIdleState = stateProperties8;
            this.txtSifre.Padding = new System.Windows.Forms.Padding(3);
            this.txtSifre.PasswordChar = '\0';
            this.txtSifre.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSifre.PlaceholderText = "Şifre";
            this.txtSifre.ReadOnly = false;
            this.txtSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.ShortcutsEnabled = true;
            this.txtSifre.Size = new System.Drawing.Size(260, 40);
            this.txtSifre.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSifre.TabIndex = 16;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSifre.TextMarginBottom = 0;
            this.txtSifre.TextMarginLeft = 3;
            this.txtSifre.TextMarginTop = 1;
            this.txtSifre.TextPlaceholder = "Şifre";
            this.txtSifre.UseSystemPasswordChar = false;
            this.txtSifre.WordWrap = true;
            this.txtSifre.TextChanged += new System.EventHandler(this.bunifuTextBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(216, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(260, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 520);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnGiris);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminGiris";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuTextBox txtKadi;
        private Bunifu.UI.WinForms.BunifuTextBox txtSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

