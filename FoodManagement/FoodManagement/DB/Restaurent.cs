//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoodManagement.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Restaurent
    {
        public Restaurent()
        {
            this.Posts = new HashSet<Post>();
        }
    
        public int Rid { get; set; }
        public string Rname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<Post> Posts { get; set; }
    }
}