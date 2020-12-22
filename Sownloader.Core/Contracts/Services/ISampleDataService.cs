using System.Collections.Generic;
using System.Threading.Tasks;

using Sownloader.Core.Models;

namespace Sownloader.Core.Contracts.Services
{
    public interface ISampleDataService
    {
        Task<IEnumerable<SampleOrder>> GetMasterDetailDataAsync();
    }
}
