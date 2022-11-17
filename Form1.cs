using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public string fileName;
        public bool isFileChanged;

        public int fontSize = 0;
        public System.Drawing.FontStyle fs = FontStyle.Regular;

        public FontSettings fontSetts;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            fileName = "";
            isFileChanged = false;
            UpdateTextWithTitle();
        }

        public void CreateNewDocument(object sender, EventArgs e)
        {
            SaveUnsvedFile();
            textBox1.Text = "";
            fileName = "";
            isFileChanged = false;
            UpdateTextWithTitle();
        }

        public void OpenFile(object sender, EventArgs e)
        {
            SaveUnsvedFile();
            openFileDialog1.FileName = "";
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    fileName = openFileDialog1.FileName;
                    isFileChanged = false;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл");
                }
            }
        }

        public void SaveFile(string _fileName)
        {
            if(_fileName == "")
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _fileName = saveFileDialog1.FileName;
                }
            }
            try
            {
                var sw = new System.IO.StreamWriter(saveFileDialog1.FileName, true); //расширение *.txt!!!
                sw.Write(textBox1.Text);
                sw.Close();
                fileName = _fileName;
                isFileChanged = false;
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить файл");
            }
            UpdateTextWithTitle();
        }

        public void Save(object sender, EventArgs e)
        {
            SaveFile(fileName);
        }
        public void SaveAs(object sender, EventArgs e)
        {
            SaveFile("");
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (!isFileChanged)
            {
                this.Text = this.Text.Replace('*', ' ');
                isFileChanged = true;
                this.Text = "*" + this.Text;
            }
        }

        public void UpdateTextWithTitle()
        {
            if (fileName != "")
            {
                this.Text = fileName + " - Блокнот";
            }
            else
            {
                this.Text = "Безымянный - Блокнот";
            }
        }
        
        public void SaveUnsvedFile()
        {
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show("Созранить изменения в файле?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(fileName);
                }
            }   
        }

        public void CopyText()
        {
            Clipboard.SetText(textBox1.SelectedText);
        }

        public void CutText()
        {
            Clipboard.SetText(textBox1.SelectedText);
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
        }
        public void PasteText()
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.SelectionStart) + Clipboard.GetText() + textBox1.Text.Substring(textBox1.SelectionStart, textBox1.Text.Length - textBox1.SelectionStart);
        }

        private void OnCopyClick(object sender, EventArgs e)
        {
            CopyText();
        }
        private void OnCutClick(object sender, EventArgs e)
        {
            CutText();
        }

        private void OnPasteClick(object sender, EventArgs e)
        {
            PasteText();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUnsvedFile();
        }

        private void OnFontClick(object sender, EventArgs e)
        {
            fontSetts = new FontSettings();
            fontSetts.Show();
        }

        private void OnFocus(object sender, EventArgs e)
        {
            if(fontSetts != null)
            {
                fontSize = fontSetts.fontSize;
                fs = fontSetts.fs;
                textBox1.Font = new Font(textBox1.Font.FontFamily, fontSize, fs);
                fontSetts.Close();
            }
        }
    }
}
