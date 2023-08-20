using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace manager
{
    public partial class Form1 : Form
    {
        //Lista com todas as tarefas adicionadas
        private List<string> texto = new List<string>();
        //Lista de tarefas checked
        private List<string> concluidos = new List<string>();

        //Indica o Filtro anterior Selecionado
        // 0 = todos, 1 = Concluido, 3 = pendentes
        private int filtroAnterior = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Adiciona o novo item na checklistBox
            Tasks.Items.Add(txtNewTask.Text);
            //Adiciona o item na lista de todas as tarefas
            texto.Add(txtNewTask.Text);

            txtNewTask.Text = "";
            txtNewTask.Focus();

        }

        //Filtro de tarefas Concluidas
        private void radioButton2_Click(object sender, EventArgs e)
        {
            //Atualiza quais são as tarefas concluidas na Lista
            AtualizarListaTasksConcluidas();

            filtroAnterior = 1;

            //Limpa a Exibição atual do CheckListBox
            Tasks.Items.Clear();

            //Exibe apenas concluidas
            foreach (var t in texto)
            {
                if (concluidos.Contains(t))
                {
                    Tasks.Items.Add(t, true);
                }
            }
        }

        //Filtro de tarefas Pendentes
        private void radioButton3_Click(object sender, EventArgs e)
        {
            AtualizarListaTasksConcluidas();
            Tasks.Items.Clear();

            filtroAnterior = 2;

            //Exibe apenas as que não estão na lista de concluidas
            foreach (var t in texto)
            {
                if (!concluidos.Contains(t))
                {
                    Tasks.Items.Add(t);
                }
            }
        }

        //Todos da Lista
        private void radioButton1_Click(object sender, EventArgs e)
        {
            AtualizarListaTasksConcluidas();
            Tasks.Items.Clear();

            filtroAnterior = 0;

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

        //Atualiza quais são as tarefas concluidas na Lista
        private void AtualizarListaTasksConcluidas()
        {
            //caso o filtro anterior seja o pendente a lista não pode ser limpa, se não perdemos os concluidos
            if (filtroAnterior == 0 || filtroAnterior == 1)
            {   //Limpo a lista e readiciono
                concluidos.Clear();
            }

            foreach (var task in Tasks.CheckedItems)
            {
                if (!concluidos.Contains(task))
                {
                    concluidos.Add(task.ToString());
                }
            }

        }

    }
}
