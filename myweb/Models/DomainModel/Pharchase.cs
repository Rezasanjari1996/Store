//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myweb.Models.DomainModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pharchase
    {
        public int Id { get; set; }
        public System.DateTime BuyDate { get; set; }
        public string FllowCode { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual user user { get; set; }
    }
}