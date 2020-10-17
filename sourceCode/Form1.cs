using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HomeworkManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\cache.html", false, Encoding.UTF8);
            writer.Write("<html><head><meta charset=GB2312><title>本周作业</title></head><body><font size=255 color='red' face='Microsoft YaHei'>本周作业如下</font>");
            writer.Write("<h1>语文作业:</h1><p><h4>" + textBox1.Text + "</h4></p>");
            writer.Write("<h1>数学作业:</h1><p><h4>" + textBox2.Text + "</h4></p>");
            writer.Write("<h1>英语作业:</h1><p><h4>" + textBox3.Text + "</h4></p>");
            writer.Write("<h1>生物作业:</h1><p><h4>" + textBox4.Text + "</h4></p>");
            writer.Write("<h1>历史作业:</h1><p><h4>" + textBox5.Text + "</h4></p>");
            writer.Write("<h1>思品（政治）作业:</h1><p><h4>" + textBox6.Text + "</h4></p>");
            writer.Write("<h1>地理作业:</h1><p><h4>" + textBox7.Text + "</h4></p>");
            writer.Write("<h1>其他作业:</h1><p><h4>" + textBox8.Text + "</h4></p>");
            writer.Write("</body></html>");
            writer.Close();
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\cache.html");
        }
    }
}
