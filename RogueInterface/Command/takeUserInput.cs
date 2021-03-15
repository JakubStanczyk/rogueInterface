using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Command
{ 
    // it can be a diffrent name cant think of anything atm
    class takeUserInput //Receiver
    {
        public string getKey(string key)
        {
            key = Console.ReadLine();
            return key;
        }
    }
}
