using System;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public void CampaignDelete(campaignManager campaign)
        {
            Console.WriteLine("Saved to offer : " + campaign.CampaignName + "\n" +
    campaign.CampaignDetail + " " + "\n" + "Campaign is Active?" + " " + campaign.ActiveOrNot);
        }

        public void CampaignSave(campaignManager campaign)
        {
            Console.WriteLine("Saved to offer : " + campaign.CampaignName + "\n" +
    campaign.CampaignDetail + " " + "\n" + "Campaign is Active?" + " " + campaign.ActiveOrNot);
        }

        public void CampaignUpdate(campaignManager campaign)
        {
            Console.WriteLine("Saved to offer : " + campaign.CampaignName + "\n" +
    campaign.CampaignDetail + " " + "\n" + "Campaign is Active?" + " " + campaign.ActiveOrNot);
        }
    }
}
