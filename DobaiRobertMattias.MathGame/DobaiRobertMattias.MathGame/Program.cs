using Math_Game;

Console.WriteLine("Hello!");
Console.WriteLine("What's your name?");
var name = Console.ReadLine();
var date = DateTime.Now;
Console.WriteLine($"Today is {date}\n");

Console.WriteLine("------------------------WELCOME TO THE MATH GAME------------------------");
Console.WriteLine($"Are you ready, {name} ????????? Y/N");
var choice = Console.ReadLine();
choice = choice.ToUpper();

if(choice == "Y")
{
    Console.WriteLine("Okay, good");
    Game obj = new Game();
    obj.GameStart();
}
