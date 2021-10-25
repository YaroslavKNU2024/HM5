using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class CellElement
    {
        private int indRow;
        private int indCol;
        public string name;
        public string expression;
        public string value;
        //public bool CellClickedUpon() => false;
        public CellElement() { }
        public CellElement(int row, int col, string expression, string value)
        {
            this.indRow = row;
            this.indCol = col;
            this.name = "R" + indRow.ToString() + "C" + indCol.ToString();
            this.expression = expression;
            this.value = value;
        }

    }
}
