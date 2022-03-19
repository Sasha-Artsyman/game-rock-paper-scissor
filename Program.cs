using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace RockPaperScissor

{

    class Program

    {

        static void Main(string[] args)

        {

            UniEnable();

            Console.Write("Make a choise (1 - Rock, 2 - Paper, 3 - Scissor): ");

            int my_chose = Convert.ToInt32(Console.ReadLine());

            int pc_chose = Comp();

            Console.WriteLine("Wellcome");

            Console.WriteLine("Your chose: " + NumToStr(my_chose));

            Console.WriteLine("PC's chose: " + NumToStr(pc_chose));

            string ans = AnalizeGame(my_chose, pc_chose);

            Console.WriteLine($"Game Result: {ans}");

        }

        

        public static string NumToStr(int iNum)

        {

            string iRetMsg = "";

            switch (iNum)

            {

                case 1:

                    iRetMsg = "Rock 👊";

                    break;

                case 2:

                    iRetMsg = "Paper ✋";

                    break;

                case 3:

                    iRetMsg = "Scissor ✌️";

                    break;

            }

            return iRetMsg;

        }

        

        public static void UniEnable() 

        {

          Console.OutputEncoding = 

          System.Text.Encoding.UTF8;

          Console.Write("\xfeff"); 

          // bom = byte order mark

        }

        

        public static int Comp()

        {

            Random rnd = new Random();

            return rnd.Next(1, 4);

        }

        

        public static string AnalizeGame(int iMy_chose, int iPc_chose)

        {

            string  win="You Win 😊",

                    lose="You Lose 😔", 

                    equal="Tie 🙌", 

                    mistake="Nothing chosen," +

                    "please input from 1-3";

            string msg = "";

            if (iMy_chose == 1)

            {

                if (iPc_chose == 1)

                {msg = equal;}

                else if (iPc_chose == 2)

                {msg = lose;}

                else if (iPc_chose == 3)

                {msg = win;}

            } 

            else if (iMy_chose == 2)

            {

                if (iPc_chose == 1)

                {msg = win;}

                else if (iPc_chose == 2)

                {msg = equal;}

                else if (iPc_chose == 3)

                {msg = lose;}

            }

            else if (iMy_chose == 3)

            {

                if (iPc_chose == 1)

                {msg = lose;}

                else if (iPc_chose == 2)

                {msg = win;}

                else if (iPc_chose == 3)

                {msg = equal;}

            }

            else

            {

                msg = mistake;

            }

            

            return msg;

        }

    }

}
