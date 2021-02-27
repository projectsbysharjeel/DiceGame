using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Item: Assignment 01 (INFT2012)
// Group members: Sharjeel Sohail (c3316130) & Fadzayi Manyenya (c3264876)
// Hand-in date: 31st May 2020
// Project: Creating a Dice Game

namespace Assessment01
{
    public partial class GamePage : Form
    {
        // Declaring few variables here so that they can be used throughout the code 
        // Declares the graphics for all 6 dice
        private Graphics graDice1;
        private Graphics graDice2;
        private Graphics graDice3;
        private Graphics graDice4;
        private Graphics graDice5;
        private Graphics graDice6;
       
        Random randDie = new Random(); // Declare Random dice and instantiate
        Random randTurn = new Random(); // Declare Random Player turn to switch between
        Random randNoOfDice = new Random(); // Declare Random no of dice for the computer 

        int iPlayerTurns;   // Changing players font from regular to bold
        int[] iDiceNum = new int[7];  // Array to save each dice value when rolling 
        int iGameLimit;     // No. of games limit as agreed
        int iPlay1Score = 0, iPlay2Score = 0; // Player scores 

        List <int> lisScoreP1 = new List <int>();   // List for Scores of Player 1
        List <int> lisScoreP2 = new List <int> ();  // List for Scores of Player 2
        int iRollingDice; // just so we can pick a random value for the computer
        int gameMode; // Game mode (1 on 1 OR Play with Computer)
        int iGameCounter1 = 0, iGameCounter2 = 0; // Counter for the Game Statistics

        //_____________________________________________________________________________________________________________________________//

        public GamePage()
        {
            // This is what happens if we instantiate an InputBox using new InputBox() with no arguments
            InitializeComponent();
            // end of default constructor
        }

        public GamePage(string sPlayer1, int iGoal, int iNoOfGames)
        {
            // This is what happens if we instantiate SixOfOne using THREE arguments (Player 1 name, Agreed Goal, And no. of games)
            // We wrote this constructor, but we still have to include InitializeComponent();
            InitializeComponent();

            // Recalling the Player turn function with Random value
            // So its going to pick player 1 and player 2 randomly as the game starts
            iPlayerTurns = 1;
            nameFont(iPlayerTurns);

            // Displaying information received form arguments 
            lblPlayerName1.Text = sPlayer1; // Player 1 name
            lblPlayerName2.Text = "Computer"; // Computer as in computers name
            lblAgreedGoal.Text = Convert.ToString(iGoal); // Agreed goal provided
            iGameLimit = iNoOfGames; // No. of Games selected
            lblNoOfGames.Text = Convert.ToString(iGameLimit); // Showing goal in a label
            gameMode = 2; // Counter 2 means playing with computer 


            // Instantiate all the picture boxes 
            graDice1 = picBxDie1.CreateGraphics();
            graDice2 = picBxDie2.CreateGraphics();
            graDice3 = picBxDie3.CreateGraphics();
            graDice4 = picBxDie4.CreateGraphics();
            graDice5 = picBxDie5.CreateGraphics();
            graDice6 = picBxDie6.CreateGraphics();
        }

        public GamePage(string splayer1, string splayer2, int iGoal, int iNoOfGames)
        {
            // This is what happens if we instantiate SixOfOne using FOUR arguments (Player 1 name, Player 2 name, Agreed Goal, And no. of games)
            // We wrote this constructor, but we still have to include InitializeComponent();
            InitializeComponent();
            
            // Recalling the Player turn function with Random value
            // So its going to pick player 1 and player 2 randomly as the game starts
            iPlayerTurns = randTurn.Next(1, 2 + 1);
            nameFont(iPlayerTurns);

            // Displaying information received form arguments 
            lblPlayerName1.Text = splayer1; // Player 1 name
            lblPlayerName2.Text = splayer2; // Player 2 name
            lblAgreedGoal.Text = Convert.ToString(iGoal); // Agreed goal provided
            iGameLimit = iNoOfGames; // No. of Games selected
            lblNoOfGames.Text = Convert.ToString(iGameLimit); // Showing goal in a label
            gameMode = 1; // Counter 1 means playing 1 on 1 


            // Instantiate all the picture boxes 
            graDice1 = picBxDie1.CreateGraphics();
            graDice2 = picBxDie2.CreateGraphics();
            graDice3 = picBxDie3.CreateGraphics();
            graDice4 = picBxDie4.CreateGraphics();
            graDice5 = picBxDie5.CreateGraphics();
            graDice6 = picBxDie6.CreateGraphics();
        }

//_____________________________________________________________________________________________________________________________//

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int iAgreedGoal = Convert.ToInt32(lblAgreedGoal.Text);
            
