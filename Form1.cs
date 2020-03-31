using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> RusWords = new Dictionary<string, string>();
        Dictionary<string, string> EngWords = new Dictionary<string, string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            RusWords.Add("Новичок", "Новичок");
            RusWords.Add("Любитель", "Любитель");
            RusWords.Add("Профи", "Профи");
            RusWords.Add("Выбор сложности", "Выбор сложности");
            RusWords.Add("Выбирите язык", "Выбирите язык");
            RusWords.Add("Выбирите языкы", "Выбирите языкы");
            EngWords.Add("Новичок", "Newbie");
            EngWords.Add("Любитель", "Amateur");
            EngWords.Add("Профи", "Profi");
            EngWords.Add("Выбор сложности", "Soloma");
            EngWords.Add("Выбирите язык", "Derevo");
            EngWords.Add("Выбирите языкы", "№3");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = RusWords["Новичок"];
            button1.Text = EngWords["Любитель"];  
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
      button1.Text = RusWords["Любитель"];
      button1.Text = EngWords["Новичок"];
      button2.Text = RusWords["Новичок"];
      button2.Text = EngWords["Любитель"];
      button3.Text = RusWords["Профи"];
      button3.Text = EngWords["Профи"];
      label3.Text = RusWords["Выбор сложности"];
      label3.Text = EngWords["Выбор сложности"];
      label2.Text = RusWords["Выбирите язык"];
      label2.Text = EngWords["Выбирите язык"];
      label1.Text = RusWords["Выбирите языкы"];
      label1.Text = EngWords["Выбирите языкы"]; 
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            button1.Text = EngWords["Любитель"];
            button1.Text = RusWords["Новичок"];
            button2.Text = EngWords["Новичок"];
            button2.Text = RusWords["Любитель"];
            button3.Text = EngWords["Профи"];
            button3.Text = RusWords["Профи"];
            label3.Text = EngWords["Выбор сложности"];
            label3.Text = RusWords["Выбор сложности"];
            label2.Text = EngWords["Выбирите язык"];
            label2.Text = RusWords["Выбирите язык"];
            label1.Text = EngWords["Выбирите языкы"];
            label1.Text = RusWords["Выбирите языкы"]; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
         button1.Text = RusWords["Любитель"];
         button2.Text = EngWords["Новичок"];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        } 
    }
}
