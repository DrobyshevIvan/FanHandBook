using Course.Controller;
using Course.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Course.View
{
    public partial class AllAthletes : Form
    {
        private AthleteController _athleteController;

        public AllAthletes(AthleteController athleteController)
        {
            InitializeComponent();
            _athleteController = athleteController;
            LoadAthletes();
        }

        private void LoadAthletes()
        {
            List<Athlete> athletes = _athleteController.GetAthletes();
            DisplayAthletes(athletes);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text;
            List<Athlete> filteredAthletes = new List<Athlete>();

            if (radioBtnName.Checked && comboBox.SelectedItem?.ToString() == "Зріст")
            {
                if (double.TryParse(textBox2.Text, out double minHeight) && double.TryParse(textBox3.Text, out double maxHeight))
                {
                    filteredAthletes = _athleteController.FilterAthletesByNameAndHeight(searchQuery, minHeight, maxHeight);
                }
            }
            else if (radioBtnName.Checked && comboBox.SelectedItem?.ToString() == "Рекордсмен")
            {
                filteredAthletes = _athleteController.FilterAthletesByNameAndRecordHolders(searchQuery, textBox2.Text);
            }
            else if (radioBtnName.Checked && comboBox.SelectedItem?.ToString() == "Досягнення")
            {
                filteredAthletes = _athleteController.FilterAthletesByNameAndAchievements(searchQuery, textBox2.Text);
            }
            else if (radioBtnCountry.Checked && comboBox.SelectedItem?.ToString() == "Зріст")
            {
                if (double.TryParse(textBox2.Text, out double minHeight) && double.TryParse(textBox3.Text, out double maxHeight))
                {
                    filteredAthletes = _athleteController.FilterAthletesByCountryAndHeight(searchQuery, minHeight, maxHeight);
                }
            }
            else if (radioBtnCountry.Checked && comboBox.SelectedItem?.ToString() == "Рекордсмен")
            {
                filteredAthletes = _athleteController.FilterAthletesByCountryAndRecordHolders(searchQuery, textBox2.Text);
            }
            else if (radioBtnCountry.Checked && comboBox.SelectedItem?.ToString() == "Досягнення")
            {
                filteredAthletes = _athleteController.FilterAthletesByCountryAndAchievements(searchQuery, textBox2.Text);
            }
            else if (radioBtnSport.Checked && comboBox.SelectedItem?.ToString() == "Зріст")
            {
                if (double.TryParse(textBox2.Text, out double minHeight) && double.TryParse(textBox3.Text, out double maxHeight))
                {
                    filteredAthletes = _athleteController.FilterAthletesBySportAndHeight(searchQuery, minHeight, maxHeight);
                }
            }
            else if (radioBtnSport.Checked && comboBox.SelectedItem?.ToString() == "Рекордсмен")
            {
                filteredAthletes = _athleteController.FilterAthletesBySportAndRecordHolders(searchQuery, textBox2.Text);
            }
            else if (radioBtnSport.Checked && comboBox.SelectedItem?.ToString() == "Досягнення")
            {
                filteredAthletes = _athleteController.FilterAthletesBySportAndAchievements(searchQuery, textBox2.Text);
            }
            else if (radioBtnName.Checked)
            {
                filteredAthletes = _athleteController.FilterAthletesByName(searchQuery);
            }
            else if (radioBtnCountry.Checked)
            {
                filteredAthletes = _athleteController.FilterAthletesByCountry(searchQuery);
            }
            else if (radioBtnSport.Checked)
            {
                filteredAthletes = _athleteController.FilterAthletesBySport(searchQuery);
            }
            else if (comboBox.SelectedItem?.ToString() == "Зріст")
            {
                if (double.TryParse(textBox2.Text, out double minHeight) && double.TryParse(textBox3.Text, out double maxHeight))
                {
                    filteredAthletes = _athleteController.FilterAthletesByHeight(minHeight, maxHeight);
                }
            }
            else if (comboBox.SelectedItem?.ToString() == "Рекордсмен")
            {
                filteredAthletes = _athleteController.FilterAthletesByRecordHolders(textBox2.Text);
            }
            else if (comboBox.SelectedItem?.ToString() == "Досягнення")
            {
                filteredAthletes = _athleteController.FilterAthletesByAchievements(textBox2.Text);
            }

            DisplayAthletes(filteredAthletes);
        }

        public void DisplayAthletes(List<Athlete> athletes)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var athlete in athletes)
            {
                AthleteControl athleteControl = new AthleteControl(athlete, _athleteController);
                flowLayoutPanel1.Controls.Add(athleteControl);
                athleteControl.InfoRequested += (sender, e) =>
                {
                    AthleteDetailsForm detailsForm = new AthleteDetailsForm(athlete, _athleteController);
                    if (detailsForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadAthletes();
                    }
                };
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox3.Text = null;
            textBox2.Visible = false;
            textBox3.Visible = false;
            switch (comboBox.SelectedItem?.ToString())
            {
                case "Зріст":
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox2.PlaceholderText = "Від";
                    textBox3.PlaceholderText = "До";
                    break;
                case "Досягнення":
                    textBox2.Visible = true;
                    textBox2.PlaceholderText = "Досягнення";
                    break;
                case "Рекордсмен":
                    textBox2.Visible = true;
                    textBox2.PlaceholderText = "Рекорд";
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAthleteForm addForm = new AddAthleteForm(_athleteController);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadAthletes();
            }
        }

        private void AllAthletes_Load(object sender, EventArgs e)
        {
            LoadAthletes();
        }

        private void btnAllAthletes_Click(object sender, EventArgs e)
        {
            LoadAthletes();
        }
    }
}


