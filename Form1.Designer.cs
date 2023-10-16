namespace _0102
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
            listViewProcesses = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            Id = new ColumnHeader();
            textBoxInterval = new TextBox();
            buttonSetInterval = new Button();
            SuspendLayout();
            // 
            // listViewProcesses
            // 
            listViewProcesses.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, Id });
            listViewProcesses.Location = new Point(12, 12);
            listViewProcesses.Name = "listViewProcesses";
            listViewProcesses.Size = new Size(442, 426);
            listViewProcesses.TabIndex = 0;
            listViewProcesses.UseCompatibleStateImageBehavior = false;
            listViewProcesses.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "№";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 200;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 150;
            // 
            // textBoxInterval
            // 
            textBoxInterval.Location = new Point(533, 39);
            textBoxInterval.Name = "textBoxInterval";
            textBoxInterval.PlaceholderText = "Введіть час оновлення у секундах";
            textBoxInterval.Size = new Size(206, 23);
            textBoxInterval.TabIndex = 1;
            // 
            // buttonSetInterval
            // 
            buttonSetInterval.Location = new Point(533, 86);
            buttonSetInterval.Name = "buttonSetInterval";
            buttonSetInterval.Size = new Size(206, 23);
            buttonSetInterval.TabIndex = 2;
            buttonSetInterval.Text = "Оновити час оновлення";
            buttonSetInterval.UseVisualStyleBackColor = true;
            buttonSetInterval.Click += buttonSetInterval_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSetInterval);
            Controls.Add(textBoxInterval);
            Controls.Add(listViewProcesses);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewProcesses;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader Id;
        private TextBox textBoxInterval;
        private Button buttonSetInterval;
    }
}