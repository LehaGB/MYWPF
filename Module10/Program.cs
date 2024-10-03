using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            User user = new User();
            user.Read();
            Console.ReadLine();
        }
    }
    interface IUser
    {
        void Read();
    }

    interface IAdmin : IUser
    {
        void Write();
    }
    public class User : IUser
    {
        public void Read()
        {
            Console.WriteLine("User is reading...");
        }
    }
    public class Admin : IAdmin
    {
        public void Read()
        {
            Console.WriteLine("Admin is reading...");
        }

        public void Write()
        {
            Console.WriteLine("Admin is writing...");
        }
    }
}
