using System;

public class Player{
    public string name = "";
    public int wins = 0;
    public int losses = 0;

    public int playerResult(){
        Die playerDie = new Die();
        int playerResult = playerDie.rollDie();
        return playerResult;
    }

    public string playerName(){
        name = Console.ReadLine();
        return name;
    }
}