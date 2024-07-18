namespace College.Forms
{
    partial class LoginForm
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
            Welcome = new Label();
            textBoxName = new TextBox();
            textBoxId = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Location = new Point(226, 61);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(119, 25);
            Welcome.TabIndex = 0;
            Welcome.Text = "ברוכים הבאים";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(328, 153);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 31);
            textBoxName.TabIndex = 1;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(97, 153);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(150, 31);
            textBoxId.TabIndex = 2;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(214, 304);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(176, 34);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "כניסה כתלמיד";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 492);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxId);
            Controls.Add(textBoxName);
            Controls.Add(Welcome);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Welcome;
        private TextBox textBoxName;
        private TextBox textBoxId;
        private Button buttonLogin;
    }
}