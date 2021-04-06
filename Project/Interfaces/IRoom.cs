using System.Collections.Generic;
using AdvenTerminal.Project.Models;

namespace AdvenTerminal.Project.Interfaces
{
   public interface IRoom
   {
      string Name { get; set; }
      string Description { get; set; }
      List<Item> Items { get; set; }
      Dictionary<string, IRoom> Exits { get; set; }
   }
}