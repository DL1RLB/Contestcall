using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Contestcalls
    {
    public partial class Form1 :Form
        {
        int Sekunden; // Zahl
        int Anzahl = 0;
        private OleDbConnection con; // als lokale Variable anlegen
        private OleDbCommand sqlCommand; // zum reden mit der Datenbank
        public Form1()
            {
            InitializeComponent();

            this.Icon = Properties.Resources.Yaesu_FT920;

            TabControl.SelectedTab = TabPage2; // zum zweiten Tab wechseln beim Start
            int index = ComboBox1Tabellenblatt.FindString(ComboBox1Tabellenblatt.Text); // Tabellenblatt 145MHz oder 433HMZ usw.
            ComboBox1Tabellenblatt.SelectedIndex = index; //übernimmt den Indes welche Tabellenblatt man ausgewählt hat
            
            //listView1.Columns[0].Width =  listView1.Width - 1;
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Label11.Text = "Produktname: " + Application.ProductName + " Vers. " + Application.ProductVersion + " " + Application.CompanyName; // Form Überschrift Version
            
            }
        public void BtnLesen_Click(object sender, EventArgs e) // Button Start
            {
            // Callsliste
            ListView1Calls.Font = new Font(new FontFamily("Arial"), Convert.ToSingle(NumericUpDown1SchriftgrößeListView.Value), FontStyle.Regular);
            ListView1Calls.Columns[0].Width = ListView1Calls.Width - 1;
            ListView1Calls.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            
            // Loacatorliste
            ListView1Locator.Font = new Font(new FontFamily("Arial"), Convert.ToSingle(NumericUpDown1SchriftgrößeListView.Value), FontStyle.Regular);
            ListView1Locator.Columns[0].Width = ListView1Locator.Width -1;
            ListView1Locator.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //TabControl.SelectedTab = tabPage1; // zum ersten Tab wechseln

            

            #region Calls lesen
            // Call
            try
            {
                String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=" + TbMDBpfad.Text + ";";
                con = new OleDbConnection(connect);
                con.Open();
                sqlCommand = con.CreateCommand(); // auf die datenbank zugreifen
                sqlCommand.CommandText = "select Rufzeichen,[Locator],Land from " + ComboBox1Tabellenblatt.Text + ";"; // Tabellennamen hier 144MHz
                                                                                                                       //sqlCommand.CommandText = "select * from 144MHz;"; // Tabellennamen hier 144MHz
                OleDbDataReader reader = sqlCommand.ExecuteReader();
                ListView1Calls.Clear(); // tabelle leeren damit nicht doppelte werte drin stehen bleiben
                

                // Listview
                for (int i = 0; i < reader.FieldCount; i++)
                    ListView1Calls.Columns.Add(reader.GetName(i), reader.GetName(i));
                
                    int Anzahl = 0;
                    Anzahl++;
                
                

                while (reader.Read()) // so lange lesen wie daten da sind
                    {
                    
                    ListViewItem item = new ListViewItem(reader["Rufzeichen"].ToString());
                    item.SubItems.Add(reader["Locator"].ToString());
                    item.SubItems.Add(reader["Land"].ToString());
                    ListView1Calls.Items.Add(item);

                    Label14AnzahlCalls.Text = "Anzahl: " + ListView1Calls.Items.Count; // Anzahl Calls
                    
                    //listView1Locator.Items.Add(item);
                    //listView1.Columns[0].Width = listView1.Width - 1;



                }


                // Checkboxen ob Liste oder drei spalten angezeigt werden sollen
                if (RadioButton3AnzeigeDetailliste.Checked)
                    {
                    ListView1Calls.View = View.Details;
                    //listView1Locator.View = View.Details;

                    //listView1.View = View.Details;
                }
                else
                    {
                    ListView1Calls.View = View.List;
                    //listView1Locator.View = View.List;
                }



                // ========= Sortieren ==============
                if (RadioButton1SortierenCalls.Checked) // sortieren nach Calls
                    {
                    ListView1Calls.Sorting = SortOrder.Ascending;
                    //listView1Locator.Sorting = SortOrder.Ascending;
                }
                else
                    {
                    ListView1Calls.Sorting = SortOrder.Descending;
                    //listView1Locator.Sorting = SortOrder.Descending;
                }


                reader.Close(); // wieder schließen
                ListView1Calls.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                //listView1Locator.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                ListView1Calls.GridLines = true;
                //listView1Locator.GridLines = true;
                //tabControl.SelectedTab = tabPage1; // zum ersten Tab wechseln

                


            }
            #region Sicherheitsabfrage
            catch (Exception ex)
                {
                string Exeptionmeldung = ex.Message; // in ex steht die Meldung drin
                string Fehlermeldung = "Fehler beim öffnen der Datenbank!";
                MessageBox.Show(Exeptionmeldung + "\n\nPrüfen sie ob sie die richtige Datei ausgewählt haben.\nVergessen sie nicht die Tabelle auszuwählen.", Fehlermeldung, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Fehler in der Datenbank! \n\n" + ex.Message);
                return;
                #endregion
                }
            #endregion
            #region Locator lesen
            // Locator
            try
            {
                String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=" + TbMDBpfad.Text + ";";
        con = new OleDbConnection(connect);
        con.Open();
                sqlCommand = con.CreateCommand(); // auf die datenbank zugreifen
                sqlCommand.CommandText = "select Rufzeichen,[Locator],Land from " + ComboBox1Tabellenblatt.Text + ";"; // Tabellennamen hier 144MHz
                                                                                                                       //sqlCommand.CommandText = "select * from 144MHz;"; // Tabellennamen hier 144MHz
                OleDbDataReader reader = sqlCommand.ExecuteReader();
                //listView1Calls.Clear(); // tabelle leeren damit nicht doppelte werte drin stehen bleiben
                ListView1Locator.Clear(); // tabelle leeren damit nicht doppelte werte drin stehen bleiben

                // Listview
                for (int i = 0; i<reader.FieldCount; i++)
                    ListView1Locator.Columns.Add(reader.GetName(i), reader.GetName(i));

                //for (int j = 0; j<reader.FieldCount; j++)
                  //  listView1Locator.Columns.Add(reader.GetName(j), reader.GetName(j));
                //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                //listView1.Columns[0].Width = listView1.Width;

                //while (reader.Read()) // so lange lesen wie daten da sind
                while (reader.Read()) // so lange lesen wie daten da sind
                    {

                    ListViewItem item = new ListViewItem(reader["Locator"].ToString());
                    item.SubItems.Add(reader["Rufzeichen"].ToString());
                    item.SubItems.Add(reader["Land"].ToString());
                   // listView1Calls.Items.Add(item);
                    ListView1Locator.Items.Add(item);
                    //listView1.Columns[0].Width = listView1.Width - 1;

                }


                // Checkboxen ob Liste oder drei spalten angezeigt werden sollen
                if (RadioButton3AnzeigeDetailliste.Checked)
                    {
                   // listView1Calls.View = View.Details;
                    ListView1Locator.View = View.Details;

                    //listView1.View = View.Details;
                }
                else
                    {
                   // listView1Calls.View = View.List;
                    ListView1Locator.View = View.List;
                }



                // ========= Sortieren ==============
                if (RadioButton1SortierenCalls.Checked) // sortieren nach Calls
                    {
                  //  listView1Calls.Sorting = SortOrder.Ascending;
                    ListView1Locator.Sorting = SortOrder.Ascending;
                }
                else
                    {
                  //  listView1Calls.Sorting = SortOrder.Descending;
                    ListView1Locator.Sorting = SortOrder.Descending;
                }


                reader.Close(); // wieder schließen
               // listView1Calls.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                ListView1Locator.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
               // listView1Calls.GridLines = true;
                ListView1Locator.GridLines = true;
                //tabControl.SelectedTab = tabPage1; // zum ersten Tab wechseln


                }
            #endregion

            #region Sicherheitsabfrage
            catch (Exception ex)
                {
                string Exeptionmeldung = ex.Message; // in ex steht die Meldung drin
                string Fehlermeldung = "Fehler beim öffnen der Datenbank!";
                MessageBox.Show(Exeptionmeldung + "\n\nPrüfen sie ob sie die richtige Datei ausgewählt haben.\nVergessen sie nicht die Tabelle auszuwählen.", Fehlermeldung, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Fehler in der Datenbank! \n\n" + ex.Message);
                return;
                
                }
            }
        #endregion

            #region Tabellenblatt öffnen
        private void ComboBox1Tabellenblatt_SelectedIndexChanged(object sender, EventArgs e) // Tabellenblatt auswählen
            {
            Object Tabellenblatt = ComboBox1Tabellenblatt.SelectedItem;
            ComboBox1Tabellenblatt.Text = Tabellenblatt.ToString();
            //comboBox1Tabellenblatt.SelectedItem = comboBox1Tabellenblatt.Items.IndexOf(1);
            }
        

        private void BtnOFD_Click(object sender, EventArgs e) // Datei öffnen und in Textbox schreiben
            {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "mdb files (*.mdb)|*.mdb|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            OpenFileDialog openFileDialog1 = openFileDialog;
            DialogResult result = openFileDialog1.ShowDialog();
            String Pfad = openFileDialog1.FileName;
            if (result == DialogResult.OK)
                {
                TbMDBpfad.Text = Path.GetDirectoryName(Pfad) + "\\" + Path.GetFileName(Pfad);
                }
            }
        
        private void Timer1_Tick(object sender, EventArgs e) // Timer 
            {
            string strNumSekunden = String.Format("{0,0:D4}", Sekunden); // Sekundenziffer
            label1Coundwon.Text = "in " + strNumSekunden + " Sek."; // Anzeige der Sekunden
            label8.Text = "in " + strNumSekunden + " Sek."; // Anzeige der Sekunden
            Sekunden--; // Sekunden runterzählen mit Minus
            
            progressBar1.Maximum = Convert.ToInt32(numericUpDown1Sekunden.Value) * 10000;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Value = (Sekunden + 1) * 10000;
            progressBar1.PerformStep();

            if (Sekunden < 0) // wenn Sekunden Kleiner Null ist dann
                {

                if (RbtnCallsLocator.Checked)
                    {
                    BtnLesen_Click(null, null);
                    }
                else
                    {
                    //btnGridViewFuellen_Click(null, null);
                    BtnLesen_Click(null, null);
                    }

                label1Coundwon.Text = "Aktualisierung"; // schreibe Klick
                label8.Text = "Aktualisierung"; // schreibe Klick

                if (numericUpDown1Sekunden.ToString() != "") // und wenn das feld nicht leer ist
                    {
                    
                    //Sekunden = Convert.ToInt32(textBox1Sekunden.Text); // Sekunden in eine Zahl konvertieren
                    Sekunden = Convert.ToInt32(numericUpDown1Sekunden.Value); // Sekunden in eine Zahl konvertieren
                    Sekunden--; // Sekunden runterzählen mit Minus
                    timer1.Start(); // hier den Timer neu starten weil ja Null ist
                    }
                }
            }
        private void BtnStartTimer_Click(object sender, EventArgs e) // Start Timer Aktualisierung runterzählen
            {

            if (numericUpDown1Sekunden.ToString() != "")
                {
                Sekunden = Convert.ToInt32(numericUpDown1Sekunden.Value);
                string strNumSekunden = String.Format("{0,0:D4}", Sekunden);
                label1Coundwon.Text = "in " + strNumSekunden + " Sek.";
                Sekunden--;
                timer1.Start();
                
                }
            }
        #endregion

            #region Form laden
        private void Form1_Load(object sender, EventArgs e)  // holen gespeicherten Usereingaben
            {
            TbMDBpfad.Text = Properties.Settings.Default.tbMDBpfad; // holen des gespeicherten Wert aus den Textbox
            ComboBox1Tabellenblatt.Text = Properties.Settings.Default.comboBox1Tabellenblatt; // holen des gespeicherten Wert aus den Textbox
            CheckBox1Autostart.Checked = Properties.Settings.Default.checkBox1Autostart; // holen des gespeicherten Wert aus der Checkbox
            RadioButton1SortierenCalls.Checked = Properties.Settings.Default.radioButton1SortierenCalls; // holen des gespeicherten Wert aus der Checkbox
            RadioButton1SortierenLocator.Checked = Properties.Settings.Default.radioButton1SortierenLocator; // holen des gespeicherten Wert aus der Checkbox
                                                                                                             //    radioButton1SortierenLogeintrag.Checked = Properties.Settings.Default.radioButton1SortierenLogeintrag; // holen des gespeicherten Wert aus der Checkbox
            RbtnCallsLocator.Checked = Properties.Settings.Default.rbtnCallsLocator; // holen des gespeicherten Wert aus der Checkbox
            RbtnAlleCalls.Checked = Properties.Settings.Default.rbtnAlleCalls; // holen des gespeicherten Wert aus der Checkbox
            }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) // speichern Usereingaben
            {
            Properties.Settings.Default.tbMDBpfad = TbMDBpfad.Text;  // während des schließens den Inhalt der textbox speichern
            Properties.Settings.Default.comboBox1Tabellenblatt = ComboBox1Tabellenblatt.Text;  // während des schließens den Inhalt der textbox speichern
            Properties.Settings.Default.checkBox1Autostart = CheckBox1Autostart.Checked;  // während des schließens den Inhalt der checkbox speichern
            Properties.Settings.Default.radioButton1SortierenCalls = RadioButton1SortierenCalls.Checked;  // während des schließens den Inhalt der checkbox speichern
            Properties.Settings.Default.radioButton1SortierenLocator = RadioButton1SortierenLocator.Checked;  // während des schließens den Inhalt der checkbox speichern
                                                                                                              //      Properties.Settings.Default.radioButton1SortierenLogeintrag = radioButton1SortierenLogeintrag.Checked;  // während des schließens den Inhalt der checkbox speichern
            Properties.Settings.Default.rbtnCallsLocator = RbtnCallsLocator.Checked;  // während des schließens den Inhalt der checkbox speichern
            Properties.Settings.Default.rbtnAlleCalls = RbtnAlleCalls.Checked;  // während des schließens den Inhalt der checkbox speichern

            // und zu guter letzt alles Speichern !!!
            Properties.Settings.Default.Save(); // speichern aller Defaultwerte beim schließen des Programms
            }
        #endregion

        #region Buttons
        private void BtnAktualisierenStop_Click(object sender, EventArgs e) // Button Aktualisierung auf dem Startfenster
            {
            if (btnAktualisierenStop.Text == "Stop")
                {
                timer1.Stop();
                btnAktualisierenStop.Text = "Start";
                }
            else
                {
                timer1.Start();
                btnAktualisierenStop.Text = "Stop";
                }

            }
        private void DateiToolStripMenuItemDatei_Click(object sender, EventArgs e) // wechselt zum EinstellungsTAB
            {
            TabControl.SelectedTab = TabPage2;
            }
        private void StartToolStripMenuItemStart_Click(object sender, EventArgs e)
            {
            BtnStartTimer_Click(sender, e);
            } // Startet den Timer        
        private void StopToolStripMenuItemStop_Click(object sender, EventArgs e) // Stopt den Timer und ändert den Text
            {
            label8.Text = "keine Aktualisierung! ";
            timer1.Stop();
            }
        private void SortierungToolStripMenuItemSortierung_Click(object sender, EventArgs e) // Sortierung
            {
            if (ListView1Calls.Sorting == SortOrder.Ascending)
                {
                ListView1Calls.Sorting = SortOrder.Descending;
                ListView1Calls.View = View.List;
                ListView1Locator.Sorting = SortOrder.Descending;
                ListView1Locator.View = View.List;

                SortierungToolStripMenuItemSortierung.Text = "Absteigend";
                SortierungToolStripMenuItemSortierung.Image = Properties.Resources.arrow_down;

                }
            else
                {
                SortierungToolStripMenuItemSortierung.Image = Properties.Resources.arrow_up;
                ListView1Calls.Sorting = SortOrder.Ascending;
                ListView1Calls.View = View.List;
                ListView1Locator.Sorting = SortOrder.Ascending;
                ListView1Locator.View = View.List;
                SortierungToolStripMenuItemSortierung.Text = "Aufsteigend";
                }

            }
        #endregion

        // leere Objekte
        #region Leer
        private void TbCalls_TextChanged(object sender, EventArgs e)
            {

            }
        private void TbMDBpfad_TextChanged(object sender, EventArgs e)
            {

            }
        private void Label6_Click(object sender, EventArgs e)
            {

            }
        private void TextBox1_TextChanged(object sender, EventArgs e)
            {

            }
        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
            {

            }
        private void TextBox1Sekunden_TextChanged(object sender, EventArgs e)
            {

            }
        private void BtnStopTimer_Click(object sender, EventArgs e)
            {
            timer1.Stop();
            }
        private void Label1Coundwon_Click(object sender, EventArgs e)
            {

            }
        private void CheckBox1Autostart_CheckedChanged(object sender, EventArgs e)
            {

            }
        private void Label8_Click(object sender, EventArgs e)
            {

            }
        private void RbtnCallsLocator_CheckedChanged(object sender, EventArgs e)
            {

            }
        private void RbtnAlleCalls_CheckedChanged(object sender, EventArgs e)
            {

            }
        private void NumericUpDown1Sekunden_ValueChanged(object sender, EventArgs e)
            {

            }
        private void RadioButton1SortierenLogeintrag_CheckedChanged(object sender, EventArgs e)
            {

            }
        private void RadioButton1SortierenLocator_CheckedChanged(object sender, EventArgs e)
            {

            }
        private void RadioButton1SortierenCalls_CheckedChanged(object sender, EventArgs e)
            {

            }
        private void Label11_Click(object sender, EventArgs e)
            {

            }
        private void ListView1Calls_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        private void ProgressBar1_Click(object sender, EventArgs e)
            {

            }
        private void Label13_Click(object sender, EventArgs e)
            {

            }
        private void NumericUpDown1SchriftgrößeListView_ValueChanged(object sender, EventArgs e)
            {

            }
        
        private void ListView1Locator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
    }
