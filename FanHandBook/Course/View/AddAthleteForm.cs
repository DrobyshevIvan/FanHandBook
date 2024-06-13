using Course.Controller;
using Course.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Course.View
{
    public partial class AddAthleteForm : Form
    {
        private AthleteController _athleteController;
        private bool isEditing = false;
        private Athlete athleteToEdit;

        public Athlete NewAthlete { get; private set; }
        public Athlete UpdatedAthlete { get; private set; }

        public AddAthleteForm(AthleteController athleteController)
        {
            InitializeComponent();
            _athleteController = athleteController;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // випадок редагування спортсмена(оновлення його даних)
                athleteToEdit.FirstName = txtFirstName.Text;
                athleteToEdit.LastName = txtLastName.Text;
                athleteToEdit.DateOfBirth = dateTimePicker1.Value;
                athleteToEdit.Height = Convert.ToDouble(txtHeight.Text);
                athleteToEdit.Weight = Convert.ToDouble(txtWeight.Text);
                athleteToEdit.Country = txtCountry.Text;
                athleteToEdit.Sport = txtSport.Text;
                athleteToEdit.ClubOrTeam = txtClub.Text;
                athleteToEdit.Coach = txtCoach.Text;
                athleteToEdit.PersonalRecords = new List<string>(listAchievements.Items.Cast<string>());

                if (string.IsNullOrEmpty(openFileDialog.FileName) && string.IsNullOrEmpty(athleteToEdit.PhotoUrl))
                {
                    athleteToEdit.PhotoUrl = "C:\\Study\\OPR\\Course\\Course\\photos\\logo.jpg";
                }
                else if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    athleteToEdit.PhotoUrl = openFileDialog.FileName;
                }

                UpdatedAthlete = athleteToEdit;
                
                _athleteController.UpdateAthlete(athleteToEdit);
            }
            else
            {
                // випадок створення нового спортсмена
                var newAthlete = new Athlete
                {
                    AthleteId = Guid.NewGuid().ToString(),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    DateOfBirth = dateTimePicker1.Value,
                    Height = Convert.ToDouble(txtHeight.Text),
                    Weight = Convert.ToDouble(txtWeight.Text),
                    Country = txtCountry.Text,
                    Sport = txtSport.Text,
                    ClubOrTeam = txtClub.Text,
                    Coach = txtCoach.Text,
                    PersonalRecords = new List<string>(listAchievements.Items.Cast<string>()),
                };

                if (string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    newAthlete.PhotoUrl = "C:\\Study\\OPR\\Course\\Course\\photos\\logo.jpg";
                }
                else
                {
                    newAthlete.PhotoUrl = openFileDialog.FileName;
                }

                NewAthlete = newAthlete;
                
                _athleteController.AddAthlete(newAthlete);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        public void EditAthlete(Athlete athlete)
        {
            isEditing = true;
            athleteToEdit = athlete;

            txtFirstName.Text = athlete.FirstName;
            txtLastName.Text = athlete.LastName;
            txtCountry.Text = athlete.Country;
            txtSport.Text = athlete.Sport;
            txtClub.Text = athlete.ClubOrTeam;
            txtCoach.Text = athlete.Coach;
            dateTimePicker1.Value = athlete.DateOfBirth;
            txtHeight.Text = athlete.Height.ToString();
            txtWeight.Text = athlete.Weight.ToString();
            listAchievements.Items.Clear();
            foreach (var record in athlete.PersonalRecords)
            {
                listAchievements.Items.Add(record);
            }
            if (!string.IsNullOrEmpty(athlete.PhotoUrl) && File.Exists(athlete.PhotoUrl))
            {
                pictureBoxPhoto.Image = Image.FromFile(athlete.PhotoUrl);
            }
            else
            {
                string defaultPhotoPath = "C:\\Study\\OPR\\Course\\Course\\photos\\default.jpg";
                if (File.Exists(defaultPhotoPath))
                {
                    pictureBoxPhoto.Image = Image.FromFile(defaultPhotoPath);
                }
            }
        }

        private void BtnUploadPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRecord.Text))
            {
                listAchievements.Items.Add(txtRecord.Text);
                txtRecord.Clear();
            }
        }

        private void BtnEditRecord_Click(object sender, EventArgs e)
        {
            if (listAchievements.SelectedItem != null && !string.IsNullOrEmpty(txtRecord.Text))
            {
                listAchievements.Items[listAchievements.SelectedIndex] = txtRecord.Text;
                txtRecord.Clear();
            }
        }

        private void BtnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (listAchievements.SelectedItem != null)
            {
                listAchievements.Items.RemoveAt(listAchievements.SelectedIndex);
                txtRecord.Clear();
            }
        }

        private void ListAchievements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAchievements.SelectedItem != null)
            {
                txtRecord.Text = listAchievements.SelectedItem.ToString();
            }
        }
    }
}



