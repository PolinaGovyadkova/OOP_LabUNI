using FitnessCenter;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    /// <summary>
    /// MainForm
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        /// <summary>
        /// The training
        /// </summary>
        public Training training;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.training = new Training();
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the 1 event of the dataGridView1_CellContentClick control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            AddExercise addExercise = new AddExercise(this);
            addExercise.Show();
        }

        /// <summary>
        /// Handles the Click event of the button2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(training.PopularTypeOfExercise(date1.Value, date2.Value));
            }
            catch
            {
                MessageBox.Show("Последовательность не содержит элементов");
            }
        }

        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (training.TotalExercise(date1.Value, date2.Value, comboBox1.SelectedIndex) == "0")
                {
                    MessageBox.Show("Надо выбрать упражнение из списка");
                }
                else MessageBox.Show(training.TotalExercise(date1.Value, date2.Value, comboBox1.SelectedIndex));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        /// <summary>
        /// Handles the Click event of the button4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (training.AllExercise(date1.Value, date2.Value) == "0")
                {
                    MessageBox.Show("Нет выполенных упражнений");
                }
                else MessageBox.Show(training.AllExercise(date1.Value, date2.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the comboBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the ValueChanged event of the dateTimePicker2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the ValueChanged event of the dateTimePicker1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the CellContentClick event of the dataGridView1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        /// Creates new table.
        /// </summary>
        public void Update()
        {
            training.index = 0;
            Table.RowCount = training.GetLenght;
            for (int i = 0; i < training.GetLenght; i++)
            {
                training.index = i;
                Table.Rows[i].Cells[0].Value = training.GetData;
                Table.Rows[i].Cells[1].Value = training.GetEndData;
                Table.Rows[i].Cells[2].Value = training.GetTypeOfExercise;
            }
        }

        /// <summary>
        /// Handles the Click event of the button6 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button6_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(this);
            edit.Show();
        }
    }
}