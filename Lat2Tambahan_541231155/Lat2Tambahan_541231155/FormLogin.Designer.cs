namespace Lat2Tambahan_541231155
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btnlogin = new Button();
            btnc = new Button();
            label1 = new Label();
            lbluser = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            lblpass = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnlogin
            // 
            resources.ApplyResources(btnlogin, "btnlogin");
            btnlogin.Name = "btnlogin";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnc
            // 
            resources.ApplyResources(btnc, "btnc");
            btnc.Name = "btnc";
            btnc.UseVisualStyleBackColor = true;
            btnc.Click += btnc_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // lbluser
            // 
            resources.ApplyResources(lbluser, "lbluser");
            lbluser.Name = "lbluser";
            // 
            // txtuser
            // 
            resources.ApplyResources(txtuser, "txtuser");
            txtuser.Name = "txtuser";
            // 
            // txtpass
            // 
            resources.ApplyResources(txtpass, "txtpass");
            txtpass.Name = "txtpass";
            // 
            // lblpass
            // 
            resources.ApplyResources(lblpass, "lblpass");
            lblpass.Name = "lblpass";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.person_24dp_000000_FILL0_wght400_GRAD0_opsz241;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(pictureBox1);
            Controls.Add(txtpass);
            Controls.Add(lblpass);
            Controls.Add(txtuser);
            Controls.Add(lbluser);
            Controls.Add(label1);
            Controls.Add(btnc);
            Controls.Add(btnlogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private Button btnc;
        private Label label1;
        private Label lbluser;
        private TextBox txtuser;
        private TextBox txtpass;
        private Label lblpass;
        private PictureBox pictureBox1;
    }
}