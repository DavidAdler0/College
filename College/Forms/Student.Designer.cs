namespace College.Forms
{
    partial class Student
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
            dataGridViewCourses = new DataGridView();
            labelName = new Label();
            labelPaymentStatus = new Label();
            buttonPayment = new Button();
            buttonCourse = new Button();
            labelGridTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Location = new Point(118, 97);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.RowHeadersWidth = 62;
            dataGridViewCourses.Size = new Size(360, 225);
            dataGridViewCourses.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(262, 26);
            labelName.Name = "labelName";
            labelName.Size = new Size(53, 25);
            labelName.TabIndex = 3;
            labelName.Text = "שלום";
            // 
            // labelPaymentStatus
            // 
            labelPaymentStatus.AutoSize = true;
            labelPaymentStatus.Location = new Point(231, 383);
            labelPaymentStatus.Name = "labelPaymentStatus";
            labelPaymentStatus.Size = new Size(173, 25);
            labelPaymentStatus.TabIndex = 4;
            labelPaymentStatus.Text = "יתרת החוב שלך הוא:";
            // 
            // buttonPayment
            // 
            buttonPayment.Location = new Point(441, 451);
            buttonPayment.Name = "buttonPayment";
            buttonPayment.Size = new Size(112, 34);
            buttonPayment.TabIndex = 5;
            buttonPayment.Text = "תשלום";
            buttonPayment.UseVisualStyleBackColor = true;
            buttonPayment.Click += buttonPayment_Click;
            // 
            // buttonCourse
            // 
            buttonCourse.Location = new Point(34, 451);
            buttonCourse.Name = "buttonCourse";
            buttonCourse.Size = new Size(171, 34);
            buttonCourse.TabIndex = 6;
            buttonCourse.Text = "הרשמה לקורס";
            buttonCourse.UseVisualStyleBackColor = true;
            buttonCourse.Click += buttonCourse_Click;
            // 
            // labelGridTitle
            // 
            labelGridTitle.AutoSize = true;
            labelGridTitle.Location = new Point(244, 69);
            labelGridTitle.Name = "labelGridTitle";
            labelGridTitle.Size = new Size(119, 25);
            labelGridTitle.TabIndex = 7;
            labelGridTitle.Text = "הקורסים שלך";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 497);
            Controls.Add(labelGridTitle);
            Controls.Add(buttonCourse);
            Controls.Add(buttonPayment);
            Controls.Add(labelPaymentStatus);
            Controls.Add(labelName);
            Controls.Add(dataGridViewCourses);
            Name = "Student";
            Text = "Student";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private DataGridView dataGridViewCourses;
        private Label labelName;
        private Label labelPaymentStatus;
        private Button buttonPayment;
        private Button buttonCourse;
        private Label labelGridTitle;
    }
}