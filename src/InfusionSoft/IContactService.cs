//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InfusionSoft
{
    using System;
    using System.Collections.Generic;
    
    
    public interface IContactService : InfusionSoft.IService
    {
        
        int Add(System.Collections.IDictionary data);
        
        bool AddToCampaign(int contactId, int campaignId);
        
        bool AddToGroup(int contactId, int campaignId);
        
        int GetNextCampaignStep(int contactId, int followUpSequenceId);
        
        InfusionSoft.Tables.Contact[] FindByEmail(string email, string[] selectedFields);
        
        InfusionSoft.Tables.Contact Load(int contactId, string[] selectedFields);
        
        bool PauseCampaign(int contactId, int sequenceId);
        
        bool RemoveFromCampaign(int contactId, int followUpSequenceId);
        
        bool RemoveFromGroup(int contactId, int tagId);
        
        bool ResumeCampaignForContact(int contactId, int seqId);
        
        int RescheduleCampaignStep(int[] contactIds, int sequenceStepId);
        
        bool RunActionSequence(int contactId, int actionSetId);
        
        int AddWithDupCheck(System.Collections.IDictionary data, string dupCheckType);
        
        int Update(int contactId, System.Collections.IDictionary data);
    }
}
