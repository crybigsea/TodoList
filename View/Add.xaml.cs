using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TodoList.Model;
using TodoList.ViewModel;

namespace TodoList.View
{
    /// <summary>
    /// Add.xaml 的交互逻辑
    /// </summary>
    public partial class Add : Window
    {
        public Action<TodoModel> AddTask;
        private VMAdd vmAdd;

        public Add()
        {
            InitializeComponent();

            vmAdd = new VMAdd
            {
                
            };

            this.DataContext = vmAdd;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddTask?.Invoke(vmAdd.ToModel());
            this.Close();
        }
    }
}
