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
        private BoekenDataSet ds = new BoekenDataSet();
        public DataSet()
        {
            InitializeComponent();
        }


        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void DataSet_Load(object sender, EventArgs e)
        {
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cat = comboBox1.SelectedValue.ToString().Trim();
            var filter = from c in ds.Categorie
                         where c.naam == cat
                         from b in ds.Boek
                         where b.categorieID == c.categorieID
                         select new { b.titel, b.isbn};
            BoekenBindingSource.DataSource = filter;
        }



    }
}
