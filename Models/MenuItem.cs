namespace lab1.Models
{
    public class MenuItem
    {
        private int id;
        private string name, link;

        public MenuItem(int id, string name, string link)
        {
            this.id = id;
            this.name = name;
            this.link = link;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Link { get => link; set => link = value; }
    }
}
