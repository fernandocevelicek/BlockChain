using Laboratorio3;
using System;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {

        BlockChain diario = new BlockChain();

        diario.AddBlock(new Block(DateTime.Now, null, "{sender: Banco Nacion, receiver: Fernando BNA, Monto: $520}"));
        diario.AddBlock(new Block(DateTime.Now, null, "{sender: Minati.Mp, receiver: Fernando BNA, Monto: $1.400}"));
        diario.AddBlock(new Block(DateTime.Now, null, "{sender: Ofarina.Mp, receiver: Fernando BNA, Monto: $680}"));
        diario.AddBlock(new Block(DateTime.Now, null, "{sender: Torres.Mp, receiver: Fernando BNA, Monto: $3.400}"));
        string strserialize = JsonSerializer.Serialize<BlockChain>(diario);
        Console.WriteLine(strserialize);

    }
}




