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
            groups[2].AddStudent("Никонов");
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
