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
            string filterTekst = "categorieID like '" + Cat_Search.SelectedValue.ToString().Trim()+ "'";
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
            string filterTekst = "uitgeverID like '" + Uit_Search.SelectedValue.ToString().Trim() + "'";
            BoekenBindingSource.Filter = filterTekst;
        }

        private void addtolist_Click(object sender, EventArgs e)
        {
            bool isDubbelProduct = false;
            try
            {
                //We halen de geselecteerde rij op uit de linkertabel
                DataRowView slcBoek = boekenlijst.CurrentRow.DataBoundItem as DataRowView;
                BoekenDataSet.BoekRow bRow = slcBoek.Row as BoekenDataSet.BoekRow;

                //We gaan die zoeken in de rechtertabel
                int nr = boekBoekenlijstBindingSource1.Find("id_boek", bRow.id);
                if (nr != -1) //Hij zit al in de rechtertabel
                {
                    boekBoekenlijstBindingSource1.Position = nr;
                    isDubbelProduct = true;
                    MessageBox.Show("Dit product wordt al verhuurd "/* + Environment.NewLine + "Pas eventueel het aantal aan"*/);
                }
                if (!isDubbelProduct)
                { //Hij zit niet in de rechtertabel
                    //We maken een nieuwe rij aan in de BoekBoekenlijst tabel
                    DataRowView drv = boekBoekenlijstBindingSource1.AddNew() as DataRowView;
                    BoekenDataSet.BoekBoekenlijstRow row = drv.Row as BoekenDataSet.BoekBoekenlijstRow;
                    //We vullen hem op
                    row.klas = klassenlijst.SelectedItem.ToString();
                    row.id_boek = bRow.id;
                    row.categorieID = bRow.categorieID;
                    row.huurprijs = 15;
                    row.schoolprijs = 13;
                    row.wordtverhuurd = 1;
                    //We stoppen met editten
                    row.EndEdit();
                    //We slagen de wijzigingen op. :)
                    boekBoekenlijstBindingSource1.EndEdit();

                }
                klaslabel.Text = klas.Text;
                /*DataGridViewCell cel = dgvOrderDetail["dgvQuantity", dgvOrderDetail.CurrentRow.Index];
                dgvOrderDetail.CurrentCell = cel;
                dgvOrderDetail.Focus();*/

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void removefromlist_Click(object sender, EventArgs e)
        {
            boekBoekenlijstBindingSource1.RemoveCurrent();
            boekBoekenlijstBindingSource1.EndEdit();
        }

        private void maakNieuweLijst_Click(object sender, EventArgs e)
        {
            //Check the text in the textbox: not empty, not the same name as an existing class

            if (klas.Text.Length <= 0)
            {
                MessageBox.Show("Vul de naam voor de nieuwe klas in.");
            }
            else {
                int index = boekenlijstBindingSource.Find("klas", klas.Text);
                if (index != -1)
                {
                    MessageBox.Show("Deze klas bestaat al.");
                }
                else { 
                    //Owkee, alles is goed :D
                    //We maken een nieuwe rij aan in de Boekenlijst tabel
                    DataRowView drv = boekenlijstBindingSource.AddNew() as DataRowView;
                    BoekenDataSet.BoekenlijstRow row = drv.Row as BoekenDataSet.BoekenlijstRow;
                    //We vullen hem op
                    row.klas = klas.Text;
                    row.statusID = 1;
                    row.opmerking = "";
                    row.laatstewijziging = DateTime.Now;
                    //We stoppen met editten
                    row.EndEdit();
                    //We slagen de wijzigingen op. :)
                    boekenlijstBindingSource.EndEdit();

                    //Moeten we de boekenlijst kopieren of niet?
                    index = maak_klas_combobox.SelectedIndex;
                    if (index != -1) { //Jup we gaan moeten kopiëren
                        BoekenDataSet.BoekBoekenlijstDataTable dt = boekBoekenlijstTableAdapter.GetData();
                        
                    }
                }
            }

        }

        //
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
