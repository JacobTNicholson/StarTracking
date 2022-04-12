using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartCalculator
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public List<string> players = new List<string>();
        public int playerCount = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            int playerSelect = 1;

            while (playerSelect < 11)
            {
                switch (playerSelect)
                {
                    case 1:
                        if (textBox1.Text != "")
                        {
                            players.Add(textBox1.Text);
                            playerCount++;
                            listBox1.Items.Add(players[playerSelect - 1]);
                            break;
                        }
                            
                        else
                        {
                            break;
                        }

                    case 2:
                        if (textBox2.Text != "")
                        {
                            players.Add(textBox2.Text);
                            playerCount++;
                            listBox1.Items.Add(players[playerSelect - 1]);
                            break;
                        }

                        else
                        {
                            break;
                        }

                    case 3:
                        if (textBox3.Text != "")
                        {
                            players.Add(textBox3.Text);
                            playerCount++;
                            listBox1.Items.Add(players[playerSelect - 1]);
                            break;
                        }

                        else
                        {
                            break;
                        }

                    case 4:
                        if (textBox4.Text != "")
                        {
                            players.Add(textBox4.Text);
                            playerCount++;
                            listBox1.Items.Add(players[playerSelect - 1]);
                            break;
                        }

                        else
                        {
                            break;
                        }

                    case 5:
                        if (textBox5.Text != "")
                        {
                            players.Add(textBox5.Text);
                            playerCount++;
                            listBox1.Items.Add(players[playerSelect - 1]);
                            break;
                        }

                        else
                        {
                            break;
                        }

                    case 6:
                        if (textBox6.Text != "")
                        {
                            players.Add(textBox6.Text);
                            playerCount++;
                            listBox1.Items.Add(players[playerSelect - 1]);
                            break;
                        }

                        else
                        {
                            break;
                        }
                    case 7:
                        if (textBox7.Text != "")
                        {
                            players.Add(textBox7.Text);
                            playerCount++;
                            listBox1.Items.Add(players[playerSelect - 1]);
                            break;
                        }

                        else
                        {
                            break;
                        }

                    case 8:
                        if (textBox8.Text != "")
                        {
                            players.Add(textBox8.Text);
                            playerCount++;
                            listBox1.Items.Add(players[playerSelect - 1]);
                            break;
                        }

                        else
                        {
                            break;
                        }

                    case 9:
                        if (textBox9.Text != "")
                        {
                            players.Add(textBox9.Text);
                            playerCount++;
                            listBox1.Items.Add(players[playerSelect - 1]);
                            break;
                        }

                        else
                        {
                            break;
                        }

                    case 10:
                        if (textBox10.Text != "")
                        {
                            players.Add(textBox10.Text);
                            playerCount++;
                            listBox1.Items.Add(players[playerSelect - 1]);
                            break;
                        }

                        else
                        {
                            break;
                        }


                }
                playerSelect++;
                //listBox1.Items.Add(playerCount);
            }

           

        }
    }
}
