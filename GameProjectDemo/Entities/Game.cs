using System;
using GameProjectDemo.Abstract;

namespace GameProjectDemo.Entities
{
    public class Game : IEntity
    {
        public string GameName { get; set; }
        public string Producer { get; set; }
        public int Price { get; set; }
    }
}
