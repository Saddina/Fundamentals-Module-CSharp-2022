using System;
using System.Linq;

namespace KaminoFactory
{
    internal class KaminoFactory
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] best = new int[length];
            int mostLeft = length;
            int bestSequenceLength = 0;
            int bestSum = 0;
            int bestSequenceNumber = 1;

            string cmd = Console.ReadLine();
            int seqNum = 0;

            while (cmd != "Clone them!")
            {
                int[] currSeq = cmd
                    .Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                seqNum++;
                int currentSequenceLenght = 0;
                int previousSequenceLenght = 0;
                int currentLongestSequence = 0;

                int leftmostIndexInCurrentArray = length;

                int currentSampleSum = 0;

                for (int i = 0; i < currSeq.Length; i++)
                {
                    if (currSeq[i] == 1)
                    {
                        currentSequenceLenght++;
                        currentSampleSum++;
                    }
                    else
                    {
                        previousSequenceLenght = currentSequenceLenght;
                        currentSequenceLenght = 0;
                    }

                    if (currentSequenceLenght > previousSequenceLenght)
                    {
                        currentLongestSequence = currentSequenceLenght;
                        leftmostIndexInCurrentArray = i - currentSequenceLenght + 1;
                    }
                }

                if (currentLongestSequence > bestSequenceLength)
                {
                    bestSequenceLength = currentLongestSequence;
                    mostLeft = leftmostIndexInCurrentArray;
                    best = currSeq;
                    bestSequenceNumber = seqNum;
                    bestSum = currentSampleSum;
                }
                else if (currentLongestSequence == bestSequenceLength)
                {
                    if (leftmostIndexInCurrentArray < mostLeft)
                    {
                        mostLeft = leftmostIndexInCurrentArray;
                        bestSum = currentSampleSum;
                        best = currSeq;
                        bestSequenceNumber = seqNum;
                    }
                    else if (mostLeft == leftmostIndexInCurrentArray)
                    {
                        if (currentSampleSum > bestSum)
                        {
                            bestSum = currentSampleSum;
                            best = currSeq;
                            bestSequenceNumber = seqNum;
                        }
                    }
                }

                cmd = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequenceNumber} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", best));


        }
    }
}

