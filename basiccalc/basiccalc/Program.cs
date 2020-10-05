using System;
using System.Drawing; 
using System.Windows.Forms;  
public class BasicCalculator : Form 
{   private Label label1;
    private Label lblfirstnum;
    private Label lblsecondnum;
    private TextBox txtfirstnum;
    private TextBox txtsecondnum;

    private Button btnPlus;
    private Button btnMinus;
    private Button btnMultiply;
    private Button btnDivision;
    private Label lblResult;
    private TextBox txtResult;
    private Button btnExit;
    public BasicCalculator()    
    {         InitializeComponent();     }  
    public void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        this.lblfirstnum = new System.Windows.Forms.Label();
        this.lblsecondnum = new System.Windows.Forms.Label();
        this.txtfirstnum = new System.Windows.Forms.TextBox();
        this.txtsecondnum = new System.Windows.Forms.TextBox();
        this.btnPlus = new System.Windows.Forms.Button();
        this.btnMinus = new System.Windows.Forms.Button();
        this.btnMultiply = new System.Windows.Forms.Button();
        this.btnDivision = new System.Windows.Forms.Button();
        this.lblResult = new System.Windows.Forms.Label();
        this.txtResult = new System.Windows.Forms.TextBox();
        this.btnExit = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.BackColor = System.Drawing.Color.Olive;
        this.label1.Dock = System.Windows.Forms.DockStyle.Top;
        this.label1.ForeColor = System.Drawing.Color.Blue;
        this.label1.Location = new System.Drawing.Point(0, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(260, 23);
        this.label1.TabIndex = 0;
        this.label1.Text = "Four Basic Sample Calculator";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblfirstnum
        // 
        this.lblfirstnum.AutoSize = true;
        this.lblfirstnum.Location = new System.Drawing.Point(23, 57);
        this.lblfirstnum.Name = "lblfirstnum";
        this.lblfirstnum.Size = new System.Drawing.Size(94, 13);
        this.lblfirstnum.TabIndex = 1;
        this.lblfirstnum.Text = "Enter First Number";
        // 
        // lblsecondnum
        // 
        this.lblsecondnum.AutoSize = true;
        this.lblsecondnum.Location = new System.Drawing.Point(132, 57);
        this.lblsecondnum.Name = "lblsecondnum";
        this.lblsecondnum.Size = new System.Drawing.Size(112, 13);
        this.lblsecondnum.TabIndex = 2;
        this.lblsecondnum.Text = "Enter Second Number";
        // 
        // txtfirstnum
        // 
        this.txtfirstnum.Location = new System.Drawing.Point(26, 73);
        this.txtfirstnum.Name = "txtfirstnum";
        this.txtfirstnum.Size = new System.Drawing.Size(99, 20);
        this.txtfirstnum.TabIndex = 1;
        this.txtfirstnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.txtfirstnum.TextChanged += new System.EventHandler(this.txtfirstnum_TextChanged);
        // 
        // txtsecondnum
        // 
        this.txtsecondnum.Location = new System.Drawing.Point(135, 73);
        this.txtsecondnum.Name = "txtsecondnum";
        this.txtsecondnum.Size = new System.Drawing.Size(96, 20);
        this.txtsecondnum.TabIndex = 2;
        this.txtsecondnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // btnPlus
        // 
        this.btnPlus.Location = new System.Drawing.Point(26, 120);
        this.btnPlus.Name = "btnPlus";
        this.btnPlus.Size = new System.Drawing.Size(41, 25);
        this.btnPlus.TabIndex = 3;
        this.btnPlus.Text = "+";
        this.btnPlus.UseVisualStyleBackColor = true;
        this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
        // 
        // btnMinus
        // 
        this.btnMinus.Location = new System.Drawing.Point(84, 120);
        this.btnMinus.Name = "btnMinus";
        this.btnMinus.Size = new System.Drawing.Size(41, 25);
        this.btnMinus.TabIndex = 4;
        this.btnMinus.Text = "-";
        this.btnMinus.UseVisualStyleBackColor = true;
        this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
        // 
        // btnMultiply
        // 
        this.btnMultiply.Location = new System.Drawing.Point(135, 120);
        this.btnMultiply.Name = "btnMultiply";
        this.btnMultiply.Size = new System.Drawing.Size(41, 25);
        this.btnMultiply.TabIndex = 5;
        this.btnMultiply.Text = "*";
        this.btnMultiply.UseVisualStyleBackColor = true;
        this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
        // 
        // btnDivision
        // 
        this.btnDivision.Location = new System.Drawing.Point(190, 120);
        this.btnDivision.Name = "btnDivision";
        this.btnDivision.Size = new System.Drawing.Size(41, 25);
        this.btnDivision.TabIndex = 6;
        this.btnDivision.Text = "/";
        this.btnDivision.UseVisualStyleBackColor = true;
        this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);

