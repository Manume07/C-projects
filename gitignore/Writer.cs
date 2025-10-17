using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitignore
{
    
    internal class Writer
    {
        private string testo;
        StreamWriter sw;

        public Writer()
        {

            sw = new StreamWriter("Info.txt");
        }

        public void ScriviFile(string t)
        {
            testo = t;
            sw.WriteLine(testo);
            sw.Close();
        }
    }
}
