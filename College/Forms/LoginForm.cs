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

namespace College.Forms
{
    public partial class LoginForm : Form
    {
        private DBcontext _dbContext;
        private FormHandler _formHandler;

        public LoginForm(DBcontext dbContext, FormHandler formHandler)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _formHandler = formHandler;

        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DataTable result = new DataTable();
            string query = "select StudentId, StudentName from Students where StudentId =@StudentId and StudentName =@StudentName;";
            SqlParameter[] parameters = [new SqlParameter("@StudentId", int.Parse(textBoxId.Text)), new SqlParameter("@StudentName", textBoxName.Text)];
            result = _dbContext.ExecuteQuery(query, parameters);
            string studentId = result.Rows[0]["StudentId"].ToString();
            string studentName = result.Rows[0]["StudentName"].ToString();
            if (studentId == "" || studentName == "")
            {
                MessageBox.Show("נרשמת בהצלחה");
            }
            else
            { 
                MessageBox.Show("אתה תסטודנט רשום במכללה");

            }
            _formHandler.ShowStudentForm(studentName);

        }
    }
}