            // PLAYING ONE ON ONE
            // Re-calling each function everytime players clicks the roll button
            // and selects the no. of dice want to roll button
            // The program Rolls the dice, Calculates the score, Displays a message in 
            // a label, and changes the turn for next person to play
            if (gameMode == 1) 
            {
                try
                {
                    if (iPlayerTurns == 1)
                    {
                        lisScoreP1 = DiceRoll(); // Saving in a list 
                        calculateScore(lisScoreP1, iPlayerTurns); // Function recall
                        goalReached(iAgreedGoal, lblPlayerName1.Text, iPlay1Score); // Function recall
                    }
                    else if (iPlayerTurns == 2)
                    {
                        lisScoreP2 = DiceRoll(); // Saving in a list
                        calculateScore(lisScoreP2, iPlayerTurns); // Function recall
                        goalReached(iAgreedGoal, lblPlayerName2.Text, iPlay2Score); // Function recall
                    }

                }
                catch (FormatException)
                {
                    // If the player does not select the no. of dice to roll
                    MessageBox.Show("Please Select the no. of dice you want to Roll!", "Oops! You forgot something!");
                }

                // When reaches the number of games, Dislpays a message and then exits 
                if (iGameLimit == 0)
                {
                    // When the players are done playing the no. of games they selected, Application closes 
                    MessageBox.Show("Thanks for playing, Hope you had fun.", "GAME OVER");
                    Application.Exit();
                }
            }

            // PLAYING WITH COMPUTER 
            // It's always the player's turn whenever playing with computer, 
            // When clicks on roll, the program rolls the dice, calculates the score, display 
            // the message in a label, changes the turn and does the same for the computer 
            // as well, except it picks a random no. of dice value and disables the button
            else if (gameMode == 2)
            {
                if (iPlayerTurns == 1)
                {
                    lisScoreP1 = DiceRoll(); // Saving in a list 
                    calculateScore(lisScoreP1, iPlayerTurns); // Function recall
                    goalReached(iAgreedGoal, lblPlayerName1.Text, iPlay1Score); // Function recall

                    // Disable the buttons for the player
                    comboBxRollingDice.Enabled = false;
                    btnRoll.Enabled = false;
                    lblRoll.Text = "Button Disabled";

                    diceAnimation(1200); // To make it a bit slow so that user understands what it's doing 
                    lisScoreP2 = DiceRoll(); // Saving in a list

                    diceAnimation(1200); // To make it a bit slow so that user understands what it's doing 
                    calculateScore(lisScoreP2, iPlayerTurns); // Function recall

                    diceAnimation(1200); // To make it a bit slow so that user understands what it's doing 
                    goalReached(iAgreedGoal, lblPlayerName2.Text, iPlay2Score); // Function recall

                    // Enabling the buttons back for the player 
                    comboBxRollingDice.Enabled = true;
                    btnRoll.Enabled = true;
                    lblRoll.Text = "Click to Roll";

                    // When reaches the number of games, Dislpays a message and then exits 
                    if (iGameLimit == 0)
                    {
                        // When the players are done playing the no. of games they selected, Application closes 
                        MessageBox.Show("Thanks for playing, Hope you had fun.", "GAME OVER");
                        Application.Exit();
                    }
                }
            }
        }

//_____________________________________________________________________________________________________________________________//

        #region DICE ROLL 
        // Function Method: Rolling Dice 
        // Input: List name to add dice values (scores)
        // Output: Displays the no. of dice selected & adding scores in an array

