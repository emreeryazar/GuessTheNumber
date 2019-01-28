
/**********************************************************************
Description: Yunus Emre ERYAZAR  Date:27.01.2019
***********************************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class frmGame : Form
    {
        Random random = new Random();

        String[] playerGuess = new String[4];
        int[] computerGuess = new int[4];
        int[] computerPick = new int[4];
        int[] computerGuessTemp = new int[4];

        List<int> computerOldGuesses = new List<int>();
        List<int> pickedNumbersPick = new List<int>();
        List<int> pickedNumbersGuess = new List<int>();
        List<int> guessNumbers = new List<int>();
        List<int> guessNumbersTemp = new List<int>();
        List<int> correctNumbersList = new List<int>();

        int oldCorrectDigits = 0;
        int oldCorrectNumbers = 0;
        int correctDigits = 0;
        int correctNumbers = 0;
        int oldCount = 0;
        int newCount = 0;
        int checkDigit = 0;
        int oldNumber = 0;
        int checkIndex = 0;
        int checkIndexNumber = 0;
        int checkNumber = 0;
        int checkCount = 0;

        bool isComputerTurn = false;
        bool isPlayerTurn = false;
        bool isFirstTurn = false;
        bool isSecondTurn = false;
        bool isContain = false;
        bool isCountEquals = false;
        bool isValid = false;


        //Initialization of Form Components and Picked Numbers from Computer and Player
        public frmGame()
        {
            InitializeComponent();

            String selectedNumberPlayer = frmMain.input;  // Get the player pick and set it to remember
            lblPlayerPick.Text += selectedNumberPlayer;

            for (int a = 0; a < 10; a++)    // Add [0,..,9] numbers to list for computer guesses
            {
                guessNumbers.Add(a);              
            }

            ComputerPick(); // Initialization of computer pick
            FirstTurn();  // Decides who will start the game
        }

        // Initialization of computer pick. Choosing a 4-digit number, with each digit different.
        public void ComputerPick()
        {
            int tmp = 0;

            while (tmp <1)
            {
                //get random numbers and add to list
                for (int a = 0; a < 4; a++)
                {
                    int nmbfirst = random.Next(1, 10);
                    int nmb = random.Next(0, 10);


                    if (a == 0) //if first digit equals 0 then pick again except 0.
                    {                        
                        pickedNumbersPick.Add(nmbfirst);
                    }
                    else
                    {                 
                        pickedNumbersPick.Add(nmb);
                    }
   
                }
                computerPick = pickedNumbersPick.ToArray(); // get the picked numbers from list and initialize computer pick

                //Check for each digit number different.If its different exit from picking otherwise pick again.  
                if (computerPick[0] != computerPick[1] && computerPick[0] != computerPick[2] && 
                    computerPick[0] != computerPick[3] && computerPick[1] != computerPick[2] &&
                    computerPick[1] != computerPick[3] && computerPick[2] != computerPick[3])
                {
                    tmp++;
                }
                else
                {
                    pickedNumbersPick.Clear();
                }
             
            }
                  
        }

        //Decides who will start the game randomly and starts the game.
        public void FirstTurn()
        {
            int selectStart = random.Next(0, 2);

            if (selectStart == 0) //Check if player starts
            {
                // Organize form components
                lblTurn.Text = "You Will Start, Guess My Number!"; 
                isPlayerTurn = true;
                isFirstTurn = true;
                btnClue.Enabled = false;
                nmrCorrectDigit.Enabled = false;
                nmrCorrectNumber.Enabled = false;

            }
            else //Check if computer starts
            {   
                //Organize values for turn check 
                isComputerTurn = true;
                isFirstTurn = true;
                ComputerGuess(); // Computer guesses player pick

                // Organize form components
                for (int i = 0; i < 4; i++)
                {
                    lblComGuess.Text += computerGuess[i];

                }
            
                lblTurn.Text = "Here My Guess, Give Me Hint!";            
                txtGuess.Enabled = false;
                btnGuess.Enabled = false;

            }

        }

        //Check turns during the game  
        public void Turns()
        {   
            //Check if computer turns. Organize the turn values and form components and Guess the player number  
            if (isComputerTurn == true)
            {
                isSecondTurn = true;
                ComputerGuess();

                for(int i =0;i< 4; i++)
                {
                    lblComGuess.Text += computerGuess[i];

                }

                lblTurn.Text = "Here My Guess, Give Me Hint!";           
                btnGuess.Enabled = false;
                txtGuess.Enabled = false;
            }
            else if (isPlayerTurn == true) // Organize the turn values and form components for player guess
            {
                lblTurn.Text = "Your Turn, Guess My Number!";
                lblComGuess.Text = "Computer Guess: ";
                btnClue.Enabled = false;
                nmrCorrectDigit.Enabled = false;
                nmrCorrectNumber.Enabled = false;

            }

        }

        //Check a guess according the pick number and organize form components according to the result of check.
        public void CheckGuess(int[] firstNumber, int[] secondNumber)
        {
            int c1 = 0;
            int c2 = 0;

            for (int x = 0; x < 4; x++)
            {
              
                for (int y = 0; y < 4; y++)
                {
                    if (x != y) //Check same digits and increase count according to the result
                    {
                        if (firstNumber[x] == secondNumber[y])
                        {
                            c2 = c2 + 1;

                        }

                    }
                    else if( x == y) //Check a digit against other digits and increase count according to the result
                    {
                        if (firstNumber[x] == secondNumber[y])
                        {
                            c1 = c1 + 1;

                        }                     

                    }

                }

            }
      
            if (isPlayerTurn == true) // Organize form components according the counts result
            {
                lblResult.Text = "Result : +" + c1 + ", -" + c2;
                
                if (c1 == 4)
                {                   
                    lblResult.Text = "You Won!";
                    btnGuess.Enabled = false;
                    btnClue.Enabled = false;

                }
            }   
        }  

        //Get the player guess, check validation of it and start checking guess.
        private void btnGuess_Click(object sender, EventArgs e)
        {   
                 
            String playerInput = txtGuess.Text;
            CheckValidation(playerInput);  //Check validation of input from player 

            if (isValid == true)
            {
                //Get the player input and send to check
                playerGuess = playerInput.ToCharArray().Select(c => c.ToString()).ToArray();
                int[] guessInput = Array.ConvertAll<string, int>(playerGuess, int.Parse);
                CheckGuess(guessInput, computerPick);

                //Organize turn values and form components
                isPlayerTurn = false;
                isComputerTurn = true;
                btnClue.Enabled = true;
                nmrCorrectDigit.Enabled = true;
                nmrCorrectNumber.Enabled = true;
                
                //Go to next turn
                Turns();
            }                                              
        }

        //Computer makes its first guess and changes it according to the hints received from player.  
        public void ComputerGuess()
        {
            if (isFirstTurn == true) //Check if its first turn of computer make a random guess.
            {
                int tmp = 0;

                while (tmp < 1)
                {
                    for (int a = 0; a < 4; a++)
                    {
                        int nmbfirst = random.Next(1, 10);
                        int nmb = random.Next(0, 10);

                        if (a == 0) //Check if first digit is 0 or not
                        {
                            pickedNumbersGuess.Add(nmbfirst);
                        }
                        else
                        {
                            pickedNumbersGuess.Add(nmb);
                        }
                    }

                    computerGuess = pickedNumbersGuess.ToArray(); // Initialize the computer guess.

                    //Check for each digit number different.If its different exit from guessing otherwise guess again.  
                    if (computerGuess[0] != computerGuess[1] && computerGuess[0] != computerGuess[2] && computerGuess[0] != computerGuess[3] && computerGuess[1] != computerGuess[2] &&
                        computerGuess[1] != computerGuess[3] && computerGuess[2] != computerGuess[3])
                    {
                        tmp++;
                    }
                    else
                    {
                        pickedNumbersGuess.Clear();
                    }

                }

                isFirstTurn = false; //computer first turn ended.
            } 
            else
            {
                //Change guess according to the results received from player.
                //if received results contains any correct number at correct digit or correct numbers at wrong digit, delete all used numbers from guess numebr list and make a new guess.
                if (newCount == 0 && isSecondTurn == true)  
                {                   
                    for (int i = 0; i < 4; i++) //Delete wrong numbers from guess number list and clean the picked numbers list.
                    {
                        guessNumbers.RemoveAll(x => x == (computerGuess[i]));
                        pickedNumbersGuess.RemoveAll(x => x == (computerGuess[i]));                      
                    }

                    for (int i = 0; i < 4; i++) //Pick a new 4-digit number with each different from guess number list for new guess.
                    {                         
                        int index = random.Next(guessNumbers.Count);
                        computerGuess[i] = guessNumbers[index];
                        guessNumbers.RemoveAll(x => x == (computerGuess[i]));

                        if (i == 0 && computerGuess[i] == 0) //Check first digit for equals 0 or not
                        {
                            int ind = random.Next(guessNumbers.Count);
                            computerGuess[i] = guessNumbers[ind];
                            guessNumbers.Add(0);
                            guessNumbers.RemoveAll(x => x == (computerGuess[i]));
                        }
                        
                        pickedNumbersGuess.Add(computerGuess[i]); //Add picked numbers to list

                    }

                    computerGuess = pickedNumbersGuess.ToArray();//Initalize your new guest
                }
                //If received results contains 1 or more correct number at correct digit or 1 or more correct numbers at wrong digit,
                //change the numbers and try to get more correct results          
                else if (newCount > 0 && newCount !=4)                                   
                {
                    if (checkCount != 0 && oldCount != 0)
                    {
                        if (oldCount == newCount)
                        {
                            guessNumbers.Add(oldNumber);
                        }

                        //If new guess contains more correct results according to the old guess,
                        //the number used before change is worthless to use again so delete it from list and increase check digit.
                        if (oldCorrectDigits < correctDigits || oldCorrectNumbers < correctNumbers)  
                        {                                                                                             
                            if(oldCount < newCount)
                            {
                                guessNumbers.RemoveAll(x => x == oldNumber);
                            }                            
                            checkDigit++;

                        }
                        //If new guess contains less correct results according to the old guess,
                        //the number used before change is valuable to use so change new digit with old valuable number and increase check digit.
                        else if (oldCorrectDigits > correctDigits || oldCorrectNumbers > correctNumbers)
                        {      
                            if(oldCount > newCount)
                            {
                                guessNumbers.RemoveAll(x => x == computerGuess[checkDigit]);
                                computerGuess[checkDigit] = oldNumber;
                            }
                            checkDigit++;

                        }
                        
                    }

                    if (checkDigit == 4) //Control count of check digit.
                    {
                        checkDigit = 3;
                    }

                    oldNumber = computerGuess[checkDigit]; //Temp values to keep number used before change

                    //Change numbers of guess to get more correct result.
                    guessNumbersTemp = guessNumbers;
                    guessNumbers.RemoveAll(x => x == oldNumber);


                    for (int i = 0; i<4; i++)
                    {
                        guessNumbers.RemoveAll(x => x == computerGuess[i]);      
                    }
                    while (true) //Make a new guess and check first digit to not equals 0.
                    {
                        int index = random.Next(guessNumbers.Count);
                        computerGuess[checkDigit] = guessNumbers[index];

                        if (computerGuess[0] != 0)
                        {
                            break;

                        }
                    }

                    guessNumbers = guessNumbersTemp;                    
                    checkCount++;

                }
                //If sum of received results contains 4 correct number, change the numbers' digits
                else if (newCount == 4)
                {
                    // If number correct numbers at wrong digits more then number of correct numbers at correct digit, change the numbers' digit.
                    if (correctNumbers > correctDigits && isCountEquals == false)
                    {
                        if (isContain == false) //Add guess to list to check used again or not
                        {
                            int checkexist = computerGuess.Select((t, i) => t * Convert.ToInt32(Math.Pow(10, computerGuess.Length - i - 1))).Sum();
                            computerOldGuesses.Add(checkexist);
                        }

                        while (true) // Check the guess is used before or not.If not used add to list otherwise make a new guess.
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                correctNumbersList.Add(computerGuess[i]);
                            }

                            int index;
                            int temp = computerGuess[0];

                            correctNumbersList.RemoveAll(x => x == computerGuess[0]);
                            for (int i = 1; i < 4; i++)
                            {
                                index = random.Next(correctNumbersList.Count);
                                computerGuess[i] = correctNumbersList[index];
                                correctNumbersList.RemoveAll(x => x == computerGuess[i]);
                            }

                            computerGuess[0] = temp;
                            isContain = computerOldGuesses.Contains(computerGuess.Select((t, i) => t * Convert.ToInt32(Math.Pow(10, computerGuess.Length - i - 1))).Sum());

                            if (isContain == false)
                            {
                                break;
                            }
                            else
                            {
                                for (int i = 1; i < 4; i++)
                                {
                                    computerOldGuesses.RemoveAll(x => x == computerGuess[i]);
                                }

                            }

                        }
                    }
                    //If number of correct numbers at correct digits is equals number of correct numbers at wrong digits, change the numbers' digit in order.
                    //İf guess is wrong go back to first guess whick is contains equal number of correct numbers at correct digits and correct numbers at wrong digits , change digit.
                    else if (correctNumbers == correctDigits || isCountEquals == true)
                    {
                        isCountEquals = true;

                        if (checkNumber < 1)
                        {
                            Array.Copy(computerGuess, computerGuessTemp, 4);

                        }

                        if (checkIndex == 3)
                        {
                            checkIndexNumber++;
                            checkIndex = checkIndexNumber;
                        }

                        Array.Copy(computerGuessTemp, computerGuess, 4);

                        int temp = computerGuess[checkIndexNumber];
                        computerGuess[checkIndexNumber] = computerGuess[checkIndex + 1];
                        computerGuess[checkIndex + 1] = temp;

                        if (computerGuess[0] == 0)
                        {
                            checkIndex++;
                            checkNumber++;

                            if (checkIndex == 3)
                            {
                                checkIndexNumber++;
                                checkIndex = checkIndexNumber;

                            }
                            Array.Copy(computerGuessTemp, computerGuess, 4);

                            int temp2 = computerGuess[checkIndexNumber];
                            computerGuess[checkIndexNumber] = computerGuess[checkIndex + 1];
                            computerGuess[checkIndex + 1] = temp2;

                        }
                        else
                        {
                            checkIndex++;
                            checkNumber++;
                        }

                    }


                }

            }

        }

        //Check validation of player guess input.
        public void CheckValidation(String input)
        {
            //Input can't be empty and should contain 4 digit number.
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
                    isValid = true;
                }
                else
                {
                    MessageBox.Show("Please Enter 4 Digit With Different Numbers!");
                }

            }

        }
        
        //Check validation of player guess input.The input must be onlt numbers.
        private void CheckValidation2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter 4 Digit With Different Numbers!");
            }
            
        }

        //Get results of computer guess from player to computer new guess
        public void GetClues(int a , int b)
        {
            oldCount = newCount;
            oldCorrectDigits = correctDigits;
            oldCorrectNumbers = correctNumbers;
            correctDigits = a;
            correctNumbers = b;
            newCount = a + b;

        }

        //Get results of computer guess from player, organize form components and go to next turn.
        private void btnClue_Click(object sender, EventArgs e)
        {
            int c1 = Convert.ToInt32(nmrCorrectDigit.Value);
            int c2 = Convert.ToInt32(nmrCorrectNumber.Value);

            GetClues(c1,c2);
            isPlayerTurn = true;
            isComputerTurn = false;
            txtGuess.Enabled = true;
            btnGuess.Enabled = true;
            nmrCorrectDigit.Value = 0;
            nmrCorrectNumber.Value = 0;

            if (correctDigits == 4)
            {
                lblResult.Text = "I Win!";
                btnClue.Enabled = false;
                btnGuess.Enabled = false;
                lblTurn.Text = "Thank You!";
            }
            else
            {
                Turns();
            }

          
        
        }
    }
}
