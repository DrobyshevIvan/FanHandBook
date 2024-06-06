using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Course.Model;
using Course.Controller;

namespace Course.View
{
    public partial class AthleteControl : UserControl
    {
        private Athlete _athlete;
        private AthleteController _controller;

        public AthleteControl(Athlete athlete, AthleteController controller)
        {
            InitializeComponent();
            _controller = controller;
            _athlete = athlete;
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblName.Text = $"{_athlete.FirstName} {_athlete.LastName}";
            lblCountry.Text = $"Country: {_athlete.Country}";
            lblSport.Text = $"Sport: {_athlete.Sport}";

            string photoPath = _athlete.PhotoUrl;
            if (string.IsNullOrEmpty(photoPath) || !File.Exists(photoPath))
            {
                photoPath = "C:\\Study\\OPR\\Course\\Course\\vini.png";
            }

            pictureBox1.Image = Image.FromFile(photoPath);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_athlete != null)
            {
                var confirmResult = MessageBox.Show("Ви впевненні, що хочете видалити спортсмена?",
                                                    "Підтвердіть видалення",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    _controller.RemoveAthlete(_athlete.AthleteId);
                    Parent.Controls.Remove(this);
                }
            }
            else
            {
                MessageBox.Show("Спортсмен не знайдений", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var detailsForm = new AthleteDetailsForm(_athlete, _controller);
            if (detailsForm.ShowDialog() == DialogResult.OK)
            {
                UpdateUI();
            }
        }
    }
}