        private List<int> DiceRoll()
        {
            // Getting the no. of dice the player decided to roll 


            if (gameMode == 2)
            {
                if (iPlayerTurns == 2)
                {
                    iRollingDice = randNoOfDice.Next(1, 7);
                    comboBxRollingDice.Text = Convert.ToString(iRollingDice);
                }
                else iRollingDice = Convert.ToInt32(comboBxRollingDice.Text);
            }
            else
            {
                iRollingDice = Convert.ToInt32(comboBxRollingDice.Text);
            }

            List<int> lScores = new List<int>();
                

            // Rolling the dice by Calling the function method of graphical faces (CreateDice)
            // Clearing rest of the dice if not selected by the player to roll
            // Also, adding score of the dice rolled into an array

            if (iRollingDice == 1)
            {
                // Clearing the rest of the dice
                graDice2.Clear(Color.Thistle);
                graDice3.Clear(Color.Thistle);
                graDice4.Clear(Color.Thistle);
                graDice5.Clear(Color.Thistle);
                graDice6.Clear(Color.Thistle);

                // Function recalls and adding the scores 
                CreateDice(graDice1, out iDiceNum[1]);
                diceAnimation(300); 
                lScores.Add(iDiceNum[1]); 
            }
            else if (iRollingDice == 2)
            {
                // Clearing the rest of the dice
                graDice3.Clear(Color.Thistle);
                graDice4.Clear(Color.Thistle);
                graDice5.Clear(Color.Thistle);
                graDice6.Clear(Color.Thistle);

                // Function recalls and adding the scores
                CreateDice(graDice1, out iDiceNum[1]); 
                diceAnimation(300); 
                lScores.Add(iDiceNum[1]);
                CreateDice(graDice2, out iDiceNum[2]); 
                diceAnimation(300); 
                lScores.Add(iDiceNum[2]);
            }
            else if (iRollingDice == 3)
            {
                // Clearing the rest of the dice
                graDice4.Clear(Color.Thistle);
                graDice5.Clear(Color.Thistle);
                graDice6.Clear(Color.Thistle);

                // Function recalls and adding the scores
                CreateDice(graDice1, out iDiceNum[1]);
                diceAnimation(300);
                lScores.Add(iDiceNum[1]);
                CreateDice(graDice2, out iDiceNum[2]);
                diceAnimation(300);
                lScores.Add(iDiceNum[2]);
                CreateDice(graDice3, out iDiceNum[3]);
                diceAnimation(300);
                lScores.Add(iDiceNum[3]);
            }
            else if (iRollingDice == 4)
            {
                // Clearing the rest of the dice
                graDice5.Clear(Color.Thistle);
                graDice6.Clear(Color.Thistle);

                // Function recalls and adding the scores
                CreateDice(graDice1, out iDiceNum[1]);
                diceAnimation(300);
                lScores.Add(iDiceNum[1]);
                CreateDice(graDice2, out iDiceNum[2]);
                diceAnimation(300);
                lScores.Add(iDiceNum[2]);
                CreateDice(graDice3, out iDiceNum[3]);
                diceAnimation(300);
                lScores.Add(iDiceNum[3]);
                CreateDice(graDice4, out iDiceNum[4]);
                diceAnimation(300);
                lScores.Add(iDiceNum[4]);
            }
            else if (iRollingDice == 5)
            {
                // Clearing the rest of the dice
                graDice6.Clear(Color.Thistle);

                // Function recalls and adding the scores
                CreateDice(graDice1, out iDiceNum[1]);
                diceAnimation(300);
                lScores.Add(iDiceNum[1]);
                CreateDice(graDice2, out iDiceNum[2]);
                diceAnimation(300);
                lScores.Add(iDiceNum[2]);
                CreateDice(graDice3, out iDiceNum[3]);
                diceAnimation(300);
                lScores.Add(iDiceNum[3]);
                CreateDice(graDice4, out iDiceNum[4]);
                diceAnimation(300);
                lScores.Add(iDiceNum[4]);
                CreateDice(graDice5, out iDiceNum[5]);
                diceAnimation(300);
                lScores.Add(iDiceNum[5]);    
            }
            else if (iRollingDice == 6)
            {
                // Function recalls and adding the scores
                CreateDice(graDice1, out iDiceNum[1]);
                diceAnimation(300);
                lScores.Add(iDiceNum[1]);
                CreateDice(graDice2, out iDiceNum[2]);
                diceAnimation(300);
                lScores.Add(iDiceNum[2]);
                CreateDice(graDice3, out iDiceNum[3]);
                diceAnimation(300);
                lScores.Add(iDiceNum[3]);
                CreateDice(graDice4, out iDiceNum[4]);
                diceAnimation(300);
                lScores.Add(iDiceNum[4]);
                CreateDice(graDice5, out iDiceNum[5]);
                diceAnimation(300);
                lScores.Add(iDiceNum[5]);
                CreateDice(graDice6, out iDiceNum[6]);
                diceAnimation(300);
                lScores.Add(iDiceNum[6]);
            }
            return lScores;
        }
        #endregion

//_____________________________________________________________________________________________________________________________//

