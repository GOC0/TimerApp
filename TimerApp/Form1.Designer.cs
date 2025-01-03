namespace TimerApp
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            textBox1 = new TextBox();
            button_Stop = new Button();
            button_Start = new Button();
            comboBox1 = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button_Stop);
            panel1.Controls.Add(button_Start);
            panel1.Location = new Point(12, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 395);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 2;
            // 
            // button_Stop
            // 
            button_Stop.Location = new Point(177, 98);
            button_Stop.Name = "button_Stop";
            button_Stop.Size = new Size(75, 23);
            button_Stop.TabIndex = 1;
            button_Stop.Text = "Stop";
            button_Stop.UseVisualStyleBackColor = true;
            button_Stop.Click += button_Stop_Click;
            // 
            // button_Start
            // 
            button_Start.Location = new Point(37, 98);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(75, 23);
            button_Start.TabIndex = 0;
            button_Start.Text = "Start";
            button_Start.UseVisualStyleBackColor = true;
            button_Start.Click += button_Start_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "15", "25", "30", "60" });
            comboBox1.Location = new Point(255, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(comboBox2);
            panel2.Location = new Point(398, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 148);
            panel2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(255, 19);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 4;
            textBox3.TabStop = false;
            textBox3.Text = "Time";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 19);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(226, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = " Type of work";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "study", "work", "relaxation", "other" });
            comboBox2.Location = new Point(23, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(226, 23);
            comboBox2.TabIndex = 0;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(398, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(390, 224);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 104, 220);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button button_Stop;
        private Button button_Start;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
        private Panel panel2;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private TextBox textBox3;
    }
}
