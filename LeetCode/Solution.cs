namespace LeetCode
{
    public class Solution
    {
        /// <summary>
        /// 58. Length of Last Word
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLastWord(string s)
        {
            int k = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    break;
                }
                else
                {
                    k++;
                }
            }
            return k;
        }

        /// <summary>
        /// IsPalindrom
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsPalindrom(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] == s[j])
                    continue;
                return false;
            }
            return true;
        }
    }

}
