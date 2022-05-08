using SQLite;

namespace SaveUp
{
    public class Liste
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Beschreibung { get; set; }
        public int Geld { get; set; }
    }
}
