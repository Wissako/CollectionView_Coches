using SQLite;
using CollectionViewEjemplo.Models;

namespace CollectionViewEjemplo.Services
{
    public class DatabaseService
    {
        private SQLiteAsyncConnection _database;

        async Task Init()
        {
            if (_database is not null) return;

            _database = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, "Coches.db3"));
            await _database.CreateTableAsync<Coches>();
        }

        public async Task<List<Coches>> GetCochesAsync()
        {
            await Init();
            return await _database.Table<Coches>().ToListAsync();
        }

        public async Task<int> SaveCocheAsync(Coches coche)
        {
            await Init();
            return await _database.InsertAsync(coche);
        }

        // Método para cargar datos iniciales si la tabla está vacía
        public async Task SeedDataAsync(List<Coches> initialData)
        {
            await Init();
            var count = await _database.Table<Coches>().CountAsync();
            if (count == 0)
            {
                await _database.InsertAllAsync(initialData);
            }
        }
    }
}