﻿using System.Diagnostics.CodeAnalysis;
using Gossip.Connection;
using Gossip.Connection.Fluent;
using Gossip.ConnectionStrings;

namespace Gossip.TestSupport.Adapters.Sqlite
{
    [ExcludeFromCodeCoverage]
    public class Sqlite : ISqlConnectionFactory
    {
        public ISqlConnection Create(IConnectionString connectionString)
        {
            return new SqliteConnection(connectionString.Value);
        }

        public IConnectionStringBuilder GetConnectionStringBuilder()
        {
            return new SqliteConnectionStringBuilder();
        }
    }
}