using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ConvertNumberToWords
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IConvertNumberToWords" in both code and config file together.
    [ServiceContract]
    public interface IConvertNumberToWords
    {
        [OperationContract ]
        string ConvertToWords(decimal Number);
    }
}
