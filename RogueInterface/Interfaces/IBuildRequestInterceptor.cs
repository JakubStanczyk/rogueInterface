using System;
using System.Collections.Generic;
using System.Text;

//A simple Interceptor interface set up, to allow the client to change the remote object.
namespace RogueInterface.Generation
{
    public interface IBuildRequestInterceptor
    {
        public void onPreBuildRequest(IBuildRequest context);
        public void onPostBuildRequest(IBuildRequest context);
    }
}
