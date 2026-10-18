using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class CeilingFan
    {
        public int HIGH { get { return 3; } }
        public int MEDIUM { get { return 2; } }
        public int LOW { get { return 1; } }
        public int OFF { get { return 0; } }
        string location;
        int speed;
        public CeilingFan(string location)
        { 
            this.location = location;
            speed = OFF;
        }

        public void High()
        {
            speed = HIGH;
            Console.WriteLine(location + " is on: " + speed);
        }

        public void Medium()
        {
            speed = MEDIUM;
            Console.WriteLine(location + " is set on: " + speed);
        }

        public void Low() 
        {
            speed = LOW;
            Console.WriteLine(location + " is set on: " + speed);
        }

        public void Off()
        {
            speed = OFF;
            Console.WriteLine(location + " is set on: " + speed);
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}
