using Course.Model;
using System.Windows.Forms;

namespace Course.View
{
    partial class AddAthleteForm : Form
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtCountry = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtSport = new TextBox();
            txtClub = new TextBox();
            txtCoach = new TextBox();
            listAchievements = new ListBox();
            btnSave = new Button();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            txtRecord = new TextBox();
            btnAddRecord = new Button();
            btnEditRecord = new Button();
            btnDeleteRecord = new Button();
            pictureBoxPhoto = new PictureBox();
            btnUploadPhoto = new Button();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(308, 59);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Ім'я";
            txtFirstName.Size = new Size(126, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(308, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Фамілія";
            txtLastName.Size = new Size(126, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(308, 224);
            txtCountry.Name = "txtCountry";
            txtCountry.PlaceholderText = "Країна";
            txtCountry.Size = new Size(126, 27);
            txtCountry.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(308, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // txtSport
            // 
            txtSport.Location = new Point(308, 257);
            txtSport.Name = "txtSport";
            txtSport.PlaceholderText = "Вид спорту";
            txtSport.Size = new Size(126, 27);
            txtSport.TabIndex = 7;
            // 
            // txtClub
            // 
            txtClub.Location = new Point(308, 290);
            txtClub.Name = "txtClub";
            txtClub.PlaceholderText = "Клуб";
            txtClub.Size = new Size(126, 27);
            txtClub.TabIndex = 8;
            // 
            // txtCoach
            // 
            txtCoach.Location = new Point(308, 323);
            txtCoach.Name = "txtCoach";
            txtCoach.PlaceholderText = "Тренер";
            txtCoach.Size = new Size(126, 27);
            txtCoach.TabIndex = 9;
            // 
            // listBox1
            // 
            listAchievements.FormattingEnabled = true;
            listAchievements.Location = new Point(308, 356);
            listAchievements.Name = "listAchievements";
            listAchievements.Size = new Size(127, 104);
            listAchievements.TabIndex = 10;
            listAchievements.SelectedIndexChanged += ListAchievements_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(280, 500);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(185, 76);
            btnSave.TabIndex = 11;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(308, 158);
            txtHeight.Name = "txtHeight";
            txtHeight.PlaceholderText = "Зріст";
            txtHeight.Size = new Size(126, 27);
            txtHeight.TabIndex = 12;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(308, 191);
            txtWeight.Name = "txtWeight";
            txtWeight.PlaceholderText = "Вага";
            txtWeight.Size = new Size(127, 27);
            txtWeight.TabIndex = 13;
            // 
            // txtRecord
            // 
            txtRecord.Location = new Point(308, 467);
            txtRecord.Name = "txtRecord";
            txtRecord.PlaceholderText = "Досягнення";
            txtRecord.Size = new Size(127, 27);
            txtRecord.TabIndex = 0;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Location = new Point(441, 356);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(95, 26);
            btnAddRecord.TabIndex = 1;
            btnAddRecord.Text = "Додати";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += BtnAddRecord_Click;
            // 
            // btnEditRecord
            // 
            btnEditRecord.Location = new Point(441, 388);
            btnEditRecord.Name = "btnEditRecord";
            btnEditRecord.Size = new Size(95, 27);
            btnEditRecord.TabIndex = 2;
            btnEditRecord.Text = "Редагувати";
            btnEditRecord.Click += BtnEditRecord_Click;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.Location = new Point(441, 421);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(95, 31);
            btnDeleteRecord.TabIndex = 3;
            btnDeleteRecord.Text = "Видалити";
            btnDeleteRecord.Click += BtnDeleteRecord_Click;
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxPhoto.Location = new Point(10, 200);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(120, 120);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto.TabIndex = 0;
            pictureBoxPhoto.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.Location = new Point(140, 200);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(100, 29);
            btnUploadPhoto.TabIndex = 1;
            btnUploadPhoto.Text = "Загрузити";
            btnUploadPhoto.Click += BtnUploadPhoto_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.JPEG)|*.BMP;*.JPG;*.PNG;*.JPEG";
            // 
            // AddAthleteForm
            // 
            ClientSize = new Size(752, 600);
            Controls.Add(pictureBoxPhoto);
            Controls.Add(btnUploadPhoto);
            Controls.Add(txtRecord);
            Controls.Add(btnAddRecord);
            Controls.Add(btnEditRecord);
            Controls.Add(btnDeleteRecord);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(btnSave);
            Controls.Add(listAchievements);
            Controls.Add(txtCoach);
            Controls.Add(txtClub);
            Controls.Add(txtSport);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtCountry);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "AddAthleteForm";
            Text = "Додавання спортсмена";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        
        #endregion
        
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtCountry;
        private DateTimePicker dateTimePicker1;
        private TextBox txtSport;
        private TextBox txtClub;
        private TextBox txtCoach;
        private ListBox listAchievements;
        private Button btnSave;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private PictureBox pictureBoxPhoto;
        private Button btnUploadPhoto;
        private OpenFileDialog openFileDialog;
        private TextBox txtRecord;
        private Button btnAddRecord;
        private Button btnEditRecord;
        private Button btnDeleteRecord;
    }
}
