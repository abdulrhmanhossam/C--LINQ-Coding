using System.Diagnostics;

namespace CAAttributes
{
    [DebuggerDisplay("Number: {_number}, Title: {_title}")]
    class Update
    {
        private int _number;
        private string? _title;

        public Update(int number, string? title)
        {
            _number = number;
            _title = title;
        }
        
        public override string ToString()
        {
            return $"{_number} - {_title}";
        }
    }
}
