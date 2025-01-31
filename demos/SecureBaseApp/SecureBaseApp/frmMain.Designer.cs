namespace CustomBaseApp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            btnLang = new ReaLTaiizor.Controls.ForeverButton();
            statusbar = new ReaLTaiizor.Controls.ForeverStatusBar();
            hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            pageEncoding = new TabPage();
            txtBase64 = new ReaLTaiizor.Controls.DungeonRichTextBox();
            btnTexttoBase64 = new ReaLTaiizor.Controls.HopeButton();
            txtData = new ReaLTaiizor.Controls.DungeonRichTextBox();
            lblinfo1 = new ReaLTaiizor.Controls.NightLabel();
            e_lbldata = new ReaLTaiizor.Controls.NightLabel();
            pageDecoding = new TabPage();
            btnBase64toText = new ReaLTaiizor.Controls.HopeButton();
            txtDecodedData = new ReaLTaiizor.Controls.DungeonRichTextBox();
            d_lbldata = new ReaLTaiizor.Controls.NightLabel();
            txtEncodedBase64 = new ReaLTaiizor.Controls.DungeonRichTextBox();
            lblinfo2 = new ReaLTaiizor.Controls.NightLabel();
            controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            panel1 = new ReaLTaiizor.Controls.Panel();
            lblSecretkey = new ReaLTaiizor.Controls.NightLabel();
            txtSecretKey = new ReaLTaiizor.Controls.BigTextBox();
            themeForm1.SuspendLayout();
            hopeTabPage1.SuspendLayout();
            pageEncoding.SuspendLayout();
            pageDecoding.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // themeForm1
            // 
            themeForm1.BackColor = Color.FromArgb(32, 41, 50);
            themeForm1.Controls.Add(btnLang);
            themeForm1.Controls.Add(statusbar);
            themeForm1.Controls.Add(hopeTabPage1);
            themeForm1.Controls.Add(controlBox1);
            themeForm1.Controls.Add(panel1);
            themeForm1.Dock = DockStyle.Fill;
            themeForm1.Font = new Font("Microsoft Sans Serif", 9F);
            themeForm1.Image = SecureBaseApp.Properties.Resources._64;
            themeForm1.Location = new Point(0, 0);
            themeForm1.Name = "themeForm1";
            themeForm1.Padding = new Padding(10, 70, 10, 9);
            themeForm1.RoundCorners = true;
            themeForm1.Sizable = true;
            themeForm1.Size = new Size(965, 707);
            themeForm1.SmartBounds = true;
            themeForm1.StartPosition = FormStartPosition.CenterScreen;
            themeForm1.TabIndex = 0;
            themeForm1.Text = "SecureBase .NET App";
            // 
            // btnLang
            // 
            btnLang.BackColor = Color.Transparent;
            btnLang.BaseColor = Color.FromArgb(20, 22, 25);
            btnLang.Font = new Font("Segoe UI", 12F);
            btnLang.Location = new Point(761, 16);
            btnLang.Name = "btnLang";
            btnLang.Rounded = true;
            btnLang.Size = new Size(81, 27);
            btnLang.TabIndex = 46;
            btnLang.Text = "English";
            btnLang.TextColor = Color.FromArgb(243, 243, 243);
            btnLang.Click += btnLang_Click;
            // 
            // statusbar
            // 
            statusbar.BaseColor = Color.FromArgb(45, 47, 49);
            statusbar.Dock = DockStyle.Bottom;
            statusbar.Font = new Font("Segoe UI", 8F);
            statusbar.ForeColor = Color.White;
            statusbar.Location = new Point(10, 675);
            statusbar.Name = "statusbar";
            statusbar.RectColor = Color.FromArgb(0, 192, 0);
            statusbar.ShowTimeDate = false;
            statusbar.Size = new Size(945, 23);
            statusbar.TabIndex = 45;
            statusbar.Text = "Hazır";
            statusbar.TextColor = Color.White;
            statusbar.TimeColor = Color.White;
            statusbar.TimeFormat = "dd.MM.yyyy - HH:mm:ss";
            // 
            // hopeTabPage1
            // 
            hopeTabPage1.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTabPage1.Controls.Add(pageEncoding);
            hopeTabPage1.Controls.Add(pageDecoding);
            hopeTabPage1.Dock = DockStyle.Top;
            hopeTabPage1.Font = new Font("Segoe UI", 12F);
            hopeTabPage1.ForeColorA = Color.White;
            hopeTabPage1.ForeColorB = Color.Gray;
            hopeTabPage1.ForeColorC = Color.FromArgb(150, 255, 255, 255);
            hopeTabPage1.ItemSize = new Size(120, 40);
            hopeTabPage1.Location = new Point(10, 135);
            hopeTabPage1.Name = "hopeTabPage1";
            hopeTabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopeTabPage1.SelectedIndex = 0;
            hopeTabPage1.Size = new Size(945, 558);
            hopeTabPage1.SizeMode = TabSizeMode.Fixed;
            hopeTabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopeTabPage1.TabIndex = 8;
            hopeTabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopeTabPage1.ThemeColorA = Color.FromArgb(64, 158, 255);
            hopeTabPage1.ThemeColorB = Color.FromArgb(150, 64, 158, 255);
            hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // pageEncoding
            // 
            pageEncoding.BackColor = Color.FromArgb(32, 41, 50);
            pageEncoding.Controls.Add(txtBase64);
            pageEncoding.Controls.Add(btnTexttoBase64);
            pageEncoding.Controls.Add(txtData);
            pageEncoding.Controls.Add(lblinfo1);
            pageEncoding.Controls.Add(e_lbldata);
            pageEncoding.Location = new Point(0, 40);
            pageEncoding.Name = "pageEncoding";
            pageEncoding.Padding = new Padding(3);
            pageEncoding.Size = new Size(945, 518);
            pageEncoding.TabIndex = 1;
            pageEncoding.Text = "Kodlama";
            // 
            // txtBase64
            // 
            txtBase64.AutoWordSelection = false;
            txtBase64.BackColor = Color.Transparent;
            txtBase64.BorderColor = Color.FromArgb(180, 180, 180);
            txtBase64.EdgeColor = Color.White;
            txtBase64.Font = new Font("Tahoma", 10F);
            txtBase64.ForeColor = Color.FromArgb(76, 76, 76);
            txtBase64.Location = new Point(29, 249);
            txtBase64.Name = "txtBase64";
            txtBase64.ReadOnly = true;
            txtBase64.Size = new Size(892, 165);
            txtBase64.TabIndex = 39;
            txtBase64.TextBackColor = Color.White;
            txtBase64.WordWrap = true;
            // 
            // btnTexttoBase64
            // 
            btnTexttoBase64.BorderColor = Color.FromArgb(220, 223, 230);
            btnTexttoBase64.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            btnTexttoBase64.DangerColor = Color.FromArgb(245, 108, 108);
            btnTexttoBase64.DefaultColor = Color.FromArgb(255, 255, 255);
            btnTexttoBase64.Font = new Font("Segoe UI", 12F);
            btnTexttoBase64.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnTexttoBase64.InfoColor = Color.FromArgb(144, 147, 153);
            btnTexttoBase64.Location = new Point(347, 430);
            btnTexttoBase64.Name = "btnTexttoBase64";
            btnTexttoBase64.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnTexttoBase64.Size = new Size(250, 40);
            btnTexttoBase64.SuccessColor = Color.FromArgb(103, 194, 58);
            btnTexttoBase64.TabIndex = 34;
            btnTexttoBase64.Text = "Metin -> Base64";
            btnTexttoBase64.TextColor = Color.White;
            btnTexttoBase64.WarningColor = Color.FromArgb(230, 162, 60);
            btnTexttoBase64.Click += btnTexttoBase64_Click;
            // 
            // txtData
            // 
            txtData.AutoWordSelection = false;
            txtData.BackColor = Color.Transparent;
            txtData.BorderColor = Color.FromArgb(180, 180, 180);
            txtData.EdgeColor = Color.White;
            txtData.Font = new Font("Tahoma", 10F);
            txtData.ForeColor = Color.FromArgb(76, 76, 76);
            txtData.Location = new Point(29, 46);
            txtData.Name = "txtData";
            txtData.ReadOnly = false;
            txtData.Size = new Size(892, 165);
            txtData.TabIndex = 33;
            txtData.TextBackColor = Color.White;
            txtData.WordWrap = true;
            // 
            // lblinfo1
            // 
            lblinfo1.AutoSize = true;
            lblinfo1.BackColor = Color.Transparent;
            lblinfo1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblinfo1.ForeColor = Color.White;
            lblinfo1.Location = new Point(29, 225);
            lblinfo1.Name = "lblinfo1";
            lblinfo1.Size = new Size(63, 21);
            lblinfo1.TabIndex = 30;
            lblinfo1.Text = "Base64;";
            // 
            // e_lbldata
            // 
            e_lbldata.AutoSize = true;
            e_lbldata.BackColor = Color.Transparent;
            e_lbldata.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            e_lbldata.ForeColor = Color.White;
            e_lbldata.Location = new Point(29, 22);
            e_lbldata.Name = "e_lbldata";
            e_lbldata.Size = new Size(40, 21);
            e_lbldata.TabIndex = 29;
            e_lbldata.Text = "Veri;";
            // 
            // pageDecoding
            // 
            pageDecoding.BackColor = Color.FromArgb(32, 41, 50);
            pageDecoding.Controls.Add(btnBase64toText);
            pageDecoding.Controls.Add(txtDecodedData);
            pageDecoding.Controls.Add(d_lbldata);
            pageDecoding.Controls.Add(txtEncodedBase64);
            pageDecoding.Controls.Add(lblinfo2);
            pageDecoding.Location = new Point(0, 40);
            pageDecoding.Name = "pageDecoding";
            pageDecoding.Padding = new Padding(3);
            pageDecoding.Size = new Size(945, 518);
            pageDecoding.TabIndex = 2;
            pageDecoding.Text = "Kod Çözme";
            // 
            // btnBase64toText
            // 
            btnBase64toText.BorderColor = Color.FromArgb(220, 223, 230);
            btnBase64toText.ButtonType = ReaLTaiizor.Util.HopeButtonType.Warning;
            btnBase64toText.DangerColor = Color.FromArgb(245, 108, 108);
            btnBase64toText.DefaultColor = Color.FromArgb(255, 255, 255);
            btnBase64toText.Font = new Font("Segoe UI", 12F);
            btnBase64toText.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnBase64toText.InfoColor = Color.FromArgb(144, 147, 153);
            btnBase64toText.Location = new Point(347, 430);
            btnBase64toText.Name = "btnBase64toText";
            btnBase64toText.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnBase64toText.Size = new Size(250, 40);
            btnBase64toText.SuccessColor = Color.FromArgb(103, 194, 58);
            btnBase64toText.TabIndex = 47;
            btnBase64toText.Text = "Base64 -> Metin";
            btnBase64toText.TextColor = Color.White;
            btnBase64toText.WarningColor = Color.FromArgb(230, 162, 60);
            btnBase64toText.Click += btnTexttoBase64_Click;
            // 
            // txtDecodedData
            // 
            txtDecodedData.AutoWordSelection = false;
            txtDecodedData.BackColor = Color.Transparent;
            txtDecodedData.BorderColor = Color.FromArgb(180, 180, 180);
            txtDecodedData.EdgeColor = Color.White;
            txtDecodedData.Font = new Font("Tahoma", 10F);
            txtDecodedData.ForeColor = Color.FromArgb(76, 76, 76);
            txtDecodedData.Location = new Point(29, 249);
            txtDecodedData.Name = "txtDecodedData";
            txtDecodedData.ReadOnly = true;
            txtDecodedData.Size = new Size(892, 165);
            txtDecodedData.TabIndex = 46;
            txtDecodedData.TextBackColor = Color.White;
            txtDecodedData.WordWrap = true;
            // 
            // d_lbldata
            // 
            d_lbldata.AutoSize = true;
            d_lbldata.BackColor = Color.Transparent;
            d_lbldata.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            d_lbldata.ForeColor = Color.White;
            d_lbldata.Location = new Point(29, 225);
            d_lbldata.Name = "d_lbldata";
            d_lbldata.Size = new Size(40, 21);
            d_lbldata.TabIndex = 45;
            d_lbldata.Text = "Veri;";
            // 
            // txtEncodedBase64
            // 
            txtEncodedBase64.AutoWordSelection = false;
            txtEncodedBase64.BackColor = Color.Transparent;
            txtEncodedBase64.BorderColor = Color.FromArgb(180, 180, 180);
            txtEncodedBase64.EdgeColor = Color.White;
            txtEncodedBase64.Font = new Font("Tahoma", 10F);
            txtEncodedBase64.ForeColor = Color.FromArgb(76, 76, 76);
            txtEncodedBase64.Location = new Point(29, 46);
            txtEncodedBase64.Name = "txtEncodedBase64";
            txtEncodedBase64.ReadOnly = false;
            txtEncodedBase64.Size = new Size(892, 165);
            txtEncodedBase64.TabIndex = 44;
            txtEncodedBase64.TextBackColor = Color.White;
            txtEncodedBase64.WordWrap = true;
            // 
            // lblinfo2
            // 
            lblinfo2.AutoSize = true;
            lblinfo2.BackColor = Color.Transparent;
            lblinfo2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblinfo2.ForeColor = Color.White;
            lblinfo2.Location = new Point(29, 22);
            lblinfo2.Name = "lblinfo2";
            lblinfo2.Size = new Size(63, 21);
            lblinfo2.TabIndex = 43;
            lblinfo2.Text = "Base64;";
            // 
            // controlBox1
            // 
            controlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBox1.BackColor = Color.FromArgb(32, 34, 37);
            controlBox1.CloseHoverColor = Color.FromArgb(230, 17, 35);
            controlBox1.DefaultLocation = true;
            controlBox1.EnableHoverHighlight = true;
            controlBox1.EnableMaximizeButton = false;
            controlBox1.EnableMinimizeButton = true;
            controlBox1.ForeColor = Color.FromArgb(155, 155, 155);
            controlBox1.Location = new Point(865, 18);
            controlBox1.MaximizeHoverColor = Color.FromArgb(74, 74, 74);
            controlBox1.MinimizeHoverColor = Color.FromArgb(63, 63, 65);
            controlBox1.Name = "controlBox1";
            controlBox1.Size = new Size(90, 25);
            controlBox1.TabIndex = 0;
            controlBox1.Text = "controlBox1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 51, 63);
            panel1.Controls.Add(lblSecretkey);
            panel1.Controls.Add(txtSecretKey);
            panel1.Dock = DockStyle.Top;
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(10, 70);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(945, 65);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 29;
            // 
            // lblSecretkey
            // 
            lblSecretkey.BackColor = Color.Transparent;
            lblSecretkey.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSecretkey.ForeColor = Color.White;
            lblSecretkey.Location = new Point(51, 23);
            lblSecretkey.Name = "lblSecretkey";
            lblSecretkey.Size = new Size(100, 21);
            lblSecretkey.TabIndex = 28;
            lblSecretkey.Text = "Gizli anahtar:";
            // 
            // txtSecretKey
            // 
            txtSecretKey.BackColor = Color.Transparent;
            txtSecretKey.Font = new Font("Tahoma", 11F);
            txtSecretKey.ForeColor = Color.DimGray;
            txtSecretKey.Image = null;
            txtSecretKey.Location = new Point(203, 14);
            txtSecretKey.MaxLength = 500;
            txtSecretKey.Multiline = false;
            txtSecretKey.Name = "txtSecretKey";
            txtSecretKey.ReadOnly = false;
            txtSecretKey.Size = new Size(678, 41);
            txtSecretKey.TabIndex = 31;
            txtSecretKey.TextAlignment = HorizontalAlignment.Left;
            txtSecretKey.UseSystemPasswordChar = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 707);
            Controls.Add(themeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(261, 61);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecureBase .NET App";
            TransparencyKey = Color.Fuchsia;
            themeForm1.ResumeLayout(false);
            hopeTabPage1.ResumeLayout(false);
            pageEncoding.ResumeLayout(false);
            pageEncoding.PerformLayout();
            pageDecoding.ResumeLayout(false);
            pageDecoding.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private TabPage pageEncoding;
        private ReaLTaiizor.Controls.HopeButton btnTexttoBase64;
        private ReaLTaiizor.Controls.DungeonRichTextBox txtData;
        private ReaLTaiizor.Controls.BigTextBox txtSecretKey;
        private ReaLTaiizor.Controls.NightLabel lblinfo1;
        private ReaLTaiizor.Controls.NightLabel e_lbldata;
        private ReaLTaiizor.Controls.NightLabel lblSecretkey;
        private ReaLTaiizor.Controls.DungeonRichTextBox txtBase64;
        private ReaLTaiizor.Controls.ForeverStatusBar statusbar;
        private ReaLTaiizor.Controls.Panel panel1;
        private TabPage pageDecoding;
        private ReaLTaiizor.Controls.HopeButton btnBase64toText;
        private ReaLTaiizor.Controls.DungeonRichTextBox txtDecodedData;
        private ReaLTaiizor.Controls.NightLabel d_lbldata;
        private ReaLTaiizor.Controls.DungeonRichTextBox txtEncodedBase64;
        private ReaLTaiizor.Controls.NightLabel lblinfo2;
        private ReaLTaiizor.Controls.ForeverButton btnLang;
    }
}
