using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.TestJSON
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public Nullable<int> Estado { get; set; }

        public string ToJsonString()
        {
            return JsonConvert.SerializeObject(this, Formatting.None);
        }

        public override string ToString()
        {
            return ToJsonString();
        }
    }
}
