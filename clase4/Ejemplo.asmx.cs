using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace clase4
{
    /// <summary>
    /// Summary description for Ejemplo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Ejemplo : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public Persona ObtenerPersona(int codigo)
        {
            Persona p = new Persona()
            {
                Codigo = codigo,
                nombre = "Juan",
                Apellido = "Perez"
            };
            return p;
        }

        [WebMethod]
        public List<Persona> ObtenerPersonas()
        {
            Persona p1 = new Persona()
            {
                Codigo = 5,
                nombre = "Juan",
                Apellido = "Perez"
            };

            Persona p2 = new Persona()
            {
                Codigo = 5,
                nombre = "CArlos",
                Apellido = "Perez"

            };

            List<Persona> l = new List<Persona>();
            l.Add(p1);
            l.Add(p2);

            return l;
        }

        [WebMethod]
        public void CrearPersona(Persona p)
        {

        }
    }
}
