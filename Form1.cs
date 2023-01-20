using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cripto {
    public partial class Form1 : Form {
        internal string SampleText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        internal bool EncriptTextStatus = false;
        internal bool ShowPassValue = true;
        internal bool clickFix = false;
        internal string Encript_Selected_File = "";
        internal string Encript_SaveDir_File = "";
        internal string Decript_Selected_File = "";
        internal string Decript_SaveDir_File = "";

        
        internal bool DecriptTextStatus = false;
        internal byte[] fileToEncrypt;
        internal byte[] fileToDecrypt;
        
        internal static byte[] Enc_Fix_Text;
        internal static byte[] Dec_Fix_Text;

        public Form1() {
            InitializeComponent();
            if(!EncriptTextStatus) {
                TextEncriptTab.Text = SampleText;
                Encript_DecryptedTextLabel.Visible = false;
                Encript_DecryptedText.Visible = false;
                Encript_DecryptedText.Visible = false;
                Encript_DecryptedButton.Visible = false;
            }
            if(!DecriptTextStatus) {
                TextDecriptTab.Text = "-- |Kyznechik| --";
                Decript_EncryptedTextLabel.Visible = false;
                DecryptedTextEncriptedTab.Visible = false;
                Decript_EncryptedButton.Visible = false;
            }
            label5.Visible = false;
            panel1.Visible = false;
            label11.Visible = false;
            OpenFileDir.Visible = false;
            string KeyGen_z = CreatePassword(32);
            KeyDecriptTab.Text = KeyGen_z;
            KeyEncriptTab.Text = KeyGen_z;
            string KeyGen_d = CreatePassword(32);
            EncriptFile_key.Text = KeyGen_d;

        }

       
        public string CreatePassword(int length) {
            const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_+=.?[]{}";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while(0 < length--) {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            MD5 md = new MD5CryptoServiceProvider();
            byte[] array = md.ComputeHash(Encoding.UTF8.GetBytes(res.ToString()));
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < array.Length; i++) {
                stringBuilder.Append(array[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }

        private void KeyGenerateEncriptTab_Click(object sender, EventArgs e) {
            KeyEncriptTab.Text = CreatePassword(32);
        }

        private void ClearEncriptTab_Click(object sender, EventArgs e) {
            TextEncriptTab.Text = "";
            ClearEncriptTab.Enabled = false;
            Encript_ButtonEncriptTab.Enabled = false;
        }

        private void ClearDecriptTab_Click(object sender, EventArgs e) {
            TextDecriptTab.Text = "";
            ClearDecriptTab.Enabled = false;
            Decript_ButtonEncriptTab.Enabled = false;
        }
    

        private void TextEncriptTab_TextChanged(object sender, EventArgs e) {
            if(TextEncriptTab.Text.Length > 0) {
                ClearEncriptTab.Enabled = true;
                if(KeyEncriptTab.Text.Length > 0) {
                    Encript_ButtonEncriptTab.Enabled = true;
                } else {
                    Encript_ButtonEncriptTab.Enabled = false;
                }
               
            } else {
                ClearEncriptTab.Enabled = false;
                Encript_ButtonEncriptTab.Enabled = false;
            }
        }

        private void KeyEncriptTab_TextChanged(object sender, EventArgs e) {
            if(KeyEncriptTab.Text.Length > 0) {
                if(TextEncriptTab.Text.Length > 0) {
                    Encript_ButtonEncriptTab.Enabled = true;
                } else {
                    Encript_ButtonEncriptTab.Enabled = false;
                }
            } else {
                Encript_ButtonEncriptTab.Enabled = false;
            }
        }

        private void KeyDecriptTab_TextChanged(object sender, EventArgs e) {
            if(KeyDecriptTab.Text.Length > 0) {
                if(TextDecriptTab.Text.Length > 0) {
                    Decript_ButtonEncriptTab.Enabled = true;
                } else {
                    Decript_ButtonEncriptTab.Enabled = false;
                }
            } else {
                Decript_ButtonEncriptTab.Enabled = false;
            }
        }

        private void TextDecriptTab_TextChanged(object sender, EventArgs e) {
            if(TextDecriptTab.Text.Length > 0) {
                ClearDecriptTab.Enabled = true;
                if(KeyDecriptTab.Text.Length > 0) {
                    Decript_ButtonEncriptTab.Enabled = true;
                } else {
                    Decript_ButtonEncriptTab.Enabled = false;
                }
               
            } else {
                ClearDecriptTab.Enabled = false;
                Decript_ButtonEncriptTab.Enabled = false;
            }
        }
        
        public static string Decript_Kyz(string value, string key) {
            byte[] StringToDecript = Encoding.Default.GetBytes(value);
            byte[] DecriptKey = Encoding.Default.GetBytes(key);
            CriptoClass criptoClass = new CriptoClass();
            byte[] DecryptedText = criptoClass.GrasshopperDecript(StringToDecript, DecriptKey);
            Dec_Fix_Text = DecryptedText;
            return Encoding.Default.GetString(DecryptedText);
        }
        public static string Encript_Kyz(string value, string key) {
            byte[] StringToEncript = Encoding.Default.GetBytes(value);
            byte[] EncriptKey = Encoding.Default.GetBytes(key);
            CriptoClass criptoClass = new CriptoClass();
            byte[] EncryptedText = criptoClass.GrasshopperEncript(StringToEncript, EncriptKey);
            Enc_Fix_Text = EncryptedText;
            return Encoding.Default.GetString(EncryptedText);
        }
        private async void DelayFunction(int delayCoef) {
            Task.Delay(delayCoef).Wait();
        }
        private async void DelayFunction2(int delayCoef) {
            Task.Delay(delayCoef).Wait();
        }
        public void Decript_ButtonEncriptTab_Click(object sender, EventArgs e) {
            int delayCoef = 50;
            KeyDecriptTab.Enabled = false;
            TextDecriptTab.Enabled = false;
            ClearDecriptTab.Enabled = false;
            Decript_ButtonEncriptTab.Enabled = false;
            Decript_EncryptedTextLabel.Visible = false;
            DecryptedTextEncriptedTab.Visible = false;
            Decript_EncryptedButton.Visible = false;
            string Temp_Btn_value = Decript_ButtonEncriptTab.Text;
            Decript_ButtonEncriptTab.Enabled = false;
            Decript_ButtonEncriptTab.Text = "Расшифровка...";
            Decript_ProgressBar_Text.Visible = true;
            if(TextDecriptTab.Text.Length < 2000) {
                delayCoef = 25;
            }
            string DecryptedText = Decript_Kyz(TextDecriptTab.Text, KeyDecriptTab.Text);
            for(int i = 0; i < 100; i++) {
                Decript_ProgressBar_Text.Value += 1;
                DelayFunction(delayCoef);
            }
            Decript_ProgressBar_Text.Visible = false;
            Decript_ButtonEncriptTab.Enabled = true;
            Decript_ButtonEncriptTab.Enabled = true;
            KeyDecriptTab.Enabled = true;
            TextDecriptTab.Enabled = true;
            ClearDecriptTab.Enabled = true;
            Decript_ButtonEncriptTab.Text = Temp_Btn_value;
            Decript_ProgressBar_Text.Value = 0;
            DecryptedTextEncriptedTab.Text = DecryptedText;
            Decript_EncryptedTextLabel.Visible = true;
            DecryptedTextEncriptedTab.Visible = true;
            Decript_EncryptedButton.Visible = true;
            MessageBox.Show("Расшифровка текста прошла успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.None);
            DecriptTextStatus = true;
        }

        private void Decript_EncryptedButton_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileTxt = new SaveFileDialog();
            DateTime FileData = DateTime.Now;
            saveFileTxt.FileName = "Decrypted_" + FileData.Hour.ToString() + FileData.Minute.ToString() + FileData.Second.ToString() + "_" + FileData.ToShortDateString() + ".txt";
            saveFileTxt.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if(saveFileTxt.ShowDialog() == DialogResult.OK) {
                File.WriteAllBytes(saveFileTxt.FileName, Dec_Fix_Text);
                OpenFileInExplorer(saveFileTxt.FileName);
                MessageBox.Show("Файл успешно сохранён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void ShowPass_Click(object sender, EventArgs e) {
            if(ShowPassValue) {
                ShowPassValue = false;
                ShowPass.BackgroundImage = global::Cripto.Properties.Resources.PassViewOn;
                KeyDecriptTab.UseSystemPasswordChar = true;
            } else {
                ShowPassValue = true;
                ShowPass.BackgroundImage = global::Cripto.Properties.Resources.PassViewOff;
                KeyDecriptTab.UseSystemPasswordChar = false;
            }
        }

        private void Encript_ButtonEncriptTab_Click(object sender, EventArgs e) {
            int delayCoef = 50;
            KeyGenerateEncriptTab.Enabled = false;
            KeyEncriptTab.Enabled = false;
            TextEncriptTab.Enabled = false;
            ClearEncriptTab.Enabled = false;
            Encript_ButtonEncriptTab.Enabled = false;
            Encript_DecryptedTextLabel.Visible = false;
            Encript_DecryptedText.Visible = false;
            Encript_DecryptedButton.Visible = false;

            string Temp_Btn_value = Encript_ButtonEncriptTab.Text;
            Encript_ButtonEncriptTab.Enabled = false;
            Encript_ButtonEncriptTab.Text = "Шифровка текста...";
            Encript_ProgressBar_Text.Visible = true;

            if(TextEncriptTab.Text.Length < 2000) {
                delayCoef = 25;
            }
            string EncryptedText = Encript_Kyz(TextEncriptTab.Text, KeyEncriptTab.Text);
            for(int i = 0; i < 100; i++) {
                Encript_ProgressBar_Text.Value += 1;
                DelayFunction2(delayCoef);
            }

            Encript_ProgressBar_Text.Visible = false;
            Encript_ButtonEncriptTab.Enabled = true;
            KeyGenerateEncriptTab.Enabled = true;
            KeyEncriptTab.Enabled = true;
            TextEncriptTab.Enabled = true;
            ClearEncriptTab.Enabled = true;
            Encript_ButtonEncriptTab.Text = Temp_Btn_value;
            Encript_ProgressBar_Text.Value = 0;
            Encript_DecryptedText.Text = EncryptedText;
            Encript_DecryptedTextLabel.Visible = true;
            Encript_DecryptedText.Visible = true;
            Encript_DecryptedButton.Visible = true;
            MessageBox.Show("Шифровка текста прошла успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.None);
            EncriptTextStatus = true;
        }
 
        private void Encript_DecryptedButton_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileTxt = new SaveFileDialog();
            DateTime FileData = DateTime.Now;
            saveFileTxt.FileName = "Encrypted_" + FileData.Hour.ToString() + FileData.Minute.ToString() + FileData.Second.ToString() + "_" + FileData.ToShortDateString() + ".txt";
            saveFileTxt.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if(saveFileTxt.ShowDialog() == DialogResult.OK) {
                File.WriteAllBytes(saveFileTxt.FileName, Enc_Fix_Text);
                OpenFileInExplorer(saveFileTxt.FileName);
                MessageBox.Show("Файл успешно сохранён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void text_GotFocus(object sender, MouseEventArgs e) {
            TextBox text = sender as TextBox;
            if(!clickFix) {
                if(text != null) text.SelectAll();
                clickFix = true;
            } else {
                clickFix = false;
            }

        }

        private void Encript_SelectFile_Click(object sender, EventArgs e) {

            EncriptFile_SelectSaveDir.Text = "Выбрать место сохранения файла";
            TextSavedFile_Enc_dir.Text = "---Выберите место сохранения зашифрованного файла ---";
            label5.Visible = false;
            panel1.Visible = false;
            label11.Visible = false;
            OpenFileDir.Visible = false;
            OpenFileDialog openFileDialog1 = new OpenFileDialog {
                InitialDirectory = System.IO.Directory.GetCurrentDirectory(),
                Title = "Выберите файл который нужно зашифровать",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                Encript_Selected_File = openFileDialog1.FileName;
                EncriptFilePatch.Text = Encript_Selected_File;
                fileToEncrypt = File.ReadAllBytes(openFileDialog1.FileName);
               
                if(EncriptFile_key.Text.Length > 0) {
                    if(Encript_Selected_File.Length > 0) {
                        if(Encript_SaveDir_File.Length > 0) {
                            EncriptFile_Btn.Enabled = true;
                        } else {
                            EncriptFile_Btn.Enabled = false;
                        }
                        EncriptFile_SelectSaveDir.Enabled = true;
                    } else {
                        EncriptFile_Btn.Enabled = false;
                        EncriptFile_SelectSaveDir.Enabled = false;
                    }
                } else {
                    EncriptFile_Btn.Enabled = false;
                    EncriptFile_SelectSaveDir.Enabled = false;
                }
            }
            
        }

        private void Encript_File_GenKey_Click(object sender, EventArgs e) {
            EncriptFile_key.Text = CreatePassword(32);
        }

        private void EncriptFile_Btn_Click(object sender, EventArgs e) {
           
            if(EncriptFile_key.Text.Length > 0) {
                if(Encript_Selected_File.Length > 0) {
                    SaveFileDialog saveFileTxt = new SaveFileDialog();

                    saveFileTxt.FileName = Path.GetFileName(Encript_Selected_File) + ".encrypted";
                    saveFileTxt.Filter = "All files (*.*)|*.*";
                    if(saveFileTxt.ShowDialog() == DialogResult.OK) {
                        Encript_SaveDir_File = saveFileTxt.FileName;
                        TextSavedFile_Enc_dir.Text = Encript_SaveDir_File;
                        EncriptFile_SelectSaveDir.Text = "Сменить место сохранения файла";
                        if(Encript_SaveDir_File.Length > 0) {
                            EncriptFile_Btn.Enabled = true;
                        } else {
                            EncriptFile_Btn.Enabled = false;
                        }
                    }
                } else {
                    EncriptFile_Btn.Enabled = false;
                    EncriptFile_SelectSaveDir.Enabled = false;
                }
            } else {
                EncriptFile_Btn.Enabled = false;
                EncriptFile_SelectSaveDir.Enabled = false;
            }
            
        }

        private void EncriptFile_key_TextChanged(object sender, EventArgs e) {
            if(EncriptFile_key.Text.Length > 0) {
                if(Encript_Selected_File.Length > 0) {
                    if(Encript_SaveDir_File.Length > 0) {
                        EncriptFile_Btn.Enabled = true;
                    } else {
                        EncriptFile_Btn.Enabled = false;
                    }
                    EncriptFile_SelectSaveDir.Enabled = true;
                } else {
                    EncriptFile_Btn.Enabled = false;
                    EncriptFile_SelectSaveDir.Enabled = false;
                }
            } else {
                EncriptFile_Btn.Enabled = false;
                EncriptFile_SelectSaveDir.Enabled = false;
            }
        }

        private void OpenFileInExplorer(string PatchD) {
            if(PatchD != "") {
                string filePath = PatchD;
                if(!File.Exists(filePath)) {
                    MessageBox.Show("Не получилось открыть файл в проводнике", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    string argument = "/select, \"" + filePath + "\"";
                    Process.Start("explorer.exe", argument);
                }  
            }
        }

        private void OpenFileDir_Click(object sender, EventArgs e) {
            OpenFileInExplorer(Encript_SaveDir_File);
        }

        private void EncriptFile_Btn_Click_1(object sender, EventArgs e) {
            label11.Text = "";
            Encript_SelectFile.Enabled = false;
            EncriptFile_key.Enabled = false;
            Encript_File_GenKey.Enabled = false;
            EncriptFile_SelectSaveDir.Enabled = false;
            label5.Visible = false;
            panel1.Visible = false;
            label11.Visible = false;
            OpenFileDir.Visible = false;
            EncriptFile_Progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            EncriptFile_Progress.Value = 0;
            EncriptFile_Progress.Visible = true;
            string Temp_Btn_value = EncriptFile_Btn.Text;
            EncriptFile_Btn.Text = "Происходит шифрация файла...";
            EncriptFile_Btn.Enabled = false;
            byte[] StringToEncript = fileToEncrypt;
            byte[] EncriptKey = Encoding.Default.GetBytes(EncriptFile_key.Text);
            CriptoClass criptoClass = new CriptoClass();
            byte[] EncryptedText = criptoClass.GrasshopperEncript(StringToEncript, EncriptKey);
            File.WriteAllBytes(Encript_SaveDir_File, EncryptedText);
            for(int i = 0; i < 100; i++) {
                EncriptFile_Progress.Value += 1;
                DelayFunction2(10);
            }
            EncriptFile_Progress.Style = System.Windows.Forms.ProgressBarStyle.Blocks;
            EncriptFile_Progress.Value = 0;
            EncriptFile_Progress.Visible = true;
            EncriptFile_Btn.Text = Temp_Btn_value;
            label5.Visible = true;
            panel1.Visible = true;
            label11.Text = Path.GetFileName(Encript_SaveDir_File);
            label11.Visible = true;
            OpenFileDir.Visible = true;
            Encript_SelectFile.Enabled = true;
            EncriptFile_Btn.Enabled = true;
            EncriptFile_key.Enabled = true;
            Encript_File_GenKey.Enabled = true;
            EncriptFile_SelectSaveDir.Enabled = true;
            MessageBox.Show("Файл успешно зашифрован", "Информация", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void button4_Click(object sender, EventArgs e) {

            SelectSaveFiletoDecriptBtn.Text = "Выбрать место сохранения файла";
            SelectSaveFiletoDecriptLabel.Text = "---Выберите место сохранения расшифрованного файла ---";
            label8.Visible = false;
            panel2.Visible = false;
            DecryptedFileNameLabel.Visible = false;
            OpenDecryptedSelectPatch.Visible = false;
            OpenFileDialog openFileDialog1 = new OpenFileDialog {
                InitialDirectory = System.IO.Directory.GetCurrentDirectory(),
                Title = "Выберите файл который нужно расшифровать",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "Encrypted files (*.encrypted)|*.encrypted|All files (*.*)|*.*",
            FilterIndex = 2,
                RestoreDirectory = true,
            };

            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                Decript_Selected_File = openFileDialog1.FileName;
                SelectDecriptFileLabel.Text = Decript_Selected_File;
                fileToDecrypt = File.ReadAllBytes(openFileDialog1.FileName);

                if(EnterDecriptKey.Text.Length > 0) {
                    if(Decript_Selected_File.Length > 0) {
                        if(Decript_SaveDir_File.Length > 0) {
                            DecriptGeneralBtn.Enabled = true;
                        } else {
                            DecriptGeneralBtn.Enabled = false;
                        }
                        SelectSaveFiletoDecriptBtn.Enabled = true;
                    } else {
                        DecriptGeneralBtn.Enabled = false;
                        SelectSaveFiletoDecriptBtn.Enabled = false;
                    }
                } else {
                    DecriptGeneralBtn.Enabled = false;
                    SelectSaveFiletoDecriptBtn.Enabled = false;
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e) {
            if(EnterDecriptKey.Text.Length > 0) {
                if(Decript_Selected_File.Length > 0) {
                    if(Decript_SaveDir_File.Length > 0) {
                        DecriptGeneralBtn.Enabled = true;
                    } else {
                        DecriptGeneralBtn.Enabled = false;
                    }
                    SelectSaveFiletoDecriptBtn.Enabled = true;
                } else {
                    DecriptGeneralBtn.Enabled = false;
                    SelectSaveFiletoDecriptBtn.Enabled = false;
                }
            } else {
                DecriptGeneralBtn.Enabled = false;
                SelectSaveFiletoDecriptBtn.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if(EnterDecriptKey.Text.Length > 0) {
                if(Decript_Selected_File.Length > 0) {
                    SaveFileDialog saveFileTxt = new SaveFileDialog();

                    saveFileTxt.FileName = Path.GetFileName(Decript_Selected_File) + ".encrypted";// remove encript text
                    saveFileTxt.Filter = "All files (*.*)|*.*";
                    if(saveFileTxt.ShowDialog() == DialogResult.OK) {
                        Decript_SaveDir_File = saveFileTxt.FileName;
                        SelectSaveFiletoDecriptLabel.Text = Decript_SaveDir_File;
                        SelectSaveFiletoDecriptBtn.Text = "Сменить место сохранения файла";
                        if(Decript_SaveDir_File.Length > 0) {
                            DecriptGeneralBtn.Enabled = true;
                        } else {
                            DecriptGeneralBtn.Enabled = false;
                        }
                    }
                } else {
                    DecriptGeneralBtn.Enabled = false;
                    SelectSaveFiletoDecriptBtn.Enabled = false;
                }
            } else {
                DecriptGeneralBtn.Enabled = false;
                SelectSaveFiletoDecriptBtn.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e) {
            DecryptedFileNameLabel.Text = "";
            SelectDecriptFileBtn.Enabled = false;
            EnterDecriptKey.Enabled = false;

            SelectSaveFiletoDecriptBtn.Enabled = false;
            label8.Visible = false;
            panel2.Visible = false;
            DecryptedFileNameLabel.Visible = false;
            OpenDecryptedSelectPatch.Visible = false;
            DecriptFileProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            DecriptFileProgressBar.Value = 0;
            DecriptFileProgressBar.Visible = true;
            string Temp_Btn_value = DecriptGeneralBtn.Text;
            DecriptGeneralBtn.Text = "Происходит дешифрация файла...";
            DecriptGeneralBtn.Enabled = false;
            byte[] StringToDecript = fileToDecrypt;
            byte[] DecriptKey = Encoding.Default.GetBytes(EnterDecriptKey.Text);
            CriptoClass criptoClass = new CriptoClass();
            byte[] DecryptedText = criptoClass.GrasshopperDecript(StringToDecript, DecriptKey);
            File.WriteAllBytes(Decript_SaveDir_File, DecryptedText);
            for(int i = 0; i < 100; i++) {
                DecriptFileProgressBar.Value += 1;
                DelayFunction2(10);
            }
            DecriptFileProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Blocks;
            DecriptFileProgressBar.Value = 0;
            DecriptFileProgressBar.Visible = true;
            DecriptGeneralBtn.Text = Temp_Btn_value;
            label8.Visible = true;
            panel2.Visible = true;
            DecryptedFileNameLabel.Text = RemoveEncryptEx(Path.GetFileName(Decript_SaveDir_File));
            DecryptedFileNameLabel.Visible = true;
            OpenDecryptedSelectPatch.Visible = true;
            SelectDecriptFileBtn.Enabled = true;
            DecriptGeneralBtn.Enabled = true;
            EnterDecriptKey.Enabled = true;

            SelectSaveFiletoDecriptBtn.Enabled = true;
            MessageBox.Show("Файл успешно расшифрован", "Информация", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void button5_Click(object sender, EventArgs e) {
            OpenFileInExplorer(Decript_SaveDir_File);
        }

        private static string RemoveEncryptEx(string str) {
            
            string result = "";
            string[] parts = str.Split(".encrypted".ToCharArray());
            for(int i = 0; i < parts.Length; i++) {
                int indexYear = parts[i].IndexOf(".encrypted");
                if(indexYear == -1) {
                    result = result + parts[i];
                } else {
                    result = result + parts[i].Substring(0, indexYear + 2);
                }
            }
            return result;
        }

        private void label9_Click(object sender, EventArgs e) {

        }
    }
}
