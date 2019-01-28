
/**********************************************************************
Description: Yunus Emre ERYAZAR  Date:27.01.2019
***********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class frmMain : Form
    {

        public static String input;
        bool checkDif = false;

        public frmMain()
        {
            InitializeComponent();
        }

        //Get player pick,check its validation and start the game.
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            input = txtPick.Text;
            CheckValidation(input);

            if (checkDif == true)
            {
                this.Hide();
                frmGame frmGame = new frmGame();
                frmGame.ShowDialog();
                this.Show();
            }
                     
        }

        //Check validation of player pick.Pick should contains 4 digit and cant be empty.
        public void CheckValidation(String input)
        {

            if (input.Trim() == string.Empty || input.Length != 4)
            {
                MessageBox.Show("Please Enter 4 Digit With Different Numbers!");

            }
            else
            {
                String Digit1, Digit2, Digit3, Digit4;

                Digit1 = input.Substring(0, 1);
                Digit2 = input.Substring(1, 1);
                Digit3 = input.Substring(2, 1);
                Digit4 = input.Substring(3, 1);

                if (Digit1 != Digit2 && Digit1 != Digit3 && Digit1 != Digit4 && Digit2 != Digit3 && Digit2 != Digit4 && Digit3 != Digit4)
                {

                    checkDif = true;
                }
                else

                    MessageBox.Show("Please Enter 4 Digit With Different Numbers!");

            }

        }

        //Check validation of player pick.Pick should contains only numbers.
        private void CheckValidation2(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

                MessageBox.Show("Please Enter 4 Digit With Different Numbers!");


            }

        }
    }


}


