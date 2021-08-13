
namespace AES_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CipherMode_Combobox = new System.Windows.Forms.ComboBox();
            this.AESType_Combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PaddingMode_Combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Key_Textbox = new System.Windows.Forms.TextBox();
            this.IV_Textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Encrypt_Button = new System.Windows.Forms.Button();
            this.Decrypt_Button = new System.Windows.Forms.Button();
            this.Input_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Output_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ConvertType_Combobox = new System.Windows.Forms.ComboBox();
            this.Encrypt_InputFilename_Textbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Encrypt_OutputFilename_Textbox = new System.Windows.Forms.TextBox();
            this.EncryptFile_Button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DecryptFile_Button = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Decrypt_OutputFilename_Textbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Decrypt_InputFilename_Textbox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CipherMode_Combobox
            // 
            this.CipherMode_Combobox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CipherMode_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CipherMode_Combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CipherMode_Combobox.ForeColor = System.Drawing.Color.White;
            this.CipherMode_Combobox.FormattingEnabled = true;
            this.CipherMode_Combobox.Location = new System.Drawing.Point(117, 114);
            this.CipherMode_Combobox.Name = "CipherMode_Combobox";
            this.CipherMode_Combobox.Size = new System.Drawing.Size(217, 33);
            this.CipherMode_Combobox.TabIndex = 1;
            this.CipherMode_Combobox.SelectedIndexChanged += new System.EventHandler(this.CipherMode_Combobox_SelectedIndexChanged);
            // 
            // AESType_Combobox
            // 
            this.AESType_Combobox.BackColor = System.Drawing.SystemColors.Window;
            this.AESType_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AESType_Combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AESType_Combobox.FormattingEnabled = true;
            this.AESType_Combobox.Location = new System.Drawing.Point(117, 75);
            this.AESType_Combobox.Name = "AESType_Combobox";
            this.AESType_Combobox.Size = new System.Drawing.Size(217, 33);
            this.AESType_Combobox.TabIndex = 3;
            this.AESType_Combobox.SelectedIndexChanged += new System.EventHandler(this.AESType_Combobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "AES C/E";
            // 
            // PaddingMode_Combobox
            // 
            this.PaddingMode_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaddingMode_Combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PaddingMode_Combobox.FormattingEnabled = true;
            this.PaddingMode_Combobox.Location = new System.Drawing.Point(468, 75);
            this.PaddingMode_Combobox.Name = "PaddingMode_Combobox";
            this.PaddingMode_Combobox.Size = new System.Drawing.Size(217, 33);
            this.PaddingMode_Combobox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "AES Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "AES Mode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(344, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Padding Mode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Key:";
            // 
            // Key_Textbox
            // 
            this.Key_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Key_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Key_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Key_Textbox.ForeColor = System.Drawing.Color.White;
            this.Key_Textbox.Location = new System.Drawing.Point(71, 165);
            this.Key_Textbox.MaxLength = 32;
            this.Key_Textbox.Name = "Key_Textbox";
            this.Key_Textbox.Size = new System.Drawing.Size(614, 30);
            this.Key_Textbox.TabIndex = 12;
            // 
            // IV_Textbox
            // 
            this.IV_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.IV_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IV_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IV_Textbox.ForeColor = System.Drawing.Color.White;
            this.IV_Textbox.Location = new System.Drawing.Point(71, 201);
            this.IV_Textbox.MaxLength = 16;
            this.IV_Textbox.Name = "IV_Textbox";
            this.IV_Textbox.Size = new System.Drawing.Size(614, 30);
            this.IV_Textbox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "IV:";
            // 
            // Encrypt_Button
            // 
            this.Encrypt_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Encrypt_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Encrypt_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Encrypt_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Encrypt_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Encrypt_Button.Location = new System.Drawing.Point(34, 760);
            this.Encrypt_Button.Name = "Encrypt_Button";
            this.Encrypt_Button.Size = new System.Drawing.Size(158, 51);
            this.Encrypt_Button.TabIndex = 12;
            this.Encrypt_Button.Text = "Encrypt";
            this.Encrypt_Button.UseVisualStyleBackColor = false;
            this.Encrypt_Button.Click += new System.EventHandler(this.Encrypt_Button_Click);
            // 
            // Decrypt_Button
            // 
            this.Decrypt_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Decrypt_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Decrypt_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Decrypt_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Decrypt_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Decrypt_Button.Location = new System.Drawing.Point(200, 760);
            this.Decrypt_Button.Name = "Decrypt_Button";
            this.Decrypt_Button.Size = new System.Drawing.Size(158, 51);
            this.Decrypt_Button.TabIndex = 12;
            this.Decrypt_Button.Text = "Decrypt";
            this.Decrypt_Button.UseVisualStyleBackColor = false;
            this.Decrypt_Button.Click += new System.EventHandler(this.Decrypt_Button_Click);
            // 
            // Input_RichTextBox
            // 
            this.Input_RichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Input_RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input_RichTextBox.DetectUrls = false;
            this.Input_RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Input_RichTextBox.ForeColor = System.Drawing.Color.White;
            this.Input_RichTextBox.Location = new System.Drawing.Point(27, 276);
            this.Input_RichTextBox.Name = "Input_RichTextBox";
            this.Input_RichTextBox.Size = new System.Drawing.Size(658, 212);
            this.Input_RichTextBox.TabIndex = 15;
            this.Input_RichTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(324, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Input";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(314, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Output";
            // 
            // Output_RichTextBox
            // 
            this.Output_RichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Output_RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output_RichTextBox.DetectUrls = false;
            this.Output_RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Output_RichTextBox.ForeColor = System.Drawing.Color.White;
            this.Output_RichTextBox.Location = new System.Drawing.Point(34, 529);
            this.Output_RichTextBox.Name = "Output_RichTextBox";
            this.Output_RichTextBox.Size = new System.Drawing.Size(658, 212);
            this.Output_RichTextBox.TabIndex = 18;
            this.Output_RichTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(532, 760);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 51);
            this.button1.TabIndex = 19;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(366, 760);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 51);
            this.button2.TabIndex = 20;
            this.button2.Text = "Save Output";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(344, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Convert Type:";
            // 
            // ConvertType_Combobox
            // 
            this.ConvertType_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConvertType_Combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ConvertType_Combobox.FormattingEnabled = true;
            this.ConvertType_Combobox.Location = new System.Drawing.Point(468, 114);
            this.ConvertType_Combobox.Name = "ConvertType_Combobox";
            this.ConvertType_Combobox.Size = new System.Drawing.Size(217, 33);
            this.ConvertType_Combobox.TabIndex = 21;
            // 
            // Encrypt_InputFilename_Textbox
            // 
            this.Encrypt_InputFilename_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Encrypt_InputFilename_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Encrypt_InputFilename_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Encrypt_InputFilename_Textbox.ForeColor = System.Drawing.Color.White;
            this.Encrypt_InputFilename_Textbox.Location = new System.Drawing.Point(878, 109);
            this.Encrypt_InputFilename_Textbox.MaxLength = 32;
            this.Encrypt_InputFilename_Textbox.Name = "Encrypt_InputFilename_Textbox";
            this.Encrypt_InputFilename_Textbox.Size = new System.Drawing.Size(614, 30);
            this.Encrypt_InputFilename_Textbox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(721, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Input File Location:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(707, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Output File Location:";
            // 
            // Encrypt_OutputFilename_Textbox
            // 
            this.Encrypt_OutputFilename_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Encrypt_OutputFilename_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Encrypt_OutputFilename_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Encrypt_OutputFilename_Textbox.ForeColor = System.Drawing.Color.White;
            this.Encrypt_OutputFilename_Textbox.Location = new System.Drawing.Point(878, 146);
            this.Encrypt_OutputFilename_Textbox.MaxLength = 32;
            this.Encrypt_OutputFilename_Textbox.Name = "Encrypt_OutputFilename_Textbox";
            this.Encrypt_OutputFilename_Textbox.Size = new System.Drawing.Size(614, 30);
            this.Encrypt_OutputFilename_Textbox.TabIndex = 25;
            // 
            // EncryptFile_Button
            // 
            this.EncryptFile_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.EncryptFile_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EncryptFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EncryptFile_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EncryptFile_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EncryptFile_Button.Location = new System.Drawing.Point(878, 185);
            this.EncryptFile_Button.Name = "EncryptFile_Button";
            this.EncryptFile_Button.Size = new System.Drawing.Size(198, 51);
            this.EncryptFile_Button.TabIndex = 28;
            this.EncryptFile_Button.Text = "Encrypt File";
            this.EncryptFile_Button.UseVisualStyleBackColor = false;
            this.EncryptFile_Button.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(708, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 29);
            this.label12.TabIndex = 32;
            this.label12.Text = "Encrypt File";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(708, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 29);
            this.label13.TabIndex = 40;
            this.label13.Text = "Decrypt File";
            // 
            // DecryptFile_Button
            // 
            this.DecryptFile_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.DecryptFile_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DecryptFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DecryptFile_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DecryptFile_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DecryptFile_Button.Location = new System.Drawing.Point(878, 417);
            this.DecryptFile_Button.Name = "DecryptFile_Button";
            this.DecryptFile_Button.Size = new System.Drawing.Size(198, 51);
            this.DecryptFile_Button.TabIndex = 37;
            this.DecryptFile_Button.Text = "Decrypt File";
            this.DecryptFile_Button.UseVisualStyleBackColor = false;
            this.DecryptFile_Button.Click += new System.EventHandler(this.DecryptFile_Button_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(707, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "Output File Location:";
            // 
            // Decrypt_OutputFilename_Textbox
            // 
            this.Decrypt_OutputFilename_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Decrypt_OutputFilename_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Decrypt_OutputFilename_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Decrypt_OutputFilename_Textbox.ForeColor = System.Drawing.Color.White;
            this.Decrypt_OutputFilename_Textbox.Location = new System.Drawing.Point(878, 378);
            this.Decrypt_OutputFilename_Textbox.MaxLength = 32;
            this.Decrypt_OutputFilename_Textbox.Name = "Decrypt_OutputFilename_Textbox";
            this.Decrypt_OutputFilename_Textbox.Size = new System.Drawing.Size(614, 30);
            this.Decrypt_OutputFilename_Textbox.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(721, 345);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Input File Location:";
            // 
            // Decrypt_InputFilename_Textbox
            // 
            this.Decrypt_InputFilename_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Decrypt_InputFilename_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Decrypt_InputFilename_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Decrypt_InputFilename_Textbox.ForeColor = System.Drawing.Color.White;
            this.Decrypt_InputFilename_Textbox.Location = new System.Drawing.Point(878, 341);
            this.Decrypt_InputFilename_Textbox.MaxLength = 32;
            this.Decrypt_InputFilename_Textbox.Name = "Decrypt_InputFilename_Textbox";
            this.Decrypt_InputFilename_Textbox.Size = new System.Drawing.Size(614, 30);
            this.Decrypt_InputFilename_Textbox.TabIndex = 33;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1498, 378);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1498, 341);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1498, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1498, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AES_Tool.Resource1.exit;
            this.pictureBox1.Location = new System.Drawing.Point(1486, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1550, 837);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.DecryptFile_Button);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Decrypt_OutputFilename_Textbox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Decrypt_InputFilename_Textbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.EncryptFile_Button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Encrypt_OutputFilename_Textbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Encrypt_InputFilename_Textbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ConvertType_Combobox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Output_RichTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Input_RichTextBox);
            this.Controls.Add(this.Decrypt_Button);
            this.Controls.Add(this.Encrypt_Button);
            this.Controls.Add(this.IV_Textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Key_Textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaddingMode_Combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AESType_Combobox);
            this.Controls.Add(this.CipherMode_Combobox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CipherMode_Combobox;
        private System.Windows.Forms.ComboBox AESType_Combobox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PaddingMode_Combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Key_Textbox;
        private System.Windows.Forms.TextBox IV_Textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Encrypt_Button;
        private System.Windows.Forms.Button Decrypt_Button;
        private System.Windows.Forms.RichTextBox Input_RichTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox Output_RichTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ConvertType_Combobox;
        private System.Windows.Forms.TextBox Encrypt_InputFilename_Textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Encrypt_OutputFilename_Textbox;
        private System.Windows.Forms.Button EncryptFile_Button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button DecryptFile_Button;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Decrypt_OutputFilename_Textbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Decrypt_InputFilename_Textbox;
    }
}

