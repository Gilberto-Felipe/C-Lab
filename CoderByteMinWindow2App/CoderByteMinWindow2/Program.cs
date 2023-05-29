using System;
using System.Text;

class MainClass
{

    public static string MinWindowSubstring(string[] strArr)
    {
        string N = strArr[0];
        string K = strArr[1];
        int min = Int32.MaxValue;
        string result = "";
        for (int i = 0; i < N.Length; i++)
        {
            StringBuilder match = new StringBuilder(K);
            for (int j = i; j < N.Length; j++)
            {
                if (match.ToString().Contains(N[j].ToString()))
                {
                    int index = match.ToString().IndexOf(N[j]);
                    match.Remove(index, 1);
                }

                if (match.Length == 0)
                {
                    if (j - i < min)
                    {
                        min = j - i;
                        result = N.Substring(i, j - i + 1);
                    }
                    break;
                }
            }
        }
        return result;
    }

    public static void Main(string[] args)
    {
        // keep this function call here
        Console.WriteLine(MinWindowSubstring(new string[] { "aaffhkksemckelloe", "fhea" }));
    }



}