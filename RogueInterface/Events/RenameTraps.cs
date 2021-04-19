using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events
{
    public class RenameTraps : IModifyTrapEvent
    {
        public void renameToPitfall()
        {
            Console.WriteLine("Medium Trap has been changed to Pitfall");
        }

        public void renameToTripwire()
        {
            Console.WriteLine("Medium Trap has been changed to Pitfall");
        }
    }
}
