//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConcertHall
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ticketType { get; set; }
        public Nullable<int> totalOfPpl { get; set; }
        public int AddressId { get; set; }
    
        public virtual CustomerAddress CustomerAddress { get; set; }
    }
}
