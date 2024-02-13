namespace Variable_Practice
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
            this.hockeybutton = new System.Windows.Forms.Button();
            this.areabutton = new System.Windows.Forms.Button();
            this.carpetbutton = new System.Windows.Forms.Button();
            this.billbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hockeybutton
            // 
            this.hockeybutton.Location = new System.Drawing.Point(31, 54);
            this.hockeybutton.Name = "hockeybutton";
            this.hockeybutton.Size = new System.Drawing.Size(146, 53);
            this.hockeybutton.TabIndex = 0;
            this.hockeybutton.Text = "Hockey";
            this.hockeybutton.UseVisualStyleBackColor = true;
            this.hockeybutton.Click += new System.EventHandler(this.hockeybutton_Click);
            // 
            // areabutton
            // 
            this.areabutton.Location = new System.Drawing.Point(31, 139);
            this.areabutton.Name = "areabutton";
            this.areabutton.Size = new System.Drawing.Size(146, 53);
            this.areabutton.TabIndex = 1;
            this.areabutton.Text = "Area";
            this.areabutton.UseVisualStyleBackColor = true;
            // 
            // carpetbutton
            // 
            this.carpetbutton.Location = new System.Drawing.Point(31, 223);
            this.carpetbutton.Name = "carpetbutton";
            this.carpetbutton.Size = new System.Drawing.Size(146, 53);
            this.carpetbutton.TabIndex = 2;
            this.carpetbutton.Text = "Carpet";
            this.carpetbutton.UseVisualStyleBackColor = true;
            // 
            // billbutton
            // 
            this.billbutton.Location = new System.Drawing.Point(31, 308);
            this.billbutton.Name = "billbutton";
            this.billbutton.Size = new System.Drawing.Size(146, 53);
            this.billbutton.TabIndex = 3;
            this.billbutton.Text = "Bill";
            this.billbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(210, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 307);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(715, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billbutton);
            this.Controls.Add(this.carpetbutton);
            this.Controls.Add(this.areabutton);
            this.Controls.Add(this.hockeybutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hockeybutton;
        private System.Windows.Forms.Button areabutton;
        private System.Windows.Forms.Button carpetbutton;
        private System.Windows.Forms.Button billbutton;
        private System.Windows.Forms.Label label1;
    }
}

