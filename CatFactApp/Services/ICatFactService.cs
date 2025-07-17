using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFactApp.Models;

namespace CatFactApp.Services
{
    public interface ICatFactService
    {
        Task<CatFact> GetCatFactAsync();
    }
}
