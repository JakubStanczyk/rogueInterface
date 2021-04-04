using System;
using System.Collections.Generic;
using System.Text;

//The interface for the concrete object, that the Interceptor will intercept. We're doing it for Event generation and the Abstract Factory method
namespace RogueInterface.Generation
{
    interface IEventParamaters
    {
        public String getEventDifficulty();
        public String setEventDifficulty();
        public String getEventType();
        public String setEventType();

    }
}
