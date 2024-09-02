using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace 期中專題
{
    internal class GlobalVar
    {
        public static string SqlConnectionString = "";
        public static int Current_Incharge_ID = 100001; //目前負責員工
        public static int Current_EmployeeID = 0;
        public static int Current_ClientID = 0;
        public static string Current_ClientStatus = "";
        public static string Current_ClientName = "";
        public static string Current_EmployeeName = "";
        public static string Current_EmployeeLevel = "";
        public static string Current_ClientLevel = "";
        public static string img_path = "";
        public static List<Product> Cart = new List<Product>();
    }
}
