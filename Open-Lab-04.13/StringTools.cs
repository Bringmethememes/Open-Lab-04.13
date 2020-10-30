using System;

namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            int[,] bruh = new int[str1.Length + 1, str2.Length + 1];
            int pleb1 = 0;    
            int pleb2 = 0;    

            for (var i = 0; i < str1.Length; i++)
                for (var j = 0; j < str2.Length; j++)
                    if (str1[i] == str2[j])
                    {
                        int len = bruh[i + 1, j + 1] = bruh[i, j] + 1;
                        if (len > bruh[pleb1, pleb2])
                        {
                            pleb1 = i + 1;
                            pleb2 = j + 1;
                        }
                    }

            return str1.Substring(pleb1 - bruh[pleb1, pleb2], bruh[pleb1, pleb2]);
        }
    }
}
