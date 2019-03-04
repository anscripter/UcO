using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcO
{
    public partial class Combolist_v1 : Telerik.WinControls.UI.RadForm
    {
        public Combolist_v1()
        {
            InitializeComponent();
        }

        string[] accs = null;

        private void convert_Click(object sender, EventArgs e)
        {
            st:
            if (accs != null)
            {
                try
                {
                    new Convert(accs).ShowDialog();
                }
                catch (Exception ex)
                {
                    var mes = MessageBox.Show(ex.Message, "UcO Discovered an error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (mes == DialogResult.Retry)
                    {
                        goto st;
                    }
                }
            }
            else
            {
                MessageBox.Show("No combolist detected.", "UcO");
            }
        }

        private void save_Click(object sender, EventArgs e)
        { 
            if (accs != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "UcO|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, string.Join("\r\n", accs));
                }
            }
            else
            {
                MessageBox.Show("No combolist detected.", "UcO");
            }
        }

        private void nulled_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                FileName = "cmd",
                Arguments = "/C start https://www.nulled.to/!2189148",
                WindowStyle = ProcessWindowStyle.Hidden
            };
            p.Start();
        }

        private void shuffle_Click(object sender, EventArgs e)
        {
            if (accs != null)
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                Task.Run(() =>
                {
                    DisableAll();
                    shuffle.Text = "Shuffling...";
                    Randomize(accs);
                    shuffle.Text = "Shuffed!";
                    EnableAll();
                });
            }
            else
            {
                MessageBox.Show("No combolist detected.", "UcO");
            }
        }

        Random ran = new Random();
        private void Randomize<T>(T[] items)
        {
            for (int i = 0; i < items.Length - 1; i++)
            {
                int j = ran.Next(i, items.Length);
                T temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }

        private void EnableAll()
        {
            browse.Enabled = true;
            shuffle.Enabled = true;
            convert.Enabled = true;
            save.Enabled = true;
        }

        private void DisableAll()
        {
            browse.Enabled = false;
            shuffle.Enabled = false;
            convert.Enabled = false;
            save.Enabled = false;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            DisableAll();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "UcO|*.txt";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Task.Run(() =>
                {
                    string[] parsed = File.ReadAllLines(ofd.FileName).Where(a => a.Contains(":")).ToArray();
                    browse.Text = "Scanning...";
                    location.Text = ofd.FileName;
                    accs = parsed;
                    browse.Text = "Success!";
                    scanned.Text = "Accounts Scanned: " + parsed.Count();
                    EnableAll();
                });
            }
            else
            {
                EnableAll();
            }
        }
    }
}
