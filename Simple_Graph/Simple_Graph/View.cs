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

//Получает данные от модели и выводит их для пользователя

//вид - это интерфэйс

namespace Simple_Graph
{
    public partial class View : Form
    {
        Model model;
        Controller controller;
        List<Vertex> V;
        List<Edge> E;

        int[,] AMatrix; //матрица смежности

        int selected1; //выбранные вершины, для соединения линиями
        int selected2;

        public View()
        {
            InitializeComponent();
            this.controller = new Controller(sheet);
            model = new Model(sheet.Width, sheet.Height);
            V = new List<Vertex>();
            E = new List<Edge>();
            sheet.Image = model.GetBitmap();
        }

        //кнопка - рисовать вершину
        private void drawVertexButton_Click(object sender, EventArgs e)
        {
            drawVertexButton.Enabled = false;
            drawEdgeButton.Enabled = true;
            dlbutton.Enabled = true;
            model.clearSheet();
            model.drawALLGraph(V, E);
            sheet.Image = model.GetBitmap();
        }

        //кнопка - рисовать ребро
        private void drawEdgeButton_Click(object sender, EventArgs e)
        {
            drawEdgeButton.Enabled = false;
            drawVertexButton.Enabled = true;
            dlbutton.Enabled = true;
            model.clearSheet();
            model.drawALLGraph(V, E);
            sheet.Image = model.GetBitmap();
            selected1 = -1;
            selected2 = -1;
        }

        //кнопка - удалить элемент
        private void dlbutton_Click(object sender, EventArgs e)
        {
            dlbutton.Enabled = false;
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            model.clearSheet();
            model.drawALLGraph(V, E);
            sheet.Image = model.GetBitmap();
        }

        //кнопка - удалить граф
        private void deleteALLButton_Click(object sender, EventArgs e)
        {
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            dlbutton.Enabled = true;
            const string message = "Вы действительно хотите полностью удалить граф?";
            const string caption = "Удаление";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
                V.Clear();
                E.Clear();
                model.clearSheet();
                sheet.Image = model.GetBitmap();
            }
        }

        //кнопка - вывод матрицы смежности
        private void Matrix_Click(object sender, EventArgs e)
        {
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            dlbutton.Enabled = true;
            controller.AddMatrix(AMatrix, V, E, listBoxMatrix);
        }

        //кнопка - сохранить граф
        private void saveButton_Click(object sender, EventArgs e)
        {
            drawVertexButton.Enabled = true;
            drawEdgeButton.Enabled = true;
            dlbutton.Enabled = true;

            if (sheet.Image != null)
            {

                    SaveFileDialog savedialog = new SaveFileDialog();
                    savedialog.Title = "Сохранить картинку как...";
                    savedialog.OverwritePrompt = true;
                    savedialog.CheckPathExists = true;
                    savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                    savedialog.ShowHelp = true;
                    if (savedialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            sheet.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        catch
                        {
                            MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } 
            }
        }

        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            //нажата кнопка "рисовать вершину"
            if (drawVertexButton.Enabled == false)
            {
                controller.DrawVerg(V, E, e, sheet);

            }
            //нажата кнопка "рисовать ребро"
            if (drawEdgeButton.Enabled == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < V.Count; i++)
                    {
                        if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= model.R * model.R)
                        {
                            if (selected1 == -1)
                            {
                                selected1 = i;
                                break;
                            }
                            if (selected2 == -1)
                            {
                                selected2 = i;
                                controller.DrawEdge(V, E, selected1, selected2, e, sheet);
                                selected1 = -1;
                                selected2 = -1;
                                break;
                            }
                        }
                    }
                }
            }

            //нажата кнопка "удалить элемент"
            if (dlbutton.Enabled == false)
            {
                bool flag = false; //удалили ли что-нибудь по ЭТОМУ клику
                controller.Delet(V, E, flag, e, sheet);
            }
        }

        private void sheet_Click(object sender, EventArgs e)
        {

        }

        private void View_Load(object sender, EventArgs e)
        {

        }
    }
}
