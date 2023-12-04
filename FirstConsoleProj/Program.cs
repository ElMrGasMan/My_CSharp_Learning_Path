// Apretar F11 y F10 para hacer Step In y Step Out en el debuggin. 

Console.WriteLine("Hey, it's nice to see you.");
Console.WriteLine("Wait, whats happening?...");

Console.WriteLine(ChangeColor());

string ChangeColor() 
{
    Console.ForegroundColor = ConsoleColor.Green;
    return "I have just changed the entire color of the letters! I'm ready to make an app to rival" +
        " Instagram.";
}