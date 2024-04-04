
using System.Collections;

namespace CAEnumerables
{
    internal class Employee : IEnumerable<PayTtem>
    {
        private readonly List<PayTtem> _payItems = new List<PayTtem>();
        //public string? Name { get; set; }

        public void AddPayItem(string name, int value)
        {

            _payItems.Add(new PayTtem {  Name = name, Value = value });
        }

        public IEnumerator<PayTtem> GetEnumerator()
        {
            return _payItems.GetEnumerator();
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    
}
