using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BoekenApplicatie
{
    //Mogelijk via een menu-item in het hoofdscherm, de gebruiker de locatie van
    //de file laten geven.
    //Zoals: http://www.programmersheaven.com/mb/csharp/194291/194291/open-and-reading-files-in-c/
    class DatabaseFiller : IDatabaseFiller
    {
        private SqlConnection connectie;
        private SqlCommand command;

        public DatabaseFiller() {
            connectie = new SqlConnection(Properties.Settings.Default.BoekenConnectionString);
        }

        public bool fillUitgevers(string padNaarUitgeversFile)
        {
            bool success = false;
            string commando = "INSERT INTO Uitgever VALUES ";
            bool eerste = true;
            try
            {
                StreamReader r = new StreamReader(padNaarUitgeversFile);
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    //Read the file...
                    string[] array = line.Split('\t');
                    for (int i = 0; i < array.Length; i++) {
                        array[i] = array[i].Trim();
                    }
                    if (eerste)
                    {
                        commando += "('" + array[0].Replace("'", "''") + "', '" + array[1].Replace("'", "''") + "')"; eerste = false;
                    }
                    else {
                        commando += ", ('" + array[0].Replace("'", "''") + "', '" + array[1].Replace("'", "''") + "')";
                    }
                }
                r.Close();
                log(commando);
                connectie.Open();
                command = new SqlCommand(commando, connectie);
                command.ExecuteNonQuery();
                connectie.Close();
                success = true;
            }
            catch (Exception e) {
                log(e.Message);
                success = false;
            }
            return success;
        }

        public void log(string text) {
            TextWriter w = new StreamWriter("log.txt", true);
            w.WriteLine(text);
            w.Close();
        }

        public bool fillCategorieen(string padNaarCategorieenFile)
        {
            bool success = false;
            string commando = "INSERT INTO Categorie VALUES ";
            bool eerste = true;
            try
            {
                StreamReader r = new StreamReader(padNaarCategorieenFile);
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    //Read the file...
                    string[] array = line.Split('\t');
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = array[i].Trim();
                    }
                    if (eerste)
                    {
                        commando += "('" + array[0].Replace("'", "''") + "', '" + array[1].Replace("'", "''") + "')"; eerste = false;
                    }
                    else
                    {
                        commando += ", ('" + array[0].Replace("'", "''") + "', '" + array[1].Replace("'", "''") + "')";
                    }
                }
                r.Close();
                log(commando);
                connectie.Open();
                command = new SqlCommand(commando, connectie);
                command.ExecuteNonQuery();
                connectie.Close();
                success = true;
            }
            catch (Exception e)
            {
                log(e.Message);
                success = false;
            }
            return success;
        }

        //Duizend inserts in 1 query is de max
        //String van duizend inserts is te lang...
        public bool fillBoeken(string padNaarBoekenFile)
        {
            bool success = false;
            //Source linecount: http://stackoverflow.com/questions/119559/determine-the-number-of-lines-within-a-text-file
            string[] commandos = new string[((File.ReadLines(padNaarBoekenFile).Count()/500)+1)];
            log("Aantal lijntjes: " + File.ReadLines(padNaarBoekenFile).Count());
            string commando = "";
            bool eerste = true;
            int j = 0, k = 0; //j = current number of lines, k = place to store the command in the aray
            try
            {
                StreamReader r = new StreamReader(padNaarBoekenFile);
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    //Read the file...
                    string[] array = line.Split('\t');
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = array[i].Trim();
                    }
                    if (eerste && array.Length == 6)
                    {
                        commando += "INSERT INTO Boek VALUES ('" + array[1].Replace("'", "''") + "', '" + array[0].Replace("'", "''") + "', " + array[3].Replace(",", ".") + ", '" + array[2].Replace("'", "''") + "', '" + array[1].Replace("'", "''") + "')"; eerste = false;
                    }
                    else if (!eerste && array.Length == 6)
                    {
                        commando += ", ('" + array[1].Replace("'", "''") + "', '" + array[0].Replace("'", "''") + "', " + array[3].Replace(",", ".") + ", '" + array[2].Replace("'", "''") + "', '" + array[1].Replace("'", "''") + "')";
                    }
                    j++;
                    if (j == 1000) {
                        commandos[k] = commando;
                        commando = "";
                        k++; j = 0; eerste = true;
                    } 
                }
                r.Close();
                if (j != 0) { commandos[k] = commando; } //We moeten de laatste string nog in de array steken tenzij het er juist ingestoken is geweest.
                connectie.Open();
                foreach (string s in commandos) {
                    if (s.Length > 0) { //We willen geen lege string uitvoeren als query
                        log(s + "\r\n");
                        command = new SqlCommand(s, connectie);
                        command.ExecuteNonQuery();  
                    }                      
                }
                connectie.Close();
                success = true;
            }
            catch (Exception e)
            {
                log(e.Message);
                success = false;
            }
            return success;
        }

        public bool fillStatusen(string padNaarStatusenFile)
        {
            bool success = false;
            try {
                command = new SqlCommand("insert into Status values (1, 'nog te starten'), (2, 'in constructie'), (3, 'afgewerkt')", connectie);
                connectie.Open();
                command.ExecuteNonQuery();
                connectie.Close();
                success = true;
            } catch(Exception e)
            {
                log(e.Message);
                success = false;
            }
            return success;            
        }
    }
}
