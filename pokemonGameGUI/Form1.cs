using pokemonGameGUI.Properties;
using System.Runtime.CompilerServices;

namespace pokemonGameGUI
{
    public partial class Form1 : Form
    {
        // This is where the variables are defined so that they can be used throughout the code within the form.
        int roundCount = 0;
        int chosenAttack = 0;
        int rivalsAttack;
        bool gameOver = false;
        bool buttonEnabled = true;
        Player playersFighter = new Player(); // The objects for the rival and player class have been defined to be used throughout the code.
        Rival rivalsFighter = new Rival();
        public Form1()
        {
            InitializeComponent(); // This line of code initialises the form to be presented to the user when called.

            switch (Form2.Choice) // A switch case is used here to check the choice made in the first interface for the character selection.
            { // Depending on the choice made in the first interface.
                case "Will Smith":
                    playersFighter.setValues("Will Smith", 100, "Left, Right, Goodnight", 30, "Defend Wife", 70);
                    rivalsFighter.setValues("The Rock", 100, "He Gon' Rumble", 40, "Take Yo Face Off", 60, 70); // Both the player and rivals values are set here using setValues.

                    btnMove1.Text = "Left, Right, Goodnight"; // Here the move buttons text is changed to match what moves the player can carry out.
                    btnMove2.Text = "Defend Wife";
                    pbPlayer.BackgroundImage = Resources.WillSmith; // The images of the player and the rival are also updated, grabbing the images from the resources.
                    pbRival.BackgroundImage = Resources.TheRock;
                    break;

                case "Chris Rock":
                    playersFighter.setValues("Chris Rock", 100, "Offensive Punchline", 40, "Bald Deflect", 50);
                    rivalsFighter.setValues("Will Smith", 100, "Left, Right, Goodnight", 30, "Defend Wife", 70, 80);

                    btnMove1.Text = "Offensive Punchline";
                    btnMove2.Text = "Bald Deflect";
                    pbPlayer.BackgroundImage = Resources.ChrisRock;
                    pbRival.BackgroundImage = Resources.WillSmith;
                    break;

                case "The Rock":
                    playersFighter.setValues("The Rock", 100, "He Gon' Rumble", 40, "Take Yo Face Off", 60);
                    rivalsFighter.setValues("Chris Rock", 100, "Offensive Punchline", 40, "Bald Deflect", 50, 60);

                    btnMove1.Text = "He Gon' Rumble";
                    btnMove2.Text = "Take Yo Face Off";
                    pbPlayer.BackgroundImage = Resources.TheRock;
                    pbRival.BackgroundImage = Resources.ChrisRock;
                    break;

                default:
                    this.Close();
                    break;
            }
            
            rtbBattle.Text = "FIGHT!\nChoose your attack!\n1. " + playersFighter.getAttack1() + "\n2. " + playersFighter.getAttack2(); // The fight has begun here and the user is informed, showing their choice of attack aswell in the text box.

        }

        private void btnTheRock_Click(object sender, EventArgs e)
        {

        }
        private void btnWillSmith_Click(object sender, EventArgs e)
        {

        }

        private void btnChrisRock_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbRival_Click(object sender, EventArgs e)
        {

        }

