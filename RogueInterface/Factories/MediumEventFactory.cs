﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Events
{
    class MediumEventFactory : IEventFactory
    {
        IEnemySpawnEvent IEventFactory.CreateEnemySpawn()
        {
            return new MediumEnemySpawnEvent();
        }

        ITrapSpawnEvent IEventFactory.CreateTrapSpawn()
        {
            return new MediumTrapSpawnEvent();
        }
    }
}
