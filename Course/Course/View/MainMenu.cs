using Course.View;
using Course.Controller;

namespace Course
{
    public partial class MainMenu : Form
    {
        private AthleteController _athleteController;

        public MainMenu()
        {
            InitializeComponent();
            _athleteController = new AthleteController("athletes.json");
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            AllAthletes allAthletes = new AllAthletes(_athleteController);
            Hide();
            allAthletes.ShowDialog();
            Show();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}