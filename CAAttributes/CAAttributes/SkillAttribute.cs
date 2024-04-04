namespace CAAttributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class SkillAttribute : Attribute
    {
        public string? Name { get; }
        public int Minimum { get; }
        public int Maximum { get; }
        public SkillAttribute(string? name, int minimum, int maximum)
        {
            Name = name;
            Minimum = minimum;
            Maximum = maximum;
        }

        public bool IsValid(object obj)
        {
            var value = (int)obj;
            return value >= Minimum && value <= Maximum;
        }
    }

}
