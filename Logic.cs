using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GunGame
{
    public class Logic
    {
        int Bullets;
        public void Loading()
        {
            Bullets = 6;
        }
        public int Spinning()
        {
            Random num = new Random();
            Bullets = num.Next(1, 7);
            return Bullets;
        }
        int Fire = 4;
        public int Shooting()
        {
            if (Bullets == 1)
            {
                //user dead
                MessageBox.Show("Play Again?", "Game Over!");
                Application.Exit();
            }
            else
            {
                Fire--;
                Bullets--;

                if (Fire == 0)
                {
                    MessageBox.Show("You win!!!", "Game Over");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
            }
            return Fire;
        }
        int FireAway = 2;
        public int ShootingAway()
        {
            if (Bullets == 1)
            {

                MessageBox.Show("You have still chances left");
            }
            else
            {
                FireAway--;
                Bullets--;
                //if no more chances of trail
                if (FireAway == 0)
                {
                    MessageBox.Show("Game Over");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("One last try..");
                }
            }

            return FireAway;
        }

    }
}
