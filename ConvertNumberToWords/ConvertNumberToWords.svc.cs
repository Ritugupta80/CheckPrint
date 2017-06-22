using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ConvertNumberToWords
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ConvertNumberToWords" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ConvertNumberToWords.svc or ConvertNumberToWords.svc.cs at the Solution Explorer and start debugging.
   
    public class ConvertNumberToWords : IConvertNumberToWords
    {
        public string ConvertToWords(decimal Number)
        {
           string convertedWords=
                ConvertNumberToWordsBusiness.ConvertToWords(Number);
            return convertedWords;

        }
    }
}
