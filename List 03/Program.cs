using System;
using System.Globalization;
using System.Runtime.CompilerServices;

//Exercise 1
//class Program
//{
//    static void Main()
//    {
//        Random rand = new Random();
//        int[] integers = new int[15];

//        for (int i = 0; i < integers.Length; i++)
//        {
//            integers[i] = rand.Next(10, 91);  

//        }
//        Console.WriteLine("Numbers: " + string.Join(", ", integers));

//        bool foundInteger = false;
//        for (int i = 0; i < integers.Length; i++)
//        {
//            if (integers[i] == 50)
//            {
//                foundInteger = true; 
//                break;
//            }

//        }
//        Console.WriteLine(foundInteger ? "Found Integer" : "Didn't Find Integer");

//        int countto50 = 0;
//        for (int i = 0; i < integers.Length; i++)
//        {
//            if (integers[i] == 50) 
//                countto50++;
//        }
//        Console.WriteLine("Number of times 50 appears:" + countto50);

//        int sumofIntegers = 0;
//        int averageofIntegers = 0;
//        for (int i = 0; i < integers.Length; i++)
//        {
//            sumofIntegers += integers[i];
//        }
//        averageofIntegers = sumofIntegers / integers.Length;
//        Console.WriteLine("Average of the Integers:" + averageofIntegers);

//        int majorant = integers[0];
//        int minorant = integers[0];
//        for (int i = 1; i < integers.Length; i++)
//        {
//            if (integers[i] > majorant) majorant = integers[i];
//            if (integers[i] < minorant) minorant = integers[i];
//        }
//        Console.WriteLine("The Majorant is: " + majorant + " and the Minorant is: " + minorant);

//        int overallSum = 0;
//        long overallProduct = 1;
//        for (int i = 0; i < integers.Length; i++)
//        {
//            overallSum += integers[i];
//            overallProduct *= integers[i];
//        }
//        Console.WriteLine("The Sum of the Integers is: " + overallSum + " and the Product of them all is: " + overallProduct);

//        for (int i = integers.Length - 1; i >= 0; i--)
//        {
//            Console.Write(integers[i]);
//            if (i > 0) Console.Write(", ");
//        }
//        Console.WriteLine();

//        int[] reverseArray = new int[integers.Length];
//        for (int i = 0; i < integers.Length; i++)
//        {
//            reverseArray[i] = integers[integers.Length - 1 - i];
//        }
//        Console.WriteLine("The reversed array is: " + string.Join(", ", reverseArray));

//        int evenNumCount = 0, oddNumCount = 0;
//        for (int i = 0; i < integers.Length; i++)
//        {
//            if (integers[i] % 2 == 0)
//                evenNumCount++;
//            else
//                oddNumCount++;
//        }

//        int[] evenNumbers = new int[evenNumCount];
//        int[] oddNumbers = new int[oddNumCount];

//        int evenIndex = 0, oddIndex = 0;
//        for (int i = 0; i < integers.Length; i++)
//        {
//            if (integers[i] % 2 == 0)
//                evenNumbers[evenIndex++] = integers[i];
//            else
//                oddNumbers[oddIndex++] = integers[i];
//        }

//        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
//        Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));

//    }
//}


//Exercise 2
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Number of values: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] numbersGenerated = new int[n];

//        Console.WriteLine("Enter the values:");
//        for (int i = 0; i < n; i++)
//        {
//            numbersGenerated[i] = int.Parse(Console.ReadLine());
//        }

//        Console.Write("Result: ");
//        for (int i = 0; i < n; i++)
//        {
//            int product = numbersGenerated[i] * i;
//            Console.Write(product + " ");
//        }

//        Console.WriteLine();
//    }
//}


//Exercise 3
//class Program
//{
//    static void Main()
//    {

//        Console.Write("Number of throws: ");    //Ask for the number of throws
//        int N = int.Parse(Console.ReadLine());

