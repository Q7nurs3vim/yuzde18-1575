namespace sayınınyuzde18inialma_1575
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
            label1 = new Label();
            btnHesapla = new Button();
            txtSayi = new TextBox();
            label2 = new Label();
            txtSonuc = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simple Outline Pat", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(129, 24);
            label1.TabIndex = 0;
            label1.Text = "Bir Sayı Girin :";
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.PaleGreen;
            btnHesapla.Location = new Point(281, 20);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(171, 27);
            btnHesapla.TabIndex = 1;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // txtSayi
            // 
            txtSayi.Location = new Point(142, 20);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(125, 27);
            txtSayi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 3;
            label2.Text = "SONUÇ :";
            // 
            // txtSonuc
            // 
            txtSonuc.Enabled = false;
            txtSonuc.Location = new Point(144, 65);
            txtSonuc.Name = "txtSonuc";
            txtSonuc.Size = new Size(125, 27);
            txtSonuc.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(464, 99);
            Controls.Add(txtSonuc);
            Controls.Add(label2);
            Controls.Add(txtSayi);
            Controls.Add(btnHesapla);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnHesapla;
        private TextBox txtSayi;
        private Label label2;
        private TextBox txtSonuc;
    }
}