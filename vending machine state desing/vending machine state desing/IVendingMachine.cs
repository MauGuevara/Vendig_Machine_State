using System;
using System.Collections.Generic;
using System.Text;

namespace vending_machine_state_desing
{
    public interface IVendingMachine
    {
        void HandleOperation(VendingMachine v_machine_context);
    }
}
