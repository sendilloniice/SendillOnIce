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
using System.Windows.Shapes;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace wpfSendillOnIce
{
    /// <summary>
    /// Interaction logic for winUserList.xaml
    /// </summary>
    public partial class winUserList : Window
    {
        public winUserList()
        {
            InitializeComponent();
        }

        
        
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
