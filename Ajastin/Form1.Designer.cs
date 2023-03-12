namespace Ajastin
{
    partial class AjastinForm
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
            this.components = new System.ComponentModel.Container();
            this.MinuutitLB = new System.Windows.Forms.Label();
            this.SekunnitLB = new System.Windows.Forms.Label();
            this.ajastinLB = new System.Windows.Forms.Label();
            this.minuutitCB = new System.Windows.Forms.ComboBox();
            this.sekunnitCB = new System.Windows.Forms.ComboBox();
            this.kaynnistaBT = new System.Windows.Forms.Button();
            this.pysaytaBT = new System.Windows.Forms.Button();
            this.ajastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MinuutitLB
            // 
            this.MinuutitLB.AutoSize = true;
            this.MinuutitLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinuutitLB.Location = new System.Drawing.Point(45, 24);
            this.MinuutitLB.Name = "MinuutitLB";
            this.MinuutitLB.Size = new System.Drawing.Size(106, 32);
            this.MinuutitLB.TabIndex = 0;
            this.MinuutitLB.Text = "Minuutit";
            // 
            // SekunnitLB
            // 
            this.SekunnitLB.AutoSize = true;
            this.SekunnitLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SekunnitLB.Location = new System.Drawing.Point(301, 24);
            this.SekunnitLB.Name = "SekunnitLB";
            this.SekunnitLB.Size = new System.Drawing.Size(93, 30);
            this.SekunnitLB.TabIndex = 1;
            this.SekunnitLB.Text = "Sekunnit";
            // 
            // ajastinLB
            // 
            this.ajastinLB.AutoSize = true;
            this.ajastinLB.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ajastinLB.Location = new System.Drawing.Point(45, 115);
            this.ajastinLB.Name = "ajastinLB";
            this.ajastinLB.Size = new System.Drawing.Size(408, 128);
            this.ajastinLB.TabIndex = 2;
            this.ajastinLB.Text = "00:00:00";
            // 
            // minuutitCB
            // 
            this.minuutitCB.FormattingEnabled = true;
            this.minuutitCB.Location = new System.Drawing.Point(45, 74);
            this.minuutitCB.Name = "minuutitCB";
            this.minuutitCB.Size = new System.Drawing.Size(182, 28);
            this.minuutitCB.TabIndex = 3;
            // 
            // sekunnitCB
            // 
            this.sekunnitCB.FormattingEnabled = true;
            this.sekunnitCB.Location = new System.Drawing.Point(271, 74);
            this.sekunnitCB.Name = "sekunnitCB";
            this.sekunnitCB.Size = new System.Drawing.Size(182, 28);
            this.sekunnitCB.TabIndex = 4;
            // 
            // kaynnistaBT
            // 
            this.kaynnistaBT.Location = new System.Drawing.Point(45, 257);
            this.kaynnistaBT.Name = "kaynnistaBT";
            this.kaynnistaBT.Size = new System.Drawing.Size(139, 50);
            this.kaynnistaBT.TabIndex = 5;
            this.kaynnistaBT.Text = "Käynnistä";
            this.kaynnistaBT.UseVisualStyleBackColor = true;
            this.kaynnistaBT.Click += new System.EventHandler(this.KaynnistaBT_Click);
            // 
            // pysaytaBT
            // 
            this.pysaytaBT.Location = new System.Drawing.Point(314, 257);
            this.pysaytaBT.Name = "pysaytaBT";
            this.pysaytaBT.Size = new System.Drawing.Size(139, 50);
            this.pysaytaBT.TabIndex = 6;
            this.pysaytaBT.Text = "Pysäytä";
            this.pysaytaBT.UseVisualStyleBackColor = true;
            this.pysaytaBT.Click += new System.EventHandler(this.PysaytaBT_Click);
            // 
            // ajastinTM
            // 
            this.ajastinTM.Interval = 1000;
            this.ajastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // AjastinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 332);
            this.Controls.Add(this.pysaytaBT);
            this.Controls.Add(this.kaynnistaBT);
            this.Controls.Add(this.sekunnitCB);
            this.Controls.Add(this.minuutitCB);
            this.Controls.Add(this.ajastinLB);
            this.Controls.Add(this.SekunnitLB);
            this.Controls.Add(this.MinuutitLB);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AjastinForm";
            this.Text = "Ajastin";
            this.Load += new System.EventHandler(this.AjastinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MinuutitLB;
        private Label SekunnitLB;
        private Label ajastinLB;
        private ComboBox minuutitCB;
        private ComboBox sekunnitCB;
        private Button kaynnistaBT;
        private Button pysaytaBT;
        private System.Windows.Forms.Timer ajastinTM;
    }
}