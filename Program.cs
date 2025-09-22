//Exercise 1

//Create a recursive function that gets a positive integer N and prints every natural numbers from 0 until reaching the number N in ascending order.

//int x = 0;

//void NaturalNumberUntilN(int n)
//{
//    if (x <= n)
//    {
//        Console.WriteLine(x);
//        x++;
//        NaturalNumberUntilN(n);
//    }
//    else
//        x = 0;
//}

//NaturalNumberUntilN(25);


//Exercise 2

//Create a recursive function that adds all the numbers inside the array and displayes the result.

//int[] x = [1, 2, 3, 5, 7, 11, 13, 17, 19];
//int y = 0;
//int i = 0;

//void AddingNumbersArray(int[] x)
//{
//    if (i <= (x.Length - 1))
//    {
//        y += x[i];
//        i++;
//        AddingNumbersArray(x);
//    }
//    else
//        Console.WriteLine(y);
//}

//AddingNumbersArray(x);


//Exercise 3

//Create a recursive function that receives a positive integer N and adds all the numbers together from 1 until reaching N.

//int x = 1;
//int y = 0;

//void AdditionofNumbersUntilN(int n)
//{
//    if (x <= n)
//    {
//        y += x;
//        x++;
//        AdditionofNumbersUntilN(n);
//    }
//    else
//        Console.WriteLine(y);
//}

//AdditionofNumbersUntilN(25);


//Exercise 4

//Create a recursive function that turns a string around. Should the word put in be "GameDevelopment", the word coming out would be "tnempoleveDemaG".

//int x = -2;
//string drow = "";

//void WordInverter(string word)
//{
//    if (x == -2)
//    {
//        x = word.Length - 1;
//        WordInverter(word);
//    }
//    else if (x >= 0)
//    {
//        drow = drow + word[x];
//        x--;
//        WordInverter(word);
//    }
//    else
//        Console.WriteLine(drow);
//}

//WordInverter("GameDevelopment");


//Exercise 5

//Create a recursive function that receives a positive integer N and gives the factorial of that number.

//int x = 1;
//int i = 1;
//void FactorialFunction(int n)
//{
//    if (x <= n)
//    {
//        i *= x;
//        x++;
//        FactorialFunction(n);
//    }
//    else
//        Console.WriteLine(i);
//}

//FactorialFunction(7);


//Exercise 6

//The superfactorial of a number N is defined by the product of the first N factorials of N. Thus, the superfactorial of 4 is sf (4) = 1! * 2! * 3! * 4! = 288
//Use previous recursive factorial function to implement this one.

//int x = 1;
//int i = 1
//int j = 1;
//void SuperFacorialFunction(int n)
//{
//    if (i <= n)
//    {
//        if (x <= i)
//        {
//            j *= x;
//            x++;
//            SuperFacorialFunction(n);
//        }
//        else
//        {
//            x = 1;
//            i++;
//            SuperFacorialFunction(n);
//        }
//    }
//    else
//        Console.WriteLine(j);
//}

//SuperFacorialFunction(7);


//Exercise 7

//Tetranacci numbers start with four predetermined terms and from there all other numbers are obtained by summing the previous four numbers.
//The first tetranacci numbers are: 0, 0, 0, 1, 1, 2,
//4, 8, 15, 29, 56, 108, 208... Create a recursive function that receives a number N and returns the Nth term in the tetranacci sequence.

//int[] x = [0, 0, 0, 1];
//int i = 0;
//int y = 0;


//void TetranacciFunction(int n)
//{
//    if ((i + 1) <= (n - 4))
//    {
//        y = x[i] + x[i + 1] + x[i + 2] + x[i + 3];
//        x = x.Append(y).ToArray();
//        i++;
//        TetranacciFunction(n);
//    }
//    else
//        Console.WriteLine(y);
//}

//TetranacciFunction(25);


//Exercise 8

//Write a recursive function that adds all of the n cubes: S(n) = 1³ +2³ +... +n³

//int x = 1;
//int i = 0;

//void AdditiveCubes(int n)
//{
//    if (x <= n)
//    {
//        i += (int)Math.Pow(x, 3);
//        x++;
//        AdditiveCubes(n);
//    }
//    else
//        Console.WriteLine(i);
//}

//AdditiveCubes(7);


//Exercise 9

//Write a recursive function that adds the digits of a number. Should the number be 123, the outcome should be 1+2+3 = 6.

//int x = 0;

//void AdditionDigits(int n)
//{
//    if (n > 0)
//    {
//        x += (n % 10);
//        n = n / 10;
//        AdditionDigits(n);
//    }
//    else
//        Console.WriteLine(x);
//}

//AdditionDigits(18032002);


//Exercise 10

// Pell numbers are defined by the following recursion:

//P0 = 0,
//P1 = 1,
//Pn = 2Pn-1 + Pn-2.

//Some numbers in this sequence are: 0, 1, 2, 5, 12, 29, 70, 169, 408, 985... Create a recursive function that receives a number N and returns the Nth Pell number.

//int[] x = [0, 1];
//int i = 2;

//void PellNumbersFunction(int n)
//{
//    if (n > 1)
//    {
//        if (i <= n)
//        {
//            x = x.Append(2 * x[i - 1] + x[i - 2]).ToArray();
//            i++;
//            PellNumbersFunction(n);
//        }
//        else
//            Console.WriteLine(x[n]);
//    }
//    else
//        Console.WriteLine(n);
//}

//PellNumbersFunction(15);