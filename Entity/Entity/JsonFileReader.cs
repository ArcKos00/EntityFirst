using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EntityFrameworkProject
{
    public class JsonFileReader
    {
        public string ReadJson()
        {
            var json = JsonConvert.DeserializeObject("config.json");
            return json;
        }
    }
}
