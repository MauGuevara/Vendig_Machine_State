using System;
using System.Collections.Generic;
using System.Text;

namespace vending_machine_state_desing
{
    public class VendingMachine
    {
        private IVendingMachine v_machine_state;

        public VendingMachine()
        {
            v_machine_state = new WaitinMoneyState();
        }

        public IVendingMachine V_M_State
        {
            get {
                return v_machine_state;
            }
            set
            {
                v_machine_state = value;
            }
        }

        public void Sell()
        {
            Console.WriteLine("Sell item process begins...");
            v_machine_state = new SelectItemState();
            v_machine_state.HandleOperation(this);



        }



    }
}
