using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PryAmestoy1
{
    internal class ClsArchivo
    {
        public string NombreArchivo = "Archivo.txt";
        
        public void Grabar(string valor)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo,true);
            AD.WriteLine(valor);
            AD.Close();
            AD.Dispose();
        }
    }
}
