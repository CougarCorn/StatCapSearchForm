using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatCapSearchForm
{
    public partial class StateCapForm : Form
    {
        //
        private string filename = "StateCap.txt";

        //
        public StateCapForm()
        {
            //
            InitializeComponent();
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            //
            string userState = StateTxtBox.Text;
            string userCapital = CapitalTxtBox.Text;
            if (userState != "" && userCapital != "")
            {
                try
                {
                    //
                    StreamWriter outputFile = File.AppendText(filename);
                    //
                    outputFile.WriteLine($"{userState},{userCapital}");
                    //
                    outputFile.Close();
                    //
                    LstBoxStateCap.Items.Add($"{userState},{userCapital}");

                    CapitalTxtBox.Clear();
                    StateTxtBox.Clear();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }
        //
        private void StateCapForm_Load(object sender, EventArgs e)
        {
            //Usine StreamReader to try and open a file
            StreamReader inputfile;
            string[] tempRead;


            try
            {
                //Load and open the file
                inputfile = File.OpenText(filename);
                //Skip the headers
                inputfile.ReadLine();
                while (!inputfile.EndOfStream)
                {
                    //
                    tempRead = inputfile.ReadLine().Split(',');
                    //Put it into the list box
                    LstBoxStateCap.Items.Add($"{tempRead[0]},{tempRead[1]}");
                }
                //
                inputfile.Close();
            }
            catch (Exception ex)
            {
                //
                MessageBox.Show(ex.Message);
            }
              
            {
                MessageBox.Show("Invalid Input", "Please enter a State and Capital.");
            }
        }
    }
}
