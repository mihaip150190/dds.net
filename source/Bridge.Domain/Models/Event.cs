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
    
    public partial class Event
    {
        public Event()
        {
            this.Pairs = new HashSet<Pair>();
            this.Deals = new HashSet<Deal>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime Date { get; set; }
        public int SysEventTypeId { get; set; }
        public bool IsImported { get; set; }
    
        public virtual SysEventType SysEventType { get; set; }
        public virtual ICollection<Pair> Pairs { get; set; }
        public virtual ICollection<Deal> Deals { get; set; }
    }
}
