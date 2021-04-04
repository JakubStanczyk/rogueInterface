using System;
using System.Collections.Generic;
using System.Text;

//A simple Interceptor interface set up, to allow the client to change the remote object.
namespace RogueInterface.Generation
{
    interface IEventInterceptor
    {
        public void OnEventGenerationRequest(IEventParamaters context);
    }
}
