﻿using System;
using System.Collections.Generic;
using System.Text;

namespace vending_machine_state_desing
{
    public class SelectItemState : IVendingMachine
    {
        public void HandleOperation(VendingMachine v_machine_context)
        {
            Console.WriteLine("{0}: Waiting to select an item", nameof(SelectItemState));
            v_machine_context.V_M_State = new Procesisng_order();
            v_machine_context.V_M_State.HandleOperation(v_machine_context);

        }
    }
}