        #region DICE ANIMATION
        // Function Method: DiceAnimation
        // Input: Area that needs an animation
        // Output: Dice looks like its changing between 1 and 6 randomly
        private void diceAnimation(int iMillisecs)
        {
                Application.DoEvents();
                System.Threading.Thread.Sleep(iMillisecs);

        }
        #endregion

//_____________________________________________________________________________________________________________________________//

        #region SWITCHING B/W PLAYERS
        // Method Function: Player Switch (Switching turns between two players)
        // Input: None
        // Output: If it's player 1's turn, it will switch to player 2, and vice versa
        public void playerSwitch()
        {
            if (iPlayerTurns == 1)
            {
                diceAnimation(400); // Recalling the animation to slow it down so that player can see the turn switching 
                iPlayerTurns = 2;
            }
            else if (iPlayerTurns == 2)
            {
                diceAnimation(400); // Recalling the animation to slow it down so that player can see the turn switching 
                iPlayerTurns = 1;
            }
        }
        #endregion

//_____________________________________________________________________________________________________________________________//

        #region CALCULATE SCORES OF EACH 
        //Method Function: Calculate Scores of the player
        //Input: List of the player, and the turn who's playing
        // Output: Prepares the Scores & displays them
        public void calculateScore(List<int> lisName, int iPlayerTurn)
        {
            int iOne = 1;
            int iCount = iterationList(lisName, iOne, lisName.Count); // Function Recall 

            // Condition: 4 (Boojum)
            // If four or more 1s rolled, Player wins the game immediately 
            if (iCount >= 4)
            {
                if (iPlayerTurn == 1)
                {
                    lblStats1.Text = "";
                    lblStats1.Text = "Woohoo! Boojum. You won the Game!";
                    resetEverything(lblPlayerName1.Text); // Function Recall 
                    gameStats(lblPlayerName1.Text); // Function Recall
                }
                else if (iPlayerTurn == 2)
                {
                    lblStats2.Text = "";
                    lblStats2.Text = "Woohoo! Boojum. You won the Game!";
                    resetEverything(lblPlayerName2.Text); // Function Recall 
                    gameStats(lblPlayerName2.Text); // Function Recall
                }
            }
            
            // Condition: 3 (Dead Drop) 
            // If exactly three 1s are rolled, Player loses the game immediately 
            else if (iCount == 3)
            {
                if (iPlayerTurn == 1)
                {                    
                    lblStats1.Text = "";
                    lblStats1.Text = "Oh, That's a Dead Drop! You lose.";
                    resetEverything(lblPlayerName2.Text); // Function Recall
                    gameStats(lblPlayerName2.Text); // Function Recall

                }
                else if (iPlayerTurn == 2)
                {                    
                    lblStats2.Text = "";
                    lblStats2.Text = "Oh, That's a Dead Drop! You lose.";
                    resetEverything(lblPlayerName1.Text); // Function Recall 
                    gameStats(lblPlayerName1.Text); // Function Recall

                }
            }

            // Condition: 2 (Snake's Eye)
            // if exactly two 1s are rolled, Player scores nothing for the turn and Score is back to zero
            else if (iCount == 2)
            {
                if (iPlayerTurn == 1)
                {
                    iPlay1Score = 0;
                    updateScore(0); // Function Recall 
                    lblStats1.Text = "";
                    lblStats1.Text = "Oh Oh! That's a Snake's eye. Scores back to Zero.";
                }
                else
                {
                    iPlay2Score = 0;
                    updateScore(0); // Function Recall 
                    lblStats2.Text = "";
                    lblStats2.Text = "Oh Oh! That's a Snake's eye. Scores back to Zero.";
                }
            }

            // Condition: 1 
            // If exactly one 1 is rolled, player scores nothing for the turn
            else if (iCount == 1)
            {
                if (iPlayerTurn == 1)
                {
                    lblStats1.Text = "";
                    lblStats1.Text = "Got 1? Uh, You score nothing for this turn.";
                    updateScore(0); // Function Recall 
                }
                else
                {
                    lblStats2.Text = "";
                    lblStats2.Text = "Got 1? Uh, You score nothing for this turn.";
                    updateScore(0); // Function Recall 
                }
            }

            // Condition: 5 AND Condition: 6
            else
            {
                for (int i = 0; i < lisName.Count(); i++)
                {
                    // Condition: 5 If three or more numbers rolled are the same (Not 1s) 
                    // Score is doubled for the player 
                    if (checkOtherOutOfSix(lisName, i)) // Function Recall
                    {
                        if (iPlayerTurn == 1)
                        {
                            lblStats1.Text = "";
                            lblStats1.Text = "Woah! That's a Snaffle. Scores Doubled!";
                            updateScore(2 * lisName.Sum()); // Function Recall & doubles the score 
                            break;
                        }
                        else if (iPlayerTurn == 2)
                        {
                            lblStats2.Text = "";
                            lblStats2.Text = "Woah! That's a Snaffle. Scores Doubled!";
                            updateScore(2 * lisName.Sum()); // Function Recall & doubles the score
                            break;
                        }
                    }

                    // Condition: 6 In any other case, Player score is added into the Score list 
                    else
                    {
                        if (iPlayerTurn == 1)
                        {
                            lblStats1.Text = "";

                            lblStats1.Text = "Yikes! Scores Added.";
                            updateScore(lisName.Sum()); // Function Recall 
                            break;
                        }
                        else if (iPlayerTurn == 2)
                        {
                            lblStats2.Text = "";
                            lblStats2.Text = "Yikes! Scores Added.";
                            updateScore(lisName.Sum()); // Function Recall 
                            break;
                        }
                    }
                }
            }
            playerSwitch(); // Function Recall 
            nameFont(iPlayerTurns); // Function Recall
        }
        #endregion

//_____________________________________________________________________________________________________________________________//

