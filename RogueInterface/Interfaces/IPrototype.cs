using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Prototype

{
     public interface IPrototype<T>
    {
        T createCopy();
        
    }
}
