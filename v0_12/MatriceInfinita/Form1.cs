using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriceInfinita
{
    public partial class Form1 : Form
    {
        const int xSize = 40, ySize = 80;
        int[,] Matrice = new int[xSize, ySize];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(GetM(0, 0).ToString());
            SetM(0, 0, 5);
            SetM(-1, 0, 6);
            SetM(43, 0, 6);
            MessageBox.Show(GetM(0, 0).ToString());
            MessageBox.Show(GetM(-1, 0).ToString());
        }

        public int GetM(int x, int y)
        {
            int i = AbstractionM(x, y)[0];
            int j = AbstractionM(x, y)[1];
            return Matrice[i, j];
        }

        public void SetM(int x, int y, int value)
        {
            int i = AbstractionM(x, y)[0];
            int j = AbstractionM(x, y)[1];
            Matrice[i, j] = value;
        }

        public int[] AbstractionM(int x, int y)
        {
            /*
            int i, j;
            if (x >= xSize)
                i = 0;
            else if (x < 0)
                i = xSize - 1;
            else
                i = x;
            if (y >= ySize)
                j = 0;
            else if (y < 0)
                j = ySize - 1;
            else
                j = y;
            return new int[] { i, j };
            */
            int i, j;
            int dx = xSize - (x + 1);
            int dy = ySize - (y + 1);

            if (dx < 0)
                i = 0 - dx;
            else if (dx > 0)
                i = 0 + dx - 1;
            else
                i = x;
            if (dy < 0)
                j = 0 - dx;
            else if (dy > 0)
                j = 0 + dx - 1;
            else
                j = y;

            return new int[] { i, j };
        }
    }
}
