using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events
{
    public class RenameMonster : IModifyMonsterEvent
    {
        public void renameToGoblin()
        {
            Console.WriteLine("Easy monster is now a Goblin");
        }

        public void renameToOrc()
        {
            Console.WriteLine("Medium monster is now a Orc");
        }
    }
}
