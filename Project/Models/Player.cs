using System.Collections.Generic;
using AdvenTerminal.Project.Interfaces;

namespace AdvenTerminal.Project.Models
{
   public class Player : IPlayer
   {
      public string Name { get; set; }
      public List<Item> Inventory { get; set; }
   }
}