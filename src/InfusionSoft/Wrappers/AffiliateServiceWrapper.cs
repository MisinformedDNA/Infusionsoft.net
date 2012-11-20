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
    using Definition;
    
    
    internal partial class AffiliateServiceWrapper : ServiceBase<IAffiliateServiceDefinition>, IAffiliateService
    {
        
        public AffiliateServiceWrapper(InfusionSoft.IInfusionSoftConfiguration configuration) : 
                base(configuration)
        {
        }
        
        public virtual object AffClawbacks(int affiliateId, System.DateTime filterStartDate, System.DateTime filterEndDate)
        {
            return Invoke(d => d.AffClawbacks(ApiKey, affiliateId, filterStartDate, filterEndDate));
        }
        
        public virtual object AffCommissions(int affiliateId, System.DateTime filterStartDate, System.DateTime filterEndDate)
        {
            return Invoke(d => d.AffCommissions(ApiKey, affiliateId, filterStartDate, filterEndDate));
        }
        
        public virtual object AffPayouts(int affiliateId, System.DateTime filterStartDate, System.DateTime filterEndDate)
        {
            return Invoke(d => d.AffPayouts(ApiKey, affiliateId, filterStartDate, filterEndDate));
        }
        
        public virtual object AffRunningTotals(string[] affiliateIds)
        {
            return Invoke(d => d.AffRunningTotals(ApiKey, affiliateIds));
        }
        
        public virtual object AffSummary(int affiliateId, System.DateTime filterStartDate, System.DateTime filterEndDate)
        {
            return Invoke(d => d.AffSummary(ApiKey, affiliateId, filterStartDate, filterEndDate));
        }
    }
}
