class Worker
{
    public Worker(string duties , string type)
    {
        Duties = duties;
        Type = type;
    }

    public string Duties {  get; set; }
    public string Type {  get; set; }

    public virtual void Work()
    {
        Console.WriteLine($"{Type}在做{Duties}");
    }
}
class Programmer : Worker
{
    public Programmer(string duties , string type) : base(duties , type) { }
}
class Planner : Worker
{
    public Planner(string duties, string type) : base(duties , type) { }
}
class Artist : Worker
{
    public Artist(string duties, string type) : base (duties , type) { }
}
 