//        int[] throws = new int[20];             //Create an array with 20 positions to count each face

//        Random rand = new Random();

//        for (int i = 0; i < N; i++)             //Simulate N throws
//        {
//            int face = rand.Next(1, 21);        // random number between 1 and 20
//            throws[face - 1]++;                 // increment the count for that face
//        }

//        Console.WriteLine("\nResults:");        //Print the result
//        for (int i = 0; i < 20; i++)
//        {
//            int faceNumber = i + 1;             // convert index from 0 to 19 to face 1..20
//            double percentage = (double)throws[i] / N * 100;
//            Console.WriteLine($"Face {faceNumber}: {throws[i]} ({percentage:F2}%)");
//        }
//    }
//}


//Exercise 4
//class Program
//{
//    static void Main()
//    {
//        int[,] matrix4x4 = new int[4, 4];
//        Console.WriteLine("Enter 16 integers (row by row):");

//        for (int i = 0; i < 4; i++)              // Read the integers in the rows
//        {
//            for (int j = 0; j < 4; j++)          // Read the integers in the columns
//            {
//                matrix4x4[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        int totalSum = 0;
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                totalSum += matrix4x4[i, j];        //Sum of all integers
//            }
//        }
//        Console.WriteLine("Total sumof integers is: " + totalSum);

//        int sumSecondRow = 0;
//        for (int j = 0; j < 4; j++)
//        {
//            sumSecondRow += matrix4x4[1, j];        //Sum of the integers in the second row
//        }
//        Console.WriteLine("Sum of integers on second row is: " + sumSecondRow);

//        int sumThirdColumn = 0;
//        for (int i = 0; i < 4; i++)
//        {
//            sumThirdColumn += matrix4x4[i, 2];      //Sum of the elements in the third column (column index 2)
//        }
//        Console.WriteLine("Sum of integers on third column is: " + sumThirdColumn);

//        Console.Write("Main diagonal elements: ");
//        for (int i = 0; i < 4; i++)
//        {
//            Console.Write(matrix4x4[i, i] + " ");   //Main diagonal elements (i == j)
//        }
//        Console.WriteLine();

//        Console.Write("Secondary diagonal elements: ");
//        for (int i = 0; i < 4; i++)
//        {
//            int j = 3 - i;                          // opposite column
//            Console.Write(matrix4x4[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//}


//Exercise 5
//class Program
//{
//    static void Main()
//    {

//        Console.Write("Enter matrix size n (n >= 1): ");
//        int dimensions = int.Parse(Console.ReadLine());                      //Enter the size of the matrix

//        if (dimensions < 1)
//        {
//            Console.WriteLine("Matrix size must be at least 1.");
//            return;
//        }

//        int[,] matrix = new int[dimensions, dimensions];

//        Console.WriteLine($"Enter {dimensions * dimensions} integers (row by row):");
//        for (int i = 0; i < dimensions; i++)
//        {
//            for (int j = 0; j < dimensions; j++)
//            {
//                matrix[i, j] = int.Parse(Console.ReadLine());               //Read the matrix's integers according to the dimension previously determined
//            }
//        }

//        int standardSum = 0;
//        for (int j = 0; j < dimensions; j++)
//        {
//            standardSum += matrix[0, j];                                    //Make the first row the 'standard' for the other sums
//        }

//        bool isMagical = true;

//        for (int i = 0; i < dimensions; i++)                                //Verifi the sums of all rows
//        {
//            int rowSum = 0;
//            for (int j = 0; j < dimensions; j++)
//                rowSum += matrix[i, j];

//            if (rowSum != standardSum)
//            {
//                isMagical = false;
//                break;
//            }
//        }

//        if (isMagical)
//        {
//            for (int j = 0; j < dimensions; j++)                            //Verify the sums of all columns
//            {
//                int colSum = 0;
//                for (int i = 0; i < dimensions; i++)
//                    colSum += matrix[i, j];

