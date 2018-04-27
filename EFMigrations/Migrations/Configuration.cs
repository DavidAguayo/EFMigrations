namespace EFMigrations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EFMigrations.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EFMigrations.Models.ContextoEmpleados>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EFMigrations.Models.ContextoEmpleados context)
        {
            context.Empleados.AddOrUpdate(z => z.Nombre,
                new Empleado
                {
                    IdEmpleado = 1,
                    Nombre = "David",
                    Apellidos = "Fern�ndez Huertas",
                    Direccion = "Calle Atl�tico de Madrid",
                    Email = "david@mail.com"
                },
                new Empleado
                {
                    IdEmpleado = 2,
                    Nombre = "Daniel",
                    Apellidos = "Hern�ndez Cavanillos",
                    Direccion = "Calle Portugal",
                    Email = "daniel@mail.com"
                },
                new Empleado
                {
                    IdEmpleado = 3,
                    Nombre = "Ana",
                    Apellidos = "Rodr�guez L�pez",
                    Direccion = "Calle Atl�tico de Madrid",
                    Email = "david@mail.com"
                }
                );
        }
    }
}
