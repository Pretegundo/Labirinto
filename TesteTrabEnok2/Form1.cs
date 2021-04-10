using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteTrabEnok2
{
    partial class Form1 : Form
    {
        System.Drawing.SolidBrush bru2 = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
        //Pen pen = new Pen(Color.Black, 1);
        Graphics Gra = null;
        Cell current;
        Cell queijo;

        public int cols, rows;
        public int w = 20;
        public List<Cell> grid = new List<Cell>();
        public List<Cell> stack = new List<Cell>();
        public Random ran = new Random();

        public Form1()
        {
            InitializeComponent();
            setup();
        }

        public void setup()
        {
            //this.ClientSize = new Size(416, 439);
            cols = canvas.Width / w;
            rows = canvas.Height / w;

            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < cols; i++)
                {
                    Cell cell = new Cell(i, j); //criando a celula
                    grid.Add(cell); // adicionando no grid
                    cell.valor = ran.Next(0, 100); // adcionando peso para cada "quadradinho" do labirinto
                }
            }

            current = grid[0];
            grid[0].rato = true;
            //Gra = canvas.CreateGraphics();
            //for (int i = 0; i < grid.Count(); i++) // desenhando todas as linha # (nao é necessario nessa parte do codigo... tem outro no montarLabirinto())
            //{
            //    grid.ElementAt(i).show(w, Gra);
            //}

            do
            {
                draw();
            } while (current != grid[0]);


        }

        public void draw()
        {
            current.visited = true;
            //current.highlight(w, Gra);

            Cell next = current.checkNeighbors(grid, this);
            if (next != null)
            {
                next.visited = true;


                stack.Add(current);


                removeWalls(current, next);


                current = next;
            }
            else if (stack.Count() > 0)
            {
                current = stack[stack.Count() - 1];
                stack.RemoveAt(stack.Count() - 1);
            }
        }


        public void removeWalls(Cell a, Cell b)
        {
            int x = a.i - b.i;
            if (x == 1)
            {
                a.walls[3] = false;
                b.walls[1] = false;
            }
            else if (x == -1)
            {
                a.walls[1] = false;
                b.walls[3] = false;
            }
            int y = a.j - b.j;
            if (y == 1)
            {
                a.walls[0] = false;
                b.walls[2] = false;
            }
            else if (y == -1)
            {
                a.walls[2] = false;
                b.walls[0] = false;
            }
        }

        public int index(int i, int j)
        {
            if (i < 0 || j < 0 || i > cols - 1 || j > rows - 1)
            {
                return -1;
            }
            return i + j * cols;
        }

        private void resetar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            grid.Clear();
            stack.Clear();
            setup();
            canvas.BackColor = System.Drawing.SystemColors.Control;
            canvas.Refresh();
            montarLabirinto();
        }

        private void criar_Click(object sender, EventArgs e)
        {

            canvas.BackColor = System.Drawing.SystemColors.Control;
            canvas.Refresh();
            montarLabirinto();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            //setup();
            //montarLabirinto();

        }

        private void procurar_Click(object sender, EventArgs e)
        {
            BuscaQueijo bus = new BuscaQueijo();
            bus.buscar(this, Gra);
            txtValor.Text = bus.retornarValortxt();
            txtValor.Refresh();
        }

        private void montarLabirinto()
        {
            Gra = canvas.CreateGraphics();
            for (int i = 0; i < grid.Count(); i++)
            {
                grid.ElementAt(i).show(w, Gra);
            }

            int r = ran.Next(0, grid.Count());
            queijo = grid[r];
            grid[r].queijo = true;

            int x = queijo.i * w;
            int y = queijo.j * w;
            Gra.FillRectangle(bru2, x + 3, y + 3, w - 6, w - 6);

        }

    }
}
