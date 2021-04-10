using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteTrabEnok2
{
    class Cell
    {
        public string teste = "";
        public bool rato = false;
        public int valor = 0;
        public bool queijo = false;
        public int i, j;
        public bool[] walls = { true, true, true, true };
        public bool visited = false;
        Pen pen = new Pen(Color.Black, 2);
        System.Drawing.SolidBrush bru1 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        System.Drawing.SolidBrush bru2 = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);

        public Cell(int ii, int jj)
        {
            i = ii;
            j = jj;
        }

        public void show(int w, Graphics Gra)
        {

            int x = this.i * w;
            int y = this.j * w;
            if (this.walls[0])
            {
                Gra.DrawLine(pen, x, y, x + w, y);
            }
            if (this.walls[1])
            {
                Gra.DrawLine(pen, x + w, y, x + w, y + w);
            }
            if (this.walls[2])
            {
                Gra.DrawLine(pen, x + w, y + w, x, y + w);
            }
            if (this.walls[3])
            {
                Gra.DrawLine(pen, x, y + w, x, y);
            }
            if (this.rato)// desenhar rato quando for movimentar, nao aqui
            {
                Gra.FillRectangle(bru1, x + 3, y + 3, w - 6, w - 6);
            }
        }

        public Cell checkValorVizinho(List<Cell> grid, Form1 f) // BuscaQueijo
        {
            List<Cell> neighbors = new List<Cell>();
            Cell top = null;
            Cell right = null;
            Cell bottom = null;
            Cell left = null;

            if (f.index(i, j - 1) != -1)
            {
                top = grid[f.index(i, j - 1)];
            }
            if (f.index(i + 1, j) != -1)
            {
                right = grid[f.index(i + 1, j)];
            }
            if (f.index(i, j + 1) != -1)
            {
                bottom = grid[f.index(i, j + 1)];
            }
            if (f.index(i - 1, j) != -1)
            {
                left = grid[f.index(i - 1, j)];
            }

            if (top != null && !top.visited && !top.walls[2])
            {
                neighbors.Add(top);
            }
            if (right != null && !right.visited && !right.walls[3])
            {
                neighbors.Add(right);
            }
            if (bottom != null && !bottom.visited && !bottom.walls[0])
            {
                neighbors.Add(bottom);
            }
            if (left != null && !left.visited && !left.walls[1])
            {
                neighbors.Add(left);
            }


            // agora vai buscar o menor valor
            string aux = "";
            teste = "";
            Cell menor = new Cell(-2, -2);
            menor.valor = int.MaxValue;
            if (neighbors.Count() > 0)
            {
                for (int i = 0; i < neighbors.Count(); i++)
                {
                    if (neighbors.Count() > 1)
                    {
                        aux = aux + neighbors[i].valor.ToString() + "  ";
                    }
                    if (menor.valor > neighbors[i].valor)
                    {
                        menor = neighbors[i];
                    }
                }

                if (neighbors.Count() > 1)
                {
                    teste = "Pesos: " + aux + "\r\n" + "Valor escolhido: " + menor.valor.ToString() + "\r\n\r\n";
                }

                return menor;
            }
            else
            {
                return null;
            }
        }
        public string teste1()
        {
            return teste;
        }
        public Cell checkNeighbors(List<Cell> grid, Form1 f)
        {

            List<Cell> neighbors = new List<Cell>();
            Cell top = null;
            Cell right = null;
            Cell bottom = null;
            Cell left = null;

            if (f.index(i, j - 1) != -1)
            {
                top = grid[f.index(i, j - 1)];
            }
            if (f.index(i + 1, j) != -1)
            {
                right = grid[f.index(i + 1, j)];
            }
            if (f.index(i, j + 1) != -1)
            {
                bottom = grid[f.index(i, j + 1)];
            }
            if (f.index(i - 1, j) != -1)
            {
                left = grid[f.index(i - 1, j)];
            }

            if (top != null && !top.visited)
            {
                neighbors.Add(top);
            }
            if (right != null && !right.visited)
            {
                neighbors.Add(right);
            }
            if (bottom != null && !bottom.visited)
            {
                neighbors.Add(bottom);
            }
            if (left != null && !left.visited)
            {
                neighbors.Add(left);
            }
            if (neighbors.Count() > 0)
            {
                int r = f.ran.Next(0, neighbors.Count());
                return neighbors.ElementAt(r);
            }
            else
            {
                return null;
            }
        }
        public void highlight(int w, Graphics Gra)
        {
            int x = this.i * w;
            int y = this.j * w;
            Gra.FillRectangle(bru2, x, y, w, w);
        }

    }
}
