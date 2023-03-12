namespace Roomalaiset
{
    partial class RoomalaisiksiForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TekstiTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.MuutaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(251, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(561, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna numero väliltä 1-3999 niin muutan sen roomalaiseksi:";
            // 
            // TekstiTB
            // 
            this.TekstiTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TekstiTB.Location = new System.Drawing.Point(592, 96);
            this.TekstiTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TekstiTB.Name = "TekstiTB";
            this.TekstiTB.Size = new System.Drawing.Size(106, 35);
            this.TekstiTB.TabIndex = 2;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(85, 179);
            this.VastausLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(121, 51);
            this.VastausLB.TabIndex = 3;
            this.VastausLB.Text = "label3";
            this.VastausLB.Visible = false;
            // 
            // MuutaBT
            // 
            this.MuutaBT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MuutaBT.Location = new System.Drawing.Point(409, 193);
            this.MuutaBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(105, 44);
            this.MuutaBT.TabIndex = 4;
            this.MuutaBT.Text = "Muuta!";
            this.MuutaBT.UseVisualStyleBackColor = true;
            this.MuutaBT.Click += new System.EventHandler(this.MuutaBT_Click);
            // 
            // RoomalaisiksiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(833, 326);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.TekstiTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RoomalaisiksiForm";
            this.Text = "Muuta roomalaisiksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TekstiTB;
        private Label VastausLB;
        private Button MuutaBT;
    }
}