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
        private string naam_van_klas; 



        public DataSet()
        {
            InitializeComponent();
        }


        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void DataSet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'boekenDataSet.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.boekenDataSet.Status);
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
            string filterTekst = "categorieID like '" + Cat_Search.SelectedValue.ToString().Trim() + "'";
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
            if (klassenlijst.SelectedIndex == -1)
            {
                MessageBox.Show("Je kan alleen boeken toevoegen aan een boekenlijst met een naam");
                return;
            }
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
                    row.klas = klassenlijst.Text;
                    row.id_boek = bRow.id;
                    row.categorieID = bRow.categorieID;
                    row.huurprijs = 0;
                    row.schoolprijs = bRow.aankoopprijs;
                    row.wordtverhuurd = 1;
                    //We stoppen met editten
                    row.EndEdit();
                    //We slagen de wijzigingen op. :)
                    boekBoekenlijstBindingSource1.EndEdit();

                    pas_info_boekenlijst_aan();

                }
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
            pas_info_boekenlijst_aan();
        }

        private void maakNieuweLijst_Click(object sender, EventArgs e)
        {
            //Check the text in the textbox: not empty, not the same name as an existing class
            if (klas.Text.Length <= 0)
            {
                MessageBox.Show("Vul de naam voor de nieuwe klas in.");
            }
            else
            {
                int index = boekenlijstBindingSource.Find("klas", klas.Text);
                if (index != -1)
                {
                    MessageBox.Show("Deze klas bestaat al.");
                }
                else
                {
                    //Owkee, alles is goed :D
                    //We maken een nieuwe rij aan in de Boekenlijst tabel
                    string waarde_combobox = maak_klas_combobox.Text;
                    MessageBox.Show("Waarde combobox: " + waarde_combobox + " (" + waarde_combobox.Length + ")");
                    DataRowView drv = boekenlijstBindingSource.AddNew() as DataRowView;
                    BoekenDataSet.BoekenlijstRow row = drv.Row as BoekenDataSet.BoekenlijstRow;
                    //We vullen hem op

                    row.klas = klas.Text;
                    row.statusID = 1;
                    row.opmerking = "Vul hier je opmerking in";
                    row.laatstewijziging = DateTime.Now;
                    //We stoppen met editten
                    row.EndEdit();
                    //We slagen de wijzigingen op. :)
                    boekenlijstBindingSource.EndEdit();


                    //Moeten we de boekenlijst kopieren of niet?
                    if (klas.Text != waarde_combobox && waarde_combobox != "")
                    { //Jup we gaan moeten kopiëren
                        MessageBox.Show("Jup we gaan moete kopieren");
                        List<BoekenDataSet.BoekBoekenlijstRow> lijst = new List<BoekenDataSet.BoekBoekenlijstRow>();
                        foreach (DataRow dr in boekenDataSet.BoekBoekenlijst.Rows)
                        {
                            MessageBox.Show("De klas in deze rij is " + dr["klas"].ToString());
                            if (dr["klas"].ToString() == waarde_combobox)
                            {
                                MessageBox.Show("Deze is dus legit");
                                //Deze moeten we kopiëren
                                //We maken een nieuwe rij aan in de BoekBoekenlijst tabel
                                BoekenDataSet.BoekBoekenlijstRow rij = boekenDataSet.BoekBoekenlijst.NewBoekBoekenlijstRow();
                                rij.klas = klas.Text;
                                rij.id_boek = (int)dr["id_boek"];
                                rij.huurprijs = (decimal)dr["huurprijs"];
                                rij.schoolprijs = (decimal)dr["schoolprijs"];
                                rij.wordtverhuurd = (byte)dr["wordtverhuurd"];
                                rij.categorieID = dr["categorieID"].ToString();
                                lijst.Add(rij); //omdat we de collectie niet kunnen veranderen terwijl we erdoor aan het lussen zijn...
                                //boekenDataSet.BoekBoekenlijst.Rows.Add(rij);
                            }
                        }
                        foreach (BoekenDataSet.BoekBoekenlijstRow rij in lijst)
                        {
                            boekenDataSet.BoekBoekenlijst.Rows.Add(rij);
                        }
                    }
                    klassenlijst_SelectedIndexChanged(null, null);
                }
            }

        }

        private void klassenlijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (klassenlijst.SelectedIndex != -1 && klassenlijst.Text.Length != 0)
            {
                MessageBox.Show("We gaan nu de rechtse tabel aanpassen, nieuwe klas: " + klassenlijst.Text);
                naam_van_klas = klassenlijst.Text;
                boekBoekenlijstBindingSource1.RemoveFilter();
                string filterTekst = "klas = '" + naam_van_klas + "'";
                boekBoekenlijstBindingSource1.Filter = filterTekst;
                //update opmerking textbox en status
                MessageBox.Show("We gaan nu de opmerking aanpassen naar die van klas: " + naam_van_klas);
                BoekenDataSet.BoekenlijstRow rij = boekenDataSet.Boekenlijst.FindByklas(naam_van_klas);
                if (rij != null)
                {
                    MessageBox.Show("Klas rij: " + rij.klas);
                    MessageBox.Show("Opmerking klas: " + rij.opmerking);
                    opmerking.Text = rij.opmerking;
                    //Status aanpassen
                    status_boekenlijst.SelectedIndex = rij.statusID - 1;
                }
                else
                {
                    opmerking.Text = "";
                }

                //We moeten ook het totaal aantal boeken laten zien + de prijs
                pas_info_boekenlijst_aan();
            }
        }

        private void pas_info_boekenlijst_aan() {
            int aantalboeken = 0;
            decimal prijs = 0;
            foreach (DataRowView rijtje in boekBoekenlijstBindingSource1)
            {
                BoekenDataSet.BoekBoekenlijstRow goed_rijtje = rijtje.Row as BoekenDataSet.BoekBoekenlijstRow;
                aantalboeken++;
                prijs += goed_rijtje.schoolprijs;
            }
            info_boekenlijst.Text = "Lijst voor " + naam_van_klas + " - Aantal boeken: " + aantalboeken + " - Totaal: " + prijs + "€";
        }

        private void annuleer_wijzigingen_Click(object sender, EventArgs e)
        {
            string klasnaam = naam_van_klas; //Klas die getoond wordt
            //We gaan door de boeken loopen in boekboekenlijst
            for (int i = 0; i < boekBoekenlijstBindingSource1.List.Count; i++) {
                DataRowView drv = boekBoekenlijstBindingSource1[i] as DataRowView;
                BoekenDataSet.BoekBoekenlijstRow rij = drv.Row as BoekenDataSet.BoekBoekenlijstRow;
                //Voor elk boek, nemen we de ID en zoeken we de ID in de boektabel.
                BoekenDataSet.BoekDataTable dt = boekTableAdapter.GetData();
                BoekenDataSet.BoekRow rij_origineel = dt.FindByid(rij.id_boek);
                //int id = BoekenBindingSource.Find("id", rij.id_boek);
                //MessageBox.Show("Id rechterkolom van boek: " + rij.id_boek + " - Index: " + id);
                //drv = BoekenBindingSource[id] as DataRowView;
                //BoekenDataSet.BoekRow rij_origineel = drv.Row as BoekenDataSet.BoekRow;

                //Nu passen we de velden aan van "rij" om terug het origineel te hebben.
                rij.schoolprijs = rij_origineel.aankoopprijs;
                rij.categorieID = rij_origineel.categorieID;
            }
            pas_info_boekenlijst_aan();
        }

        private void save_opmerking_Click(object sender, EventArgs e)
        {
            //Edit column in dataset: http://msdn.microsoft.com/en-us/library/tat996zc(v=vs.80).aspx
            string klas = naam_van_klas;
            if (klas.Length > 0)
            {
                BoekenDataSet.BoekenlijstRow rij = boekenDataSet.Boekenlijst.FindByklas(klas);
                rij.opmerking = opmerking.Text;
            }

        }

        private void status_boekenlijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            string klas = naam_van_klas;
            if (klas.Length > 0)
            {
                BoekenDataSet.BoekenlijstRow rij = boekenDataSet.Boekenlijst.FindByklas(klas);
                rij.statusID = status_boekenlijst.SelectedIndex + 1;
            }
        }

        private void klaslijst_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            pas_info_boekenlijst_aan();
        }
    }
}
