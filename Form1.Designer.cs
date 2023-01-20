
namespace Cripto {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TextTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EncriptTextTab = new System.Windows.Forms.TabPage();
            this.Encript_ProgressBar_Text = new System.Windows.Forms.ProgressBar();
            this.ClearEncriptTab = new System.Windows.Forms.Button();
            this.Encript_DecryptedButton = new System.Windows.Forms.Button();
            this.KeyEncriptTab = new System.Windows.Forms.TextBox();
            this.Encript_ButtonEncriptTab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Encript_DecryptedTextLabel = new System.Windows.Forms.Label();
            this.KeyGenerateEncriptTab = new System.Windows.Forms.Button();
            this.TextEncriptTab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Encript_DecryptedText = new System.Windows.Forms.TextBox();
            this.DecriptTextTab = new System.Windows.Forms.TabPage();
            this.Decript_ProgressBar_Text = new System.Windows.Forms.ProgressBar();
            this.ClearDecriptTab = new System.Windows.Forms.Button();
            this.Decript_EncryptedButton = new System.Windows.Forms.Button();
            this.KeyDecriptTab = new System.Windows.Forms.TextBox();
            this.Decript_ButtonEncriptTab = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Decript_EncryptedTextLabel = new System.Windows.Forms.Label();
            this.TextDecriptTab = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DecryptedTextEncriptedTab = new System.Windows.Forms.TextBox();
            this.FileTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Encript_File_GenKey = new System.Windows.Forms.Button();
            this.EncriptFile_key = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EncriptFilePatch = new System.Windows.Forms.TextBox();
            this.Encript_SelectFile = new System.Windows.Forms.Button();
            this.EncriptFile_Progress = new System.Windows.Forms.ProgressBar();
            this.OpenFileDir = new System.Windows.Forms.Button();
            this.EncriptFile_Btn = new System.Windows.Forms.Button();
            this.EncriptFile_SelectSaveDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SettingStab = new System.Windows.Forms.TabPage();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.SelectFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileTxt = new System.Windows.Forms.SaveFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.TextSavedFile_Enc_dir = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.DecriptGeneralBtn = new System.Windows.Forms.Button();
            this.DecriptFileProgressBar = new System.Windows.Forms.ProgressBar();
            this.SelectSaveFiletoDecriptLabel = new System.Windows.Forms.TextBox();
            this.SelectSaveFiletoDecriptBtn = new System.Windows.Forms.Button();
            this.DecryptedFileNameLabel = new System.Windows.Forms.Label();
            this.EnterDecriptKey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SelectDecriptFileLabel = new System.Windows.Forms.TextBox();
            this.SelectDecriptFileBtn = new System.Windows.Forms.Button();
            this.OpenDecryptedSelectPatch = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.DevBy = new System.Windows.Forms.Label();
            this.ShowPass = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.TextTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.EncriptTextTab.SuspendLayout();
            this.DecriptTextTab.SuspendLayout();
            this.FileTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SettingStab.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.TextTab);
            this.TabControl.Controls.Add(this.FileTab);
            this.TabControl.Controls.Add(this.SettingStab);
            this.TabControl.Controls.Add(this.AboutTab);
            this.TabControl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabControl.HotTrack = true;
            this.TabControl.ItemSize = new System.Drawing.Size(123, 25);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(0, 0);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(495, 497);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 0;
            // 
            // TextTab
            // 
            this.TextTab.Controls.Add(this.tabControl1);
            this.TextTab.Location = new System.Drawing.Point(4, 4);
            this.TextTab.Margin = new System.Windows.Forms.Padding(0);
            this.TextTab.Name = "TextTab";
            this.TextTab.Size = new System.Drawing.Size(487, 464);
            this.TextTab.TabIndex = 0;
            this.TextTab.Text = "Текст";
            this.TextTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EncriptTextTab);
            this.tabControl1.Controls.Add(this.DecriptTextTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(487, 464);
            this.tabControl1.TabIndex = 8;
            // 
            // EncriptTextTab
            // 
            this.EncriptTextTab.Controls.Add(this.Encript_ProgressBar_Text);
            this.EncriptTextTab.Controls.Add(this.ClearEncriptTab);
            this.EncriptTextTab.Controls.Add(this.Encript_DecryptedButton);
            this.EncriptTextTab.Controls.Add(this.KeyEncriptTab);
            this.EncriptTextTab.Controls.Add(this.Encript_ButtonEncriptTab);
            this.EncriptTextTab.Controls.Add(this.label1);
            this.EncriptTextTab.Controls.Add(this.Encript_DecryptedTextLabel);
            this.EncriptTextTab.Controls.Add(this.KeyGenerateEncriptTab);
            this.EncriptTextTab.Controls.Add(this.TextEncriptTab);
            this.EncriptTextTab.Controls.Add(this.label2);
            this.EncriptTextTab.Controls.Add(this.Encript_DecryptedText);
            this.EncriptTextTab.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncriptTextTab.Location = new System.Drawing.Point(4, 25);
            this.EncriptTextTab.Name = "EncriptTextTab";
            this.EncriptTextTab.Padding = new System.Windows.Forms.Padding(3);
            this.EncriptTextTab.Size = new System.Drawing.Size(479, 435);
            this.EncriptTextTab.TabIndex = 0;
            this.EncriptTextTab.Text = "Зашифровать";
            this.EncriptTextTab.UseVisualStyleBackColor = true;
            // 
            // Encript_ProgressBar_Text
            // 
            this.Encript_ProgressBar_Text.Location = new System.Drawing.Point(124, 198);
            this.Encript_ProgressBar_Text.MarqueeAnimationSpeed = 25;
            this.Encript_ProgressBar_Text.Name = "Encript_ProgressBar_Text";
            this.Encript_ProgressBar_Text.Size = new System.Drawing.Size(223, 25);
            this.Encript_ProgressBar_Text.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Encript_ProgressBar_Text.TabIndex = 21;
            this.Encript_ProgressBar_Text.Visible = false;
            // 
            // ClearEncriptTab
            // 
            this.ClearEncriptTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearEncriptTab.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearEncriptTab.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearEncriptTab.Location = new System.Drawing.Point(6, 198);
            this.ClearEncriptTab.Name = "ClearEncriptTab";
            this.ClearEncriptTab.Size = new System.Drawing.Size(112, 25);
            this.ClearEncriptTab.TabIndex = 18;
            this.ClearEncriptTab.Text = "Очистить поле";
            this.ClearEncriptTab.UseVisualStyleBackColor = true;
            this.ClearEncriptTab.Click += new System.EventHandler(this.ClearEncriptTab_Click);
            // 
            // Encript_DecryptedButton
            // 
            this.Encript_DecryptedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Encript_DecryptedButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Encript_DecryptedButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encript_DecryptedButton.Location = new System.Drawing.Point(221, 385);
            this.Encript_DecryptedButton.Name = "Encript_DecryptedButton";
            this.Encript_DecryptedButton.Size = new System.Drawing.Size(252, 25);
            this.Encript_DecryptedButton.TabIndex = 17;
            this.Encript_DecryptedButton.Text = "Сохранить зашифрованный текст в файл .txt";
            this.Encript_DecryptedButton.UseVisualStyleBackColor = true;
            this.Encript_DecryptedButton.Click += new System.EventHandler(this.Encript_DecryptedButton_Click);
            // 
            // KeyEncriptTab
            // 
            this.KeyEncriptTab.AllowDrop = true;
            this.KeyEncriptTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyEncriptTab.BackColor = System.Drawing.SystemColors.Window;
            this.KeyEncriptTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyEncriptTab.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyEncriptTab.Location = new System.Drawing.Point(118, 25);
            this.KeyEncriptTab.MaxLength = 32;
            this.KeyEncriptTab.Name = "KeyEncriptTab";
            this.KeyEncriptTab.Size = new System.Drawing.Size(260, 23);
            this.KeyEncriptTab.TabIndex = 10;
            this.KeyEncriptTab.Text = "JOhh#ZiHbKs4GxmnwFf~8G4wEOK8LwEM";
            this.KeyEncriptTab.TextChanged += new System.EventHandler(this.KeyEncriptTab_TextChanged);
            // 
            // Encript_ButtonEncriptTab
            // 
            this.Encript_ButtonEncriptTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Encript_ButtonEncriptTab.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Encript_ButtonEncriptTab.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encript_ButtonEncriptTab.Location = new System.Drawing.Point(353, 198);
            this.Encript_ButtonEncriptTab.Name = "Encript_ButtonEncriptTab";
            this.Encript_ButtonEncriptTab.Size = new System.Drawing.Size(120, 25);
            this.Encript_ButtonEncriptTab.TabIndex = 16;
            this.Encript_ButtonEncriptTab.Text = "Зашифровать текст";
            this.Encript_ButtonEncriptTab.UseVisualStyleBackColor = true;
            this.Encript_ButtonEncriptTab.Click += new System.EventHandler(this.Encript_ButtonEncriptTab_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите ключ:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Encript_DecryptedTextLabel
            // 
            this.Encript_DecryptedTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encript_DecryptedTextLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encript_DecryptedTextLabel.Location = new System.Drawing.Point(0, 236);
            this.Encript_DecryptedTextLabel.Name = "Encript_DecryptedTextLabel";
            this.Encript_DecryptedTextLabel.Size = new System.Drawing.Size(479, 23);
            this.Encript_DecryptedTextLabel.TabIndex = 15;
            this.Encript_DecryptedTextLabel.Text = "Зашифрованный текст";
            this.Encript_DecryptedTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeyGenerateEncriptTab
            // 
            this.KeyGenerateEncriptTab.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.KeyGenerateEncriptTab.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyGenerateEncriptTab.Location = new System.Drawing.Point(384, 24);
            this.KeyGenerateEncriptTab.Name = "KeyGenerateEncriptTab";
            this.KeyGenerateEncriptTab.Size = new System.Drawing.Size(92, 25);
            this.KeyGenerateEncriptTab.TabIndex = 11;
            this.KeyGenerateEncriptTab.Text = "Сгенерировать";
            this.KeyGenerateEncriptTab.UseVisualStyleBackColor = true;
            this.KeyGenerateEncriptTab.Click += new System.EventHandler(this.KeyGenerateEncriptTab_Click);
            // 
            // TextEncriptTab
            // 
            this.TextEncriptTab.AcceptsReturn = true;
            this.TextEncriptTab.AcceptsTab = true;
            this.TextEncriptTab.AllowDrop = true;
            this.TextEncriptTab.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEncriptTab.Location = new System.Drawing.Point(6, 75);
            this.TextEncriptTab.MaxLength = 99999999;
            this.TextEncriptTab.Multiline = true;
            this.TextEncriptTab.Name = "TextEncriptTab";
            this.TextEncriptTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextEncriptTab.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextEncriptTab.Size = new System.Drawing.Size(467, 117);
            this.TextEncriptTab.TabIndex = 14;
            this.TextEncriptTab.Text = "Test Text ";
            this.TextEncriptTab.TextChanged += new System.EventHandler(this.TextEncriptTab_TextChanged);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Текст для шифрации";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Encript_DecryptedText
            // 
            this.Encript_DecryptedText.AcceptsReturn = true;
            this.Encript_DecryptedText.AcceptsTab = true;
            this.Encript_DecryptedText.AllowDrop = true;
            this.Encript_DecryptedText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encript_DecryptedText.Location = new System.Drawing.Point(6, 262);
            this.Encript_DecryptedText.MaxLength = 99999999;
            this.Encript_DecryptedText.Multiline = true;
            this.Encript_DecryptedText.Name = "Encript_DecryptedText";
            this.Encript_DecryptedText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Encript_DecryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Encript_DecryptedText.Size = new System.Drawing.Size(467, 117);
            this.Encript_DecryptedText.TabIndex = 12;
            this.Encript_DecryptedText.Text = "Test Text ";
            this.Encript_DecryptedText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_GotFocus);
            // 
            // DecriptTextTab
            // 
            this.DecriptTextTab.Controls.Add(this.ShowPass);
            this.DecriptTextTab.Controls.Add(this.Decript_ProgressBar_Text);
            this.DecriptTextTab.Controls.Add(this.ClearDecriptTab);
            this.DecriptTextTab.Controls.Add(this.Decript_EncryptedButton);
            this.DecriptTextTab.Controls.Add(this.KeyDecriptTab);
            this.DecriptTextTab.Controls.Add(this.Decript_ButtonEncriptTab);
            this.DecriptTextTab.Controls.Add(this.label4);
            this.DecriptTextTab.Controls.Add(this.Decript_EncryptedTextLabel);
            this.DecriptTextTab.Controls.Add(this.TextDecriptTab);
            this.DecriptTextTab.Controls.Add(this.label6);
            this.DecriptTextTab.Controls.Add(this.DecryptedTextEncriptedTab);
            this.DecriptTextTab.Location = new System.Drawing.Point(4, 25);
            this.DecriptTextTab.Name = "DecriptTextTab";
            this.DecriptTextTab.Padding = new System.Windows.Forms.Padding(3);
            this.DecriptTextTab.Size = new System.Drawing.Size(479, 435);
            this.DecriptTextTab.TabIndex = 1;
            this.DecriptTextTab.Text = "Расшифровать";
            this.DecriptTextTab.UseVisualStyleBackColor = true;
            // 
            // Decript_ProgressBar_Text
            // 
            this.Decript_ProgressBar_Text.Location = new System.Drawing.Point(124, 198);
            this.Decript_ProgressBar_Text.MarqueeAnimationSpeed = 25;
            this.Decript_ProgressBar_Text.Name = "Decript_ProgressBar_Text";
            this.Decript_ProgressBar_Text.Size = new System.Drawing.Size(223, 25);
            this.Decript_ProgressBar_Text.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Decript_ProgressBar_Text.TabIndex = 20;
            this.Decript_ProgressBar_Text.Visible = false;
            // 
            // ClearDecriptTab
            // 
            this.ClearDecriptTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearDecriptTab.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearDecriptTab.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearDecriptTab.Location = new System.Drawing.Point(6, 198);
            this.ClearDecriptTab.Name = "ClearDecriptTab";
            this.ClearDecriptTab.Size = new System.Drawing.Size(112, 25);
            this.ClearDecriptTab.TabIndex = 19;
            this.ClearDecriptTab.Text = "Очистить поле";
            this.ClearDecriptTab.UseVisualStyleBackColor = true;
            this.ClearDecriptTab.Click += new System.EventHandler(this.ClearDecriptTab_Click);
            // 
            // Decript_EncryptedButton
            // 
            this.Decript_EncryptedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Decript_EncryptedButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Decript_EncryptedButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decript_EncryptedButton.Location = new System.Drawing.Point(221, 385);
            this.Decript_EncryptedButton.Name = "Decript_EncryptedButton";
            this.Decript_EncryptedButton.Size = new System.Drawing.Size(252, 25);
            this.Decript_EncryptedButton.TabIndex = 17;
            this.Decript_EncryptedButton.Text = "Сохранить расшифрованный текст в файл .txt";
            this.Decript_EncryptedButton.UseVisualStyleBackColor = true;
            this.Decript_EncryptedButton.Click += new System.EventHandler(this.Decript_EncryptedButton_Click);
            // 
            // KeyDecriptTab
            // 
            this.KeyDecriptTab.AllowDrop = true;
            this.KeyDecriptTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyDecriptTab.BackColor = System.Drawing.SystemColors.Window;
            this.KeyDecriptTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyDecriptTab.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyDecriptTab.Location = new System.Drawing.Point(118, 25);
            this.KeyDecriptTab.MaxLength = 32;
            this.KeyDecriptTab.Name = "KeyDecriptTab";
            this.KeyDecriptTab.Size = new System.Drawing.Size(260, 23);
            this.KeyDecriptTab.TabIndex = 10;
            this.KeyDecriptTab.Text = "JOhh#ZiHbKs4GxmnwFf~8G4wEOK8LwEM";
            this.KeyDecriptTab.TextChanged += new System.EventHandler(this.KeyDecriptTab_TextChanged);
            // 
            // Decript_ButtonEncriptTab
            // 
            this.Decript_ButtonEncriptTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Decript_ButtonEncriptTab.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Decript_ButtonEncriptTab.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decript_ButtonEncriptTab.Location = new System.Drawing.Point(353, 198);
            this.Decript_ButtonEncriptTab.Name = "Decript_ButtonEncriptTab";
            this.Decript_ButtonEncriptTab.Size = new System.Drawing.Size(120, 25);
            this.Decript_ButtonEncriptTab.TabIndex = 16;
            this.Decript_ButtonEncriptTab.Text = "Расшифровать текст";
            this.Decript_ButtonEncriptTab.UseVisualStyleBackColor = true;
            this.Decript_ButtonEncriptTab.Click += new System.EventHandler(this.Decript_ButtonEncriptTab_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите ключ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Decript_EncryptedTextLabel
            // 
            this.Decript_EncryptedTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decript_EncryptedTextLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decript_EncryptedTextLabel.Location = new System.Drawing.Point(0, 236);
            this.Decript_EncryptedTextLabel.Name = "Decript_EncryptedTextLabel";
            this.Decript_EncryptedTextLabel.Size = new System.Drawing.Size(479, 23);
            this.Decript_EncryptedTextLabel.TabIndex = 15;
            this.Decript_EncryptedTextLabel.Text = "Расшифрованный текст";
            this.Decript_EncryptedTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextDecriptTab
            // 
            this.TextDecriptTab.AcceptsReturn = true;
            this.TextDecriptTab.AcceptsTab = true;
            this.TextDecriptTab.AllowDrop = true;
            this.TextDecriptTab.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDecriptTab.Location = new System.Drawing.Point(6, 75);
            this.TextDecriptTab.MaxLength = 99999999;
            this.TextDecriptTab.Multiline = true;
            this.TextDecriptTab.Name = "TextDecriptTab";
            this.TextDecriptTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextDecriptTab.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextDecriptTab.Size = new System.Drawing.Size(467, 117);
            this.TextDecriptTab.TabIndex = 14;
            this.TextDecriptTab.Text = resources.GetString("TextDecriptTab.Text");
            this.TextDecriptTab.TextChanged += new System.EventHandler(this.TextDecriptTab_TextChanged);
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(0, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(479, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Зашифрованный текст";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DecryptedTextEncriptedTab
            // 
            this.DecryptedTextEncriptedTab.AcceptsReturn = true;
            this.DecryptedTextEncriptedTab.AcceptsTab = true;
            this.DecryptedTextEncriptedTab.AllowDrop = true;
            this.DecryptedTextEncriptedTab.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptedTextEncriptedTab.Location = new System.Drawing.Point(6, 262);
            this.DecryptedTextEncriptedTab.MaxLength = 99999999;
            this.DecryptedTextEncriptedTab.Multiline = true;
            this.DecryptedTextEncriptedTab.Name = "DecryptedTextEncriptedTab";
            this.DecryptedTextEncriptedTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DecryptedTextEncriptedTab.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DecryptedTextEncriptedTab.Size = new System.Drawing.Size(467, 117);
            this.DecryptedTextEncriptedTab.TabIndex = 12;
            this.DecryptedTextEncriptedTab.Text = "Test Text ";
            this.DecryptedTextEncriptedTab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_GotFocus);
            // 
            // FileTab
            // 
            this.FileTab.Controls.Add(this.tabControl2);
            this.FileTab.Location = new System.Drawing.Point(4, 4);
            this.FileTab.Margin = new System.Windows.Forms.Padding(0);
            this.FileTab.Name = "FileTab";
            this.FileTab.Size = new System.Drawing.Size(487, 464);
            this.FileTab.TabIndex = 1;
            this.FileTab.Text = "Файл";
            this.FileTab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Padding = new System.Drawing.Point(0, 0);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(487, 464);
            this.tabControl2.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.EncriptFile_Btn);
            this.tabPage1.Controls.Add(this.EncriptFile_Progress);
            this.tabPage1.Controls.Add(this.TextSavedFile_Enc_dir);
            this.tabPage1.Controls.Add(this.EncriptFile_SelectSaveDir);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.Encript_File_GenKey);
            this.tabPage1.Controls.Add(this.EncriptFile_key);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.EncriptFilePatch);
            this.tabPage1.Controls.Add(this.Encript_SelectFile);
            this.tabPage1.Controls.Add(this.OpenFileDir);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(479, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Зашифровать";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Encript_File_GenKey
            // 
            this.Encript_File_GenKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Encript_File_GenKey.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encript_File_GenKey.Location = new System.Drawing.Point(381, 69);
            this.Encript_File_GenKey.Name = "Encript_File_GenKey";
            this.Encript_File_GenKey.Size = new System.Drawing.Size(92, 23);
            this.Encript_File_GenKey.TabIndex = 26;
            this.Encript_File_GenKey.Text = "Сгенерировать";
            this.Encript_File_GenKey.UseVisualStyleBackColor = true;
            this.Encript_File_GenKey.Click += new System.EventHandler(this.Encript_File_GenKey_Click);
            // 
            // EncriptFile_key
            // 
            this.EncriptFile_key.AllowDrop = true;
            this.EncriptFile_key.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncriptFile_key.BackColor = System.Drawing.SystemColors.Window;
            this.EncriptFile_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EncriptFile_key.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncriptFile_key.Location = new System.Drawing.Point(116, 69);
            this.EncriptFile_key.MaxLength = 32;
            this.EncriptFile_key.Name = "EncriptFile_key";
            this.EncriptFile_key.Size = new System.Drawing.Size(260, 23);
            this.EncriptFile_key.TabIndex = 25;
            this.EncriptFile_key.Text = "JOhh#ZiHbKs4GxmnwFf~8G4wEOK8LwEM";
            this.EncriptFile_key.TextChanged += new System.EventHandler(this.EncriptFile_key_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Введите ключ:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EncriptFilePatch
            // 
            this.EncriptFilePatch.AllowDrop = true;
            this.EncriptFilePatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncriptFilePatch.BackColor = System.Drawing.SystemColors.Window;
            this.EncriptFilePatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EncriptFilePatch.Enabled = false;
            this.EncriptFilePatch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncriptFilePatch.Location = new System.Drawing.Point(9, 34);
            this.EncriptFilePatch.MaxLength = 32;
            this.EncriptFilePatch.Name = "EncriptFilePatch";
            this.EncriptFilePatch.ReadOnly = true;
            this.EncriptFilePatch.Size = new System.Drawing.Size(392, 23);
            this.EncriptFilePatch.TabIndex = 23;
            this.EncriptFilePatch.Text = "--- Выберите файл для зашифровки ---";
            this.EncriptFilePatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Encript_SelectFile
            // 
            this.Encript_SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Encript_SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Encript_SelectFile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encript_SelectFile.Location = new System.Drawing.Point(407, 34);
            this.Encript_SelectFile.Name = "Encript_SelectFile";
            this.Encript_SelectFile.Size = new System.Drawing.Size(66, 23);
            this.Encript_SelectFile.TabIndex = 22;
            this.Encript_SelectFile.Text = "Выбрать";
            this.Encript_SelectFile.UseVisualStyleBackColor = true;
            this.Encript_SelectFile.Click += new System.EventHandler(this.Encript_SelectFile_Click);
            // 
            // EncriptFile_Progress
            // 
            this.EncriptFile_Progress.Location = new System.Drawing.Point(205, 127);
            this.EncriptFile_Progress.MarqueeAnimationSpeed = 25;
            this.EncriptFile_Progress.Name = "EncriptFile_Progress";
            this.EncriptFile_Progress.Size = new System.Drawing.Size(268, 25);
            this.EncriptFile_Progress.TabIndex = 21;
            // 
            // OpenFileDir
            // 
            this.OpenFileDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFileDir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OpenFileDir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFileDir.Location = new System.Drawing.Point(9, 404);
            this.OpenFileDir.Name = "OpenFileDir";
            this.OpenFileDir.Size = new System.Drawing.Size(464, 25);
            this.OpenFileDir.TabIndex = 18;
            this.OpenFileDir.Text = "Открыть директорию с файлом";
            this.OpenFileDir.UseVisualStyleBackColor = true;
            this.OpenFileDir.Click += new System.EventHandler(this.OpenFileDir_Click);
            // 
            // EncriptFile_Btn
            // 
            this.EncriptFile_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncriptFile_Btn.Enabled = false;
            this.EncriptFile_Btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EncriptFile_Btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncriptFile_Btn.Location = new System.Drawing.Point(9, 158);
            this.EncriptFile_Btn.Name = "EncriptFile_Btn";
            this.EncriptFile_Btn.Size = new System.Drawing.Size(464, 25);
            this.EncriptFile_Btn.TabIndex = 17;
            this.EncriptFile_Btn.Text = "Зашифровать файл";
            this.EncriptFile_Btn.UseVisualStyleBackColor = true;
            this.EncriptFile_Btn.Click += new System.EventHandler(this.EncriptFile_Btn_Click_1);
            // 
            // EncriptFile_SelectSaveDir
            // 
            this.EncriptFile_SelectSaveDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncriptFile_SelectSaveDir.Enabled = false;
            this.EncriptFile_SelectSaveDir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EncriptFile_SelectSaveDir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncriptFile_SelectSaveDir.Location = new System.Drawing.Point(9, 127);
            this.EncriptFile_SelectSaveDir.Name = "EncriptFile_SelectSaveDir";
            this.EncriptFile_SelectSaveDir.Size = new System.Drawing.Size(190, 25);
            this.EncriptFile_SelectSaveDir.TabIndex = 16;
            this.EncriptFile_SelectSaveDir.Text = "Выбрать место сохранения файла";
            this.EncriptFile_SelectSaveDir.UseVisualStyleBackColor = true;
            this.EncriptFile_SelectSaveDir.Click += new System.EventHandler(this.EncriptFile_Btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выберите файл:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(-1, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(479, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Зашифрованный файл";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // SettingStab
            // 
            this.SettingStab.Controls.Add(this.label9);
            this.SettingStab.Location = new System.Drawing.Point(4, 4);
            this.SettingStab.Margin = new System.Windows.Forms.Padding(0);
            this.SettingStab.Name = "SettingStab";
            this.SettingStab.Size = new System.Drawing.Size(487, 464);
            this.SettingStab.TabIndex = 3;
            this.SettingStab.Text = "Настройки";
            this.SettingStab.UseVisualStyleBackColor = true;
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.DevBy);
            this.AboutTab.Controls.Add(this.panel3);
            this.AboutTab.Location = new System.Drawing.Point(4, 4);
            this.AboutTab.Margin = new System.Windows.Forms.Padding(0);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Size = new System.Drawing.Size(487, 464);
            this.AboutTab.TabIndex = 2;
            this.AboutTab.Text = "О программе";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // SelectFile
            // 
            this.SelectFile.FileName = "SelectFile";
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(0, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(479, 22);
            this.label11.TabIndex = 28;
            this.label11.Text = "Assembly-Sharp.dll.encrypt";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextSavedFile_Enc_dir
            // 
            this.TextSavedFile_Enc_dir.AllowDrop = true;
            this.TextSavedFile_Enc_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextSavedFile_Enc_dir.BackColor = System.Drawing.SystemColors.Window;
            this.TextSavedFile_Enc_dir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSavedFile_Enc_dir.Enabled = false;
            this.TextSavedFile_Enc_dir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSavedFile_Enc_dir.Location = new System.Drawing.Point(9, 98);
            this.TextSavedFile_Enc_dir.MaxLength = 32;
            this.TextSavedFile_Enc_dir.Name = "TextSavedFile_Enc_dir";
            this.TextSavedFile_Enc_dir.ReadOnly = true;
            this.TextSavedFile_Enc_dir.Size = new System.Drawing.Size(464, 23);
            this.TextSavedFile_Enc_dir.TabIndex = 29;
            this.TextSavedFile_Enc_dir.Text = "--- Выберите место сохранения зашифрованного файла ---";
            this.TextSavedFile_Enc_dir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.DecriptGeneralBtn);
            this.tabPage2.Controls.Add(this.DecriptFileProgressBar);
            this.tabPage2.Controls.Add(this.SelectSaveFiletoDecriptLabel);
            this.tabPage2.Controls.Add(this.SelectSaveFiletoDecriptBtn);
            this.tabPage2.Controls.Add(this.DecryptedFileNameLabel);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.EnterDecriptKey);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.SelectDecriptFileLabel);
            this.tabPage2.Controls.Add(this.SelectDecriptFileBtn);
            this.tabPage2.Controls.Add(this.OpenDecryptedSelectPatch);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(479, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расшифровать";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(-1, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(479, 23);
            this.label8.TabIndex = 31;
            this.label8.Text = "Расшифрованный файл";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Visible = false;
            // 
            // DecriptGeneralBtn
            // 
            this.DecriptGeneralBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecriptGeneralBtn.Enabled = false;
            this.DecriptGeneralBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DecriptGeneralBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecriptGeneralBtn.Location = new System.Drawing.Point(9, 157);
            this.DecriptGeneralBtn.Name = "DecriptGeneralBtn";
            this.DecriptGeneralBtn.Size = new System.Drawing.Size(464, 25);
            this.DecriptGeneralBtn.TabIndex = 33;
            this.DecriptGeneralBtn.Text = "Расшифровать файл";
            this.DecriptGeneralBtn.UseVisualStyleBackColor = true;
            this.DecriptGeneralBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DecriptFileProgressBar
            // 
            this.DecriptFileProgressBar.Location = new System.Drawing.Point(205, 126);
            this.DecriptFileProgressBar.MarqueeAnimationSpeed = 25;
            this.DecriptFileProgressBar.Name = "DecriptFileProgressBar";
            this.DecriptFileProgressBar.Size = new System.Drawing.Size(268, 25);
            this.DecriptFileProgressBar.TabIndex = 35;
            // 
            // SelectSaveFiletoDecriptLabel
            // 
            this.SelectSaveFiletoDecriptLabel.AllowDrop = true;
            this.SelectSaveFiletoDecriptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectSaveFiletoDecriptLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SelectSaveFiletoDecriptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectSaveFiletoDecriptLabel.Enabled = false;
            this.SelectSaveFiletoDecriptLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSaveFiletoDecriptLabel.Location = new System.Drawing.Point(9, 97);
            this.SelectSaveFiletoDecriptLabel.MaxLength = 32;
            this.SelectSaveFiletoDecriptLabel.Name = "SelectSaveFiletoDecriptLabel";
            this.SelectSaveFiletoDecriptLabel.ReadOnly = true;
            this.SelectSaveFiletoDecriptLabel.Size = new System.Drawing.Size(464, 23);
            this.SelectSaveFiletoDecriptLabel.TabIndex = 43;
            this.SelectSaveFiletoDecriptLabel.Text = "--- Выберите место сохранения расшифрованного файла ---";
            this.SelectSaveFiletoDecriptLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectSaveFiletoDecriptBtn
            // 
            this.SelectSaveFiletoDecriptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectSaveFiletoDecriptBtn.Enabled = false;
            this.SelectSaveFiletoDecriptBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SelectSaveFiletoDecriptBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectSaveFiletoDecriptBtn.Location = new System.Drawing.Point(9, 126);
            this.SelectSaveFiletoDecriptBtn.Name = "SelectSaveFiletoDecriptBtn";
            this.SelectSaveFiletoDecriptBtn.Size = new System.Drawing.Size(190, 25);
            this.SelectSaveFiletoDecriptBtn.TabIndex = 32;
            this.SelectSaveFiletoDecriptBtn.Text = "Выбрать место сохранения файла";
            this.SelectSaveFiletoDecriptBtn.UseVisualStyleBackColor = true;
            this.SelectSaveFiletoDecriptBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // DecryptedFileNameLabel
            // 
            this.DecryptedFileNameLabel.AutoEllipsis = true;
            this.DecryptedFileNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptedFileNameLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecryptedFileNameLabel.Location = new System.Drawing.Point(0, 378);
            this.DecryptedFileNameLabel.Name = "DecryptedFileNameLabel";
            this.DecryptedFileNameLabel.Size = new System.Drawing.Size(479, 22);
            this.DecryptedFileNameLabel.TabIndex = 42;
            this.DecryptedFileNameLabel.Text = "Assembly-Sharp.dll";
            this.DecryptedFileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DecryptedFileNameLabel.Visible = false;
            // 
            // EnterDecriptKey
            // 
            this.EnterDecriptKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterDecriptKey.BackColor = System.Drawing.SystemColors.Window;
            this.EnterDecriptKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnterDecriptKey.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterDecriptKey.Location = new System.Drawing.Point(116, 68);
            this.EnterDecriptKey.MaxLength = 32;
            this.EnterDecriptKey.Name = "EnterDecriptKey";
            this.EnterDecriptKey.Size = new System.Drawing.Size(260, 23);
            this.EnterDecriptKey.TabIndex = 39;
            this.EnterDecriptKey.Text = "JOhh#ZiHbKs4GxmnwFf~8G4wEOK8LwEM";
            this.EnterDecriptKey.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 23);
            this.label10.TabIndex = 38;
            this.label10.Text = "Введите ключ:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectDecriptFileLabel
            // 
            this.SelectDecriptFileLabel.AllowDrop = true;
            this.SelectDecriptFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectDecriptFileLabel.BackColor = System.Drawing.SystemColors.Window;
            this.SelectDecriptFileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectDecriptFileLabel.Enabled = false;
            this.SelectDecriptFileLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDecriptFileLabel.Location = new System.Drawing.Point(9, 33);
            this.SelectDecriptFileLabel.MaxLength = 32;
            this.SelectDecriptFileLabel.Name = "SelectDecriptFileLabel";
            this.SelectDecriptFileLabel.ReadOnly = true;
            this.SelectDecriptFileLabel.Size = new System.Drawing.Size(392, 23);
            this.SelectDecriptFileLabel.TabIndex = 37;
            this.SelectDecriptFileLabel.Text = "--- Выберите файл для расшифровки ---";
            this.SelectDecriptFileLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectDecriptFileBtn
            // 
            this.SelectDecriptFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectDecriptFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SelectDecriptFileBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectDecriptFileBtn.Location = new System.Drawing.Point(407, 33);
            this.SelectDecriptFileBtn.Name = "SelectDecriptFileBtn";
            this.SelectDecriptFileBtn.Size = new System.Drawing.Size(66, 23);
            this.SelectDecriptFileBtn.TabIndex = 36;
            this.SelectDecriptFileBtn.Text = "Выбрать";
            this.SelectDecriptFileBtn.UseVisualStyleBackColor = true;
            this.SelectDecriptFileBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // OpenDecryptedSelectPatch
            // 
            this.OpenDecryptedSelectPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenDecryptedSelectPatch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OpenDecryptedSelectPatch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenDecryptedSelectPatch.Location = new System.Drawing.Point(9, 403);
            this.OpenDecryptedSelectPatch.Name = "OpenDecryptedSelectPatch";
            this.OpenDecryptedSelectPatch.Size = new System.Drawing.Size(464, 25);
            this.OpenDecryptedSelectPatch.TabIndex = 34;
            this.OpenDecryptedSelectPatch.Text = "Открыть директорию с файлом";
            this.OpenDecryptedSelectPatch.UseVisualStyleBackColor = true;
            this.OpenDecryptedSelectPatch.Visible = false;
            this.OpenDecryptedSelectPatch.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 23);
            this.label12.TabIndex = 30;
            this.label12.Text = "Выберите файл:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DevBy
            // 
            this.DevBy.AutoSize = true;
            this.DevBy.Location = new System.Drawing.Point(184, 5);
            this.DevBy.Name = "DevBy";
            this.DevBy.Size = new System.Drawing.Size(111, 16);
            this.DevBy.TabIndex = 0;
            this.DevBy.Text = "DEV BY VUIT-QA";
            this.DevBy.Click += new System.EventHandler(this.label9_Click);
            // 
            // ShowPass
            // 
            this.ShowPass.BackColor = System.Drawing.Color.White;
            this.ShowPass.BackgroundImage = global::Cripto.Properties.Resources.PassViewOff;
            this.ShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPass.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPass.ForeColor = System.Drawing.Color.Transparent;
            this.ShowPass.Location = new System.Drawing.Point(384, 25);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(23, 23);
            this.ShowPass.TabIndex = 21;
            this.ShowPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ShowPass.UseVisualStyleBackColor = false;
            this.ShowPass.Click += new System.EventHandler(this.ShowPass_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Cripto.Properties.Resources.decrypt_icon_21;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 157);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Cripto.Properties.Resources.decrypt_icon_21;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 157);
            this.panel2.TabIndex = 41;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Cripto.Properties.Resources.Screenshot_1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(11, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 437);
            this.panel3.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(156, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Coming soon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(494, 497);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифрование по ГОСТ Р 34.12 2015 «Кузнечик»";
            this.TabControl.ResumeLayout(false);
            this.TextTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.EncriptTextTab.ResumeLayout(false);
            this.EncriptTextTab.PerformLayout();
            this.DecriptTextTab.ResumeLayout(false);
            this.DecriptTextTab.PerformLayout();
            this.FileTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.SettingStab.ResumeLayout(false);
            this.SettingStab.PerformLayout();
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TextTab;
        private System.Windows.Forms.TabPage FileTab;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.TabPage SettingStab;
        private System.Windows.Forms.OpenFileDialog SelectFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DecriptTextTab;
        private System.Windows.Forms.Button Decript_EncryptedButton;
        private System.Windows.Forms.TextBox KeyDecriptTab;
        private System.Windows.Forms.Button Decript_ButtonEncriptTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Decript_EncryptedTextLabel;
        private System.Windows.Forms.TextBox TextDecriptTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DecryptedTextEncriptedTab;
        private System.Windows.Forms.Button ClearDecriptTab;
        private System.Windows.Forms.ProgressBar Decript_ProgressBar_Text;
        private System.Windows.Forms.SaveFileDialog saveFileTxt;
        private System.Windows.Forms.Button ShowPass;
        private System.Windows.Forms.TabPage EncriptTextTab;
        private System.Windows.Forms.ProgressBar Encript_ProgressBar_Text;
        private System.Windows.Forms.Button ClearEncriptTab;
        private System.Windows.Forms.Button Encript_DecryptedButton;
        private System.Windows.Forms.TextBox KeyEncriptTab;
        private System.Windows.Forms.Button Encript_ButtonEncriptTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Encript_DecryptedTextLabel;
        private System.Windows.Forms.Button KeyGenerateEncriptTab;
        private System.Windows.Forms.TextBox TextEncriptTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Encript_DecryptedText;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Encript_SelectFile;
        private System.Windows.Forms.ProgressBar EncriptFile_Progress;
        private System.Windows.Forms.Button OpenFileDir;
        private System.Windows.Forms.Button EncriptFile_Btn;
        private System.Windows.Forms.Button EncriptFile_SelectSaveDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EncriptFilePatch;
        private System.Windows.Forms.TextBox EncriptFile_key;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Encript_File_GenKey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextSavedFile_Enc_dir;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DecriptGeneralBtn;
        private System.Windows.Forms.ProgressBar DecriptFileProgressBar;
        private System.Windows.Forms.TextBox SelectSaveFiletoDecriptLabel;
        private System.Windows.Forms.Button SelectSaveFiletoDecriptBtn;
        private System.Windows.Forms.Label DecryptedFileNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox EnterDecriptKey;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SelectDecriptFileLabel;
        private System.Windows.Forms.Button SelectDecriptFileBtn;
        private System.Windows.Forms.Button OpenDecryptedSelectPatch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label DevBy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
    }
}

