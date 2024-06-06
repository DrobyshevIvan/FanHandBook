namespace Course;

partial class MainMenu
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
        btnPlayers = new Button();
        btnExit = new Button();
        SuspendLayout();
        // 
        // btnPlayers
        // 
        btnPlayers.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnPlayers.Location = new Point(450, 186);
        btnPlayers.Name = "btnExit";
        btnPlayers.Size = new Size(361, 109);
        btnPlayers.TabIndex = 0;
        btnPlayers.Text = "Гравці";
        btnPlayers.UseVisualStyleBackColor = true;
        btnPlayers.Click += btnPlayers_Click;
        // 
        // btnExit
        // 
        btnExit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
        btnExit.Location = new Point(450, 358);
        btnExit.Name = "btnPlayers";
        btnExit.Size = new Size(361, 104);
        btnExit.TabIndex = 1;
        btnExit.Text = "Вихід";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // MainMenu
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1295, 704);
        Controls.Add(btnPlayers);
        Controls.Add(btnExit);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "MainMenu";
        Text = "Головне меню";
        ResumeLayout(false);
    }

    #endregion

    private Button btnPlayers;
    private Button btnExit;
}