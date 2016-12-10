using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange
{
    
    class SayService : IMessageContract
    {
        public string Say(string s)
        {
            Console.WriteLine("Server Got Message: " + s);
            return "Server reply: " + s;
        }
    }
}
