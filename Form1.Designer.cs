using dialogNote.Properties;
using System;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dialogNote
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            //this.button1 = new System.Windows.Forms.Button();
            //this.button2 = new System.Windows.Forms.Button();
            //this.button3 = new System.Windows.Forms.Button();
            //this.button3 = new System.Windows.Forms.Button();
            //this.button4 = new System.Windows.Forms.Button();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 310);
            this.textBox1.TabIndex = 0;
            //// 
            //// button1
            //// 
            //this.button1.Location = new System.Drawing.Point(12, 12);
            //this.button1.Name = "button1";
            //this.button1.Size = new System.Drawing.Size(75, 48);
            //this.button1.TabIndex = 1;
            //this.button1.Text = string.Empty;
            //this.button1.Image = Image.FromFile("C:\\Users\\Pavel\\Desktop\\f803e165-87f2-4173-b6cf-aa4c5f556797.png").GetThumbnailImage(40, 40, null, IntPtr.Zero);
            //this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += Button1_Click;
            //// 
            //// button2
            //// 
            //this.button2.Location = new System.Drawing.Point(93, 11);
            //this.button2.Name = "button2";
            //this.button2.Size = new System.Drawing.Size(75, 49);
            //this.button2.TabIndex = 2;
            //this.button2.Text = string.Empty;
            //this.button2.Image = Image.FromFile("C:\\Users\\Pavel\\Desktop\\MicrosoftTeams-image.png").GetThumbnailImage(40, 40, null, IntPtr.Zero);
            //this.button2.UseVisualStyleBackColor = true;
            //this.button2.Click += Button2_Click;
            //// 
            //// button3
            //// 

            //this.button3.Location = new System.Drawing.Point(174, 12);
            //this.button3.Name = "button3";
            //this.button3.Size = new System.Drawing.Size(75, 49);
            //this.button3.TabIndex = 2;
            //this.button3.Text = string.Empty;
            //this.button3.Image = Image.FromFile("C:\\Users\\Pavel\\Desktop\\—Pngtree—printer icon_5105608.png").GetThumbnailImage(40, 40, null, IntPtr.Zero);
            //this.button3.UseVisualStyleBackColor = true;
            //this.button3.Click += Button3_Click;
            //// 
            //// button4
            //// 

            //this.button4.Location = new System.Drawing.Point(255, 12);
            //this.button4.Name = "button4";
            //this.button4.Size = new System.Drawing.Size(75, 49);
            //this.button4.TabIndex = 2;
            //this.button4.Text = string.Empty;
            //this.button4.Image = Image.FromFile("C:\\Users\\Pavel\\Desktop\\color-palette.png").GetThumbnailImage(40, 40, null, IntPtr.Zero);
            //this.button4.UseVisualStyleBackColor = true;
            //this.button4.Click += Button4_Click;

            menu = new MenuStrip();
            ToolStripMenuItem fileItem = new ToolStripMenuItem();
            fileItem.ShowShortcutKeys = true;
            fileItem.Text = "File";
            fileItem.DropDownItems.Add(new ToolStripMenuItem("Save", null, new EventHandler((s, e) => Button1_Click())) { ShortcutKeys = Keys.Control | Keys.N });
            fileItem.DropDownItems.Add(new ToolStripMenuItem("Open", null, new EventHandler((s, e) => Button2_Click())) { ShortcutKeys = Keys.Control | Keys.O });
            fileItem.DropDownItems.Add(new ToolStripMenuItem("Print", null, new EventHandler((s, e) => Button3_Click())) { ShortcutKeys = Keys.Control | Keys.P });
            fileItem.DropDownItems.Add(new ToolStripSeparator());
            fileItem.DropDownItems.Add(new ToolStripMenuItem("Exit", null, new EventHandler((s, e) => this.Close())));

            ToolStripMenuItem formItem = new ToolStripMenuItem();
            formItem.Text = "Form";
            formItem.DropDownItems.Add(new ToolStripMenuItem("Change color", null, new EventHandler((s, e) => Button4_Click())) { ShortcutKeys = Keys.Control | Keys.F });

            ToolStripComboBox comboBox1 = new ToolStripComboBox();
            comboBox1.Items.Add(new ToolStripMenuItem("Small"));
            comboBox1.Items.Add(new ToolStripMenuItem("Medium"));
            comboBox1.Items.Add(new ToolStripMenuItem("Large"));
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            menu.Items.Add(fileItem);
            menu.Items.Add(formItem);
            menu.Items.Add(comboBox1);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            //this.Controls.Add(this.button2);
            //this.Controls.Add(this.button1);
            //this.Controls.Add(this.button3);
            //this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(menu);
            this.Name = "Form1";
            this.Text = "Note";
            this.Load += Form1_Load;


        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ToolStripComboBox).SelectedIndex == 0)
            {
                this.textBox1.Font = new Font("Times New Roman", 12.0f);
            }
            else if ((sender as ToolStripComboBox).SelectedIndex == 1)
            {
                this.textBox1.Font = new Font("Times New Roman", 14.0f);
            }
            else if ((sender as ToolStripComboBox).SelectedIndex == 2)
            {
                this.textBox1.Font = new Font("Times New Roman", 18.0f);
            }
        }






        //            this.textBox1.Font = new Font("Times New Roman", 18.0f);



        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("bg.txt"))
            {
                int color = int.Parse(File.ReadAllText("bg.txt"));
                this.BackColor = Color.FromArgb(color);
            }  

        }

        private void Button4_Click()
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dialog.Color;
                int color = dialog.Color.ToArgb();
                File.WriteAllText("bg.txt", color.ToString());

            }
        }

        private void Button3_Click()
        {
            PrintDialog dialog = new PrintDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //dialog.Document;
            }
        }

        private void Button1_Click()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "text|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, this.textBox1.Text);
            }
        }

        private void Button2_Click()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "text|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                
                    using (StreamReader reader = new StreamReader(dialog.FileName))
                    {
                        this.textBox1.Text = reader.ReadToEnd();
                    }
                
            }
        }

        #endregion

        System.Windows.Forms.TextBox textBox1;
        MenuStrip menu;
        //Button button1;
        //Button button2;
        //Button button3;
        //Button button4;
    }
}

