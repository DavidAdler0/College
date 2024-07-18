using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace College.Forms
{

    public partial class Student : Form
    {
        private DBcontext _dbContext;
        private FormHandler _formHandler;
        private string _name;

        public Student(DBcontext dbContext, FormHandler formHandler, string name)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _formHandler = formHandler;
            _name = name;
            labelName.Text = $"Hello {name}";
            DataTable courseResult = new DataTable();
            string courseQuery = @"SELECT CourseName, CycleNum,Startingdate,CoursePrice,CourseDays,CourseHours
                            FROM Courses c
                            inner join Registrations r on r.courseId = c.courseId
                            inner join Students s on r.StudentId = s.StudentId
                            where studentName = @studentName;";
            SqlParameter[] parameters = [new SqlParameter("@studentName", _name)];
            courseResult = _dbContext.ExecuteQuery(courseQuery, parameters);
            dataGridViewCourses.DataSource = courseResult;

            int statmentResult;
            string statmentQuery = "SELECT studentBalance FROM students where studentName = @studentName;";
            SqlParameter[] parameters1 = [new SqlParameter("@studentName", _name)];

            statmentResult = (int)_dbContext.ExecuteScalar(statmentQuery, parameters1);
            labelPaymentStatus.Text = $"Your outstanding balance is {statmentResult.ToString()}";



        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            return;
        }

        private void buttonCourse_Click(object sender, EventArgs e)
        {
            _formHandler.ShowSelectCourseForm(_name);

        }
    }
}
