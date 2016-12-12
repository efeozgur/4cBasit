namespace _4cBasit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnKisi = new DevLib.ModernUI.Forms.ModernTile();
            this.btnSabitler = new DevLib.ModernUI.Forms.ModernTile();
            this.btnKisiMaasBilgileri = new DevLib.ModernUI.Forms.ModernTile();
            this.modernTile1 = new DevLib.ModernUI.Forms.ModernTile();
            this.modernTile2 = new DevLib.ModernUI.Forms.ModernTile();
            this.modernTile3 = new DevLib.ModernUI.Forms.ModernTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Location = new System.Drawing.Point(1, 405);
            this.StatusStrip.Size = new System.Drawing.Size(470, 20);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(336, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnKisi
            // 
            this.btnKisi.ActiveControl = null;
            this.btnKisi.ColorStyle = DevLib.ModernUI.Forms.ModernColorStyle.Purple;
            this.btnKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisi.Location = new System.Drawing.Point(23, 77);
            this.btnKisi.Name = "btnKisi";
            this.btnKisi.Size = new System.Drawing.Size(139, 66);
            this.btnKisi.TabIndex = 1;
            this.btnKisi.Text = "Kişi Bilgileri";
            this.btnKisi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKisi.UseSelectable = true;
            this.btnKisi.UseStyleColors = false;
            // 
            // btnSabitler
            // 
            this.btnSabitler.ActiveControl = null;
            this.btnSabitler.ColorStyle = DevLib.ModernUI.Forms.ModernColorStyle.Red;
            this.btnSabitler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSabitler.Location = new System.Drawing.Point(168, 77);
            this.btnSabitler.Name = "btnSabitler";
            this.btnSabitler.Size = new System.Drawing.Size(139, 66);
            this.btnSabitler.TabIndex = 2;
            this.btnSabitler.Text = "Sabit Değerler";
            this.btnSabitler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSabitler.UseSelectable = true;
            this.btnSabitler.UseStyleColors = false;
            // 
            // btnKisiMaasBilgileri
            // 
            this.btnKisiMaasBilgileri.ActiveControl = null;
            this.btnKisiMaasBilgileri.ColorStyle = DevLib.ModernUI.Forms.ModernColorStyle.Green;
            this.btnKisiMaasBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiMaasBilgileri.Location = new System.Drawing.Point(313, 77);
            this.btnKisiMaasBilgileri.Name = "btnKisiMaasBilgileri";
            this.btnKisiMaasBilgileri.Size = new System.Drawing.Size(139, 66);
            this.btnKisiMaasBilgileri.TabIndex = 2;
            this.btnKisiMaasBilgileri.Text = "Kişi Maaş Bilgileri";
            this.btnKisiMaasBilgileri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKisiMaasBilgileri.UseSelectable = true;
            this.btnKisiMaasBilgileri.UseStyleColors = false;
            // 
            // modernTile1
            // 
            this.modernTile1.ActiveControl = null;
            this.modernTile1.ColorStyle = DevLib.ModernUI.Forms.ModernColorStyle.Purple;
            this.modernTile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modernTile1.Location = new System.Drawing.Point(23, 149);
            this.modernTile1.Name = "modernTile1";
            this.modernTile1.Size = new System.Drawing.Size(139, 30);
            this.modernTile1.TabIndex = 2;
            this.modernTile1.Text = "Banka Listesi";
            this.modernTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.modernTile1.UseSelectable = true;
            this.modernTile1.UseStyleColors = false;
            // 
            // modernTile2
            // 
            this.modernTile2.ActiveControl = null;
            this.modernTile2.ColorStyle = DevLib.ModernUI.Forms.ModernColorStyle.Red;
            this.modernTile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modernTile2.Location = new System.Drawing.Point(168, 149);
            this.modernTile2.Name = "modernTile2";
            this.modernTile2.Size = new System.Drawing.Size(139, 30);
            this.modernTile2.TabIndex = 3;
            this.modernTile2.Text = "Asgari Geçim İndirim";
            this.modernTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.modernTile2.UseSelectable = true;
            this.modernTile2.UseStyleColors = false;
            // 
            // modernTile3
            // 
            this.modernTile3.ActiveControl = null;
            this.modernTile3.ColorStyle = DevLib.ModernUI.Forms.ModernColorStyle.Green;
            this.modernTile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modernTile3.Location = new System.Drawing.Point(313, 149);
            this.modernTile3.Name = "modernTile3";
            this.modernTile3.Size = new System.Drawing.Size(139, 30);
            this.modernTile3.TabIndex = 4;
            this.modernTile3.Text = "Bordro";
            this.modernTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.modernTile3.UseSelectable = true;
            this.modernTile3.UseStyleColors = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::_4cBasit.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(144, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 412);
            this.ColorStyle = DevLib.ModernUI.Forms.ModernColorStyle.Purple;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.modernTile3);
            this.Controls.Add(this.modernTile2);
            this.Controls.Add(this.modernTile1);
            this.Controls.Add(this.btnKisiMaasBilgileri);
            this.Controls.Add(this.btnSabitler);
            this.Controls.Add(this.btnKisi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form1";
            this.ShowStatusStrip = true;
            this.Text = "4C Maaş Hesap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.StatusStrip, 0);
            this.Controls.SetChildIndex(this.btnKisi, 0);
            this.Controls.SetChildIndex(this.btnSabitler, 0);
            this.Controls.SetChildIndex(this.btnKisiMaasBilgileri, 0);
            this.Controls.SetChildIndex(this.modernTile1, 0);
            this.Controls.SetChildIndex(this.modernTile2, 0);
            this.Controls.SetChildIndex(this.modernTile3, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevLib.ModernUI.Forms.ModernTile btnKisi;
        private DevLib.ModernUI.Forms.ModernTile btnSabitler;
        private DevLib.ModernUI.Forms.ModernTile btnKisiMaasBilgileri;
        private DevLib.ModernUI.Forms.ModernTile modernTile1;
        private DevLib.ModernUI.Forms.ModernTile modernTile2;
        private DevLib.ModernUI.Forms.ModernTile modernTile3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

