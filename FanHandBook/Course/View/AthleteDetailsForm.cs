using Course.Controller;
using Course.Model;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Course.View
{
    public partial class AthleteDetailsForm : Form
    {
        private Athlete _athlete;
        private AthleteController _athleteController;

        public AthleteDetailsForm(Athlete athlete, AthleteController athleteController)
        {
            InitializeComponent();
            _athlete = athlete;
            _athleteController = athleteController;
            DisplayAthleteInfo();
        }

        private void DisplayAthleteInfo()
        {
            lblName.Text = $"Ім'я: {_athlete.FirstName} {_athlete.LastName}";
            lblDateOfBirth.Text = $"Дата народження: {_athlete.DateOfBirth.ToShortDateString()}";
            lblHeight.Text = $"Висота: {_athlete.Height} cm";
            lblWeight.Text = $"Вага: {_athlete.Weight} kg";
            lblCountry.Text = $"Країна: {_athlete.Country}";
            lblSport.Text = $"Спорт: {_athlete.Sport}";
            lblClubOrTeam.Text = $"Команда: {_athlete.ClubOrTeam}";
            lblCoach.Text = $"Тренер: {_athlete.Coach}";

            dataGridViewGames.Rows.Clear();
            foreach (var game in _athlete.Games)
            {
                dataGridViewGames.Rows.Add(game.Date.ToShortDateString(), game.Opponent, game.Result);
            }

            lblPersonalRecords.Text = string.Join("\n", _athlete.PersonalRecords);

            if (!string.IsNullOrEmpty(_athlete.PhotoUrl) && File.Exists(_athlete.PhotoUrl))
                pictureBoxPhoto.Image = Image.FromFile(_athlete.PhotoUrl);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddAthleteForm addForm = new AddAthleteForm(_athleteController);
            addForm.EditAthlete(_athlete);

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                _athlete = addForm.UpdatedAthlete;
                _athleteController.UpdateAthlete(_athlete);
                DisplayAthleteInfo();
                DialogResult = DialogResult.OK;
            }
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
                    _athleteController.UpdateAthlete(_athlete);
                }
                else
                {
                    MessageBox.Show("Вибрана гра не знайдена!");
                }
            }
            else
            {
                MessageBox.Show("Виберіть гру яку потрібно видалити!");
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            AddGameForm addGameForm = new AddGameForm();
            if (addGameForm.ShowDialog() == DialogResult.OK)
            {
                var newGame = addGameForm.NewGame;
                _athlete.Games.Add(newGame);
                dataGridViewGames.Rows.Add(newGame.Date.ToShortDateString(), newGame.Opponent, newGame.Result);
                _athleteController.UpdateAthlete(_athlete);
            }
        }

        private void btnSaveToTextFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _athleteController.SaveAthleteToTextFile(_athlete, saveFileDialog.FileName);
                MessageBox.Show("Дані про спортсмена збережено у файл.");
            }
        }
    }
}

