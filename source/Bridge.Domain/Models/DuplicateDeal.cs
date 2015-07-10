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
    
    public partial class DuplicateDeal
    {
        public int Id { get; set; }
        public int DealId { get; set; }
        public int NSPairId { get; set; }
        public int EWPairId { get; set; }
        public string Contract { get; set; }
        public int Declarer { get; set; }
        public int Result { get; set; }
        public string BestContract { get; set; }
        public Nullable<int> BestContractDeclarer { get; set; }
        public Nullable<int> BestContractResult { get; set; }
    
        public virtual SysPlayer SysPlayer { get; set; }
        public virtual SysPlayer SysPlayer1 { get; set; }
        public virtual Pair Pair { get; set; }
        public virtual Pair Pair1 { get; set; }
        public virtual Deal Deal { get; set; }
    }
}
