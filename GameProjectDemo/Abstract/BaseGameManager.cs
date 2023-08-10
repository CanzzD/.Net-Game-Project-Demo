using System;
using GameProjectDemo.Concreate;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    public class BaseGameManager : IGameService
    {
        public void Sales(Game game)
        {
            Console.WriteLine("Purchase Successful" + ":" +game.GameName
                + " " + "\n" +"Payment" + game.Price + "$" );
        }
    }
}
