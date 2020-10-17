using System.Collections.Generic;
using HandIn_1.Models;

namespace HandIn_1.Data
{
    public interface IAdultService
    {
        void AddAdult(Adult adult);
        List<Adult> getAdults();
        void RemoveAdult(int adultID);
    }
}