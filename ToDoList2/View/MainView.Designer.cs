namespace ToDoList2
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTaskDesc = new System.Windows.Forms.TextBox();
            this.lblDiscription = new System.Windows.Forms.Label();
            this.lblCompl = new System.Windows.Forms.Label();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnClearTask = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(23, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(272, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = " What task do you want to add?";
            // 
            // txtBoxTaskName
            // 
            this.txtBoxTaskName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTaskName.Location = new System.Drawing.Point(27, 69);
            this.txtBoxTaskName.Name = "txtBoxTaskName";
            this.txtBoxTaskName.Size = new System.Drawing.Size(251, 25);
            this.txtBoxTaskName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your tasks";
            // 
            // txtBoxTaskDesc
            // 
            this.txtBoxTaskDesc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTaskDesc.Location = new System.Drawing.Point(27, 125);
            this.txtBoxTaskDesc.Multiline = true;
            this.txtBoxTaskDesc.Name = "txtBoxTaskDesc";
            this.txtBoxTaskDesc.Size = new System.Drawing.Size(251, 29);
            this.txtBoxTaskDesc.TabIndex = 5;
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscription.Location = new System.Drawing.Point(43, 100);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(216, 22);
            this.lblDiscription.TabIndex = 6;
            this.lblDiscription.Text = "What is your task about?";
            // 
            // lblCompl
            // 
            this.lblCompl.AutoSize = true;
            this.lblCompl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompl.Location = new System.Drawing.Point(12, 267);
            this.lblCompl.Name = "lblCompl";
            this.lblCompl.Size = new System.Drawing.Size(337, 44);
            this.lblCompl.TabIndex = 7;
            this.lblCompl.Text = "If you have complated your task select \r\nthe task and click here!";
            // 
            // btnTask
            // 
            this.btnTask.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.Location = new System.Drawing.Point(100, 171);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(100, 73);
            this.btnTask.TabIndex = 2;
            this.btnTask.Text = "Enter";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnClearTask
            // 
            this.btnClearTask.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTask.Location = new System.Drawing.Point(395, 258);
            this.btnClearTask.Name = "btnClearTask";
            this.btnClearTask.Size = new System.Drawing.Size(107, 44);
            this.btnClearTask.TabIndex = 8;
            this.btnClearTask.Text = "Clear";
            this.btnClearTask.UseVisualStyleBackColor = true;
            this.btnClearTask.Click += new System.EventHandler(this.btnClearTask_Click);
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.taskNameDataGridViewTextBoxColumn,
            this.taskDescriptionDataGridViewTextBoxColumn,
            this.registerIDDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.taskTableBindingSource;
            this.dgv.Location = new System.Drawing.Point(318, 69);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(245, 164);
            this.dgv.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // taskNameDataGridViewTextBoxColumn
            // 
            this.taskNameDataGridViewTextBoxColumn.DataPropertyName = "taskName";
            this.taskNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.taskNameDataGridViewTextBoxColumn.Name = "taskNameDataGridViewTextBoxColumn";
            // 
            // taskDescriptionDataGridViewTextBoxColumn
            // 
            this.taskDescriptionDataGridViewTextBoxColumn.DataPropertyName = "taskDescription";
            this.taskDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.taskDescriptionDataGridViewTextBoxColumn.Name = "taskDescriptionDataGridViewTextBoxColumn";
            // 
            // registerIDDataGridViewTextBoxColumn
            // 
            this.registerIDDataGridViewTextBoxColumn.DataPropertyName = "RegisterID";
            this.registerIDDataGridViewTextBoxColumn.HeaderText = "RegisterID";
            this.registerIDDataGridViewTextBoxColumn.Name = "registerIDDataGridViewTextBoxColumn";
            this.registerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // taskTableBindingSource
            // 
            this.taskTableBindingSource.DataSource = typeof(ToDoList2.Model.TaskTable);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(612, 321);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnClearTask);
            this.Controls.Add(this.lblCompl);
            this.Controls.Add(this.lblDiscription);
            this.Controls.Add(this.txtBoxTaskDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.txtBoxTaskName);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoApp";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxTaskName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTaskDesc;
        private System.Windows.Forms.Label lblDiscription;
        private System.Windows.Forms.Label lblCompl;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnClearTask;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource taskTableBindingSource;
    }
}

