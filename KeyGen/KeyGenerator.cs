using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace LeaveManagementSystem.KeyGen
{
    public class KeyGenerator
    {
        public static string GenerateKey(int length = 32)
        {
           
                var byteArray = new byte[length];
                RandomNumberGenerator.Fill(byteArray);
                return Convert.ToBase64String(byteArray);
        }
    }
    
}

