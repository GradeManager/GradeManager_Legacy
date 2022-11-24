using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradecalculator
{
    internal class MSKMath
    {
        /// <summary>
        /// Get all doubles from the list who are the closest to the value
        /// </summary>
        /// <param name="value">value</param>
        /// <param name="list">list</param>
        /// <returns>List with the closest values</returns>
        public static List<double> getClosestDouble(double value, List<double> list)
        {
            List<double> result = new List<double>();

            List<valuePair> tempList = new List<valuePair>();

            List<valuePair> lowestVal = new List<valuePair>();

            //Creates a list with all values of the lists, and their distance to the value
            for (int i = 0; i < list.Count; i++)
            {
                double t = Math.Abs(list[i]-value);

                tempList.Add(new valuePair(list[i], t));
            }

            //Takes out the lowest values of the list with the values and their distance to the value
            for (int i = 0; i < tempList.Count; i++)
            {
                if (i == 0)
                    lowestVal.Add(tempList[i]);
                else if (lowestVal[0].value > tempList[i].value)
                {
                    lowestVal.Clear();
                    lowestVal.Add(tempList[i]);
                }
                else if (lowestVal[0].value == tempList[i].value)
                {
                    lowestVal.Add(tempList[i]);
                }
            }
            //Converts valuePair list into double list
            foreach (valuePair val in lowestVal)
            {
                result.Add(val.key);
            }
            return result;
        }
    }

    class valuePair
    {
        public dynamic key { get; set; }
        public dynamic value { get; set; }

        public valuePair(dynamic key, dynamic value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
