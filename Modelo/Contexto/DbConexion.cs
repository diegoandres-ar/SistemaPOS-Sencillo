﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelos
{
    public partial class DbConexion : DbContext
    {
        private DbConexion(string cadenaConexion) : base(cadenaConexion)
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Database.CommandTimeout = 900;
        }

        public static DbConexion CrearConexion()
        {
            return new DbConexion("name:DbConexion");
        }

    }
}
