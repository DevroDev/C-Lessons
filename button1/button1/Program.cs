using System;
using System.Windows.Forms;
using System.Drawing;

public class MyfirstApp : Form
{
    public MyfirstApp()
    {
        this.button1 = new Button();
        this.button1.Location = new Point(146, 197);
        this.button1.Size = new Size(75, 23);
        this.button1.Text = "Click Me";
        this.button1.Click += new EventHandler(this.button1_Click);

        Text = "My first Application";
        this.ClientSize = new Size(292, 268);
        this.Controls.Add(this.button1);
    }
    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("With a button,My First Application have been created.");
    }
    public static void Main()
    {
        Application.Run(new MyfirstApp());
    }

    private Button button2;
    private System.Windows.Forms.Button button1;

    private void InitializeComponent()
    {
        this.button2 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(101, 181);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(75, 23);
        this.button2.TabIndex = 0;
        this.button2.Text = "click me";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // MyfirstApp
        // 
        this.ClientSize = new System.Drawing.Size(284, 261);
        this.Controls.Add(this.button2);
        this.Name = "MyfirstApp";
        this.Load += new System.EventHandler(this.MyfirstApp_Load);
        this.ResumeLayout(false);

    }

    private void MyfirstApp_Load(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Thank");
    }
}
