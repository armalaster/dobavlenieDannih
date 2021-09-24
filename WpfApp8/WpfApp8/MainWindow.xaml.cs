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

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*Ученики*/
            string KlassNumber = TextBoxDrop.Text;
            if (KlassNumber.Length == -1)
            {
                MessageBox.Show("Необходимо ввести ФИО, Номер телефона, Адрес, Номер класса");
                return;
            }
            int NumKlass2 = int.Parse(KlassNumber);
            db.Ycheniki NumKlass = new db.Ycheniki();
            NumKlass.NumKlass = NumKlass2;
            db.Entities conection = new db.Entities();
            string Fio_Ycheniki = TextBoxFio.Text;
            if (Fio_Ycheniki.Length == 0)
            {
                MessageBox.Show("Необходимо ввести ФИО ученика");
                return;
            }
            NumKlass.Fio_Ychenika = Fio_Ycheniki;
            string NumberPhone = TextBoxNumPhone.Text;
            if (NumberPhone.Length == 0)
            {
                MessageBox.Show("Необходимо ввести ФИО, Номер телефона, Адрес, Номер класса");
                return;
            }
            NumKlass.NumPhone = NumberPhone;
            string idYchenika = IDYchenika.Text;
            if (idYchenika.Length == 0)
            {
                MessageBox.Show("Необходимо ввести код ученика");
                return;
            }
            int idycheniki = int.Parse(idYchenika);
            NumKlass.KodYchenika = idycheniki;
            string Adresych = TextBoxAdres.Text;
            if (Adresych.Length == 0)
            {
                MessageBox.Show("Необходимо ввести адрес ученика");
                return;
            }
            NumKlass.Adres = Adresych;
            conection.Ycheniki.Add(NumKlass);
            int save = conection.SaveChanges();
            if (save > 0)
            {
                IDYchenika.Text = "";
                TextBoxFio.Text = "";
                TextBoxNumPhone.Text = "";
                TextBoxAdres.Text = "";
                TextBoxDrop.Text = "";
                MessageBox.Show("Данные успешно добавлены");
            }
            /*Ученики*/

            /*Преподователи*/
            string Teacher = NumTeacherTexted.Text;
            if (Teacher.Length == -1)
            {
                MessageBox.Show("Необходимо ввести данные");
                return;
            }
            int Teacher2 = int.Parse(Teacher);
            db.Teacher NumTeacher = new db.Teacher();
            NumTeacher.NumTeacher = Teacher2;
            db.Entities conections = new db.Entities();

            string Fio_Teacher = FioTeacherText.Text;
            if (Fio_Teacher.Length == 0)
            {
                MessageBox.Show("Необходимо ввести ФИО преподователя");
                return;
            }
            NumTeacher.Fio = Fio_Teacher;

            string TeacherPhone = PhoneTeacherText.Text;
            if (TeacherPhone.Length == 0)
            {
                MessageBox.Show("Необходимо ввести ФИО, Номер телефона, Адрес, Номер класса");
                return;
            }
            NumTeacher.Phone = TeacherPhone;

            conections.Teacher.Add(NumTeacher);
            int saves = conections.SaveChanges();
            if (saves > 0)
            {
                /*
                IDYchenika.Text = "";
                TextBoxFio.Text = "";
                TextBoxNumPhone.Text = "";
                TextBoxAdres.Text = "";
                TextBoxDrop.Text = "";
                MessageBox.Show("Данные успешно добавлены");
                переделать 

                 */
            }



            /*Преподователи*/





        }


    }
}
