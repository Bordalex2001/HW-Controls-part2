using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.IO;

namespace HW_Controls__part_2_
{
    internal class Presenter
    {
        private readonly IView _view;
        private readonly List<Puzzle> _pieces;
        public Presenter(IView view)
        {
            _view = view;
            _pieces = new List<Puzzle>();
            MakePieces();
            _view.SetPuzzlePieces(_pieces);
        }
        private void MakePieces()
        {
            BitmapImage bitmapImage = new BitmapImage(new Uri(@"C:\Users\user\Desktop\pic1.jpg", UriKind.RelativeOrAbsolute));
            for(int i = 0; i < 9; i++)
            {
                CroppedBitmap piece = new CroppedBitmap(bitmapImage, new Int32Rect(i % 3 * 100, i / 3 * 100, 100, 100));
                _pieces.Add(new Puzzle { Index = i, Picture = piece });
            }
        }
        public void CheckPuzzleSolution()
        {
            bool isSolved = true;
            for(int i = 0; i < 9; i++)
            {
                if (_pieces[i].Index != i)
                {
                    isSolved = false;
                    break;
                }
            }
            if (isSolved)
            {
                _view.ShowMessage("Вітаємо, ви склали пазл!");
            }
            else
            {
                _view.ShowMessage("Упс, спробуйте ще раз.");
            }
        }
    }
}