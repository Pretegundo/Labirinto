using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteTrabEnok2
{
    class BuscaQueijo
    {
        public string teste = "";
        //public List<Cell> grid = new List<Cell>();
        public List<Cell> stack = new List<Cell>();
        System.Drawing.SolidBrush bru1 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        System.Drawing.SolidBrush bru2 = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
        Cell current;

        public void buscar(Form1 f, Graphics Gra)
        {
            current = f.grid[0];

            for (int i = 0; i < f.grid.Count; i++)
            {
                f.grid[i].visited = false;
            }
            do
            {
                procurarQueijo(f, Gra);
                teste += current.teste1();
            } while (!current.queijo);

        }

        public string retornarValortxt()
        {
            return teste;
        }
        public void procurarQueijo(Form1 f, Graphics Gra)
        {
            current.visited = true;

            Cell next = current.checkValorVizinho(f.grid, f);

            Thread.Sleep(50);

            if (next != null)
            {
                next.visited = true;

                stack.Add(current);

                int x = current.i * f.w;
                int y = current.j * f.w;
                Gra.FillRectangle(bru1, x + 3, y + 3, f.w - 6, f.w - 6);

                current = next;
            }
            else if (stack.Count() > 0)
            {
                int x = current.i * f.w;
                int y = current.j * f.w;
                Gra.FillRectangle(bru2, x + 3, y + 3, f.w - 6, f.w - 6);

                current = stack[stack.Count() - 1];
                stack.RemoveAt(stack.Count() - 1);
            }
        }
    }
}
