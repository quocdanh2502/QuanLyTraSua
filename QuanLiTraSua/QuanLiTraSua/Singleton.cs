using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTraSua
{
    internal class Singleton
    {
        private static Singleton instance;
        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        public string curentKey;
        public Dictionary<string, DataTable> Temp_Hd = new Dictionary<string, DataTable>();
    }
}
