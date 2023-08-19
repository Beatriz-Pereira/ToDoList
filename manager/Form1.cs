using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager
{
    public partial class Form1 : Form
    {
        private List<string> texto = new List<string>();
        private List<string> concluidos = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Tasks.Items.Add(txtNewTask.Text);
            texto.Add(txtNewTask.Text);
            txtNewTask.Text = "";
            txtNewTask.Focus();

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            foreach (var task in Tasks.CheckedItems)
            {
                if (!concluidos.Contains(task))
                {
                    concluidos.Add(task.ToString());
                }
            }

            Tasks.Items.Clear();

            foreach (var t in texto)
            {
                if (concluidos.Contains(t))
                {
                    Tasks.Items.Add(t, true);
                }
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {

            foreach (var task in Tasks.CheckedItems)
            {
                if (!concluidos.Contains(task))
                {
                    concluidos.Add(task.ToString());
                }
            }

            Tasks.Items.Clear();

            foreach (var t in texto)
            {
                if (!concluidos.Contains(t))
                {
                    Tasks.Items.Add(t);
                }
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            Tasks.Items.Clear();

            foreach (var t in texto)
            {
                if (!concluidos.Contains(t))
                {
                    Tasks.Items.Add(t);
                }
                else
                {
                    Tasks.Items.Add(t, true);
                }
            }

        }


    }
}
