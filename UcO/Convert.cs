using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace UcO
{
    public partial class Convert : Telerik.WinControls.UI.RadForm
    {
        public Convert(string[] data)
        {
            InitializeComponent();
            d = data;
        }

        Random ran = new Random();
        string[] d = null;

        private void radButton1_Click(object sender, EventArgs e)
        {
            List<string> filter = new List<string>(d);
            if (e_to_u.IsChecked)
            {
                List<string> accounts = new List<string>();

                foreach(string acc in filter.ToArray())
                {
                    try
                    {
                        string a = acc.Split('@')[0];
                        string p = acc.Split(':')[1];
                        accounts.Add(a + ":" + p);
                    }
                    catch
                    {

                    }
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "UcO|*.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, string.Join("\r\n", accounts));
                    MessageBox.Show("Success!", "UcO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (u_to_e.IsChecked)
            {
                List<string> accounts = new List<string>();

                foreach (string acc in filter.ToArray())
                {
                    try
                    {
                        string a = acc.Split(':')[0];
                        string p = acc.Split(':')[1];

                        switch (ran.Next(0, 3))
                        {
                            case 0:
                                {
                                    a = a + "@gmail.com";
                                    break;
                                }
                            case 1:
                                {
                                    a = a + "@hotmail.com";
                                    break;
                                }
                            case 2:
                                {
                                    a = a + "@outlook.com";
                                    break;
                                }
                            case 3:
                                {
                                    a = a + "@yahoo.com";
                                    break;
                                }
                        }


                        accounts.Add(a + ":" + p);
                    }
                    catch
                    {

                    }
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "UcO|*.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, string.Join("\r\n", accounts));
                    MessageBox.Show("Success!", "UcO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
