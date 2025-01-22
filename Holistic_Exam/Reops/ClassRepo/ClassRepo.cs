using Holistic_Exam.Data;
using Holistic_Exam.DTOs;
using Holistic_Exam.Models;
using Microsoft.EntityFrameworkCore;

namespace Holistic_Exam.Reops.ClassRepo
{
    public class ClassRepo:IClass
    {
        public ClassRepo(DbContextOptions options) : base(options)
        {
        }

        void Add(ClassAll classAll)
        {
            var cla = new Classs
            {
                Name = Classs.Name,
              

               
            };
            _context.Cinema.Add(cla);
            _context.SaveChanges();
        }
    }
       
    }
}
