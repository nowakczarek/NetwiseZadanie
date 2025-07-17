using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CatFactApp.Models;
using Microsoft.Extensions.Logging;

namespace CatFactApp.Services
{
    public class CatFactService : ICatFactService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<CatFactService> _logger;

        public CatFactService(HttpClient httpClient, ILogger<CatFactService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<CatFact> GetCatFactAsync()
        {
            _logger.LogInformation("Pobieranie faktu o kocie...");

            try
            {
                var response = await _httpClient.GetAsync("fact");

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogWarning("Nie udało się pobrać faktu: {StatusCode}", response.StatusCode);
                }

                var json = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<CatFact>(json);

                if (result == null)
                {
                    _logger.LogWarning("Deserializacja zwróciła null.");
                    return null;
                }

                _logger.LogInformation("Udało się pobrać fakt o kocie.");

                return result;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Wystąpił wyjatek w trakcie pobierania faktu o kocie");
                return null;
            }
        }
    }
}
