using System.Collections.Generic;
using AdvenTerminal.Project.Models;

namespace AdvenTerminal.Project.Interfaces
{
   public interface IPlayer
   {
      string Name { get; set; }
      List<Item> Inventory { get; set; }
   }
}