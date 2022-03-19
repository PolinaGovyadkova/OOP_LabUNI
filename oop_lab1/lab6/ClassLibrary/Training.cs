using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FitnessCenter
{
    /// <summary>
    ///
    /// </summary>
    enum ExerciseType
    {
        /// <summary>
        /// The fitness yoga
        /// </summary>
        Fitness_yoga,

        /// <summary>
        /// The stretching
        /// </summary>
        Stretching,

        /// <summary>
        /// The bodyflex
        /// </summary>
        Bodyflex,

        /// <summary>
        /// The fitball
        /// </summary>
        Fitball,

        /// <summary>
        /// The nordic walking
        /// </summary>
        Nordic_walking,

        /// <summary>
        /// The pilates
        /// </summary>
        Pilates,

        /// <summary>
        /// The callanetic
        /// </summary>
        Callanetic,

        /// <summary>
        /// The anaerobic load
        /// </summary>
        Anaerobic_load,

        /// <summary>
        /// The butterfly
        /// </summary>
        Butterfly,

        /// <summary>
        /// The burpee
        /// </summary>
        Burpee,

        /// <summary>
        /// The pancake
        /// </summary>
        Pancake,

        /// <summary>
        /// The gainer
        /// </summary>
        Gainer
    }

    /// <summary>
    /// Training
    /// </summary>
    public class Training
    {
        /// <summary>
        ///
        /// </summary>
        private class Exercise
        {
            /// <summary>
            /// The data
            /// </summary>
            private DateTime _data;

            /// <summary>
            /// The end data
            /// </summary>
            private DateTime _end_data;

            /// <summary>
            /// The type of exercise
            /// </summary>
            private string _type_of_exercise;

            /// <summary>
            /// The exercise time
            /// </summary>
            private int[] _exercise_time = { 60, 120, 30, 50, 30, 60, 45, 120, 30, 60, 120, 30 };

            /// <summary>
            /// The number of exercise
            /// </summary>
            private int _number_of_exercise;

            /// <summary>
            /// Initializes a new instance of the <see cref="Exercise"/> class.
            /// </summary>
            /// <param name="data">The data.</param>
            /// <param name="number_of_exercise">The number of exercise.</param>
            public Exercise(DateTime data, int number_of_exercise)
            {
                this._number_of_exercise = number_of_exercise;
                this._data = data;
                this._end_data = data.AddMinutes(Convert.ToDouble(_exercise_time[_number_of_exercise]));
                this._type_of_exercise = Enum.GetName(typeof(ExerciseType), number_of_exercise);
            }

            /// <summary>
            /// Gets or sets the data.
            /// </summary>
            /// <value>
            /// The data.
            /// </value>
            internal DateTime Data
            {
                get
                {
                    return _data;
                }
                set
                {
                    _data = value;
                }
            }

            /// <summary>
            /// Gets or sets the end data.
            /// </summary>
            /// <value>
            /// The end data.
            /// </value>
            internal DateTime EndData
            {
                get
                {
                    return _end_data;
                }
                set
                {
                    _end_data = value;
                }
            }

            /// <summary>
            /// Gets or sets the type of exercise.
            /// </summary>
            /// <value>
            /// The type of exercise.
            /// </value>
            internal string TypeOfExercise
            {
                get
                {
                    return _type_of_exercise;
                }
                set
                {
                    _type_of_exercise = value;
                }
            }

            /// <summary>
            /// Gets or sets the number of exercise.
            /// </summary>
            /// <value>
            /// The number of exercise.
            /// </value>
            internal int NumberOfExercise
            {
                get
                {
                    return _number_of_exercise;
                }
                set
                {
                    _number_of_exercise = value;
                }
            }
        }

        /// <summary>
        /// The exercise time
        /// </summary>
        int[] _exercise_time = { 60, 120, 30, 50, 30, 60, 45, 120, 30, 60, 120, 30 };

        /// <summary>
        /// The exercise array
        /// </summary>
        private Exercise[] _exercise_array = new Exercise[] { };

        /// <summary>
        /// The index
        /// </summary>
        public int index = 0;

        /// <summary>
        /// Gets the get lenght.
        /// </summary>
        /// <value>
        /// The get lenght.
        /// </value>
        public int GetLenght
        {
            get
            {
                return _exercise_array.Length;
            }
        }

        /// <summary>
        /// Gets or sets the get data.
        /// </summary>
        /// <value>
        /// The get data.
        /// </value>
        public DateTime GetData
        {
            get
            {
                return _exercise_array[index].Data;
            }
            set
            {
                _exercise_array[index].Data = value;
            }
        }

        /// <summary>
        /// Gets or sets the get end data.
        /// </summary>
        /// <value>
        /// The get end data.
        /// </value>
        public DateTime GetEndData
        {
            get
            {
                return _exercise_array[index].EndData;
            }
            set
            {
                _exercise_array[index].EndData = value;
            }
        }

        /// <summary>
        /// Gets or sets the get type of exercise.
        /// </summary>
        /// <value>
        /// The get type of exercise.
        /// </value>
        public string GetTypeOfExercise
        {
            get
            {
                return _exercise_array[index].TypeOfExercise;
            }
            set
            {
                _exercise_array[index].TypeOfExercise = value;
            }
        }

        /// <summary>
        /// Alls the exercise.
        /// </summary>
        /// <param name="low_date">The low date.</param>
        /// <param name="high_date">The high date.</param>
        /// <returns></returns>
        public string AllExercise(DateTime low_date, DateTime high_date)
        {
            int count_of_exercise = 0;
            for (int i = 0; i < _exercise_array.Length; i++)
            {
                if (_exercise_array[i].Data >= low_date && _exercise_array[i].EndData <= high_date)
                {
                    count_of_exercise++;
                }
            }
            File.WriteAllText("D:\\ AllExercise.txt", Convert.ToString(count_of_exercise));
            return Convert.ToString(count_of_exercise);
        }

        /// <summary>
        /// Populars the type of exercise.
        /// </summary>
        /// <param name="low_date">The low date.</param>
        /// <param name="high_date">The high date.</param>
        /// <returns></returns>
        public string PopularTypeOfExercise(DateTime low_date, DateTime high_date)
        {
            int[] count_of_exercise = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            List<string> type = new List<string>() { };
            for (int i = 0; i < _exercise_array.Length; i++)
            {
                if (_exercise_array[i].Data >= low_date && _exercise_array[i].EndData <= high_date)
                {
                    count_of_exercise[_exercise_array[i].NumberOfExercise]++;
                    type.Add(_exercise_array[i].TypeOfExercise);
                }
            }

            //SelectMany(x => x.Split(...)) в качестве х последовательность,
            //которую надо проецировать, а в качестве x.Split(...) - функцию преобразования, т.е.
            // разделяем по пространству: с помощью String.Split и удаляем пустые строки, затем группируем по каждоиу слову
            // и упорядочиваем по убыванию "употребления?" слова.
            // в конце, получем первый элемент (слово) по кол-ву употребления.
            string exercise_type = type.SelectMany(x => x.Split(new[] { " " },
                                      StringSplitOptions.RemoveEmptyEntries)).
                                      GroupBy(x => x).
                                      OrderByDescending(x => x.Count()).
                                      Select(x => x.Key).
                                      First();
            File.WriteAllText("D:\\PopularTypeOfExercise.txt", exercise_type);
            return Convert.ToString(count_of_exercise.Max()) + exercise_type;
        }

        /// <summary>
        /// Totals the exercise.
        /// </summary>
        /// <param name="low_date">The low date.</param>
        /// <param name="high_date">The high date.</param>
        /// <param name="number_of_exercise">The number of exercise.</param>
        /// <returns></returns>
        public string TotalExercise(DateTime low_date, DateTime high_date, int number_of_exercise)
        {
            int count = 0;

            for (int i = 0; i < _exercise_array.Length; i++)
            {
                if (_exercise_array[i].Data >= low_date && _exercise_array[i].EndData <= high_date)
                {
                    if (_exercise_array[i].NumberOfExercise == number_of_exercise)
                    {
                        count++;
                    }
                }
            }
            File.WriteAllText("D:\\TotalExercise.txt", Convert.ToString(count));
            return Convert.ToString(count);
        }

        /// <summary>
        /// Adds the exercise.
        /// </summary>
        /// <param name="new_data">The new data.</param>
        /// <param name="number_of_exercise">The number of exercise.</param>
        public void AddExercise(DateTime new_data, int number_of_exercise)
        {
            index = _exercise_array.Length + 1;
            Array.Resize(ref _exercise_array, index--);
            _exercise_array[index] = new Exercise(new_data, number_of_exercise);
        }

        /// <summary>
        /// Edits the exercise.
        /// </summary>
        /// <param name="new_data">The new data.</param>
        /// <param name="number_of_exercise">The number of exercise.</param>
        /// <param name="i">The i.</param>
        public void EditExercise(DateTime new_data, int number_of_exercise, int i)
        {
            _exercise_array[i].Data = new_data;
            _exercise_array[i].EndData = new_data.AddMinutes(Convert.ToDouble(_exercise_time[number_of_exercise]));
            _exercise_array[i].TypeOfExercise = Enum.GetName(typeof(ExerciseType), number_of_exercise);
            _exercise_array[i].NumberOfExercise = number_of_exercise;
        }
    }
}