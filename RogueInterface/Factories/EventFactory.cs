﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events
{
    public class EventFactory
    {
        public static IEventFactory GetEasySpawn()
        {
            return new EasyEventFactory();
        }

        public static IEventFactory GetMediumSpawn()
        {
            return new MediumEventFactory();
        }
    }
}
