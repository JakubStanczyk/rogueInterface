using System;
using System.Collections.Generic;
using System.Text;

namespace RogueInterface.Command
{
    class TakeKeyboardInputCommand : ICommand
    {
        private takeUserInput takeUserInput;

        string keyName;

        public TakeKeyboardInputCommand(takeUserInput takeUserInput, string keyName)
        {
            this.takeUserInput = takeUserInput;
            this.keyName = keyName;

                
        
        }

    
        void ICommand.Execute()
        {
            Console.WriteLine("what key do you want to assign for this action");
            this.keyName = this.takeUserInput.getKey(keyName);
        
        }
        
    }
}
