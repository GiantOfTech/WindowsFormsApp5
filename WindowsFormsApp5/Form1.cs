using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap a1 = null;
        Bitmap a2 = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            for (int i = 4; i < 7; i++)
            {
                int k = 0;
                for (int j = 1; j < i; j++)
                {
                    if (k == 0)
                    {
                        k = (i * j);
                    }
                    k *=  j;
                    switch (i)
                    {
                        case 4:

                            listBox1.Items.Add(k);
                            break;
                        case 5:
                            listBox2.Items.Add(k);
                            break;
                        case 6:
                            listBox3.Items.Add(k);
                            break;
                    }


                }
                k = 0;
            }
            int[][] arr = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                arr[i] = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    switch (j)
                    {
                        case 0:
                            if ((listBox1.Items.Count - 1) < i)
                            {
                                break;
                            }
                            arr[i][j] = Convert.ToInt32(listBox1.Items[i]);
                            break;
                        case 1:
                            if ((listBox2.Items.Count - 1) < i)
                            {
                                break;
                            }
                            arr[i][j] = Convert.ToInt32(listBox2.Items[i]);
                            break;
                        case 2:
                            if ((listBox3.Items.Count - 1) < i)
                            {
                                break;
                            }
                            arr[i][j] = Convert.ToInt32(listBox3.Items[i]);
                            break;
                    }
                }

            }
            for (int i = 0; i < 6; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = arr[i][0];
                dataGridView1.Rows[i].Cells[1].Value = arr[i][1];
                dataGridView1.Rows[i].Cells[2].Value = arr[i][2];
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
            try
            { int G = Convert.ToInt32(dataGridView1.SelectedRows[0].Index);
  textBox1.Text = dataGridView1.Rows[G].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[G].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[G].Cells[2].Value.ToString();
            }
            catch
            {

            }
             

               
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a1 = Properties.Resources.download;
            a2= Properties.Resources.download1;

            if (pictureBox1.Image ==null)
            {
                pictureBox1.Image = Properties.Resources.download;
               
            }
            else if (pictureBox1.Image==a1)
            {
                pictureBox1.Image = a2;

            }
            else
            {
                pictureBox1.Image = a1;
            }
           



        }
    } }

