using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TestWithUC;

namespace TestWithUC
{
    public class MesDatas
    {
        private static DataSet dsGlobal = new DataSet();
     
        public static DataSet DsGlobal { 
            get {

                dsGlobal = new DataSet(); //On crée un DataSet pour contenir les données de la table
                SQLiteConnection cx = Connexion.Connec; //On se connecte

                DataTable dt = cx.GetSchema("Tables"); //On crée un DataTable pour contenir les données de la table

                string requete;

                foreach(DataRow row in dt.Rows)
                {
                    string nomtable = row["TABLE_NAME"].ToString(); //On récupère le nom de la table
                    requete = "SELECT * FROM " + nomtable;
                    SQLiteCommand cmd = new SQLiteCommand(requete, cx);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                    da.Fill(dsGlobal, nomtable);
                }


                return MesDatas.dsGlobal; } }

    }
}
