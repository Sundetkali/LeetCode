namespace LeetCode;
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

    /// <summary>
    /// 35. Search Insert Position
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int SearchInsert(int[] nums, int target)
    {
        if (nums == null)
            return 0;

        if (target > nums.Last())
            return nums.Length;

        var pos = 0;

        if (nums.Contains(target))
        {
            pos = Array.IndexOf(nums, target);
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > target)
                {
                    pos = i;
                    break;
                }
            }
        }
        return pos;
    }


}
