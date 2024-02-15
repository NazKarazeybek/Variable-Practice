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
            this.hockeyButton = new System.Windows.Forms.Button();
            this.areaButton = new System.Windows.Forms.Button();
            this.carpetButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hockeyButton
            // 
            this.hockeyButton.Location = new System.Drawing.Point(31, 54);
            this.hockeyButton.Name = "hockeyButton";
            this.hockeyButton.Size = new System.Drawing.Size(146, 53);
            this.hockeyButton.TabIndex = 0;
            this.hockeyButton.Text = "Hockey";
            this.hockeyButton.UseVisualStyleBackColor = true;
            this.hockeyButton.Click += new System.EventHandler(this.hockeyButton_Click);
            // 
            // areaButton
            // 
            this.areaButton.Location = new System.Drawing.Point(31, 139);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(146, 53);
            this.areaButton.TabIndex = 1;
            this.areaButton.Text = "Area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // carpetButton
            // 
            this.carpetButton.Location = new System.Drawing.Point(31, 223);
            this.carpetButton.Name = "carpetButton";
            this.carpetButton.Size = new System.Drawing.Size(146, 53);
            this.carpetButton.TabIndex = 2;
            this.carpetButton.Text = "Carpet";
            this.carpetButton.UseVisualStyleBackColor = true;
            this.carpetButton.Click += new System.EventHandler(this.carpetButton_Click);
            // 
            // billButton
            // 
            this.billButton.Location = new System.Drawing.Point(31, 308);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(146, 53);
            this.billButton.TabIndex = 3;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(210, 54);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(476, 307);
            this.outputLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(715, 397);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.carpetButton);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.hockeyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hockeyButton;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button carpetButton;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

