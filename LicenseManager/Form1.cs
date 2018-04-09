using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
//using System.Management.Instrumentation;
using System.Net.NetworkInformation;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace LicenseManager
{
    public partial class Form1 : Form
    {
        public static string password = "PANJA123";
        public static string version = "ACCMNGR1_1_1.1_1";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(1);
            dateTimePicker1.Value = DateTime.Today.AddDays(30);
            numupdwn_no_of_mac.Value = 1;
        }

        public void EncryptFile(string inputString, string outputFile, string password)
        {

            try
            {
                //string password = @"myKey123"; // Your Key Here
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                int data = 0;
                int strlen = inputString.Length;
                while (data < strlen)
                {
                    cs.WriteByte((byte)inputString[data]);
                    data = data + 1;
                }

                cs.Close();
                fsCrypt.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Encryption failed!" + exp.Message, "Error");
                //this.print_log("Encryption failed!" + exp.Message);
            }
        }

        /// Decrypts a file using Rijndael algorithm.
        public String DecryptFile(string inputFile, string password)
        {
            try
            {
                //string password = @"myKey123"; // Your Key Here
                string decrypted_text;
                var builder = new StringBuilder();
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    builder.Append((char)data);
                decrypted_text = builder.ToString();
                cs.Close();
                fsCrypt.Close();
                return (decrypted_text);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Decryption failed!" + exp.Message, "Error");
                //this.print_log("Decryption failed!" + exp.Message);
                return ("FAILURE");
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime datetimelocal = dateTimePicker1.Value;
            txtbx_lic_exp_date.Text = "YEAR:" + datetimelocal.Year.ToString() + "    MONTH:" + datetimelocal.Month.ToString() + "    DAY:" + datetimelocal.Day.ToString() + ""; 
        }
        private void bt_test_Click(object sender, EventArgs e)
        {
            /*
            string macAddresses = string.Empty;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if ((!nic.Description.Contains("Virtual") && !nic.Description.Contains("Pseudo")))
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        macAddresses += nic.GetPhysicalAddress().ToString() + ";";
                    }
                }
            }

                MessageBox.Show("macAddresses=" + macAddresses);*/
            /*
            EncryptFile("VERSION=ACCMNGR1_1_1.1_1;EXP_YEAR=2013;EXP_MONTH=12;EXP_DAY=31;NO_OF_MAC=1;MAC1=FFFFFFFFFFFF;", "C:\\Documents\\LICENSE_FOR_ALL.DAT", "PANJA123");
            MessageBox.Show("LICENSE FILE CREATED AT PATH = " + "C:\\Documents\\LICENSE_FOR_ALL.DAT");
              */
            
            
        }

        private void change_numupdwn_visiblity(Int16 no_of_mac)
        {
            /* change visibility of the textboxes */
        }

        private void numupdwn_no_of_mac_ValueChanged(object sender, EventArgs e)
        {
            Int16 no_of_mac = Convert.ToInt16(numupdwn_no_of_mac.Value);
            lbl_mac_addr_1.Visible = false;
            txtbx_mac_1_1.Visible = false;
            txtbx_mac_1_2.Visible = false;
            txtbx_mac_1_3.Visible = false;
            txtbx_mac_1_4.Visible = false;
            txtbx_mac_1_5.Visible = false;
            txtbx_mac_1_6.Visible = false;
            lbl_mac_addr_2.Visible = false;
            txtbx_mac_2_1.Visible = false;
            txtbx_mac_2_2.Visible = false;
            txtbx_mac_2_3.Visible = false;
            txtbx_mac_2_4.Visible = false;
            txtbx_mac_2_5.Visible = false;
            txtbx_mac_2_6.Visible = false;
            lbl_mac_addr_3.Visible = false;
            txtbx_mac_3_1.Visible = false;
            txtbx_mac_3_2.Visible = false;
            txtbx_mac_3_3.Visible = false;
            txtbx_mac_3_4.Visible = false;
            txtbx_mac_3_5.Visible = false;
            txtbx_mac_3_6.Visible = false;
            lbl_mac_addr_4.Visible = false;
            txtbx_mac_4_1.Visible = false;
            txtbx_mac_4_2.Visible = false;
            txtbx_mac_4_3.Visible = false;
            txtbx_mac_4_4.Visible = false;
            txtbx_mac_4_5.Visible = false;
            txtbx_mac_4_6.Visible = false;
            lbl_mac_addr_5.Visible = false;
            txtbx_mac_5_1.Visible = false;
            txtbx_mac_5_2.Visible = false;
            txtbx_mac_5_3.Visible = false;
            txtbx_mac_5_4.Visible = false;
            txtbx_mac_5_5.Visible = false;
            txtbx_mac_5_6.Visible = false;
            if (no_of_mac > 0)
            {
                //First Mac Addr
                lbl_mac_addr_1.Visible = true;
                txtbx_mac_1_1.Visible = true;
                txtbx_mac_1_2.Visible = true;
                txtbx_mac_1_3.Visible = true;
                txtbx_mac_1_4.Visible = true;
                txtbx_mac_1_5.Visible = true;
                txtbx_mac_1_6.Visible = true;
            }
            if (no_of_mac > 1)
            {
                //Second Mac Addr
                lbl_mac_addr_2.Visible = true;
                txtbx_mac_2_1.Visible = true;
                txtbx_mac_2_2.Visible = true;
                txtbx_mac_2_3.Visible = true;
                txtbx_mac_2_4.Visible = true;
                txtbx_mac_2_5.Visible = true;
                txtbx_mac_2_6.Visible = true;
            }
            if (no_of_mac > 2)
            {
                //Third Mac Addr
                lbl_mac_addr_3.Visible = true;
                txtbx_mac_3_1.Visible = true;
                txtbx_mac_3_2.Visible = true;
                txtbx_mac_3_3.Visible = true;
                txtbx_mac_3_4.Visible = true;
                txtbx_mac_3_5.Visible = true;
                txtbx_mac_3_6.Visible = true;
            }
            if (no_of_mac > 3)
            {
                //Fourth Mac Addr
                lbl_mac_addr_4.Visible = true;
                txtbx_mac_4_1.Visible = true;
                txtbx_mac_4_2.Visible = true;
                txtbx_mac_4_3.Visible = true;
                txtbx_mac_4_4.Visible = true;
                txtbx_mac_4_5.Visible = true;
                txtbx_mac_4_6.Visible = true;
            }
            if (no_of_mac > 4)
            {
                //Fifth Mac Addr
                lbl_mac_addr_5.Visible = true;
                txtbx_mac_5_1.Visible = true;
                txtbx_mac_5_2.Visible = true;
                txtbx_mac_5_3.Visible = true;
                txtbx_mac_5_4.Visible = true;
                txtbx_mac_5_5.Visible = true;
                txtbx_mac_5_6.Visible = true;
            }
        }

        private void btn_create_license_Click(object sender, EventArgs e)
        {
            if (save_file_dialog.ShowDialog() == DialogResult.OK)
            {
                string lic_file_name = save_file_dialog.FileName;
                string lic_content_raw = "";
                /*
                 VERSION=ACCMNGR1_1_1.1_1;EXP_YEAR=2013;EXP_MONTH=12;EXP_DAY=31;NO_OF_MAC=1;MAC1=FFFFFFFFFFFF;
                 */
                lic_content_raw = "VERSION=" + txtbx_version.Text + ";";
                lic_content_raw = lic_content_raw + "EXP_YEAR=" + dateTimePicker1.Value.Year.ToString() + ";";
                if(Convert.ToInt16(dateTimePicker1.Value.Month) < 10)
                    lic_content_raw = lic_content_raw + "EXP_MONTH=0" + dateTimePicker1.Value.Month.ToString() + ";";
                else
                    lic_content_raw = lic_content_raw + "EXP_MONTH=" + dateTimePicker1.Value.Month.ToString() + ";";
                if (Convert.ToInt16(dateTimePicker1.Value.Day) < 10)
                    lic_content_raw = lic_content_raw + "EXP_DAY=0" + dateTimePicker1.Value.Day.ToString() + ";";
                else
                    lic_content_raw = lic_content_raw + "EXP_DAY=" + dateTimePicker1.Value.Day.ToString() + ";";
                Int16 no_of_mac = Convert.ToInt16(numupdwn_no_of_mac.Value);
                lic_content_raw = lic_content_raw + "NO_OF_MAC=" + numupdwn_no_of_mac.Value.ToString() + ";";
                if (no_of_mac > 0)
                {
                    lic_content_raw = lic_content_raw + "MAC1=" + txtbx_mac_1_1.Text + txtbx_mac_1_2.Text + txtbx_mac_1_3.Text + txtbx_mac_1_4.Text + txtbx_mac_1_5.Text + txtbx_mac_1_6.Text + ";";
                }
                if (no_of_mac > 1)
                {
                    lic_content_raw = lic_content_raw + "MAC2=" + txtbx_mac_2_1.Text + txtbx_mac_2_2.Text + txtbx_mac_2_3.Text + txtbx_mac_2_4.Text + txtbx_mac_2_5.Text + txtbx_mac_2_6.Text + ";";
                }
                if (no_of_mac > 2)
                {
                    lic_content_raw = lic_content_raw + "MAC3=" + txtbx_mac_3_1.Text + txtbx_mac_3_2.Text + txtbx_mac_3_3.Text + txtbx_mac_3_4.Text + txtbx_mac_3_5.Text + txtbx_mac_3_6.Text + ";";
                }
                if (no_of_mac > 3)
                {
                    lic_content_raw = lic_content_raw + "MAC4=" + txtbx_mac_4_1.Text + txtbx_mac_4_2.Text + txtbx_mac_4_3.Text + txtbx_mac_4_4.Text + txtbx_mac_4_5.Text + txtbx_mac_4_6.Text + ";";
                }
                if (no_of_mac > 4)
                {
                    lic_content_raw = lic_content_raw + "MAC5=" + txtbx_mac_5_1.Text + txtbx_mac_5_2.Text + txtbx_mac_5_3.Text + txtbx_mac_5_4.Text + txtbx_mac_5_5.Text + txtbx_mac_5_6.Text + ";";
                }
                MessageBox.Show("LICENSE CONTENT ARE = \"" + lic_content_raw + "\"");
                this.EncryptFile(lic_content_raw, lic_file_name, password);
            }
        }

        private void btn_read_license_Click(object sender, EventArgs e)
        {
            if (open_file_dialog.ShowDialog() == DialogResult.OK)
            {
                string lic_file_name = open_file_dialog.FileName;
                string lic_content_raw = "";
                lic_content_raw = this.DecryptFile(lic_file_name, password);
                MessageBox.Show("LICENSE CONTENT ARE = \"" + lic_content_raw + "\"");
            }
        }
    }
}
