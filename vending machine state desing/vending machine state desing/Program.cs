using System;

namespace vending_machine_state_desing
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vending_machine = new VendingMachine();
            vending_machine.Sell(20);
        }
    }
}
