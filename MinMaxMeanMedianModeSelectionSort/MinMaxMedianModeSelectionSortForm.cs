using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectionSort
{
    public partial class MinMaxMedianModeSelectionSortForm : Form
    {
        // All your code should be placed within the class.

        #region Examples of Comments
        // This is a one-line comment

        /*
         * 
         * This is a multi-line comment.
         * 
         */
        #endregion

        #region Global Declarations, Initializations and Instantiations
        // Global variables and objects should be created at the top of the class.
        // If a variable or object is global to a class, any procedure in the class
        // can access and modify it.

        // Declaration: Associates a name with a data type or class
        // Initialization: Gives a variable its initial value
        // Instantiation: Creates an object and initializes it

        /*
         * The part of the following statement that lies to the left of the equals sign 
         * associates the name "numberList" with a list of "double" values. This is called 
         * a "declaration." The part that lies on the right creates the initially empty list. 
         * This is called an "instantiation."
         */
        private List<double> numberList = new List<double>();
        private List<double> numberListTwo = new List<double>();

        #endregion

        #region A Note on Object-Oriented Programming
        /*
         * In object-oriented programming, classes are the "blueprints" or "templates" for
         * making objects. Just as a cookie-cutter can be used to make any number of cookies,
         * a class can be used to make any number of objects. In Microsoft Visual Studio,
         * objects consist of properties, methods and events.
         * 
         * property-> A variable that belongs to an object, typically used to store
         *            information about a characteristic of the object
         * method  -> A procedure or function that belongs to an object. Methods are
         *            ACTIONS that can be performed by, to or for an object.
         * event   -> An event is a message sent by an object to signal the occurrence 
         *            of an action. Events are used to trigger the execution of code.
         * 
         * For example, the "Button" class is used to make buttons in Windows Forms
         * applications. 
         * 
         * Text    -> A property found within the Button class. It stores the text that is 
         *            displayed on the button.
         * Hide    -> A method found within the Button class. It is used to hide a button.
         * Click   -> An event found within the Button class. The "Click" event is is raised
         *            whenever the user clicks on a button.
         */
        #endregion

        #region Constructor Method
        // The following is called a "constructor method" for the form "SelectionSortForm."
        // Place within the constructor method any code that needs to be executed as 
        // soon as the form is created (i.e. loaded). 
        public MinMaxMedianModeSelectionSortForm()
        {
            InitializeComponent();
        }

        #endregion

        //Everything above is just notes

        //EVENT HANDLERS
        #region Event Handlers

        /**************************************************************************************************************/
        //EVENT HANDLERS FOR CALCULATOR STUFF
        /**************************************************************************************************************/
        //This is the event handler for the "CLICK" on "SUBMIT BUTTON"
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            double number;
            bool isNumeric = Double.TryParse(numberTextBox.Text, out number);

            numberListBox.SelectedIndex = -1; //Remove any highlighting

            if (isNumeric) // This is equivalent to 'if (isnumeric == true)'
            {
                // Add the entered number to both the list and the list box
                numberList.Add(number);
                numberListBox.Items.Add(number);
            }
            else
            {
                MessageBox.Show("You may only enter numbers!", "Error");
            }
            numberTextBox.SelectAll();
        }

        //This is the event handler for the "CLICK" on "SUBMIT BUTTON TWO"
        private void SubmitButtonTwo_Click(object sender, EventArgs e)
        {
            double number;
            bool isNumeric = Double.TryParse(numberTextBox.Text, out number);

            numberListBoxTwo.SelectedIndex = -1; //Remove any highlighting

            if (isNumeric) // This is equivalent to 'if (isnumeric == true)'
            {
                // Add the entered number to both the list and the list box
                numberListTwo.Add(number);
                numberListBoxTwo.Items.Add(number);
            }
            else
            {
                MessageBox.Show("You may only enter numbers!", "Error");
            }
            numberTextBox.SelectAll();
        }

        //This is the event handler for the "CLICK" on "BINARY SEARCH BUTTON"
        private void BinarySearchButton_Click(object sender, EventArgs e)
        {
            double number;
            bool isNumeric = Double.TryParse(numberTextBox.Text, out number);

            numberListBox.SelectedIndex = -1; //Remove any highlighting
            List<double> SortedList = new List<double>(SelectionSort(numberList, true));
            if (isNumeric)
            {
                int indexOfNumber = BinarySearchNum(SortedList, number);
                DisplayList(SortedList);

                if (indexOfNumber != -1)
                {
                    outputLabel.Text = "'" + number.ToString() + "' was found at index '" + indexOfNumber.ToString() + "'.";
                    numberListBox.SelectedIndex = indexOfNumber;
                }
                else
                {
                    outputLabel.Text = "'" + number.ToString() + "' was not found.";
                }
            }
            else
            {
                MessageBox.Show("You may only enter numbers.", "Error");
            }
            numberTextBox.SelectAll();
        }

        //This is the event handler for the "CLICK" on "LINEAR SEARCH BUTTON"
        private void LinearSearchButton_Click(object sender, EventArgs e)
        {
            double number;
            bool isNumeric = Double.TryParse(numberTextBox.Text, out number);

            numberListBox.SelectedIndex = -1; //Remove any highlighting

            if (isNumeric)
            {
                int indexOfNumber = LinearSearchNum(numberList, number);

                if (indexOfNumber != -1)
                {
                    outputLabel.Text = "'" + number.ToString() + "' was found at index '" + indexOfNumber.ToString() + "'.";
                    numberListBox.SelectedIndex = indexOfNumber;
                }
                else
                {
                    outputLabel.Text = "'" + number.ToString() + "' was not found.";
                }
            }
            else
            {
                MessageBox.Show("You may only enter numbers.", "Error");
            }
            numberTextBox.SelectAll();
        }

        //This is the event handler for the "CLICK" on "MINIMUM BUTTON"
        private void MinButton_Click(object sender, EventArgs e)
        {
            double min = MinimumNum(numberList);
            numberListBox.SelectedIndex = -1; //Removes highlighting off the number

            if (!Double.IsNaN(min)) //Same thing as 'Double.IsNan(min) != true', this is bascially a double negative
                                    //Capital Double checks for the properties of the double "min"
            {
                outputLabel.Text = "The minimum value from the list is " + min.ToString() + "!";
            }
            else
            {
                outputLabel.Text = "The list is empty!";
            }
            int smallestIndex = MinimumIndex(numberList);
            numberListBox.SelectedIndex = smallestIndex;

        }

        //This is the event handler for the "CLICK" on "MAXIMUM BUTTON"
        private void MaxButton_Click(object sender, EventArgs e)
        {
            double max = MaximumNum(numberList);
            numberListBox.SelectedIndex = -1; //Removes highlighting off the number

            if (!Double.IsNaN(max)) //Same thing as 'Double.IsNan(min) != true', this is bascially a double negative
                                    //Capital Double checks for the properties of the double "max"
            {
                outputLabel.Text = "The maximum value from the list is " + max.ToString() + "!";
            }
            else
            {
                outputLabel.Text = "The list is empty!";
            }
            int largestIndex = MaximumIndex(numberList);
            numberListBox.SelectedIndex = largestIndex;

        }

        //This is the event handler for the "CLICK" on "SORT BUTTON"
        private void SortButton_Click(object sender, EventArgs e)
        {
            numberListBox.SelectedIndex = -1; //Remove any highlighting

            numberList = SelectionSort(numberList, AscendingRadioButton.Checked); // Sort "numberList"

            numberListBox.Items.Clear(); // Clear the list box then display the sorted list in the list box

            foreach (double item in numberList)
            {
                numberListBox.Items.Add(item.ToString());
            }
        }

        

        //This is the event handler for the "CLICK" on "MEAN BUTTON"
        private void MeanButton_Click(object sender, EventArgs e)
        {
            double average = MeanAverage(numberList);
            numberListBox.SelectedIndex = -1; //Removes highlighting off the number

            if (!Double.IsNaN(average)) //Same thing as 'Double.IsNan(min) != true', this is bascially a double negative
                                        //Capital Double checks for the properties of the double "max"
            {
                outputLabel.Text = "The mean (average) of the list is " + average.ToString() + "!";
            }
            else
            {
                outputLabel.Text = "The list is empty!";
            }

        }

        //This is the event handler for the "CLICK" on "MEDIAN BUTTON"
        private void MedianButton_Click(object sender, EventArgs e)
        {
            double median = MedianNum(numberList);
            numberListBox.SelectedIndex = -1; //Removes highlighting off the number

            if (!Double.IsNaN(median)) //Same thing as 'Double.IsNan(min) != true', this is bascially a double negative
                                       //Capital Double checks for the properties of the double "max"
            {
                outputLabel.Text = "The median of the list is " + median.ToString() + "!";
            }
            else
            {
                outputLabel.Text = "The list is empty!";
            }

        }

        //This is the event handler for the "CLICK" on "MODE BUTTON"
        private void ModeButton_Click(object sender, EventArgs e)
        {
            numberListBox.SelectedIndex = -1; //Remove any highlighting

            List<double> modeList = DevMode(numberList);

            if (modeList.Count > 1) // Multi-modal
            {
                outputLabel.Text = "The modes are ";
                for (int i = 0; i < modeList.Count; i++)
                {
                    outputLabel.Text += modeList[i].ToString() + ", ";
                }

                // Replace the last comma and space with a period
                outputLabel.Text = outputLabel.Text;
            }
            else if (modeList.Count == 1)
            {
                outputLabel.Text = "The mode is " + modeList[0].ToString() + ".";
            }
            else
            {
                outputLabel.Text = "The list is empty.";
            }
        }

        //This is the event handler for the "CLICK" on "RANDOM BUTTON"
        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random RandomNumberGenerator = new Random();

            int LimitHowMany = RandomNumberGenerator.Next(5, 11);

            numberList.Clear();
            numberListBox.Items.Clear();

            for (int i = 1; i <= LimitHowMany; i++)
            {
                double number = Math.Round(RandomNumberGenerator.NextDouble() * 100 - 50, 2);
                numberList.Add(number);
                numberListBox.Items.Add(number);
            }
        }

        //This is the event handler for the "CLICK" on "CLEAR BUTTON"
        private void ClearButton_Click(object sender, EventArgs e)
        {
            numberList.Clear();
            numberListBox.Items.Clear();
            numberListBox.SelectedIndex = -1; //Remove any highlighting
            outputLabel.Text = "";
        }

        //This is the event handler for the "CLICK" on "SCRAMBLE BUTTON"
        private void ScrambleButton_Click(object sender, EventArgs e)
        {
            numberListBox.SelectedIndex = -1; //Remove any highlighting

            numberList = Scramble(numberList);

            numberListBox.Items.Clear(); // Clear the list box then display the sorted list in the list box

            foreach (double item in numberList)
            {
                numberListBox.Items.Add(item.ToString());
            }
        }

        // Used to ensure that the focus stays on the text box when the button is clicked.
        // Otherwise, the button will have the focus.
        private void SubmitButton_MouseUp(object sender, MouseEventArgs e)
        {
            numberTextBox.SelectAll();
            numberTextBox.Focus();
        }

        /**************************************************************************************************************/
        //EVENT HANDLERS FOR OTHER OPERATIONS & SORTING ALGORITHMS
        /**************************************************************************************************************/
        //Event Handler for "CLICK" on "REVERSE BUTTON"
        private void ReverseButton_Click(object sender, EventArgs e)
        {
            numberListBox.SelectedIndex = -1; //Remove any highlighting

            ReverseList(numberList); 
            numberListBox.Items.Clear(); // Clear the list box then display the sorted list in the list box

            foreach (double item in numberList)
            {
                numberListBox.Items.Add(item.ToString());
            }
        }

        //Event Handler for "CLICK" on "SUM FIRST NUMBERS BUTTON"
        private void SumFirstNumbersButton_Click(object sender, EventArgs e)
        {
            int number;
            bool isNumeric = Int32.TryParse(nValueTextBox.Text, out number);

            numberListBox.SelectedIndex = -1; //Remove any highlighting

            if (number < numberList.Count+1)
            {
                if (isNumeric)
                {
                    double sum = SumFirstNumbers(numberList, number);
                    outputLabel.Text = "The sum of the first " + number.ToString() + " consecutive numbers is " + sum.ToString() + "!";
                }
                else
                {
                    MessageBox.Show("You may only enter numbers.", "Error");
                }
            }
            else
            {
                MessageBox.Show("The number entered exceeds the list size", "Error");
            }
        }

        //Event Handler for "CLICK" on SumNumbersWithStartingPosition BUTTON"
        private void SumNumbersWithStartingPositionButton_Click(object sender, EventArgs e)
        {
            int number;
            int position;
            bool isNumeric = Int32.TryParse(nValueTextBox.Text, out number);
            bool isNumericPosition = Int32.TryParse(xValueTextBox.Text, out position);

            numberListBox.SelectedIndex = -1;

            if (position + number < numberList.Count+2)
            {
                if (isNumeric)
                {
                    double sum = SumNumbersWithStartingPosition(numberList, number, position);
                    outputLabel.Text = "Starting at position " + position.ToString() + ", the sum of " + number.ToString() + " consecutive number(s) is " + sum.ToString() + "!";
                }
                else
                {
                    MessageBox.Show("You may only enter numbers.", "Error");
                }
            }
            else
            {
                MessageBox.Show("The numbers entered exceed the list size", "Error");
            }
        }

        //Event Handler for "CLICK" on "OddIndexedList BUTTON"
        private void OddIndexedListButton_Click(object sender, EventArgs e)
        {
            numberListBox.SelectedIndex = -1; //Remove any highlighting

            numberList = OddIndexedList(numberList); // Sort "numberList"

            numberListBox.Items.Clear(); // Clear the list box then display the sorted list in the list box

            foreach (double item in numberList)
            {
                numberListBox.Items.Add(item.ToString());
            }
        }

        //Event Handler for "CLICK" on "AlternateItemList BUTTON"
        private void AlternateItemListButton_Click(object sender, EventArgs e)
        {
            numberListBox.SelectedIndex = -1; //Remove any highlighting
            numberListBoxTwo.SelectedIndex = -1;

            numberList = AlternateItemList(numberList, numberListTwo);

            numberListTwo.Clear();

            numberListBox.Items.Clear(); // Clear the list box then display the alternate list in the list box
            numberListBoxTwo.Items.Clear();

            foreach (double item in numberList)
            {
                numberListBox.Items.Add(item.ToString());
            }
        }

        //Event Handler for "CLICK" on "MergeSortedListsButton"
        private void MergeSortedListsButton_Click(object sender, EventArgs e)
        {
            numberListBox.SelectedIndex = -1; //Remove any highlighting
            numberListBoxTwo.SelectedIndex = -1;

            numberList = SelectionSort(numberList, true);
            numberListTwo = SelectionSort(numberListTwo, true);

            numberList = AlternateItemList(numberList, numberListTwo);

            numberListTwo.Clear();

            numberListBox.Items.Clear(); // Clear the list box then display the alternate list in the list box
            numberListBoxTwo.Items.Clear();

            foreach (double item in numberList)
            {
                numberListBox.Items.Add(item.ToString());
            }
        }

        #endregion


        //FUNCTIONS
        #region Programmer-Defined Methods

        /**************************************************************************************************************/
        //FUNCTIONS FOR CALCULATOR STUFF
        /**************************************************************************************************************/
        //MINIMUM FUNCTION code starts here
        private static double MinimumNum(List<double> OriginalList)  //private static "what do you want to output" FunctionName(List<type of values in list> ListName)
        {
            if (OriginalList.Count > 0) //if list is not empty
            {

                double smallest = OriginalList[0]; //The double variable "smallest" is declared & initialized.
                                                   //Its initial value is set to the first item in the list "listOfNumbers"

                for (int i = 1; i < OriginalList.Count; i++) //This is a "for loop" (counted loop) in C#
                { //begin loop

                    if (OriginalList[i] < smallest)
                    {
                        smallest = OriginalList[i];
                    }

                } // end loop
                return smallest; //return output value
            }
            else
            {
                return Double.NaN; //shows that the list is empty
            }
        }


        //MINIMUM INDEX FUNCTION code starts here
        private static int MinimumIndex(List<double> OriginalList)  //private static "what do you want to output" FunctionName(List<type of values in list> ListName)
        {
            if (OriginalList.Count > 0) //if list is not empty
            {

                double smallest = OriginalList[0];
                int smallestIndex = 0;

                for (int i = 1; i < OriginalList.Count; i++)
                { //begin loop

                    if (OriginalList[i] < smallest)
                    {
                        smallest = OriginalList[i];
                        smallestIndex = i;
                    }

                } // end loop
                return smallestIndex; //return index of smallest number
            }
            else
            {
                return -1;
            }
        }


        //MAXIMUM FUNCTION code starts here
        private static double MaximumNum(List<double> OriginalList)  //private static "what do you want to output" FunctionName(List<type of values in list> ListName)
        {
            if (OriginalList.Count > 0) //if list is not empty
            {

                double largest = OriginalList[0]; //The double variable "largest" is declared & initialized.
                                                  //Its initial value is set to the first item in the list "listOfNumbers"

                for (int i = 1; i < OriginalList.Count; i++) //This is a "for loop" (counted loop) in C#
                { //begin loop

                    if (OriginalList[i] > largest)
                    {
                        largest = OriginalList[i];
                    }

                } // end loop
                return largest; //return output value
            }
            else
            {
                return Double.NaN; //shows that the list is empty
            }
        }


        //MAXIMUM INDEX FUNCTION code starts here
        private static int MaximumIndex(List<double> OriginalList)  //private static "what do you want to output" FunctionName(List<type of values in list> ListName)
        {
            if (OriginalList.Count > 0) //if list is not empty
            {
                double largest = OriginalList[0];
                int largestIndex = 0;

                for (int i = 1; i < OriginalList.Count; i++) //This is a "for loop" (counted loop) in C#
                { //begin loop

                    if (OriginalList[i] > largest)
                    {
                        largest = OriginalList[i];
                        largestIndex = i;
                    }

                } // end loop
                return largestIndex; //return index of largest number
            }
            else
            {
                return -1; //shows that the list is empty
            }
        }


        //MEAN (AVERAGE) FUNCTION code starts here
        private static double MeanAverage(List<double> OriginalList)  //private static "what do you want to output" FunctionName(List<type of values in list> ListName)
        {
            if (OriginalList.Count > 0) //if list is not empty
            {

                double sum = 0;
                double average = new double();

                for (int i = 0; i < OriginalList.Count; i++) //This is a "for loop" (counted loop) in C#
                { //begin loop
                    sum += OriginalList[i]; // can also do this: sum = sum + OriginalList[i];

                    average = sum / OriginalList.Count;
                }

                return average;             }
            else
            {
                return Double.NaN;
            }
        }


        //MEDIUM FUNCTION code starts here
        private double MedianNum(List<double> OriginalList)
        {
            if (OriginalList.Count > 0)
            {
                List<double> SortedList = new List<double>(SelectionSort(OriginalList, true));

                if (SortedList.Count % 2 == 1) //odd
                {
                    return SortedList[SortedList.Count / 2];
                }
                else //even
                {
                    int UpperMiddle = (SortedList.Count) / 2;
                    return (SortedList[UpperMiddle] + SortedList[UpperMiddle - 1]) / 2;
                }
            }
            else
            {
                return Double.NaN;
            }
        }


        //DEVMODE FUNCTION
        private static List<double> DevMode(List<double> OriginalList)
        {
            Dictionary<double, double> dict = new Dictionary<double, double>();
            List<double> modeList = new List<double>();

            if (OriginalList.Count > 0)
            {
                for (int i = 0; i < OriginalList.Count; i++)
                {
                    if (dict.ContainsKey(OriginalList[i]))
                    {
                        dict[OriginalList[i]]++;
                    }
                    else
                    {
                        dict.Add(OriginalList[i], 1);
                    }
                }
                List<double> frequencyList = dict.Values.ToList();
                int modeFrequency = (int)MaximumNum(frequencyList);

                foreach (KeyValuePair<double, double> item in dict)
                {
                    if (item.Value == modeFrequency)
                    {
                        modeList.Add(item.Key);
                    }
                }
            }
            return modeList;
        }


        //KEVMODE FUNCTION
        private static List<double> KevMode(List<double> OriginalList)
        {
            List<double> modeList = new List<double>();


            if (OriginalList.Count > 0)
            {
                int currentCount = 1;
                int highestCount = 0;

                modeList = SelectionSort(OriginalList, true);

                for (int i = 1; i < OriginalList.Count; i++)
                {
                    if (OriginalList[i] == OriginalList[i - 1])
                    {
                        currentCount++;
                    }
                    else if (currentCount > highestCount)
                    {
                        highestCount = currentCount;
                        modeList.Clear();
                        modeList.Add(OriginalList[i]);
                        currentCount = 1;
                    }
                    else if (currentCount == highestCount)
                    {
                        modeList.Add(OriginalList[i]);
                        currentCount = 1;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                }
            }
            return modeList;

        }


        //MODE FUNCTION code starts here
        /*private static List<double> Mode(List<double> OriginalList)
        {
            List<double> valueList = new List<double>();

            if (OriginalList.Count > 0)
            {
                List<double> sortedList = SelectionSort(OriginalList, true);
                List<double> frequencyList = new List<double>();

                int frequency = 1;

                for (int i = 1; i < sortedList.Count; i++) //Determine the frequency of each distinct value in the list
                {
                    if(sortedList[i-1] == sortedList[i]) //if value before is the same, then frequency++
                    {
                        frequency++;
                    }
                    else // if a new value
                    {
                        valueList.Add(OriginalList[i - 1]);
                        frequencyList.Add(frequency);
                        frequency = 1;
                    }
                }
                valueList.Add(sortedList[sortedList.Count - 1]);
                frequencyList.Add(frequency);

                int maxFrequency = (int)MaximumNum(frequencyList);

                for (int i = frequencyList.Count - 1; i >= 0; i--)
                {
                    if(frequencyList[i] < maxFrequency)
                    {
                        frequencyList.RemoveAt(i); // Remove item at index "i"
                        valueList.RemoveAt(i);
                    }
                }
            }
            return SelectionSort(valueList, true);
        }*/


        //Display List in Listbox
        private void DisplayList(List<double> OriginalList)
        {
            List<double> copyList = new List<double>(OriginalList);
            numberListBox.Items.Clear();
            numberList.Clear();
            numberList = copyList;
            for (int i = 0; i < copyList.Count; i++)
            {
                numberListBox.Items.Add(copyList[i]);
            }
        }


        //BINARY SEARCH FUNCTION code starts here
        private static int BinarySearchNum(List<double> OriginalList, double key)
        {
            if (OriginalList.Count > 0)
            {
                int bottom = 0, top = OriginalList.Count - 1;

                while (bottom <= top)
                {
                    int middle = (bottom + top) / 2;

                    if (key < OriginalList[middle])
                    {
                        top = middle - 1;
                    }
                    else if (key > OriginalList[middle])
                    {
                        bottom = middle + 1;
                    }
                    else
                    {
                        return middle;
                    }
                }
            }
            return -1;
        }


        //LINEAR SEARCH FUNCTION code starts here
        private static int LinearSearchNum(List<double> OriginalList, double key)
        {
            int FoundAtIndex = -1; // If "key" is not found, -1 is returned.
            if (OriginalList.Count > 0)
            {
                for (int i = 0; i < OriginalList.Count; i++)
                {
                    if (OriginalList[i] == key) //Equivalent to if (ascending == true)
                    {
                        FoundAtIndex = i;
                        break; //End loop prematurely
                    }

                }
            }

            return FoundAtIndex;
        }


        //SELECTION SORT FUNCTION code starts here
        private static List<double> SelectionSort(List<double> OriginalList, bool ascending) //private static "what do you want to output" FunctionName(List<type of values in list> ListName, boolean statement
        {
            List<double> SortedList = new List<double>(); //create an empty list: List<type of values> ListName = new List<type of values>(what list of values to input)

            List<double> OriginalListCopy = new List<double>(OriginalList); //Create a copy of 'OriginalListCopy' so that the original list remains unaltered.

            foreach (double number in OriginalList)
            { //start of loop
                double MinOrMax; // declare the variable and what type it is

                if (ascending) // equivalent to if (ascending == true)
                {
                    MinOrMax = MinimumNum(OriginalListCopy);
                }
                else //equivalent to if (!ascending)
                {
                    MinOrMax = MaximumNum(OriginalListCopy);
                }

                SortedList.Add(MinOrMax);
                OriginalListCopy.Remove(MinOrMax);

            } //end of loop
            return SortedList; //returns the final sorted list
        }



        //CocktailSort FUNCTION code starts here
        private static List<double> CocktailSort(List<double> unsortedList)
        {
            List<double> sortedList = new List<double>(unsortedList);
            int start = 0;
            int end = unsortedList.Count - 1;
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;

                for (int i = start; i < end; i++)
                {
                    if (sortedList[i] > sortedList[i + 1])
                    {
                        double copy = sortedList[i];
                        sortedList[i] = sortedList[i + 1];
                        sortedList[i + 1] = copy;
                        sorted = false;
                    }
                }
                end--;

                for (int i = end; i > start; i--)
                {
                    if (sortedList[i] > sortedList[i+1])
                    {
                        double copy = sortedList[i];
                        sortedList[i] = sortedList[i + 1];
                        sortedList[i + 1] = copy;
                        sorted = false;
                    }
                }
                start++;
            }
            return sortedList;
        }




        //Nolfi's way of doing GnomeSort (using "while loop")
        /*List<double> sortedList = new List<double>(listofNumbers);
        double copy = new double();

        int i = 0;

        while (i < sortedList.Count)
        {
            if (i == 0 || sortedList[i] >= sortedList[i - 1])
            {
                i++;
            }
            else
            {
                copy = sortedList[i];
                sortedList[i] = sortedList[i - 1];
                sortedList[i - 1] = copy;

                i--;
            }
        }
        return sortedList;*/


        //My way of doing GnomeSort (using "for loop")
        /*List<double> sortedList = new List<double>(listofNumbers);
        double copy = new double();
        int i = 0;

        if (sortedList.Count > 0)
        {
            for (i = 0; i < sortedList.Count;)
            {
                if (i == 0 || sortedList[i] >= sortedList[i-1])
                {
                    i++;
                }
                else
                {

                    copy = sortedList[i];
                    sortedList[i] = sortedList[i - 1];
                    sortedList[i - 1] = copy;

                    //Ajay's way:
                    //copy = sortedList[i];
                    //sortedList.RemoveAt(i);
                    //sortedList.Insert(i-1, copy);

                    i--;
                }
            }
        }
        return sortedList; */


        //SCRAMBLE FUNCTION code starts here
        private List<double> Scramble(List<double> OriginalList)
        {
            Random randomValue = new Random();
            int randomIndex = new int();
            List<double> scrambleList = new List<double>();

            while (OriginalList.Count != 0)
            {
                randomIndex = randomValue.Next(0, OriginalList.Count);
                scrambleList.Add(OriginalList[randomIndex]);
                OriginalList.RemoveAt(randomIndex);
            }
            return scrambleList;
        }

        /**************************************************************************************************************/
        //FUNCTIONS FOR PROBLEMS
        /**************************************************************************************************************/

        //Problem#1: ReverseList
        private void ReverseList(List<double> OriginalList)
        {
            if (OriginalList.Count > 0)
            {
                int i = 0;
                int repetitions = OriginalList.Count / 2;
                int lastValue = OriginalList.Count - 1; //Set lastValue to the last number in the list

                for (i = 0; i < repetitions; i++)
                {
                    double copyFirst = OriginalList[i];
                    double copyLast = OriginalList[lastValue];
                    OriginalList[i] = copyLast;
                    OriginalList[lastValue] = copyFirst;
                    lastValue--;
                }
            }
        }

        //Problem#2: SumFirstNumbers
        private double SumFirstNumbers(List<double> OriginalList, int n)
        {
            if (OriginalList.Count > 0)
            {
                int i = 0;
                double sum = 0;
                int stopIndex = n - 1;

                for (i = 0; i <= stopIndex; i++)
                {
                    sum += OriginalList[i];
                }
                return sum;
            }
            else
            {
                return Double.NaN;
            }
        }

        //Problem#3: SumNumbersWithStartingPosition
        private double SumNumbersWithStartingPosition(List<double> OriginalList, int n, int x)
        {
            if (OriginalList.Count > 0)
            {
                int i;
                double sum = 0;
                int startIndex = x - 1;
                int stopIndex = startIndex + n;

                for (i = startIndex; i < stopIndex; i++)
                {
                    sum += OriginalList[i];
                }
                return sum;
            }
            else
            {
                return Double.NaN;
            }
        }

        //Problem #4: OddIndexedList
        private List<double> OddIndexedList(List<double> OriginalList)
        {
            List<double> oddIndexedList = new List<double>(OriginalList);

            if (OriginalList.Count > 0)
            {
                int i = 0;
                for (i = 0; i < oddIndexedList.Count; i++)
                {
                    oddIndexedList.RemoveAt(i);
                }
            }
            return oddIndexedList;
        }

        //Problem #5: AlternateItemList
        private List<double> AlternateItemList(List<double> listOne, List<double> listTwo)
        {
            List<double> AlternateList = new List<double>();
            int i = 0;
            int CountOne = listOne.Count;
            int CountTwo = listTwo.Count;
            int finalCount;

            if (CountOne == CountTwo)
            {
                finalCount = CountOne;

                for (i = 0; i < finalCount; i++)
                {
                    AlternateList.Add(listOne[i]);
                    AlternateList.Add(listTwo[i]);
                }
            }
            else if (CountOne > CountTwo)
            {
                finalCount = CountTwo;

                for (i = 0; i < finalCount; i++)
                {
                    AlternateList.Add(listOne[i]);
                    AlternateList.Add(listTwo[i]);
                }
                for (i = finalCount; i < CountOne; i++)
                {
                    AlternateList.Add(listOne[i]);
                }
            }
            else if (CountOne < CountTwo)
            {
                finalCount = CountOne;

                for (i = 0; i < finalCount; i++)
                {
                    AlternateList.Add(listOne[i]);
                    AlternateList.Add(listTwo[i]);
                }
                for (i = finalCount; i < CountTwo; i++)
                {
                    AlternateList.Add(listTwo[i]);
                }
            }

            return AlternateList;
        }

        //Problem #6: MergeSortedLists
        /*private List<double> MergeSortedLists(List<double> listOne, List<double> listTwo)
        {
            int i = 0;
            int CountOne = listOne.Count;
            int CountTwo = listTwo.Count;

            if (CountOne == CountTwo)
            {
                for (i = 0; i < CountOne; i++)
                {
                    if();
                }
            }
            else if (CountOne > CountTwo)
            {

            }
            else if (CountOne < CountTwo)
            {

            }
        }*/

        private static double QuadraticMean(List<double>listOfNumbers)
        {
            if(listOfNumbers.Count == 0)
            {
                return Double.NaN;
            }
            double SumOfSquares = 0;
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                SumOfSquares += Math.Pow(listOfNumbers[i], 2);
            }
            return Math.Sqrt(SumOfSquares / listOfNumbers.Count);
        }


        //SortRecursiveEventHandler
        /*private void SortButton_Click(object sender, EventArgs e)
        {
            numberListBox.SelectedIndex = -1; //Remove any highlighting
            //numberList = BubbleSortRecursive(numberList, numberList.Count);
            //numberList = CocktailSortRecursive(numberList, 0, numberList.Count);
            //numberList = InsertionSortRecursive(numberList, numberList.Count);

            IterativeInsertionSort(testArray);
            PrintArray();
            
            numberListBox.Items.Clear(); // Clear the list box then display the sorted list in the list box

            foreach (double item in numberList)
            {
                numberListBox.Items.Add(item.ToString());
            }
        }*/

        //BubbleSortRecursive
        private static List<double> BubbleSortRecursive(List<double> ScrambledList, int listCount)
        {
            //Base Case
            if (listCount == 1)
            {
                return ScrambledList;
            }

            //First Pass
            for (int i = 0; i < listCount - 1; i++)
            {
                if (ScrambledList[i] > ScrambledList[i + 1])
                {
                    double z = ScrambledList[i];
                    ScrambledList[i] = ScrambledList[i + 1];
                    ScrambledList[i + 1] = z;
                }
            }

            //Recurisve for all other Passes
            return BubbleSortRecursive(ScrambledList, listCount - 1);
        }

        //CocktailSortRecursive
        private static List<double> CocktailSortRecursive(List<double> ScrambledList, int startIndex, int endIndex)
        {
            //Base Case
            if(startIndex == endIndex)
            {
                return ScrambledList;
            }

            //First Forward Pass
            for (int i = 0; i < endIndex - 1; i++)
            {
                if(ScrambledList[i] > ScrambledList[i + 1])
                {
                    double z = ScrambledList[i];
                    ScrambledList[i] = ScrambledList[i + 1];
                    ScrambledList[i + 1] = z;
                }
            }

            //First Backward Pass
            for(int i = endIndex-1; i > startIndex; i--)
            {
                if (ScrambledList[i] < ScrambledList[i - 1])
                {
                    double z = ScrambledList[i];
                    ScrambledList[i] = ScrambledList[i - 1];
                    ScrambledList[i - 1] = z;
                }
            }

            //Recursive for all other Passes
            return CocktailSortRecursive(ScrambledList, startIndex + 1, endIndex - 1);
        }

        //InsertionSortRecursive
        private static List<double> InsertionSortRecursive(List<double> ScrambledList, int endIndex)
        {
            //Base Case
            if(endIndex == 1)
            {
                return ScrambledList;
            }

            //First Pass
            for(int i = 0; i < endIndex - 1; i++)
            {
                if (ScrambledList[i+1] < ScrambledList[i])
                {
                    double z = ScrambledList[i + 1];
                    ScrambledList[i + 1] = ScrambledList[i];
                    ScrambledList[i] = z;
                }
            }

            //Recursive for all other Passes
            return InsertionSortRecursive(ScrambledList, endIndex - 1);
        }

        //IterativeInsertionSort
        private static void IterativeInsertionSort(double[] a)
        {
            for(int i = 1; i< a.Length; i++)
            {
                if(a[i-1]>a[i])
                {
                    Insert(a, i);
                }
            }
        }

        //Insert
        private static void Insert(double[] a, int fromIndex)
        {
            double copy = a[fromIndex];
            int toIndex = 0;

            for(int i = 0; i<fromIndex; i++)
            {
                if(a[fromIndex] < a[i])
                {
                    toIndex = i;
                    break;
                }
            }

            for(int bump = fromIndex; bump > toIndex; bump--)
            {
                a[bump] = a[bump - 1];
            }
            a[toIndex] = copy;
        }

        private double[] testArray = { 2, 5, 4, 3, 9, 10, 8, 20, 15, 17, 14 };
        private void PrintArray()
        {
            foreach (double item in testArray)
            {
                Console.WriteLine(item);
            }
        }

        #endregion


    }// end of class
}// end of namespace
