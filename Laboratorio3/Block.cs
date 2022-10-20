using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    internal class Block
    {

        public int Index
            { get; set; }
        public DateTime TimeStamp { get; set; }
        
        public String PreviusHash { get; set; }

        public String Hash { get; set; }

        public String Data { get; set; }

        public Block(DateTime timeStamp, String PreviusHash, String Data)
        {
            Index = 0;
            TimeStamp = timeStamp;
            PreviusHash = PreviusHash;
            Data = Data;
            Hash = CalculateHash();
        }

        public String CalculateHash()
        {
            SHA256 sHA256 = SHA256.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes($"{ TimeStamp}-{ PreviusHash ?? ""}-{ Data}");
            byte[] outputBytes = sHA256.ComputeHash(inputBytes);
            return Convert.ToBase64String(outputBytes);
        }
    }
}
