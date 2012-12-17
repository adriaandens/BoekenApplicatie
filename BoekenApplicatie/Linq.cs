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
            //var q1 = from boek in dc.Boeks
            //         join cc in dc.Categories on boek.categorieID equals cc.categorieID
            //         group boek by boek.categorieID into gg
            //         select new { Categorie = gg.Key, aantal = gg.Count() };

            var q1 = from cats in dc.Categories
                     join boek in dc.Boeks on cats.categorieID equals boek.categorieID
                     group cats by cats.naam into gg
                     orderby gg.Key
                     select new { Categorie = gg.Key, aantal = gg.Count() };
                    
            this.dgv1.DataSource = q1;

            //query 2
            var q2 = from b in dc.BoekBoekenlijsts
                     select new { b.klas, b.id_boek, b.huurprijs, b.schoolprijs };
            this.dgv2.DataSource = q2;
        }
    }
}
