
namespace getLastLoop
{
    public class Change
    {
        /// <summary>
        ///  quinta 1:00 da matina sole survivor.
        /// </summary>
        /// <param name="trade">Is a variable that running in the vector [i] position and count the numbers that robot walking</param>
        static void LastPosition(String trade)
        {
            int l = trade.Length;

            int countUp = 0, countDown = 0;
            int countLeft = 0, countRight = 0;

            //this for count the numbers of words was digited and add in your variable
            for (int i = 0; i < l; i++)
            {

                if (trade[i] == 'U' || trade[i] == 'u')
                    countUp++;


                else if (trade[i] == 'D' || trade[i] == 'd')
                    countDown++;

                else if (trade[i] == 'L' || trade[i] == 'l')
                    countLeft++;

                else if (trade[i] == 'R' || trade[i] == 'r')
                    countRight++;


            }



            Console.WriteLine("Last Position is: (" + (countRight - countLeft) + ", " + (countUp - countDown) + ")");

        }


        public static void Main()
        {
            Console.WriteLine("Please insert your string for robot (24 characters) ");
            String trade = Console.ReadLine();
            if (trade.Length != 23)
            {
                Console.WriteLine("Please Inset 24 Characteres");
            }
            else
            {
                Console.WriteLine("Output:" + (trade.Substring(2, 10)));
                LastPosition(trade);
            }



        }

    }
}

