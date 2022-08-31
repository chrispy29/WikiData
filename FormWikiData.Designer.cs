namespace WikiData
{
    partial class FormWikiData
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelDefinition = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.RadioButtonLinear = new System.Windows.Forms.RadioButton();
            this.RadioButtonNonLinear = new System.Windows.Forms.RadioButton();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LabelData = new System.Windows.Forms.Label();
            this.column_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupBoxStructure = new System.Windows.Forms.GroupBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.GroupBoxStructure.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Name,
            this.column_Category});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(385, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(226, 357);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(19, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(38, 13);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Name:";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(19, 157);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(52, 13);
            this.LabelCategory.TabIndex = 3;
            this.LabelCategory.Text = "Category:";
            // 
            // LabelDefinition
            // 
            this.LabelDefinition.AutoSize = true;
            this.LabelDefinition.Location = new System.Drawing.Point(19, 209);
            this.LabelDefinition.Name = "LabelDefinition";
            this.LabelDefinition.Size = new System.Drawing.Size(54, 13);
            this.LabelDefinition.TabIndex = 4;
            this.LabelDefinition.Text = "Definition:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(19, 26);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(171, 20);
            this.TextBoxName.TabIndex = 5;
            // 
            // RadioButtonLinear
            // 
            this.RadioButtonLinear.AutoSize = true;
            this.RadioButtonLinear.Location = new System.Drawing.Point(11, 19);
            this.RadioButtonLinear.Name = "RadioButtonLinear";
            this.RadioButtonLinear.Size = new System.Drawing.Size(54, 17);
            this.RadioButtonLinear.TabIndex = 6;
            this.RadioButtonLinear.TabStop = true;
            this.RadioButtonLinear.Text = "Linear";
            this.RadioButtonLinear.UseVisualStyleBackColor = true;
            // 
            // RadioButtonNonLinear
            // 
            this.RadioButtonNonLinear.AutoSize = true;
            this.RadioButtonNonLinear.Location = new System.Drawing.Point(11, 47);
            this.RadioButtonNonLinear.Name = "RadioButtonNonLinear";
            this.RadioButtonNonLinear.Size = new System.Drawing.Size(77, 17);
            this.RadioButtonNonLinear.TabIndex = 7;
            this.RadioButtonNonLinear.TabStop = true;
            this.RadioButtonNonLinear.Text = "Non-Linear";
            this.RadioButtonNonLinear.UseVisualStyleBackColor = true;
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Location = new System.Drawing.Point(19, 174);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(171, 21);
            this.ComboBoxCategory.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 225);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(168, 193);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // LabelData
            // 
            this.LabelData.AutoSize = true;
            this.LabelData.Location = new System.Drawing.Point(382, 2);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(33, 13);
            this.LabelData.TabIndex = 10;
            this.LabelData.Text = "Data:";
            // 
            // column_Name
            // 
            this.column_Name.Text = "Name:";
            this.column_Name.Width = 110;
            // 
            // column_Category
            // 
            this.column_Category.Text = "Category:";
            this.column_Category.Width = 110;
            // 
            // GroupBoxStructure
            // 
            this.GroupBoxStructure.Controls.Add(this.RadioButtonNonLinear);
            this.GroupBoxStructure.Controls.Add(this.RadioButtonLinear);
            this.GroupBoxStructure.Location = new System.Drawing.Point(19, 61);
            this.GroupBoxStructure.Name = "GroupBoxStructure";
            this.GroupBoxStructure.Size = new System.Drawing.Size(171, 74);
            this.GroupBoxStructure.TabIndex = 11;
            this.GroupBoxStructure.TabStop = false;
            this.GroupBoxStructure.Text = "Structure";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(215, 26);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 12;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(215, 60);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 13;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(215, 94);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 14;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(385, 389);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 15;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(536, 389);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpen.TabIndex = 16;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(215, 208);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 17;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(215, 175);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(164, 20);
            this.TextBoxSearch.TabIndex = 18;
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(215, 154);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(44, 13);
            this.LabelSearch.TabIndex = 19;
            this.LabelSearch.Text = "Search:";
            // 
            // FormWikiData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 430);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.GroupBoxStructure);
            this.Controls.Add(this.LabelData);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ComboBoxCategory);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelDefinition);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.listView1);
            this.Name = "FormWikiData";
            this.Text = "Wiki Data";
            this.GroupBoxStructure.ResumeLayout(false);
            this.GroupBoxStructure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader column_Name;
        private System.Windows.Forms.ColumnHeader column_Category;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelDefinition;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.RadioButton RadioButtonLinear;
        private System.Windows.Forms.RadioButton RadioButtonNonLinear;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label LabelData;
        private System.Windows.Forms.GroupBox GroupBoxStructure;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label LabelSearch;
    }
}

