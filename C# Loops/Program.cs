// For Loop
/*
string myString = "Hi \nHi";
for (int counter = 0; counter < 10; counter++)
{
    //Console.WriteLine(counter);
    Console.WriteLine(myString);
    // Thread.sleep causes a delay
    Thread.Sleep(1000);
}

// Countdown For loop

for (int i= 10; i >= 0;  i--)
{
    //Console.WriteLine(i);
}

*/
/*
// Rocket landing in console
string rocketString = "   /\\  \n   ||  \n   ||  \n   ||  \n   ||  \n  /  \\";
string newLines = "";

for (int i = 0; i < 10; i++)
{
    // Add a new line to the top
    newLines = "\n" + newLines;

    // Clear the console
    Console.Clear();

    // Redraw the new lines and the rocket
    Console.WriteLine(newLines + rocketString);

    // Pause for 1 second
    Thread.Sleep(1000);
}


//Console.WriteLine("The rocket has landed");
*/


// The While loop

/*
Console.WriteLine("Go or Stay");

string userChoice = Console.ReadLine();


while (userChoice == "go")
{
    Console.WriteLine("You said go");
    userChoice = Console.ReadLine();
    
}

Console.WriteLine("You didnt say go");

*/

/*

Random random = new Random();

int secretNumber = random.Next(20);
Console.WriteLine(secretNumber);
int userInput = 0;
int guessAmount = 10;

while (userInput != secretNumber && guessAmount > 1)
{
    Console.WriteLine("Please guess a number between 0 and 20");
    userInput = int.Parse(Console.ReadLine());
    guessAmount--;
    Thread.Sleep(1000);
    if (userInput < secretNumber)
    {
        Console.WriteLine("Your guess was too low, try again");
    }
    else if (userInput > guessAmount)
    {
        
        Console.WriteLine("Your guess was too high, try again");
        
    }
    else
    {
        Console.WriteLine("You guessed correctly");
    }
}
   
*/

// Adventure Game

/*
Console.WriteLine("Welcome to your Adventure Game!");
Console.WriteLine("Please enter your characters name: ");
string playerName = Console.ReadLine();
Console.WriteLine("Choose your characters class: (Warrior, Wizard or Ranger)");
string playerClass = Console.ReadLine();

Console.WriteLine($"You, {playerName} the {playerClass} find yourself at the edge of a very dark forest ");
Console.WriteLine("Do you want to be brave and enter the forest or do you want to camp on the edge (Enter/Camp)");
 
string choice1 = Console.ReadLine();

if (choice1.ToLower() == "enter")
{
    Console.WriteLine("You bravely, or perhaps stupidly, enter the forest");
}
else
{
    Console.WriteLine("You decide to camp out and wait for daylight");
}

bool gameContinues = true;

while (gameContinues)
{
    Console.WriteLine("You see two paths in the trees, do you go left or right");
    string direction = Console.ReadLine();
    if(direction.ToLower() == "left")
    {
        Console.WriteLine("You find a treasure chest");
        gameContinues = false;
    }
    else
    {
        Console.WriteLine("You see a wild beast in front of you with 3 heads");
        Console.WriteLine("Do you fight or flee (fight/flee)");
        string fightChoice = Console.ReadLine();
        if (fightChoice.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);
            if (luck >5)
            {
                Console.WriteLine("You beat the wild beast, it lays dead on its back");
                if (luck > 8)
                {
                    Console.WriteLine("The wild beast dropped the treasure");
                }
            }
            else
            {
                Console.WriteLine("You get bitten in half by the beast");
                gameContinues = false;
            }
        }
    }
}

Console.WriteLine("GAME OVER!!!");
*/

// Do While loop

/*
using System.Security.Cryptography.X509Certificates;

int overallScore = 0;
int currentScore = 0;
int counter = 0;
float average = 0;
do
{
    Console.WriteLine("Enter your students score. Enter 0 to finish");
    currentScore = int.Parse(Console.ReadLine());
    if (currentScore != 0)
    {
        counter++;
        overallScore += currentScore;
        Console.WriteLine($"Overall score is {overallScore}");
        Thread.Sleep(1000);
    }
} while (currentScore != 0);

average = overallScore / counter;

Console.WriteLine($"Your average score was {average}");
 */

// Break and Continue

/*
for (int i = 0; i < 4; i++)
{
    Console.WriteLine(i);
    if (i == 2)
    {
        //Console.WriteLine("I is 3");
        continue;
    }
    Console.WriteLine(i);
}

{

}
    
*/

// Simple Array
/*
int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;
int num5 = 0;

int[] myIntArray = [5,12,13,14,15];

string[] daysOfWeek = ["mon", "tue", "wed", "thur", "Fri", "Sat", "Sun"];

// For each loop

foreach (string day in daysOfWeek)
{
    //Console.WriteLine(day);
}

// Two Dimensional Array

string[,] ticTacToeField =
{
   { "O", "X", "X" },
   { "0", "O", "X" },
   { "X", "X", "O" }
};

Console.WriteLine(ticTacToeField[1,2]);
// [0] [0] [0] 
// [0] [0] [0] 
// [0] [0] [0] 

int[,] array2DInitialising = { {1,2}, {3,4} };
// [1] [2]
// [3] [4]

string[] newArray =
{
    "cheese", "chicken", "curry"
};

/ /Console.WriteLine(newArray[0]);
int[,,] array3DDecleartion = new int[3, 3, 3];
*/

int[,] newArray =
{
    {1, 2, 3 },
    {4, 5, 6 },
    {7, 8, 9 }
};

int sum1 = newArray[0,0] + newArray[0,1] + newArray[0,2];
int sum2 = newArray[1,0] + newArray[1,1] + newArray[1,2];
int sum3 = newArray[2,0] + newArray[2,1] + newArray[2,2];

Console.WriteLine(sum1);
Console.WriteLine(sum2);
Console.WriteLine(sum3);