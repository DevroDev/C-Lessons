using System;
using System.Windows.Forms;
public class Program
{
    public static void Main()
    {
        DialogResult result = MessageBox.Show("Pont will you marry me?","Proposal",
            MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
        if (result == DialogResult.Yes)
            MessageBox.Show("Oh!Yeah!I'm the happiest man in the world!\nYou are my angle!");
        else
            MessageBox.Show("Are you sure,Pont?\nI can't live without you,you know?\nCan I have an another chance?");
    }
}

