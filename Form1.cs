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
            /*private TextBox txtBox = new TextBox();
            private Button btnAdd = new Button();
            private ListBox lstBox = new ListBox();
            private CheckBox chkBox = new CheckBox();
            private Label lblCount = new Label();*/
        }

        public List<string> players = new List<string>();
        
        public int startingTextX = 85;
        public int startingLabelX = 25;
        public int startingY = 65;
        
        public int difference = 33;

        public int playerCount = 0;
        //playerCount = 


        private void button1_Click(object sender, EventArgs e)
        {
            int playerSelect = 1;
            playerCount = Int32.Parse(textBox11.Text);

            for (var i = 0; i < playerCount + 1; i++)
            {
                if (i == 0)
                {
                    TextBox _txt = new TextBox();
                    _txt.Name = "textBox1" + (i +1);
                    _txt.Location = new System.Drawing.Point(startingTextX, startingY);
                    _txt.Text = "Enter player " + (i + 1) + "Name";
                    this.Controls.Add(_txt);

                    Label lbl = new Label();
                    lbl.Text = "Player" + (i +1);
                    lbl.Location = new System.Drawing.Point(startingLabelX, startingY); ;
                    this.Controls.Add(lbl);
                }

                else
                {
                    //find way to get position of previous textbox
                    //list of textboxes?
                    TextBox _txt = new TextBox();
                    int newY = (difference * i) + startingY;
                    _txt.Name = "textBox" + (i + 1);
                    _txt.Location = new System.Drawing.Point(startingTextX, newY);
                    _txt.Text = "Enter player " + (i + 1) + "Name";
                    this.Controls.Add(_txt);

                    Label lbl = new Label();
                    lbl.Text = "Player" + (i + 1);
                    lbl.Location = new System.Drawing.Point(startingLabelX, newY);
                    this.Controls.Add(lbl);


                }
            }

/*            while (playerSelect < 11)
            {
                switch (playerSelect)
                {
                    case 1:
                        if (textBox1 != null )
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

                        *//*//* case 10:
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
                             }//**//*


                }
                playerSelect++;
                //listBox1.Items.Add(playerCount);
            }*/



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            /*for (var i = 0; i < playerCount; i++)
            {
                if (i == 0) { 
                TextBox _txt = new TextBox();
                _txt.Name = "textBox0" + i;
                //_txt.Location = new System.Drawing.Point(10, 25 * count);
                _txt.Text = "helloo";
                this.Controls.Add(_txt);

                Label lbl = new Label();
                lbl.Text = "I am a label";
                this.Controls.Add(lbl);
                }

                else
                {
                    //find way to get position of previous textbox
                    //list of textboxes?
                    TextBox _txt = new TextBox();
                    int newY = 33 * i;
                    _txt.Name = "textBox0" + i;
                    _txt.Location = new System.Drawing.Point(10, newY);
                    _txt.Text = "hello";
                    this.Controls.Add(_txt);

                    Label lbl = new Label();
                    lbl.Text = "I am a label";
                    this.Controls.Add(lbl);


                }*/
        }

    }

    /*TextBox textbox = new TextBox();
    int count = this.Controls.OfType<TextBox>().ToList().Count;
    textbox.Location = new System.Drawing.Point(10, 25 * count);
    textbox.Size = new System.Drawing.Size(80, 20);
    textbox.Name = "txt_" + (count + 1);
    this.Controls.Add(textbox);

    //Create the dynamic Button to remove the TextBox.
    Button button = new Button();
    button.Location = new System.Drawing.Point(95, 25 * count);
    button.Size = new System.Drawing.Size(60, 20);
    button.Name = "btnDelete_" + (count + 1);
    button.Text = "Delete";
    button.Click += new System.EventHandler(this.button2_Click);
    this.Controls.Add(button);*/
}
//}
//}
