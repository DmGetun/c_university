using System;
using System.Linq;

namespace labCards
{
    internal class CardPack
    {
        private Random rnd = new Random();
        private int[] arr;
        public int Count { get; }

        public CardPack(int count)
        {
            Count = count;
            CardRandom();
        }

        public int this[int index] { get { return arr[index]; } }

        public void CardSort() => arr = Enumerable.Range(0, Count).ToArray();
        public void CardRandom() => arr = Enumerable.Range(0, Count).OrderBy(cc => rnd.Next()).ToArray();
        

    }
}