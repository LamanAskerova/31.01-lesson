namespace _31._01_lesson;

internal class Animal : BaseModel
{
    public string Name { get; set; }

    public int Id { get; set; }
    public string Farm { get; set; }
    public string Farmer { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public Animal()
    {

    }

    public Animal(string name, int id, string farm)
    {
        Name = name;
        Id = id;
        Farm = farm;
    }

    public Animal(string name, int id, string farm, string farmer)
    {
        Name = name;
        Id = id;
        Farm = farm;
        Farmer = farmer;
    }

    public override string ToString()
    {
        return $"{Name} {Farm} {Id}";
    }
}
