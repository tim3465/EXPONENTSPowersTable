
int userInput;

string anser = "n";
do
{
    bool valid = false;
    do
    {
        Console.Write("Learn your squares and cubes!\n" +
        "Enter an interger: ");
        userInput = int.Parse(Console.ReadLine());
        if (userInput <= 0)
        {
            Console.WriteLine("Sorry no negative numbers or 0, please try again\n ");
            valid = false;
        }
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

    Console.WriteLine("{0,-10}{1,-10}{2,-13}", "Numbers", "Squared", "Cubed");
    for (int i = 1; i <= userInput; i++)
    {
        Console.WriteLine(String.Format("{0,-10}{1,-10}{2,-13}", (i), Squared(i),Cubed(i)));
    }
    Console.WriteLine();

    Console.Write("Continue? (y/n):");
    anser = Console.ReadLine().ToLower().Trim();


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
