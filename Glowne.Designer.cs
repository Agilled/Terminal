namespace WindowsForms_termianal
{
    partial class Glowne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.śmietnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogryzekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ądzeńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytywanieAdresówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scenariuszeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narzędziaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorDALIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.komendyDALIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sekwencjeKomendDALIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dupaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chmuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p2PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.konfiguracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPIPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chmuraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.p2PToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Połącz = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odebrane";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(852, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 19);
            this.button3.TabIndex = 5;
            this.button3.Text = "Wyślij";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(890, 67);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(41, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "CR";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(946, 67);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(38, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "LF";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(208, 405);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(812, 141);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(852, 88);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.UseWaitCursor = true;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(286, 382);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 19);
            this.button5.TabIndex = 21;
            this.button5.Text = "Wyczyść";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(386, 382);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(50, 17);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.Text = "echo";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(921, 151);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 28);
            this.button7.TabIndex = 35;
            this.button7.Text = "programowanie";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(852, 151);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 28);
            this.button8.TabIndex = 36;
            this.button8.Text = "Praca";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 33);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(172, 513);
            this.treeView1.TabIndex = 37;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.Root);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TreeView1_MouseClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(192, 352);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 38;
            this.button9.Text = "Add Nodes";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(890, 33);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 20);
            this.textBox5.TabIndex = 39;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.śmietnikToolStripMenuItem,
            this.narzędziaToolStripMenuItem,
            this.dupaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // śmietnikToolStripMenuItem
            // 
            this.śmietnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogryzekToolStripMenuItem,
            this.ądzeńToolStripMenuItem,
            this.wczytywanieAdresówToolStripMenuItem,
            this.grupowanieToolStripMenuItem,
            this.scenariuszeToolStripMenuItem});
            this.śmietnikToolStripMenuItem.Name = "śmietnikToolStripMenuItem";
            this.śmietnikToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.śmietnikToolStripMenuItem.Text = "Uruchomienie";
            this.śmietnikToolStripMenuItem.Click += new System.EventHandler(this.śmietnikToolStripMenuItem_Click);
            // 
            // ogryzekToolStripMenuItem
            // 
            this.ogryzekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robakToolStripMenuItem,
            this.minMaxToolStripMenuItem});
            this.ogryzekToolStripMenuItem.Name = "ogryzekToolStripMenuItem";
            this.ogryzekToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ogryzekToolStripMenuItem.Text = "Test instalacji";
            // 
            // robakToolStripMenuItem
            // 
            this.robakToolStripMenuItem.Name = "robakToolStripMenuItem";
            this.robakToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.robakToolStripMenuItem.Text = "min max off";
            this.robakToolStripMenuItem.Click += new System.EventHandler(this.robakToolStripMenuItem_Click);
            // 
            // minMaxToolStripMenuItem
            // 
            this.minMaxToolStripMenuItem.Name = "minMaxToolStripMenuItem";
            this.minMaxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minMaxToolStripMenuItem.Text = "min max";
            // 
            // ądzeńToolStripMenuItem
            // 
            this.ądzeńToolStripMenuItem.Name = "ądzeńToolStripMenuItem";
            this.ądzeńToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ądzeńToolStripMenuItem.Text = "Adresowanie urządzeń";
            // 
            // wczytywanieAdresówToolStripMenuItem
            // 
            this.wczytywanieAdresówToolStripMenuItem.Name = "wczytywanieAdresówToolStripMenuItem";
            this.wczytywanieAdresówToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.wczytywanieAdresówToolStripMenuItem.Text = "Wczytywanie Adresów";
            // 
            // grupowanieToolStripMenuItem
            // 
            this.grupowanieToolStripMenuItem.Name = "grupowanieToolStripMenuItem";
            this.grupowanieToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.grupowanieToolStripMenuItem.Text = "Grupowanie";
            // 
            // scenariuszeToolStripMenuItem
            // 
            this.scenariuszeToolStripMenuItem.Name = "scenariuszeToolStripMenuItem";
            this.scenariuszeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.scenariuszeToolStripMenuItem.Text = "Scenariusze";
            // 
            // narzędziaToolStripMenuItem
            // 
            this.narzędziaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monitorDALIToolStripMenuItem,
            this.komendyDALIToolStripMenuItem,
            this.sekwencjeKomendDALIToolStripMenuItem});
            this.narzędziaToolStripMenuItem.Name = "narzędziaToolStripMenuItem";
            this.narzędziaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narzędziaToolStripMenuItem.Text = "Narzędzia";
            // 
            // monitorDALIToolStripMenuItem
            // 
            this.monitorDALIToolStripMenuItem.Name = "monitorDALIToolStripMenuItem";
            this.monitorDALIToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.monitorDALIToolStripMenuItem.Text = "Monitor DALI";
            this.monitorDALIToolStripMenuItem.Click += new System.EventHandler(this.monitorDALIToolStripMenuItem_Click);
            // 
            // komendyDALIToolStripMenuItem
            // 
            this.komendyDALIToolStripMenuItem.Name = "komendyDALIToolStripMenuItem";
            this.komendyDALIToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.komendyDALIToolStripMenuItem.Text = "Komendy DALI";
            this.komendyDALIToolStripMenuItem.Click += new System.EventHandler(this.komendyDALIToolStripMenuItem_Click);
            // 
            // sekwencjeKomendDALIToolStripMenuItem
            // 
            this.sekwencjeKomendDALIToolStripMenuItem.Name = "sekwencjeKomendDALIToolStripMenuItem";
            this.sekwencjeKomendDALIToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.sekwencjeKomendDALIToolStripMenuItem.Text = "Sekwencje komend DALI";
            // 
            // dupaToolStripMenuItem1
            // 
            this.dupaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialToolStripMenuItem1,
            this.tCPIPToolStripMenuItem,
            this.chmuraToolStripMenuItem,
            this.p2PToolStripMenuItem,
            this.toolStripSeparator1,
            this.konfiguracjaToolStripMenuItem});
            this.dupaToolStripMenuItem1.Name = "dupaToolStripMenuItem1";
            this.dupaToolStripMenuItem1.Size = new System.Drawing.Size(75, 20);
            this.dupaToolStripMenuItem1.Text = "Połączenie";
            this.dupaToolStripMenuItem1.Click += new System.EventHandler(this.PolaczenieToolStripMenuItem1_Click);
            // 
            // serialToolStripMenuItem1
            // 
            this.serialToolStripMenuItem1.Name = "serialToolStripMenuItem1";
            this.serialToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.serialToolStripMenuItem1.Text = "Serial";
            this.serialToolStripMenuItem1.Click += new System.EventHandler(this.SerialToolStripMenuItem1_Click);
            // 
            // tCPIPToolStripMenuItem
            // 
            this.tCPIPToolStripMenuItem.Name = "tCPIPToolStripMenuItem";
            this.tCPIPToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.tCPIPToolStripMenuItem.Text = "TCP/IP";
            this.tCPIPToolStripMenuItem.Click += new System.EventHandler(this.tCPIPToolStripMenuItem_Click);
            // 
            // chmuraToolStripMenuItem
            // 
            this.chmuraToolStripMenuItem.Name = "chmuraToolStripMenuItem";
            this.chmuraToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.chmuraToolStripMenuItem.Text = "Chmura";
            this.chmuraToolStripMenuItem.Click += new System.EventHandler(this.chmuraToolStripMenuItem_Click);
            // 
            // p2PToolStripMenuItem
            // 
            this.p2PToolStripMenuItem.Name = "p2PToolStripMenuItem";
            this.p2PToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.p2PToolStripMenuItem.Text = "P2P";
            this.p2PToolStripMenuItem.Click += new System.EventHandler(this.p2PToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // konfiguracjaToolStripMenuItem
            // 
            this.konfiguracjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialToolStripMenuItem,
            this.tCPIPToolStripMenuItem1,
            this.chmuraToolStripMenuItem1,
            this.p2PToolStripMenuItem1});
            this.konfiguracjaToolStripMenuItem.Name = "konfiguracjaToolStripMenuItem";
            this.konfiguracjaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.konfiguracjaToolStripMenuItem.Text = "Konfiguracja interfejsu";
            // 
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.serialToolStripMenuItem.Text = "Serial";
            this.serialToolStripMenuItem.Click += new System.EventHandler(this.serialToolStripMenuItem_Click);
            // 
            // tCPIPToolStripMenuItem1
            // 
            this.tCPIPToolStripMenuItem1.Name = "tCPIPToolStripMenuItem1";
            this.tCPIPToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.tCPIPToolStripMenuItem1.Text = "TCPIP";
            this.tCPIPToolStripMenuItem1.Click += new System.EventHandler(this.tCPIPToolStripMenuItem1_Click);
            // 
            // chmuraToolStripMenuItem1
            // 
            this.chmuraToolStripMenuItem1.Name = "chmuraToolStripMenuItem1";
            this.chmuraToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.chmuraToolStripMenuItem1.Text = "Chmura";
            // 
            // p2PToolStripMenuItem1
            // 
            this.p2PToolStripMenuItem1.Name = "p2PToolStripMenuItem1";
            this.p2PToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.p2PToolStripMenuItem1.Text = "P2P";
            // 
            // Połącz
            // 
            this.Połącz.Location = new System.Drawing.Point(219, 177);
            this.Połącz.Name = "Połącz";
            this.Połącz.Size = new System.Drawing.Size(75, 23);
            this.Połącz.TabIndex = 45;
            this.Połącz.Text = "Połącz";
            this.Połącz.UseVisualStyleBackColor = true;
            this.Połącz.Click += new System.EventHandler(this.Połącz_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox3.Location = new System.Drawing.Point(242, 31);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(62, 21);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.Text = "DataBits";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bity danych:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "1440",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.comboBox1.Location = new System.Drawing.Point(120, 31);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "BaudRate";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liczba biitów na sekundę:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 30);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Port";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Parzystość";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Zamknij port";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1",
            "1,5",
            "2"});
            this.comboBox6.Location = new System.Drawing.Point(400, 32);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(54, 21);
            this.comboBox6.TabIndex = 18;
            this.comboBox6.Text = "BitsStop";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Parzyste",
            "Nieparzyste",
            "Brak",
            "Znacznik",
            "Spacja"});
            this.comboBox4.Location = new System.Drawing.Point(320, 31);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(62, 21);
            this.comboBox4.TabIndex = 15;
            this.comboBox4.Text = "Parity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sterowanie Przepływem:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Bity stopu:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Xon/Xoff",
            "Sprzętowe",
            "Brak"});
            this.comboBox5.Location = new System.Drawing.Point(472, 32);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(92, 21);
            this.comboBox5.TabIndex = 17;
            this.comboBox5.Text = "ControlFlow";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Otwórz port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Location = new System.Drawing.Point(189, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(630, 121);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "konfiguracja portu com";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(202, 68);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(399, 37);
            this.button4.TabIndex = 20;
            this.button4.Text = "Wykryj porty";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Glowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 564);
            this.Controls.Add(this.Połącz);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Glowne";
            this.Text = "Command Administrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dupaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem śmietnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogryzekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCPIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p2PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chmuraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem konfiguracjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCPIPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chmuraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem p2PToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ądzeńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytywanieAdresówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupowanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scenariuszeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narzędziaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorDALIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem komendyDALIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sekwencjeKomendDALIToolStripMenuItem;
        private System.Windows.Forms.Button Połącz;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
    }
}

