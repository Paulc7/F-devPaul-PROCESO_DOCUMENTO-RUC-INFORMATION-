using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace INFORMATION.Models
{
    class ClsInformationCompany
    {
        public void sendinformation()
        {
            string vgurl = ConfigurationSettings.AppSettings["ruc"];
            string path = @"F:\devPaul\PROCESO_DOCUMENTO\1724000516001\TXTINFORMATION\" + vgurl + ".txt";
            string name = "SIPER",
                   address = "LA VICENTINA VERDE CRUZ E16-13 Y PADRE JACOME";
            if (!File.Exists(path))
            {
                using(StreamWriter read = File.CreateText(path))
                {
                    read.WriteLine(vgurl);
                    read.WriteLine(name);
                    read.WriteLine(address);
                }
            }
            

        }
    }
}
