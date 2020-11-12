using System;
using System.Collections.Generic;
using System.Text;

namespace vending_machine_state_desing
{
    public class GivingItemState: IVendingMachine
    {
        public void HandleOperation(VendingMachine v_machine_context)
        {
            Console.WriteLine("{0}: Sell is comlplete", nameof(GivingItemState));
            v_machine_context.V_M_State = new WaitinMoneyState();
            v_machine_context.V_M_State.HandleOperation(v_machine_context);

        }
    }
}
