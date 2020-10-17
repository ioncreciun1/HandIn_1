using System.Collections.Generic;
using System.Linq;
using HandIn_1.Data.Persistence;
using HandIn_1.Models;

namespace HandIn_1.Data
{
   
    public class AdultService : IAdultService
    {
        private  FileContext context;
        private List<Adult> adults = new List<Adult>();

        public AdultService()
        {
            context= new FileContext();
            adults = (List<Adult>)context.Adults;
        }
        
        public void AddAdult(Adult adult)
        {
            int max = adults.Max(Adult => Adult.Id);
            adult.Id = (++max);
            adults.Add(adult);
            context.SaveChanges();
        }

        public List<Adult> getAdults()
        {
            return adults;
        }

        public void RemoveAdult(int adultID)
        {
            Adult adultRemove = adults.First(a => a.Id == adultID);
            adults.Remove(adultRemove);
            context.SaveChanges();
            
        }
    }
}