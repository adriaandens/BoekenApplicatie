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
            boekBindingSource.Filter = filterTekst;
        }

        private void isbnzoeken_TextChanged(object sender, EventArgs e)
        {
            string filterTekst = "isbn like '%" + isbnzoeken.Text.Trim() + "%'";
            boekBindingSource.Filter = filterTekst;
        }

        private void Cat_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = Cat_Search.SelectedValue.ToString();
            string filterTekst = "categorieID like '" + Cat_Search.SelectedValue.ToString() + "'";
            boekBindingSource.Filter = filterTekst;
        }

        private void all_Click(object sender, EventArgs e)
        {
            titelzoeken.Text = "";
            isbnzoeken.Text = "";
            boekBindingSource.RemoveFilter();

        }

        private void titelzoeken_TextChanged_1(object sender, EventArgs e)
        {
            string filterTekst = "titel like '%" + titelzoeken.Text.Trim() + "%'";
            boekBindingSource.Filter = filterTekst;
        }

        private void Uit_Search_SelectedIndexChanged(object sender, EventArgs e)
        {

            string filterTekst = "uitgeverID like '" + Uit_Search.SelectedValue.ToString() + "'";
            boekBindingSource.Filter = filterTekst;
        }

        private void addtolist_Click(object sender, EventArgs e)
        {
            bool isDubbelProduct = false;
            try
            {
                DataRowView lijst = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                BoekenDataSet.BoekRow bRow = lijst.Row as BoekenDataSet.BoekRow;
                int nr = boekBoekenlijstBindingSource.Find("id_boek", bRow.id);
                if (nr != -1)
                {
                    boekBoekenlijstBindingSource.Position = nr;
                    isDubbelProduct = true;
                    MessageBox.Show("dit product wordt al verhuurd ");
                }
                if (!isDubbelProduct)
                {
                    DataRowView drv = boekBoekenlijstBindingSource.AddNew() as DataRowView;
                    BoekenDataSet.BoekBoekenlijstRow row = drv.Row as BoekenDataSet.BoekBoekenlijstRow;
                    row.klas = klas.Text;
                    row.id_boek = bRow.id;
                    row.categorieID = bRow.categorieID;
                    row.huurprijs = 1;
                    row.schoolprijs = 1;
                    row.wordtverhuurd = 1;
                    row.EndEdit();
                    boekBoekenlijstBindingSource.EndEdit();

                }
                welkeklas.Text = klas.Text;
                klaslijst.Focus();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void removefromlist_Click(object sender, EventArgs e)
        {
            boekBoekenlijstBindingSource.RemoveCurrent();
            boekBoekenlijstBindingSource.EndEdit();
        }



    }
}
