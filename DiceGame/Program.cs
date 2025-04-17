using System;
using System.IO.Compression;

public class Program{
    public static void Main(){
        Console.WriteLine("Lets start the game");
        Console.WriteLine("Rolling die");
        Die computerDie = new Die();
        int computerResult = computerDie.rollDie();
        Console.WriteLine("Computer result is: " + computerResult);

        Player playerDie = new Player();
        int personResult = playerDie.playerResult();
        Console.WriteLine("Player result: " + personResult);
    }
}
