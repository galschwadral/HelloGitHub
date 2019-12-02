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

namespace TictactoeWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class TicTacToeWindow : Window
    {
        Controller control = new Controller();
        
        public TicTacToeWindow()
        {
            InitializeComponent();
            
            lbl1.Content = control.GiveViewScore(1);
            lbl2.Content = control.GiveViewScore(2);

            btn1.Click += MyButtonClick;
            btn2.Click += MyButtonClick;
            btn3.Click += MyButtonClick;
            btn4.Click += MyButtonClick;
            btn5.Click += MyButtonClick;
            btn6.Click += MyButtonClick;
            btn7.Click += MyButtonClick;
            btn8.Click += MyButtonClick;
            btn9.Click += MyButtonClick;
            replayBtn.Click += MyButtonClick;
        }

        void MyButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Name)
            {
                case "btn1":
                    control.ClickAction(btn1, replayBtn, 1, playGrid);
                    break;
                case "btn2":
                    control.ClickAction(btn2, replayBtn, 2, playGrid);
                    break;
                case "btn3":
                    control.ClickAction(btn3, replayBtn, 3, playGrid);
                    break;
                case "btn4":
                    control.ClickAction(btn4, replayBtn, 4, playGrid);
                    break;
                case "btn5":
                    control.ClickAction(btn5, replayBtn, 5, playGrid);
                    break;
                case "btn6":
                    control.ClickAction(btn6, replayBtn, 6, playGrid);
                    break;
                case "btn7":
                    control.ClickAction(btn7, replayBtn, 7, playGrid);
                    break;
                case "btn8":
                    control.ClickAction(btn8, replayBtn, 8, playGrid);
                    break;
                case "btn9":
                    control.ClickAction(btn9, replayBtn, 9, playGrid);
                    break;
                case "replayBtn":
                    control.Replay(replayBtn, playGrid);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            lbl1.Content = control.GiveViewScore(1);
            lbl2.Content = control.GiveViewScore(2);
            winnerLbl.Content = control.winOutput;
        }
    }
}
