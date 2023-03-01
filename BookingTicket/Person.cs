using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTicket
{
    class Person
    {
        protected string name, address, email, phone;
        public string Name
        {
            get { return name; }

            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set {
                foreach (Char c in value)
                {
                    if (!Char.IsDigit(c))
                        throw new ArgumentException("Author not valid!");
                    phone = value;
                }
                
            }
        }
        public Person() { }
        public Person(string name, string addressm, string email, string phone)
        {
            this.Name = name;
            this.Address = addressm;
            this.Email = email;
            this.Phone = phone;
        }
        public void EnterInfo()
        {
            Console.Write("Input your name: ");
            Name = Console.ReadLine();

            Console.Write("Input your email: ");
            Email = Console.ReadLine();

            Console.Write("Input your address: ");
            Address = Console.ReadLine();

            Console.Write("Input your phone: ");
            Phone = Console.ReadLine();


        }

        /*public virtual void DisplayPerson()
        {
            Console.WriteLine("-- Inforamtion");
            Console.WriteLine($"Full Name: {Name} ");
            Console.WriteLine($"Email: {Address}");
            Console.WriteLine($"Full Name: {Email} ");
            Console.WriteLine($"Email: {Phone}");
        }*/
    }

}