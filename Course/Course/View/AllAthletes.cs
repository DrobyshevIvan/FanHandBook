using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Course.Model;
using Course.Controller;

namespace Course.View
{
    public partial class AllAthletes : Form
    {
        private AthleteController _controller;

        public AllAthletes(AthleteController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text;
            List<Athlete> filteredAthletes = new List<Athlete>();

            if (radioButton1.Checked && comboBox1.SelectedItem?.ToString() == "Зріст")
            {
                if (double.TryParse(textBox2.Text, out double minHeight) && double.TryParse(textBox3.Text, out double maxHeight))
                {
                    filteredAthletes = _controller.FilterAthletesByNameAndHeight(searchQuery, minHeight, maxHeight);
                }
            }
            else if (radioButton1.Checked && comboBox1.SelectedItem?.ToString() == "Рекордсмен")
            {
                filteredAthletes = _controller.FilterAthletesByNameAndRecordHolders(searchQuery, textBox2.Text);
            }
            else if (radioButton1.Checked && comboBox1.SelectedItem?.ToString() == "Досягнення")
            {
                filteredAthletes = _controller.FilterAthletesByNameAndAchievements(searchQuery, textBox2.Text);
            }
            else if (radioButton2.Checked && comboBox1.SelectedItem?.ToString() == "Зріст")
            {
                if (double.TryParse(textBox2.Text, out double minHeight) && double.TryParse(textBox3.Text, out double maxHeight))
                {
                    filteredAthletes = _controller.FilterAthletesByCountryAndHeight(searchQuery, minHeight, maxHeight);
                }
            }
            else if (radioButton2.Checked && comboBox1.SelectedItem?.ToString() == "Рекордсмен")
            {
                filteredAthletes = _controller.FilterAthletesByCountryAndRecordHolders(searchQuery, textBox2.Text);
            }
            else if (radioButton2.Checked && comboBox1.SelectedItem?.ToString() == "Досягнення")
            {
                filteredAthletes = _controller.FilterAthletesByCountryAndAchievements(searchQuery, textBox2.Text);
            }
            else if (radioButton3.Checked && comboBox1.SelectedItem?.ToString() == "Зріст")
            {
                if (double.TryParse(textBox2.Text, out double minHeight) && double.TryParse(textBox3.Text, out double maxHeight))
                {
                    filteredAthletes = _controller.FilterAthletesBySportAndHeight(searchQuery, minHeight, maxHeight);
                }
            }
            else if (radioButton3.Checked && comboBox1.SelectedItem?.ToString() == "Рекордсмен")
            {
                filteredAthletes = _controller.FilterAthletesBySportAndRecordHolders(searchQuery, textBox2.Text);
            }
            else if (radioButton3.Checked && comboBox1.SelectedItem?.ToString() == "Досягнення")
            {
                filteredAthletes = _controller.FilterAthletesBySportAndAchievements(searchQuery, textBox2.Text);
            }
            else if (radioButton1.Checked)
            {
                filteredAthletes = _controller.FilterAthletesByName(searchQuery);
            }
            else if (radioButton2.Checked)
            {
                filteredAthletes = _controller.FilterAthletesByCountry(searchQuery);
            }
            else if (radioButton3.Checked)
            {
                filteredAthletes = _controller.FilterAthletesBySport(searchQuery);
            }
            else if (comboBox1.SelectedItem?.ToString() == "Зріст")
            {
                if (double.TryParse(textBox2.Text, out double minHeight) && double.TryParse(textBox3.Text, out double maxHeight))
                {
                    filteredAthletes = _controller.FilterAthletesByHeight(minHeight, maxHeight);
                }
            }
            else if (comboBox1.SelectedItem?.ToString() == "Рекордсмен")
            {
                filteredAthletes = _controller.FilterAthletesByRecordHolders(textBox2.Text);
            }
            else if (comboBox1.SelectedItem?.ToString() == "Досягнення")
            {
                filteredAthletes = _controller.FilterAthletesByAchievements(textBox2.Text);
            }

            DisplayAthletes(filteredAthletes);
        }

        public void DisplayAthletes(List<Athlete> athletes)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var athlete in athletes)
            {
                var athleteControl = new AthleteControl(athlete, _controller);
                flowLayoutPanel1.Controls.Add(athleteControl);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox3.Text = null;
            textBox2.Visible = false;
            textBox3.Visible = false;
            switch (comboBox1.SelectedItem?.ToString())
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

        private void button2_Click(object sender, EventArgs e)
        {
            var addForm = new AddAthleteForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Athlete newAthlete = addForm.NewAthlete;
                _controller.AddAthlete(newAthlete);
                MessageBox.Show("Athlete added to the file successfully!");
                LoadAthletes();
            }
        }

        private void AllAthletes_Load(object sender, EventArgs e)
        {
            LoadAthletes();
        }

        private void LoadAthletes()
        {
            var athletes = _controller.LoadAllAthletes();
            DisplayAthletes(athletes);
        }
    }
}

