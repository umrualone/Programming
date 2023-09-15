using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Item
    {
        /// <summary>
        /// 
        /// </summary>
        private string _name;
        
        /// <summary>
        /// 
        /// </summary>
        private string _info;
        
        /// <summary>
        /// 
        /// </summary>
        private double _cost;

        /// <summary>
        /// 
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get => _name;
            set 
            {
                ValueValidator.AssertStringOnLength(value, 200, Name);
                _name = value; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, Info);
                _info = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double Cost
        {
            get => _cost;
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="info"></param>
        /// <param name="cost"></param>
        public Item(string name, string info, double cost)
        {
            Id = IdGenerator.NewIdItem();
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
