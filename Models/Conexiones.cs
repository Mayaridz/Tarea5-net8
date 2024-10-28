using Microsoft.EntityFrameworkCore;

namespace ApiEmpresa.Models;

public class Conexiones : DbContext
{
    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options)
    {
    }

    public DbSet<Clientes> Clientes { get; set; } = null!;
    
    public DbSet<Proveedores> Proveedores { get; set; } = null!; //Dbset representa todas las entidadse
    //aqui se colocan las entidades 
    //por ejemplo si queremos agregar la entidad empleado seria asi:
    //public DbSet<Empleado> Empleado { get; set; } = null!;
}