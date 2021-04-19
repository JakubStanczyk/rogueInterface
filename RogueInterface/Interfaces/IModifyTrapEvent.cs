using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events
{
    public interface IModifyTrapEvent
    {
        public void renameToPitfall();
        public void renameToTripwire();
    }
}
