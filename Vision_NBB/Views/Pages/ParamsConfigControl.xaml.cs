﻿using System;
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
using System.Windows.Shapes;

namespace Vision_NBB.Views.Pages
{
    /// <summary>
    /// ParamsConfigControl.xaml 的交互逻辑
    /// </summary>
    public partial class ParamsConfigControl : Window
    {
        public ParamsConfigControl()
        {
            InitializeComponent();
        }

        public ParamsConfigControl(string moduleName)
        {
            InitializeComponent();
           mainWin.Title= moduleName;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
