using PrymeraApi.Models;
using PrymeraApi.Utils;

namespace PrymeraApi.Data
{
    public class PrymeraRepository
    {
        public List<Usuario> Usuarios { get; } = new()
        {
            new Usuario
            {
                Id = 1,
                Nombres = "Administrador",
                Apellidos = "Prymera",
                Dni = "12345678",
                Correo = "admin@prymera.pe",
                PasswordHash = PasswordHasher.Hash("123456")
            }
        };

        public List<Producto> Productos { get; } = new()
        {
            new Producto { Id = 1, Nombre = "Capital de Trabajo", Categoria = "Créditos PYME", Descripcion = "Crédito para impulsar el crecimiento del negocio.", Beneficio = "Financia mercadería, campañas y operaciones." },
            new Producto { Id = 2, Nombre = "Crédito Activo Fijo", Categoria = "Créditos PYME", Descripcion = "Financiamiento para equipos, herramientas o maquinaria.", Beneficio = "Permite mejorar la productividad." },
            new Producto { Id = 3, Nombre = "Préstamo Mi Cash", Categoria = "Persona", Descripcion = "Préstamo personal para gastos importantes.", Beneficio = "Atención rápida y requisitos claros." },
            new Producto { Id = 4, Nombre = "Cuenta de Ahorros", Categoria = "Ahorros", Descripcion = "Cuenta sin cobros de mantenimiento.", Beneficio = "Ahorra de forma segura y simple." },
            new Producto { Id = 5, Nombre = "Depósito a Plazo Fijo", Categoria = "Ahorros", Descripcion = "Producto para hacer crecer tus ahorros.", Beneficio = "Plazos desde 30 días." }
        };

        public List<Agencia> Agencias { get; } = new()
        {
            new Agencia { Id = 1, Nombre = "Agencia Miraflores", Direccion = "Av. República de Panamá 6251, Miraflores", Telefono = "243-4800", Horario = "Lunes a viernes 09:00 a 18:30 / Sábados 09:00 a 12:30" },
            new Agencia { Id = 2, Nombre = "Agencia Plaza Norte", Direccion = "C.C. Plaza Norte, Independencia", Telefono = "533-1632", Horario = "Lunes a domingo 10:00 a 22:00" },
            new Agencia { Id = 3, Nombre = "Agencia Mall del Sur", Direccion = "Av. Los Lirios / Av. Pedro Miotta, San Juan de Miraflores", Telefono = "276-7658", Horario = "Lunes a domingo 10:00 a 22:00" }
        };
    }
}
