using System;
using System.Collections;

namespace Blockchain
{
    public class Program
    {
        ArrayList blockchain = new ArrayList();

        public static void Main(string[] args)
        {
            string[] genesisTransactions = { "dani california" };
            string[] transactions01 = { "donald trump" };

            Block genesisBlock = new Block(0, genesisTransactions);
            Block block01 = new Block(genesisBlock.getBlockHash(), transactions01);

            Console.WriteLine(genesisBlock.getBlockHash());
            Console.WriteLine(block01.getBlockHash());
            Console.ReadLine();
        }
    }


}
