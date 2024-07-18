using College.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{

    public class FormHandler
    {


        private DBcontext _dbContext;
        public FormHandler(DBcontext dbContext)
        {
            _dbContext = dbContext;
        }

        public static void CloseAll()
        {
        List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
        foreach (Form item in openForms)
            {
                item.Hide();
            }
        }
        public void ShowLoginForm()
        {
            CloseAll();
            Form form = new LoginForm(_dbContext, this);
            form.Show();

        }
        public void ShowStudentForm(string name)
        {
            CloseAll();
            Form form = new Student(_dbContext, this, name);
            form.Show();

        }
        public void ShowSelectCourseForm(string name)
        {
            CloseAll();
            Form form = new SelectCourseForm(_dbContext, this, name);
            form.Show();

        }
    }
}
