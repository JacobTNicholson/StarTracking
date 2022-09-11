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
        public int playerSelect = 1;
        //playerCount = 


        private void button1_Click(object sender, EventArgs e)
        {

            //change code to have drop down for players and enable corresponding labels/textBoxes
            //int playerSelect = 1;
            //playerCount = Int32.Parse(textBox11.Text);

            /*for (var i = 0; i < playerCount + 1; i++)
            {*/
                /*string test = "label " + i;
                label1.Visible = true;
                textBox1.Visible = true;*/
                /*{
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
                }*/

                            while (playerSelect <= (playerCount +1))
                            {
                                switch (playerSelect)
                                {
                                    case 1:
                                        if (textBox1.Visible==false)
                                        {
                                            //players.Add(textBox1.Text);
                                            //playerSelect++;
                                            //listBox1.Items.Add(players[playerSelect - 1]);
                                            textBox1.Visible = true;
                                            label1.Visible=true;
                                            break;
                                        }

                                        else
                                        {
                                            break;
                                        }

                                    case 2:
                                        if (textBox2.Visible == false)
                                        {
                                            //players.Add(textBox2.Text);
                                            //playerCount++;
                                            //listBox1.Items.Add(players[playerSelect - 1]);
                                            textBox2.Visible = true;
                                            label2.Visible = true;
                                            break;
                                        }

                                        else
                                        {
                                            break;
                                        }

                                    case 3:
                                        if (textBox3.Visible == false)
                                        {
                                            //players.Add(textBox2.Text);
                                            //playerCount++;
                                            //listBox1.Items.Add(players[playerSelect - 1]);
                                            textBox3.Visible = true;
                                            label3.Visible = true;
                                             break;
                        }

                                        else
                                        {
                                            break;
                                        }

                                    case 4:
                                        if (textBox4.Visible == false)
                                        {
                                            //players.Add(textBox2.Text);
                                             //playerCount++;
                                             //listBox1.Items.Add(players[playerSelect - 1]);
                                             textBox4.Visible = true;
                                                label4.Visible = true;
                                                 break;
                        }

                                        else
                                        {
                                            break;
                                        }

                                    case 5:
                                        if (textBox5.Visible == false)
                                        {
                                            //players.Add(textBox2.Text);
                                            //playerCount++;
                                            //listBox1.Items.Add(players[playerSelect - 1]);
                                             textBox5.Visible = true;
                                            label5.Visible = true;
                                            break;
                        }

                                        else
                                        {
                                            break;
                                        }

                                    case 6:
                                        if (textBox6.Visible == false)
                                        {
                                            //players.Add(textBox2.Text);
                                             //playerCount++;
                                            //listBox1.Items.Add(players[playerSelect - 1]);
                                            textBox6.Visible = true;
                                            label6.Visible = true;
                                            break;
                        }

                                        else
                                        {
                                            break;
                                        }
                                    case 7:
                                        if (textBox7.Visible == false)
                                        {
                                            //players.Add(textBox2.Text);
                                            //playerCount++;
                                            //listBox1.Items.Add(players[playerSelect - 1]);
                                            textBox7.Visible = true;
                                            label7.Visible = true;
                                            break;
                        }

                                        else
                                        {
                                            break;
                                        }

                                    case 8:
                                        if (textBox8.Visible == false)
                                        {
                                            //players.Add(textBox2.Text);
                                            //playerCount++;
                                            //listBox1.Items.Add(players[playerSelect - 1]);
                                            textBox8.Visible = true;
                                            label8.Visible = true;
                                            break;
                        }

                                        else
                                        {
                                            break;
                                        }

                                    case 9:
                                        if (textBox9.Visible == false)
                                        {
                                            //players.Add(textBox2.Text);
                                            //playerCount++;
                                            //listBox1.Items.Add(players[playerSelect - 1]);
                                            textBox9.Visible = true;
                                            label9.Visible = true;
                                            break;
                        }

                                        else
                                        {
                                            break;
                                        }

                                        case 10:
                                             if (textBox10.Visible == false)
                                             {
                                                //players.Add(textBox2.Text);
                                                //playerCount++;
                                                //listBox1.Items.Add(players[playerSelect - 1]);
                                                textBox10.Visible = true;
                                                label10.Visible = true;
                                                break;
                        }

                                             else
                                             {
                                                textBox10.Visible = false;
                                                label10.Visible = false;
                                                break;
                                             }


                                }
                                playerSelect++;
                                //listBox1.Items.Add(playerCount);
                            }

            playerSelect = 0;



           // }

            /*        private void button2_Click(object sender, EventArgs e)
                    {*/


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
            // }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (comboBox1.SelectedIndex != 0)
            {
                playerCount = (Int32.Parse(comboBox1.SelectedValueChanged));
            }*/

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                playerCount = Int32.Parse(comboBox1.Text);
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
}
//}
//}
