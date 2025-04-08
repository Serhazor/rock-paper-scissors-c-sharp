using System;

public class Program{
    public static void Main(){

        string player = GetPlayersChoice();
        string computer = GetComputerChoice();
        DetermineWinner(player, computer);
    }

    static int wins = 0;
    static int loses = 0;

    static string GetPlayersChoice(){
        //here I want to ask player for a choice of either rock, paper of scissors, also validate the answer
        Console.WriteLine("Please enter your choice (rock, paper, scissors): ");
        string player = Console.ReadLine().ToLower();
        return player;
    }

    static string GetComputerChoice(){
        //in this part I want script to generate a random number from 1 to 3 and depending on the number assign the value
        Random rand = new Random();
        int secret = rand.Next(0,3);
        string computer = "";
        if(secret == 1){
            computer = "rock";
            return computer;
        }
        else if(secret == 2){
            computer = "paper";
            return computer;
        }
        else{
            computer = "scissors";
            return computer;
        }
    }

    static void DetermineWinner(string player, string computer){
        //rules: rock beats scissors
        //scissors beat paper
        //paper beats rock
        if(player == computer){
            Console.WriteLine("Its a draw, nobody's a looser (or a winner... Nobody is anything here...)");
            AskToPlayAgain();
        }
        else if (player == "rock" && computer == "scissors"){
            Console.WriteLine("Congratulations, player. You won this one!");
            wins++;
            Console.WriteLine("Your total wins: " + wins);
            Console.WriteLine("Your total loses: " + loses);
            AskToPlayAgain();
        }
        else if (player == "rock" && computer == "paper"){
            Console.WriteLine("Pathethic human, you lost! No surprise there. LOL");
            loses++;
            Console.WriteLine("Your total wins: " + wins);
            Console.WriteLine("Your total loses: " + loses);
            AskToPlayAgain();
        }
        else if (player == "scissors" && computer == "rock"){
            Console.WriteLine("Pathethic human, you lost! No surprise there. LOL");
            loses++;
            Console.WriteLine("Your total wins: " + wins);
            Console.WriteLine("Your total loses: " + loses);
            AskToPlayAgain();
        }
        else if (player == "scissors" && computer == "paper"){
            Console.WriteLine("You only won cause I let you.");
            wins++;
            Console.WriteLine("Your total wins: " + wins);
            Console.WriteLine("Your total loses: " + loses);
            AskToPlayAgain();
        }
        else if (player == "paper" && computer == "rock"){
            Console.WriteLine("Its not a pattern, its just an accident - you won");
            wins++;
            Console.WriteLine("Your total wins: " + wins);
            Console.WriteLine("Your total loses: " + loses);
            AskToPlayAgain();
        }
        else if (player == "paper" && computer == "scissors"){
            Console.WriteLine("Just as I expected, you lost - I won, mwhahahaha...");
            loses++;
            Console.WriteLine("Your total wins: " + wins);
            Console.WriteLine("Your total loses: " + loses);
            AskToPlayAgain();
        }
    }

    static string AskToPlayAgain(){
        Console.WriteLine("Play again? y/n");
        string playAgain = Console.ReadLine().ToLower();
        if (playAgain == "y"){
            GetPlayersChoice();
        }
    }
}