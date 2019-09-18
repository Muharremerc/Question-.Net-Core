using KO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KO.DAL
{
    public class KO_Initializer
    {
        private KO_DBContext _context;

        public KO_Initializer(KO_DBContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.Members.Any())
            {
                _context.AddRange(Members);
                await _context.SaveChangesAsync();
            }
        }
        List<Member> Members = new List<Member>
        {
            new Member
            {
                Name="Ahmet",
                Password="1",
                Username="a"
            },
             new Member
            {
                Name="Mehmet",
                Password="1",
                Username="m"
            }
        };

    }
}
