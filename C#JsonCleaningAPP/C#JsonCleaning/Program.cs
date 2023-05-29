//# Remove all keys that have values of N/A, -, or empty strings. +If one of these values appear in an array, remove that single item from the array. Then console log the modified object as a string.

//# Sample case:
//#     URL response -    {"name":{"first":"Daniel","middle":"N/A","last":"Smith"},"age":45}
//#     Output solution - {"name":{"first":"Daniel","last":"Smith"},"age":45}

//# (without external nuget packages (newtonsoft json and javascriptserializer))
//# Example solution using RegularExpressions

using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;


WebRequest request = WebRequest.Create("https://coderbyte.com/api/challenges/json/json-cleaning");
WebResponse response = request.GetResponse();

StreamReader reader = new StreamReader(response.GetResponseStream());
string output = reader.ReadLine();

while (output != null)
{
    string[] regexstr = new string[]{
          "[\"][a-zA-Z0-9_]*[\"]:[[\"][nN]\\/[aA][\"]]*[,]",
          "[\"][a-zA-Z0-9_]*[\"]:[[\"]-[\"]]*[,]",
          "[\"][a-zA-Z0-9_]*[\"]:[[\"][\"]]*[,]",
          "[,]\"-\"|\"-\"[,]"
          };

    foreach (var regex in regexstr)
    {
        output = Regex.Replace(output, regex, string.Empty);
    }

    Console.WriteLine(output);
    output = reader.ReadLine();
}
response.Close();
