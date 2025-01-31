namespace _31._01_lesson;

internal class Farm : BaseModel
{
    public string Name { get; set; }
    public string Id { get; set; }
    public Farmer Farmer { get; set; }
    public Animal[] Animals { get; set; } = new Animal[20];


    public Farm() { }
    public Farm(string name) { }

    public Farm(string name, string id)
    {
        Name = name;
        Id = id;
    }

    public Farm(string name, string id, Farmer farmer, Animal[] animals)
    {
        Name = name;
        Id = id;
        Farmer = farmer;
        Animals = animals;
    }

    public override string ToString()
    {
        return $"{Name} {Id}";
    }
}