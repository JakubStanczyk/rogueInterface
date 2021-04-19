using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events
{
    public class ImplementModifyTrapEvent : ModifyTrapEvent
    {
        public ImplementModifyTrapEvent(IModifyTrapEvent changeNameOfTrapEvent) : base(changeNameOfTrapEvent)
        {

        }
        public override void renameToPitfall()
        {
            changeNameOfTrapEvent.renameToPitfall();
        }

        public override void renameToTripwire()
        {
            changeNameOfTrapEvent.renameToTripwire();
        }
    }
}
