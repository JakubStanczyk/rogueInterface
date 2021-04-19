using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events
{
    public class ImplementModifyEnemyEvents : ModifyEnemyEvent
    {
        public ImplementModifyEnemyEvents(IModifyMonsterEvent changeNameOfEnemyEvent) : base(changeNameOfEnemyEvent)
        {

        }

        public override void renameToGoblin()
        {
            changeNameOfEnemyEvent.renameToGoblin();
        }

        public override void renameToOrc()
        {
            changeNameOfEnemyEvent.renameToOrc();
        }
    }
}
