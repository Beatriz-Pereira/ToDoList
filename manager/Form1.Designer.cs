namespace manager
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtNewTask = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            Tasks = new System.Windows.Forms.CheckedListBox();
            label1 = new System.Windows.Forms.Label();
            radioAll = new System.Windows.Forms.RadioButton();
            radioCompleted = new System.Windows.Forms.RadioButton();
            radioInProgress = new System.Windows.Forms.RadioButton();
            SuspendLayout();
            // 
            // txtNewTask
            // 
            txtNewTask.Location = new System.Drawing.Point(257, 40);
            txtNewTask.Name = "txtNewTask";
            txtNewTask.Size = new System.Drawing.Size(401, 27);
            txtNewTask.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(677, 39);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(142, 28);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Enviar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Tasks
            // 
            Tasks.FormattingEnabled = true;
            Tasks.Location = new System.Drawing.Point(257, 101);
            Tasks.Name = "Tasks";
            Tasks.Size = new System.Drawing.Size(562, 312);
            Tasks.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Plum;
            label1.Location = new System.Drawing.Point(40, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(170, 38);
            label1.TabIndex = 4;
            label1.Text = "To do List";
            // 
            // radioAll
            // 
            radioAll.AutoSize = true;
            radioAll.Location = new System.Drawing.Point(52, 101);
            radioAll.Name = "radioAll";
            radioAll.Size = new System.Drawing.Size(69, 24);
            radioAll.TabIndex = 5;
            radioAll.TabStop = true;
            radioAll.Text = "Todas";
            radioAll.UseVisualStyleBackColor = true;
            radioAll.Click += radioButton1_Click;
            // 
            // radioCompleted
            // 
            radioCompleted.AutoSize = true;
            radioCompleted.Location = new System.Drawing.Point(52, 144);
            radioCompleted.Name = "radioCompleted";
            radioCompleted.Size = new System.Drawing.Size(102, 24);
            radioCompleted.TabIndex = 6;
            radioCompleted.TabStop = true;
            radioCompleted.Text = "Concluidas";
            radioCompleted.UseVisualStyleBackColor = true;
            radioCompleted.Click += radioButton2_Click;
            // 
            // radioInProgress
            // 
            radioInProgress.AutoSize = true;
            radioInProgress.Location = new System.Drawing.Point(52, 189);
            radioInProgress.Name = "radioInProgress";
            radioInProgress.Size = new System.Drawing.Size(97, 24);
            radioInProgress.TabIndex = 7;
            radioInProgress.TabStop = true;
            radioInProgress.Text = "Pendentes";
            radioInProgress.UseVisualStyleBackColor = true;
            radioInProgress.Click += radioButton3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(878, 450);
            Controls.Add(radioInProgress);
            Controls.Add(radioCompleted);
            Controls.Add(radioAll);
            Controls.Add(label1);
            Controls.Add(Tasks);
            Controls.Add(btnAdd);
            Controls.Add(txtNewTask);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtNewTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox Tasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioCompleted;
        private System.Windows.Forms.RadioButton radioInProgress;
    }
}
