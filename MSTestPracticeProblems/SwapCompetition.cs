using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestPracticeProblems
{
    public class SwapCompetition
    {
        public string IsEligible(List<string> words)
        {
            string firstWord = words[0];
            string secondWord = words[1];

            List<char> firstWordLetters = new List<char>(firstWord);
            List<char> secondWordLetters = new List<char>(secondWord);

            foreach (char letter in secondWordLetters)
            {
                if (firstWordLetters.Contains(letter))
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
            return default;
        }
    }
}
