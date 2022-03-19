using Products.Discount;
using System;

namespace Products
{
    /// <summary>
    /// ListOfPurchases
    /// </summary>
    public class ListOfPurchases
    {
        /// <summary>
        /// The purchases
        /// </summary>
        public Purchases[] purchases = new Purchases[] { };

        /// <summary>
        /// The index
        /// </summary>
        public int index = 0;

        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int Length
        {
            get
            {
                return purchases.Length;
            }
        }

        //модификатор virtual для переопределения методов в тестах.
        /// <summary>
        /// All cost by type.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public virtual string AllCostByType(string name)
        {
            double all_cost = 0;
            double all_cost_with_discount = 0;
            int count = 0;
            for (int i = 0; i < purchases.Length; i++)
            {
                if (purchases[i].Name == name)
                {
                    count++;
                    all_cost += purchases[i].Cost;
                    all_cost_with_discount += purchases[i].NewCost;
                }
            }
            if (count != 0)
            {
                all_cost /= count;
                all_cost_with_discount /= count;
            }
            else all_cost = 0;
            return "Цена без скидки: " + Convert.ToString(all_cost) + "\nЦена со скидкой: " + Convert.ToString(all_cost_with_discount);
        }

        /// <summary>
        /// All count by type.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public virtual string AllCountByType(string name)
        {
            int count = 0;
            for (int i = 0; i < purchases.Length; i++)
            {
                if (purchases[i].Name == name)
                {
                    count++;
                }
            }
            return Convert.ToString(count);
        }

        /// <summary>
        /// Total cost.
        /// </summary>
        /// <returns></returns>
        public virtual string TotalCost()
        {
            double all_cost_with_discount = 0;
            double all_cost = 0;

            for (int i = 0; i < purchases.Length; i++)
            {
                all_cost_with_discount += purchases[i].NewCost;
                all_cost += purchases[i].Cost;
            }
            return "Цена без скидки: " + Convert.ToString(all_cost) + "\nЦена со скидкой: " + Convert.ToString(all_cost_with_discount);
        }

        /// <summary>
        /// Submitted units.
        /// </summary>
        /// <returns></returns>
        public virtual string SubmittedUnits()
        {
            int count = 0;
            for (int i = 0; i < purchases.Length; i++)
            {
                if (purchases[i].Percent != 0)
                {
                    count++;
                }
            }
            return Convert.ToString(count);
        }

        /// <summary>
        /// Add the product.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="disc">The disc.</param>
        public void Add(string name, double cost, Dicount disc)
        {
            index = purchases.Length + 1;
            Array.Resize(ref purchases, index--);
            switch (name)
            {
                case "Ботинки":
                    {
                        purchases[index] = new Boots(name, cost, disc);
                        break;
                    }
                case "Пальто":
                    {
                        purchases[index] = new Coat(name, cost, disc);
                        break;
                    }
                case "Шапка":
                    {
                        purchases[index] = new Hat(name, cost, disc);
                        break;
                    }
                case "Худи":
                    {
                        purchases[index] = new Hoodie(name, cost, disc);
                        break;
                    }
                case "Куртка":
                    {
                        purchases[index] = new Jacket(name, cost, disc);
                        break;
                    }
                case "Джинсы":
                    {
                        purchases[index] = new Jeans(name, cost, disc);
                        break;
                    }
                case "Рубашка":
                    {
                        purchases[index] = new Shirt(name, cost, disc);
                        break;
                    }
                case "Шорты":
                    {
                        purchases[index] = new Shorts(name, cost, disc);
                        break;
                    }
                case "Кроссовки":
                    {
                        purchases[index] = new Sneakers(name, cost, disc);
                        break;
                    }
                case "Носки":
                    {
                        purchases[index] = new Socks(name, cost, disc);
                        break;
                    }
                case "Топ":
                    {
                        purchases[index] = new Top(name, cost, disc);
                        break;
                    }
                default:
                    {
                        purchases[index] = new NewProducts(name, cost, disc);
                        break;
                    }
            }
        }

        /// <summary>
        /// Edits the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="disc">The disc.</param>
        /// <param name="i">The i.</param>
        public void Edit(string name, double cost, Dicount disc, int i)
        {
            purchases[i].Name = name;
            purchases[i].Cost = cost;
            purchases[i].dicount = disc;
        }

        /// <summary>Selecteds the discount.</summary>
        /// <param name="discount">The discount.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public Dicount SelectedDiscount(string discount)
        {
            Dicount disc;
            switch (int.Parse(discount))
            {
                case 0: disc = new Dicount(); return disc;
                case 10: disc = new Dicount10(); return disc;
                case 25: disc = new Dicount25(); return disc;
                default: disc = new MyDiscount(int.Parse(discount)); return disc;
            }
        }
    }
}