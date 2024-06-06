namespace Course.View
{
    partial class AllAthletes
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            radioBtnName = new RadioButton();
            radioBtnCountry = new RadioButton();
            radioBtnSport = new RadioButton();
            comboBox = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnAdd = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAllAthletes = new Button();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1119, 640);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(212, 52);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSearch.Location = new Point(8, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(263, 38);
            txtSearch.TabIndex = 1;
            // 
            // radioBtnName
            // 
            radioBtnName.AutoSize = true;
            radioBtnName.Location = new Point(279, 15);
            radioBtnName.Name = "radioBtnName";
            radioBtnName.Size = new Size(87, 24);
            radioBtnName.TabIndex = 2;
            radioBtnName.TabStop = true;
            radioBtnName.Text = "За ім'ям";
            radioBtnName.UseVisualStyleBackColor = true;
            // 
            // radioBtnCountry
            // 
            radioBtnCountry.AutoSize = true;
            radioBtnCountry.Location = new Point(381, 15);
            radioBtnCountry.Name = "radioBtnCountry";
            radioBtnCountry.Size = new Size(108, 24);
            radioBtnCountry.TabIndex = 3;
            radioBtnCountry.TabStop = true;
            radioBtnCountry.Text = "За країною";
            radioBtnCountry.UseVisualStyleBackColor = true;
            // 
            // radioBtnSport
            // 
            radioBtnSport.AutoSize = true;
            radioBtnSport.Location = new Point(504, 15);
            radioBtnSport.Name = "radioBtnSport";
            radioBtnSport.Size = new Size(146, 24);
            radioBtnSport.TabIndex = 4;
            radioBtnSport.TabStop = true;
            radioBtnSport.Text = "За видом спорту";
            radioBtnSport.UseVisualStyleBackColor = true;
            // 
            // comboBox
            // 
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Зріст", "Досягнення", "Рекордсмен", "Без додаткових фільтрів" });
            comboBox.Location = new Point(667, 14);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(228, 28);
            comboBox.TabIndex = 5;
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(933, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(113, 27);
            textBox2.TabIndex = 6;
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1052, 15);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(113, 27);
            textBox3.TabIndex = 7;
            textBox3.Visible = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(23, 640);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(212, 52);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Додати спортсмена";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 63);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1319, 558);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            // 
            // btnAllAthletes
            // 
            btnAllAthletes.Location = new Point(933, 639);
            btnAllAthletes.Name = "btnAllAthletes";
            btnAllAthletes.Size = new Size(141, 54);
            btnAllAthletes.TabIndex = 10;
            btnAllAthletes.Text = "Всі Спортсмени";
            btnAllAthletes.UseVisualStyleBackColor = true;
            btnAllAthletes.Click += btnAllAthletes_Click;
            // 
            // AllAthletes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 704);
            Controls.Add(btnAllAthletes);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnAdd);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox);
            Controls.Add(radioBtnSport);
            Controls.Add(radioBtnCountry);
            Controls.Add(radioBtnName);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AllAthletes";
            Text = "Всі спортсмени";
            Load += AllAthletes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private RadioButton radioBtnName;
        private RadioButton radioBtnCountry;
        private RadioButton radioBtnSport;
        private ComboBox comboBox;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnAdd;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAllAthletes;
    }
}