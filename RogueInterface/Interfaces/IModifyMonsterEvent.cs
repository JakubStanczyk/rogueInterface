using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events
{
    public interface IModifyMonsterEvent
    {
        public void renameToGoblin();
        public void renameToOrc();
    }
}
