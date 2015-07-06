using System;
using System.Collections.Generic;

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

        public string GetResult(Student s)
        {
            //Calculate average
            double avg = (s.M1 + s.M2 + s.M3)/3.0;

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

        public Student GetTopper(ICollection<Student> Students)
        {
            double maxAvg = 0;
            Student topper = null;

            foreach (Student s in Students)
            {
                double avg = (s.M1 + s.M2 + s.M3) / 3.0;

                if (avg > maxAvg)
                {
                    maxAvg = avg;
                    topper = s;
                }
            }

            return topper;
        }
    }
}