using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static gradecalculator.Subject;

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

        /// <summary>
        /// Get arithmetic mean (average) from list
        /// </summary>
        /// <param name="list"></param>
        /// <returns>arithmetic mean</returns>
        public static double getArithmeticMean(List<Subject.Exam> list)
        {
            double result = 0;

            int percentResult = 0;
            
            foreach (Subject.Exam ex in list)
            {
                result += ex.grade * ex.percentage;
                percentResult += ex.percentage;
            }

            return Math.Round(result/percentResult, 2);
        }

        public static double getAverageOfAllSubjects(List<Subject> subjectList)
        {
            List<Exam> examList = new List<Exam>();

            foreach (Subject subj in subjectList)
            {
                foreach (Exam exam in subj.exames)
                {
                    examList.Add(exam);
                }
            }

            return getArithmeticMean(examList);
        }

        public static double getPlusPoints(List<Subject> subjectList)
        {
            double result = 0;

            foreach (Subject subj in subjectList)
            {
                if (subj.exames.Count == 0)
                    continue;

                double average = getArithmeticMean(subj.exames);
                if (average < 3.75)
                    result += roundToNearestQuarter(average*2) -8;
                else
                    result += roundToNearestQuarter(average) -4;
            }
            return roundToNearestQuarter(result);
        }

        private static double roundToNearestQuarter(double value)
        {
            return Math.Round(value * 2, MidpointRounding.AwayFromZero) / 2;
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
