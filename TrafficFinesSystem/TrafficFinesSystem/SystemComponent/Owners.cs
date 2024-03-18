namespace TrafficFinesSystem.SystemComponent
{
    public class Owners
    {
        public string Name { get; set; }
        public List<Fines> Fines { get; set; } = new List<Fines>();
    }
}
