namespace LeetCode
{
    public class Solution
    {
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
