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

        public int active = 0;

        public int startingTextX = 85;
        public int startingLabelX = 25;
        public int startingY = 65;

        public int difference = 33;

        public int playerCount = 0;
        public int playerSelect = 1;
        //playerCount = 
        public void addPlayers(int playerCount)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= players.Count; i++){

                
                    listBox1.Items.Add(players[i - 1]);
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerSelect = 0;

            while (playerSelect <= playerCount)
            {
                switch (playerSelect)
                {
                    case 1:
                        if (textBox1.Text != "")
                        {
                            players.Add(textBox1.Text);
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
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
                           // playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
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
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
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
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
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
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
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
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
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
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
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
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
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
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
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
                                 //playerCount++;
                                 //listBox1.Items.Add(players[playerSelect - 1]);
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
            addPlayers(playerCount);

           

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

            playerSelect = 0;
            //if (comboBox1.SelectedIndex != 0)
            //{
                playerCount = Int32.Parse(comboBox1.Text);
           // }

            while (playerSelect <= 10)
            {
                switch (playerSelect)
                {
                    case 1:

                        if (textBox1.Visible == false && 1 <= playerCount)
                        {
                            //players.Add(textBox1.Text);
                            //playerSelect++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
                            textBox1.Visible = true;
                            label1.Visible = true;
                            active++;
                            break;
                        }

                        else if (textBox1.Visible == true && 1 > playerCount)
                        {

                            textBox1.Visible = false;
                            label1.Visible = false;
                            active--;
                            break;

                        }

                        else
                            break;

                    case 2:
                        if (textBox2.Visible == false && 2 <= playerCount)
                        {
                            //players.Add(textBox2.Text);
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
                            textBox2.Visible = true;
                            label2.Visible = true;
                            active++;
                            break;
                        }

                        else if (textBox2.Visible == true && 2 > playerCount)
                        {
                            textBox2.Text = "";
                            textBox2.Visible = false;
                            label2.Visible = false;
                            active--;
                            //players.Add(textBox6.Text);
                            if (playerSelect - 1 < players.Count)
                            {
                                players.Remove(players[1]);

                            }
                            break;

                        }

                        else
                            break;

                    case 3:
                        if (textBox3.Visible == false && 3 <= playerCount)
                        {
                            //players.Add(textBox2.Text);
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
                            textBox3.Visible = true;
                            label3.Visible = true;
                            active++;
                            break;
                        }

                        else if (textBox3.Visible == true && 3 > playerCount)
                        {
                            textBox3.Text = "";
                            textBox3.Visible = false;
                            label3.Visible = false;
                            active--;
                            //players.Remove(players[playerSelect - 1]);

                            if (playerSelect - 1 < players.Count)
                            {
                                players.Remove(players[1]);

                            }
                            break;
                        }

                        else
                            break;

                    case 4:
                        if (textBox4.Visible == false && 4 <= playerCount)
                        {
                            //players.Add(textBox2.Text);
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
                            textBox4.Visible = true;
                            label4.Visible = true;
                            active++;                           
                            break;
                        }

                        else if (textBox4.Visible == true && 4 > playerCount)
                        {
                            textBox4.Text = "";
                            textBox4.Visible = false;
                            label4.Visible = false;
                            active--;
                            if (playerSelect - 1 < players.Count)
                            {
                                players.Remove(players[1]);

                            }
                            
                            break;
                        }

                        else
                            break;

                    case 5:
                        if (textBox5.Visible == false && 5 <= playerCount)
                        {
                            //players.Add(textBox2.Text);
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
                            textBox5.Visible = true;
                            label5.Visible = true;
                            active++;
                            break;
                        }

                        else if (textBox5.Visible == true && 5 > playerCount)
                        {
                            textBox5.Text = "";
                            textBox5.Visible = false;
                            label5.Visible = false;
                            active--;
                            if (playerSelect - 1 < players.Count)
                            {
                                players.Remove(players[1]);

                            }
                            break;
                        }

                        else
                            break;

                    case 6:
                        if (textBox6.Visible == false && 6 <= playerCount)
                        {
                            //players.Add(textBox2.Text);
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
                            textBox6.Visible = true;
                            label6.Visible = true;
                            active++;
                            break;
                        }

                        else if (textBox6.Visible == true && 6 > playerCount)
                        {
                            textBox6.Text = "";
                            textBox6.Visible = false;
                            label6.Visible = false;
                            active--;
                            if (playerSelect - 1 < players.Count)
                            {
                                players.Remove(players[1]);

                            }
                            break;
                        }

                        else
                            break;

                    case 7:
                        if (textBox7.Visible == false && 7 <= playerCount)
                        {
                            //players.Add(textBox2.Text);
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
                            textBox7.Visible = true;
                            label7.Visible = true;
                            active++;
                            break;
                        }

                        else if (textBox7.Visible == true && 7 > playerCount)
                        {
                            textBox7.Text = "";
                            textBox7.Visible = false;
                            label7.Visible = false;
                            active--;
                            if (playerSelect - 1 < players.Count)
                            {
                                players.Remove(players[1]);

                            }
                            break;
                        }

                        else
                            break;

                    case 8:
                        if (textBox8.Visible == false && 8 <= playerCount)
                        {
                            //players.Add(textBox2.Text);
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
                            textBox8.Visible = true;
                            label8.Visible = true;
                            active++;
                            break;
                        }

                        else if (textBox8.Visible == true && 8 > playerCount)
                        {
                            textBox8.Text = "";
                            textBox8.Visible = false;
                            label8.Visible = false;
                            active--;
                            if (playerSelect - 1 < players.Count)
                            {
                                players.Remove(players[1]);

                            }
                            break;
                        }

                        else
                            break;

                    case 9:
                        if (textBox9.Visible == false && 9 <= playerCount)
                        {
                            //players.Add(textBox2.Text);
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
                            textBox9.Visible = true;
                            label9.Visible = true;
                            active++;
                            break;
                        }

                        else if (textBox9.Visible == true && 9 > playerCount)
                        {
                            textBox9.Text = "";
                            textBox9.Visible = false;
                            label9.Visible = false;
                            active--;
                            if (playerSelect - 1 < players.Count)
                            {
                                players.Remove(players[1]);

                            }
                            break;
                        }

                        else
                            break;

                    case 10:
                        if (textBox10.Visible == false && 10 == playerCount)
                        {
                            //players.Add(textBox2.Text);
                            //playerCount++;
                            //listBox1.Items.Add(players[playerSelect - 1]);
                            textBox10.Visible = true;
                            label10.Visible = true;
                            active++;
                            break;
                        }

                        else if (textBox10.Visible == true && 10 > playerCount)
                        {
                            textBox10.Text = "";
                            textBox10.Visible = false;
                            label10.Visible = false;
                            active--;
                            if (playerSelect - 1 < players.Count)
                            {
                                players.Remove(players[1]);

                            }
                            break;
                        }

                        else
                            break;


                }
                playerSelect++;
                //listBox1.Items.Add(playerCount);
            }

            playerSelect = 0;
        }

        private void groupBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {
            

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
