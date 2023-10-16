using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace _0102
{
    public partial class Form1 : Form
    {
        private int updateIntervalInSeconds = 5;
        private System.Threading.Timer timer;
        private int numberItem = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new System.Threading.Timer(UpdateProcessesList, null, 0, updateIntervalInSeconds * 1000);
        }

        private void UpdateProcessesList(object state)
        {
            numberItem = 0;
            if (listViewProcesses.InvokeRequired)
            {
                listViewProcesses.Invoke(new Action(() => { listViewProcesses.Items.Clear(); }));
            }
            else
            {
                listViewProcesses.Items.Clear();
            }

            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                if (listViewProcesses.InvokeRequired)
                {
                    listViewProcesses.Invoke(new Action(() =>
                    {
                        listViewProcesses.Items.Add(new ListViewItem(new string[] { (numberItem + 1).ToString(), process.ProcessName, process.Id.ToString() }));
                    }));
                    numberItem++;
                }
                else
                {
                    listViewProcesses.Items.Add(new ListViewItem(new string[] { (numberItem + 1).ToString(), process.ProcessName, process.Id.ToString() }));
                    numberItem++;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSetInterval_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInterval.Text, out int interval) && int.Parse(textBoxInterval.Text) > 0)
            {
                updateIntervalInSeconds = interval;
                timer.Change(0, updateIntervalInSeconds * 1000);
            }
            else
            {
                MessageBox.Show("Неправильно введенні дані. Будь ласка введіть коректне число у секундах.");
            }
        }
    }
}