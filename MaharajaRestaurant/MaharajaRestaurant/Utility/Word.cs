using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace MaharajaRestaurant.Utility
{
    public static class Word
    {
        public static string GetItShortened(string wording,int number)
        {
            StringBuilder ret = new StringBuilder();
            string[] temp = wording.Split(' ');
            int i = 0;
            foreach(string s in temp)
            {
                if(i < number)
                {
                    ret.Append(s);
                    ret.Append(" ");
                    i++;
                }
            }
            return ret.ToString();
        }

        public static string GetKeywords(string wording)
        {
            String[] temps = wording.Split(new String[] { " " }, StringSplitOptions.RemoveEmptyEntries).Where(w => w.Trim().Length > 5).Distinct().ToArray();
            return String.Join(",",temps);
        }
    }
}