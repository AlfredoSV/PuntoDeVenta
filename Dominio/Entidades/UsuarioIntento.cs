using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class UsuarioIntento
    {
        private Guid _idUsuarioIntento;

        private Guid _idUsuario;

        private DateTime _fechaYHoraIntento;

        public Guid IdUsuarioIntento { get => _idUsuarioIntento; set => _idUsuarioIntento = value; }

        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }

        public DateTime FechaYHoraIntento { get => _fechaYHoraIntento; set => _fechaYHoraIntento = value; }

        public UsuarioIntento(Guid idUsuarioIntento, Guid idUsuario, DateTime fechaYHoraIntento)
        {
            IdUsuarioIntento = idUsuarioIntento;
            IdUsuario = idUsuario;
            FechaYHoraIntento = fechaYHoraIntento;
        }

        public static UsuarioIntento Crear(Guid idUsuarioIntento, Guid idUsuario, DateTime fechaYHoraIntento)
        {
            return new UsuarioIntento(idUsuarioIntento, idUsuario, fechaYHoraIntento);
        }

        public UsuarioIntento(Guid idUsuario)
        {
            
            IdUsuario = idUsuario;
        }

        public static UsuarioIntento Crear( Guid idUsuario)
        {
            return new UsuarioIntento( idUsuario);
        }
    }
}
