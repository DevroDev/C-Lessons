using System; 
using System.Drawing;
using System.Windows.Forms;  
public class Zodiac : Form 
{     private CheckBox cbAries;    
    private CheckBox cbTaurus;    
    private CheckBox cbGemini;  
    private CheckBox cbCancer;  
    private CheckBox cbLeo;    
    private CheckBox cbVirgo; 
     private CheckBox cbLibra;    
    private CheckBox cbScorpio;   
    private CheckBox cbSagittarius;   
    private CheckBox cbCapricorn;   
    private CheckBox cbAquarius;    
    private CheckBox cbPisces;   
    private Label lblText;    
    private Button btnDisplay; 
    private Button btnClose;    
    private PictureBox pictureBox1;   
    private Label lblPicture;  
    public Zodiac()   
    {         InitializeComponent();     }  
    public void InitializeComponent() 
    {         // cbAries        
        cbAries = new CheckBox();        
        cbAries.ForeColor = Color.Yellow;       
        cbAries.Location = new Point(12, 25);   
        cbAries.Name = "cbAries";       
        cbAries.Text = "ARIES";       
        cbAries.UseVisualStyleBackColor = true;       
        // cbTaurus        
        cbTaurus = new CheckBox();    
        cbTaurus.ForeColor = Color.Yellow;     
        cbTaurus.Location = new Point(12, 45);  
        cbTaurus.Name = "cbTaurus";      
        cbTaurus.Text = "TAURUS";      
        cbTaurus.UseVisualStyleBackColor = true;       
        // cbGemini  
        cbGemini = new CheckBox();      
        cbGemini.ForeColor = Color.Yellow;   
        cbGemini.Location = new Point(12, 65);    
        cbGemini.Name = "cbGemini";     
        cbGemini.Text = "GEMINI";        
        cbGemini.UseVisualStyleBackColor = true;       
        // cbCancer        
        cbCancer = new CheckBox();      
        cbCancer.ForeColor = Color.Yellow;
         cbCancer.Location = new Point(12, 85);       
        cbCancer.Name = "cbCancer";       
        cbCancer.Text = "CANCER";       
        cbCancer.UseVisualStyleBackColor = true; 
        // cbLeo        
        cbLeo = new CheckBox();    
        cbLeo.ForeColor = Color.Yellow; 
        cbLeo.Location = new Point(12, 105);     
        cbLeo.Name = "cbLeo";      
        cbLeo.Text = "LEO";    
        cbLeo.UseVisualStyleBackColor = true;    
        // cbVirgo      
        cbVirgo = new CheckBox();        
        cbVirgo.ForeColor = Color.Yellow;     
        cbVirgo.Location = new Point(12, 125);  
        cbVirgo.Name = "cbVirgo";      
        
        cbVirgo.Text = "VIRGO";       
        cbVirgo.UseVisualStyleBackColor = true;     
        // cbLibra        
        cbLibra = new CheckBox();       
        cbLibra.ForeColor = Color.Yellow;    
        cbLibra.Location = new Point(12, 145);  
        cbLibra.Name = "cbLibra";       
        cbLibra.Text = "LIBRA";      
        cbLibra.UseVisualStyleBackColor = true;       
        // cbScorpio      
        cbScorpio = new CheckBox();      
        cbScorpio.ForeColor = Color.Yellow; 
        cbScorpio.Location = new Point(12, 165);  
        cbScorpio.Name = "cbScorpio";      
        cbScorpio.Text = "SCORPIO";        
        cbScorpio.UseVisualStyleBackColor = true;  
        // cbSagittarius     
        cbSagittarius = new CheckBox();         
        cbSagittarius.ForeColor = Color.Yellow;  
        
        cbSagittarius.Location = new Point(12, 185); 
        cbSagittarius.Name = "cbSagittarius";        
        cbSagittarius.Text = "SAGITTARIUS";         
        cbSagittarius.UseVisualStyleBackColor = true;   
        // cbCapricorn         
        cbCapricorn = new CheckBox();    
        cbCapricorn.ForeColor = Color.Yellow; 
        cbCapricorn.Location = new Point(12, 205); 
        cbCapricorn.Name = "cbCapricorn";       
        
        cbCapricorn.Text = "CAPRICORN";      
        cbCapricorn.UseVisualStyleBackColor = true;   
        // cbAquarius       
        cbAquarius = new CheckBox();      
        cbAquarius.ForeColor = Color.Yellow; 
        cbAquarius.Location = new Point(12, 225);   
        cbAquarius.Name = "cbAquarius";        
        cbAquarius.Text = "AQUARIUS";      
        cbAquarius.UseVisualStyleBackColor = true;  
        // cbPisces    
        cbPisces = new CheckBox();   
        cbPisces.ForeColor = Color.Yellow;   
        cbPisces.Location = new Point(12, 245);  
        cbPisces.Name = "cbAquarius";      
        cbPisces.Text = "PISCES";      
        
        cbPisces.UseVisualStyleBackColor = true;  
        // lblText         
        lblText = new Label();       
        lblText.BackColor = Color.White;  
        lblText.BorderStyle = BorderStyle.Fixed3D; 
        lblText.Font = new System.Drawing.Font("Times New Roman", 11.25F);    
        lblText.Location = new Point(128, 25);   
        lblText.Name = "lblText";     
        lblText.Size = new Size(273, 197);       
        lblText.TextAlign = ContentAlignment.MiddleCenter;  
        lblText.Text =              "Ladies and Gentlemen!!\n" +           
            "Do you believe fortune telling that " +            
            "can be called astrology?\n" +             
            "Do you believe that Zodiac influenced " +   
            "all of people?\n" +              
            "Here, I showed these Zodiacs for you !!" +   
            "Don't waste the time!! Hurry up !!";  
        // btnDisplay  
        btnDisplay = new Button();   
        btnDisplay.Location = new Point(128, 234);    
        btnDisplay.Name = "btnDisplay";      
        btnDisplay.Size = new Size(99, 31);   
        btnDisplay.BackColor = Color.Gray;        
        btnDisplay.ForeColor = Color.Yellow; 
         btnDisplay.TabIndex = 1;     
        btnDisplay.Font = new System.Drawing.Font("Calibri", 9.25F);    
        btnDisplay.Text = "Look";      
        btnDisplay.UseVisualStyleBackColor = false; 
        btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);  
        // btnClose   
        btnClose = new Button();   
        btnClose.Location = new System.Drawing.Point(302, 234);     
        btnClose.Name = "btnClose";       
        btnClose.Size = new System.Drawing.Size(99, 31);     
        btnClose.TabIndex = 2;     
        btnClose.BackColor = Color.Gray;   
        btnClose.ForeColor = Color.Yellow;      
        btnClose.Font = new System.Drawing.Font("Calibri", 9.25F);        
        btnClose.Text = "Close";        
        btnClose.UseVisualStyleBackColor = true;  
        btnClose.Click += new System.EventHandler(this.btnClose_Click);
        // pictureBox1   
        Image img = Image.FromFile("1.jpg");  
        pictureBox1 = new PictureBox();       
        pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;    
        pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;  
        pictureBox1.Location = new Point(426, 25);        
        pictureBox1.Name = "pictureBox1";        
        pictureBox1.Size = new Size(124, 104);   
        pictureBox1.Image = img;  
        // lblPicture     
        lblPicture = new Label(); 
        lblPicture.Location = new Point(426, 145);   
        lblPicture.Name = "lblPicture";        
        lblPicture.Size = new Size(124, 104);  
        // form     
        this.BackColor = System.Drawing.SystemColors.HotTrack;  
        this.ClientSize = new Size(564, 290);        
        
