namespace Harjoitus_3
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
            this.luku1TB = new System.Windows.Forms.TextBox();
            this.luku2TB = new System.Windows.Forms.TextBox();
            this.laskuToimitusCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.laskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // luku1TB
            // 
            this.luku1TB.Location = new System.Drawing.Point(52, 60);
            this.luku1TB.Name = "luku1TB";
            this.luku1TB.Size = new System.Drawing.Size(150, 50);
            this.luku1TB.TabIndex = 0;
            this.luku1TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // luku2TB
            // 
            this.luku2TB.Location = new System.Drawing.Point(418, 60);
            this.luku2TB.Name = "luku2TB";
            this.luku2TB.Size = new System.Drawing.Size(150, 50);
            this.luku2TB.TabIndex = 1;
            // 
            // laskuToimitusCB
            // 
            this.laskuToimitusCB.FormattingEnabled = true;
            this.laskuToimitusCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.laskuToimitusCB.Location = new System.Drawing.Point(218, 60);
            this.laskuToimitusCB.Name = "laskuToimitusCB";
            this.laskuToimitusCB.Size = new System.Drawing.Size(182, 53);
            this.laskuToimitusCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(641, 60);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(35, 45);
            this.vastausLB.TabIndex = 4;
            this.vastausLB.Text = "x";
            this.vastausLB.Visible = false;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(720, 68);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(169, 59);
            this.laskeBT.TabIndex = 5;
            this.laskeBT.Text = "Laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laskuToimitusCB);
            this.Controls.Add(this.luku2TB);
            this.Controls.Add(this.luku1TB);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Harjoitus 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox luku1TB;
        private TextBox luku2TB;
        private ComboBox laskuToimitusCB;
        private Label label1;
        private Label vastausLB;
        private Button laskeBT;
    }
}