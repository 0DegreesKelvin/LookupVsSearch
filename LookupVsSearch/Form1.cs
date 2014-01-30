using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LookupVsSearch
{
    using System.Diagnostics;
    using System.IO;

    public partial class MainForm : Form
    {
        private enum SearchMethod
        {
            /// <summary>
            /// for-each
            /// </summary>
            Method_1,

            /// <summary>
            /// linq
            /// </summary>
            Method_2,

            /// <summary>
            /// lookup
            /// </summary>
            Method_3
        }

        private const int NUMBER_OF_EXECUTIONS = 100;

        private Boolean fileAlreadyLoaded = false;

        private string filename;

        private IList<Person> personList = new List<Person>();

        private IDictionary<string, IList<Person>> firstNamesLookup = new Dictionary<string, IList<Person>>(); 

        public MainForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                this.dataFilePathTextBox.Text = openFileDialog1.FileName;
            }
        }

        // read through the file so that it is cached by the file system
        // and timings don't actually include first file-read time
        private void PreLoadFile()
        {
            string newFileName = this.dataFilePathTextBox.Text;

            if (this.filename != newFileName)
            {
                fileAlreadyLoaded = false;
            }

            if (!fileAlreadyLoaded)
            {
                if (!File.Exists(newFileName))
                {
                    MessageBox.Show(
                        "Unable to read the data file!",
                        "Error reading file",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    this.filename = newFileName;

                    var reader = new StreamReader(File.OpenRead(filename));
                    
                    // do nothing, we are simply caching the file in the OS file cache
                    reader.ReadToEnd();
              
                    reader.Close();

                    fileAlreadyLoaded = true;
                }
            }
        }

        private void loadData1Button_Click(object sender, EventArgs e)
        {
            this.ClearLog();

            // make sure that we aren't including file read times in the timings
            PreLoadFile();

            if (fileAlreadyLoaded)
            {
                // read the file into a data structure
                personList.Clear();

                List<string> logLines = new List<string>(this.searchLogTextBox.Lines);

                Stopwatch sw = new Stopwatch();
                sw.Start();

                var reader = new StreamReader(File.OpenRead(this.filename));

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Person p = new Person(values[0], values[1]);

                    this.personList.Add(p);
                }

                reader.Close();

                sw.Stop();

                this.AppendToLog(string.Format("LoadData_1 : Read data file in {0} ticks", sw.ElapsedTicks));

                SetSearchButtonsEnabled(SearchMethod.Method_1);
            }
        }

        private void SetSearchButtonsEnabled(SearchMethod method)
        {
            this.searchData1Button.Enabled = SearchMethod.Method_1 == method;
            this.searchData2Button.Enabled = SearchMethod.Method_2 == method;
            this.searchData3Button.Enabled = SearchMethod.Method_3 == method;
        }

        private void ClearLog()
        {
            this.searchLogTextBox.Lines = new string[0];
        }

        private void AppendToLog(string message)
        {
            IList<string> logLines = new List<string>(this.searchLogTextBox.Lines);

            logLines.Add(message);

            this.searchLogTextBox.Lines = logLines.ToArray();
        }

        private void loadData2Button_Click(object sender, EventArgs e)
        {
            this.ClearLog();

            // make sure that we aren't including file read times in the timings
            PreLoadFile();

            if (this.fileAlreadyLoaded)
            {
                // read the file into a data structure
                personList.Clear();

                List<string> logLines = new List<string>(this.searchLogTextBox.Lines);

                Stopwatch sw = new Stopwatch();
                sw.Start();

                var reader = new StreamReader(File.OpenRead(this.filename));

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Person p = new Person(values[0], values[1]);

                    this.personList.Add(p);
                }

                reader.Close();

                sw.Stop();

                this.AppendToLog(string.Format("LoadData_2 : Read data file in {0} ticks", sw.ElapsedTicks));

                SetSearchButtonsEnabled(SearchMethod.Method_2);
            }
        }

        private void loadData3Button_Click(object sender, EventArgs e)
        {
            this.ClearLog();

            // make sure that we aren't including file read times in the timings
            PreLoadFile();

            if (this.fileAlreadyLoaded)
            {
                // read the file into a data structure
                personList.Clear();

                List<string> logLines = new List<string>(this.searchLogTextBox.Lines);

                Stopwatch sw = new Stopwatch();
                sw.Start();

                var reader = new StreamReader(File.OpenRead(this.filename));

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Person p = new Person(values[0], values[1]);

                    // add the first name to a lookup list
                    if (!firstNamesLookup.ContainsKey(p.Firstname))
                    {
                        IList<Person> newList = new List<Person>();
                        newList.Add(p);

                        firstNamesLookup.Add(p.Firstname, newList);
                    }
                    else
                    {
                        firstNamesLookup[p.Firstname].Add(p);
                    }

                    this.personList.Add(p);
                }

                reader.Close();

                sw.Stop();

                this.AppendToLog(string.Format("LoadData_3 : Read data file in {0} ticks", sw.ElapsedTicks));

                SetSearchButtonsEnabled(SearchMethod.Method_3);
            }
        }

        private IList<Person> Search_1(string searchTerm)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            IList<Person> results = new List<Person>();

            foreach (var person in personList)
            {
                if (person.Firstname.Equals(searchTerm))
                {
                    results.Add(person);
                }
            }

            sw.Stop();

            // display a readable message that makes sense, then put the number of results and the time to conduct the search as comma
            // separated values so that the results can be pasted into a spreadsheet and easily analysed.
            this.AppendToLog(string.Format("Search method 1 (for-each) found {0} matches in {1} ticks, {0}, {1}", results.Count, sw.ElapsedTicks));

            return results;
        }

        private IList<Person> Search_2(string searchTerm)
        {
            

            IList<Person> results = new List<Person>();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            results = this.personList.Where(p => p.Firstname == searchTerm).ToList();

            sw.Stop();

            // display a readable message that makes sense, then put the number of results and the time to conduct the search as comma
            // separated values so that the results can be pasted into a spreadsheet and easily analysed.
            this.AppendToLog(string.Format("Search method 2 (linq) found {0} matches in {1} ticks, {0}, {1}", results.Count, sw.ElapsedTicks));

            return results;
        }

        private IList<Person> Search_3(string searchTerm)
        {
           

            IList<Person> results = new List<Person>();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (firstNamesLookup.ContainsKey(searchTerm))
            {
                results = firstNamesLookup[searchTerm];
            }

            sw.Stop();

            // display a readable message that makes sense, then put the number of results and the time to conduct the search as comma
            // separated values so that the results can be pasted into a spreadsheet and easily analysed.
            this.AppendToLog(string.Format("Search method 3 (lookup),  found {0} matches in {1} ticks, {0}, {1}", results.Count, sw.ElapsedTicks));

            return results;
        }

        private void searchData1Button_Click(object sender, EventArgs e)
        {
            string searchTerm = this.searchTermTextBox.Text;

            for (int i = 0; i < NUMBER_OF_EXECUTIONS; i++ )
            {
                this.Search_1(searchTerm);
            }
        }

        private void searchData2Button_Click(object sender, EventArgs e)
        {
            string searchTerm = this.searchTermTextBox.Text;

            for (int i = 0; i < NUMBER_OF_EXECUTIONS; i++)
            {
                this.Search_2(searchTerm);
            }
        }

        private void searchData3Button_Click(object sender, EventArgs e)
        {
            string searchTerm = this.searchTermTextBox.Text;

            for (int i = 0; i < NUMBER_OF_EXECUTIONS; i++)
            {
                this.Search_3(searchTerm);
            }
        }

        private void copyLogToClipboardButton_Click(object sender, EventArgs e)
        {
            this.searchLogTextBox.SelectAll();
            this.searchLogTextBox.Copy();
        }


    }
}
