using Laboratorio3;
using System.Text.Json;

namespace LibroContable
{
    [Serializable]
    internal class BlockChain
    {
        public List<Block> Chain { get; set; }

        private const string BASE_PATH = "/bloques/";
        private const string GENESIS_NAME = "GENESIS.bin";

        public BlockChain()
        {
            if(File.Exists(BASE_PATH + GENESIS_NAME))
            {
                Block genesisBlock = BinarySerialization.ReadFromBinaryFile<Block>(BASE_PATH + GENESIS_NAME);
                LoadBlockChainFromFileSystem(genesisBlock);
            }
            else
            {

                InitializeChain();
                AddGenesisBlock();
            }

            foreach(Block block in Chain)
            {
                Console.WriteLine(JsonSerializer.Serialize<Block>(block));
            }
        }

        public void InitializeChain()
        {
            Chain = new List<Block>();
        }
        public Block CreateGenesisBlock()
        {
            return new Block(DateTime.Now, null, new Entidades.LibroDiario());
        }
        
        public void AddGenesisBlock()
        {
            Block genesisBlock = CreateGenesisBlock();
            BinarySerialization.WriteToBinaryFile(BASE_PATH + GENESIS_NAME, genesisBlock);
            Chain.Add(genesisBlock);
        }

        public void LoadBlockChainFromFileSystem(Block genesisBlock)
        {
            int index = genesisBlock.Index;
            Chain = new List<Block>();
            Chain.Add(genesisBlock);

            while(true)
            {
                index++;
                string nextPath = @BASE_PATH+(index)+".bin";
                if (File.Exists(nextPath))
                {
                    Block loadedBlock = BinarySerialization.ReadFromBinaryFile<Block>(nextPath);

                    if (!IsValidBlock(index, loadedBlock)) throw new InvalidBlockException("EL BLOQUE Nro " + index + " es invalido.");

                    Chain.Add(loadedBlock);
                }
                else
                {
                    break;
                }
            }

        }

        public Block GetLatestBlock()
        {
            return Chain[Chain.Count - 1];
        }
        public void AddBlock(Block block)
        {
            Block latestBlock = GetLatestBlock();
            block.Index = latestBlock.Index + 1;
            block.PreviousHash = latestBlock.Hash;
            block.Hash = block.CalculateHash();

            BinarySerialization.WriteToBinaryFile(BASE_PATH + block.Index + ".bin", block);

            Chain.Add(block);
        }
        public bool IsValid()
        {
            for (int i = 1; i < Chain.Count; i++)
            {
                Block currentBlock = Chain[i];
                Block previousBlock = Chain[i - 1];

                if (currentBlock.Hash != currentBlock.CalculateHash())
                {
                    return false;
                }

                if (currentBlock.PreviousHash != previousBlock.Hash)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsValidBlock(int index, Block currentBlock)
        {
            Block previousBlock = Chain[index - 1];

            if (currentBlock.Hash != currentBlock.CalculateHash() || currentBlock.PreviousHash != previousBlock.Hash)
            {
                return false;
            }

            return true;
        }
    }
}
