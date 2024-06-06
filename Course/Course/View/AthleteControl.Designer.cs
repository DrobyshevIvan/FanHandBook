using Course.Model;
using System.Drawing;

namespace Course.View
{
    partial class AthleteControl
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

        #region Код, автоматически созданный конструктором компонентов
        
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel = new Panel();
            lblName = new Label();
            lblCountry = new Label();
            lblSport = new Label();
            pictureBox1 = new PictureBox();
            btnDelete = new Button();
            btnInfo = new Button();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.WhiteSmoke;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(lblName);
            panel.Controls.Add(lblCountry);
            panel.Controls.Add(lblSport);
            panel.Controls.Add(pictureBox1);
            panel.Controls.Add(btnDelete);
            panel.Controls.Add(btnInfo);
            panel.Location = new Point(5, 5);
            panel.Margin = new Padding(10);
            panel.Name = "panel";
            panel.Padding = new Padding(10);
            panel.Size = new Size(415, 150);
            panel.TabIndex = 6;
            panel.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
                    Color.Gray, 2, ButtonBorderStyle.Solid, // Ліва межа
                    Color.Gray, 2, ButtonBorderStyle.Solid, // Верхня межа
                    Color.Gray, 2, ButtonBorderStyle.Solid, // Права межа
                    Color.Gray, 2, ButtonBorderStyle.Solid); // Нижня межа
            };
            // 
            // lblName
            // 
            lblName.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblName.Location = new Point(150, 10);
            lblName.Name = "lblName";
            lblName.Size = new Size(250, 25);
            lblName.TabIndex = 1;
            // 
            // lblCountry
            // 
            lblCountry.Font = new Font("Arial", 10F);
            lblCountry.Location = new Point(150, 40);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(250, 20);
            lblCountry.TabIndex = 2;
            // 
            // lblSport
            // 
            lblSport.Font = new Font("Arial", 10F);
            lblSport.Location = new Point(150, 70);
            lblSport.Name = "lblSport";
            lblSport.Size = new Size(250, 20);
            lblSport.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(190, 105);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.FromArgb(128, 128, 255);
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnInfo.ForeColor = Color.Black;
            btnInfo.Location = new Point(296, 105);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(104, 30);
            btnInfo.TabIndex = 5;
            btnInfo.Text = "Інформація";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // AthleteControl
            // 
            Controls.Add(panel);
            Name = "AthleteControl";
            Size = new Size(425, 160);
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        
        private Panel panel;
        private Label lblName, lblCountry, lblSport;
        private PictureBox pictureBox1;
        private Button btnDelete, btnInfo;
    }
}
