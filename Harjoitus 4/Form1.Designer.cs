namespace Harjoitus_4
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
            this.aikadTP = new System.Windows.Forms.DateTimePicker();
            this.vuosiLB = new System.Windows.Forms.Label();
            this.kuukausiLB = new System.Windows.Forms.Label();
            this.paivaLB = new System.Windows.Forms.Label();
            this.tuntiLB = new System.Windows.Forms.Label();
            this.minuuttiLB = new System.Windows.Forms.Label();
            this.sekuntiLB = new System.Windows.Forms.Label();
            this.laskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aikadTP
            // 
            this.aikadTP.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aikadTP.Location = new System.Drawing.Point(37, 29);
            this.aikadTP.Name = "aikadTP";
            this.aikadTP.Size = new System.Drawing.Size(537, 50);
            this.aikadTP.TabIndex = 0;
            this.aikadTP.ValueChanged += new System.EventHandler(this.aikadTP_ValueChanged);
            // 
            // vuosiLB
            // 
            this.vuosiLB.AutoSize = true;
            this.vuosiLB.Location = new System.Drawing.Point(55, 130);
            this.vuosiLB.Name = "vuosiLB";
            this.vuosiLB.Size = new System.Drawing.Size(54, 25);
            this.vuosiLB.TabIndex = 1;
            this.vuosiLB.Text = "vuosi";
            // 
            // kuukausiLB
            // 
            this.kuukausiLB.AutoSize = true;
            this.kuukausiLB.Location = new System.Drawing.Point(59, 198);
            this.kuukausiLB.Name = "kuukausiLB";
            this.kuukausiLB.Size = new System.Drawing.Size(81, 25);
            this.kuukausiLB.TabIndex = 2;
            this.kuukausiLB.Text = "kuukausi";
            // 
            // paivaLB
            // 
            this.paivaLB.AutoSize = true;
            this.paivaLB.Location = new System.Drawing.Point(53, 268);
            this.paivaLB.Name = "paivaLB";
            this.paivaLB.Size = new System.Drawing.Size(54, 25);
            this.paivaLB.TabIndex = 3;
            this.paivaLB.Text = "paiva";
            // 
            // tuntiLB
            // 
            this.tuntiLB.AutoSize = true;
            this.tuntiLB.Location = new System.Drawing.Point(439, 124);
            this.tuntiLB.Name = "tuntiLB";
            this.tuntiLB.Size = new System.Drawing.Size(48, 25);
            this.tuntiLB.TabIndex = 4;
            this.tuntiLB.Text = "tunti";
            this.tuntiLB.Click += new System.EventHandler(this.label4_Click);
            // 
            // minuuttiLB
            // 
            this.minuuttiLB.AutoSize = true;
            this.minuuttiLB.Location = new System.Drawing.Point(454, 212);
            this.minuuttiLB.Name = "minuuttiLB";
            this.minuuttiLB.Size = new System.Drawing.Size(78, 25);
            this.minuuttiLB.TabIndex = 5;
            this.minuuttiLB.Text = "minuutti";
            // 
            // sekuntiLB
            // 
            this.sekuntiLB.AutoSize = true;
            this.sekuntiLB.Location = new System.Drawing.Point(465, 284);
            this.sekuntiLB.Name = "sekuntiLB";
            this.sekuntiLB.Size = new System.Drawing.Size(68, 25);
            this.sekuntiLB.TabIndex = 6;
            this.sekuntiLB.Text = "sekunti";
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(640, 43);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(112, 34);
            this.laskeBT.TabIndex = 7;
            this.laskeBT.Text = "Laske ikä:";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.sekuntiLB);
            this.Controls.Add(this.minuuttiLB);
            this.Controls.Add(this.tuntiLB);
            this.Controls.Add(this.paivaLB);
            this.Controls.Add(this.kuukausiLB);
            this.Controls.Add(this.vuosiLB);
            this.Controls.Add(this.aikadTP);
            this.Name = "Form1";
            this.Text = "Harjoitus 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker aikadTP;
        private Label vuosiLB;
        private Label kuukausiLB;
        private Label paivaLB;
        private Label tuntiLB;
        private Label minuuttiLB;
        private Label sekuntiLB;
        private Button laskeBT;
    }
}