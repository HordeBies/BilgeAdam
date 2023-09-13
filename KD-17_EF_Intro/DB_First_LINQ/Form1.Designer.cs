namespace DB_First_LINQ
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            employee_id = new TextBox();
            employee_firstname = new TextBox();
            button2 = new Button();
            employee_lastname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 384);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 25);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 1;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SaveChanges;
            // 
            // employee_id
            // 
            employee_id.Location = new Point(161, 26);
            employee_id.Name = "employee_id";
            employee_id.Size = new Size(100, 23);
            employee_id.TabIndex = 2;
            // 
            // employee_firstname
            // 
            employee_firstname.Location = new Point(267, 26);
            employee_firstname.Name = "employee_firstname";
            employee_firstname.Size = new Size(100, 23);
            employee_firstname.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(479, 26);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Upsert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Upsert;
            // 
            // employee_lastname
            // 
            employee_lastname.Location = new Point(373, 25);
            employee_lastname.Name = "employee_lastname";
            employee_lastname.Size = new Size(100, 23);
            employee_lastname.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 8);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 8);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 7;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 7);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 8;
            label3.Text = "Last Name";
            // 
            // button3
            // 
            button3.Location = new Point(713, 26);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Delete;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(employee_lastname);
            Controls.Add(button2);
            Controls.Add(employee_firstname);
            Controls.Add(employee_id);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox employee_id;
        private TextBox employee_firstname;
        private Button button2;
        private TextBox employee_lastname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
    }
}
