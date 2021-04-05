using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Generation
{
    public class BuildRequestDispatcher2 : IBuildRequestInterceptor
    {
        List<IBuildRequestInterceptor> interceptors;

        public void onPostBuildRequest(IBuildRequest context)
        {
            
        }

        public void onPreBuildRequest(IBuildRequest context)
        {
            
        }
    }
}