        #region GOAL CHECK
        // Method Function: Goal Reached (Checks if the score of the player has reached the agreed goal)
        // Input: Agreed goal, Player's name, and the Player's score 
        // Output: Displays a message who won the game, Deducts each game from the no. of games and clears the list of both
        private void goalReached(int iGoal, string sPlayerName, int iPScore)
        {
            if (iPScore >= iGoal)
            {
                if (iPlayerTurns == 1)
                {
                    resetEverything(sPlayerName); // Function recall
                    gameStats(sPlayerName); // Function recall
                }
                else
                {
                    resetEverything(sPlayerName); // Function recall
                    gameStats(sPlayerName); // Function recall

                }
            }
        }
        #endregion

//_____________________________________________________________________________________________________________________________//

        #region GAME STATISTICS 
        // Method Function: Game Stats (Shows who won how many games in the statistics part of the design)
        // Input: Player name 
        // Output: Dsiplays the stats in the labels down at the bottom 
        private void gameStats (string sPlayerName)
        {
            if (iPlayerTurns == 1)
            {
                iGameCounter1 = iGameCounter1 + 1; // Counter to keep record
                lblGameStats1.Text = sPlayerName + " won " + iGameCounter1 + " game(s)";
            }
            else
            {
                iGameCounter2 = iGameCounter2 + 1; // Counter to keep record
                lblGameStats2.Text = sPlayerName + " won " + iGameCounter2 + " game(s)";
            }
        }
        #endregion

//_____________________________________________________________________________________________________________________________//

