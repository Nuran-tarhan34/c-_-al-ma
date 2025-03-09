namespace DerinlemesineKodlama101
{
    partial class Form3
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
            btnEkle = new Button();
            txtOgrenciAdi = new TextBox();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(39, 110);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(563, 56);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Diziye Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtOgrenciAdi
            // 
            txtOgrenciAdi.Location = new Point(39, 57);
            txtOgrenciAdi.Name = "txtOgrenciAdi";
            txtOgrenciAdi.Size = new Size(563, 47);
            txtOgrenciAdi.TabIndex = 1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(664, 238);
            Controls.Add(txtOgrenciAdi);
            Controls.Add(btnEkle);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private TextBox txtOgrenciAdi;
    }
}