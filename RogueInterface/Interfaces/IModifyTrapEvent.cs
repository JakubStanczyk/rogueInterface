using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events
{
    interface IModifyTrapEvent
    {
        void renameToPitfall();
        void renameToTripwire();
    }
}
