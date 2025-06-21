using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ClienteDAO
    {

        public string IdCliente { get; set; }

        public string? Correo { get; set; }

        public long? Telefono { get; set; }
        public string? Direccion { get; set; }

        public string Nombre { get; set; } = null!;
        public Dictionary<string, byte[]>? Files { get; set; }

        public ClienteDAO(string idCliente, string? correo, long? telefono, string? direccion, string nombre, Dictionary<string, byte[]>? files)
        {
            IdCliente = idCliente;
            Correo = correo;
            Telefono = telefono;
            Direccion = direccion;
            Nombre = nombre;
            Files = files;
        }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }

            if (Telefono.HasValue && Telefono.ToString().Length < 5)
            {
                throw new ArgumentException("Numero de télefono invalido.");
            }

            if (Correo != null && !System.Text.RegularExpressions.Regex.IsMatch(Correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new ArgumentException("El correo electrónico no es válido.");
            }
            if (Direccion != null && Direccion.Length < 20)
            {
                throw new ArgumentException("La dirección no puede tener menos de 20 caracteres.");
            }
            if (Direccion != null && Direccion.Length > 150)
            {
                throw new ArgumentException("La dirección no puede tener mas de 150 caracteres.");
            }
        }
    }
}

