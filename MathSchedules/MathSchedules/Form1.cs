using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace MathSchedules
{
    public partial class Form1Opt : Form
    {
        public Form1Opt()
        {
            InitializeComponent();

            buttonExit.Click += ButtonExit_Click;
            buttonOpen.Click += ButtonOpen_Click;
            buttonCancel.Click += ButtonCancel_Click;
            buttonCalc.Click += ButtonCalc_Click;
            buttonGen.Click += ButtonGen_Click;
            buttonSave.Click += ButtonSave_Click;
            buttonTestload.Click += ButtonTest_Click;

        }

        public int[,] schedule;

        void ButtonTest_Click(object sender, EventArgs e)
        {
            textBoxHeight.Text=Convert.ToString(10);
            textBoxLenght.Text = Convert.ToString(10);
            LoaderParameters.LoadParams(out schedule);
            textBoxHeight.Enabled = false;
            textBoxLenght.Enabled = false;
            buttonGen.Enabled = false;
            buttonCalc.Enabled = true;
            buttonOpen.Enabled = false;
            buttonSave.Enabled = true;
            buttonExit.Enabled = false;
            buttonExit.Visible = false;
            buttonCancel.Enabled = true;
            buttonCancel.Visible = true;
            buttonTestload.Enabled = false;
            touchFileLable.Text = "тестовый";
        }

        void ButtonGen_Click(object sender, EventArgs e)
        {
            touchFileLable.Text = "случайная";
            int x;
            if ( !int.TryParse( textBoxLenght.Text, out x))
            {
                textBoxLenght.Text = Convert.ToString(5);
            }
            if ( !int.TryParse(textBoxHeight.Text, out x))
            {
                textBoxHeight.Text = Convert.ToString(5);
            }
            int n = Convert.ToInt32(textBoxHeight.Text);
            int m = Convert.ToInt32(textBoxLenght.Text);
            textBoxHeight.Enabled = false;
            textBoxLenght.Enabled = false;
            buttonOpen.Enabled = false;
            buttonGen.Enabled = false;
            buttonTestload.Enabled = false;
            buttonExit.Enabled = false;
            buttonExit.Visible = false;
            buttonSave.Enabled = true;
            buttonCancel.Visible = true;
            buttonCancel.Enabled = true;
            schedule = null;
            LoaderParameters.LoadParams(m, n, 2, out schedule);
            buttonCalc.Enabled = true;
        }

        void ButtonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Не выбрано место сохранения");
            }
            string filename = saveFileDialog.FileName;
            StreamWriter file = new StreamWriter(filename);
            file.WriteLine("start schedule");
            string str = null;
            for (int j = 0; j < schedule.GetLength(1); j++)
            {
                for(int i = 0; i < schedule.GetLength(0); i++)
                {
                    str += schedule[i, j].ToString() + ' ';
                }
                str = str.Trim();
                file.WriteLine(str);
                str = null;
            }
            file.WriteLine("###");
            file.Close();
        }

        void ButtonCalc_Click(object sender, EventArgs e)
        {
            
        }

        void ButtonCancel_Click(object sender, EventArgs e)
        {
            touchFileLable.Text = "";
            textBoxHeight.Enabled = true;
            textBoxLenght.Enabled = true;
            buttonGen.Enabled = true;
            buttonTestload.Enabled = true;
            buttonOpen.Enabled = true;
            buttonSave.Enabled = false;
            buttonExit.Enabled = true;
            buttonExit.Visible = true;
            buttonCancel.Visible = false;
            buttonCancel.Enabled = false;
            buttonCalc.Enabled = false;
            backgroundWorkerCalc.CancelAsync();
        }

        void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void ButtonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                touchFileLable.Text = "Файл не выбран";
                textBoxHeight.Enabled = true;
                textBoxLenght.Enabled = true;
                buttonGen.Enabled = true;
                buttonTestload.Enabled = true;
                buttonExit.Enabled = true;
                buttonExit.Visible = true;
                buttonCancel.Visible = false;
                buttonCancel.Enabled = false;
                return;
            }
            int m, n;
            string filename = openFileDialog.FileName;
            touchFileLable.Text = filename;
            textBoxHeight.Enabled = false;
            textBoxLenght.Enabled = false;
            buttonGen.Enabled = false;
            buttonTestload.Enabled = false;
            buttonExit.Enabled = false;
            buttonExit.Visible = false;
            buttonCancel.Visible = true;
            buttonCancel.Enabled = true;
            LoaderParameters.LoadParams(filename, out schedule, out m, out n);
            string str = Convert.ToString(m);
            textBoxLenght.Text = str;
            str = Convert.ToString(n);
            textBoxHeight.Text = str;
            buttonCalc.Enabled = true;
        }

    }

    class LoaderParameters  //Перегружаемый класс загрузки параметров
    {
        public static void LoadParams(int m, int n, int z, out int[,] massive) //Загрузка рандомной матрицы выбранного размера
        {
            massive = new int[m,n];
            System.DateTime time = new System.DateTime();
            Random rnd = new Random(time.Millisecond);
            for (int i=0; i<m; i++)
            {
                for(int j=0; j<n; j++)
                {
                    massive[i, j] = rnd.Next(1, 100);
                }
            }
            return;
        }

        public static void LoadParams(string filename, out int[,] massive, out int m, out int n) //Загрузка матрицы взятой из файла, !!!Файл должен быть правильно написан!!!
        {
            StreamReader ReadFile = File.OpenText(filename);
            string Input = null;
            string[] line = new string[1];
            bool check, error;
            check = error = false;
            m = n = 0;
            while ((Input = ReadFile.ReadLine()) != null)
            {
                if (Input == "###")
                {
                    check = false;
                }
                if (check)
                {
                    n = Input.Split(' ').Length;
                    m++;
                    
                }
                if (Input == "start schedule")
                {
                    check = true;
                }
            }
            check = false;
            ReadFile.Close();
            massive = new int[m, n];
            string[][] point = new string[m][];
            m = 0;
            ReadFile = File.OpenText(filename);
            while ((Input = ReadFile.ReadLine()) != null)
            {
                if (Input == "###")
                {
                    check = false;
                }
                if (check)
                {
                    point[m] = Input.Split(' ');
                    m++;
                }
                if (Input == "start schedule")
                {
                    check = true;
                }
            }
            for(int i=0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    massive[i, j] = Convert.ToInt32(point[i][j]);
                }
            }
            return;
        }

        public static void LoadParams(out int[,] massive) //Загрузка фиксированной матрицы
        {
            massive = new int[10, 10];
            massive[0, 0] = 88;
            massive[0, 1] = 79;
            massive[0, 2] = 26;
            massive[0, 3] = 62;
            massive[0, 4] = 72;
            massive[0, 5] = 63;
            massive[0, 6] = 67;
            massive[0, 7] = 57;
            massive[0, 8] = 2;
            massive[0, 9] = 82;
            massive[1, 0] = 72;
            massive[1, 1] = 30;
            massive[1, 2] = 55;
            massive[1, 3] = 58;
            massive[1, 4] = 47;
            massive[1, 5] = 81;
            massive[1, 6] = 14;
            massive[1, 7] = 65;
            massive[1, 8] = 23;
            massive[1, 9] = 69;
            massive[2, 0] = 40;
            massive[2, 1] = 43;
            massive[2, 2] = 83;
            massive[2, 3] = 48;
            massive[2, 4] = 47;
            massive[2, 5] = 74;
            massive[2, 6] = 50;
            massive[2, 7] = 67;
            massive[2, 8] = 4;
            massive[2, 9] = 11;
            massive[3, 0] = 82;
            massive[3, 1] = 54;
            massive[3, 2] = 50;
            massive[3, 3] = 61;
            massive[3, 4] = 33;
            massive[3, 5] = 39;
            massive[3, 6] = 68;
            massive[3, 7] = 4;
            massive[3, 8] = 96;
            massive[3, 9] = 98;
            massive[4, 0] = 13;
            massive[4, 1] = 8;
            massive[4, 2] = 26;
            massive[4, 3] = 72;
            massive[4, 4] = 59;
            massive[4, 5] = 76;
            massive[4, 6] = 87;
            massive[4, 7] = 28;
            massive[4, 8] = 93;
            massive[4, 9] = 7;
            massive[5, 0] = 34;
            massive[5, 1] = 74;
            massive[5, 2] = 99;
            massive[5, 3] = 56;
            massive[5, 4] = 32;
            massive[5, 5] = 46;
            massive[5, 6] = 4;
            massive[5, 7] = 11;
            massive[5, 8] = 8;
            massive[5, 9] = 76;
            massive[6, 0] = 86;
            massive[6, 1] = 59;
            massive[6, 2] = 43;
            massive[6, 3] = 30;
            massive[6, 4] = 31;
            massive[6, 5] = 66;
            massive[6, 6] = 36;
            massive[6, 7] = 82;
            massive[6, 8] = 82;
            massive[6, 9] = 78;
            massive[7, 0] = 26;
            massive[7, 1] = 72;
            massive[7, 2] = 1;
            massive[7, 3] = 82;
            massive[7, 4] = 65;
            massive[7, 5] = 10;
            massive[7, 6] = 7;
            massive[7, 7] = 31;
            massive[7, 8] = 84;
            massive[7, 9] = 6;
            massive[8, 0] = 25;
            massive[8, 1] = 65;
            massive[8, 2] = 16;
            massive[8, 3] = 10;
            massive[8, 4] = 3;
            massive[8, 5] = 73;
            massive[8, 6] = 8;
            massive[8, 7] = 88;
            massive[8, 8] = 29;
            massive[8, 9] = 96;
            massive[9, 0] = 90;
            massive[9, 1] = 6;
            massive[9, 2] = 14;
            massive[9, 3] = 80;
            massive[9, 4] = 91;
            massive[9, 5] = 34;
            massive[9, 6] = 40;
            massive[9, 7] = 88;
            massive[9, 8] = 66;
            massive[9, 9] = 36;
            return;
        }
    }
}
