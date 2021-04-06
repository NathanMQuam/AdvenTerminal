using AdvenTerminal.Project.Interfaces;

namespace AdvenTerminal.Project.Models
{
   public class Item : IItem
   {
      public string Name { get; set; }
      public string Description { get; set; }
   }
}