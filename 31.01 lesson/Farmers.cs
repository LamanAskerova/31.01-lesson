namespace _31._01_lesson;

internal class Farmer : BaseModel
{
    public string Name { get; set; }
    public string Id { get; set; }
    public string NameofFarm { get; set; }


    public Farmer() { }

    public Farmer(int id) { }

    public Farmer(string name, string id, string nameofFarm)
    {
        this.Name = name;
        Id = id;
        NameofFarm = nameofFarm;
    }

    public override string ToString()
    {
        return $"{Name} {NameofFarm} {Id}";
    }
}
