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

namespace wpfSendillOnIce
{
    /// <summary>
    /// Interaction logic for winUsers.xaml
    /// </summary>
    public partial class winUsers : Window
    {
        public winUsers()
        {
            InitializeComponent();
        }

        private System.Data.Objects.ObjectQuery<tbl_users> Gettbl_usersQuery(dbpallettEntities dbpallettEntities)
        {
            // Auto generated code

            System.Data.Objects.ObjectQuery<wpfSendillOnIce.tbl_users> tbl_usersQuery = dbpallettEntities.tbl_users;
            // Returns an ObjectQuery.
            return tbl_usersQuery;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            wpfSendillOnIce.dbpallettEntities dbpallettEntities = new wpfSendillOnIce.dbpallettEntities();
            // Load data into tbl_users. You can modify this code as needed.
            System.Windows.Data.CollectionViewSource tbl_usersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tbl_usersViewSource")));
            System.Data.Objects.ObjectQuery<wpfSendillOnIce.tbl_users> tbl_usersQuery = this.Gettbl_usersQuery(dbpallettEntities);
            tbl_usersViewSource.Source = tbl_usersQuery.Execute(System.Data.Objects.MergeOption.AppendOnly);
        }
    }
}
