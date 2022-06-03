using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Gestion_conservatoire.Modele;

namespace Gestion_conservatoire.DAL
{
    class InscriptionDao
    {
        private ConnexionSql maConnexionsql;
        private MySqlCommand Ocom;
        private CoursDao unCours = new CoursDao();


        public List<Inscription> getInscriptions(Adherent ad)
        {
            Dictionary<int, int> lc = new Dictionary<int, int>();
            List<Inscription> listInscription = new List<Inscription>();
            try
            {

                maConnexionsql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionsql.openConnection();

                Ocom = maConnexionsql.reqExec("Select idCours, paye from inscription where idAdherent = " + ad.Num);

                MySqlDataReader reader1 = Ocom.ExecuteReader();
                Inscription uneInscription;


                while (reader1.Read())
                {
                    int idCours = (int)reader1.GetValue(0);
                    int solde = (int)reader1.GetValue(1);

                    lc.Add(idCours, solde);                 
                }

                reader1.Close();

                maConnexionsql.closeConnection();

                foreach(var val in lc)
                {
                    Cours c = unCours.getCours(val.Key);

                    uneInscription = new Inscription(ad, c, val.Value);

                    listInscription.Add(uneInscription);
                }
                return listInscription;

            }
            catch(Exception emp)
            {

                throw (emp);

            }

        }


        public void updateSolde(Inscription uneInsc)
        {
            try
            {

            maConnexionsql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

            maConnexionsql.openConnection();

            Ocom = maConnexionsql.reqExec("Update inscription set paye =" + uneInsc.Solde + " where idAdherent = " + uneInsc.UnAdherent.Num + " and idCours =" + uneInsc.UnCours.Id);
            Ocom.ExecuteNonQuery();

            }
            catch (Exception emp)
            {

                throw (emp);
            }

        }



    }
}
