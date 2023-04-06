namespace Sekuntikello
{
    partial class SekkariForm
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
            components = new System.ComponentModel.Container();
            aikaLB = new Label();
            KaynnistaBT = new Button();
            LopetaBT = new Button();
            TyhjennaBT = new Button();
            AjastinTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // aikaLB
            // 
            aikaLB.AutoSize = true;
            aikaLB.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            aikaLB.Location = new Point(213, 121);
            aikaLB.Name = "aikaLB";
            aikaLB.Size = new Size(585, 128);
            aikaLB.TabIndex = 0;
            aikaLB.Text = "00:00:00:000";
            // 
            // KaynnistaBT
            // 
            KaynnistaBT.Location = new Point(45, 265);
            KaynnistaBT.Name = "KaynnistaBT";
            KaynnistaBT.Size = new Size(237, 88);
            KaynnistaBT.TabIndex = 1;
            KaynnistaBT.Text = "Käynnistä";
            KaynnistaBT.UseVisualStyleBackColor = true;
            KaynnistaBT.Click += KaynnistaBT_Click_1;
            // 
            // LopetaBT
            // 
            LopetaBT.Location = new Point(392, 265);
            LopetaBT.Name = "LopetaBT";
            LopetaBT.Size = new Size(237, 88);
            LopetaBT.TabIndex = 2;
            LopetaBT.Text = "Lopeta";
            LopetaBT.UseVisualStyleBackColor = true;
            LopetaBT.Click += LopetaBT_Click_1;
            // 
            // TyhjennaBT
            // 
            TyhjennaBT.Location = new Point(739, 265);
            TyhjennaBT.Name = "TyhjennaBT";
            TyhjennaBT.Size = new Size(237, 88);
            TyhjennaBT.TabIndex = 3;
            TyhjennaBT.Text = "Tyhjennä";
            TyhjennaBT.UseVisualStyleBackColor = true;
            TyhjennaBT.Click += TyhjennaBT_Click_1;
            // 
            // AjastinTM
            // 
            AjastinTM.Enabled = true;
            AjastinTM.Tick += AjastinTM_Tick_1;
            // 
            // SekkariForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 485);
            Controls.Add(aikaLB);
            Controls.Add(TyhjennaBT);
            Controls.Add(LopetaBT);
            Controls.Add(KaynnistaBT);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "SekkariForm";
            Text = "Sekuntikello";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label aikaLB;
        private Button KaynnistaBT;
        private Button LopetaBT;
        private Button TyhjennaBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}