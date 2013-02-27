using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Collections;
using Microsoft.Win32;

namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btCalc1_Click(object sender, RoutedEventArgs e)
        {
            if (tBn.Text == "")
            {    MessageBox.Show("Укажи число элементов");
            }
               else {  //ArrayList MyArr = new ArrayList();
                int index;
                int number;
                int itemCount = Convert.ToInt32(tBn.Text);
                Random rnd1 = new Random();
                lB1.Items.Clear();
                for (index = 1; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    lB1.Items.Add(number);
                }
            }
           
            
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lB1.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }

        }

        private void btCalc2_Click(object sender, RoutedEventArgs e)
        {
            if (tBn.Text == "")
            {
                MessageBox.Show("Укажи число элементов");
            }
            else
            {
                ArrayList MyArr = new ArrayList();
                int index;
                int number;
                int itemCount = Convert.ToInt32(tBn.Text);
                Random rnd1 = new Random();
                lB1.Items.Clear();
                for (index = 1; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    lB1.Items.Add(number);
                    MyArr.Add(number);
                }
                MyArr.Sort();
                lB1.Items.Add("Отсортированный массив");
                foreach (int elem in MyArr)
                {
                    lB1.Items.Add(elem);
                }
            }
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
