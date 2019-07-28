using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RandomRoutine
{
    public partial class MainPage : ContentPage
    {
        List<string> exPush, exPull, exLegs, exBiceps, exTriceps, exBonus;

        public MainPage()
        {
            InitializeComponent();
            CreateLists();
        }

        private void CreateLists()
        {
            exPush = new List<string>() { "Overhead Press (75)", "Bench Press (135)", "Ring Flys", "Dips" };
            exPull = new List<string>() { "Pull Ups", "Horizontal Rows", "Barbell Rows (95)", "Pull Up Negatives" };
            exLegs = new List<string>() { "Deadlift (185)", "Squat (135)", "Split Squat (95)", "Goblet Squat (45)" };
            exBiceps = new List<string>() { "Preacher Curls (55)", "Barbell Curls (65)", "DB Curls (25)" };
            exTriceps = new List<string>() { "Band Extensions", "Reverse Grip Bench (95)", "Skull Crushers (55)" };
            exBonus = new List<string>() { "KB Thrusters (45)", "KB Snatch (25)", "Butterfly Raises" };
        }

        private void BtnRandom_Clicked(object sender, EventArgs e)
        {
            var random = new Random();

            List<string> exercises = new List<string>()
            {
                exPush[random.Next(exPush.Count)],
                exPull[random.Next(exPull.Count)],
                exLegs[random.Next(exLegs.Count)],
                exBiceps[random.Next(exBiceps.Count)],
                exTriceps[random.Next(exTriceps.Count)],
                exBonus[random.Next(exBonus.Count)]
            };

            lblPushEx.Text = exercises[0];
            lblPullEx.Text = exercises[1];
            lblLegsEx.Text = exercises[2];
            lblBicepsEx.Text = exercises[3];
            lblTricepsEx.Text = exercises[4];
            lblBonusEx.Text = exercises[5];

        }
    }
}
