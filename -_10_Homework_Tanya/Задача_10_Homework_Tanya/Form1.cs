using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задача_10_Homework_Tanya
{
    public partial class Form1 : Form
    {
        // the "//" things are just notes, i am entering them here to read everything i need to know or learn.
        // Of course, you can read the notes.
        public Form1()
        {
            InitializeComponent();
        }

        private List<Student> students = new List<Student>();

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // what is null?? well null means "no object", it simply means nothing to be there.
            //making a message to pop up on the screen when the textBox and comboBox is empty.
            if (textBoxName.Text == null || textBoxName.Text == "" || comboBoxCourses.SelectedItem == null) 
            {
                // a message will pop up when everything is empty
                MessageBox.Show("Please enter a name and of course select the course", "Valid Error");
                return;
            }

            //adding the student like a list
            // SelectedItem: property to an object, the ComboBox attempts to make that object the currently selected one in the list.
            Student student = new Student();
            student.Name = textBoxName.Text;
            student.Course = comboBoxCourses.SelectedItem.ToString();
            students.Add(student);

            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = students;

            //what is SelectedIndex: indicates the zero-based index of the currently selected item in the combo box list.
            textBoxName.Clear();
            comboBoxCourses.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //This is for the comboBoxCourses
            comboBoxCourses.Items.Add("Programming");
            comboBoxCourses.Items.Add("Math");
            comboBoxCourses.Items.Add("Physics");
            comboBoxCourses.Items.Add("Chemistry");
        }
    }

    public class Student 
    {
        // for the student
        public string Name { get; set; }
        public string Course { get; set; }
    }

}
