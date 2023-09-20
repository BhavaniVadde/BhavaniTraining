namespace ElectroncityBill
{
    public class Program
    {
        static void Main(string[]args)
        {
            //declares variables to store customer information and electricity bill deatails
            // Customer ID and units consumed
            int custid, conu;
            // Charges, surcharge, gross amount, and net amount
            double chg, surchg = 0, gramt, netamt;
            // Customer name (nullable string)
            string? connm;

            //displays heading message
            Console.Write("\n\n");
            Console.Write("Calculate Electricity Bill:\n");
            Console.Write("-----------------------------");
            Console.Write("\n\n");
            
            //prompts to enter input customer information
            Console.Write("Input Customer ID :");
            custid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the name of the customer :");
            connm = Console.ReadLine();
            Console.Write("Input the unit consumed by the customer : ");
            conu = Convert.ToInt32(Console.ReadLine());

            // Calculate the charges based on the number of units consumed
            if (conu < 200)
                chg = 1.20;
            else if (conu >= 200 && conu < 400)
                chg = 1.50;
            else if (conu >= 400 && conu < 600)
                chg = 1.80;
            else
                chg = 2.00;

            // Calculate the gross amount
            gramt = conu * chg;

            // Calculate the surcharge if the gross amount is greater than 300
            if (gramt > 300)
                surchg = (gramt * 15 )/ 100;
            // Calculate the net amount, at least 100
            netamt = gramt + surchg;
            if (netamt < 100)
                netamt = 100;
            // Display the electricity bill details
            Console.Write("\nElectricity Bill\n");
            Console.Write("Customer IDNO :{0}\n", custid);
            Console.Write("Customer Name :{0}\n", connm);
            Console.Write("unit Consumed :{0}\n", conu);
            Console.Write("Amount Charges @Rs. {0}  per unit :{1:0.00}\n", chg, gramt);
            Console.Write("Surchage Amount :{0:0.00}\n",surchg);
            Console.Write("Net Amount Paid By the Customer :{0:0.00}\n", netamt);
        }
    }
}