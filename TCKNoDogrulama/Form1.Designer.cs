
namespace TCKNoDogrulama
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tcKutusu = new Guna.UI2.WinForms.Guna2TextBox();
            this.adKutusu = new Guna.UI2.WinForms.Guna2TextBox();
            this.soyadKutusu = new Guna.UI2.WinForms.Guna2TextBox();
            this.yilSecici = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dogrulaBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.ResizeForm = false;
            // 
            // tcKutusu
            // 
            this.tcKutusu.Animated = true;
            this.tcKutusu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tcKutusu.DefaultText = "";
            this.tcKutusu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tcKutusu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tcKutusu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tcKutusu.DisabledState.Parent = this.tcKutusu;
            this.tcKutusu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tcKutusu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tcKutusu.FocusedState.Parent = this.tcKutusu;
            this.tcKutusu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tcKutusu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tcKutusu.HoverState.Parent = this.tcKutusu;
            this.tcKutusu.Location = new System.Drawing.Point(12, 35);
            this.tcKutusu.Name = "tcKutusu";
            this.tcKutusu.PasswordChar = '\0';
            this.tcKutusu.PlaceholderText = "TC Kimlik";
            this.tcKutusu.SelectedText = "";
            this.tcKutusu.ShadowDecoration.Parent = this.tcKutusu;
            this.tcKutusu.Size = new System.Drawing.Size(367, 36);
            this.tcKutusu.TabIndex = 0;
            // 
            // adKutusu
            // 
            this.adKutusu.Animated = true;
            this.adKutusu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adKutusu.DefaultText = "";
            this.adKutusu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adKutusu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adKutusu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adKutusu.DisabledState.Parent = this.adKutusu;
            this.adKutusu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adKutusu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adKutusu.FocusedState.Parent = this.adKutusu;
            this.adKutusu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adKutusu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adKutusu.HoverState.Parent = this.adKutusu;
            this.adKutusu.Location = new System.Drawing.Point(12, 77);
            this.adKutusu.Name = "adKutusu";
            this.adKutusu.PasswordChar = '\0';
            this.adKutusu.PlaceholderText = "Ad";
            this.adKutusu.SelectedText = "";
            this.adKutusu.ShadowDecoration.Parent = this.adKutusu;
            this.adKutusu.Size = new System.Drawing.Size(181, 36);
            this.adKutusu.TabIndex = 1;
            // 
            // soyadKutusu
            // 
            this.soyadKutusu.Animated = true;
            this.soyadKutusu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soyadKutusu.DefaultText = "";
            this.soyadKutusu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.soyadKutusu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.soyadKutusu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.soyadKutusu.DisabledState.Parent = this.soyadKutusu;
            this.soyadKutusu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.soyadKutusu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.soyadKutusu.FocusedState.Parent = this.soyadKutusu;
            this.soyadKutusu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.soyadKutusu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.soyadKutusu.HoverState.Parent = this.soyadKutusu;
            this.soyadKutusu.Location = new System.Drawing.Point(198, 77);
            this.soyadKutusu.Name = "soyadKutusu";
            this.soyadKutusu.PasswordChar = '\0';
            this.soyadKutusu.PlaceholderText = "Soyad";
            this.soyadKutusu.SelectedText = "";
            this.soyadKutusu.ShadowDecoration.Parent = this.soyadKutusu;
            this.soyadKutusu.Size = new System.Drawing.Size(181, 36);
            this.soyadKutusu.TabIndex = 2;
            // 
            // yilSecici
            // 
            this.yilSecici.Animated = true;
            this.yilSecici.BackColor = System.Drawing.Color.Transparent;
            this.yilSecici.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.yilSecici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yilSecici.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yilSecici.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yilSecici.FocusedState.Parent = this.yilSecici;
            this.yilSecici.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.yilSecici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.yilSecici.HoverState.Parent = this.yilSecici;
            this.yilSecici.ItemHeight = 30;
            this.yilSecici.ItemsAppearance.Parent = this.yilSecici;
            this.yilSecici.Location = new System.Drawing.Point(12, 119);
            this.yilSecici.Name = "yilSecici";
            this.yilSecici.ShadowDecoration.Parent = this.yilSecici;
            this.yilSecici.Size = new System.Drawing.Size(367, 36);
            this.yilSecici.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(345, -2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 5;
            // 
            // dogrulaBtn
            // 
            this.dogrulaBtn.Animated = true;
            this.dogrulaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.dogrulaBtn.CheckedState.Parent = this.dogrulaBtn;
            this.dogrulaBtn.CustomImages.Parent = this.dogrulaBtn;
            this.dogrulaBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.dogrulaBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dogrulaBtn.ForeColor = System.Drawing.Color.White;
            this.dogrulaBtn.HoverState.Parent = this.dogrulaBtn;
            this.dogrulaBtn.Location = new System.Drawing.Point(0, 162);
            this.dogrulaBtn.Name = "dogrulaBtn";
            this.dogrulaBtn.ShadowDecoration.Parent = this.dogrulaBtn;
            this.dogrulaBtn.Size = new System.Drawing.Size(390, 46);
            this.dogrulaBtn.TabIndex = 6;
            this.dogrulaBtn.Text = "Doğrula";
            this.dogrulaBtn.Click += new System.EventHandler(this.dogrulaBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 27);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(390, 135);
            this.guna2Panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "TC Kimlik No Doğrulayıcı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(391, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dogrulaBtn);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.yilSecici);
            this.Controls.Add(this.soyadKutusu);
            this.Controls.Add(this.adKutusu);
            this.Controls.Add(this.tcKutusu);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Kimlik Doğrulama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox tcKutusu;
        private Guna.UI2.WinForms.Guna2TextBox soyadKutusu;
        private Guna.UI2.WinForms.Guna2TextBox adKutusu;
        private Guna.UI2.WinForms.Guna2ComboBox yilSecici;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button dogrulaBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
    }
}

