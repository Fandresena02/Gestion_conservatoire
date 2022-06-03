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
    class InstrumentDao
    {
        private ConnexionSql maConnexionSql;
        private MySqlCommand Ocom;

        public Instrument getInstrument(int idInstru)
        {

            Instrument unInstrument = new Instrument();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("select instru.id, instru.nomInstru from instrument as instru where instru.id = " + idInstru);


                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    int id = (int)reader1.GetValue(0);
                    string nomInstru = (string)reader1.GetValue(1);

                    unInstrument = new Instrument(id, nomInstru);

                }


                reader1.Close();

                maConnexionSql.closeConnection();

               return (unInstrument);

            }

            catch (Exception emp)
            {

                throw (emp);
            }

        }
    }
}
