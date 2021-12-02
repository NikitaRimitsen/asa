using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaberRockKamen
{
    public partial class Form1 : Form
    {
        TreeView tree;


        public Form1()
        {
            this.Height = 700;//свойство высота формы
            this.Width = 1200;//свойство ширины формы, если это свойство то после, ставится =
            this.Text = "Rock Paper Scissors";//Text - название, заголовок формы
            this.BackColor = Color.Blue;

            tree = new TreeView();
            tree.Dock = DockStyle.Top;
            tree.Width = 50;
            tree.AfterSelect += Tree_AfterSelect;

            MenuStrip menu = new MenuStrip();
            ToolStripMenuItem menuFile = new ToolStripMenuItem("File");
            this.MainMenuStrip = menu;


            TreeNode tnnas = new TreeNode("Настройки");

            tnnas.Nodes.Add(new TreeNode("Цвет"));
            tnnas.Nodes.Add(new TreeNode("Шрифт"));
            tnnas.Nodes.Add(new TreeNode("Размер"));
            tnnas.Nodes.Add(new TreeNode("Выбор картинок"));

            tree.Nodes.Add(tnnas);//связались
            this.Controls.Add(tree);//добавляет в форму
        }


        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
