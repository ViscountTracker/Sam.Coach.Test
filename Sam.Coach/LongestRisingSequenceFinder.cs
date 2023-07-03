using System.Collections.Generic;
using System.Threading.Tasks;


namespace Sam.Coach
{
    public class LongestRisingSequenceFinder : ILongestRisingSequenceFinder
    {
        public Task<IEnumerable<int>> Find(IEnumerable<int> numbers) => Task.Run(() =>
        {
            // TODO: return the longest raising sequence in the collection provided, i.e.
            // when numbers = [4, 6, -3, 3, 7, 9] then expected result is [-3, 3, 7, 9]
            // when numbers = [9, 6, 4, 5, 2, 0] then expected result is [4, 5]
            IEnumerable<int> result = null;
            List<int> longestSequence = new List<int>();
            List<int> currentSequence = new List<int>();

            foreach (var number in numbers)
            {
                if (currentSequence.Count == 0 || number > currentSequence[currentSequence.Count - 1])
                {
                    currentSequence.Add(number);
                }
                else
                {
                    if (currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence = new List<int>(currentSequence);
                    }
                    currentSequence.Clear();
                    currentSequence.Add(number);
                }
            }
            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = new List<int>(currentSequence);
            }
            result = longestSequence;
            return result;
        });
    }
}
