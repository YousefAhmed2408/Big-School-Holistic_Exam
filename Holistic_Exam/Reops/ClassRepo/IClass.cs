using Holistic_Exam.Data;
using Holistic_Exam.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Holistic_Exam.Reops.ClassRepo
{
    public interface IClass:AppdbContext
    {
        void Add(ClassAll classAll);
    }
}
