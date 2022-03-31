namespace Students.Client.Data
{
    public class prueba
    {
        public int Id { get; set; }
        public string Nif { get; set; }
        public string Name { get; set; }
        public string Last { get; set; }
        public string Phone { get; set; }

        public prueba(int id, string nif, string name, string last, string phone)
        {
            Id = id;
            Nif = nif;
            Name = name;
            Last = last;
            Phone = phone;
        }
    }
}
