using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Course.Controller;
using Course.Model;

namespace Course.View
{
    public partial class AthleteDetailsForm : Form
    {
        private Athlete _athlete;
        private AthleteController _controller;

        public AthleteDetailsForm(Athlete athlete, AthleteController controller)
        {
            InitializeComponent();
            _controller = controller;
            _athlete = athlete ?? throw new ArgumentNullException(nameof(athlete));
            DisplayAthleteInfo();
        }

        private void DisplayAthleteInfo()
        {
            lblName.Text = $"Name: {_athlete.FirstName} {_athlete.LastName}";
            lblDateOfBirth.Text = $"Date of Birth: {_athlete.DateOfBirth.ToShortDateString()}";
            lblHeight.Text = $"Height: {_athlete.Height} cm";
            lblWeight.Text = $"Weight: {_athlete.Weight} kg";
            lblCountry.Text = $"Country: {_athlete.Country}";
            lblSport.Text = $"Sport: {_athlete.Sport}";
            lblClubOrTeam.Text = $"Club/Team: {_athlete.ClubOrTeam}";
            lblCoach.Text = $"Coach: {_athlete.Coach}";

            lblPersonalRecords.Text = string.Join("\n", _athlete.PersonalRecords);

            if (!string.IsNullOrEmpty(_athlete.PhotoUrl) && File.Exists(_athlete.PhotoUrl))
                pictureBoxPhoto.Image = Image.FromFile(_athlete.PhotoUrl);

            dataGridViewGames.Rows.Clear();
            foreach (var game in _athlete.Games)
            {
                dataGridViewGames.Rows.Add(game.Date.ToShortDateString(), game.Opponent, game.Result);
            }
        }

        private void SaveAthleteData()
        {
            _controller.UpdateAthlete(_athlete);
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            if (dataGridViewGames.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewGames.SelectedRows[0];
                var date = DateTime.Parse(selectedRow.Cells[0].Value.ToString());
                var opponent = selectedRow.Cells[1].Value.ToString();

                var gameToRemove = _athlete.Games.FirstOrDefault(g => g.Date.Date == date.Date && g.Opponent == opponent);
                if (gameToRemove != null)
                {
                    _athlete.Games.Remove(gameToRemove);
                    dataGridViewGames.Rows.Remove(selectedRow);

                    SaveAthleteData();
                }
                else
                {
                    MessageBox.Show("Selected game not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a game to delete.");
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            var addGameForm = new AddGameForm();
            if (addGameForm.ShowDialog() == DialogResult.OK)
            {
                var newGame = addGameForm.NewGame;
                _athlete.Games.Add(newGame);
                dataGridViewGames.Rows.Add(newGame.Date.ToShortDateString(), newGame.Opponent, newGame.Result);

                SaveAthleteData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var addForm = new AddAthleteForm(_athlete);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                _athlete = addForm.UpdatedAthlete;
                SaveAthleteData();
                DisplayAthleteInfo();
            }
        }
    }
}
