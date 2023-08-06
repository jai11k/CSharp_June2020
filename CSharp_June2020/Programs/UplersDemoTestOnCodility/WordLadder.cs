using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Programs.Word_Ladder
{
    public class WordLadder
    {
        //Given two words (beginWord and endWord), and a dictionary of word lists,
        //find the length of the shortest transformation sequence from beginWord to endWord,
        //such that only one letter can be changed at a time.

        public static int WordLadderLength(string beginWord, string endWord, List<string> wordList)
        {
            HashSet<string> wordSet = new HashSet<string>(wordList);

            if (!wordSet.Contains(endWord))
                return 0;

            Queue<string> queue = new Queue<string>();
            queue.Enqueue(beginWord);
            int level = 1;

            while (queue.Count > 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    string currentWord = queue.Dequeue();

                    for (int j = 0; j < currentWord.Length; j++)
                    {
                        char[] charArray = currentWord.ToCharArray();

                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            charArray[j] = c;
                            string newWord = new string(charArray);

                            if (newWord == endWord)
                                return level + 1;

                            if (wordSet.Contains(newWord))
                            {
                                queue.Enqueue(newWord);
                                wordSet.Remove(newWord);
                            }
                        }
                    }
                }

                level++;
            }

            return 0;
        }

        public static void Main()
        {
            string beginWord = "hit";
            string endWord = "cog";

            List<string> wordList = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };

            int length = WordLadderLength(beginWord, endWord, wordList);
            Console.WriteLine("Length of the shortest transformation sequence: " + length);
        }
    }
}
