using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

        public List<Country> GetAllCountries()
        {
            List<Country> countries = new List<Country>();

            string conStr = "Server=WIN81VM;Database=WCF;User Id=sa;Password=GUesst01;";

            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Country", con);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                Country c;
                while (dr.Read())
                {
                    c = new Country()
                    {
                        CountryId = int.Parse(dr[0].ToString()),
                        CountryName = dr[1].ToString()
                    };

                    countries.Add(c);
                }

                dr.Close();
                con.Close();
            }

            return countries;
        }
    }
}