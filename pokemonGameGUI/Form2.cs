using pokemonGameGUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemonGameGUI
{
    public partial class Form2 : Form
    {
        Player playersFighter = new Player(); // The objects for the rival and player class have been defined to be used throughout the code.
        public Form2()
        {
            InitializeComponent(); // This line of code initialises the form and makes it visible to the user.
        }

        public static string Choice = ""; // The variable Choice is made to be used to define what character has been chosen and is used in the battle form to set the values of the images and move buttons.

        private void btnChrisRock_Click(object sender, EventArgs e)
        {
            Choice = "Chris Rock";
            playersFighter.setValues("Chris Rock", 100, "Offensive Punchline", 40, "Bald Deflect", 50);
            pbSelect.BackgroundImage = Resources.ChrisRock;
            rtbSelect.Text = playersFighter.getName() + "\nHealth: " + playersFighter.getHealth() + "\nAttack 1: " + playersFighter.getAttack1() + "\nAttack 1 Damage: " + playersFighter.getAttack1Damage() + "\nAttack 2: " + playersFighter.getAttack2() + "\nAttack 2 Damage: " + playersFighter.getAttack2Damage();
        }

        private void btnWillSmith_Click(object sender, EventArgs e)
        {
            Choice = "Will Smith";
            playersFighter.setValues("Will Smith", 100, "Left, Right, Goodnight", 30, "Defend Wife", 70);
            pbSelect.BackgroundImage = Resources.WillSmith;
            rtbSelect.Text = playersFighter.getName() + "\nHealth: " + playersFighter.getHealth() + "\nAttack 1: " + playersFighter.getAttack1() + "\nAttack 1 Damage: " + playersFighter.getAttack1Damage() + "\nAttack 2: " + playersFighter.getAttack2() + "\nAttack 2 Damage: " + playersFighter.getAttack2Damage();

        }

        private void btnTheRock_Click(object sender, EventArgs e)
        {
            Choice = "The Rock";
            playersFighter.setValues("The Rock", 100, "He Gon' Rumble", 40, "Take Yo Face Off", 60);
            pbSelect.BackgroundImage = Resources.TheRock;
            rtbSelect.Text = playersFighter.getName() + "\nHealth: " + playersFighter.getHealth() + "\nAttack 1: " + playersFighter.getAttack1() + "\nAttack 1 Damage: " + playersFighter.getAttack1Damage() + "\nAttack 2: " + playersFighter.getAttack2() + "\nAttack 2 Damage: " + playersFighter.getAttack2Damage();

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (Choice != "")
            {
                this.Hide(); // This line of code hides the form.
                Form1 f2 = new Form1(); // This line of code then creates the battle form to show the battle interface.

                f2.ShowDialog(); // This code presents the interface to the user.
            }
        }
    }
}
