namespace SequenceGenerator
{
    public class SequenceGeneratorService : ISequenceGeneratorService
    {
        public string ProcessInput(string inputString)
        {
            string[] inputStrings = Array.Empty<string>();
            int[] inputNumbers = Array.Empty<int>();

            inputStrings = inputString.Split(' ', StringSplitOptions.TrimEntries);

            try
            {
                inputNumbers = Array.ConvertAll(inputStrings, int.Parse);
            }
            catch (FormatException)
            {
                return "Invalid numbers entered";
            }

            var longestSequence = GenerateLongestSubSequence(inputNumbers);

            return(string.Join(" ", longestSequence));
        }

        private int[] GenerateLongestSubSequence(int[] inputNumbers)
        {
            int[] longestSubSequence = Array.Empty<int>();
            List<int> subSequence = new List<int>();

            for (int i = 0; i < inputNumbers.Length - 1; i++)
            {
                if (inputNumbers[i] < inputNumbers[i + 1])
                {
                    subSequence.Add(inputNumbers[i]);
                    if (i + 1 == inputNumbers.Length - 1)
                    {
                        subSequence.Add(inputNumbers[i + 1]);
                        SetLongestSubSequence(ref longestSubSequence, subSequence);
                    }
                }
                else
                {
                    subSequence.Add(inputNumbers[i]);
                    SetLongestSubSequence(ref longestSubSequence, subSequence);
                }
            }

            return longestSubSequence;
        }

        private void SetLongestSubSequence(ref int[] longestSubSequence, List<int> subSequence)
        {
            if (subSequence.Count > longestSubSequence.Length)
            {
                longestSubSequence = subSequence.ToArray();
            }
            subSequence.Clear();
        }
    }
}
