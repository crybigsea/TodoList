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

        public MainWindow()
        {
            InitializeComponent();

            todoModels.Add(new TodoModel { Title = "task1", Content = "task wpf", EndTime = DateTime.Now });
            todoModels.Add(new TodoModel { Title = "task2", Content = "task java", EndTime = DateTime.Now.AddDays(1), IsStar = true });

            lbTodoList.ItemsSource = todoModels;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new Add
            {
                AddTask = (model) => todoModels.Add(model)
            };
            addWindow.ShowDialog();
        }
    }
}
