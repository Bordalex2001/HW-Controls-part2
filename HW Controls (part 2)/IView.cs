using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Controls__part_2_
{
    internal interface IView
    {
        void SetPuzzlePieces(List<Puzzle> pieces);
        void ShowMessage(string message);
    }
}