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
    public partial class Glowne : Form
    {

        KonfigSerialPort f = new KonfigSerialPort();


        bool flagConnect = false;

        public Glowne()
        {
            InitializeComponent();
            serialToolStripMenuItem.Checked = false;
            tCPIPToolStripMenuItem.Checked = false;
            chmuraToolStripMenuItem.Checked = false;
            p2PToolStripMenuItem.Checked = false;
        }


        void polonczSerial()
        {
            try
            {
                //ustawiany jest port, który został wybrany z rozwijanej listy
                serialPort1.PortName = comboBox2.Text;
                //konwersja i ustawienie prędkości transmisji (która została wybrana z rozwijanej listy)
                serialPort1.BaudRate = Convert.ToInt32(comboBox1.Text);

                //otwarcie wybranego portu
                serialPort1.Open();

                //wpisanie do "odebrane"
                richTextBox1.Text += "Połączono dla Port " + serialPort1.PortName + " " + serialPort1.BaudRate.ToString() + "bps \n\r";
                /*
                //aktywacja i deaktywacja odpowiednich kontrolerk
                comboBox1.Enabled = false;      //lista z portami
                comboBox2.Enabled = false;      //lista z prędkością
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;

                //button1.Enabled = false;         //przycisk połącz
               // button2.Enabled = true;        //przycisk rozłącz
                                               //button3.Enabled = true;         //przycisk wyślij
                                               //textBox1.Enabled = true;        //edit box dla wyślij
                */
            }
            catch
            {
                //jeżeli wystąpi błąd
                richTextBox1.Text += "Błąd połączenia\n\r";
                //richTextBox1.Text += "Błąd połączenia\n\r";

            }
        }

        void rozlaczSerial()
        {

            //zabezpieczenie przed wystąpieniem wyjątku/problemu z zamknięciem portu
            try
            {

                //zamknięciu portu - odłączenie
                serialPort1.Close();

                //wpisanie do "odebrane"
                richTextBox1.Text += "Rozłączono\n\r";

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
                richTextBox1.Text += "Błąd z rozłączeniem\n\r";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
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
            checkBox1.Checked = true;       // LR
            checkBox2.Checked = true;       // CR

            
            
            //aktywacja i deaktywacja odpowiednich kontrolek
            comboBox2.Enabled = true;   //lista z portami
            comboBox1.Enabled = true;   //lista z prędkością
            button1.Enabled = true;    //przycisk połącz
            button2.Enabled = false;     //przycisk rozłącz
            button3.Enabled = false;    //przycisk wyślij
            textBox1.Enabled = true;   //edit box dla wyślij
        }

        private void Button1_Click(object sender, EventArgs e)
        {
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
                richTextBox1.Text += "Połączono dla Port " + serialPort1.PortName + " " + serialPort1.BaudRate.ToString() + "bps \n\r";

                //aktywacja i deaktywacja odpowiednich kontrolerk
                comboBox1.Enabled = false;      //lista z portami
                comboBox2.Enabled = false;      //lista z prędkością
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;

                button1.Enabled = false;         //przycisk połącz
                button2.Enabled = true;        //przycisk rozłącz
                button3.Enabled = true;         //przycisk wyślij
                textBox1.Enabled = true;        //edit box dla wyślij
            }
            catch
            {
                //jeżeli wystąpi błąd
                richTextBox1.Text += "Błąd połączenia\n\r";
               
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //zabezpieczenie przed wystąpieniem wyjątku/problemu z zamknięciem portu
            try
            {
                //zamknięciu portu - odłączenie
                serialPort1.Close();

                //wpisanie do "odebrane"
                richTextBox1.Text += "Rozłączono\n\r";

                //aktywacja i deaktywacja odpowiednich kontrolerk
                comboBox1.Enabled = true;   //lista z portami
                comboBox2.Enabled = true;   //lista z prędkością
                button1.Enabled = true;    //przycisk wyślij
                button2.Enabled = true;     //przycisk połącz
                button3.Enabled = true;    //przycisk rozłącz
                textBox1.Enabled = true;   //edit box dla wyślij
            }
            catch
            {
                //jeżeli wystąpi błąd
                richTextBox1.Text += "Błąd z rozłączeniem\n\r";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                //wsyłanie danych z kontroli textbox przez port szeregowy
                serialPort1.Write(textBox1.Text.ToString());

                //czy ma wysyłać polecenie powrotu karetki
                if (checkBox2.Checked)
                {
                    //wysłanie polecenia powrotu
                    serialPort1.Write("\r");
                }

                //czy ma wysyłać polecenie nowej lini
                if (checkBox1.Checked)
                {
                    //wysłanie polecenia nowej linii
                    serialPort1.Write("\n");
                }
            }
                

            catch 
            {
                //jeżeli wystąpi błąd
                richTextBox1.Text += "Zamknięty port COM\n\r";
                //MessageBox.Show(blad.Message);
            }
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //sprawdzenie czy komponent gdzie wypisywane są odebrane jest w tym samym wątku co odbiór danych
            if (richTextBox1.InvokeRequired)
            {
                //utworzenie delegata (wskaźnika do mikro funkcji) metody do wpisywania danych w komponencie z bufora odbioru danych
                // () => oznacza lambdę
                Action act = () => richTextBox1.Text += serialPort1.ReadExisting();

                //wykonanie delegata dla wątku głównego
                Invoke(act);   //wywołanie delegata
            }
            else
            {//jeżeli jest w tym samym wątku przepisz normalnie dane z bufora do komponentu
                richTextBox1.Text += serialPort1.ReadExisting();
                
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
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
            button3.Enabled = true;    //przycisk rozłącz
            textBox1.Enabled = true;   //edit box dla wyślij



        }

        private void Button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("$C1PRG");
                //czy ma wysyłać polecenie powrotu karetki
                if (checkBox2.Checked)
                {
                    //wysłanie polecenia powrotu
                    serialPort1.Write("\r");
                }

                //czy ma wysyłać polecenie nowej lini
                if (checkBox1.Checked)
                {
                    //wysłanie polecenia nowej linii
                    serialPort1.Write("\n");
                }

                
            }
            catch(System.InvalidOperationException blad)
            {
                MessageBox.Show(blad.Message);

            }

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("$C1RUN");


                //czy ma wysyłać polecenie powrotu karetki
                if (checkBox2.Checked)
                {
                    //wysłanie polecenia powrotu
                    serialPort1.Write("\r");
                }

                //czy ma wysyłać polecenie nowej lini
                if (checkBox1.Checked)
                {
                    //wysłanie polecenia nowej linii
                    serialPort1.Write("\n");
                }
            }
            catch (System.InvalidOperationException blad)
            {
                MessageBox.Show(blad.Message);

            }



        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void Root(object sender, ItemDragEventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Fizyczne urządzenie1 192.168.1.111");
           
            treeView1.Nodes[0].Nodes.Add("Linia DALI 1");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("oprawy");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("LED_0");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("LED_1");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("LED_2");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("urządzenia");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("KASETA_4P");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("BUTTON_4");
            treeView1.Nodes[0].Nodes[0].Nodes[6].Nodes.Add("INPUT1");
            treeView1.Nodes[0].Nodes[0].Nodes[6].Nodes.Add("INPUT2");
            treeView1.Nodes[0].Nodes[0].Nodes[6].Nodes.Add("INPUT3");
            treeView1.Nodes[0].Nodes[0].Nodes[6].Nodes.Add("INPUT4");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("SENSOR");

            treeView1.Nodes[0].Nodes.Add("Linia DALI 2");
            
            treeView1.Nodes.Add("Fizyczne urządzenie2");
            treeView1.Nodes[1].Nodes.Add("Oprawy");
            treeView1.Nodes[1].Nodes.Add("Urządzenia");

          //  treeView1.Nodes[0].ContextMenuStrip = test;
           // treeView1.Nodes[0].Nodes[0].ContextMenuStrip = test;
           // treeView1.Nodes[0].Nodes[1].ContextMenuStrip = test;
        }

        private void TreeView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PolaczenieToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void SerialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if (flagConnect == false)
            {
                if (!serialToolStripMenuItem1.Checked)
                {
                    serialToolStripMenuItem1.Checked = true;
                    tCPIPToolStripMenuItem.Checked = false;
                    chmuraToolStripMenuItem.Checked = false;
                    p2PToolStripMenuItem.Checked = false;


                }
                else
                {

                    serialToolStripMenuItem1.Checked = false;
                    tCPIPToolStripMenuItem.Checked = false;
                    chmuraToolStripMenuItem.Checked = false;
                    p2PToolStripMenuItem.Checked = false;

                }
            }
        }


        private void serialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            f.ShowDialog();

            if (f.Choice != "") richTextBox1.Text += f.Choice;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void śmietnikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tCPIPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KonfigTCPIP a = new KonfigTCPIP();
            a.ShowDialog();
            
        }

        private void monitorDALIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonitorDALI a = new MonitorDALI();
            a.ShowDialog();
        }

        private void komendyDALIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KomDALI a = new KomDALI();
            a.ShowDialog();
        }

        private void tCPIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flagConnect == false)
            {
                serialToolStripMenuItem1.Checked = false;
                tCPIPToolStripMenuItem.Checked = true;
                chmuraToolStripMenuItem.Checked = false;
                p2PToolStripMenuItem.Checked = false;
            }
        }

        private void chmuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flagConnect == false)
            {
                serialToolStripMenuItem1.Checked = false;
                tCPIPToolStripMenuItem.Checked = false;
                chmuraToolStripMenuItem.Checked = true;
                p2PToolStripMenuItem.Checked = false;
            }
        }

        private void p2PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flagConnect == false)
            {
                serialToolStripMenuItem1.Checked = false;
                tCPIPToolStripMenuItem.Checked = false;
                chmuraToolStripMenuItem.Checked = false;
                p2PToolStripMenuItem.Checked = true;
            }
        }

        private void Połącz_Click(object sender, EventArgs e)
        {
            if (serialToolStripMenuItem1.Checked == true && flagConnect == false)
            {
                flagConnect = true;
                polonczSerial();
                Połącz.Text = "Rozłącz";
            }
            else if (serialToolStripMenuItem1.Checked == true && flagConnect == true)
            {
                flagConnect = false;
                rozlaczSerial();
                Połącz.Text = "Połącz";
            }
        }

        private void button10_tets_Click(object sender, EventArgs e)
        {

        }

        private void robakToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
