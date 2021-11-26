using System.Collections.Generic;
using System.Threading.Tasks;
using Database4Adult1.Persistence;

namespace Database4Adult1.Domain
{
    public class AdultRepo : IAdultRepo
    {
        
        protected AdultContext ctx;
        
        public void Setup()
        {
            ctx = new AdultContext();
        }
        
        
        public Task<IList<Adult>> ReadAllAdults()
        {
            throw new System.NotImplementedException();
        }

        public Task<Adult> AddAdult(Adult addAdult)
        {
            throw new System.NotImplementedException();
        }

        public Task<Adult> UpdateAdult(Adult updateAdult)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAdult(int deleteAdult)
        {
            throw new System.NotImplementedException();
        }
    }
}