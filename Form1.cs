using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Students
{
    public partial class AddStudent : Form
    {
        private List<StudentGroup> groups = new List<StudentGroup>();
        public AddStudent()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            groups.Add(new StudentGroup(1, "ET-214"));
            groups.Add(new StudentGroup(2, "ET-212"));

            groups[0].AddStudent("Петухов");
            groups[1].AddStudent("Семенов");
            groups[1].AddStudent("Никонов");

            comboBoxSelectAGroup.DataSource = groups;
            comboBoxSelectAGroup.SelectedIndex = 0;
        }

        private void addGroup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameOfGroup.Text))
            {
                MessageBox.Show("10X");
                return;
            }

            int newId = groups.Count + 1;
            StudentGroup studentGroup = new StudentGroup(newId, textBoxNameOfGroup.Text);
            groups.Add(studentGroup);
            textBoxNameOfGroup.Text = null;
            UpdateComboBox(groups);
        }

        private void UpdateComboBox(List<StudentGroup> groups)
        {
            comboBoxSelectAGroup.DataSource = null;
            comboBoxSelectAGroup.DataSource = groups;
            comboBoxSelectAGroup.SelectedIndex = groups.Count - 1;
        }

        private void comboBoxSelectAGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectAGroup.SelectedIndex < 0)
            {
                return;
            }

            UpdateListOfStudents(groups[comboBoxSelectAGroup.SelectedIndex].Students);
            textBoxNameSelectGroup.Text = comboBoxSelectAGroup.Text;
            textBoxGroupID.Text = groups[comboBoxSelectAGroup.SelectedIndex].Id.ToString();
        }

        private void UpdateListOfStudents(List<string> students)
        {
            listOfStudent.Items.Clear();

            foreach (var item in students)
            {
                listOfStudent.Items.Add(item);
            }
        }

        private void addSudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFullName.Text))
            {
                MessageBox.Show("Введите ФИО");
                return;
            }

            groups[comboBoxSelectAGroup.SelectedIndex].AddStudent(textBoxFullName.Text);
            textBoxFullName.Text = null;
            UpdateListOfStudents(groups[comboBoxSelectAGroup.SelectedIndex].Students);
        }

        private void buttonChangeGroup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameOfGroup.Text))
            {
                MessageBox.Show("Введите название группы");
                return;
            }

            groups[comboBoxSelectAGroup.SelectedIndex].Name = textBoxNameOfGroup.Text;
            UpdateComboBox(groups);
        }

        private void buttonChangeStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFullName.Text) || listOfStudent.SelectedItem == null)
            {
                MessageBox.Show("Введите ФИО и выберите студента для изменения");
                return;
            }

            groups[comboBoxSelectAGroup.SelectedIndex].ChangeStudent(textBoxFullName.Text, listOfStudent.SelectedIndex);
            textBoxFullName.Text = null;
            UpdateListOfStudents(groups[comboBoxSelectAGroup.SelectedIndex].Students);
        }
    }
}
