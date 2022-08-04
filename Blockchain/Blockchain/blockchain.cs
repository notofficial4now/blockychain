using System;
//using System.Security.Cryptography;

namespace Blockchain
{
    class Block
    {
        private int PreviousHash;
        private string[] transactions;
        private int blockHash;
        //Block genesisBlock = new Block(0, genesisTransactions);
        public Block(int PreviousHash, string[] transactions)
        {
            this.PreviousHash = PreviousHash;
            this.transactions = transactions;

            Object[] contest = { PreviousHash, transactions.GetHashCode() };
            int blockHash = contest.GetHashCode();
        }
        public int getPreviousHash()
        {
            return PreviousHash;
        }
        public string[] getTransactions()
        {
            return transactions;
        }
        public int getBlockHash()
        {
            return blockHash;
        }

    }

}
