//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestApp1.Models
{
    using System;
    using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;

  public partial class club_member
    {
        public int ID_club_member { get; set; }
    [Required]
        public string firstName { get; set; }
    [Required]
    public string lastName { get; set; }
        public System.DateTime joinDate { get; set; }
        public Nullable<int> grade { get; set; }
        public string status { get; set; }
    [Required]
    public string email { get; set; }
    }
}
