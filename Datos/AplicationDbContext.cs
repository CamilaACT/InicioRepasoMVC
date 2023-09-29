using BlogCore.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogCore.Datos
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base (options) 
        { 
        }
        //Agregar los modelos aquí
        
             
        
    }
}
