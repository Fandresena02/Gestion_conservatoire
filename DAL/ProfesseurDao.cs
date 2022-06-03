using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Gestion_conservatoire.Modele;

namespace Gestion_conservatoire.DAL
{
    class ProfesseurDao
    {
        private ConnexionSql maConnexionSql;
        private MySqlCommand Ocom;

        public Professeur getProfesseur(int idProfesseur)
        {
            try
            {
                Professeur prof = null;


                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("select p.id as idProf, p.nom as nomProf, p.prenom as prenomProf, " +
                    "p.tel as telProf, p.adresse as adresseProf, p.mail as mailProf, prf.salaire as salaireProf " +
                    "from professeur as prf " +
                    "inner join personnes as p on p.id = prf.id where p.id =" + idProfesseur);


                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    int idProf = (int)reader1.GetValue(0);
                    string nomProf= (string)reader1.GetValue(1);
                    string prenomProf = (string)reader1.GetValue(2);
                    string telProf = (string)reader1.GetValue(3);
                    string adresseProf = (string)reader1.GetValue(4);
                    string mailProf = (string)reader1.GetValue(5);
                    int salaireProf = (int)reader1.GetValue(6);

                    prof = new Professeur(idProf, nomProf, prenomProf, mailProf, telProf, adresseProf, salaireProf);

                }

                reader1.Close();

                maConnexionSql.closeConnection();

                return prof;
            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }
    }
}