        private void btnMove1_Click(object sender, EventArgs e)
        {
            if (buttonEnabled == true) // This if statement checks if the button is enabled and can be pressed, this used to ensure they are not used when the game is over.
            {
                rtbBattle.Text = "---------Turn " + roundCount + "------------ -\n\nYour Move:\n" + playersFighter.getName() + " uses.. " + playersFighter.getAttack1() + "!\n\n";
                rivalsFighter.setHealth(playersFighter.Attack(1));
                if (rivalsFighter.getHealth() < 0)
                {
                    progressBarRival.Value = 0; // The progress bar is amended here to reach 0 if the rivals health goes below 0, as an error is returned otherwise.
                }
                else
                {
                    progressBarRival.Value = rivalsFighter.getHealth(); // If the health has not reached zero then the progress bar is matched with the players health.
                }
                lblRivalsHealth.Text = "Rivals Health: " + rivalsFighter.getHealth().ToString();
                if (rivalsFighter.getHealth() < 0) // The code checks if the players health is below 0 and outputs to the player they have won the game.
                {
                    rtbBattle.Text = "Congratulations! You beat " + rivalsFighter.getName() + ", pat yourself on the back!";
                    gameOver = true; // The game is set to over.
                }
                else
                {
                    chosenAttack = 0;
                    roundCount++; // Here the roundCount is increased by one as to immitate the round starting.
                    Random rnd = new Random();
                    rivalsAttack = rnd.Next(1, 3); // A random number is generated here to choose what attack the rival carries out.
                    switch (rivalsAttack)
                    {
                        case 1:
                            rtbBattle.Text = "---------Turn " + roundCount + "------------ -\n\nYour Move:\n" + playersFighter.getName() + " uses.. " + playersFighter.getAttack1() + "!\n\n" + rivalsFighter.getName() + " uses.. " + rivalsFighter.getAttack1() + "!\n\n";
                            playersFighter.setHealth(rivalsFighter.Attack(1)); // Here the health is deducted after using the attack function to return the attacks damage.
                            break;
                        case 2:
                            rtbBattle.Text = "---------Turn " + roundCount + "------------ -\n\nYour Move:\n" + playersFighter.getName() + " uses.. " + playersFighter.getAttack1() + "!\n\n" + rivalsFighter.getName() + " uses.. " + rivalsFighter.getAttack2() + "!\n\n";
                            playersFighter.setHealth(rivalsFighter.Attack("two"));
                            break;
                        case 3:
                            rtbBattle.Text = "---------Turn " + roundCount + "------------ -\n\nYour Move:\n" + playersFighter.getName() + " uses.. " + playersFighter.getAttack1() + "!\n\n" + rivalsFighter.getName() + " uses.. " + rivalsFighter.getAttack2() + "!\n\n";
                            playersFighter.setHealth(rivalsFighter.specialAttack());
                            break;
                    }
                    if (playersFighter.getHealth() < 0)
                    {
                        progressBarPlayer.Value = 0; // The progress bar is amended here to reach 0 if the rivals health goes below 0, as an error is returned otherwise.
                    }
                    else
                    {
                        progressBarPlayer.Value = playersFighter.getHealth(); // If the health has not reached zero then the progress bar is matched with the players health.
                    }
                    lblPlayerHealth.Text = "Players Health: " + playersFighter.getHealth().ToString();
                    if (playersFighter.getHealth() < 0)
                    {
                        gameOver = true;
                        rtbBattle.Text = "Looks like you were beaten by " + rivalsFighter.getName() + ", better luck next time!";
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) // This timer is used to constantly check certain if statements to make the game function.
        {
            if (gameOver == true) // For example, if the game is over then the buttons are set to disbled and cannot be used.
            {
                buttonEnabled = false;
            }

            if (buttonEnabled == false) // Another example being the button colours which are set to gray when the buttons are disabled.
            {
                btnMove1.BackColor = Color.Gray;
                btnMove2.BackColor = Color.Gray;
            }
        }

        private void btnMove2_Click(object sender, EventArgs e) // The same code is used for the second move button here, as the same code is required, only to be changed to the secondaryAttack.
        {
            if (buttonEnabled == true)
            {
                rtbBattle.Text = "---------Turn " + roundCount + "------------ -\n\nYour Move:\n" + playersFighter.getName() + " uses.. " + playersFighter.getAttack2() + "!\n\n";
                rivalsFighter.setHealth(playersFighter.Attack("two"));
                if (rivalsFighter.getHealth() < 0)
                {
                    progressBarRival.Value = 0;
                }
                else
                {
                    progressBarRival.Value = rivalsFighter.getHealth();
                }
                lblRivalsHealth.Text = "Rivals Health: " + rivalsFighter.getHealth().ToString();
                if (rivalsFighter.getHealth() < 0)
                {
                    rtbBattle.Text = "Congratulations! You beat " + rivalsFighter.getName() + ", pat yourself on the back!";
                    gameOver = true;
                }
                else
                {
                    chosenAttack = 0;
                    roundCount++;
                    Random rnd = new Random();
                    rivalsAttack = rnd.Next(1, 3);
                    switch (rivalsAttack)
                    {
                        case 1:
                            rtbBattle.Text = "---------Turn " + roundCount + "------------ -\n\nYour Move:\n" + playersFighter.getName() + " uses.. " + playersFighter.getAttack2() + "!\n\n" + rivalsFighter.getName() + " uses.. " + rivalsFighter.getAttack1() + "!\n\n";
                            playersFighter.setHealth(rivalsFighter.Attack(1));
                            break;
                        case 2:
                            rtbBattle.Text = "---------Turn " + roundCount + "------------ -\n\nYour Move:\n" + playersFighter.getName() + " uses.. " + playersFighter.getAttack2() + "!\n\n" + rivalsFighter.getName() + " uses.. " + rivalsFighter.getAttack2() + "!\n\n";
                            playersFighter.setHealth(rivalsFighter.Attack("two"));
                            break;
                        case 3:
                            rtbBattle.Text = "---------Turn " + roundCount + "------------ -\n\nYour Move:\n" + playersFighter.getName() + " uses.. " + playersFighter.getAttack2() + "!\n\n" + rivalsFighter.getName() + " uses.. " + rivalsFighter.getAttack2() + "!\n\n";
                            playersFighter.setHealth(rivalsFighter.specialAttack());
                            break;
                    }
                    if (playersFighter.getHealth() < 0)
                    {
                        progressBarPlayer.Value = 0;
                    }
                    else
                    {
                        progressBarPlayer.Value = playersFighter.getHealth();
                    }
                    lblPlayerHealth.Text = "Players Health: " + playersFighter.getHealth().ToString();
                    if (playersFighter.getHealth() < 0)
                    {
                        gameOver = true;
                        rtbBattle.Text = "Looks like you were beaten by " + rivalsFighter.getName() + ", better luck next time!";
                    }
                }
            }
        }
    }
}