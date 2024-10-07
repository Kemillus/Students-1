namespace Students
{
    partial class AddStudent
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxSelectAGroup = new System.Windows.Forms.ComboBox();
            this.listOfStudent = new System.Windows.Forms.ListBox();
            this.selectAGroup = new System.Windows.Forms.Label();
            this.labelListOfStudent = new System.Windows.Forms.Label();
            this.nameOfGroup = new System.Windows.Forms.Label();
            this.labelNameOfGroup = new System.Windows.Forms.TextBox();
            this.addGroup = new System.Windows.Forms.Button();
            this.addSudent = new System.Windows.Forms.Button();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxNameSelectGroup = new System.Windows.Forms.TextBox();
            this.textBoxGroupID = new System.Windows.Forms.TextBox();
            this.GroupID = new System.Windows.Forms.Label();
            this.nameSelectGroup = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSelectAGroup
            // 
            this.comboBoxSelectAGroup.FormattingEnabled = true;
            this.comboBoxSelectAGroup.Location = new System.Drawing.Point(38, 59);
            this.comboBoxSelectAGroup.Name = "comboBoxSelectAGroup";
            this.comboBoxSelectAGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectAGroup.TabIndex = 0;
            this.comboBoxSelectAGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectAGroup_SelectedIndexChanged);
            // 
            // listOfStudent
            // 
            this.listOfStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listOfStudent.FormattingEnabled = true;
            this.listOfStudent.Location = new System.Drawing.Point(39, 149);
            this.listOfStudent.Name = "listOfStudent";
            this.listOfStudent.Size = new System.Drawing.Size(120, 134);
            this.listOfStudent.TabIndex = 1;
            // 
            // selectAGroup
            // 
            this.selectAGroup.AutoSize = true;
            this.selectAGroup.Location = new System.Drawing.Point(36, 43);
            this.selectAGroup.Name = "selectAGroup";
            this.selectAGroup.Size = new System.Drawing.Size(93, 13);
            this.selectAGroup.TabIndex = 2;
            this.selectAGroup.Text = "Выберите группу";
            // 
            // labelListOfStudent
            // 
            this.labelListOfStudent.AutoSize = true;
            this.labelListOfStudent.Location = new System.Drawing.Point(36, 133);
            this.labelListOfStudent.Name = "labelListOfStudent";
            this.labelListOfStudent.Size = new System.Drawing.Size(98, 13);
            this.labelListOfStudent.TabIndex = 3;
            this.labelListOfStudent.Text = "Список студентов";
            // 
            // nameOfGroup
            // 
            this.nameOfGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameOfGroup.AutoSize = true;
            this.nameOfGroup.Location = new System.Drawing.Point(211, 133);
            this.nameOfGroup.Name = "nameOfGroup";
            this.nameOfGroup.Size = new System.Drawing.Size(145, 13);
            this.nameOfGroup.TabIndex = 4;
            this.nameOfGroup.Text = "Введите название группы :";
            // 
            // labelNameOfGroup
            // 
            this.labelNameOfGroup.Location = new System.Drawing.Point(214, 149);
            this.labelNameOfGroup.Name = "labelNameOfGroup";
            this.labelNameOfGroup.Size = new System.Drawing.Size(100, 20);
            this.labelNameOfGroup.TabIndex = 5;
            // 
            // addGroup
            // 
            this.addGroup.Location = new System.Drawing.Point(214, 214);
            this.addGroup.Name = "addGroup";
            this.addGroup.Size = new System.Drawing.Size(100, 54);
            this.addGroup.TabIndex = 6;
            this.addGroup.Text = "Добавить группу";
            this.addGroup.UseVisualStyleBackColor = true;
            this.addGroup.Click += new System.EventHandler(this.addGroup_Click);
            // 
            // addSudent
            // 
            this.addSudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSudent.Location = new System.Drawing.Point(380, 214);
            this.addSudent.Name = "addSudent";
            this.addSudent.Size = new System.Drawing.Size(100, 54);
            this.addSudent.TabIndex = 7;
            this.addSudent.Text = "Добавить студента в группу";
            this.addSudent.UseVisualStyleBackColor = true;
            this.addSudent.Click += new System.EventHandler(this.addSudent_Click);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(383, 149);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFullName.TabIndex = 8;
            // 
            // textBoxNameSelectGroup
            // 
            this.textBoxNameSelectGroup.Location = new System.Drawing.Point(383, 95);
            this.textBoxNameSelectGroup.Name = "textBoxNameSelectGroup";
            this.textBoxNameSelectGroup.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameSelectGroup.TabIndex = 9;
            // 
            // textBoxGroupID
            // 
            this.textBoxGroupID.Location = new System.Drawing.Point(383, 43);
            this.textBoxGroupID.Name = "textBoxGroupID";
            this.textBoxGroupID.Size = new System.Drawing.Size(100, 20);
            this.textBoxGroupID.TabIndex = 10;
            // 
            // GroupID
            // 
            this.GroupID.AutoSize = true;
            this.GroupID.Location = new System.Drawing.Point(380, 27);
            this.GroupID.Name = "GroupID";
            this.GroupID.Size = new System.Drawing.Size(118, 13);
            this.GroupID.TabIndex = 11;
            this.GroupID.Text = "Выбрана группа с ID :";
            // 
            // nameSelectGroup
            // 
            this.nameSelectGroup.AutoSize = true;
            this.nameSelectGroup.Location = new System.Drawing.Point(380, 79);
            this.nameSelectGroup.Name = "nameSelectGroup";
            this.nameSelectGroup.Size = new System.Drawing.Size(158, 13);
            this.nameSelectGroup.TabIndex = 12;
            this.nameSelectGroup.Text = "Название выбранной группы:";
            // 
            // labelFullName
            // 
            this.labelFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(377, 133);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(130, 13);
            this.labelFullName.TabIndex = 13;
            this.labelFullName.Text = "Введите ФИО студента:";
            this.labelFullName.UseWaitCursor = true;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.nameSelectGroup);
            this.Controls.Add(this.GroupID);
            this.Controls.Add(this.textBoxGroupID);
            this.Controls.Add(this.textBoxNameSelectGroup);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.addSudent);
            this.Controls.Add(this.addGroup);
            this.Controls.Add(this.labelNameOfGroup);
            this.Controls.Add(this.nameOfGroup);
            this.Controls.Add(this.labelListOfStudent);
            this.Controls.Add(this.selectAGroup);
            this.Controls.Add(this.listOfStudent);
            this.Controls.Add(this.comboBoxSelectAGroup);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 489);
            this.Name = "AddStudent";
            this.Text = "Добавить студента в группу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectAGroup;
        private System.Windows.Forms.ListBox listOfStudent;
        private System.Windows.Forms.Label selectAGroup;
        private System.Windows.Forms.Label labelListOfStudent;
        private System.Windows.Forms.Label nameOfGroup;
        private System.Windows.Forms.TextBox labelNameOfGroup;
        private System.Windows.Forms.Button addGroup;
        private System.Windows.Forms.Button addSudent;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxNameSelectGroup;
        private System.Windows.Forms.TextBox textBoxGroupID;
        private System.Windows.Forms.Label GroupID;
        private System.Windows.Forms.Label nameSelectGroup;
        private System.Windows.Forms.Label labelFullName;
    }
}

