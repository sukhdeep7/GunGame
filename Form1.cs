using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GunGame
{
    public partial class Form1 : Form
    {
        private Logic LogicClass = new Logic();

        public Form1()
        {
            InitializeComponent();
            Bitmap bp = new Bitmap(GunGame.Resource1.startgame);
            pictureBox1.Image = bp;

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer smp = new System.Media.SoundPlayer(GunGame.Resource1.loadSound);
            smp.Play();
            Bitmap bp = new Bitmap(GunGame.Resource1.load);
            pictureBox1.Image = bp;
            LogicClass.Loading();

        }

        private void SpinBtn_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer smp = new System.Media.SoundPlayer(GunGame.Resource1.loadSound);
            smp.Play();
            Bitmap bp = new Bitmap(GunGame.Resource1.spin);
            pictureBox1.Image = bp;
            LogicClass.Spinning();
        }

        private void FireBtn_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer smp = new System.Media.SoundPlayer(GunGame.Resource1.fireSound);
            smp.Play();
            Bitmap bp = new Bitmap(GunGame.Resource1.shoot);
            pictureBox1.Image = bp;
            LogicClass.Shooting();
        }

        private void FireAwayBtn_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer smp = new System.Media.SoundPlayer(GunGame.Resource1.fireSound);
            smp.Play();
            Bitmap bp = new Bitmap(GunGame.Resource1.fireaway);
            pictureBox1.Image = bp;
            LogicClass.ShootingAway();
        }

        private void PlayAgainBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
