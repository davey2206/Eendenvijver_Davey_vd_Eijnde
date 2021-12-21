using System;
using System.Windows.Forms;

namespace Eendenvijver
{
    public partial class LakeFrom : Form
    {
        private Lake lake = new Lake();

        public LakeFrom()
        {
            InitializeComponent();
            //lake.CreateLake();
            turn();
        }

        public void turn()
        {
            listBoxDucks.Items.Clear();
            listBoxFrogs.Items.Clear();
            listBoxStorks.Items.Clear();
            foreach (var duck in lake.getDucks())
            {
                listBoxDucks.Items.Add(duck.Gender + "    " + duck.Age);
            }

            foreach (var frog in lake.getFrogs())
            {
                listBoxFrogs.Items.Add(frog.Id.ToString());
            }

            foreach (var stork in lake.getStorks())
            {
                listBoxStorks.Items.Add(stork.Id.ToString() + "    " + stork.Honger);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lake.EatFrog();
            lake.age();
            lake.Delete();
            lake.CreateDucks();
            lake.createFrogs();
            turn();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnFrog_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Math.Round(frogCounter.Value, 0));
            lake.addFrog(count);
            turn();
        }

        private void btnStorks_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Math.Round(storksCounter.Value, 0));
            lake.addStork(count);
            turn();
        }

        private void btnDucks_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Math.Round(ducksCounter.Value, 0));
            lake.addDuck(count);
            turn();
        }
    }
}