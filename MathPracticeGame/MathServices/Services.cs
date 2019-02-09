using System;

namespace MathServices
{
    public class Services
    {
        public const int Easy = 10;
        public const int Medium = 50;
        public const int Hard = 100;
        public const int Expert = 500;

        public const int Add = 1;
        public const int Sub = 2;
        public const int Mul = 3;
        public const int Dev = 4;
        int limit;

        Random rand;
        public int Oper { get; set; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Result { get; set; }

        public Services()
        {

        }

        public String GetLevel(int lv)
        {
            switch (Oper)
            {
                case Easy: return "1";
                case Medium: return "2";
                case Hard: return "3";
                case Expert: return "4";
            }
            return String.Empty;
        }

        public String GetOperator()
        {
            switch(Oper)
            {
                case Add: return "+";
                case Sub: return "-";
                case Mul: return "x";
                case Dev: return ":";
            }
            return String.Empty;
        }
        public void RandomLevel(int Level)
        {
            switch (Level)
            {
                case 0: limit=Easy; break;
                case 1: limit= Medium; break;
                case 2: limit= Hard; break;
                case 3: limit = Expert; break;
            }
        }
        public void RandomCalculation()
        {
            rand = new Random();
            Oper = rand.Next(1,5);
            Result = rand.Next(limit);
            Number2 = rand.Next(limit/2);
            if (Number2>Result)
            {
                int temp = Result;  Result = Number2;Number2 = temp;
            }
            switch (Oper)
            {
                case Add:
                    Number1 = Result - Number2;
                    break;
                case Sub:
                    Number1 = Result + Number2;
                    break;
                case Mul:
                    if (Number2 == 0) Number2 = 1;
                    Number1 = Result / Number2;
                    Result = Number1 * Number2;
                    break;
                case Dev:
                    Number1 = Result;
                    if (Number2 == 0) Number2 = 1;
                    Result=Number1/Number2;
                    Number1 = Result * Number2;
                    break;
            }
        }
    }
}
