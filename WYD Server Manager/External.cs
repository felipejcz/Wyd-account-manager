using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WYD_Server_Manager
{
    static class External
    {
        //public static Structs.sITEMLIST ItemList = new Structs.sITEMLIST();
        public static Structs.STRUCT_ACCOUNTFILE conta = new Structs.STRUCT_ACCOUNTFILE();
        public static List<Structs.STRUCT_ACCOUNTFILE> listaContas = new List<Structs.STRUCT_ACCOUNTFILE>();
        //public static List<Structs.STRUCT_ACCOUNTFILE> ContasLocalizadas = new List<Structs.STRUCT_ACCOUNTFILE>();
        public static int currentChar = -1;
    }
}
