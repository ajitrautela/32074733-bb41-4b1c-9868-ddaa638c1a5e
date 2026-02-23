namespace SequenceGeneratorService
{
    public class SequenceGeneratorService
    {
        public int[] GenerateLongestSubSequence(int[] inputNumbers)
        {
            int[] longestSubSequence = Array.Empty<int>();
            List<int> subSequence = new List<int>();

            for (int i = 0; i < inputNumbers.Length - 1; i++)
            {
                if (inputNumbers[i] < inputNumbers[i + 1])
                {
                    subSequence.Add(inputNumbers[i]);
                }
                else
                {
                    subSequence.Add(inputNumbers[i]);
                    if (subSequence.Count > longestSubSequence.Length)
                    {
                        longestSubSequence = subSequence.ToArray();
                    }
                    subSequence.Clear();
                }
            }

            return longestSubSequence;
        }
    }
}
