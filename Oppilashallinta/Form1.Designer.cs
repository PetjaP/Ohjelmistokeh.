﻿namespace Oppilashallinta
{
    partial class OppilashallintaForm
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
            this.idLB = new System.Windows.Forms.Label();
            this.etunimiLB = new System.Windows.Forms.Label();
            this.sukunimiLB = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.opiskelijanroLB = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.enimiTB = new System.Windows.Forms.TextBox();
            this.snimiTB = new System.Windows.Forms.TextBox();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.opiskelijaidTB = new System.Windows.Forms.TextBox();
            this.tietotauluDG = new System.Windows.Forms.DataGridView();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // idLB
            // 
            this.idLB.AutoSize = true;
            this.idLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLB.Location = new System.Drawing.Point(29, 22);
            this.idLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLB.Name = "idLB";
            this.idLB.Size = new System.Drawing.Size(32, 24);
            this.idLB.TabIndex = 0;
            this.idLB.Text = "ID:";
            // 
            // etunimiLB
            // 
            this.etunimiLB.AutoSize = true;
            this.etunimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etunimiLB.Location = new System.Drawing.Point(29, 60);
            this.etunimiLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etunimiLB.Name = "etunimiLB";
            this.etunimiLB.Size = new System.Drawing.Size(78, 24);
            this.etunimiLB.TabIndex = 1;
            this.etunimiLB.Text = "Etunimi:";
            // 
            // sukunimiLB
            // 
            this.sukunimiLB.AutoSize = true;
            this.sukunimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sukunimiLB.Location = new System.Drawing.Point(29, 99);
            this.sukunimiLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sukunimiLB.Name = "sukunimiLB";
            this.sukunimiLB.Size = new System.Drawing.Size(93, 24);
            this.sukunimiLB.TabIndex = 2;
            this.sukunimiLB.Text = "Sukunimi:";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhelinLB.Location = new System.Drawing.Point(394, 22);
            this.puhelinLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(79, 24);
            this.puhelinLB.TabIndex = 3;
            this.puhelinLB.Text = "Puhelin:";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLB.Location = new System.Drawing.Point(394, 60);
            this.emailLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(107, 24);
            this.emailLB.TabIndex = 4;
            this.emailLB.Text = "Sähköposti:";
            // 
            // opiskelijanroLB
            // 
            this.opiskelijanroLB.AutoSize = true;
            this.opiskelijanroLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opiskelijanroLB.Location = new System.Drawing.Point(387, 99);
            this.opiskelijanroLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.opiskelijanroLB.Name = "opiskelijanroLB";
            this.opiskelijanroLB.Size = new System.Drawing.Size(162, 24);
            this.opiskelijanroLB.TabIndex = 5;
            this.opiskelijanroLB.Text = "Opiskelijanumero:";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(138, 27);
            this.idTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(217, 20);
            this.idTB.TabIndex = 6;
          
            // 
            // enimiTB
            // 
            this.enimiTB.Location = new System.Drawing.Point(138, 60);
            this.enimiTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enimiTB.Name = "enimiTB";
            this.enimiTB.Size = new System.Drawing.Size(217, 20);
            this.enimiTB.TabIndex = 7;
            // 
            // snimiTB
            // 
            this.snimiTB.Location = new System.Drawing.Point(138, 103);
            this.snimiTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.snimiTB.Name = "snimiTB";
            this.snimiTB.Size = new System.Drawing.Size(217, 20);
            this.snimiTB.TabIndex = 8;
            // 
            // puhelinTB
            // 
            this.puhelinTB.Location = new System.Drawing.Point(514, 26);
            this.puhelinTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(217, 20);
            this.puhelinTB.TabIndex = 9;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(514, 64);
            this.emailTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(217, 20);
            this.emailTB.TabIndex = 10;
            // 
            // opiskelijaidTB
            // 
            this.opiskelijaidTB.Location = new System.Drawing.Point(554, 103);
            this.opiskelijaidTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.opiskelijaidTB.Name = "opiskelijaidTB";
            this.opiskelijaidTB.Size = new System.Drawing.Size(177, 20);
            this.opiskelijaidTB.TabIndex = 11;
            // 
            // tietotauluDG
            // 
            this.tietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tietotauluDG.Location = new System.Drawing.Point(8, 164);
            this.tietotauluDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tietotauluDG.Name = "tietotauluDG";
            this.tietotauluDG.RowHeadersWidth = 62;
            this.tietotauluDG.RowTemplate.Height = 28;
            this.tietotauluDG.Size = new System.Drawing.Size(745, 211);
            this.tietotauluDG.TabIndex = 12;
            this.tietotauluDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tietotauluDG_CellClick);
            
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(37, 126);
            this.tyhjennaBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(154, 31);
            this.tyhjennaBT.TabIndex = 13;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // tallennaBT
            // 
            this.tallennaBT.Location = new System.Drawing.Point(217, 126);
            this.tallennaBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(154, 31);
            this.tallennaBT.TabIndex = 14;
            this.tallennaBT.Text = "Tallenna";
            this.tallennaBT.UseVisualStyleBackColor = true;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click);
            // 
            // paivitaBT
            // 
            this.paivitaBT.Location = new System.Drawing.Point(396, 126);
            this.paivitaBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(154, 31);
            this.paivitaBT.TabIndex = 15;
            this.paivitaBT.Text = "Päivitä";
            this.paivitaBT.UseVisualStyleBackColor = true;
            this.paivitaBT.Click += new System.EventHandler(this.paivitaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(575, 124);
            this.poistaBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(154, 31);
            this.poistaBT.TabIndex = 16;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // OppilashallintaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 383);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.tietotauluDG);
            this.Controls.Add(this.opiskelijaidTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.puhelinTB);
            this.Controls.Add(this.snimiTB);
            this.Controls.Add(this.enimiTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.opiskelijanroLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.sukunimiLB);
            this.Controls.Add(this.etunimiLB);
            this.Controls.Add(this.idLB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OppilashallintaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OppilashallintaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLB;
        private System.Windows.Forms.Label etunimiLB;
        private System.Windows.Forms.Label sukunimiLB;
        private System.Windows.Forms.Label puhelinLB;
        private System.Windows.Forms.Label emailLB;
        private System.Windows.Forms.Label opiskelijanroLB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox enimiTB;
        private System.Windows.Forms.TextBox snimiTB;
        private System.Windows.Forms.TextBox puhelinTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox opiskelijaidTB;
        private System.Windows.Forms.DataGridView tietotauluDG;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button tallennaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.Button poistaBT;
    }
}

