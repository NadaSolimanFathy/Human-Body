using Human_Body.Context;
using Human_Body.Interfaces;
using Human_Body.Model;
using Microsoft.EntityFrameworkCore;

namespace Human_Body.Repository
{
    public class HumanBodyRepository: IHumanBodyRepository
    {
        private readonly HumanBodyDbContext context;

        public HumanBodyRepository(HumanBodyDbContext _context)
        {
            context = _context;
        }

        public  HumanBody GetTheOrganInfo(string name)
        {
            var organ =  context.humanBodyOrgans.FirstOrDefault(organ => organ.Name == name);
         
            return organ;
        }



      
    }
}
