using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDogRace
{
    public partial class GamePanel : Form
    {
        //Initialize array of guys
        Guy[] guys = new Guy[3];

        //intialize array of greyhounds
        GreyHound[] obj = new GreyHound[4];
        public GamePanel()
        {
            InitializeComponent();
            guys[0] = new Guy() { Money = 50, Name = "Joe", MyLabel = lblJoe, MyRadioButton = radioJoe };
            guys[1] = new Guy() { Money = 50, Name = "Bob", MyLabel = lblBob, MyRadioButton = radioBob };
            guys[2] = new Guy() { Money = 50, Name = "Al", MyLabel = lblAl, MyRadioButton = radioAl };
            foreach (Guy guy in guys)
                guy.PlaceBet(0, 0);

            //set the default bet name to Joe
            lblName.Text = guys[0].Name;

            obj[0] = new GreyHound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                trackLength = racetrackPictureBox.Width - pictureBox1.Width,
                Randomizer = new Random()
            };

            obj[1] = new GreyHound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                trackLength = racetrackPictureBox.Width - pictureBox2.Width,
                Randomizer = obj[0].Randomizer
            };

            obj[2] = new GreyHound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                trackLength = racetrackPictureBox.Width - pictureBox3.Width,
                Randomizer = obj[0].Randomizer
            };

            obj[3] = new GreyHound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                trackLength = racetrackPictureBox.Width - pictureBox4.Width,
                Randomizer = obj[0].Randomizer
            };

            updateForm();
        }

        

        public void updateForm()
        {
            radioJoe.Text = guys[0].Name + " has $" + guys[0].Money;
            radioBob.Text = guys[1].Name + " has $" + guys[1].Money;
            radioAl.Text = guys[2].Name + " has $" + guys[2].Money;
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            try
            {
                //reset dog positions
                foreach (GreyHound g in obj)
                {
                    g.MyPictureBox.Left = g.StartingPosition;
                }

                //start timer for race

                timer1.Enabled = true;

               //When dogs run the race, Bet and Race button will disable
                btnRace.Enabled = false;
                btnBets.Enabled = false;
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        private void btnBets_Click(object sender, EventArgs e)
        {
            try
            {
               
                // Bets button working here
                int guy;
                if (radioJoe.Checked)
                {
                    guy = 0;
                }
                else if (radioBob.Checked)
                {
                    guy = 1;
                }
                else
                {
                    guy = 2;
                }

                /*place the bet for the selected amount on the selected dog 
                 by the selected guy */
                guys[guy].PlaceBet((int)numBets.Value, (int)numDog.Value - 1);

                Console.WriteLine(guys[guy].Name + " bets $" + guys[guy].Bet.Amt + " on dog " + (guys[guy].Bet.Dog + 1));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioJoe_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = guys[0].Name; //set the name of guy on label for Joe
        }

        private void radioBob_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = guys[1].Name; //set the name of guy on label for Bob
        }

        private void radioAl_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = guys[2].Name; //set the name of guy on label for Al
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int winner;
            //while (!GreyhoundArray[0].Run(racetrackPictureBox) && !GreyhoundArray[1].Run(racetrackPictureBox) && !GreyhoundArray[2].Run(racetrackPictureBox) && !GreyhoundArray[3].Run(racetrackPictureBox)) { }
            //timer1.Enabled = false;
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].Run(racetrackPictureBox))
                {
                    winner = i;
                    timer1.Enabled = false;
                    MessageBox.Show("Dog #" + (winner + 1) + " Wins!");
                    for (int j = 0; j < guys.Length; j++)
                    {
                        if (guys[j].Bet.PayOut(winner) != 0)
                            guys[j].Money += guys[j].Bet.PayOut(winner);
                        guys[j].MyRadioButton.Text = guys[j].Name + " has $" + guys[j].Money;
                        if (guys[0].Money < 5)
                        {
                            lblJoe.Text = "BUSTED!";
                            guys[0].MyRadioButton.Enabled = false;
                        }
                        else if (guys[1].Money < 5)
                        {
                            lblBob.Text = "BUSTED!";
                            guys[1].MyRadioButton.Enabled = false;

                        }
                        else if (guys[2].Money < 5)
                        {
                            lblAl.Text = "BUSTED!";
                            guys[2].MyRadioButton.Enabled = false;
                        }
                        else if (guys[0].Money < 5 && guys[1].Money < 5 && guys[2].Money < 5)
                        {
                            lblAl.Text = "BUSTED!"; lblBob.Text = "BUSTED!"; lblJoe.Text = "BUSTED!";
                            guys[0].MyRadioButton.Enabled = false;
                            guys[1].MyRadioButton.Enabled = false;
                            guys[2].MyRadioButton.Enabled = false;
                            MessageBox.Show("GAME OVER");

                            // buttons disabled here
                            btnBets.Enabled = false;
                            btnRace.Enabled = false;
                        }
                    }

                    // buttons enabled again
                    btnBets.Enabled = true;
                    btnRace.Enabled = true;

                   
                    break;

                }
            }
        }

        
    }
}
