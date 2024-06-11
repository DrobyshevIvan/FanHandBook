using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Course.Model
{
    internal class DataManagement
    {
        public static void SaveAthletesToFile(string filePath, List<Athlete> athletes)
        {
            string json = JsonConvert.SerializeObject(athletes, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static List<Athlete> LoadAthletesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Athlete>>(json) ?? new List<Athlete>();
            }
            return new List<Athlete>();
        }
    }
}