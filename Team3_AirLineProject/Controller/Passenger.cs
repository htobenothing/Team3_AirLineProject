//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Controller
{
    using System;
    using System.Collections.Generic;
    
    public partial class Passenger
    {
        public Passenger()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public string idUser { get; set; }
        public string passportNo { get; set; }
        public string pasName { get; set; }
        public System.DateTime dateOfBirth { get; set; }
        public string gender { get; set; }
        public System.DateTime createDate { get; set; }
    
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual User User { get; set; }
    }
}
