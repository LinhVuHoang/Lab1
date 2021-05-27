using System;
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
using Lab1.Models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Lab1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Mail : Page
    {
        public Mail()
        {
            this.InitializeComponent();
        }

        private void ListMail_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (object value in Mail_create.C)
            {
                ListMail.Items.Add(value);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SubFrame5.Navigate(typeof(Pages.Mail_create));
        }
    }
}
