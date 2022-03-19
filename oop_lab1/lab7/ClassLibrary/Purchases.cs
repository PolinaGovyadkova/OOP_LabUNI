namespace Products
{
    /// <summary>
    /// Purchases
    /// </summary>
    public class Purchases
    {
        /// <summary>
        /// The dicount
        /// </summary>
        public Dicount dicount;

        /// <summary>
        /// The name
        /// </summary>
        private string _name;

        /// <summary>
        /// The cost
        /// </summary>
        private double _cost;

        /// <summary>
        /// Initializes a new instance of the <see cref="Purchases" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="dicount">The dicount.</param>
        public Purchases(string name, double cost, Dicount dicount)
        {
            this._name = name;
            this._cost = cost;
            this.dicount = dicount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Purchases" /> class.
        /// </summary>
        public Purchases()
        {
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>
        /// The cost.
        /// </value>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }

        /// <summary>
        /// Gets or sets the percent.
        /// </summary>
        /// <value>
        /// The percent.
        /// </value>
        public int Percent
        {
            get
            {
                return dicount.Percent;
            }
        }

        /// <summary>
        /// Calculates a discount for a product.
        /// </summary>
        /// <param name="cost">The cost.</param>
        /// <returns></returns>
        public double Discount(double cost)
        {
            double decimal_percentage;
            double new_percentage;
            double result_cost;
            decimal_percentage = 100 - Percent;
            new_percentage = decimal_percentage / 100;
            result_cost = cost * new_percentage;
            return result_cost;
        }

        /// <summary>
        /// Creates new cost.
        /// </summary>
        /// <value>
        /// The new cost.
        /// </value>
        public double NewCost
        {
            get
            {
                double _newcost = Discount(_cost);
                return _newcost;
            }
        }
    }
}