using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

    namespace A3._2._6_Calculadora_Dinamica
        {
       public partial class MainWindow : Window
        {
        public MainWindow()
        {
            InitializeComponent();
            CrearBotonesDinamicos();
        }

        private void CrearBotonesDinamicos()
        {
            int numero = 1;

           
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Button btn = new Button();
                    btn.Content = numero.ToString();
                    btn.Click += Button_Click;


                    Grid.SetRow(btn, fila);
                    Grid.SetColumn(btn, columna);


                    ButtonGrid.Children.Add(btn);

                    numero++;
                }
            }

    
            Button btn0 = new Button();
            btn0.Content = "0";
            btn0.Click += Button_Click;
            Grid.SetRow(btn0, 3);
            Grid.SetColumn(btn0, 0);
            Grid.SetColumnSpan(btn0, 3);
            ButtonGrid.Children.Add(btn0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Display.Text += btn.Content.ToString();
            }
        }
    }
    }