//                if (colSum != standardSum)
//                {
//                    isMagical = false;
//                    break;
//                }
//            }
//        }

//        if (isMagical)
//        {
//            int mainDiagonalSum = 0;
//            for (int i = 0; i < dimensions; i++)                            //Verify the sum of the main diagonal
//                mainDiagonalSum += matrix[i, i];

//            if (mainDiagonalSum != standardSum)
//                isMagical = false;
//        }


//        if (isMagical)
//        {
//            int secondaryDiagonalSum = 0;
//            for (int i = 0; i < dimensions; i++)                            //Verify the sum of the secondary diagonal
//                secondaryDiagonalSum += matrix[i, dimensions - 1 - i];

//            if (secondaryDiagonalSum != standardSum)
//                isMagical = false;
//        }

//        if (dimensions == 1)                                                //Make the exception for when the matrix has dimension 1
//            isMagical = true;

//        if (isMagical)                                                      //Tell the result
//            Console.WriteLine("Magic square");
//        else
//            Console.WriteLine("Not a magic square");
//    }
//}

//SECOND PART OF LIST_03

//Exercise 1
//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int>(); //Makes the list a dynamic list with changeable metrics
//        bool running = true;                 //Makes the program keep running upon selecting an option

//        while (running)
//        {
//            Console.WriteLine("\n--- Integer List Menu ---");
//            Console.WriteLine("1) Add an integer to the list");
//            Console.WriteLine("2) Remove an integer from the list");
//            Console.WriteLine("3) Remove an integer by its position form the list");
//            Console.WriteLine("4) Print the integers from the list");                                                 //This is the display menu where all of the options that are available will show
//            Console.WriteLine("5) Print the integers from the list in reverse order");
//            Console.WriteLine("6) Print the number of integers on the list");
//            Console.WriteLine("7) Clear all elements on the list");
//            Console.WriteLine("8) Exit");
//            Console.Write("Choose an option from 1 to 8: ");


//            string choiceInput = Console.ReadLine();
//            int choice;

//            if (!int.TryParse(choiceInput, out choice))
//            {
//                Console.WriteLine("Invalid input! Please choose a number between 1 and 8.");
//                continue; //Restart the loop
//            }

//            Console.WriteLine(); // blank line for readability

//            switch (choice)
//            {
//                case 1:

//                    Console.Write("Enter a number to add: ");
//                    string addInput = Console.ReadLine();
//                    int addValue;

//                    if (int.TryParse(addInput, out addValue))
//                    {
//                        numbers.Add(addValue);
//                        Console.WriteLine($"{addValue} added to the list.");                                        //Add an integer to the list
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid number!");
//                    }
//                    break;

//                case 2:

//                    Console.Write("Enter an integer to remove: ");
//                    string removeInput = Console.ReadLine();
//                    int removeValue;

//                    if (int.TryParse(removeInput, out removeValue))
//                    {
//                        if (numbers.Remove(removeValue))
//                        {
//                            Console.WriteLine($"{removeValue} removed from the list.");                             //Remove an integer from the list via value
//                        }
//                        else
//                        {
//                            Console.WriteLine("Number not found in the list.");
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid number!");
//                    }
//                    break;

//                case 3:

//                    Console.Write("Enter the position (0-based index) to remove the integer: ");                    //Remove by position (index)
//                    string posInput = Console.ReadLine();
//                    int position;

//                    if (int.TryParse(posInput, out position))
//                    {
//                        if (position >= 0 && position < numbers.Count)
//                        {
//                            int removed = numbers[position];
//                            numbers.RemoveAt(position);
//                            Console.WriteLine($"Integer {removed} at position {position} removed.");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Invalid position! Out of range.");
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid number!");
//                    }
//                    break;

//                case 4:

