using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
  public partial class Form1 : Form
  {
    int index = 0;

    public Form1()
    {
      InitializeComponent();
    }
    int roll()
    {
      int sum = 0;
      int dice = 0;
      Random rand = new Random();
      label7.Text = "";
      if (label7.Visible == false)
      {
        label7.Visible = true;
      }
      for (int i = 0; i < 3; i++)
      {
        dice = rand.Next(1, 6);
        if ( i == 2)
        {
          label7.Text += dice;
        }
        else
        {
          label7.Text += string.Format("{0} + ", dice);
        }
        sum += dice;
      }

      return sum;
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      switch (index)
      {
        case 0:
          textBox1.Text = roll().ToString();
          break;
        case 1:
          textBox2.Text = roll().ToString();
          break;
        case 2:
          textBox3.Text = roll().ToString();
          break;
        case 3:
          textBox4.Text = roll().ToString();
          break;
        case 4:
          textBox5.Text = roll().ToString();
          break;
        case 5:
          textBox6.Text = roll().ToString();
          break;
      }
      index++;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      index = 0;
      textBox1.Text = "";
      textBox2.Text = "";
      textBox3.Text = "";
      textBox4.Text = "";
      textBox5.Text = "";
      textBox6.Text = "";
      label7.Visible = false;
    }
  }
}