        #region RESET EVERYTHING WHEN WIN
        // Method: ResetEverything (Resets everything on the page whenever the player wins)
        // Input: Player name (to dislpay the message)
        // Output: Displays a message box to annouce winner, Clears everything on the game page and deducts each
        // game from the no. of games selected  
        private void resetEverything(string sPlayerName)
        {
            MessageBox.Show("Congrats! " + sPlayerName + " Won this game.", "Winner Announcement!!");


            // Clears the scores 
            iPlay1Score = 0;
            iPlay2Score = 0;
            updateScore(0);

            // Clears the status list 
            lblStats1.Text = "";
            lblStats2.Text = "";
            lblScoreToWin1.Text = "";
            lblScoreToWin2.Text = "";

            // Clears all the dice
            graDice1.Clear(Color.Thistle);
            graDice2.Clear(Color.Thistle);
            graDice3.Clear(Color.Thistle);
            graDice4.Clear(Color.Thistle);
            graDice5.Clear(Color.Thistle);
            graDice6.Clear(Color.Thistle);

            lblScore1.Text = Convert.ToString(iPlay1Score);
            lblScore2.Text = Convert.ToString(iPlay2Score);

            // Deducts each game when wins from the agreed number of games 
            lblNoOfGames.Text = Convert.ToString(iGameLimit -= 1);
        }
        #endregion

//_____________________________________________________________________________________________________________________________//

        #region CHANGE PLAYER's NAME FONT
        // Method Function: Name Font (Changes font in order to tell both the users whose turn it is)
        // Input: Current player's turn
        // Output: Changes the font to BOLD and displays a label to tell user that its' their turn
        public void nameFont(int iPlayerTurn)
        {
            if (iPlayerTurn == 1) // when first player is playing
            {
                lbl2Turn.Text = "";
                lbl1Turn.Text = "It's your turn now"; // Small label appearing above the name
                lblPlayerName2.Font = new Font(lblPlayerName2.Font, FontStyle.Regular);
                lblPlayerName1.Font = new Font(lblPlayerName1.Font, FontStyle.Bold);
            }
            else if (iPlayerTurn == 2) // when second player is playing
            {
                lbl1Turn.Text = "";
                lbl2Turn.Text = "It's your turn now"; //Small label appearing above the name
                lblPlayerName2.Font = new Font(lblPlayerName2.Font, FontStyle.Bold);
                lblPlayerName1.Font = new Font(lblPlayerName2.Font, FontStyle.Regular);
            }
        }
        #endregion

//_____________________________________________________________________________________________________________________________//

        #region GRAPHICAL DICE FACES
        // Function Method: CreateDice (Creates random graphical faces)
        // Input: Picture box and the random dice value
        // Output: Displays the graphical image of the random value

