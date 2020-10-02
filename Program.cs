/* Programming task done from T. Gaddis, Starting Out With Java, VII ed.
 * 
 * Task 2.15. Stock Commision
 * 
 * Instruction:
 * Kathryn bought 600 shares of stock at a price of $21.77 per share. She must pay her stock-broker a 2 percent 
 * commission  for  the  transaction. Write  a  program  that  calculates  and displays the following:
 * -  The amount paid for the stock alone (without the commission)
 * -  The amount of the commission
 * -  The total amount paid (for the stock plus the commission)
 */

using System;
using System.CodeDom;

namespace StockCommision
{
    class CommissionCalculator
    {
        static void Main(string[] args)
        {

            int sharesAmountBought = 600;

            double pricePerShare = 21.77;

            const double BROKER_COMMISION_RATIO = 0.02;

            double totalNetSharesValue = (double) sharesAmountBought * pricePerShare;

            double brokerCommisionValue = totalNetSharesValue * BROKER_COMMISION_RATIO;

            double totalAmountPaid = totalNetSharesValue + brokerCommisionValue;

            Console.WriteLine($"Amount of shares bought: {sharesAmountBought}");
            Console.WriteLine($"Price per share: {pricePerShare}");
            Console.WriteLine($"Broker commision ratio: {BROKER_COMMISION_RATIO}");
            Console.WriteLine($"\nAmount paid for the stock alone: {totalNetSharesValue}");
            Console.WriteLine($"Amount of the commission: {brokerCommisionValue}");
            Console.WriteLine($"Total amount paid: {totalAmountPaid}");

        }
    }
}
