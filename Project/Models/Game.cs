using AdvenTerminal.Project.Interfaces;

namespace AdvenTerminal.Project.Models
{
   public class Game : IGame
   {
      public IRoom CurrentRoom { get; set; }
      public IPlayer CurrentPlayer { get; set; }

      //NOTE Make yo rooms here...
      public void Setup()
      {
         throw new System.NotImplementedException();
      }
   }
}