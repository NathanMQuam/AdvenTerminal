using System.Collections.Generic;
using AdvenTerminal.Project.Interfaces;

namespace AdvenTerminal.Project.Models
{
   public class Room
   {
      public string Name { get; set; }
      public string Description { get; set; }
      public List<Item> Items { get; set; }
      public Dictionary<string, IRoom> Exits { get; set; }
   }
}