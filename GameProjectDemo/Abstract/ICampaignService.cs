using System;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    public interface ICampaignService
    {
        void CampaignSave(campaignManager campaign);
        void CampaignUpdate(campaignManager campaign);
        void CampaignDelete(campaignManager campaign);
    }
}