        private int CreateDice(Graphics graDice, out int iDiceValue)
        {
            SolidBrush brshBlack = new SolidBrush(Color.Black); // Declare & Instantiate a Black brush for dice 
            iDiceValue = randDie.Next(1, 6 + 1); // Random dice values to present 

            // Creates a graphical dice image for each dice value
            // from 1 to 6

            if (iDiceValue == 1) // if the random value is 1
            {
                graDice.Clear(Color.Gainsboro);
                graDice.FillEllipse(brshBlack, 35, 35, 10, 10); // Centre
            }
            else if (iDiceValue == 2) // if the random value is 2
            {
                graDice.Clear(Color.Gainsboro);
                graDice.FillEllipse(brshBlack, 15, 35, 10, 10); // Middle left
                graDice.FillEllipse(brshBlack, 55, 35, 10, 10); // Middle Right 
            }
            else if (iDiceValue == 3) // if the random value is 3
            {
                graDice.Clear(Color.Gainsboro);
                graDice.FillEllipse(brshBlack, 35, 35, 10, 10); // Centre
                graDice.FillEllipse(brshBlack, 55, 15, 10, 10); // Top right
                graDice.FillEllipse(brshBlack, 15, 55, 10, 10); // Bottom left
            }
            else if (iDiceValue == 4) // if the random value is 4
            {
                graDice.Clear(Color.Gainsboro);
                graDice.FillEllipse(brshBlack, 15, 15, 10, 10); // Top left
                graDice.FillEllipse(brshBlack, 55, 15, 10, 10); // Top right
                graDice.FillEllipse(brshBlack, 15, 55, 10, 10); // Bottom right 
                graDice.FillEllipse(brshBlack, 55, 55, 10, 10); // Bottom left
            }
            else if (iDiceValue == 5) // if the random value is 5
            {
                graDice.Clear(Color.Gainsboro);
                graDice.FillEllipse(brshBlack, 15, 15, 10, 10); // Top left
                graDice.FillEllipse(brshBlack, 55, 15, 10, 10); // Top right
                graDice.FillEllipse(brshBlack, 15, 55, 10, 10); // Bottom right
                graDice.FillEllipse(brshBlack, 55, 55, 10, 10); // Bottom left
                graDice.FillEllipse(brshBlack, 35, 35, 10, 10); // Centre
            }
            else if (iDiceValue == 6) // if the random value is 6
            {
                graDice.Clear(Color.Gainsboro);
                graDice.FillEllipse(brshBlack, 15, 15, 10, 10); // Top left
                graDice.FillEllipse(brshBlack, 55, 15, 10, 10); // Top right
                graDice.FillEllipse(brshBlack, 15, 55, 10, 10); // Bottom right
                graDice.FillEllipse(brshBlack, 55, 55, 10, 10); // Bottom left
                graDice.FillEllipse(brshBlack, 15, 35, 10, 10); // Middle left
                graDice.FillEllipse(brshBlack, 55, 35, 10, 10); // Middle right 
            }
            return (iDiceValue);
        }
        #endregion

//_____________________________________________________________________________________________________________________________//

        #region Iteration List (Check 1s)
        // Method Function: Iteration List (Checks the ones in the List, If found, Counter would add up depending on how much 1s
        // Input: List, iNumber (Condition number 1), iLimit (Length of the list)
        // Output: int times (Counter)
        private int iterationList(List <int> iList, int iNumber, int iLimit)
        {
            int iTimes = 0;
            for (int i = 0; i < iLimit; i++)
            {
                if (iList[i] == iNumber)
                {
                    iTimes++;
                }
            }
            return iTimes;
        }
        #endregion

//_____________________________________________________________________________________________________________________________//

        #region UPDATE & DISPLAY SCORES
        // Function Method: UpdateScore (adds & Updates each players score on the label)
        // Input: Current players score 
        // Output: Updates the label with current score 
        private void updateScore(int iEachTurnScore)
        {
            if (iPlayerTurns == 1)
            {
                iPlay1Score += iEachTurnScore; // Adds up 
                lblScore1.Text = Convert.ToString(iPlay1Score); // Displays
                int iNeedToWin1 = Convert.ToInt32(lblAgreedGoal.Text);
                lblScoreToWin1.Text = "";
                lblScoreToWin1.Text = "Need " + Convert.ToString(iNeedToWin1 - iPlay1Score) + " to Win";
            }
            else
            {
                iPlay2Score += iEachTurnScore; // Adds up 
                lblScore2.Text = Convert.ToString(iPlay2Score); // Displays
                int iNeedToWin2 = Convert.ToInt32(lblAgreedGoal.Text);
                lblScoreToWin2.Text = "";
                lblScoreToWin2.Text = "Need " + Convert.ToString(iNeedToWin2 - iPlay2Score) + " to Win";
            }
        }
        #endregion

//_____________________________________________________________________________________________________________________________//

        #region CHECK SAME NUMBERS (SNAFFLE)
        // Function Method: checkOtherOutOfSix (Checks if three or more numbers are the same other than 1s)
        // Input: list and Dice values
        // Output: Returns a boolean value post checking 
        private Boolean checkOtherOutOfSix(List <int> ilist, int iNumbers)
        {
            int iTimes = 0;
            
            // Checking each element in the list 
            foreach (int iElement in ilist)
            {
                if (iElement == iNumbers) iTimes++; // if same, increase the counter 
            }

            if (iTimes > 2) // If more than two times found, return true
            {
                return true;
            }
            else return false; // If not, return false
        }
        #endregion

//_____________________________________________________________________________________________________________________________//
    }
}

