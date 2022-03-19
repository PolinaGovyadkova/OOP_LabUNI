using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    /// <summary>
    ///   <br />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddExercise : Form
    {
        /// <summary>
        /// The main form
        /// </summary>
        private MainForm mainForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddExercise"/> class.
        /// </summary>
        /// <param name="mainForm">The main form.</param>
        public AddExercise(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the AddExercise control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddExercise_Load(object sender, EventArgs e)
        {
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
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            int selectedType = type.SelectedIndex;
            try
            {
                if (type.SelectedItem == null)
                {
                    MessageBox.Show("Выберите упражнение");
                }
                else
                {
                    mainForm.training.AddExercise(dateTime.Value, selectedType);
                    mainForm.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            Close();
        }

        /// <summary>
        /// Handles the Click event of the label1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the label2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}