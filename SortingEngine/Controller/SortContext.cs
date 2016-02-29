using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SortingEngine
{
    class SortContext{

        View _view;
        Model _model;
        SortStrategy _strategy;

        public SortContext()
        {
            _model = new Model();
        }

        public void sortBtn_Click(object sender, EventArgs e)
        {
            if (_view.getSortingMethodName().Equals("Selection Sort"))
            {
                //set strategy to selection sort
                SetSortStrategy(new SelectionSort());
            }
            else
            {
                //set strategy to merge sort
                SetSortStrategy(new MergeSort());
            }

            _strategy.Sort(_model.getUnSortedList(), _view);
        }

        public void SetSortStrategy(SortStrategy sortstrategy){
            _strategy = sortstrategy;
        }
        public void arraySizeBar_ValueChanged(object sender, EventArgs e){
            _model.reset(_view.getArraySize()); //reset model's array
            _view.setArraySize(_model.arraySize.ToString()); //set text box in view to new array size
            _view.arrayToBars(_model.getUnSortedList()); //update view
        }
        public void exitBtn_Click(object sender, EventArgs e){
            _view.Close();
        }
        public void View_Activated(object sender, EventArgs e){
            _view = (View)sender; //cast sender, set as view
            _model.reset(_view.getArraySize()); //set array in model
            _view.arrayToBars(_model.getUnSortedList()); //update view
        }
        public void resetBtn_Click(object sender, EventArgs e){
            _model.reset(_view.getArraySize()); //reset array in model (same size)
            _view.arrayToBars(_model.getUnSortedList()); //update view
        }
    }
}
