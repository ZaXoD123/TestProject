namespace HEY
{
    partial class Form1
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
            this.btnAddStud = new System.Windows.Forms.Button();
            this.btnDeleteStud = new System.Windows.Forms.Button();
            this.btnAddFac = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStud
            // 
            this.btnAddStud.Location = new System.Drawing.Point(14, 13);
            this.btnAddStud.Name = "btnAddStud";
            this.btnAddStud.Size = new System.Drawing.Size(75, 34);
            this.btnAddStud.TabIndex = 3;
            this.btnAddStud.Text = "Добавить студента";
            this.btnAddStud.UseVisualStyleBackColor = true;
            this.btnAddStud.Click += new System.EventHandler(this.btnAddStud_Click);
            // 
            // btnDeleteStud
            // 
            this.btnDeleteStud.Location = new System.Drawing.Point(14, 53);
            this.btnDeleteStud.Name = "btnDeleteStud";
            this.btnDeleteStud.Size = new System.Drawing.Size(75, 35);
            this.btnDeleteStud.TabIndex = 4;
            this.btnDeleteStud.Text = "Удалить студента";
            this.btnDeleteStud.UseVisualStyleBackColor = true;
            this.btnDeleteStud.Click += new System.EventHandler(this.btnDeleteStud_Click);
            // 
            // btnAddFac
            // 
            this.btnAddFac.Location = new System.Drawing.Point(14, 94);
            this.btnAddFac.Name = "btnAddFac";
            this.btnAddFac.Size = new System.Drawing.Size(75, 38);
            this.btnAddFac.TabIndex = 5;
            this.btnAddFac.Text = "Изменить факультет";
            this.btnAddFac.UseVisualStyleBackColor = true;
            this.btnAddFac.Click += new System.EventHandler(this.btnAddFac_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(14, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 37);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Поиск студента";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(95, 13);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(312, 381);
            this.listBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сохранить и выйти";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddFac);
            this.Controls.Add(this.btnDeleteStud);
            this.Controls.Add(this.btnAddStud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "UIStudents";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddStud;
        private System.Windows.Forms.Button btnDeleteStud;
        private System.Windows.Forms.Button btnAddFac;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button1;
    }
}