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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Разметка кнопок для выбора дат
            DateTime dateFirst = DateTime.Now;
            for (int i = 0; i < 31; i++)
            {
                Button btn = new Button();
                btn.Content = dateFirst.ToString("dd.MM");
                btn.Height = 30;
                btn.Width = 37;
                btn.FontSize = 12;
                btn.Margin = new Thickness(1);
                btn.Padding = new Thickness(0);
                datesButtons.Children.Add(btn);
                dateFirst = dateFirst.AddDays(1);
            }
            //Разметка горизонтальной нумерации аудиторий
            int k = 0;
            for (int i = 0; i < 12; i++)                    // Подставляем кол-во аудиторий после проверки БД вместо 12
            {
                k++;
                TextBlock textBlock = new TextBlock();
                textBlock.FontSize = 20;
                textBlock.Foreground = Brushes.Gray;
                textBlock.TextAlignment = TextAlignment.Center;
                textBlock.Width = 75;
                textBlock.Text = k.ToString();
                classRoomNumber.Children.Add(textBlock);
                //Width = "116" Height = "85.333"
            }
            //Разметка 1 пары с инфой по аудиториям 
            
            for (int i = 0; i < 12; i++)                    // Подставляем кол-во аудиторий после проверки БД вместо 12
            { 
                Button btn = new Button();
                btn.Width = 75; 
                btn.Background = Brushes.White;

                TextBlock txtCenter = new TextBlock();
                txtCenter.FontSize = 15;
                txtCenter.TextAlignment = TextAlignment.Center;
                txtCenter.Foreground = Brushes.Gray;
                txtCenter.Text = 2.ToString();

                TextBlock txtRight = new TextBlock();
                txtRight.FontSize = 11;
                txtRight.Foreground = Brushes.Gray;
                txtRight.Padding = new Thickness(55, 0, 0, 0);
                txtRight.Text = 7.ToString();

                Grid grid = new Grid();
                RowDefinition rowDef1 = new RowDefinition();
                rowDef1.Height = new GridLength(18, GridUnitType.Pixel);
                RowDefinition rowDef2 = new RowDefinition();
                rowDef2.Height = new GridLength(62, GridUnitType.Pixel);
                grid.RowDefinitions.Add(rowDef1);
                grid.RowDefinitions.Add(rowDef2);

                Grid.SetRow(txtRight, 0);
                Grid.SetRow(txtCenter, 1);

                grid.Children.Add(txtRight);
                grid.Children.Add(txtCenter);

                btn.Content = grid;
                class1Rooms.Children.Add(btn);
                //Width = "116" Height = "85.333"
            }
        }
    }
}