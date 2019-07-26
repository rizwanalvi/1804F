﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using AppDataBinding.Model;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppDataBinding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Fruit _fruit = new Fruit();
            lstData.ItemsSource = _fruit.GetAllFruits();
            comboBox.ItemsSource = _fruit.GetAllFruits();
            gridView.ItemsSource = _fruit.GetAllFruits();
        }

        private void lstData_ItemClick(object sender, ItemClickEventArgs e)
        {
            Fruit fr = (Fruit) e.ClickedItem;
            lblName.Text = fr.FruitName;
        }
    }
}