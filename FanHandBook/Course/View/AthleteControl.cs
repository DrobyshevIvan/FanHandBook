using Course.Controller;
using Course.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Course.View
{
    public partial class AthleteControl : UserControl
    {
        private AthleteController _athleteController;
        public Athlete Athlete { get; private set; }

        public AthleteControl(Athlete athlete, AthleteController athleteController)
        {
            InitializeComponent();
            Athlete = athlete;
            _athleteController = athleteController;
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblName.Text = $"{Athlete.FirstName} {Athlete.LastName}";
            lblCountry.Text = $"Країна: {Athlete.Country}";
            lblSport.Text = $"Спорт: {Athlete.Sport}";

            string photoPath = Athlete.PhotoUrl;
            if (string.IsNullOrEmpty(photoPath) || !File.Exists(photoPath))
            {
                photoPath = "C:\\Study\\OPR\\Course\\Course\\photos\\logo.jpg";
            }

            pictureBox1.Image = Image.FromFile(photoPath);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Athlete != null)
            {
                var confirmResult = MessageBox.Show("Ви впевненні, що хочете видалити спортсмена?",
                                                     "Підтвердіть видалення",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _athleteController.RemoveAthlete(Athlete.AthleteId);
                        Parent.Controls.Remove(this);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Спортсмен не знайдений", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            OnInfoRequested();
        }

        public event EventHandler InfoRequested;
        protected virtual void OnInfoRequested()
        {
            InfoRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}

