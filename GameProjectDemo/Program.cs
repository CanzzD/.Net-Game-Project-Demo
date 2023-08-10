using System;
using GameProjectDemo.Abstract;
using GameProjectDemo.Concreate;
using GameProjectDemo.Entities;

namespace GameProjectDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            BaseCustomerManager customerManager = new GameXCustomerManager();
            customerManager.Save(new Customer
            {
                FirstName = "Can",
                LastName = "Özdemir",
                NationatyId = "63913048576",
                DateOfBirth = new DateTime(2000, 10, 5)
            });

            BaseCampaignManager campaignManager = new SummerCampaignManager();
            campaignManager.CampaignSave(new campaignManager
            {
                CampaignName = "Summer Campaign",
                CampaignDetail = "All Games are 50% off for 10 days",
                Discount = 50,
                ActiveOrNot = true,
            });

            BaseGameManager gameManager = new GameCustomerManager();
            gameManager.Sales(new Game
            {
                GameName = "Call of Duty 4 Modern Warfare",
                Producer = "Activision",
                Price = 200
            });
     
        }
    }
}