        this.btnExit.Location = new System.Drawing.Point(150, 150);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(41, 25);
        this.btnExit.TabIndex = 9;
        this.btnDivision.Text = "Exit";
        this.btnExit.UseVisualStyleBackColor = false;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        
       
        // 
        // lblResult
        // 
        this.lblResult.AutoSize = true;
        this.lblResult.Location = new System.Drawing.Point(23, 164);
        this.lblResult.Name = "lblResult";
        this.lblResult.Size = new System.Drawing.Size(37, 13);
        this.lblResult.TabIndex = 7;
        this.lblResult.Text = "Result";
        // 
        // txtResult
        // 
        this.txtResult.Location = new System.Drawing.Point(26, 195);
        this.txtResult.Multiline = true;
        this.txtResult.Name = "txtResult";
        this.txtResult.Size = new System.Drawing.Size(205, 29);
        this.txtResult.TabIndex = 7;
        this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // BasicCalculator
        // 
        this.ClientSize = new System.Drawing.Size(260, 236);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.lblfirstnum);
        this.Controls.Add(this.lblsecondnum);
        this.Controls.Add(this.txtfirstnum);
        this.Controls.Add(this.txtsecondnum);
        this.Controls.Add(this.btnPlus);
        this.Controls.Add(this.btnMinus);
        this.Controls.Add(this.btnMultiply);
        this.Controls.Add(this.btnDivision);
        this.Controls.Add(this.lblResult);
        this.Controls.Add(this.txtResult);
        this.Controls.Add(this.btnExit);
        this.MaximizeBox = false;
        this.Name = "BasicCalculator";
        this.Text = "Basic Calculator";
        this.ResumeLayout(false);
        this.PerformLayout();

}   
    private void btnPlus_Click(object sender, EventArgs e)   
    {         double sum = Convert.ToDouble(txtfirstnum.Text) + Convert.ToDouble(txtsecondnum.Text);       
        txtResult.Text = sum.ToString();     }  
    private void btnMinus_Click(object sender, EventArgs e)    
    {         double sum = Convert.ToDouble(txtfirstnum.Text) - Convert.ToDouble(txtsecondnum.Text);        
        txtResult.Text = sum.ToString();     }  
    private void btnMultiply_Click(object sender, EventArgs e)   
    {         double sum = Convert.ToDouble(txtfirstnum.Text) * Convert.ToDouble(txtsecondnum.Text);        
        txtResult.Text = sum.ToString();     }  
    private void btnDivision_Click(object sender, EventArgs e)    
    {         if (Convert.ToDouble(txtfirstnum.Text) == 0 && Convert.ToDouble(txtsecondnum.Text) == 0)        
    {             MessageBox.Show("Result of function is undefined.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);         }  
        else if (Convert.ToDouble(txtsecondnum.Text) == 0)         
    {             MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);         }  
        else         {             double sum = Convert.ToDouble(txtfirstnum.Text) / Convert.ToDouble(txtsecondnum.Text);           
            txtResult.Text = sum.ToString();         }     }
    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
                                                                 
    public static void Main()    
    
    {         Application.EnableVisualStyles();        
        Application.Run(new BasicCalculator());     }

    private void txtfirstnum_TextChanged(object sender, EventArgs e)
    {

    }
}