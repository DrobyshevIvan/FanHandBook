using System.Collections.Generic;
using Course.Model;

namespace Course.Controller
{
    public class AthleteController
    {
        private string _filePath;

        public AthleteController(string filePath)
        {
            _filePath = filePath;
        }

        public List<Athlete> LoadAllAthletes()
        {
            return DataManagement.LoadAthletesFromFile(_filePath);
        }

        public void AddAthlete(Athlete athlete)
        {
            DataManagement.AddAthleteToFile(_filePath, athlete);
        }

        public void RemoveAthlete(string athleteId)
        {
            DataManagement.RemoveAthleteFromFile(_filePath, athleteId);
        }

        public void UpdateAthlete(Athlete athlete)
        {
            var athletes = DataManagement.LoadAthletesFromFile(_filePath);
            var index = athletes.FindIndex(a => a.AthleteId == athlete.AthleteId);
            if (index != -1)
            {
                athletes[index] = athlete;
                DataManagement.SaveAthletesToFile(_filePath, athletes);
            }
        }

        public List<Athlete> FilterAthletesByName(string name)
        {
            return DataManagement.FilterAthletesByName(_filePath, name);
        }

        public List<Athlete> FilterAthletesByCountry(string country)
        {
            return DataManagement.FilterAthletesByCountry(_filePath, country);
        }

        public List<Athlete> FilterAthletesBySport(string sport)
        {
            return DataManagement.FilterAthletesBySport(_filePath, sport);
        }

        public List<Athlete> FilterAthletesByHeight(double minHeight, double maxHeight)
        {
            return DataManagement.FilterAthletesByHeight(_filePath, minHeight, maxHeight);
        }

        public List<Athlete> FilterAthletesByRecordHolders(string achievement)
        {
            return DataManagement.FilterAthletesByRecordHolders(_filePath, achievement);
        }

        public List<Athlete> FilterAthletesByAchievements(string achievement)
        {
            return DataManagement.FilterAthletesByAchievements(_filePath, achievement);
        }

        public List<Athlete> FilterAthletesByNameAndHeight(string name, double minHeight, double maxHeight)
        {
            return DataManagement.FilterAthletesByNameAndHeight(_filePath, name, minHeight, maxHeight);
        }

        public List<Athlete> FilterAthletesByNameAndRecordHolders(string name, string records)
        {
            return DataManagement.FilterAthletesByNameAndRecordHolders(_filePath, name, records);
        }

        public List<Athlete> FilterAthletesByNameAndAchievements(string name, string achievement)
        {
            return DataManagement.FilterAthletesByNameAndAchievements(_filePath, name, achievement);
        }

        public List<Athlete> FilterAthletesByCountryAndHeight(string country, double minHeight, double maxHeight)
        {
            return DataManagement.FilterAthletesByCountryAndHeight(_filePath, country, minHeight, maxHeight);
        }

        public List<Athlete> FilterAthletesByCountryAndRecordHolders(string country, string records)
        {
            return DataManagement.FilterAthletesByCountryAndRecordHolders(_filePath, country, records);
        }

        public List<Athlete> FilterAthletesByCountryAndAchievements(string country, string achievement)
        {
            return DataManagement.FilterAthletesByCountryAndAchievements(_filePath, country, achievement);
        }

        public List<Athlete> FilterAthletesBySportAndHeight(string sport, double minHeight, double maxHeight)
        {
            return DataManagement.FilterAthletesBySportAndHeight(_filePath, sport, minHeight, maxHeight);
        }

        public List<Athlete> FilterAthletesBySportAndRecordHolders(string sport, string records)
        {
            return DataManagement.FilterAthletesBySportAndRecordHolders(_filePath, sport, records);
        }

        public List<Athlete> FilterAthletesBySportAndAchievements(string sport, string achievement)
        {
            return DataManagement.FilterAthletesBySportAndAchievements(_filePath, sport, achievement);
        }
    }
}
