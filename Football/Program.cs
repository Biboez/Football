using Football;

// Creating players
    FootballPlayer player1 = new FootballPlayer("John Doe", 25, 7, 180.5);
    FootballPlayer player2 = new FootballPlayer("Jane Smith", 28, 10, 170.0);
    FootballPlayer player3 = new FootballPlayer("Michael Johnson", 24, 3, 175.5);
    FootballPlayer player4 = new FootballPlayer("Emily Brown", 26, 5, 165.0);
    FootballPlayer player5 = new FootballPlayer("David Wilson", 29, 9, 185.0);
    FootballPlayer player6 = new FootballPlayer("Sarah Davis", 27, 2, 160.0);
    FootballPlayer player7 = new FootballPlayer("Robert Thompson", 23, 6, 175.0);
    FootballPlayer player8 = new FootballPlayer("Jessica Taylor", 25, 11, 170.0);
    FootballPlayer player9 = new FootballPlayer("William Clark", 28, 8, 182.0);
    FootballPlayer player10 = new FootballPlayer("Olivia Martinez", 26, 4, 167.5);
    FootballPlayer player11 = new FootballPlayer("Daniel Anderson", 24, 1, 178.0);
// ... create more players

// Creating teams
Coach coach1 = new Coach("Mike Johnson", 45);
    Team team1 = new Team(coach1, new List<FootballPlayer>
    {
        player1, 
        player2,
        player3,
        player4,
        player5,
        player6,
        player7,
        player8,
        player9,
        player10,
        player11
    });
// ... add more players to team1

Coach coach2 = new Coach("Alex Davis", 42);
Team team2 = new Team(coach1, new List<FootballPlayer>
    {
        player1,
        player2,
        player3,
        player4,
        player5,
        player6,
        player7,
        player8,
        player9,
        player10,
        player11
    });

// Creating referee
Referee referee = new Referee("Mark Thompson", 35);

    // Creating a game
    Game game1 = new Game(team1, team2, referee);

    // Adding goals to the game
    game1.AddGoal(10, "John Doe");
    game1.AddGoal(30, "Jane Smith");
    // ... add more goals

    // Setting the game result
    game1.SetResult("2-1", "Team 1");

    // Printing the game details
    Console.WriteLine("Game Details:");
    Console.WriteLine($"Team 1: {game1.Team1.Players.Count} players");
    Console.WriteLine($"Team 2: {game1.Team2.Players.Count} players");
    Console.WriteLine($"Referee: {game1.Referee.Name}");
    Console.WriteLine("Goals:");
    foreach (string goal in game1.Goals)
    {
        Console.WriteLine(goal);
    }
    Console.WriteLine($"Result: {game1.Result}");
    Console.WriteLine($"Winner: {game1.Winner}");