using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string reverseText = new string(arr);
            if (str.Equals(reverseText))
            {
                return true;
            }
            else
            {
                return false;
            }
        } 

    }
}
