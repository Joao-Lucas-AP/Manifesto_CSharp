using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema__4
{
    public class PalindromeDate
    {
        public static DateTime FindLastPalindromeDate()
        {
            DateTime currentDate = DateTime.Now;

            while (true)
            {
                string dateString = currentDate.ToString("MMddyyyy");
                bool isPalindrome = IsPalindrome(dateString);

                if (isPalindrome)
                {
                    return currentDate;
                }

                currentDate = currentDate.AddDays(-1);
            }
        }

        public static bool IsPalindrome(string text)
        {
            int left = 0;
            int right = text.Length - 1;

            while(left < right)
            {
                if (text[left] != text[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