//                    if (numbers.Count == 0)
//                        Console.WriteLine("The list is empty.");
//                    else
//                        Console.WriteLine("List integers: " + string.Join(", ", numbers));                          //Print list
//                    break;

//                case 5:

//                    if (numbers.Count == 0)
//                    {
//                        Console.WriteLine("The list is empty.");
//                    }
//                    else
//                    {
//                        Console.WriteLine("List in reverse order:");                                                //Print list in reverse
//                        for (int i = numbers.Count - 1; i >= 0; i--)
//                            Console.Write(numbers[i] + (i > 0 ? ", " : "\n"));
//                    }
//                    break;

//                case 6:

//                    Console.WriteLine($"The list has {numbers.Count} integer(s).");                                 //Print the number of elements
//                    break;

//                case 7:

//                    numbers.Clear();
//                    Console.WriteLine("All integers have been removed from the list.");                             //Clear the list
//                    break;

//                case 8:

//                    Console.WriteLine("Exiting program. Goodbye!");                                                 //Exit from the displayed menu
//                    running = false;
//                    break;

//                default:
//                    Console.WriteLine("Invalid choice! Please select a number between 1 and 8.");
//                    break;
//            }
//        }
//    }
//}

//Exercise 2
//class Program
//{
//    static void Main()
//    {
//        Stack<int> stack = new Stack<int>();                                                            //Makes the stack dynamic with changeable metrics
//        bool running = true;

//        while (running)
//        {
            
//            Console.WriteLine("\n--- Stack Menu ---");
//            Console.WriteLine("1) Push a number");
//            Console.WriteLine("2) Pop a number");
//            Console.WriteLine("3) Peek (show top)");                                                    //This is the display menu where all of the options that are available will show
//            Console.WriteLine("4) Clear the stack");
//            Console.WriteLine("5) Exit");
//            Console.Write("Choose an option (1-5): ");

//            string choiceInput = Console.ReadLine();
//            int choice;
//            if (!int.TryParse(choiceInput, out choice))
//            {
//                Console.WriteLine("Invalid input! Please enter a number between 1 and 5.");
//                continue;
//            }

//            Console.WriteLine();

//            switch (choice)
//            {
//                case 1:
                    
//                    Console.Write("Enter a number to push: ");
//                    string pushInput = Console.ReadLine();
//                    int value;
//                    if (int.TryParse(pushInput, out value))
//                    {
//                        stack.Push(value);
//                        Console.WriteLine($"Number {value} pushed onto the stack.");                    //Push an integer onto the stack
//                        Console.WriteLine($"Stack size: {stack.Count}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid number!");
//                    }
//                    break;

//                case 2:
                    
//                    if (stack.Count > 0)
//                    {
//                        int popped = stack.Pop();
//                        Console.WriteLine($"Number {popped} popped from the stack.");                   //Pop (delete) an integer from the stack
//                        Console.WriteLine($"Stack size: {stack.Count}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Stack is empty. Cannot pop.");
//                    }
//                    break;

//                case 3:
                    
//                    if (stack.Count > 0)
//                    {
//                        int top = stack.Peek();
//                        Console.WriteLine($"Top element: {top}");                                       //Peek (print) into the stack
//                        Console.WriteLine($"Stack size: {stack.Count}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Stack is empty. Nothing to peek.");
//                    }
//                    break;

//                case 4:
                    
//                    stack.Clear();
//                    Console.WriteLine("Stack cleared.");                                                //Clear (delete) the stack
//                    break;

//                case 5:
                    
//                    Console.WriteLine("Exiting program. Goodbye!");                                     //Exit from the displayed menu
//                    running = false;
//                    break;

//                default:
//                    Console.WriteLine("Invalid choice! Please select between 1 and 5.");
//                    break;
//            }
//        }
//    }
//}

//I was able to use Console.WriteLine($"blahblah {blah} blahblah"); and not Console.WriteLine("blahblah " + blah + " blahblah"); in order to make the code appear cleaner than before.