namespace person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

        public class Person()
        {
            
            private int personId = int.Parse(Console.ReadLine());
            private int personName;
            private string accounts;

            public string PersonId {

            get { 
                if(personId == 2)
                {
                    return "second";
                }
                else if(personId == 3)
                {
                    return "third";
                }
                else {
                    return "th";
                }
            }
            
            set { } 
        
        }
            public string PersonName { get; set; }
            public string Accounts { get; set; }

        }
    
}







