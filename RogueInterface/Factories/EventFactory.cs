using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events
{
    class EventFactory
    {
        static IEventFactory GetEasySpawn()
        {
            return new EasyEventFactory();
        }

        static IEventFactory GetMediumSpawn()
        {
            return new MediumEventFactory();
        }
    }
}
