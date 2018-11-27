using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterPassPaymentServiceTests
{
    public static class InitialData
    {
        //Корректные данные 222222222222222
        public static string    guid            = "8F322CAA-EF25-4D52-992B-1754343B67BE";
        public static string    uniqueId        = "0639DB14E9F6906F54D722F474A0952E52FA4F60292B13F23184D11A7537E852";
        public static double    amount          = 76.86;
        public static int       filialId        = 1998;
        public static string    frNumber        = "NF00000000";
        public static string    pos_ip          = "192.168.0.106";
        public static int       localChequeId   = 28102;
        public static int       zId             = -1;
        public static string    posName         = "\u041a\u0430\u0441\u0441\u0430 N  6";
        public static string    uuid            = "1308b38c-62eb-11e6-a591-9f9dbd6df78d";

        //Не верные данные
        public static int zId_wrong = 1234567890;
        public static string frNumber_wrong = "0000000000";
        public static string pos_ip_wrong = "127.0.0.1";

        //Не корректныйе
        public static string guid_wrong = "8F322CAA-EF25-4D52-992B-1754343B67B0";
        public static string uniqueId_wrong = "0639DB14E9F6906F54D722F474A0952E52FA4F60292B13F23184D11A7537E853";
        public static double amount_plus1cop = 76.87;

        public static double amount_plus1hrn = 77.87;

        public static int filialId_wrong = 1999;
        //public static int localChequeId = 28102;
        public static string posName_wrong = "\u041a\u0430\u0441\u0441\u0430 B  6";
        public static string uuid_wrong = "1308b38c-62eb-11e6-a591-9f9dbd6df78s";
    }
}
