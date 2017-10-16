using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            this.Text = "[New]:" + e.NewValue.ToString() + " [OldValue]:" + e.OldValue.ToString() + " [ScrollOrientation]:" + e.ScrollOrientation.ToString() + " [Type]:" + e.Type.ToString();
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {
            this.Text = "[New]:" + e.NewValue.ToString() + " [OldValue]:" + e.OldValue.ToString() + " [ScrollOrientation]:" + e.ScrollOrientation.ToString() + " [Type]:" + e.Type.ToString();
        }
        int oldCount = 0;
        bool bLoad = false;
        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            
            if (dataGridView1.FirstDisplayedScrollingRowIndex >= dataGridView1.Rows.Count - 50)
            {
                //dataGridView1.Enabled = false;
                MessageBox.Show("加载中...........");
                for (int i = 0; i < 100; i++)
                {
                    dataGridView1.Rows.Add("瀑布流出来的" + i, "bbb" + i);
                }
                //dataGridView1.Enabled = true;
            }
            bLoad = true;
            
            ////if (dataGridView1.FirstDisplayedScrollingRowIndex != oldCount)
            ////{
            //if (!bLoad)
            //{
            //    dataGridView1.Enabled = false;
            //    if (dataGridView1.FirstDisplayedScrollingRowIndex >= dataGridView1.Rows.Count - 50)
            //    {
            //        for (int i = 0; i < 100; i++)
            //        {
            //            dataGridView1.Rows.Add("瀑布流出来的" + i, "bbb" + i);
            //        }
            //    }
            //    bLoad = true;
            //    dataGridView1.Enabled = true;
            //}
            //else
            //{
            //    bLoad = false;
            //}
            ////}
            ////this.Text = "[New]:" + e.NewValue.ToString() + " [OldValue]:" + e.OldValue.ToString() + " [ScrollOrientation]:" + e.ScrollOrientation.ToString() + " [Type]:" + e.Type.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100;i++ )
            {
                dataGridView1.Rows.Add("aaaa" + i, "bbb" + i);
            }
            
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
