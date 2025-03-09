namespace DerinlemesineKodlama101
{
    partial class Form1
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
        private void InitializeComponent()
        {
            button1 = new Button();
            txtAdSoyad = new TextBox();
            label1 = new Label();
            txtTCKimlik = new TextBox();
            txtDersNotu = new TextBox();
            button2 = new Button();
            txtProductName = new TextBox();
            txtUnitPrice = new TextBox();
            lblMesaj = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(317, 272);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(220, 68);
            button1.TabIndex = 0;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(40, 76);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(497, 47);
            txtAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 20);
            label1.Name = "label1";
            label1.Size = new Size(145, 41);
            label1.TabIndex = 2;
            label1.Text = "Ad Soyad";
            // 
            // txtTCKimlik
            // 
            txtTCKimlik.Location = new Point(40, 129);
            txtTCKimlik.Name = "txtTCKimlik";
            txtTCKimlik.Size = new Size(497, 47);
            txtTCKimlik.TabIndex = 1;
            // 
            // txtDersNotu
            // 
            txtDersNotu.Location = new Point(40, 182);
            txtDersNotu.Name = "txtDersNotu";
            txtDersNotu.Size = new Size(497, 47);
            txtDersNotu.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(868, 182);
            button2.Name = "button2";
            button2.Size = new Size(193, 53);
            button2.TabIndex = 3;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(587, 76);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(474, 47);
            txtProductName.TabIndex = 4;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(587, 129);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(474, 47);
            txtUnitPrice.TabIndex = 4;
            // 
            // lblMesaj
            // 
            lblMesaj.Location = new Point(587, 272);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(474, 90);
            lblMesaj.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1097, 434);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(button2);
            Controls.Add(lblMesaj);
            Controls.Add(label1);
            Controls.Add(txtDersNotu);
            Controls.Add(txtTCKimlik);
            Controls.Add(txtAdSoyad);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtAdSoyad;
        private Label label1;
        private TextBox txtTCKimlik;
        private TextBox txtDersNotu;
        private Button button2;
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private Label lblMesaj;
    }
}
