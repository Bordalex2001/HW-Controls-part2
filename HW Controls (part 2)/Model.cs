using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;

namespace HW_Controls__part_2_
{
    public class Puzzle : IModel  //Puzzle is Model
    {
        public int Index { get; set; }
        public ImageSource Picture { get; set; }
    }
}