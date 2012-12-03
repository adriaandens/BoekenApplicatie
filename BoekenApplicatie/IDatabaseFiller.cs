using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoekenApplicatie
{
    interface IDatabaseFiller
    {
        bool fillUitgevers(string padNaarUitgeversFile);
        bool fillCategorieen(string padNaarCategorieenFile);
        bool fillBoeken(string padNaarBoekenFile);
        bool fillStatusen(string padNaarStatusenFile);
    }
}
