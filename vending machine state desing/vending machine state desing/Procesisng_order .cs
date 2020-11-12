using System;
using System.Collections.Generic;
using System.Text;

namespace vending_machine_state_desing
{
    public class Procesisng_order : IVendingMachine
    {
        public void HandleOperation(VendingMachine v_machine_context)
        {
            Console.WriteLine("{0}: Procesing order....", nameof(Procesisng_order));
            Console.WriteLine(" giving change.....  ");
            v_machine_context.V_M_State = new GivingItemState();
            v_machine_context.V_M_State.HandleOperation(v_machine_context);
        }
    }
}
