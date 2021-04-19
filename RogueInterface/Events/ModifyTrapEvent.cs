using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events
{
    public abstract class ModifyTrapEvent
    {
        protected IModifyTrapEvent changeNameOfTrapEvent;

        public ModifyTrapEvent(IModifyTrapEvent changeNameOfTrapEvent)
        {
            this.changeNameOfTrapEvent = changeNameOfTrapEvent;
        }

        public abstract void renameToPitfall();

        public abstract void renameToTripwire();
    }
}
