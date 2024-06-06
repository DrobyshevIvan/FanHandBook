namespace Course.View
{
    partial class AddGameForm
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
            dateTimePicker1 = new DateTimePicker();
            txtOpponent = new TextBox();
            txtResult = new TextBox();
            btnSave = new Button();
            lblDate = new Label();
            lblOpponent = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(174, 13);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // txtOpponent
            // 
            txtOpponent.Location = new Point(172, 58);
            txtOpponent.Margin = new Padding(3, 4, 3, 4);
            txtOpponent.Name = "txtOpponent";
            txtOpponent.Size = new Size(200, 27);
            txtOpponent.TabIndex = 1;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(172, 96);
            txtResult.Margin = new Padding(3, 4, 3, 4);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(200, 27);
            txtResult.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(172, 142);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(120, 18);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Дата";
            // 
            // lblOpponent
            // 
            lblOpponent.AutoSize = true;
            lblOpponent.Location = new Point(17, 61);
            lblOpponent.Name = "lblOpponent";
            lblOpponent.Size = new Size(149, 20);
            lblOpponent.TabIndex = 5;
            lblOpponent.Text = "Суперник/Змагання";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(86, 99);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(75, 20);
            lblResult.TabIndex = 6;
            lblResult.Text = "Результат";
            // 
            // AddGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 178);
            Controls.Add(lblResult);
            Controls.Add(lblOpponent);
            Controls.Add(lblDate);
            Controls.Add(btnSave);
            Controls.Add(txtResult);
            Controls.Add(txtOpponent);
            Controls.Add(dateTimePicker1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddGameForm";
            Text = "Додавання гри";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox txtOpponent;
        private TextBox txtResult;
        private Button btnSave;
        private Label lblDate;
        private Label lblOpponent;
        private Label lblResult;
    }
}