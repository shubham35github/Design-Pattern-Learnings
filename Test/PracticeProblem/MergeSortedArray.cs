using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.PracticeProblem
{
    public class MergeSortedArray
    {
       /* Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        Output: [1,2,2,3,5,6]
        Explanation: The arrays we are merging are[1, 2, 3] and[2, 5, 6].
        The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.*/
        public int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            Dictionary<char,int> dic = new Dictionary<char,int>();
            string s = "shubham";
            int[] temp = nums1;
            int k=0,i=0,j=0;
            while(j<n || i<m)
            {
                if (nums1[i] <= nums2[j])
                {
                    temp[k++] = nums1[i++];
                }
                else if (nums1[i] > nums2[j])
                {
                    temp[k++] = nums2[j++];
                }
            }
            return temp;
        }
        public bool IsPalindrome(string s)
        {
            string[] spt = s.Split(' ');
            s=s.Remove(0,2);
            int l = 0;
            int r = s.Length - 1;
            s = s.ToUpper();
            while (r >= l)
            {
                bool isLeftAlpha = true;
                bool isRightAlpha = true;
                if (!IsAlphabet(s[l]))
                {
                    l++;
                    isLeftAlpha = false;
                }
                if (!IsAlphabet(s[r]))
                {
                    r--;
                    isRightAlpha = false;
                }
                if (isRightAlpha && isLeftAlpha)
                {
                    if (s[l] != s[r])
                    {
                        return false;
                    }
                    l++;
                    r--;
                }
                if(r<l && !isLeftAlpha && !isRightAlpha)
                {
                    return false;
                }
            }
            
            return true;
        }
        public bool IsAlphabet(char chr)
        {
            if (chr >= 65 && chr <= 90)
            {
                return true;
            }
            return false;
        }

    }
}
