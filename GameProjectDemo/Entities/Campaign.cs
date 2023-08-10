using System;
using GameProjectDemo.Abstract;

namespace GameProjectDemo.Entities
{
    public class campaignManager : IEntity
    {
        public string CampaignName { get; set; }
        public string CampaignDetail { get; set; }
        public bool ActiveOrNot { get; set; }
        public int Discount { get; set; }
    }
}

