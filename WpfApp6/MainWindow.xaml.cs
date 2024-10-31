using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random _random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RunAwayButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            double canvasWidth = MainCanvas.ActualWidth;
            double canvasHeight = MainCanvas.ActualHeight;

 
            double buttonWidth = RunAwayButton.ActualWidth;
            double buttonHeight = RunAwayButton.ActualHeight;

        
            double newLeft = _random.NextDouble() * (canvasWidth - buttonWidth);
            double newTop = _random.NextDouble() * (canvasHeight - buttonHeight);

       
            DoubleAnimation leftAnimation = new DoubleAnimation
            {
                To = newLeft,
                Duration = TimeSpan.FromSeconds(0.5)
            };

            DoubleAnimation topAnimation = new DoubleAnimation
            {
                To = newTop,
                Duration = TimeSpan.FromSeconds(0.5)
            };

            RunAwayButton.BeginAnimation(Canvas.LeftProperty, leftAnimation);
            RunAwayButton.BeginAnimation(Canvas.TopProperty, topAnimation);
        }
    }
}
