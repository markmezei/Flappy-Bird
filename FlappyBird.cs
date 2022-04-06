using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class FlappyBird : Form{
        int score = 0;
        int gravity = 15;
        int speed = 7;
      
        public FlappyBird(){
            InitializeComponent();
            Timer.Start();
        }

        private void SoundEffect(){
            SoundPlayer sound = new SoundPlayer(@"C:\Users\Mark\Documents\Programozás\Flappy Bird\Resources\EZ sound effect.wav");
            sound.Play();
        }

        private void FlappyBird_KeyDown(object sender, KeyEventArgs key){
            if(key.KeyCode == Keys.Space){
                gravity = -15;
                Bird.Image = Properties.Resources.bird_rotated1;
            }

        }

        private void FlappyBird_KeyUp(object sender, KeyEventArgs key){
            if (key.KeyCode == Keys.Space){
                gravity = 15;
                Bird.Image = Properties.Resources.bird_rotated2;
            }
        }

        private void GameOver(){
            Timer.Stop();
            gameScore.Text += " \nGAME OVER!!! KURVA SZAR VAGY!";
        }

        private void gameEngine(object sender, EventArgs e){
            Bird.Top += gravity;
            PipeDown.Left -= speed;
            PipeUp.Left -= speed;
            gameScore.Text = "Score: " + score;

            if (PipeDown.Left < -130){
                PipeDown.Left = 800;
                score++;
                SoundEffect();
            }
            if (PipeUp.Left < -130){
                PipeUp.Left = 800;
            }
            if (Bird.Bounds.IntersectsWith(PipeDown.Bounds) || Bird.Bounds.IntersectsWith(PipeUp.Bounds) || Bird.Bounds.IntersectsWith(Ground.Bounds) || Bird.Top < -30){
                GameOver();
            }
            if (score >= 5){
                speed = 12;
            }
            if(score >= 10){
                speed = 18;
            }
            if(score >= 15){
                speed = 20;
            }
            if(score >= 20){
                speed = 25;
            }
            if (score >= 25){
                speed = 30;
            }
        }
    }
}
