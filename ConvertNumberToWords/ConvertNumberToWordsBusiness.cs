using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ConvertNumberToWords
{
    public class ConvertNumberToWordsBusiness
    {
        /// <summary>
        /// The method will take double value up to 900000.
        /// We are getting words from enums which are defined for numbers.
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public static string ConvertToWords(decimal Number)
        {

            try
            {
                ///Checking the range and input
                if (!(Number <= 900000 && Number >= 1))
                {
                    return "Out of Range";
                }

                StringBuilder convertedWords = new StringBuilder();

                /// Calculating number positions

                int input = (int)Number;
                //Divide by lack

                int divider = 100000;
                int result = input / divider;
                input = input % divider;
                int resultMultiplier = result * divider;

                string resultString = string.Empty;

                if (result != 0 && input != (int)Number)
                {
                    convertedWords.Append((SingleNumberNames)resultMultiplier).ToString();
                }

                ///Divid by 1000
                divider = 1000;
                result = input / divider;
                input = input % divider;

                ///Check if number is divided properly
                if (result != 0 && input != (int)Number)
                {
                    if (result <= 99 && result > 19)
                    {
                        int remainder = result % 10;

                        convertedWords.Append(string.Format(" {0} {1} {2}",
                            ((SingleNumberNames)result - remainder).ToString() ,
                            ((remainder != 0) ? ((SingleNumberNames)remainder).ToString() : "") ,
                            ((SingleNumberNames)divider).ToString()));
                    }
                    else
                    {

                        convertedWords.Append(string.Format(" {0} {1}",
                            ((SingleNumberNames)result).ToString() ,
                            ((SingleNumberNames)divider).ToString()));
                    }

                }

                divider = 100;
                result = input / divider;
                input = input % divider;

                if (result != 0 && input != (int)Number)
                {
                    convertedWords.Append(string.Format(" {0} {1}",
                        ((SingleNumberNames)result).ToString() ,
                        ((SingleNumberNames)divider).ToString()));

                }
                divider = 10;
                if (input <= 99 && input > 20)
                {
                        int remainder = input % 10;
                        convertedWords.Append(string.Format(" {0} {1} {2}",
                            ((SingleNumberNames)input - remainder).ToString() ,
                            ((remainder != 0) ? ((SingleNumberNames)remainder).ToString() : "")));
                    
                }
                else
                {
                    convertedWords.Append(((SingleNumberNames)input).ToString());
                }

                /// Extracting Decimal part
                /// 
                int decimalPart = (int)(Number - (int)Number) * 100;

                ///Check if number is greater than 20 else fall into 1 to 20 range
                if (decimalPart <= 99 && decimalPart > 20)
                {
                        int remainder = decimalPart % 10;
                        convertedWords.Append(string.Format(" AND {0} {1} {2} CENTS",
                            ((SingleNumberNames)decimalPart - remainder).ToString(),
                            ((remainder != 0) ? ((SingleNumberNames)remainder).ToString() : "")));
                    
                }
                else if(decimalPart>0)
                {
                    convertedWords.Append(string.Format(" AND {0} CENTS",((SingleNumberNames)decimalPart).ToString()));
                }


                return convertedWords.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }

    }

}