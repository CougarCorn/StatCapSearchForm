using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatCapSearchForm
{
    public class StateCapital
    {
        List<string> StateCapList = new List<string>();
        Dictionary<string, string> StateCapDict = new Dictionary<string, string>();

        public StateCapital()
        {
            StreamReader inputFile;

            try
            {
                inputFile = File.OpenText("statecap.txt");
                //skips the header
                inputFile.ReadLine();
                while (!inputFile.EndOfStream)
                {
                    string[] tempstatecap = inputFile.ReadLine().Split(',');
                    StateCapList.Add($"{tempstatecap[0]},{tempstatecap[1]}");
                    StateCapDict.Add(tempstatecap[0], tempstatecap[1]);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Search the List for the capital
        /// </summary>
        /// <param name="state">User input for the state</param>
        /// <returns>Capital based on the user's state</returns>
        public string FindCapitalInList(string state)
        {
            foreach (string sc in StateCapList)
            {
                string[] tempsc = sc.Split(',');
                if (tempsc[0] == state)
                {
                    return tempsc[1];
                }
            }
            return $"Could not find {state} in the database.";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public string FindCapitalInDict(string state)
        {
            if (StateCapDict.TryGetValue(state, out string capital))
            {
                return capital;
            }
            return $"Could not find {state} in the database.";
        }   
    }
}
