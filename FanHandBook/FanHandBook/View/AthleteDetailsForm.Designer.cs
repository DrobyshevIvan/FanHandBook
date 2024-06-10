using System.ComponentModel;

namespace Course.View
{
    partial class AthleteDetailsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBoxPhoto = new PictureBox();
            lblDateOfBirth = new Label();
            lblName = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            lblCountry = new Label();
            lblSport = new Label();
            lblClubOrTeam = new Label();
            lblCoach = new Label();
            panelPersonalRecords = new Panel();
            lblPersonalRecords = new Label();
            dataGridViewGames = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            btnDeleteGame = new Button();
            btnAddGame = new Button();
            btnEdit = new Button();
            ((ISupportInitialize)pictureBoxPhoto).BeginInit();
            panelPersonalRecords.SuspendLayout();
            ((ISupportInitialize)dataGridViewGames).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxPhoto.Location = new Point(10, 10);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(100, 100);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto.TabIndex = 0;
            pictureBoxPhoto.TabStop = false;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Location = new Point(120, 120);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(400, 20);
            lblDateOfBirth.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(120, 97);
            lblName.Name = "lblName";
            lblName.Size = new Size(400, 23);
            lblName.TabIndex = 2;
            // 
            // lblHeight
            // 
            lblHeight.Location = new Point(120, 140);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(400, 20);
            lblHeight.TabIndex = 3;
            // 
            // lblWeight
            // 
            lblWeight.Location = new Point(120, 160);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(400, 20);
            lblWeight.TabIndex = 4;
            // 
            // lblCountry
            // 
            lblCountry.Location = new Point(120, 180);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(400, 20);
            lblCountry.TabIndex = 5;
            // 
            // lblSport
            // 
            lblSport.Location = new Point(120, 200);
            lblSport.Name = "lblSport";
            lblSport.Size = new Size(400, 20);
            lblSport.TabIndex = 6;
            // 
            // lblClubOrTeam
            // 
            lblClubOrTeam.Location = new Point(120, 220);
            lblClubOrTeam.Name = "lblClubOrTeam";
            lblClubOrTeam.Size = new Size(400, 20);
            lblClubOrTeam.TabIndex = 7;
            // 
            // lblCoach
            // 
            lblCoach.Location = new Point(120, 240);
            lblCoach.Name = "lblCoach";
            lblCoach.Size = new Size(400, 20);
            lblCoach.TabIndex = 8;
            // 
            // panelPersonalRecords
            // 
            panelPersonalRecords.AutoScroll = true;
            panelPersonalRecords.BorderStyle = BorderStyle.FixedSingle;
            panelPersonalRecords.Controls.Add(lblPersonalRecords);
            panelPersonalRecords.Location = new Point(532, 10);
            panelPersonalRecords.Name = "panelPersonalRecords";
            panelPersonalRecords.Size = new Size(250, 250);
            panelPersonalRecords.TabIndex = 9;
            // 
            // lblPersonalRecords
            // 
            lblPersonalRecords.Location = new Point(-1, 0);
            lblPersonalRecords.Name = "lblPersonalRecords";
            lblPersonalRecords.Size = new Size(250, 250);
            lblPersonalRecords.TabIndex = 10;
            // 
            // dataGridViewGames
            // 
            dataGridViewGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGames.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewGames.Location = new Point(10, 300);
            dataGridViewGames.Name = "dataGridViewGames";
            dataGridViewGames.RowHeadersWidth = 51;
            dataGridViewGames.Size = new Size(760, 150);
            dataGridViewGames.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTextBoxColumn1.HeaderText = "Дата";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Суперник/Змагання";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Результат";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnDeleteGame
            // 
            btnDeleteGame.Location = new Point(12, 456);
            btnDeleteGame.Name = "btnDeleteGame";
            btnDeleteGame.Size = new Size(85, 32);
            btnDeleteGame.TabIndex = 11;
            btnDeleteGame.Text = "Видалити";
            btnDeleteGame.UseVisualStyleBackColor = true;
            btnDeleteGame.Click += btnDeleteGame_Click;
            // 
            // btnAddGame
            // 
            btnAddGame.Location = new Point(103, 457);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(72, 31);
            btnAddGame.TabIndex = 12;
            btnAddGame.Text = "Додати";
            btnAddGame.UseVisualStyleBackColor = true;
            btnAddGame.Click += btnAddGame_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(682, 457);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(106, 36);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Редагувати";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // AthleteDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(btnEdit);
            Controls.Add(btnAddGame);
            Controls.Add(pictureBoxPhoto);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblName);
            Controls.Add(lblHeight);
            Controls.Add(lblWeight);
            Controls.Add(lblCountry);
            Controls.Add(lblSport);
            Controls.Add(lblClubOrTeam);
            Controls.Add(lblCoach);
            Controls.Add(panelPersonalRecords);
            Controls.Add(dataGridViewGames);
            Controls.Add(btnDeleteGame);
            Name = "AthleteDetailsForm";
            Text = "Детальна інформація про спортсмена";
            ((ISupportInitialize)pictureBoxPhoto).EndInit();
            panelPersonalRecords.ResumeLayout(false);
            ((ISupportInitialize)dataGridViewGames).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblName, lblDateOfBirth, lblHeight, lblWeight, lblCountry, lblSport, lblClubOrTeam, lblCoach, lblPersonalRecords;
        private PictureBox pictureBoxPhoto;
        private DataGridView dataGridViewGames;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Panel panelPersonalRecords;
        private Button btnDeleteGame, btnAddGame, btnEdit;
    }
}
