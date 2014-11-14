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

namespace learningXAML
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            learningXAML.peopleDataSet peopleDataSet = ((learningXAML.peopleDataSet)(this.FindResource("peopleDataSet")));

            // Load data into the table sample_data. You can modify this code as needed.
            learningXAML.peopleDataSetTableAdapters.sample_dataTableAdapter peopleDataSetsample_dataTableAdapter = new learningXAML.peopleDataSetTableAdapters.sample_dataTableAdapter();
            peopleDataSetsample_dataTableAdapter.Fill(peopleDataSet.sample_data);
            System.Windows.Data.CollectionViewSource sample_dataViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("sample_dataViewSource")));
            sample_dataViewSource.View.MoveCurrentToFirst();
        }

    }
}
