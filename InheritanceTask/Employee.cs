namespace InheritanceTask
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public Employee(string name)
        {
            Name = name;
        }

        public abstract decimal Salary();

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}