using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void addGroup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNameSelectGroup.Text))
            {
                int newId = groups.Count + 1;
                StudentGroup studentGroup = new StudentGroup(newId,textBoxNameSelectGroup.Text);
                groups.Add(studentGroup);
                comboBoxSelectAGroup.DataSource= null;
                comboBoxSelectAGroup.DataSource= groups;
                comboBoxSelectAGroup.SelectedItem = studentGroup;

            }

        }
    }
}
