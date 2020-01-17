using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TodoList.Model;
using TodoList.View;

namespace TodoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<TodoModel> todoModels = new ObservableCollection<TodoModel>();
        private readonly CollectionViewSource todoViewSource;

        public MainWindow()
        {
            InitializeComponent();

            todoModels.Add(new TodoModel { Title = "task1", Content = "task wpf", EndTime = DateTime.Now, IsFinish = true });
            todoModels.Add(new TodoModel { Title = "task2", Content = "task java", EndTime = DateTime.Now.AddDays(1), IsStar = true });

            todoViewSource = (CollectionViewSource)Resources["todoViewSource"];
            todoViewSource.Source = todoModels;
            todoViewSource.Filter += TodoViewSource_Filter;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new Add
            {
                AddTask = (model) => todoModels.Add(model)
            };
            addWindow.ShowDialog();
        }

        private void ckAll_Checked(object sender, RoutedEventArgs e)
        {
            todoViewSource.Filter -= TodoViewSource_Filter;
        }

        private void ckAll_Unchecked(object sender, RoutedEventArgs e)
        {
            todoViewSource.Filter += TodoViewSource_Filter;
        }

        private void TodoViewSource_Filter(object sender, FilterEventArgs e)
        {
            var todoModel = e.Item as TodoModel;
            if (todoModel != null)
            {
                e.Accepted = todoModel.IsFinish == false;
            }
        }

    }
}
