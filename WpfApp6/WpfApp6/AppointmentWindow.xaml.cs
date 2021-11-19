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

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for AppointmentWindow.xaml
    /// </summary>
    public partial class AppointmentWindow : Window
    {
        private Action<Appointment> saveCallback;
        public AppointmentWindow(Action<Appointment> saveCallback)
        {
            InitializeComponent();
            this.saveCallback = saveCallback;
            
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Subject = subjectTbx.Text;
            appointment.Date = datePicker.SelectedDate.Value;
            saveCallback(appointment);
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
