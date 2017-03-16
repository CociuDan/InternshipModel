using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Events.NewPaymentEventArgs;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentManager pm = new PaymentManager();
            Visa visa = new Visa(pm);
            MasterCard mc = new MasterCard(pm);
            pm.SimulateExecutingPayment(CardType.MasterCard, 1, 20.0, 1);
            Console.ReadKey();
        }
    }
}
