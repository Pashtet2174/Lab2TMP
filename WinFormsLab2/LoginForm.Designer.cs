using System.ComponentModel;

namespace WinFormsLab2;

partial class LoginForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
        Enter = new System.Windows.Forms.Button();
        cancel = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox3 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        Namebox = new System.Windows.Forms.TextBox();
        Password = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // Enter
        // 
        Enter.Anchor = System.Windows.Forms.AnchorStyles.None;
        Enter.AutoSize = true;
        Enter.ForeColor = System.Drawing.SystemColors.Desktop;
        Enter.Location = new System.Drawing.Point(41, 289);
        Enter.Name = "Enter";
        Enter.Size = new System.Drawing.Size(230, 30);
        Enter.TabIndex = 0;
        Enter.Text = "Вход";
        Enter.UseVisualStyleBackColor = true;
        Enter.Click += Enter_Click;
        // 
        // cancel
        // 
        cancel.AutoSize = true;
        cancel.ForeColor = System.Drawing.SystemColors.Desktop;
        cancel.Location = new System.Drawing.Point(482, 289);
        cancel.Name = "cancel";
        cancel.Size = new System.Drawing.Size(263, 30);
        cancel.TabIndex = 1;
        cancel.Text = "Отмена";
        cancel.UseVisualStyleBackColor = true;
        cancel.Click += cancel_Click;
        // 
        // textBox1
        // 
        textBox1.BackColor = System.Drawing.Color.LemonChiffon;
        textBox1.Dock = System.Windows.Forms.DockStyle.Top;
        textBox1.Location = new System.Drawing.Point(0, 0);
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
        textBox1.Size = new System.Drawing.Size(782, 27);
        textBox1.TabIndex = 2;
        textBox1.Text = "АИС Отдел кадров";
        textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // textBox2
        // 
        textBox2.BackColor = System.Drawing.Color.Gold;
        textBox2.Dock = System.Windows.Forms.DockStyle.Top;
        textBox2.Location = new System.Drawing.Point(0, 27);
        textBox2.Name = "textBox2";
        textBox2.ReadOnly = true;
        textBox2.Size = new System.Drawing.Size(782, 27);
        textBox2.TabIndex = 3;
        textBox2.Text = "Версия1.0.0.0 ";
        textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // textBox3
        // 
        textBox3.Dock = System.Windows.Forms.DockStyle.Top;
        textBox3.Location = new System.Drawing.Point(0, 54);
        textBox3.Name = "textBox3";
        textBox3.ReadOnly = true;
        textBox3.Size = new System.Drawing.Size(782, 27);
        textBox3.TabIndex = 4;
        textBox3.Text = "Введите имя пользователя и пароль ";
        textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label1
        // 
        label1.ForeColor = System.Drawing.SystemColors.WindowText;
        label1.Location = new System.Drawing.Point(41, 138);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(164, 32);
        label1.TabIndex = 5;
        label1.Text = "Имя пользователя";
        // 
        // label2
        // 
        label2.ForeColor = System.Drawing.SystemColors.WindowText;
        label2.Location = new System.Drawing.Point(41, 204);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(143, 29);
        label2.TabIndex = 6;
        label2.Text = "Пароль";
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = ((System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage"));
        pictureBox1.ErrorImage = ((System.Drawing.Image)resources.GetObject("pictureBox1.ErrorImage"));
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.InitialImage = ((System.Drawing.Image)resources.GetObject("pictureBox1.InitialImage"));
        pictureBox1.Location = new System.Drawing.Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(113, 81);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 7;
        pictureBox1.TabStop = false;
        // 
        // Namebox
        // 
        Namebox.Location = new System.Drawing.Point(291, 134);
        Namebox.Name = "Namebox";
        Namebox.Size = new System.Drawing.Size(453, 27);
        Namebox.TabIndex = 8;
        // 
        // Password
        // 
        Password.Location = new System.Drawing.Point(291, 204);
        Password.Name = "Password";
        Password.Size = new System.Drawing.Size(454, 27);
        Password.TabIndex = 9;
        // 
        // LoginForm
        // 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
        BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        ClientSize = new System.Drawing.Size(782, 353);
        Controls.Add(Password);
        Controls.Add(Namebox);
        Controls.Add(pictureBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(cancel);
        Controls.Add(Enter);
        ForeColor = System.Drawing.SystemColors.ControlDark;
        MaximumSize = new System.Drawing.Size(800, 400);
        MinimumSize = new System.Drawing.Size(800, 400);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Вход";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox Password;

    private System.Windows.Forms.TextBox Namebox;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Button cancel;

    private System.Windows.Forms.Button Enter;

    #endregion
}