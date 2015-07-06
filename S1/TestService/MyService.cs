using System;

namespace TestService
{
    public class MyService: IMyService
    {
        public string GetData()
        {
            return "www.udemy.com";
        }

        public string GetMessage(string Name)
        {
            return "Hello Mr./Ms " + Name;
        }

        public string GetResult(int sid, string sName, int M1, int M2, int M3)
        {
            //Calculate average
            double avg = (M1 + M2 + M3)/3.0;

            if (avg < 35)
                return "Fail";
            else
                return "Pass";

        }

        public int GetMax(int[] ar) 
        {
            int max = ar[0];

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > max)
                    max = ar[i];
            }

            return max;
        }

        public int[] GetSorted(int[] ar)
        {
            Array.Sort(ar);
            return ar;
        }
    }
}