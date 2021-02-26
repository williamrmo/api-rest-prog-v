using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Ejemplo.TestJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente()
            {
                ClienteID = 0,
                Nombre = "Test",
                Apellidos = "Json 5",
                Estado = 1
            };
            GrabarCliente(c);
            Console.ReadLine();

        }

        private const string SERVICE_BASE_URL = "http://localhost/";

        private static void GrabarCliente(Cliente c)
        {
            string json = c.ToJsonString();

            using (var client = new HttpClient())
            {
                var task = Task.Run(async () =>
                {
                    return await client.PostAsync(
                       SERVICE_BASE_URL,
                       new StringContent(json, Encoding.UTF8, "application/json")
                       );
                }
                );

                HttpResponseMessage message = task.Result;
                if(message.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    var task2 = Task<string>.Run(async () =>
                    {
                        return await message.Content.ReadAsStringAsync();
                    });
                    string resultStr = task2.Result;
                    Cliente result = JsonConvert.DeserializeObject<Cliente>(resultStr);
                    Console.WriteLine("Cliente {0} creado con el codigo {1}", result.Nombre, result.ClienteID);
                }
                else
                {
                    Console.WriteLine("Ha ocurrido un error en la aplicacion intente mas tarde.");
                }
            }
        }
    }
}
