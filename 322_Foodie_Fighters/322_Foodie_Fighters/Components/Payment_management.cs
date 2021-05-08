using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _322_Foodie_Fighters
{
    static public class PaymentManagement
    {
        class PaymentService
        {
            protected int paymentServiceID;
            public void processPayment()
            {

            }
        }

        class CreditCardService : PaymentService
        {

        }
        class DebitCardService : PaymentService
        {

        }
        class ThirdPartyService : PaymentService
        {

        }

        static public void processPayment(double price)
        {

        }
        static public void printReceipt(double price)
        {

        }

    }
}
 