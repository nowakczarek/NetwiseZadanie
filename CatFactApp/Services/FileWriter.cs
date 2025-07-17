using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFactApp.Models;
using Microsoft.Extensions.Logging;

namespace CatFactApp.Services
{
    public class FileWriter : IFileWriter
    {
        private const string FileName = "CatFacts.txt";
        private readonly ILogger<FileWriter> _logger;

        public FileWriter(ILogger<FileWriter> logger)
        {
            _logger = logger;
        }

        public async Task WriteFactToFileAsync(CatFact fact)
        {
            try
            {
                var line = $"{DateTime.Now:dd-MM-yyyy HH:mm:ss} - {fact.Fact}";
                var path = Path.Combine(AppContext.BaseDirectory, FileName);

                await File.AppendAllTextAsync(FileName, line + Environment.NewLine);

                _logger.LogInformation("Zapisano fakt w pliku: {path}", path);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Nie udało sie zapisać faktu do pliku");
            }

        }
    }
}
