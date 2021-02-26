using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo.TestWCF.ServicioWCF;

namespace wcf
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EjemploWCFClient client = new EjemploWCFClient())
            {
                Persona p = client.ObtenerPersonal(1);
                Console.WriteLine(string.Format("{0} {1}", p.Nombre, p.Apellido));
            }
            Console.ReadLine();
        }
    }
}
