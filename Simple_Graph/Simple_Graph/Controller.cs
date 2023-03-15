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

//Обрабатывает действия пользователя, проверяет полученные данные и передает модели

//Контроллер - обработчик событий, инициализируемых пользователем.

namespace Simple_Graph
{
    class Controller
    {
        Model model = null;
        public Controller(PictureBox sheet)
        {
            this.model = new Model(sheet.Width, sheet.Height);
        }

        public void AddMatrix(int[,] AMatrix, List<Vertex> V, List<Edge> E, ListBox listBoxMatrix)
        {
            //создание матрицы смежности и вывод в листбокс
                AMatrix = new int[V.Count, V.Count];
                if (V.Count == 0) { MessageBox.Show("Build the graph!"); }
                model.fillAdjacencyMatrix(V.Count, E, AMatrix);
                listBoxMatrix.Items.Clear();
                string sOut = "    ";
                for (int i = 0; i < V.Count; i++)
                    sOut += (i + 1) + " ";
                listBoxMatrix.Items.Add(sOut);
                for (int i = 0; i < V.Count; i++)
                {
                    sOut = (i + 1) + " | ";
                    for (int j = 0; j < V.Count; j++)
                        sOut += AMatrix[i, j] + " ";
                    listBoxMatrix.Items.Add(sOut);
                }
                
        }

        public void DrawVerg(List<Vertex> V, List<Edge> E, MouseEventArgs e, PictureBox sheet)
        {
            V.Add(new Vertex(e.X, e.Y));
            model.drawVertex(e.X, e.Y, V.Count.ToString());
            sheet.Image = model.GetBitmap();
        }
        public void DrawEdge(List<Vertex> V, List<Edge> E, int selected1, int selected2, MouseEventArgs e, PictureBox sheet)
        {
            E.Add(new Edge(selected1, selected2));
            model.drawEdge(V[selected1], V[selected2], E[E.Count - 1], E.Count - 1);
            sheet.Image = model.GetBitmap();
        }
       
        public void Delet(List<Vertex> V, List<Edge> E, bool flag, MouseEventArgs e, PictureBox sheet)
        {
            //нажата кнопка "удалить элемент"
            for (int i = 0; i < V.Count; i++)
            {
                if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= model.R * model.R)
                {
                    for (int j = 0; j < E.Count; j++)
                    {
                        if ((E[j].v1 == i) || (E[j].v2 == i))
                        {
                            E.RemoveAt(j);
                            j--;
                        }
                        else
                        {
                            if (E[j].v1 > i) E[j].v1--;
                            if (E[j].v2 > i) E[j].v2--;
                        }
                    }
                    V.RemoveAt(i);
                    flag = true;
                    break;
                }
            }
            //ищем, возможно было нажато ребро
            if (!flag)
            {
                for (int i = 0; i < E.Count; i++)
                {
                    if (E[i].v1 == E[i].v2) //если это петля
                    {
                        if ((Math.Pow((V[E[i].v1].x - model.R - e.X), 2) + Math.Pow((V[E[i].v1].y - model.R - e.Y), 2) <= ((model.R + 2) * (model.R + 2))) &&
                            (Math.Pow((V[E[i].v1].x - model.R - e.X), 2) + Math.Pow((V[E[i].v1].y - model.R - e.Y), 2) >= ((model.R - 2) * (model.R - 2))))
                        {
                            E.RemoveAt(i);
                            flag = true;
                            break;
                        }
                    }
                    else //не петля
                    {
                        if (((e.X - V[E[i].v1].x) * (V[E[i].v2].y - V[E[i].v1].y) / (V[E[i].v2].x - V[E[i].v1].x) + V[E[i].v1].y) <= (e.Y + 4) &&
                            ((e.X - V[E[i].v1].x) * (V[E[i].v2].y - V[E[i].v1].y) / (V[E[i].v2].x - V[E[i].v1].x) + V[E[i].v1].y) >= (e.Y - 4))
                        {
                            if ((V[E[i].v1].x <= V[E[i].v2].x && V[E[i].v1].x <= e.X && e.X <= V[E[i].v2].x) ||
                                (V[E[i].v1].x >= V[E[i].v2].x && V[E[i].v1].x >= e.X && e.X >= V[E[i].v2].x))
                            {
                                E.RemoveAt(i);
                                flag = true;
                                break;
                            }
                        }
                    }
                }
            }
            //если что-то было удалено, то обновляем граф на экране
            if (flag)
            {
                model.clearSheet();
                model.drawALLGraph(V, E);
                sheet.Image = model.GetBitmap();
            }
        }

    }
}
