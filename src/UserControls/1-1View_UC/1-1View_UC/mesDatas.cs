using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _1_1View_UC
{
    public class MesDatas
    {
        private static DataSet dsGlobal = new DataSet();
     
        public static DataSet DsGlobal 
        { 
            get 
            {
                
                return dsGlobal;
            } 
        }

    }
}
