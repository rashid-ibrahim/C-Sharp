/** Name: Rashid "Lee" Ibrahim
 *   Date: April 28, 2014
 *   Application: Rock, Paper, Scissors game
 *   Purpose: Final project/ To create a clickable game of rock, paper, scissors **/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Form load event.
        private void Final_Load(object sender, EventArgs e)
        {
            //Creates a new instance of gametype form.
            LoadGameType GameType = new LoadGameType();
            //Shows the form.
            GameType.ShowDialog();
            //Hides this form.
            this.Visible = false;
            //Clears the results label on load.
            lblResults.Text = "";
            //Sets the random for the first round of the first game.
            CurrentRand = randChoice.Next(3);
            //Sets gamestate for initial round.
            GameState = 1;
        }
        
        //Variable to track human wins.
        int HumanWins = 0;
        //Variable to track computer wins
        int CompWins = 0;
        //Variable to track ties.
        int Ties = 0;
        //Integer for the computer's choice.
        Random randChoice = new Random();
        //Variable to hold current random number for computer.
        int CurrentRand = 0;
        //Variable to hold the @nd player or computer player.
        int ChoiceTwo = 0;
        //Variable to hold the choice of the user.
        int ChoiceOne = 0;
        //Variable to hold comp choice for displaying results.
        string CompChoice = "";
        //Variable to hold current click.
        int CurrentClick = 0;
        //Variable to hold game state.
        int GameState = 0;

        public static class Variables
        {
            public static int GameType;
        }

        //Event handler for the new game button.
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //Sets game state for this game.
            GameState = 1;
            //Resets the game variables back to default.
            HumanWins = 0;
            CompWins = 0;
            Ties = 0;
            ChoiceOne = 0;
            ChoiceTwo = 0;
            CompChoice = "";
            CurrentClick = 0;
            //Resets the results label
            lblResults.Text = "";
            //Generates a new random for the new game set.
            CurrentRand = randChoice.Next(3);
            //Resets the win loss ratio for the new game.
            lblRatio.Text = "Wins: " + HumanWins + " Losses: " + CompWins + " Ties: " + Ties;
            //Hides this form.
            this.Visible = false;
            //Statement to recheck game type.
            //Creates a new instance of gametype form.
            LoadGameType GameType = new LoadGameType();
            //Shows the form.
            GameType.ShowDialog();
            //Shows the form again.
            this.Visible = true;
        }



        //Event hadler for the play again button.
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //Checks to see if the game is single player or two player.
            if (Variables.GameType == 1)
                //Runs if the game is single player.
            {
                //Generates a new random for this round.
                CurrentRand = randChoice.Next(5) + 1;
                //Sets the computer choice.
                ChoiceTwo = CurrentRand;
            }
            //Runs if the game is two player.
            else if (Variables.GameType == 2)
            {
                //Clears user two's choice.
                ChoiceTwo = 0;
            }
            //Sets game state for this round.
            GameState = 1;
            //Clears the user choice.
            ChoiceOne = 0;
            //Resets the results label.
            lblResults.Text = "";
        }

        
        //Event for the click of rock.
        private void picRock_Click(object sender, EventArgs e)
        {
            //Sets user choice.
            CurrentClick = 1;

            if (ChoiceTwo != 0 || Variables.GameType == 1)
            {
                CurrentChoice(CurrentClick);
                ChoiceTwo = CurrentRand;
                Gameplay();
            }
            else if (ChoiceTwo == 0 || Variables.GameType == 2)
            {
                MessageBox.Show("Player Two's turn to choose!");

                lblResults.Text = "Now player two must choose";

            }
            //Test code.
            //MessageBox.Show("UserChoice: " + UserChoice);
        }

        //Event for the click of paper.
        private void picPaper_Click(object sender, EventArgs e)
        {
            //Sets user choice.
            CurrentClick = 2;
            //Runs method to determine the choice.
            CurrentChoice(CurrentClick);
        }

        //Event for the click of scissors.
        private void picScissors_Click(object sender, EventArgs e)
        {
            //Sets user choice.
            CurrentClick = 3;
            //Runs method to determine the choice.
            CurrentChoice(CurrentClick);
        }

        //Event for the click of lizard.
        private void picLizard_Click(object sender, EventArgs e)
        {
            //Sets the user choice.
            ChoiceOne = 4;
            //Runs the game play.
            Gameplay();
        }

        //Event for the click of spock.
        private void picSpock_Click(object sender, EventArgs e)
        {
            //Sets the user choice.
            ChoiceOne = 5;
            //Runs the game play.
            Gameplay();
        }

        //Handles choosing pictures.
        public void CurrentChoice(int _click)
        {
            if (ChoiceOne == 0)
            {
                ChoiceOne = _click;
            }
            else
            {
                ChoiceTwo = _click;
            }
        }

        //Handles game play.
        public void Gameplay()
        {
            //Checks the gamestate for this round.
            if (GameState != 0 && ChoiceOne != 0)
            {
                //Statement only runs during singleplayer games.
                if (Variables.GameType == 1)
                {
                    //Switch statement used to display which choice the computer made.
                    switch (CurrentRand)
                    {
                        //Runs if rock was chosen.
                        case 1:
                            CompChoice = "Rock";
                            break;
                        //Runs if paper was chosen.
                        case 2:
                            CompChoice = "Paper";
                            break;
                        //Runs if scissors was chosen.
                        case 3:
                            CompChoice = "Scissors";
                            break;
                        //Runs if lizard was chosen.
                        case 4:
                            CompChoice = "Lizard";
                            break;
                        //Runs if spock was chosen.
                        case 5:
                            CompChoice = "Spock";
                            break;
                    }
                }

                //Evaluates the win codditions.
                //This section runs if the user chose paper.
                if (ChoiceOne == 1)
                {
                    //Runs if the computer has scissors.
                    if (ChoiceTwo == 3)
                    {
                        //Runs if the user beats the computer.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //MessageBox displaying the results.
                        MessageBox.Show("Rock smashes scissors! Player Wins!");
                        //Adds to the player score.
                        HumanWins += 1;
                    }
                    //Runs if the computer has paper.
                    else if (ChoiceTwo == 2)
                    {
                        //Runs if the user loses
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //MessageBox displays if computer wins.
                        MessageBox.Show("Paper wraps rock. Computer win.");
                        //Adds to the computer score.
                        CompWins += 1;
                    }
                    //Runs if the computer chooses rock.
                    else if (ChoiceTwo == 1)
                    {
                        //Displays if the computer also chooses rock.
                        lblResults.Text = "The computer also chose: " + CompChoice;
                        //Displays when there is a tie.
                        MessageBox.Show("Oops there is no winner this round! Please play again.");
                        //Adds to the tie count.
                        Ties += 1;
                    }
                    //Runs if the computer chooses lizard.
                    else if (ChoiceTwo == 4)
                    {
                        //Changes the display of what the computer chose.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //Displays the results.
                        MessageBox.Show("Rock crushes lizard. Player wins!");
                        //Adds to the player win count.
                        HumanWins += 1;
                    }
                        //Runs if the computer chooses spock.
                    else if (ChoiceTwo == 5)
                    {
                        //Changes the display of what the computer chose.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //Displays the results.
                        MessageBox.Show("Spock vaporizes rock. Computer wins.");
                        //Updates the computer win count.
                        CompWins += 1;
                    }
                    //Modifies the game state so that the new game or play again buttons have to be clicked first.
                    GameState = 0;
                }
                //Runs if the user chooses paper.
                else if (ChoiceOne == 2)
                {
                    //Runs if the computer has scissors.
                    if (ChoiceTwo == 3)
                    {
                        //Runs if the computer beats the user.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //MessageBox displaying the results.
                        MessageBox.Show("Scissors cuts paper! Computer wins.");
                        //Adds to the computer score.
                        CompWins += 1;
                    }
                    //Runs if the computer has rock.
                    else if (ChoiceTwo == 1)
                    {
                        //Runs if the user wins.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //MessageBox displays if user wins.
                        MessageBox.Show("Paper wraps rock. Player wins!");
                        //Adds to the user score.
                        HumanWins += 1;
                    }
                    else if (ChoiceTwo == 2)
                    {
                        //Displays if the computer also chooses paper.
                        lblResults.Text = "The computer also chose: " + CompChoice;
                        //Displays when there is a tie.
                        MessageBox.Show("Oops there is no winner this round! Please play again.");
                        //Adds to the tie count.
                        Ties += 1;
                    }
                    //Runs if the computer chooses lizard.
                    else if (ChoiceTwo == 4)
                    {
                        //Displays the computer choice.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //Displays the results.
                        MessageBox.Show("Lizard eats paper. Computer wins.");
                        //Adds to the computer win count.
                        CompWins += 1;
                    }
                        //Runs if the computer chooses spock.
                    else if (ChoiceTwo == 5)
                    {
                        //Displays the computer choice.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //Displays the results.
                        MessageBox.Show("Paper disproves Spock. Player wins!");
                        //Adds to the player win count.
                        HumanWins += 1;
                    }
                    //Modifies the game state so that the new game or play again buttons have to be clicked first.
                    GameState = 0;
                }
                //Runs if the user chooses paper.
                else if (ChoiceOne == 3)
                {
                    //Runs if the computer has scissors.
                    if (ChoiceTwo == 2)
                    {
                        //Runs if the user beats the computer.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //MessageBox displaying the results.
                        MessageBox.Show("Scissors cuts paper! Player wins!");
                        //Adds to the user score.
                        HumanWins += 1;
                    }
                    //Runs if the computer has rock.
                    else if (ChoiceTwo == 1)
                    {
                        //Runs if the user loses
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //MessageBox displays if computer wins.
                        MessageBox.Show("Rock smashes scissors. Computer wins");
                        //Adds to the player score.
                        CompWins += 1;
                    }
                    else if (ChoiceTwo == 3)
                    {
                        //Displays if the computer also chooses scissors.
                        lblResults.Text = "The computer also chose: " + CompChoice;
                        //Displays when there is a tie.
                        MessageBox.Show("Oops there is no winner this round! Please play again.");
                        //Adds to the tie count.
                        Ties += 1;
                    }
                    //Runs if the computer chooses lizard.
                    else if (ChoiceTwo == 4)
                    {
                        //Displays the computer choice.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //Displays the results
                        MessageBox.Show("Scissors decapitates lizard. Player wins!");
                        //Adds to the player win count.
                        HumanWins += 1;
                    }
                    //Modifies the game state so that the new game or play again buttons have to be clicked first.
                    GameState = 0;
                }
                    //Runs if the player chooses lizard.
                else if (ChoiceOne == 4)
                {
                    //Runs if the computer has scissors.
                    if (ChoiceTwo == 2)
                    {
                        //Runs if the user beats the computer.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //MessageBox displaying the results.
                        MessageBox.Show("Liazard eats paper! Player wins!");
                        //Adds to the user score.
                        HumanWins += 1;
                    }
                    //Runs if the computer has rock.
                    else if (ChoiceTwo == 1)
                    {
                        //Runs if the user loses
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //MessageBox displays if computer wins.
                        MessageBox.Show("Rock crushes lizard. Computer wins");
                        //Adds to the computer score.
                        CompWins += 1;
                    }
                    //Runs if the computer has scissors.
                    else if (ChoiceTwo == 3)
                    {
                        //Displays the computer choice.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //Displays the results.
                        MessageBox.Show("Scissors decapitates lizard. Computer wins.");
                        //Adds to the computer score.
                        CompWins += 1;
                    }
                    //Runs if the computer chooses lizard.
                    else if (ChoiceTwo == 4)
                    {
                        //Displays the computer choice.
                        lblResults.Text = "The computer also chose: " + CompChoice;
                        //Displays the results.
                        MessageBox.Show("Oops there is now winner this round!");
                        //Adds to the tie count.
                        Ties += 1;
                    }
                    //Runs if the computer chooses spock.
                    else if (ChoiceTwo == 5)
                    {
                        //Displays the computer choice.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //Displays the results.
                        MessageBox.Show("Lizard poisons Spock. Player wins!");
                        //Adds to the player win count.
                        HumanWins += 1;
                    }
                    //Modifies the game state so that the new game or play again buttons have to be clicked first.
                    GameState = 0;
                }
                    //Runs if the player chooses Spock.
                else if (ChoiceOne == 5)
                {
                    //Runs if the computer has scissors.
                    if (ChoiceTwo == 2)
                    {
                        //Displays the computer choice.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //MessageBox displaying the results.
                        MessageBox.Show("Paper disproves Spock. Computer wins.");
                        //Adds to the computer score.
                        CompWins += 1;
                    }
                    //Runs if the computer has rock.
                    else if (ChoiceTwo == 1)
                    {
                        //Displays the computer choice.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //MessageBox displaying the results.
                        MessageBox.Show("Spock vaporizes rock. Player wins!");
                        //Adds to the player score.
                        HumanWins += 1;
                    }
                    //Runs if the computer has scissors.
                    else if (ChoiceTwo == 3)
                    {
                        //Displays the computer choice.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //Displays the results.
                        MessageBox.Show("Spock smashes scissors. Player wins!");
                        //Adds to the player score.
                        HumanWins += 1;
                    }
                    //Runs if the computer chooses lizard.
                    else if (ChoiceTwo == 4)
                    {
                        //Displays the computer choice.
                        lblResults.Text = "The computer chose: " + CompChoice;
                        //Displays the results.
                        MessageBox.Show("Lizard poisons Spock. Computer wins.");
                        //Adds to the computer count.
                        CompWins += 1;
                    }
                    //Runs if the computer chooses spock.
                    else if (ChoiceTwo == 5)
                    {
                        //Displays the computer choice.
                        lblResults.Text = "The computer also chose: " + CompChoice;
                        //Displays the results.
                        MessageBox.Show("Oops there is no winner this round.");
                        //Adds to the tie count.
                        Ties += 1;
                    }
                    //Modifies the game state so that the new game or play again buttons have to be clicked first.
                    GameState = 0;
                }
            } 
            else
                //If a new game or a continuation of this round has not been selected this message displays.
           {
                MessageBox.Show("You must either start a new game or a new round of this game before proceeding."); 
           }
           //Sets the win loss ratio for the current round.
           lblRatio.Text = "Wins: " + HumanWins + " Losses: " + CompWins + " Ties: " + Ties;
        }
        //Click event for the instructions button.
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //Creates a new instructions instance.
            Instructions Instructions = new Instructions();
            //Shows the instructions form.
            Instructions.ShowDialog();
        }

        //Event handler for the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the application.
            this.Close();
        }
    }
}