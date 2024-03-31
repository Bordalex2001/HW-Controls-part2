using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace HW_Controls__part_2_
{
    public interface IModel
    {
        int Index { get; set; }
        ImageSource Picture { get; set; }
    }
}