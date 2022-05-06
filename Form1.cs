using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerieGarage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GarageDataContext db = new GarageDataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            misAjour();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            txtTel.Text = "";
            txtMat.Text = "";
            txtMarque.Text = "";
            txtModel.Text = "";
            txtRecherche.Text = "";
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            Voiture v = new Voiture();
            v.Immat = txtMat.Text;
            v.MarqueV = txtMarque.Text;
            v.ModeleV = txtModel.Text;
            v.TelProprietaire = txtTel.Text;

            db.Voiture.InsertOnSubmit(v);
            db.SubmitChanges();
            misAjour();
            txtTel.Text = "";
            txtMat.Text = "";
            txtMarque.Text = "";
            txtModel.Text = "";
            MessageBox.Show("Ajouter avec succés");
        }
        public void misAjour()
        {
            var vo = db.Voiture.Select(x => new { Immatricule = x.Immat, Marque = x.MarqueV });
            dataGridView1.DataSource = vo;
        }

        private void bntRecherche_Click(object sender, EventArgs e)
        {
            var v = db.Voiture.Where(x => x.Immat==txtRecherche.Text || x.MarqueV==txtRecherche.Text).Select(x => new { Immatricule = x.Immat, Marque = x.MarqueV });
            dataGridView1.DataSource = v;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Voiture v = new Voiture();
            v.Immat = txtMat.Text;
            v.MarqueV = txtMarque.Text;
            v.ModeleV = txtModel.Text;
            v.TelProprietaire = txtTel.Text;
            db.SubmitChanges();
            misAjour();
            txtTel.Text = "";
            txtMat.Text = "";
            txtMarque.Text = "";
            txtModel.Text = "";
            MessageBox.Show("Modifier avec succés");
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            var v = db.Voiture.Where(x => x.Immat == txtMat.Text).FirstOrDefault();
            db.Voiture.DeleteOnSubmit(v);
            db.SubmitChanges();
            txtTel.Text = "";
            txtMat.Text = "";
            txtMarque.Text = "";
            txtModel.Text = "";
            MessageBox.Show("sipprimer avec succés");
            misAjour();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            txtMat.Text = row.Cells[0].Value.ToString();
            var v = db.Voiture.Where(x => x.Immat == txtMat.Text).FirstOrDefault();
            txtMarque.Text = v.MarqueV;
            txtModel.Text = v.ModeleV;
            txtTel.Text = v.TelProprietaire;

        }
    }
}
