using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW_Controls__part_2_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        private readonly Presenter _presenter;
        public MainWindow()
        {
            InitializeComponent();
            _presenter = new Presenter(this);
        }

        public void SetPuzzlePieces(List<Puzzle> pieces)
        {
            foreach (Puzzle piece in pieces)
            {
                Image img = new Image { Source = piece.Picture };
                img.MouseDown += PuzzlePiece_MouseDown;
                puzzleGrid.Children.Add(img);
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void PuzzlePiece_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop((sender as Image), (sender as Image).Source, DragDropEffects.Move);
            }
        }

        private void PuzzleGrid_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                BitmapSource source = e.Data.GetData(DataFormats.Bitmap) as BitmapSource;
                if (e.Source is Image target)
                {
                    target.Source = source;
                    int index = puzzleGrid.Children.IndexOf(target);
                    _presenter.CheckPuzzleSolution();
                }
            }
        }
    }
}