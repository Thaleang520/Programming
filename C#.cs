class Program{
    static void Main(){
        Console.BackgroundColor = (ConsoleColor)5; 
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine("Hello C#!");
        Console.ReadKey(true);
        Console.ResetColor();
    }
}