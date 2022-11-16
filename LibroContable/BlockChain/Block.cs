using LibroContable.Entidades;
using System.Security.Cryptography;
using System.Text;

namespace Laboratorio3
{
    [Serializable]
    internal class Block
    {

        public int Index
            { get; set; }
        public DateTime TimeStamp { get; set; }
        
        public String PreviousHash { get; set; }

        public String Hash { get; set; }

        public LibroDiario Data { get; set; }

        public Block(DateTime timeStamp, String previousHash, LibroDiario data)
        {
            Index = 0;
            TimeStamp = timeStamp;
            PreviousHash = previousHash;
            Data = data;
            Hash = CalculateHash();
        }

        public String CalculateHash()
        {
            SHA256 sHA256 = SHA256.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes($"{ TimeStamp}-{ PreviousHash ?? ""}-{ Data}");
            byte[] outputBytes = sHA256.ComputeHash(inputBytes);
            return Convert.ToBase64String(outputBytes);
        }
    }
}
