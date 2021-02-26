using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestASMX.ReferenciaServicioSoap;

namespace TestASMX
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EjemploSoapClient client = new EjemploSoapClient())
            {
                Console.WriteLine(client.HelloWorld());
            }

            Console.ReadLine();
        }
    }
}
