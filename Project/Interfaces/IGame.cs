using AdvenTerminal.Project.Models;

namespace AdvenTerminal.Project.Interfaces
{
   public interface IGame
   {
      IRoom CurrentRoom { get; set; }
      IPlayer CurrentPlayer { get; set; }

      void Setup();
   }
}