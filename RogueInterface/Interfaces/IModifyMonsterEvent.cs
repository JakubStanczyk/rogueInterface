using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events

{
    interface IModifyMonsterEvent
    {
        void renameToGoblin();
        void renameToOrc();

    }
}
