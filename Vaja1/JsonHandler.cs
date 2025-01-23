using System;
using System.Text.Json; 
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Vaja1
{
        public static class JsonHandler
        {
        private static string filePath = "sporocila.json";

        // Shrani seznam sporočil v datoteko
        public static void ShraniSporocila(List<Sporocila> sporocila)
        {
            var options = new JsonSerializerOptions { WriteIndented = true }; // Formatirano za lažje branje
            string json = JsonSerializer.Serialize(sporocila, options);
            File.WriteAllText(filePath, json);
        }

        // Prebere seznam sporočil iz datoteke
        public static List<Sporocila> NaloziSporocila()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Sporocila>>(json) ?? new List<Sporocila>();
            }
            return new List<Sporocila>();
        }
    }
    
}
