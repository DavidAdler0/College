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
using System.Xml.Linq;

namespace College.Forms
{
    public partial class SelectCourseForm : Form
    {
        private DBcontext _dbContext;
        private FormHandler _formHandler;
        private string _name;


        public SelectCourseForm(DBcontext dbContext, FormHandler formHandler, string name)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _formHandler = formHandler;
            _name = name;
            
            DataTable studentResult = new DataTable();
            string studentQuery = @"SELECT CourseName, CycleNum,Startingdate,CoursePrice,CourseDays,CourseHours
                            FROM Courses c
                            inner join Registrations r on r.courseId = c.courseId
                            inner join Students s on r.StudentId = s.StudentId
                            where studentName = @studentName;";
            SqlParameter[] parameters = [new SqlParameter("@studentName", _name)];
            studentResult = _dbContext.ExecuteQuery(studentQuery, parameters);
            dataGridViewStudent.DataSource = studentResult;

            DataTable allResult = new DataTable();
            string allQuery = @"SELECT CourseId, CourseName, CycleNum,Startingdate,CoursePrice,CourseDays,CourseHours
                            FROM Courses c
                            inner join Registrations r on r.courseId = c.courseId
                            inner join Students s on r.StudentId = s.StudentId";
            studentResult = _dbContext.ExecuteQuery(allQuery, null);
            dataGridViewAll.DataSource = studentResult;

        }
        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            int result;
            string query = @"SELECT *
                            FROM Courses c
                            inner join Registrations r on r.courseId = c.courseId
                            inner join Students s on r.StudentId = s.StudentId
                            where studentName = @studentName and courseId = @courseId;";
            SqlParameter[] parameters = [new SqlParameter("@studentName", _name), new SqlParameter("@courseId", int.Parse(textBoxChoice.Text))];
            result = _dbContext.ExecuteNonQuery(query, parameters);
            if (result != 0)
            {
                MessageBox.Show("You are already registered to this course!");
                return;
            }

            int id;
            string idQuery = @"select StudentId from students
                              where StudentName = 'tsachi';";
            SqlParameter[] parameters1 = [new SqlParameter("@studentName", _name)];
            id = (int)_dbContext.ExecuteScalar(idQuery, parameters1);

          
            string updatequery = @"insert into Registrations (StudentId, courseId)
                                  values (@StudentId, @courseId)";
            SqlParameter[] parameters2 = [new SqlParameter("@StudentId", id), new SqlParameter("@courseId", int.Parse(textBoxChoice.Text))];
            _dbContext.ExecuteNonQuery(updatequery, parameters2);
            MessageBox.Show("proceeding to payment!");
            
            DataTable studentResult = new DataTable();
            string studentQuery = @"SELECT CourseName, CycleNum,Startingdate,CoursePrice,CourseDays,CourseHours
                            FROM Courses c
                            inner join Registrations r on r.courseId = c.courseId
                            inner join Students s on r.StudentId = s.StudentId
                            where studentName = @studentName;";
            SqlParameter[] parameters3 = [new SqlParameter("@studentName", _name)];
            studentResult = _dbContext.ExecuteQuery(studentQuery, parameters3);
            dataGridViewStudent.DataSource = studentResult;

            int price;
            string priceQuery = @"";
            SqlParameter[] parameters4 = [new SqlParameter("@courseId", int.Parse(textBoxChoice.Text))];
            price = (int)_dbContext.ExecuteScalar(priceQuery, parameters4);


        }


    }
}
