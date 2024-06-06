using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

        public static void AddAthleteToFile(string filePath, Athlete newAthlete)
        {
            var athletes = LoadAthletesFromFile(filePath);
            athletes.Add(newAthlete);
            SaveAthletesToFile(filePath, athletes);
        }

        public static void RemoveAthleteFromFile(string filePath, string athleteId)
        {
            var athletes = LoadAthletesFromFile(filePath);
            var athleteToRemove = athletes.FirstOrDefault(a => a.AthleteId == athleteId);

            if (athleteToRemove != null)
            {
                athletes.Remove(athleteToRemove);
                SaveAthletesToFile(filePath, athletes);
            }
            else
            {
                throw new Exception("Athlete not found.");
            }
        }
    }
}