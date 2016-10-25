using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            int amountToPay = 266;
            int paidAmount = 500;

            int changeToPayBack = paidAmount - amountToPay;


            // To keep things simple, we assume that you pay back
            // change as: 1-kr coins, 10-kr coins and 100-kr bills.

            int noOf1krCoins = 1;
            int noOf10krCoins = 10;
            int noOf100krBills = 100;

            int _noOf1krCoins = (int)(changeToPayBack / noOf1krCoins);
            int _noOf10krCoins = (int)((changeToPayBack % noOf1krCoins) / noOf10krCoins);
            int _noOf100krBills = (int)(((changeToPayBack % noOf1krCoins) & noOf10krCoins) / noOf100krBills);
            
            // YOUR JOB: Add code to calculate the correct change


            Console.WriteLine("Your change is {0} 1-kr coins, {1} 10-kr coins and {2} 100-kr bills", _noOf1krCoins, _noOf10krCoins, _noOf100krBills);
            Console.WriteLine("A total of {0} kr", changeToPayBack);


            // The LAST line of code should be ABOVE this line
        }
    }
}
