namespace NopanHeitto
{
    partial class Nopanheitto
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
            this.Noppa01PB = new System.Windows.Forms.PictureBox();
            this.Noppa02PB = new System.Windows.Forms.PictureBox();
            this.HeitaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nopanheitto";
            // 
            // Noppa01PB
            // 
            this.Noppa01PB.Image = global::NopanHeitto.Properties.Resources.dice01;
            this.Noppa01PB.Location = new System.Drawing.Point(77, 105);
            this.Noppa01PB.Name = "Noppa01PB";
            this.Noppa01PB.Size = new System.Drawing.Size(176, 176);
            this.Noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa01PB.TabIndex = 1;
            this.Noppa01PB.TabStop = false;
            // 
            // Noppa02PB
            // 
            this.Noppa02PB.Image = global::NopanHeitto.Properties.Resources.dice01;
            this.Noppa02PB.Location = new System.Drawing.Point(278, 105);
            this.Noppa02PB.Name = "Noppa02PB";
            this.Noppa02PB.Size = new System.Drawing.Size(185, 176);
            this.Noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa02PB.TabIndex = 2;
            this.Noppa02PB.TabStop = false;
            // 
            // HeitaBT
            // 
            this.HeitaBT.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeitaBT.Location = new System.Drawing.Point(77, 299);
            this.HeitaBT.Name = "HeitaBT";
            this.HeitaBT.Size = new System.Drawing.Size(386, 76);
            this.HeitaBT.TabIndex = 3;
            this.HeitaBT.Text = "Heitä noppaa";
            this.HeitaBT.UseVisualStyleBackColor = true;
            this.HeitaBT.Click += new System.EventHandler(this.HeitaBT_Click);
            // 
            // Nopanheitto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 428);
            this.Controls.Add(this.HeitaBT);
            this.Controls.Add(this.Noppa02PB);
            this.Controls.Add(this.Noppa01PB);
            this.Controls.Add(this.label1);
            this.Name = "Nopanheitto";
            this.Text = "Nopan heitto";
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox Noppa01PB;
        private PictureBox Noppa02PB;
        private Button HeitaBT;
    }
}