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

namespace Space_Race_Summative
{

//Evan White-Roy
//June 18th
//Space Race
    public partial class Form1 : Form
    {
        //Players variables
        Rectangle player1 = new Rectangle(600, 439, 20, 20);
        Rectangle player2 = new Rectangle(200, 439, 20, 20);
        int playersSpeed = 6;

        Image rocket1 = (Properties.Resources.Rocket);
        Image rocket2 = (Properties.Resources.Rocket);

        //List of meteoroids
        List<Rectangle> meteoroids = new List<Rectangle>();
        List<int> meteoroidSpeeds = new List<int>();
        List<string> meteoroidColours = new List<string>();
        List<int> meteoroidSize = new List<int>();

        int player1Score = 0;
        int player2Score = 0;
        int time = 500;

        //player1 and player2 keybinds
        bool upPressed = false;
        bool downPressed = false;
        bool wPressed = false;
        bool sPressed = false;

        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush skyblueBrush = new SolidBrush(Color.SkyBlue);
        SolidBrush goldBrush = new SolidBrush(Color.Gold);

        Pen greenPen = new Pen(Color.Olive, 6); //greenPen for time 

        SoundPlayer crash = new SoundPlayer(Properties.Resources.Crash);
        SoundPlayer start = new SoundPlayer(Properties.Resources.Start);
        SoundPlayer end = new SoundPlayer(Properties.Resources.End);

        Random randGen = new Random();
        int randValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //Check Buttons

            switch (e.KeyCode)
            {
                case Keys.Up:
                    upPressed = false;
                    break;
                case Keys.Down:
                    downPressed = false;
                    break;

                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Check buttons
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upPressed = true;
                    break;
                case Keys.Down:
                    downPressed = true;
                    break;

                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;

                //escape button for exiting before the game starts and space button for starting the game
                case Keys.Escape:
                    if (gameTimer.Enabled == false)
                    {
                        Application.Exit();
                    }
                    break;
                case Keys.Space:
                    if (gameTimer.Enabled == false)
                    {
                        GameInitialize();
                    }
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (gameTimer.Enabled == false && time > 0)
            {
                //Starting screen
                titlelabel.Text = "Space Racer";
                subLabel.Text = "Press Space to Start or Esc to Exit";
               
            }
            else if (gameTimer.Enabled == true)
            {
                //Update score display
                scorelabel1.Text = $"{player1Score}";
                scorelabel2.Text = $"{player2Score}";

                //Draw the Players 
                e.Graphics.DrawImage(rocket1, player1);
                e.Graphics.DrawImage(rocket2, player2);

                //Draw the time
                e.Graphics.DrawLine(greenPen, 400, 450, 400, this.Height - time);

                for (int i = 0; i < meteoroids.Count(); i++)
                {
                    e.Graphics.FillEllipse(whiteBrush, meteoroids[i]);
                }

                for (int i = 0; i < meteoroids.Count(); i++)
                {
                    if (meteoroidColours[i] == "white")
                    {
                        e.Graphics.FillEllipse(whiteBrush, meteoroids[i]);
                    }
                    else if (meteoroidColours[i] == "skyblue")
                    {
                        e.Graphics.FillEllipse(skyblueBrush, meteoroids[i]);
                    }
                    else if (meteoroidColours[i] == "gold")
                    {
                        e.Graphics.FillEllipse(goldBrush, meteoroids[i]);
                    }
                }
            }
            else
            {
                //End of the Game screen
                titlelabel.Text = "GAME OVER";
                subLabel.Text = "Press Space to Start or Esc to Exit";
            }
        }
        
