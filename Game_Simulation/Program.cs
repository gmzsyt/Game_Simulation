using System;

namespace GameSimulation
{

    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() { Id = "123456", GamerName = "Gamze", GamerSurname = "Seyit", BirthYear = "1995" };
            Gamer gamer2 = new Gamer() { Id = "654321", GamerName = "Canan Nehir", GamerSurname = "Gül", BirthYear = "2000" };

            Game game1 = new Game() { Id = 1, Name = "Call Of Duty", Price = 56, UnitsInStock = 15 };
            Game game2 = new Game() { Id = 2, Name = "Flight Simulator", Price = 20, UnitsInStock = 20 };

            Campaign campaign = new Campaign() { Id = 1, Name = "Black Friday", Discount = 50 };



            GameManagers gameManager = new GameManagers();
            gameManager.Add(game1);
            gameManager.Delete(game2);
            gameManager.Update(game1);



            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer2);

            CampaignManagers campaignManager = new CampaignManagers();
            campaignManager.Add(campaign);


            SaleManagers saleManager = new SaleManagers();
            saleManager.Sale(game1, gamer1, campaign);
            saleManager.Sale(game2, gamer2, campaign);








            Console.Read();


        }
    }
}
