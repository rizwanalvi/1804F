namespace NexusComputers
{
    partial class frmLogin
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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(50, 63);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(190, 23);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.Text = "metroTextBox1";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(50, 165);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Login";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(165, 165);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Cancel";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(50, 106);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '*';
            this.metroTextBox2.Size = new System.Drawing.Size(190, 23);
            this.metroTextBox2.TabIndex = 0;
            this.metroTextBox2.Text = "metroTextBox1";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Name = "frmLogin";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
    }
}