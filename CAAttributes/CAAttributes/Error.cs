namespace CAAttributes
{
    public class Error
    {
        private string? _field;
        private string? _description;

        public Error(string? field, string? description)
        {
            _field = field;
            _description = description;
        }

        public override string ToString()
        {
            return $"{{\"{_field}\": \"{_description}\" }}";
        }
    }
    
}
