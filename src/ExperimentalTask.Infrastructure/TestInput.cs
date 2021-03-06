using ExperimentalTask.Domain.Entities;
using ExperimentalTask.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExperimentalTask.Infrastructure
{
    public class TestInput
    {

        public TestInput() { }


        public string FuncCalculation(string request)
        {

            #region Validate and Calculation

            // If Null or Empty
            if (String.IsNullOrEmpty(request))
                return "Incorrect string";

            // Get characters request 
            char[] characters = request.ToCharArray();
            
            // If first char in string equal * / + - . set error
            if (characters[0] == '*' ||
              characters[0] == '/' ||
              characters[0] == '+' ||
              characters[0] == '-' ||
              characters[0] == '.')
                return "Incorrect string";

            // if two . in togOther
            for (int i = 0; i < characters.Count() - 1; i++)
            {
                if (characters[i] == '.' && characters[i + 1] == '.')
                    return "Incorrect string";
            }

            Regex r = new Regex("a|b|c|d|e|f|g|h|i|j|k|l|m|n|o|p|q|r|s|t|u|v|w|x|y|z");
            Regex r2 = new Regex("A|B|C|D|E|F|G|H|I|J|K|L|M|N|O|P|Q|R|S|T|U|V|W|X|Y|Z");

            // Regex r3 = new Regex("@|#|$|%|&|=|!|~|<|>|^");
            Regex r3 = new Regex("@|#|&|!|<|>");


            bool containsAny = r.IsMatch(request);
            bool containsAny2 = r2.IsMatch(request);
            bool containsAny3 = r3.IsMatch(request);

            if (containsAny || containsAny2 || containsAny3)
                return "Incorrect string";


            // Calculation
            StringToRule stringToRule = new StringToRule();
            string value = (stringToRule.computation(request)).ToString();


           // string value = new DataTable().Compute(request, null).ToString();

            #endregion


            #region Insert Database

            AppDbContext context = new AppDbContext();

            Experimental experimental = new Experimental();

            experimental.ExperimentalId = Guid.NewGuid().ToString();
            experimental.Question = request;
            experimental.Answer = value;

            // Add to dataBase
            context.Experimentals.Add(experimental);

            // Save in dataBase
            context.SaveChanges();

            #endregion

            return value;

            #region Last code

            // DataTable dt = new DataTable();
            // var v = dt.Compute(request, "");

            // int number = Int32.Parse(request, NumberStyles.AllowExponent);

            //string math = "100 * 5 - 2";
            //string value = new DataTable().Compute(math, null).ToString();

            //char[] characters = request.ToCharArray();

            //if ((Array.IndexOf(characters, '*') > -1) || (Array.IndexOf(characters, '/') > -1))
            //{
            //    // The x array contains the character c
            //    return 700;
            //}
            //else
            //{
            //    return 800;
            //}


            //  List<int> indexAmalgar = new List<int>();
            ////  List<int> indexZarb = new List<int>();

            //  int index = 0;
            ////  int indexZ = 0;

            //  foreach (var aa in characters)
            //  {

            //      if(aa == '+' || aa == '-' || aa == '*' || aa == '/')
            //      {
            //          indexAmalgar.Add(index);
            //      }

            //      if (aa == '*' || aa == '/')
            //      {
            //         // indexZarb.Add(indexZ);
            //      }

            //      index = index + 1;
            //   //   indexZ = indexZ + 1;
            //  }


            //for(int i =0; i < characters.Count()-1 ; i++)
            //{

            //}


            // string[] splitArray = request.Split('+', '-', '*', '/');

            // List<string> sss = Regex.Split(request, "+-").ToList();

            //foreach (var aa in splitArray)
            //{
            //    var fff = aa;
            //}


            //int cc = Convert.ToInt32(splitArray[0]);



            //for(int i =0; i< indexAmalgar.Count()-1;i++)
            //{
            //    if (characters[i] == '+')
            //    {

            //    }

            //}






            //foreach (int aa in indexAmalgar)
            //{

            //    if (characters[aa] == '+')
            //    {

            //        var eeeeee = indexAmalgar[aa + 1] - 1;

            //        string between = request.Substring(aa+1, indexAmalgar[aa + 1] - 1); //start at char 400, take 30 chars

            //       // var ii = String.Concat(pp);

            //        cc = cc + Convert.ToInt32(between);
            //    }
            //    else if (characters[aa] == '-')
            //    {

            //    }

            //}


            //   return cc;




            //char[] characters = request.ToCharArray();



            //foreach(var aa in characters)
            //{

            //    //if(aa == 'm')
            //    //{

            //    //}





            //}



            // return (4 + (2 * (3 - 1)));

            #endregion

        }




        


    }   
}
