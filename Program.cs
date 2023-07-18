
int userInput;

string anser = "n";
do
{
    bool valid = false;
    do
    {
        //Getting input from the user 
        Console.Clear();
        Console.Write("Learn your squares and cubes!\n" +
        "Enter an interger: ");
        userInput = int.Parse(Console.ReadLine());
        if (userInput <= 0)
        {
            Console.WriteLine("Sorry no negative numbers or 0, please try again\n ");
            valid = false;
        }
        //It is important not to go above 1290 because when cubed it will cause the integer to overflow 
        else if (userInput > 1290)
        {
            Console.WriteLine("number is too high, please try again\n ");
            valid = false;
        }
        else
        {
            valid = true;
        }
    } while (!valid);
    //Displays the results of each method 
    Console.WriteLine("{0,-10}{1,-10}{2,-13}", "Numbers", "Squared", "Cubed");
    for (int i = 1; i <= userInput; i++)
    {
        Console.WriteLine(String.Format("{0,-10}{1,-10}{2,-13}", (i), Squared(i),Cubed(i)));
    }
    Console.WriteLine();
    //Ask the user whether he or she wishes to continue 
    while (true)  
    {
        Console.Write("Continue? (y/n):");
        anser = Console.ReadLine().ToLower().Trim();
        if (anser=="y"||anser=="n")
        {
            break;
        }
        else
        {
            Console.WriteLine("\nInvalid entry please try again.");
        }
    }

} while (anser == "y");

//Methods
static int Squared(int number)
{
    return number * number;
}
static int Cubed(int number)
{
    return number * number*number;
}