        private void GameInitialize()
        {
            //Reset

            titlelabel.Text = "";
            subLabel.Text = "";

            gameTimer.Enabled = true;

            time = 500;
            player1Score = 0;
            player2Score = 0;

            meteoroidColours.Clear();
            meteoroids.Clear();
            meteoroidSpeeds.Clear();

           player1 = new Rectangle(600, 439, 20, 20);
           player2 = new Rectangle(200, 439, 20, 20);

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Subtract time

            time--;

            //Player 1

            if (upPressed == true && player1.Y > 0)
            {
                player1.Y = player1.Y - playersSpeed;
            }
            if (downPressed == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y = player1.Y + playersSpeed;
            }

            //Player 2

            if (wPressed == true && player2.Y > 0)
            {
                player2.Y = player2.Y - playersSpeed;
            }
            if (sPressed == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y = player2.Y + playersSpeed;
            }

            //Create new blocks/obstacles

            for(int i = 0; i < meteoroids.Count; i++)
            {
                int x = meteoroids[i].X + meteoroidSpeeds[i];
                meteoroids[i] = new Rectangle(x, meteoroids[i].Y, meteoroidSize[i], meteoroidSize[i]);


            }

            randValue = randGen.Next(0, 100);

            //Colour size speed or blocks

            if(randValue < 10)
            {
                randValue = randGen.Next(0, this.Height - 25);

                Rectangle ball = new Rectangle(0, randValue, 0, 0);
                meteoroids.Add(ball);
                meteoroidColours.Add("skyblue");
                meteoroidSpeeds.Add(randGen.Next(5, 10));
                meteoroidSize.Add(randGen.Next(5, 13));
            }
            else if (randValue < 15)
            {
                randValue = randGen.Next(0, this.Height - 25);

                Rectangle ball = new Rectangle(this.Width - 8, randValue, 0, 0);
                meteoroids.Add(ball);
                meteoroidColours.Add("skyblue");
                meteoroidSpeeds.Add(randGen.Next(-10, -5));
                meteoroidSize.Add(randGen.Next(5, 13));
            }
            else if (randValue < 20)
            {
                randValue = randGen.Next(0, this.Height - 25);

                Rectangle ball = new Rectangle(this.Width - 8, randValue, 0, 0);
                meteoroids.Add(ball);
                meteoroidColours.Add("gold");
                meteoroidSpeeds.Add(randGen.Next(-10, -5));
                meteoroidSize.Add(randGen.Next(5, 13));
            }
            else if (randValue < 20)
            {
                randValue = randGen.Next(0, this.Height - 25);

                Rectangle ball = new Rectangle(0, randValue, 0, 0);
                meteoroids.Add(ball);
                meteoroidColours.Add("gold");
                meteoroidSpeeds.Add(randGen.Next(5, -10));
                meteoroidSize.Add(randGen.Next(5, 13));
            }
            else if (randValue < 40)
            {
                randValue = randGen.Next(0, this.Height - 25);

                Rectangle ball = new Rectangle(0, randValue, 0, 0);
                meteoroids.Add(ball);
                meteoroidColours.Add("white");
                meteoroidSpeeds.Add(randGen.Next(5, 10));
                meteoroidSize.Add(randGen.Next(5, 13));
            }
            else if (randValue < 40)
            {
                randValue = randGen.Next(0, this.Height - 25);

                Rectangle ball = new Rectangle(this.Width - 8, randValue, 0, 0);
                meteoroids.Add(ball);
                meteoroidColours.Add("white");
                meteoroidSpeeds.Add(randGen.Next(-10, -5));
                meteoroidSize.Add(randGen.Next(5, 13));
            }

            //Remove when block travels off screen

            for (int i = 0; i < meteoroids.Count; i++)
            {
                if (meteoroids[i].X > this.Width - 8 || meteoroids[i].X < 0)
                {
                    meteoroids.RemoveAt(i);
                    meteoroidColours.RemoveAt(i);
                    meteoroidSpeeds.RemoveAt(i);
                    meteoroidSize.RemoveAt(i);
                }
            }

            //Check if player 1 and player 2 interact with meteoroids
            for (int i = 0; i < meteoroids.Count; i++)
            {
                if (player1.IntersectsWith(meteoroids[i]))
                {
                    player1.X = 600;
                    player1.Y = 439;

                    crash.Play();

                    meteoroids.RemoveAt(i);
                    meteoroidColours.RemoveAt(i);
                    meteoroidSpeeds.RemoveAt(i);
                    meteoroidSize.RemoveAt(i);
                }
                if (player2.IntersectsWith(meteoroids[i]))
                {
                    player2.X = 200;
                    player2.Y = 439;

                    crash.Play();

                    meteoroids.RemoveAt(i);
                    meteoroidColours.RemoveAt(i);
                    meteoroidSpeeds.RemoveAt(i);
                    meteoroidSize.RemoveAt(i);
                }
            }

            //Getting points

            if(player1.Y < 0)
            {
                player1Score++;
                scorelabel1.Text = $"{player1Score}";

                start.Play();

                player1.X = 600;
                player1.Y = 439;

            }

            if (player2.Y < 0)
            {
                player2Score++;
                scorelabel2.Text = $"{player2Score}";

                start.Play();

                player2.X = 200;
                player2.Y = 439;
            }
                

                if(time == 0 && player1Score > player2Score)
                {
                    start.Play();
                    winLabel.Text = "Player1 Wins";

                    gameTimer.Stop();
                }

               else if (time == 0 && player2Score > player1Score)
                {
                    start.Play();
                    winLabel.Text = "Player2 Wins";

                    gameTimer.Stop();
                }

                if (time == 0 && player1Score == player2Score)
                {
                    start.Play();
                    winLabel.Text = "TIE";

                    gameTimer.Stop();
                }

                



            
            Refresh();

        }
    }
    }

