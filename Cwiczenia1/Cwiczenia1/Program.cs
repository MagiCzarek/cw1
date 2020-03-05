using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cwiczenia1
{
    public class Student
    {
        
        public string Nazwisko { get; set; }
    }
    public class Osoba
    {
        private int _age;

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

    }
    class Program
    {
        public static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var result = await client.GetAsync("https://www.pja.edu.pl");
            if (result.IsSuccessStatusCode)
            {
                string html = await result.Content.ReadAsStringAsync();
                var regex = new Regex("[a-z]+[a-z0-9]*@[a-z.]+");
                var matches = regex.Matches(html);
                foreach(var m in matches)
                {
                    Console.WriteLine(m);
                    Console.WriteLine(m);
                }
                
            }
            var st = new Student();
            st.Nazwisko = "Bogo";

            Console.WriteLine("Dest");
        }
    }
}
