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
        //Use the txt file as a string
        private string filename = "StateCap.txt";

        //Make the Form public to use
        public StateCapForm()
        {
            
            InitializeComponent();
        }
        //create the button
        private void button1_Click(object sender, EventArgs e)
        {
            //create the strings for the states and capitals in the text box
            string userState = StateTxtBox.Text;
            string userCapital = CapitalTxtBox.Text;
            if (userState != "" && userCapital != "")
            {
                try
                {
                    //Add the names to the text box
                    StreamWriter outputFile = File.AppendText(filename);
                    //Concat the state and capital with a comma
                    outputFile.WriteLine($"{userState},{userCapital}");
                    //close the file
                    outputFile.Close();
                    //add the concat string
                    LstBoxStateCap.Items.Add($"{userState},{userCapital}");

                    //clear both the txt boxes
                    CapitalTxtBox.Clear();
                    StateTxtBox.Clear();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }
        
        private void StateCapForm_Load(object sender, EventArgs e)
        {
            //Using StreamReader to try and open a file
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
                    //Seperates the State and Capital by using the comma
                    tempRead = inputfile.ReadLine().Split(',');
                    //Put it into the list box
                    LstBoxStateCap.Items.Add($"{tempRead[0]},{tempRead[1]}");
                }
                //close the file that was opened
                inputfile.Close();
            }
            catch (Exception ex)
            {
                //show them the messages when they are finished
                MessageBox.Show(ex.Message);
            }
              
           
        }
    }
}
