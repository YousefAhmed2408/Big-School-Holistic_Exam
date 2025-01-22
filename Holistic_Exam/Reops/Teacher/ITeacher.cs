using Holistic_Exam.DTOs;

namespace Holistic_Exam.Reops.Teacher
{
    public interface ITeacher
    {
        List<TeacherAll>GetAlls();
        void Add(TeacherDTO teacher);
        List<TeacherandClass> GetByID();

    }
}
