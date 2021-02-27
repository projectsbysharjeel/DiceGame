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
// Group members: Sharjeel Sohail (c3316130) & Fadzayi Manyenya (c-----)
// Hand-in date: 31st May 2020
// Project: Creating a Dice Game

namespace Assessment01
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx //

        // Declaring varibale required
        string sPlayer1, sPlayer2;
        int iNoOfGames;


// xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx //

        private void trackBarGoal_Scroll(object sender, EventArgs e)
        {
            txtbxScoreSelected.Text = Convert.ToString(trackBarGoal.Value);
        }

        private void radioBtnComp_CheckedChanged(object sender, EventArgs e)
        {
            txtBxPlayer2.Enabled = false;
        }

        private void radioBtn1on1_CheckedChanged(object sender, EventArgs e)
        {
            txtBxPlayer2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declare and Instantiate the AboutBoxGame form
            MoreInfo frmMoreInfo = new MoreInfo();
            // Display form
            frmMoreInfo.ShowDialog();
        }

        // xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx //


        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Reading the input given by the user 
                sPlayer1 = txtBxPlayer1.Text; // Player 1 Name
                sPlayer2 = txtBxPlayer2.Text; // Player 2 Name
                iNoOfGames = Convert.ToInt32(comboBxGames.Text);  // No. of games selected  
                
                if (radioBtn1on1.Checked)
                {
                    // Declare and Instantiate the final game form
                    GamePage frmGamePage = new GamePage(txtBxPlayer1.Text, txtBxPlayer2.Text, trackBarGoal.Value, iNoOfGames);

                    // Display form
                    frmGamePage.ShowDialog();
                }

                else if (radioBtnComp.Checked)
                {
                    // Declare and Instantiate the final game form
                    GamePage frmGamePage = new GamePage(txtBxPlayer1.Text, trackBarGoal.Value, iNoOfGames);

                    // Display form
                    frmGamePage.ShowDialog();
                }
            }
            catch
            {
                // If any field is missed, it displays a message!
                MessageBox.Show("Please fill out all the information!", "Missing Information Error");
            }
        }
    }
}
