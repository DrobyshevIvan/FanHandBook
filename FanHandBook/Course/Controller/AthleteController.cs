using Course.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Course.Controller
{
    public class AthleteController
    {
        private readonly string _filePath;
        private List<Athlete> _athletes;

        public AthleteController(string filePath)
        {
            _filePath = filePath;
            _athletes = DataManagement.LoadAthletesFromFile(_filePath);
        }

        public List<Athlete> GetAthletes()
        {
            return _athletes;
        }

        public void SaveData()
        {
            DataManagement.SaveAthletesToFile(_filePath, _athletes);
        }

        public void AddAthlete(Athlete athlete) 
        {
            _athletes.Add(athlete);
            SaveData();
        }

        public void UpdateAthlete(Athlete athlete)
        {
            var index = _athletes.FindIndex(a => a.AthleteId == athlete.AthleteId);
            if (index != -1)
            {
                _athletes[index] = athlete;
                SaveData();
            }
        }

        public void RemoveAthlete(string athleteId)
        {
            var athleteToRemove = _athletes.FirstOrDefault(a => a.AthleteId == athleteId);
            if (athleteToRemove != null)
            {
                _athletes.Remove(athleteToRemove);
                SaveData();
            }
            else
            {
                throw new Exception("Athlete not found.");
            }
        }

        private bool ContainsFullName(Athlete athlete, string name)
        {
            string fullName = athlete.FirstName + " " + athlete.LastName;
            return fullName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public List<Athlete> FilterAthletesByName(string name)
        {
            return _athletes.Where(a => ContainsFullName(a, name)).ToList();
        }

        public List<Athlete> FilterAthletesByCountry(string country)
        {
            return _athletes.Where(a => a.Country.IndexOf(country, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public List<Athlete> FilterAthletesBySport(string sport)
        {
            return _athletes.Where(a => a.Sport.IndexOf(sport, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public List<Athlete> FilterAthletesByHeight(double minHeight, double maxHeight)
        {
            return _athletes.Where(a => a.Height >= minHeight && a.Height <= maxHeight).ToList();
        }

        public List<Athlete> FilterAthletesByRecordHolders(string achievement)
        {
            if (string.IsNullOrWhiteSpace(achievement))
            {
                return _athletes.Where(a => a.PersonalRecords.Any(pr => pr.IndexOf("wr", StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
            }
            else
            {
                return _athletes.Where(a => a.PersonalRecords.Any(pr => pr.IndexOf(achievement, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
            }
        }

        public List<Athlete> FilterAthletesByAchievements(string achievement)
        {
            return _athletes.Where(a => a.PersonalRecords.Any(pr => pr.IndexOf(achievement.Trim(), StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
        }

        public List<Athlete> FilterAthletesByNameAndHeight(string name, double minHeight, double maxHeight)
        {
            return _athletes.Where(a => ContainsFullName(a, name) && a.Height >= minHeight && a.Height <= maxHeight).ToList();
        }

        public List<Athlete> FilterAthletesByNameAndRecordHolders(string name, string records)
        {
            return _athletes.Where(a => ContainsFullName(a, name) && a.PersonalRecords.Any(pr => pr.IndexOf("wr", StringComparison.OrdinalIgnoreCase) >= 0 && pr.IndexOf(records, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
        }

        public List<Athlete> FilterAthletesByNameAndAchievements(string name, string achievement)
        {
            return _athletes.Where(a => ContainsFullName(a, name) && a.PersonalRecords.Any(pr => pr.IndexOf(achievement, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
        }

        public List<Athlete> FilterAthletesByCountryAndHeight(string country, double minHeight, double maxHeight)
        {
            return _athletes.Where(a => a.Country.IndexOf(country, StringComparison.OrdinalIgnoreCase) >= 0 && a.Height >= minHeight && a.Height <= maxHeight).ToList();
        }

        public List<Athlete> FilterAthletesByCountryAndRecordHolders(string country, string records)
        {
            return _athletes.Where(a => a.Country.IndexOf(country, StringComparison.OrdinalIgnoreCase) >= 0 && a.PersonalRecords.Any(pr => pr.IndexOf("wr", StringComparison.OrdinalIgnoreCase) >= 0 && pr.IndexOf(records, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
        }

        public List<Athlete> FilterAthletesByCountryAndAchievements(string country, string achievement)
        {
            return _athletes.Where(a => a.Country.IndexOf(country, StringComparison.OrdinalIgnoreCase) >= 0 && a.PersonalRecords.Any(pr => pr.IndexOf(achievement, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
        }

        public List<Athlete> FilterAthletesBySportAndHeight(string sport, double minHeight, double maxHeight)
        {
            return _athletes.Where(a => a.Sport.IndexOf(sport, StringComparison.OrdinalIgnoreCase) >= 0 && a.Height >= minHeight && a.Height <= maxHeight).ToList();
        }

        public List<Athlete> FilterAthletesBySportAndRecordHolders(string sport, string records)
        {
            return _athletes.Where(a => a.Sport.IndexOf(sport, StringComparison.OrdinalIgnoreCase) >= 0 && a.PersonalRecords.Any(pr => pr.IndexOf("wr", StringComparison.OrdinalIgnoreCase) >= 0 && pr.IndexOf(records, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
        }

        public List<Athlete> FilterAthletesBySportAndAchievements(string sport, string achievement)
        {
            return _athletes.Where(a => a.Sport.IndexOf(sport, StringComparison.OrdinalIgnoreCase) >= 0 && a.PersonalRecords.Any(pr => pr.IndexOf(achievement, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
        }

        public void SaveAthleteToTextFile(Athlete athlete, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Ім'я: {athlete.FirstName} {athlete.LastName}");
                writer.WriteLine($"Дата народження: {athlete.DateOfBirth.ToShortDateString()}");
                writer.WriteLine($"Зріст: {athlete.Height} cm");
                writer.WriteLine($"Вага: {athlete.Weight} kg");
                writer.WriteLine($"Країна: {athlete.Country}");
                writer.WriteLine($"Спорт: {athlete.Sport}");
                writer.WriteLine($"Клуб або команда: {athlete.ClubOrTeam}");
                writer.WriteLine($"Тренер: {athlete.Coach}");
                writer.WriteLine();

                writer.WriteLine("Досягнення:");
                foreach (var record in athlete.PersonalRecords)
                {
                    writer.WriteLine($"- {record}");
                }
                writer.WriteLine();

                writer.WriteLine("Ігри/Змагання:");
                foreach (var game in athlete.Games)
                {
                    writer.WriteLine($"{game.Date.ToShortDateString()} - {game.Opponent} - {game.Result}");
                }
            }
        }
    }
}

