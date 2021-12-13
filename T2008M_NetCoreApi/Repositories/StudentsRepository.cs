using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2008M_NetCoreApi.Models;

namespace T2008M_NetCoreApi.Repositories
{
    public class StudentsRepository : IStudentsRepository, IDisposable
    {
        private DatabaseContext context;      

        public StudentsRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await context.Students.ToListAsync();
        }
        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await context.Students.FindAsync(id);
        }

        public async Task AddStudentAsync(Student student)
        {
            await context.Students.AddAsync(student);            
        }

        public async Task DeleteStudentAsync(int id)
        {
            Student ctg = await context.Students.FindAsync(id);
            context.Students.Remove(ctg);
        }

        public async Task UpdateStudentAsync(Student student)
        {
            var studentInDb = await context.Students.FindAsync(student.Id);
            studentInDb = student;
            await SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
