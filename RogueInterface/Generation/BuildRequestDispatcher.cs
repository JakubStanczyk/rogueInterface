using System;
using System.Collections.Generic;
using System.Text;

//not excactlty sure on setting up the dispatcher from the examples. 
namespace RogueInterface.Generation
{
    public abstract class BuildRequestDispatcher
    {
        protected List<IBuildRequestInterceptor> interceptors;

        public BuildRequestDispatcher()
        {
            interceptors = new List<IBuildRequestInterceptor>(5);
        }

        public void registerBuildRequestInterceptor(IBuildRequestInterceptor interceptor)
        {
            interceptors.Add(interceptor);
        }

        abstract protected void dispatchPostBuildRequest(IBuildRequest context);
        abstract protected void dispatchPreBuilldRequest(IBuildRequest context);
    }
}
