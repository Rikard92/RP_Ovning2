namespace RP_Övning
{
    internal class Repeater
    {
        internal void RunMenu()
        {
            Console.WriteLine("Main Menu: \n0: Quit Program \n1: Calculate Ticket Price \n2: Repeat 10 times \n3: Get the Third Word");
            while (true)
            {
                String input = Console.ReadLine();
                switch (input)
                {
                    case "0":

                        return;

                    case "1":
                        Console.WriteLine("How many people wants to see a movie?");
                        int partynum = Int32.Parse(Console.ReadLine());
                        int TicketSum = GetTicketPrice(partynum);
                        Console.WriteLine("Total {0}kr", TicketSum);
                        break;

                    case "2":
                        Console.WriteLine("Write the Text you want repeated 10 times.");
                        string theText = Console.ReadLine();
                        for(int i=1; i<=10; i++)
                        {
                            Console.Write("{0}. {1} ", i,theText);
                        }

                        break;

                    case "3":
                        Console.WriteLine("Write a sentence with three words");
                        string sentence = Console.ReadLine();
                        if (sentence.Split(' ').Length > 2)
                        {
                            Console.WriteLine(sentence.Split(' ')[2]);
                        }
                        else
                        {
                            Console.WriteLine("Write three words next time");
                        }
                        break;

                    default:
                        Console.WriteLine("Present a valid input");
                        break;

                }
            }
        }

        private int GetTicketPrice(int partynum)
        {
            int price = 0;
            for (int i = 1; i <= partynum; i++){
                Console.WriteLine("Declair persons {0} age", i);
                int Age = Int32.Parse(Console.ReadLine());
                if (Age<20)
                {
                    price += 80;
                }
                else if (Age > 64)
                {
                    price += 90;
                }
                else
                {
                    price += 120;
                }
                
            }
            return price;
        }
    }
}