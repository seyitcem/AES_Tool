using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] key_size = { "AES-128", "AES-192", "AES-256" };
            AESType_Combobox.Items.AddRange(key_size);
            AESType_Combobox.SelectedIndex = 2;
            string[] cipher_modes = { "CBC", "ECB", "CFB" };
            CipherMode_Combobox.Items.AddRange(cipher_modes);
            CipherMode_Combobox.SelectedIndex = 0;
            string[] padding_modes = { "None", "PKCS7 (Default)", "Zeros", "ANSIX923", "ISO10126" };
            PaddingMode_Combobox.Items.AddRange(padding_modes);
            PaddingMode_Combobox.SelectedIndex = 1;
            string[] convert_types = { "Line by line", "All lines" };
            ConvertType_Combobox.Items.AddRange(convert_types);
            ConvertType_Combobox.SelectedIndex = 0;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AESType_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AESType_Combobox.SelectedIndex == 0)
            {
                Key_Textbox.MaxLength = 16;
            }
            else if (AESType_Combobox.SelectedIndex == 1)
            {
                Key_Textbox.MaxLength = 24;
            }
            else if (AESType_Combobox.SelectedIndex == 2)
            {
                Key_Textbox.MaxLength = 32;
            }
        }

        private void Encrypt_Button_Click(object sender, EventArgs e)
        {
            if (AESType_Combobox.SelectedIndex == 0 && Key_Textbox.Text.Length != 16)
            {
                MessageBox.Show("Length of the key must be 16 in AES-128.");
                return;
            }
            if (AESType_Combobox.SelectedIndex == 1 && Key_Textbox.Text.Length != 24)
            {
                MessageBox.Show("Length of the key must be 24 in AES-192.");
                return;
            }
            if (AESType_Combobox.SelectedIndex == 2 && Key_Textbox.Text.Length != 32)
            {
                MessageBox.Show("Length of the key must be 32 in AES-256.");
                return;
            }
            if ((CipherMode_Combobox.SelectedIndex == 0 || CipherMode_Combobox.SelectedIndex == 2) && IV_Textbox.Text.Length != 16)
            {
                MessageBox.Show("Length of the IV must be 16 byte.");
                return;
            }
            if (ConvertType_Combobox.SelectedIndex == 0)
            {
                string[] lines = Input_RichTextBox.Text.Split('\n');
                Output_RichTextBox.Clear();
                foreach (string line in lines)
                {
                    if (line.Length > 0)
                    {
                        Output_RichTextBox.Text += AES.AES_Encryptor(line, (AESType_Combobox.SelectedIndex + 2) * 8, Key_Textbox.Text, IV_Textbox.Text, CipherMode_Combobox.SelectedItem.ToString(), PaddingMode_Combobox.Text.Split(' ')[0].ToString()) + "\n";
                    }
                }
            }
            else if (ConvertType_Combobox.SelectedIndex == 1)
            {
                Output_RichTextBox.Clear();
                Output_RichTextBox.Text = AES.AES_Encryptor(Input_RichTextBox.Text, (AESType_Combobox.SelectedIndex + 2) * 8, Key_Textbox.Text, IV_Textbox.Text, CipherMode_Combobox.SelectedItem.ToString(), PaddingMode_Combobox.Text.Split(' ')[0].ToString());
            }
        }

        private void Decrypt_Button_Click(object sender, EventArgs e)
        {
            if (AESType_Combobox.SelectedIndex == 0 && Key_Textbox.Text.Length != 16)
            {
                MessageBox.Show("Length of the key must be 16 in AES-128.");
                return;
            }
            if (AESType_Combobox.SelectedIndex == 1 && Key_Textbox.Text.Length != 24)
            {
                MessageBox.Show("Length of the key must be 24 in AES-192.");
                return;
            }
            if (AESType_Combobox.SelectedIndex == 2 && Key_Textbox.Text.Length != 32)
            {
                MessageBox.Show("Length of the key must be 32 in AES-256.");
                return;
            }
            if ((CipherMode_Combobox.SelectedIndex == 0 || CipherMode_Combobox.SelectedIndex == 2) && IV_Textbox.Text.Length != 16)
            {
                MessageBox.Show("Length of the IV must be 16 byte.");
                return;
            }
            if (ConvertType_Combobox.SelectedIndex == 0)
            {
                string[] lines = Input_RichTextBox.Text.Split('\n');
                Output_RichTextBox.Clear();
                foreach (string line in lines)
                {
                    if (line.Length > 0)
                    {
                        string result = AES.AES_Decryptor(line, (AESType_Combobox.SelectedIndex + 2) * 8, Key_Textbox.Text, IV_Textbox.Text, CipherMode_Combobox.SelectedItem.ToString(), PaddingMode_Combobox.Text.Split(' ')[0].ToString());
                        if (result == null)
                        {
                            break;
                        }
                        else
                        {
                            Output_RichTextBox.Text += result + "\n";
                        }
                    }
                }
            }
            else if (ConvertType_Combobox.SelectedIndex == 1)
            {
                Output_RichTextBox.Clear();
                Output_RichTextBox.Text = AES.AES_Decryptor(Input_RichTextBox.Text, (AESType_Combobox.SelectedIndex + 2) * 8, Key_Textbox.Text, IV_Textbox.Text, CipherMode_Combobox.SelectedItem.ToString(), PaddingMode_Combobox.Text.Split(' ')[0].ToString());
            }
        }

        private void CipherMode_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CipherMode_Combobox.SelectedItem.ToString() == "ECB")
            {
                IV_Textbox.Enabled = false;
                IV_Textbox.BackColor = this.BackColor;
                IV_Textbox.Text = "";
            }
            else
            {
                IV_Textbox.Enabled = true;
                IV_Textbox.BackColor = Color.FromArgb(66, 66, 66);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input_RichTextBox.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file_name = openFileDialog.FileName;
                Input_RichTextBox.Text = File.ReadAllText(file_name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.Write(Output_RichTextBox.Text);
                streamWriter.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Input_RichTextBox.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file_name = openFileDialog.FileName;
                Encrypt_InputFilename_Textbox.Text = file_name;
                Encrypt_OutputFilename_Textbox.Text = file_name + ".aes";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Input_RichTextBox.Clear();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folder_name = folderBrowserDialog.SelectedPath;
                Encrypt_OutputFilename_Textbox.Text = folder_name + Encrypt_InputFilename_Textbox.Text.Substring(Encrypt_InputFilename_Textbox.Text.LastIndexOf('\\'));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (AESType_Combobox.SelectedIndex == 0 && Key_Textbox.Text.Length != 16)
            {
                MessageBox.Show("Length of the key must be 16 in AES-128.");
                return;
            }
            if (AESType_Combobox.SelectedIndex == 1 && Key_Textbox.Text.Length != 24)
            {
                MessageBox.Show("Length of the key must be 24 in AES-192.");
                return;
            }
            if (AESType_Combobox.SelectedIndex == 2 && Key_Textbox.Text.Length != 32)
            {
                MessageBox.Show("Length of the key must be 32 in AES-256.");
                return;
            }
            if ((CipherMode_Combobox.SelectedIndex == 0 || CipherMode_Combobox.SelectedIndex == 2) && IV_Textbox.Text.Length != 16)
            {
                MessageBox.Show("Length of the IV must be 16 byte.");
                return;
            }
            File.WriteAllBytes(Encrypt_OutputFilename_Textbox.Text, AES.AES_File_Encryptor(Encrypt_InputFilename_Textbox.Text, (AESType_Combobox.SelectedIndex + 2) * 8, Key_Textbox.Text, IV_Textbox.Text, CipherMode_Combobox.SelectedItem.ToString(), PaddingMode_Combobox.Text.Split(' ')[0].ToString()));
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "AES Files|*.aes";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file_name = openFileDialog.FileName;
                Decrypt_InputFilename_Textbox.Text = file_name;
                Decrypt_OutputFilename_Textbox.Text = file_name.Substring(0, file_name.IndexOf(".aes"));
            }
        }

        private void DecryptFile_Button_Click(object sender, EventArgs e)
        {
            if (AESType_Combobox.SelectedIndex == 0 && Key_Textbox.Text.Length != 16)
            {
                MessageBox.Show("Length of the key must be 16 in AES-128.");
                return;
            }
            if (AESType_Combobox.SelectedIndex == 1 && Key_Textbox.Text.Length != 24)
            {
                MessageBox.Show("Length of the key must be 24 in AES-192.");
                return;
            }
            if (AESType_Combobox.SelectedIndex == 2 && Key_Textbox.Text.Length != 32)
            {
                MessageBox.Show("Length of the key must be 32 in AES-256.");
                return;
            }
            if ((CipherMode_Combobox.SelectedIndex == 0 || CipherMode_Combobox.SelectedIndex == 2) && IV_Textbox.Text.Length != 16)
            {
                MessageBox.Show("Length of the IV must be 16 byte.");
                return;
            }
            byte[] bytes = AES.AES_File_Decryptor(Decrypt_InputFilename_Textbox.Text, (AESType_Combobox.SelectedIndex + 2) * 8, Key_Textbox.Text, IV_Textbox.Text, CipherMode_Combobox.SelectedItem.ToString(), PaddingMode_Combobox.Text.Split(' ')[0].ToString());
            if (bytes != null)
            {
                File.WriteAllBytes(Decrypt_OutputFilename_Textbox.Text, bytes);
            }
        }
    }
}
