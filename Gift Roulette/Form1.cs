using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gift_Roulette
{
    public partial class Form1 : Form
    {
        Gifts myGifts = new Gifts();
        public Form1()
        {
             InitializeComponent();
            this.Text = "Gift Roulette";
            
            //Turn these buttons off
            btnOpen.Enabled = false;
            btnPass.Enabled = false;
            btnReset.Enabled = false;
        }
        
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            //Turn these buttons on
            btnShuffle.Visible = true;
            btnOpen.Visible = true;
            btnPass.Visible = true;
            btnReset.Visible = true;
            pbGift.Visible = true;
            pbWinLose.Visible = true;

            //Turn these buttons off
            btnStartGame.Visible = false;
            btnHTP.Visible = false;
        }

        //How to play the game
        private void btnHTP_Click(object sender, EventArgs e) 
            
        {
            MessageBox.Show(
                "First shuffle then open the presents to collect the money, but be careful because 1 of these 6 presents " +
                "contains a BOMB! You have two chances to pass the bomb so use them wisely. \n\n Good Luck!");
        }
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            myGifts.Bomb = myGifts.RandomNumber();

            pbGift.Image = Gift_Roulette.Resource1.Shuffle;
            playShuffling();

            btnOpen.Enabled = true;
            btnPass.Enabled = true;
            btnShuffle.Enabled = false;
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            Pass();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void Open()
        {
            
            myGifts.count = myGifts.count + 1;
            lblTurn.Text = "Turn: " + myGifts.count;

            //Open button used (No Bomb Hit)
            if (myGifts.count != myGifts.Bomb && myGifts.clickCounter != 0)
            {
                playDing();
                pbGift.Image = Gift_Roulette.Resource1.Money;
                DialogResult result = MessageBox.Show("No bomb here! Just a whole lot of money!");
                
                if (result == DialogResult.OK)
                {

                    pbGift.Image = Gift_Roulette.Resource1.Gift;
                }
            }
            
            //Open button used to hit bomb (player loses)
            if (myGifts.count == myGifts.Bomb | myGifts.clickCounter == 0)
            {
                myGifts.lossCount = myGifts.lossCount + 1;

                pbGift.Image = Gift_Roulette.Resource1.Explosion;
                playExplosion();

                DialogResult result = MessageBox.Show("Oh NO! You opened the gift with the Bomb and lost all the money!");

                pbWinLose.Image = Gift_Roulette.Resource1.TryAgain;
                

                btnOpen.Enabled = false;
                btnPass.Enabled = false;
                btnShuffle.Enabled = false;

                btnReset.Enabled = true;

                lblWinLoss.Text = "Wins: " + myGifts.winCount + " " + "Loses: " + myGifts.lossCount;
            }
          
        }

        void Pass()
        {
            myGifts.count = myGifts.count + 1;
            myGifts.clickCounter = myGifts.clickCounter - 1;

            lblPasses.Text = "Passes Left: " + myGifts.clickCounter;
            lblTurn.Text = "Turn: " + myGifts.count;
            
            //Button pressed to pass the money
            if (myGifts.count != myGifts.Bomb)
              {
                pbGift.Image = Gift_Roulette.Resource1.Money;
                playSad();
                DialogResult result = MessageBox.Show("Unlucky, you passed up some money!");
                 if (result == DialogResult.OK)
                {
                    pbGift.Image = Gift_Roulette.Resource1.Gift;
                }
            }
           
            //Button pressed to pass the bomb.( Player Wins )
            if (myGifts.count == myGifts.Bomb)
                 {
                    myGifts.winCount = myGifts.winCount + 1;
                pbGift.Image = Gift_Roulette.Resource1.Bomb;
                pbSlowClap.Image = Gift_Roulette.Resource1.SlowClap;
                SlowClap();
                playClap();

                lblWinLoss.Text = "Wins: " + myGifts.winCount + " " + "Loses: " + myGifts.lossCount;
                DialogResult result = MessageBox.Show("You passed the bomb! You win and get to keep the money!");
                
                if (result == DialogResult.OK)
                {
                    stopSound();
                    pbSlowClap.Image = null;
                    pbGift.Image = Gift_Roulette.Resource1.Win;
                    pbWinLose.Image = Gift_Roulette.Resource1.YouWin;
                    playMoney();
                }

                btnShuffle.Enabled = false;
                btnOpen.Enabled = false;
                btnPass.Enabled = false;

                btnReset.Enabled = true;

            }

            if (myGifts.clickCounter == 0 && myGifts.count != myGifts.Bomb) 
                //player only has two chances to pass

            {
                MessageBox.Show("Uh Oh, that was your last pass! The next gift isn't looking too good for you!");
                btnPass.Enabled = false;
            }
            
        }
        /// <summary>
        /// Resets everything (buttons, labels, counts and picture boxes)
        /// </summary>
        void Reset()
        {
           

            pbGift.Image = Gift_Roulette.Resource1.Gift;
            pbWinLose.Image = null;
            
            btnOpen.Enabled = false;
            btnPass.Enabled = false;
            btnReset.Enabled = false;
            btnShuffle.Enabled = true;

            myGifts.clickCounter = 2;
            
            myGifts.count = 0;
            lblTurn.Text = "";
            lblPasses.Text = "";
            stopSound();
        }

        /// <summary>
        /// Makes the slow clap picture box close after it has played
        /// </summary>
        public async void SlowClap() 
        {
            pbSlowClap.Visible = true;

            await Task.Delay(15000);

            pbSlowClap.Visible = false;

        }

        //These will make sounds play
        private void playExplosion()   
        {
            SoundPlayer Explosion = new SoundPlayer(Resource1.Explosion1);
            Explosion.Play();
        }
       
        private void playMoney()
        {
            SoundPlayer Money = new SoundPlayer(Resource1.MoneySong);
            Money.Play();
        }
        private void playDing()
        {
            SoundPlayer Ding = new SoundPlayer(Resource1.Ding);
            Ding.Play();
        }
        private void playSad()
        {
            SoundPlayer Sad = new SoundPlayer(Resource1.OhSound);
            Sad.Play();
        }
        private void playClap()
        {
            SoundPlayer Clap = new SoundPlayer(Resource1.ClapSound);
            Clap.Play();
        }
        private void playShuffling()
        {
            SoundPlayer Shuffling = new SoundPlayer(Resource1.Shuffling);
            Shuffling.Play();
        }
        /// <summary>
        /// Sound will stop
        /// </summary>
        private void stopSound()
        {
            SoundPlayer Sound = new SoundPlayer();
            Sound.Stop();
        } 
    }
    
}
