
using GameProject;

GamerManager gamerManager = new GamerManager(new UserValidationManager());

Gamer gamer1 = new Gamer();
gamer1.Id = 1;
gamer1.FirstName = "Bilal";
gamer1.LastName = "Demirci";
gamer1.DateOfBirth = 1999;
gamer1.IdentityNumber = "61075";

Game game1 = new Game();
game1.GameId = 1;
game1.GameName = "Counter Strike2";
game1.GamePrice = 15;

gamerManager.Add(gamer1);
GameSalesManager gameSalesManager = new GameSalesManager();
gameSalesManager.Sale(gamer1,game1);

Console.ReadLine();