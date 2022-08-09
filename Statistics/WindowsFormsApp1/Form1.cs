using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        //data storage
        private int[] rawData;
        private int[] sortedData;
        private int size, lowerLimit, upperLimit;
        
        public MainForm()
        {
            InitializeComponent();
        }

        


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            size = int.Parse(txtSize.Text);
            lowerLimit = int.Parse(txtLower.Text);
            upperLimit = int.Parse(txtUpper.Text);

            //allocate
            rawData = new int[size];
            sortedData = new int[size];

            //generate data
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                rawData[i] = random.Next(lowerLimit, upperLimit + 1);
                sortedData[i] = rawData[i];
            }

            SortData();

            //load into lists
            listRaw.Items.Clear();
            listSorted.Items.Clear();
            for (int i = 0; i < size; i++)
            {
                listRaw.Items.Add(rawData[i]);
                listSorted.Items.Add(sortedData[i]);
            }
        }

        private void SortData()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (sortedData[i] > sortedData[j])
                    {
                        int tmp = sortedData[i];
                        sortedData[i] = sortedData[j];
                        sortedData[j] = tmp;
                    }
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int[] freq = CalculateFrequence();
            
            txtMean.Text = CalcMean().ToString("0.00");
            txtMedian.Text = CalcMedian().ToString("0.00");
            txtMode.Text = CalcMode(freq).ToString("0.00");

            //display the chart
            this.histogramChart.Series.Clear();
            var series = this.histogramChart.Series.Add("Random Variable");

            for (int i = 0; i < freq.Length; i++)
            {
                series.Points.AddXY(i, freq[i]);
            }
        }

        
        private int[] CalculateFrequence()
        {
            int[] freq = new int[upperLimit + 1];

            for (int i = 0; i < size; i++)
            {
                freq[rawData[i]] += 1;
            }
            return freq;
        }

        
        private double CalcMean()
        {
            double sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += rawData[i];
            }
            return sum / size;
        }

        private double CalcMedian()
        {
            double median = 0;
            int mid = 0;

            if (size % 2 == 0)
            {
                mid = size / 2;
                median = (sortedData[mid] + sortedData[mid + 1]) / 2.0;
            }

            else
            {
                mid = size / 2;
                median = sortedData[mid];
            }
            return median;
        }

        private int CalcMode(int[] frequences)
        {
            int max = frequences[0];
            int maxIndex = 0;

            for (int i = 0; i < frequences.Length; i++)
            {
                if (max < frequences[i])
                {
                    max = frequences[i];
                    maxIndex = i;
                }
            }
            return maxIndex; //mode
        }
    }
}
