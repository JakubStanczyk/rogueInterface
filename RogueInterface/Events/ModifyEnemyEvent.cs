using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events
{
    abstract class ModifyEnemyEvent
    {
        protected IModifyMonsterEvent changeNameOfEnemyEvent;
        
        public ModifyEnemyEvent(IModifyMonsterEvent changeNameOfEnemyEvent)
        {
            this.changeNameOfEnemyEvent = changeNameOfEnemyEvent;
        }

        public abstract void renameToGoblin();

        public abstract void renameToOrc();

    }
}
