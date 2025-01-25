using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Dijkstra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int V = 8;
            Graph graph = new Graph(V);

            graph.AddEdge(0, 1, 5);
            graph.AddEdge(0, 7, 8);
            graph.AddEdge(1, 2, 4);
            graph.AddEdge(1, 7, 2);
            graph.AddEdge(2, 3, 7);
            graph.AddEdge(2, 5, 5);
            graph.AddEdge(3, 4, 9);
            graph.AddEdge(3, 5, 14);
            graph.AddEdge(4, 5, 10);
            graph.AddEdge(5, 6, 2);
            graph.AddEdge(6, 7, 6);           


            graph.Dijkstra(0);
        }
    }
}
