using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2008M_NetCoreApi.Models;

namespace T2008M_NetCoreApi.Repositories
{
    public interface IStudentsRepository
    {
        Task<IEnumerable<Student>> GetStudentsAsync();
        Task<Student> GetStudentByIdAsync(int id);
        Task AddStudentAsync(Student student);
        Task DeleteStudentAsync(int id);
        Task UpdateStudentAsync(Student student);
        Task SaveChangesAsync();
        
    }
}
