using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.Win32;
using System.Net;
using System.Net.Sockets;


namespace WindowsForms_termianal
{
    public partial class KonfigSerialPort : Form
    {
        public KonfigSerialPort()
        {
            InitializeComponent();
        }

        ~KonfigSerialPort()
        {
            try
            {
                //zamknięciu portu - odłączenie
                serialPort1.Close();

                //wpisanie do "odebrane"
                // richTextBox1.Text += "Rozłączono\n\r";

                //aktywacja i deaktywacja odpowiednich kontrolerk
                comboBox1.Enabled = true;   //lista z portami
                comboBox2.Enabled = true;   //lista z prędkością
                button1.Enabled = true;    //przycisk wyślij
                button2.Enabled = true;     //przycisk połącz
                                            // button3.Enabled = true;    //przycisk rozłącz
                                            // textBox1.Enabled = true;   //edit box dla wyślij
            }
            catch
            {
                //jeżeli wystąpi błąd
                //richTextBox1.Text += "Błąd z rozłączeniem\n\r";
            }

        }

        public string Choice
        { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            //odczytanie dostępnych portów wraz z wpisanie ich do rozwijanej listy
            comboBox2.Items.AddRange(SerialPort.GetPortNames());

            //sortowanie wyswietlanych nazw dostępnych portów
            comboBox2.Sorted = true;   //true oznacza, że zawartość tego komponenty ma być posortowana

            //przypisanie wartosci domyslnych w rozwijanych listach wyboru
            comboBox2.SelectedIndex = 0;   //pierwszy dostępny port
            comboBox1.SelectedIndex = 4;   //prędkość 19200 - jest 6 z kolei - liczymy od 0
            comboBox3.SelectedIndex = 4;   //bity danych
            comboBox4.SelectedIndex = 2;    //parzystość
            comboBox5.SelectedIndex = 2;    //sterowanie przepływem
            comboBox6.SelectedIndex = 0;    //Bity stopu
           // checkBox1.Checked = true;       // LR
           // checkBox2.Checked = true;       // CR



            //aktywacja i deaktywacja odpowiednich kontrolek
            comboBox2.Enabled = true;   //lista z portami
            comboBox1.Enabled = true;   //lista z prędkością
            if (serialPort1.IsOpen == false)
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }//przycisk połącz
            else
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }//przycisk rozłącz
           // button3.Enabled = false;    //przycisk wyślij
          //  textBox1.Enabled = true;   //edit box dla wyślij
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

         public void button1_Click(object sender, EventArgs e)
        {

            Choice = "";

            //zabezpieczenie przed wystąpieniem wyjątku/problemu z otwarciem portu
            try
            {
                //ustawiany jest port, który został wybrany z rozwijanej listy
                serialPort1.PortName = comboBox2.Text;
                //konwersja i ustawienie prędkości transmisji (która została wybrana z rozwijanej listy)
                serialPort1.BaudRate = Convert.ToInt32(comboBox1.Text);

                //otwarcie wybranego portu
                serialPort1.Open();

                //wpisanie do "odebrane"
                Choice = "Połączono dla Port " + serialPort1.PortName + " " + serialPort1.BaudRate.ToString() + "bps \n\r";

                //aktywacja i deaktywacja odpowiednich kontrolerk
                comboBox1.Enabled = false;      //lista z portami
                comboBox2.Enabled = false;      //lista z prędkością
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;

                button1.Enabled = false;         //przycisk połącz
                button2.Enabled = true;        //przycisk rozłącz
                //button3.Enabled = true;         //przycisk wyślij
                //textBox1.Enabled = true;        //edit box dla wyślij
            }
            catch
            {
                //jeżeli wystąpi błąd
                Choice = "Błąd połączenia\n\r";
                //richTextBox1.Text += "Błąd połączenia\n\r";

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            comboBox2.Items.Clear();
            //odczytanie dostępnych portów wraz z wpisanie ich do rozwijanej listy

            comboBox2.Items.AddRange(SerialPort.GetPortNames());
            //sortowanie wyswietlanych nazw dostępnych portów
            comboBox2.Sorted = true;   //true oznacza, że zawartość tego komponenty ma być posortowana

            //aktywacja i deaktywacja odpowiednich kontrolerk
            comboBox1.Enabled = true;   //lista z portami
            comboBox2.Enabled = true;   //lista z prędkością
            button1.Enabled = true;    //przycisk wyślij
            button2.Enabled = false;     //przycisk połącz
            // button3.Enabled = true;    //przycisk rozłącz
            // textBox1.Enabled = true;   //edit box dla wyślij
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //zabezpieczenie przed wystąpieniem wyjątku/problemu z zamknięciem portu
            try
            {
                //zamknięciu portu - odłączenie
                serialPort1.Close();

                //wpisanie do "odebrane"
                Choice = "Rozłączono\n\r";

                //aktywacja i deaktywacja odpowiednich kontrolerk
                comboBox1.Enabled = true;   //lista z portami
                comboBox2.Enabled = true;   //lista z prędkością
                button1.Enabled = true;    //przycisk wyślij
                button2.Enabled = true;     //przycisk połącz
               // button3.Enabled = true;    //przycisk rozłącz
                // textBox1.Enabled = true;   //edit box dla wyślij
            }
            catch
            {
                //jeżeli wystąpi błąd
                //richTextBox1.Text += "Błąd z rozłączeniem\n\r";
            }
        }
    }
}
