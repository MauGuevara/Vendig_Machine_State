using System;
using System.Collections.Generic;
using System.Text;

namespace vending_machine_state_desing
{
    public class WaitinMoneyState : IVendingMachine
    {
        public void HandleOperation(VendingMachine v_machine_context)
        {
            Console.WriteLine("Insert Money............");
        }


    }
}
