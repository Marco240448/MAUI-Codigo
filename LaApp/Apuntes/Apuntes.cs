using System;
using System.Collections.Generic;
using System.Text;

namespace LaApp.Apuntes
{
    public class Apuntes
    {
        /*
        dotnet add package Microsoft.EntityFrameworkCore
        dotnet add package Microsoft.EntityFrameworkCore.SqlServer
        dotnet add package Microsoft.EntityFrameworkCore.Tools

        Infrastructure ->
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options) {}

            public DbSet<Entidad> Entidades { get; set; }
        }

        Dependency Injection ->
        public static class DependencyInjection
        {
            public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
            {
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(connectionString));

                return services;
            }
        }

        MauiProgram.cs ->
        public static class MauiProgram
        {
            public static MauiApp CreateMauiApp()
            {
                var builder = MauiApp.CreateBuilder();

                string connection =
                    "Server=TU_SERVIDOR;Database=TU_DB;User Id=USUARIO;Password=PASS;TrustServerCertificate=true;";

                builder.Services.AddInfrastructure(connection);

                return builder.Build();
            }
        }

        En Application -> Interfaces ->

        public interface IProductoRepository
        {
            Task<List<Producto>> GetAll();
        }


        Infrastructure Repository ->
        public class ProductoRepository : IProductoRepository
        {
            private readonly AppDbContext _context;

            public ProductoRepository(AppDbContext context)
            {
                _context = context;
            }

            public async Task<List<Producto>> GetAll()
            {
                return await _context.Productos.ToListAsync();
            }
        }

        MainViewModel ->
        public class ProductosViewModel
        {
            private readonly IProductoRepository _repo;

            public ObservableCollection<Producto> Productos { get; set; }

            public ProductosViewModel(IProductoRepository repo)
            {
                _repo = repo;
                Productos = new ObservableCollection<Producto>();
            }

            public async Task Cargar()
            {
                var lista = await _repo.GetAll();
                foreach (var item in lista)
                    Productos.Add(item);
            }
        }

         
         */
    }
}
