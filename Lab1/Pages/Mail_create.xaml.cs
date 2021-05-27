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
    public sealed partial class Mail_create : Page
    {
        private static List<MailList> c = new List<MailList>();
        public Mail_create()
        {
            this.InitializeComponent();
        }
        internal static List<MailList> C { get => c; set => c = value; }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            string email = input2.Text;
            MailList cl = new MailList(email);
            C.Add(cl);
            SubFrame6.Navigate(typeof(Pages.Mail));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SubFrame6.Navigate(typeof(Pages.Mail));
        }
    }
}
