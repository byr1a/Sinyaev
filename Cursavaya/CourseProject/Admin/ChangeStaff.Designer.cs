namespace View.Admin
{
    partial class ChangeStaff
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
            Button AddStaff;
            Button Cancel;
            TextStaff = new Label();
            flowLayoutPanel8 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            AddStaff = new Button();
            Cancel = new Button();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // AddStaff
            // 
            AddStaff.Location = new Point(546, 12);
            AddStaff.Name = "AddStaff";
            AddStaff.Size = new Size(93, 43);
            AddStaff.TabIndex = 1;
            AddStaff.Text = "Добавить";
            AddStaff.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(645, 12);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(93, 43);
            Cancel.TabIndex = 2;
            Cancel.Text = "Отмена";
            Cancel.UseVisualStyleBackColor = true;
            // 
            // TextStaff
            // 
            TextStaff.AutoSize = true;
            TextStaff.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextStaff.Location = new Point(12, 9);
            TextStaff.Name = "TextStaff";
            TextStaff.Size = new Size(289, 25);
            TextStaff.TabIndex = 0;
            TextStaff.Text = "Добавление нового сотрудника";
            TextStaff.Click += Text_staff_Click;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.BackColor = SystemColors.ControlDark;
            flowLayoutPanel8.Controls.Add(label2);
            flowLayoutPanel8.Controls.Add(label1);
            flowLayoutPanel8.Location = new Point(12, 61);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(177, 47);
            flowLayoutPanel8.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ControlDark;
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Location = new Point(195, 61);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(177, 47);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ControlDark;
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Location = new Point(378, 61);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(177, 47);
            flowLayoutPanel2.TabIndex = 18;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = SystemColors.ControlDark;
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.Location = new Point(561, 61);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(177, 47);
            flowLayoutPanel3.TabIndex = 18;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = SystemColors.ControlDark;
            flowLayoutPanel4.Controls.Add(label6);
            flowLayoutPanel4.Location = new Point(12, 114);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(177, 47);
            flowLayoutPanel4.TabIndex = 19;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackColor = SystemColors.ControlDark;
            flowLayoutPanel5.Controls.Add(label7);
            flowLayoutPanel5.Location = new Point(195, 114);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(177, 47);
            flowLayoutPanel5.TabIndex = 20;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.BackColor = SystemColors.ControlDark;
            flowLayoutPanel6.Controls.Add(label8);
            flowLayoutPanel6.Location = new Point(378, 114);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(177, 47);
            flowLayoutPanel6.TabIndex = 19;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.BackColor = SystemColors.ControlDark;
            flowLayoutPanel7.Controls.Add(label9);
            flowLayoutPanel7.Location = new Point(561, 114);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(177, 47);
            flowLayoutPanel7.TabIndex = 19;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(43, 3);
            label1.Margin = new Padding(3, 3, 3, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 2);
            label1.TabIndex = 0;
            label1.Text = "Фио";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "ФИО";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Опыт работы ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Должность";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 4;
            label5.Text = "Зароботная плата";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 5;
            label6.Text = "введите фио..";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
            label7.TabIndex = 6;
            label7.Text = "ведите опыт работы...";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(121, 15);
            label8.TabIndex = 7;
            label8.Text = "введите должность...";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 8;
            label9.Text = "введите ЗП...";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChangeStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(749, 176);
            Controls.Add(flowLayoutPanel7);
            Controls.Add(flowLayoutPanel6);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel8);
            Controls.Add(Cancel);
            Controls.Add(AddStaff);
            Controls.Add(TextStaff);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ChangeStaff";
            Text = "ChangeStaff";
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextStaff;
        private FlowLayoutPanel flowLayoutPanel8;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}