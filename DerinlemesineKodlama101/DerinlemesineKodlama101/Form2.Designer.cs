namespace DerinlemesineKodlama101
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtMusteriTutari = new TextBox();
            label1 = new Label();
            lblSonDurum = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(49, 34);
            button1.Name = "button1";
            button1.Size = new Size(302, 79);
            button1.TabIndex = 0;
            button1.Text = "ve operatörü";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(49, 119);
            button2.Name = "button2";
            button2.Size = new Size(302, 79);
            button2.TabIndex = 0;
            button2.Text = "veya operatörü";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(708, 172);
            button3.Name = "button3";
            button3.Size = new Size(225, 65);
            button3.TabIndex = 1;
            button3.Text = "Hesapla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // txtMusteriTutari
            // 
            txtMusteriTutari.Location = new Point(433, 119);
            txtMusteriTutari.Name = "txtMusteriTutari";
            txtMusteriTutari.Size = new Size(500, 47);
            txtMusteriTutari.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(433, 72);
            label1.Name = "label1";
            label1.Size = new Size(270, 41);
            label1.TabIndex = 3;
            label1.Text = "Müşteri Satış Tutarı";
            // 
            // lblSonDurum
            // 
            lblSonDurum.Location = new Point(433, 295);
            lblSonDurum.Name = "lblSonDurum";
            lblSonDurum.Size = new Size(500, 111);
            lblSonDurum.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1028, 516);
            Controls.Add(lblSonDurum);
            Controls.Add(label1);
            Controls.Add(txtMusteriTutari);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtMusteriTutari;
        private Label label1;
        private Label lblSonDurum;
    }
}