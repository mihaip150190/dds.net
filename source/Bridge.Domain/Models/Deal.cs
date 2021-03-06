//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bridge.Domain.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Deal
    {
        public Deal()
        {
            this.DuplicateDeals = new HashSet<DuplicateDeal>();
            this.MakeableContracts = new HashSet<MakeableContract>();
        }
    
        public int Id { get; set; }
        public int EventId { get; set; }
        public int Index { get; set; }
        public string PBNRepresentation { get; set; }
        public int SysVulnerabilityId { get; set; }
        public string HandViewerInput { get; set; }
        public string BestContract { get; set; }
        public string BestContractDisplay { get; set; }
        public int BestContractDeclarer { get; set; }
        public int BestContractResult { get; set; }
        public string BestContractHandViewerInput { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual SysVulnerability SysVulnerability { get; set; }
        public virtual ICollection<DuplicateDeal> DuplicateDeals { get; set; }
        public virtual ICollection<MakeableContract> MakeableContracts { get; set; }
        public virtual SysPlayer SysPlayer { get; set; }
    }
}
