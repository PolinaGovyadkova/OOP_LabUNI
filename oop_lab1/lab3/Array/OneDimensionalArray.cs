using System;

namespace Array
{
    /// <summary>
    ///OneDimensionalArray
    /// </summary>
    public class OneDimensionalArray
    {
        /// <summary>
        /// The array
        /// </summary>
        public double[] array;

        /// <summary>
        /// The array name
        /// </summary>
        public string array_name;

        /// <summary>
        /// Gets the length of the array.
        /// </summary>
        /// <value>
        /// The length of the array.
        /// </value>
        public int GetLength()
        {
            return array.Length;
        }

        /// <summary>
        /// Gets or sets the <see cref="System.Double"/> at the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="System.Double"/>.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public double this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneDimensionalArray"/> class.
        /// </summary>
        /// <param name="array_name">Name of the array.</param>
        public OneDimensionalArray(string array_name)
        {
            this.array_name = array_name;
            array = new double[] { };

            //Для работоспособоности теста.
            array = new double[] { -1, -2, 4, -3 };
        }

        /// <summary>
        /// Gets the dimensional array.
        /// </summary>
        public void GetDimensionalArray(int size)
        {
            array = new double[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
        }

        /// <summary>
        /// Negativ elements of the arrays A and C.
        /// </summary>
        public int NegativElements()
        {
            int count = 0;
            try
            {
                for (int i = 0; i < GetLength(); i++)
                {
                    if (array[i] < 0)
                    {
                        count++;
                    }
                }
            }
            catch
            {
                count = 0;
            }
            return count;
        }

        /// <summary>Negativs the elements.</summary>
        /// <param name="item">The item.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public int NegativElements(double item)
        {
            int count = 0;
            try
            {
                for (int i = 0; i < GetLength(); i++)
                {
                    if (i > item && array[i] < 0)
                    {
                        count++;
                    }
                }
            }
            catch
            {
                count = 0;
            }
            return count;
        }

        /// <summary>
        /// Implements the operator *.
        /// </summary>
        /// <param name="ArrayA">The array a.</param>
        /// <param name="ArrayC">The array c.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static OneDimensionalArray operator *(OneDimensionalArray ArrayA, OneDimensionalArray ArrayC)
        {
            OneDimensionalArray NewArray = new OneDimensionalArray(ArrayA.array_name + "*" + ArrayC.array_name);
            if (ArrayA.GetLength() == ArrayC.GetLength())
            {
                NewArray.array = new double[ArrayA.GetLength()];
                for (int i = 0; i < NewArray.GetLength(); i++)
                {
                    NewArray[i] = ArrayA[i] * ArrayC[i];
                }
            }
            return NewArray;
        }

        /// <summary>Arrays for ab.</summary>
        /// <returns>
        ///  New array[500]
        /// </returns>
        public double[] ArrayAB()
        {
            double[] newarray = new double[501];
            bool flag = false;
            try
            {
                for (int i = 0; i < GetLength(); i++)
                {
                    if (array[i] < 0 && array[i] > -5.3)
                    {
                        flag = true;
                        break;
                    }
                    else flag = false;
                }
                if (flag == true)
                {
                    Random rand = new Random();
                    for (int j = 1; j <= 500; j++)
                    {
                        newarray[j] = rand.Next(500);
                        if (j % 10 == 0)
                        {
                            newarray[j] = 0;
                        }
                    }
                }
            }
            catch
            { }
            return newarray;
        }
    }
}