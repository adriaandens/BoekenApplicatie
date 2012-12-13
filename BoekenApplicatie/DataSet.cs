using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoekenApplicatie
{
    public partial class DataSet : Form
    {
        private BoekenDataContext dc = new BoekenDataContext();
        public DataSet()
        {
            InitializeComponent();
        }


        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void DataSet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'boekenDataSet.Uitgever' table. You can move, or remove it, as needed.
            this.uitgeverTableAdapter.Fill(this.boekenDataSet.Uitgever);
            // TODO: This line of code loads data into the 'boekenDataSet.Boek' table. You can move, or remove it, as needed.
            this.boekTableAdapter.Fill(this.boekenDataSet.Boek);
            // TODO: This line of code loads data into the 'boekenDataSet.Categorie' table. You can move, or remove it, as needed.
            this.categorieTableAdapter.Fill(this.boekenDataSet.Categorie);
            // TODO: This line of code loads data into the 'boekenDataSet.Boekenlijst' table. You can move, or remove it, as needed.
            this.boekenlijstTableAdapter.Fill(this.boekenDataSet.Boekenlijst);
            // TODO: This line of code loads data into the 'boekenDataSet.BoekBoekenlijst' table. You can move, or remove it, as needed.
            this.boekBoekenlijstTableAdapter.Fill(this.boekenDataSet.BoekBoekenlijst);

        }

        private void titelzoeken_TextChanged(object sender, EventArgs e)
        {
            string filterTekst = "titel like '%" + titelzoeken.Text.Trim() + "%'";
            BoekenBindingSource.Filter = filterTekst;
        }

        private void isbnzoeken_TextChanged(object sender, EventArgs e)
        {
            string filterTekst = "isbn like '%" + isbnzoeken.Text.Trim() + "%'";
            BoekenBindingSource.Filter = filterTekst;
        }

        private void Cat_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView cat = Cat_Search.SelectedItem as DataRowView;
            string sValue = "";
            if (cat != null)
            {
                sValue = cat.Row["naam"] as string;
            }
            var filter = from c in dc.Categories
                                         where c.naam == sValue
                                         from b in dc.Boeks
                                         where b.categorieID == c.categorieID
                                         select new { b.categorieID };
            string nieuw = "";
            foreach (var prod in filter)
            {
                nieuw = prod.categorieID;
            }
            this.Text = nieuw;
            string filterTekst = "categorieID like '" + nieuw  + "'";
            BoekenBindingSource.Filter = filterTekst;
        }

        private void all_Click(object sender, EventArgs e)
        {
            titelzoeken.Text = "";
            isbnzoeken.Text = "";
            BoekenBindingSource.RemoveFilter();

        }

        private void titelzoeken_TextChanged_1(object sender, EventArgs e)
        {
            string filterTekst = "titel like '%" + titelzoeken.Text.Trim() + "%'";
            BoekenBindingSource.Filter = filterTekst;
        }

        private void Uit_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView uit = Uit_Search.SelectedItem as DataRowView;
            string sValue = "";
            if (uit != null)
            {
                sValue = uit.Row["naam"] as string;
            }
            var filter = from u in dc.Uitgevers
                         where u.naam == sValue
                         from b in dc.Boeks
                         where b.uitgeverID == u.uitgeverID
                         select new { b.uitgeverID };
            string nieuw = "";
            foreach (var prod in filter)
            {
                nieuw = prod.uitgeverID;
            }
            this.Text = nieuw;
            string filterTekst = "uitgeverID like '" + nieuw + "'";
            BoekenBindingSource.Filter = filterTekst;
        }



    }
}
