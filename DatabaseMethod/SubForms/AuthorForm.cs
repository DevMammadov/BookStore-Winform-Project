using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseMethod.SubForms
{
    public partial class AuthorForm : Form
    {
        DataBase<Model.Author> author = new DataBase<Model.Author>();
        public AuthorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if( author.Add(new Model.Author(textBox1.Text, textBox2.Text)))
            {
                MessageBox.Show(textBox1.Text + " Elave edildi!");
            }
            else
            {
                MessageBox.Show("Xeta ad elave edilmedi");
            }
        }

        //public LoadGrid()
        //{

        //}
    }
}
