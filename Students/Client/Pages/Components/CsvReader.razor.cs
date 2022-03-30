using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Components.Forms;

namespace Csv.Client.Pages.Components
{
    public partial class CsvReader
    {
        public static List<string[]> csv = new List<string[]>();
        public async Task OnInputFileChange(InputFileChangeEventArgs e)
        {
            var singleFile = e.File;

           
                var stream = singleFile.OpenReadStream();
                
                MemoryStream ms = new MemoryStream();
                await stream.CopyToAsync(ms);
                stream.Close();
                var outputFileString = System.Text.Encoding.UTF8.GetString(ms.ToArray());

                foreach (var item in outputFileString.Split(Environment.NewLine))
                {
                    csv.Add(SplitCSV(item.ToString()));
                }

            
        }

        private string[] SplitCSV(string input)
        {
            //Excludes commas within quotes  
            Regex csvSplit = new Regex("(?:^|,)(\"(?:[^\"]+|\"\")*\"|[^,]*)", RegexOptions.Compiled);
            List<string> list = new List<string>();
            string curr = null;
            foreach (Match match in csvSplit.Matches(input))
            {
                curr = match.Value;
                if (0 == curr.Length) list.Add("");

                list.Add(curr.TrimStart(','));
            }

            return list.ToArray();
        }
    }
}
