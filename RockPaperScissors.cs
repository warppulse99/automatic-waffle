using System;

class RockPaperScissors {
    static void Main() {
        string[] choices = { "Rock", "Paper", "Scissors" };
        Random rand = new Random();

        Console.Write("✊✋✌️ Choose (Rock, Paper, Scissors): ");
        string playerChoice = Console.ReadLine();
        string computerChoice = choices[rand.Next(0, 3)];

        Console.WriteLine($"🤖 Computer chose: {computerChoice}");

        if (playerChoice == computerChoice) Console.WriteLine("🔄 It's a tie!");
        else if ((playerChoice == "Rock" && computerChoice == "Scissors") ||
                 (playerChoice == "Paper" && computerChoice == "Rock") ||
                 (playerChoice == "Scissors" && computerChoice == "Paper"))
            Console.WriteLine("🎉 You win!");
        else
            Console.WriteLine("😢 You lose!");
    }
}
