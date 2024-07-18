namespace College.Forms
{
    partial class SelectCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewAll = new DataGridView();
            textBoxChoice = new TextBox();
            dataGridViewStudent = new DataGridView();
            LabelHeder = new Label();
            labelCoursesGrid = new Label();
            labelStudentGrid = new Label();
            buttonRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAll
            // 
            dataGridViewAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAll.Location = new Point(408, 90);
            dataGridViewAll.Name = "dataGridViewAll";
            dataGridViewAll.RowHeadersWidth = 62;
            dataGridViewAll.Size = new Size(360, 329);
            dataGridViewAll.TabIndex = 1;
            // 
            // textBoxChoice
            // 
            textBoxChoice.Location = new Point(396, 479);
            textBoxChoice.Name = "textBoxChoice";
            textBoxChoice.Size = new Size(150, 31);
            textBoxChoice.TabIndex = 2;
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Location = new Point(12, 90);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.RowHeadersWidth = 62;
            dataGridViewStudent.Size = new Size(360, 329);
            dataGridViewStudent.TabIndex = 1;
            // 
            // LabelHeder
            // 
            LabelHeder.AutoSize = true;
            LabelHeder.Location = new Point(174, 479);
            LabelHeder.Name = "LabelHeder";
            LabelHeder.Size = new Size(198, 25);
            LabelHeder.TabIndex = 0;
            LabelHeder.Text = "Enter Course to register";
            // 
            // labelCoursesGrid
            // 
            labelCoursesGrid.AutoSize = true;
            labelCoursesGrid.Location = new Point(461, 39);
            labelCoursesGrid.Name = "labelCoursesGrid";
            labelCoursesGrid.Size = new Size(251, 25);
            labelCoursesGrid.TabIndex = 0;
            labelCoursesGrid.Text = "select a course ID from the list";
            // 
            // labelStudentGrid
            // 
            labelStudentGrid.AutoSize = true;
            labelStudentGrid.Location = new Point(67, 39);
            labelStudentGrid.Name = "labelStudentGrid";
            labelStudentGrid.Size = new Size(279, 25);
            labelStudentGrid.TabIndex = 0;
            labelStudentGrid.Text = "You are registerd to these courses";
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(338, 573);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(112, 34);
            buttonRegister.TabIndex = 3;
            buttonRegister.Text = "Confirmation and proceed to payment";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click_1;
            // 
            // SelectCourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 645);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxChoice);
            Controls.Add(dataGridViewStudent);
            Controls.Add(dataGridViewAll);
            Controls.Add(labelCoursesGrid);
            Controls.Add(labelStudentGrid);
            Controls.Add(LabelHeder);
            Name = "SelectCourseForm";
            Text = "StudentRegistration";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewAll;
        private TextBox textBoxChoice;
        private DataGridView dataGridViewStudent;
        private Label LabelHeder;
        private Label labelCoursesGrid;
        private Label labelStudentGrid;
        private Button buttonRegister;
    }
}