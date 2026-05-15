using Microsoft.EntityFrameworkCore;
using StudentEnrollementForm_CRUD.Models;     

namespace StudentEnrollementForm_CRUD.Data
{


public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
}

}