using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class ConexionString
    {
        private static ConexionString _strconexionBdSql;
        private readonly string _defaultConexionSqlServer;

        public ConexionString()
        {
            _defaultConexionSqlServer = "Server=DESKTOP-GUSKUDA;Database=PuntoVenta;Trusted_Connection=True;";
        }



        public static ConexionString StrConexionBdSql
        {
            get
            {
                if (_strconexionBdSql == null)
                    _strconexionBdSql = new ConexionString();

                return _strconexionBdSql;

            }

        }

        public string DefaultConexionSqlServer => _defaultConexionSqlServer;
    }
}
