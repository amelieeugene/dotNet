using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApp1.Models
{
  public class ClubModel
  {
    public List<announcement> Announcements { get; set; }
    public List<club_event> Upcoming_events { get; set; }
    public List<club_event> Past_events { get; set; }
    public string SomeText { get; set; }
    public bool IsAdmin { get; set; }
  }
}