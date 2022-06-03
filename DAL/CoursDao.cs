using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Gestion_conservatoire.Modele;

namespace Gestion_conservatoire.DAL
{
    class CoursDao
    {
        private ConnexionSql maConnexionSql;
        private MySqlCommand Ocom;
        private InstrumentDao unInstru = new InstrumentDao();
        private ProfesseurDao unProf = new ProfesseurDao();
        private int idProf, idInstru, id, nbPlace;
        private string sceance;

        public Cours getCours(int idCours)
        {

            try
            {
                Cours unCours;



                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("select c.id as idCours, c.jourHeure as seanceCours, c.nbPlace as nbPlaceCours, " +
                    "c.idProfesseur as idProfCours, c.idInstrument as idInstrumentCours from cours as c where c.id =" + idCours);


                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    id = (int)reader1.GetValue(0);
                    sceance = (string)reader1.GetValue(1);
                    nbPlace = (int)reader1.GetValue(2);
                    idProf = (int)reader1.GetValue(3);
                    idInstru = (int)reader1.GetValue(4);
                }

                reader1.Close();

                maConnexionSql.closeConnection();

                Professeur prof = unProf.getProfesseur(idProf);
                Instrument instru = unInstru.getInstrument(idInstru);

                unCours = new Cours(id, sceance, nbPlace, prof, instru);


                return (unCours);

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }
    }
}
