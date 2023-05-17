using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassingTests
{
    public partial class TestForm : Form
    {
        static String fileName = "";
        static String text = "";
        string[,] Test = null;
        int [] TestAnswers = null;
        int number = 0;
        String changedName = "";
        int[] TestNumber;
        public TestForm()
        {
            fileName = StartForm.openFileDialog.FileName;
            InitializeComponent();
            text = File.ReadAllText(fileName);
            text = text.Replace("<question>", "#");
            text = text.Replace("<variant>", "`");
            Test = new string[getTestSize(fileName), 6];
            TestNumber = new int[getTestSize(fileName)];
            TestNumber = rundomTest(TestNumber, getTestSize(fileName));
            int i = 0;
            int c = 0;
            int questionNumber = -1;
            while (i < text.Length)
            {
                if (text[i] == '#')
                {
                    questionNumber++;
                    c = 0;
                    i++;
                }
                if (text[i] == '`')
                {
                    c++;
                    i++;
                }
                if (questionNumber < getTestSize(fileName) && c < 6 && i < text.Length)
                {
                    Test[questionNumber, c] += text[i];
                }
                i++;
            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            //radioButton
            if (TestAnswers != null && changedName!="")
            {
                if (TestAnswers[int.Parse(changedName[2].ToString())-1] == 1)
                {
                    CheckButton.BackColor = Color.LightGreen;
                }
                else
                {
                    CheckButton.BackColor = Color.Red;
                }
            }
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            
            if (TestNumber[number] < getTestSize(fileName))
            {
                CheckButton.BackColor = Color.White;
                quetion.Text = "";
                variant1.Text = "";
                variant2.Text = "";
                variant3.Text = "";
                variant4.Text = "";
                variant5.Text = "";
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                TestAnswers = new int[5];
                var rand = new Random();
                var knownNumbers = new HashSet<int>();
                for (int i = 0; i < TestAnswers.Length; i++)
                {
                    int newElement;
                    do
                    {
                        newElement = rand.Next(5);
                    } while (!knownNumbers.Add(newElement));
                    TestAnswers[i] = newElement+1;
                }
                quetion.Text = Test[TestNumber[number], 0];
                variant1.Text = Test[TestNumber[number], TestAnswers[0]];
                variant2.Text = Test[TestNumber[number], TestAnswers[1]];
                variant3.Text = Test[TestNumber[number], TestAnswers[2]];
                variant4.Text = Test[TestNumber[number], TestAnswers[3]];
                variant5.Text = Test[TestNumber[number], TestAnswers[4]];
                number++;
            }
            else
            {
                MessageBox.Show("End!");
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (TestNumber[number] > 0 && number > 0)
            {
                CheckButton.BackColor = Color.White;
                quetion.Text = "";
                variant1.Text = "";
                variant2.Text = "";
                variant3.Text = "";
                variant4.Text = "";
                variant5.Text = "";
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                TestAnswers = new int[5];
                var rand = new Random();
                var knownNumbers = new HashSet<int>();
                for (int i = 0; i < TestAnswers.Length; i++)
                {
                    int newElement;
                    do
                    {
                        newElement = rand.Next(5);
                    } while (!knownNumbers.Add(newElement));
                    TestAnswers[i] = newElement + 1;
                }
                quetion.Text = Test[TestNumber[number], 0];
                variant1.Text = Test[TestNumber[number], TestAnswers[0]];
                variant2.Text = Test[TestNumber[number], TestAnswers[1]];
                variant3.Text = Test[TestNumber[number], TestAnswers[2]];
                variant4.Text = Test[TestNumber[number], TestAnswers[3]];
                variant5.Text = Test[TestNumber[number], TestAnswers[4]];
                number--;
            }
            else
            {
                MessageBox.Show("First quetion");
            }
        }

        int [] rundomTest(int [] TestNumber, int testSize)
        {
            
            var rand = new Random();
            var knownNumbers = new HashSet<int>();
            for (int i = 0; i < TestNumber.Length; i++)
            {
                int newElement;
                do
                {
                    newElement = rand.Next(testSize+1);
                } while (!knownNumbers.Add(newElement));
                TestNumber[i] = newElement;
            }
            for (int i = 0; i < TestNumber.Length; i++)
            {
                Console.WriteLine(TestNumber[i]);
            }
            return TestNumber;
        }

        public void DrawQuetion(ref int[] TestNumber)
        {
            if (TestNumber[number] > 0 && number > 0)
            {
                CheckButton.BackColor = Color.White;
                quetion.Text = "";
                variant1.Text = "";
                variant2.Text = "";
                variant3.Text = "";
                variant4.Text = "";
                variant5.Text = "";
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                rb5.Checked = false;
                TestAnswers = new int[5];
                var rand = new Random();
                var knownNumbers = new HashSet<int>();
                for (int i = 0; i < TestAnswers.Length; i++)
                {
                    int newElement;
                    do
                    {
                        newElement = rand.Next(5);
                    } while (!knownNumbers.Add(newElement));
                    TestAnswers[i] = newElement + 1;
                }
                quetion.Text = Test[TestNumber[number], 0];
                variant1.Text = Test[TestNumber[number], TestAnswers[0]];
                variant2.Text = Test[TestNumber[number], TestAnswers[1]];
                variant3.Text = Test[TestNumber[number], TestAnswers[2]];
                variant4.Text = Test[TestNumber[number], TestAnswers[3]];
                variant5.Text = Test[TestNumber[number], TestAnswers[4]];
                number--;
            }
            else
            {
                MessageBox.Show("First quetion");
            }
        }

        public static int getTestSize(String FileName)
        {
            int amount = new Regex("#").Matches(text).Count;
            return amount;
        }

        public void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    changedName = rb.Name;
                }
            }
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartForm form1 = new StartForm();
            form1.Visible = true;
        }
    }
}
