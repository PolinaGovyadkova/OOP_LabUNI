using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    /// <summary>
    /// Edit
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Edit : Form
    {
        /// <summary>
        /// The main form
        /// </summary>
        private MainForm mainForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="Edit" /> class.
        /// </summary>
        /// <param name="mainForm">The main form.</param>
        public Edit(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            Initializer();
        }

        /// <summary>
        /// Handles the Load event of the Edit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Edit_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the type control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the ValueChanged event of the dateTime control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Initializers this instance.
        /// </summary>
        private void Initializer()
        {
            try
            {
                int index = mainForm.Table.CurrentRow.Index;
                dateTime.Value = (DateTime)mainForm.Table.Rows[index].Cells[0].Value;
                type.Text = (string)mainForm.Table.Rows[index].Cells[2].Value;
            }
            catch
            {
                MessageBox.Show("Выберите упражнение");
            }
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mainForm.training.EditExercise(dateTime.Value, type.SelectedIndex, mainForm.Table.CurrentRow.Index);
                mainForm.Update();
            }
            catch
            {
                MessageBox.Show("Индекс находится вне границ");
            }
            Close();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the comboBox2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}