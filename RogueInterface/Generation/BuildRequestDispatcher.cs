using System;
using System.Collections.Generic;
using System.Text;

//not excactlty sure on setting up the dispatcher from the examples. 
namespace RogueInterface.Generation
{
    public class BuildRequestDispatcher
    {
        List<IBuildRequestInterceptor> interceptors;

        public void registerBuildRequestInterceptor(IBuildRequestInterceptor interceptor)
        {
            interceptors.Add(interceptor);
        }

        public void dispatchBuildRequestPre(IBuildRequest context)
        {
        }
    }
}
