﻿namespace CelsiusToFahrenheit
{
    partial class AstemuunninForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FahrenheitRB = new System.Windows.Forms.RadioButton();
            this.CelsiusRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.AsteetTB = new System.Windows.Forms.TextBox();
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FahrenheitRB);
            this.groupBox1.Controls.Add(this.CelsiusRB);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(427, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miten muunnat?";
            // 
            // FahrenheitRB
            // 
            this.FahrenheitRB.AutoSize = true;
            this.FahrenheitRB.Location = new System.Drawing.Point(13, 102);
            this.FahrenheitRB.Name = "FahrenheitRB";
            this.FahrenheitRB.Size = new System.Drawing.Size(182, 42);
            this.FahrenheitRB.TabIndex = 1;
            this.FahrenheitRB.TabStop = true;
            this.FahrenheitRB.Text = "Fahrenheit";
            this.FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // CelsiusRB
            // 
            this.CelsiusRB.AutoSize = true;
            this.CelsiusRB.Location = new System.Drawing.Point(17, 46);
            this.CelsiusRB.Name = "CelsiusRB";
            this.CelsiusRB.Size = new System.Drawing.Size(131, 42);
            this.CelsiusRB.TabIndex = 0;
            this.CelsiusRB.TabStop = true;
            this.CelsiusRB.Text = "Celsius";
            this.CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anna asteet:";
            // 
            // AsteetTB
            // 
            this.AsteetTB.Location = new System.Drawing.Point(199, 105);
            this.AsteetTB.Name = "AsteetTB";
            this.AsteetTB.Size = new System.Drawing.Size(191, 31);
            this.AsteetTB.TabIndex = 2;
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.MuunnaBT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MuunnaBT.Location = new System.Drawing.Point(786, 98);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(186, 79);
            this.MuunnaBT.TabIndex = 3;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = true;
            this.MuunnaBT.Click += new System.EventHandler(this.MuunnaBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(108, 321);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(122, 38);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // AstemuunninForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 505);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.MuunnaBT);
            this.Controls.Add(this.AsteetTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AstemuunninForm";
            this.Text = "CelsiusToFahrenheit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton FahrenheitRB;
        private RadioButton CelsiusRB;
        private Label label1;
        private TextBox AsteetTB;
        private Button MuunnaBT;
        private Label VastausLB;
    }
}