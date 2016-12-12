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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKisi = new DevLib.ModernUI.Forms.ModernTile();
            this.btnSabitler = new DevLib.ModernUI.Forms.ModernTile();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Location = new System.Drawing.Point(1, 466);
            this.StatusStrip.Size = new System.Drawing.Size(552, 20);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(464, 27);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 473);
            this.ColorStyle = DevLib.ModernUI.Forms.ModernColorStyle.Purple;
            this.Controls.Add(this.btnSabitler);
            this.Controls.Add(this.btnKisi);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form1";
            this.ShowStatusStrip = true;
            this.Text = "4C Maaş Hesap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.StatusStrip, 0);
            this.Controls.SetChildIndex(this.btnKisi, 0);
            this.Controls.SetChildIndex(this.btnSabitler, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevLib.ModernUI.Forms.ModernTile btnKisi;
        private DevLib.ModernUI.Forms.ModernTile btnSabitler;
    }
}

