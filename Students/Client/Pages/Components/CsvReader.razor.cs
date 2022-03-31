using Microsoft.AspNetCore.Components.Forms;
using Students.Client.Data;

namespace Csv.Client.Pages.Components;

public partial class CsvReader
{
    
    public async Task OnInputFileChange(InputFileChangeEventArgs e)
    {
        List<CsvReader> listCsv = new List<CsvReader>();
        var singleFile = e.File;


        var stream = singleFile.OpenReadStream();

        MemoryStream ms = new MemoryStream();
        await stream.CopyToAsync(ms);
        stream.Close();
        var outputFileString = System.Text.Encoding.UTF8.GetString(ms.ToArray());

        List<string> csvRows = outputFileString.Split("\n").ToList();

        for (int i = 0; i < csvRows.Count; i++)
        {
            if (i > 0)
            {
                List<string> csvStringList = csvRows[i].Split(";").ToList();
                prueba csvFinal = new prueba(
                    Int32.Parse(csvStringList[0]),
                    csvStringList[1],
                    csvStringList[2],
                    csvStringList[3],
                    csvStringList[4]
                    );

                listCsv.Add(csvFinal);
            }
        }
    }
}
