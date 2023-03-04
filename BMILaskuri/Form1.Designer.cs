namespace BMILaskuri
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
            this.PainoLB = new System.Windows.Forms.Label();
            this.PituusLB = new System.Windows.Forms.Label();
            this.PainoTB = new System.Windows.Forms.TextBox();
            this.PituusTB = new System.Windows.Forms.TextBox();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.KuvausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PainoLB
            // 
            this.PainoLB.AutoSize = true;
            this.PainoLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PainoLB.Location = new System.Drawing.Point(77, 61);
            this.PainoLB.Name = "PainoLB";
            this.PainoLB.Size = new System.Drawing.Size(141, 32);
            this.PainoLB.TabIndex = 0;
            this.PainoLB.Text = "Anna paino:";
            // 
            // PituusLB
            // 
            this.PituusLB.AutoSize = true;
            this.PituusLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PituusLB.Location = new System.Drawing.Point(73, 126);
            this.PituusLB.Name = "PituusLB";
            this.PituusLB.Size = new System.Drawing.Size(147, 32);
            this.PituusLB.TabIndex = 1;
            this.PituusLB.Text = "Anna pituus:";
            // 
            // PainoTB
            // 
            this.PainoTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PainoTB.Location = new System.Drawing.Point(258, 59);
            this.PainoTB.Name = "PainoTB";
            this.PainoTB.Size = new System.Drawing.Size(150, 31);
            this.PainoTB.TabIndex = 2;
            // 
            // PituusTB
            // 
            this.PituusTB.Location = new System.Drawing.Point(258, 129);
            this.PituusTB.Name = "PituusTB";
            this.PituusTB.Size = new System.Drawing.Size(150, 31);
            this.PituusTB.TabIndex = 3;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskeBT.Location = new System.Drawing.Point(77, 200);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(331, 61);
            this.LaskeBT.TabIndex = 4;
            this.LaskeBT.Text = "Laske painoindeksi";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(88, 318);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(100, 32);
            this.VastausLB.TabIndex = 5;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // KuvausLB
            // 
            this.KuvausLB.AutoSize = true;
            this.KuvausLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KuvausLB.Location = new System.Drawing.Point(92, 403);
            this.KuvausLB.Name = "KuvausLB";
            this.KuvausLB.Size = new System.Drawing.Size(97, 32);
            this.KuvausLB.TabIndex = 6;
            this.KuvausLB.Text = "Kuvaus";
            this.KuvausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 499);
            this.Controls.Add(this.KuvausLB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.PituusTB);
            this.Controls.Add(this.PainoTB);
            this.Controls.Add(this.PituusLB);
            this.Controls.Add(this.PainoLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PainoLB;
        private Label PituusLB;
        private TextBox PainoTB;
        private TextBox PituusTB;
        private Button LaskeBT;
        private Label VastausLB;
        private Label KuvausLB;
    }
}