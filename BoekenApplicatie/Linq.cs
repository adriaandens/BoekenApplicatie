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
            var q1 = from boek in dc.Boeks
                     group boek by boek.categorieID into gg
                     select new { Categorie = gg.Key, aantal = gg.Count() };
                     

            this.dgv1.DataSource = q1;
        }
    }
}
