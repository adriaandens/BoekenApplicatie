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
    public partial class Linq : Form
    {
        private BoekenDataContext dc = new BoekenDataContext();

        public Linq()
        {
            InitializeComponent();
        }

        private void Linq_Load(object sender, EventArgs e)
        {
        
            var q1 = from cats in dc.Categories
                     join boek in dc.Boeks on cats.categorieID equals boek.categorieID
                     group cats by cats.naam into gg
                     orderby gg.Key
                     select new { Categorie = gg.Key, aantal = gg.Count() };
                    
            this.dgv1.DataSource = q1;

            //query 2
            var q2 = from b in dc.Boekenlijsts
                     join bb in dc.BoekBoekenlijsts on b.klas equals bb.klas
                     group new { b, bb } by bb.klas into g
                     select new { Klas = g.Key, Totale_Prijs = g.Sum(p => p.bb.schoolprijs) };
                     
            this.dgv2.DataSource = q2;

            var q3 = from b in dc.BoekBoekenlijsts
                     join bb in dc.Boekenlijsts on b.klas equals bb.klas
                     join bbb in dc.Boeks on b.id_boek equals bbb.id
                     group new { b, bb, bbb } by new { bbb.titel,bbb.categorieID } into g
                     orderby g.Key.categorieID,g.Key.titel
                     select new { Titel = g.Key.titel, Cat = g.Key.categorieID, Totale_AantalStuks = g.Sum(s => s.bb.aantalLeerlingen) };
            


            this.dgv3.DataSource = q3;
                     
            
        }

        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
