using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        private List<Student> students;
        public MainWindow()
        {
            DataContext = new MainWindowVM();
            InitializeComponent();
            students = new List<Student>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected students
            List<Student> selectedStudents = GetSelectedStudents();

            if (selectedStudents.Count == 0)
            {
                MessageBox.Show("No students selected.");
                return;
            }

            foreach (Student student in selectedStudents)
            {
                EditStudentName(student);
            }

            MessageBox.Show("Selected students' names have been edited successfully.");

            // Update the UI or perform any other necessary actions
        }

        private List<Student> GetSelectedStudents()
        {

            List<Student> selectedStudents = new List<Student>();

            
            // Get the selected students from the UI or any other source
            // Example: Assuming you have a ListBox named "studentListBox" where multiple students can be selected
            // Iterate through the ListBox's SelectedItems and add them to the selectedStudents list
            foreach (var selectedItem in studentListBox.SelectedItems)
            {
                if (selectedItem is Student selectedStudent)
                {
                    selectedStudents.Add(selectedStudent);
                }
            }

            return selectedStudents;
        }

        private void EditStudentName(Student student)
        {
            // Prompt the user to enter the new name for the student
            string newName = PromptUserForName();

            // Edit the student's name
            student.Name = newName;
        }

        private string PromptUserForName()
        {
            YourInputDialog inputDialog = new YourInputDialog();
            bool? dialogResult = inputDialog.ShowDialog();

            if (dialogResult == true)
            {
                return inputDialog.Name;
            }
            else
            {
                return string.Empty;
            }
        }

    }

    internal class YourInputDialog
    {
        public string Name { get; internal set; }

        internal bool? ShowDialog()
        {
            throw new NotImplementedException();
        }
    }

    
   
}
