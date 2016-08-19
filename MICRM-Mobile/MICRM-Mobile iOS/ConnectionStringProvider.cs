using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIML.CRMInterface;

namespace MICRM_Mobile
{
    class ConnectionStringProvider : IConnectionStringProvider
    {
        public string ConnectionString()
        {
            return @"DATA SOURCE=vmSQL02.nero.systems;Initial Catalog=CRM;User Id=Android;Password=Android1;";
        }

        public string ConnectionString(ConnectionStringProviderEnum type)
        {
            return ConnectionString();
        }
    }
}