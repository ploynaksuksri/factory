using System;
using System.Linq;
using WebApplication.Services.Abstract;


namespace WebApplication.Services.Concrete
{
    public class StringService: IStringService
    {
        public bool IsPalindrome(string value)
        {
            var left = 0;
            var right = value.Length - 1;
            while (true)
            {
                if (left > right)
                    return true; 

                if (value[left] != value[right])
                    return false;
                left++;
                right--;
            }
        }

        public string ReverseWords(string value)
        {
            var words = value.Split(' ');
            return string.Join(" ", words.Reverse());         
        }
    }
}
