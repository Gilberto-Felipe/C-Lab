using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace GenericsEventsProject.DataAccess
{
    internal class DataAccess<T> where T : new()
    {
        public event EventHandler<T> BadWordFound;

        public void SaveToCSV(List<T> items, string filePath)
        {
            List<string> rows = new List<string>();

            var cols = GetHeaders(rows);

            GetData(rows, cols, items);

            File.WriteAllLines(filePath, rows);
        }


        private PropertyInfo[] GetHeaders(List<string> rows)
        {            
            T entry = new T();

            // Get header by Reflection
            var cols = entry.GetType().GetProperties();

            string headerRow = "";

            foreach (var col in cols)
            {
                headerRow += $",{ col.Name }";
            }

            headerRow = headerRow.Substring(1);

            rows.Add(headerRow);

            return cols;
        }

        private List<string> GetData(List<string> rows, PropertyInfo[] cols, List<T> items)
        {            
            foreach (var item in items)
            {
                bool areBadWords = false;
                var row = "";

                foreach (var col in cols)
                {
                    row += $",{col.GetValue(item)}";

                    areBadWords = SearchBadWords(row);

                    if (areBadWords)
                    {
                        BadWordFound?.Invoke(this, item);
                        break;
                    }                    
                }

                if (areBadWords)
                {
                    continue;
                }

                row = row.Substring(1);

                rows.Add(row);
            }

            return rows;
        }

        private bool SearchBadWords(string row)
        {
            bool output = false;

            if (row.ToLower().Contains("heck") || row.ToLower().Contains("shit"))
            {
                output = true;
            }

            return output;
        }
    }
}
