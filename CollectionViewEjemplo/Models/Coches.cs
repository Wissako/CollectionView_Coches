using SQLite;

namespace CollectionViewEjemplo.Models
{
    public class Coches
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nombreCoche { get; set; }
        public string marcaCoche { get; set; }
        public string cocheUrl { get; set; }
        public string Origen { get; set; }
    }
}