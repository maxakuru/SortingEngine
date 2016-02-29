using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingEngine
{
    public partial class View : Form
    {
        SortContext my_controller;
        System.Drawing.Graphics graphics;

        public View()
        {
            InitializeComponent();

            my_controller = new SortContext();
            setArraySize("32");
            sortingMethod.SelectedIndex = 0;
            this.arraySizeBar.ValueChanged += new System.EventHandler(my_controller.arraySizeBar_ValueChanged);
            this.exitBtn.Click += new System.EventHandler(my_controller.exitBtn_Click);
            this.resetBtn.Click += new System.EventHandler(my_controller.resetBtn_Click);
            this.sortBtn.Click += new System.EventHandler(my_controller.sortBtn_Click);
            this.Activated += new System.EventHandler(my_controller.View_Activated);

        }

        public int getArraySize()
        {
            return this.arraySizeBar.Value;
        }

        public void setArraySize(string size)
        {
            this.arraySize.Text = size;
        }

        public void showBar(float x, float y, float w, float h)
        {
            graphics = this.canvas.CreateGraphics();
            using (Brush brush = new SolidBrush(Color.Blue))
            {
                graphics.FillRectangle(brush, x, y, w, h);
            }
        }

        public string getSortingMethodName()
        {
            return sortingMethod.SelectedItem.ToString();
        }

        public void arrayToBars(int[] list)
        {
            this.canvas.Refresh();
            int width = this.canvas.Width;
            int height = this.canvas.Height;

            if (list != null)
            {
                float spacing = (float)width / list.Length;
                float scaling = (float)height / list.Length;
                for (int i = 0; i < list.Length; i++)
                {
                    showBar(i * spacing,  // x
                              height - (list[i] * scaling), // y
                              spacing - 2, //width
                              list[i] * scaling //hight
                              );
                }
            }
        }
    }
}
