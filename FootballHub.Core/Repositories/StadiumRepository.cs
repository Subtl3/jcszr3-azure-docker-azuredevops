using Azure.Data.Tables;
using FootballHub.Core.Models;
using System;
using System.Collections.Generic;

namespace FootballHub.Core.Repositories
{
    public class StadiumRepository : ITableStorageRepository<Stadium>
    {
        private readonly TableClient _client;

        public StadiumRepository(TableClient client)
        {
            _client = client;
        }

        public void Delete(Stadium entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Stadium> GetByPartition(string partitionKey)
        {
            throw new NotImplementedException();
        }

        public void Insert(Stadium entity)
        {
            TableEntity ent = new TableEntity();
            ent.PartitionKey = entity.Name;
            ent.RowKey = entity.Name;
            ent["Capacity"] = entity.Capacity;

            _client.AddEntity(ent);
        }

        public void Update(Stadium entity)
        {
            throw new NotImplementedException();
        }
    }
}
