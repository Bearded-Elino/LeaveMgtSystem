using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagementSystem.KeyGen;


namespace LeaveManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretKey = KeyGenerator.GenerateKey();
            Console.WriteLine(secretKey);
        }
    }
}