        this.MaximizeBox = false;    
        this.Text = "Zodiac";  
        // Adding Controls on the form        
        this.Controls.Add(this.cbAries); 
        this.Controls.Add(this.cbTaurus);  
        this.Controls.Add(this.cbGemini);  
        this.Controls.Add(this.cbCancer);    
        this.Controls.Add(this.cbLeo);      
        this.Controls.Add(this.cbVirgo);      
        this.Controls.Add(this.cbLibra);      
        this.Controls.Add(this.cbScorpio);    
        this.Controls.Add(this.cbSagittarius);   
        this.Controls.Add(this.cbCapricorn);     
        this.Controls.Add(this.cbAquarius);      
        this.Controls.Add(this.cbPisces);       
        this.Controls.Add(this.lblText);        
        this.Controls.Add(this.btnDisplay);     
        this.Controls.Add(this.btnClose);       
        this.Controls.Add(this.pictureBox1);    
        this.Controls.Add(this.lblPicture);     
    }  
    public static  void Main(string[] args)     
    {         Application.Run(new Zodiac());     }  
    private void btnClose_Click(object who, EventArgs exe)   
    {         DialogResult result = MessageBox.Show("Are you sure to want to exit?", "Zodiac",
        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);        
        if (result == DialogResult.Yes)             Application.Exit();     }  
    private void btnDisplay_Click(object who, EventArgs ex)    
    {  
        if (cbAries.Checked == true)     
        {             Image img = Image.FromFile("1.jpg");      
            lblPicture.Image = img;            
            lblText.Text =               
                "Energetic. Adventurous and spontaneous. Confident and enthusiastic. " +
                "Fun. Loves a challenge. EXTREMELY impatient. Sometimes selfish. " +   
                "Short fuse.(Easily angered.) Lively, passionate, and sharp wit. " +   
                "Outgoing. Lose interest quickly - easily bored. Egotistical. " + 
         "Courageous and assertive. Tends to be physical and athletic.";         
        }      
        else if (cbTaurus.Checked == true)     
        {             Image img = Image.FromFile("1.jpg");         
            lblPicture.Image = img;        
            lblText.Text =                 
                "Charming but aggressive. Can come off as boring, but they are not. " +  
                "Hard workers. Warm-hearted. Strong, has endurance. Solid beings " +     
                "who are stable and secure in their ways. Not looking for shortcuts. " +      
                "Take pride in their beauty. Patient and reliable. Make great friends. " +    
                "and give good advice. Loving and kindLoves hard - passionate. " +           
                "Express themselves emotionally. Prone to ferocioustemper-tantrums. " +        
                "Determined. Indulge themselves often. Very generous.";         } 
        else if (cbGemini.Checked == true)        
        {             Image img = Image.FromFile("1.jpg"); 
            lblPicture.Image = img;       
            lblText.Text =                
                "Smart and witty. Outgoing, very chatty. Lively, energetic. " +   
                "Adaptable but needs to express themselves. Argumentative and outspoken. " +     
                "Likes change. Versatile. Busy, sometimes nervous and tense. " +         
                "Gossips. May seem superficial or inconsistent, but is only changeable. " +  
                "Beautiful physically and *mentally.";         }  
        else if (cbCancer.Checked == true)     
        {             Image img = Image.FromFile("1.jpg"); 
            lblPicture.Image = img;            
            lblText.Text =                
                "Moody, emotional. May be shy. Very loving and caring. Pretty/handsome. " +   
                "Excellent partners for life. Protective. Inventive and imaginative. " +      
                "Cautious.Touchy-feely kind of person. Needs love from others. " +            
                "Easily hurt, but sympathetic.";         }  
        else if (cbLeo.Checked == true)      
        {             Image img = Image.FromFile("1.jpg"); 
            lblPicture.Image = img;          
            lblText.Text =                 
                "Very organized. Need order in their lives - like being in control. " +      
                "Like boundaries. Tend to take over *everything. Bossy. Like to help " +
                 "others. Social and outgoing. Extroverted. Generous, warm-hearted. " +    
                 "Sensitive.Creative energy. Full of themselves. Loving. " +    
                 "Doing the right thing is important to Leos. Attractive.";         
        }        
        else if (cbVirgo.Checked == true)        
        {             Image img = Image.FromFile("1.jpg");   
            lblPicture.Image = img;            
            lblText.Text =          
                "Dominant in relationships. Conservative. Always wants the last word. " +    
                "Argumentative. Worries. Very smart. Dislikes noise and chaos. Eager. " +  
                "Hardworking. Loyal. Beautiful. Easy to talk to. Hard to please. " +      
                "Harsh.Practical and very fussy. Often shy. Pessimistic.";     
        }        
        else if (cbLibra.Checked == true)    
        {             Image img = Image.FromFile("1.jpg");  
            lblPicture.Image = img;         
            lblText.Text =                 
                "Nice to everyone they meet. Can't make up their mind. " + 
                "Have own unique appeal. Creative, energetic, and very social. " +
                "Hates to be alone. Peaceful, generous. Very loving and beautiful. " + 
                "Flirtatious. Give in too easily. Procrastinators. Very gullible.";       
        }       
        else if (cbScorpio.Checked == true)      
        {             Image img = Image.FromFile("1.jpg"); 
            lblPicture.Image = img;           
            lblText.Text =              
                "Very energetic. Intelligent. Can be jealous and/or possessive. " +    
                "Hardworking. Great kisser. Can become obsessive or secretive. " +     
                "Holds grudges. Attractive. Determined.Loves being in long " +         
                "relationships. Talkative. Romantic. Can be self-centered at times. " + 
                "Passionate and Emotional.";        
        }        
        else if (cbSagittarius.Checked == true)      
        {             
            Image img = Image.FromFile("1.jpg");     
            lblPicture.Image = img;           
            lblText.Text =                 
                "Good-natured optimist. Doesn't want to grow up (Peter Pan Syndrome). " +
                "Indulges self. Boastful. Likes luxuries and gambling. " +               
                "Social and outgoing. Doesn't like responsibilities. Often fantasizes. " +
                "Impatient. Fun to be around.Having lots of friends. Flirtatious. " + 
                "Doesn't like rules. Sometimes hypocritical.Dislikes being " +
                "confined - tight spaces or even tight clothes. " + 
                 "Doesn't like being doubted. Beautiful inside and out.";
        }
        else if (cbCapricorn.Checked == true)
        { Image img = Image.FromFile("1.jpg");
            lblPicture.Image = img; 
            lblText.Text = "Patient and wise. Practical and rigid. Ambitious. " + 
                "Tends to be good-looking. Humorous and *funny. " + 
                "Can be a bit shy and reserved. Often pessimists. " + 
                "Capricorns tend to act before they think and can be unfriendly at " + 
                "times. Hold grudges. Like competition. Get what they want."; }
        else if (cbAquarius.Checked == true)
        { Image img = Image.FromFile("1.jpg"); 
            lblPicture.Image = img; lblText.Text = 
                "Optimistic and honest. Sweet personality. Very independent. " +
                "Can be a bit rebellious. Very stubborn, but original and unique " + 
                "attractive on the inside and out. Eccentric personality."; }
        else if (cbPisces.Checked == true)
        { Image img = Image.FromFile("1.jpg");
            lblPicture.Image = img; lblText.Text =
                "Generous, kind, and thoughtful. Very creative and imaginative. " +
                "May become secretive and vague. Sensitive. " + 
                "Don't like details Dreamy and unrealistic. " + 
                "Sympathetic and loving. Kind. Unselfish. " + 
                "Good kisser. Beautiful."; }
    }
}