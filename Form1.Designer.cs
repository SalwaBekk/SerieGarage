
namespace SerieGarage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.bntRecherche = new System.Windows.Forms.Button();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnVal = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.Last = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(307, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(24, 22);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(159, 20);
            this.txtRecherche.TabIndex = 1;
            // 
            // bntRecherche
            // 
            this.bntRecherche.Location = new System.Drawing.Point(256, 22);
            this.bntRecherche.Name = "bntRecherche";
            this.bntRecherche.Size = new System.Drawing.Size(75, 23);
            this.bntRecherche.TabIndex = 2;
            this.bntRecherche.Text = "Rechercher";
            this.bntRecherche.UseVisualStyleBackColor = true;
            this.bntRecherche.Click += new System.EventHandler(this.bntRecherche_Click);
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(526, 49);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(159, 20);
            this.txtMat.TabIndex = 3;
            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(526, 95);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(159, 20);
            this.txtMarque.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(526, 141);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(159, 20);
            this.txtModel.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(526, 187);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(159, 20);
            this.txtTel.TabIndex = 6;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(461, 316);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 7;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(568, 316);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 8;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(670, 316);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(75, 23);
            this.btnSupp.TabIndex = 9;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnVal
            // 
            this.btnVal.Location = new System.Drawing.Point(522, 363);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(75, 23);
            this.btnVal.TabIndex = 10;
            this.btnVal.Text = "Valider";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(628, 363);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // Last
            // 
            this.Last.Location = new System.Drawing.Point(303, 345);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(30, 23);
            this.Last.TabIndex = 12;
            this.Last.Text = ">>";
            this.Last.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(60, 345);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(30, 23);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(267, 345);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(24, 345);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(30, 23);
            this.btnFirst.TabIndex = 15;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Immatricule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Marque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Modele";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.Last);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.bntRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button bntRecherche;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button Last;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

