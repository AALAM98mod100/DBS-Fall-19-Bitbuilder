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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BitBuilder_v1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class upd_proc : Page
    {
        public upd_proc()
        {
            this.InitializeComponent();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(admin_dash));
        }


        private void cancel_click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(admin_dash));
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }


        private void type_box_changed(object sender, TextChangedEventArgs e)
        {

        }
    }
}
