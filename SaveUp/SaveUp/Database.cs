using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace SaveUp
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            // Datenbank erstellen
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Liste>().Wait();
        }

        // Daten Lesen
        public Task<List<Liste>> GetPeopleAsync()
        {
            return _database.Table<Liste>().ToListAsync();
        }

        // Daten in die Datenbank reinschreiben
        public Task<int> SaveListeAsync(Liste liste)
        {
            return _database.InsertAsync(liste);
        }
    }
}
