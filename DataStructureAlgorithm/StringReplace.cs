using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    internal class StringReplace
    {
        public void Validate(string actual, string name)
        {
            string result = actual.Replace("<< name >>", name);
            result.Replace("<< full name >>", name);
            Console.WriteLine(result);
        }
        public void ValidateNumber(string actual, string phoneno)
        {
            string result = actual.Replace("<< contactno >>", phoneno);
            result.Replace("<< contactno >>", phoneno);
            Console.WriteLine(result);
        }
        public void ValidateDate(string actual, string date)
        {
            string result = actual.Replace("<< Date >>", date);
            result.Replace("<< Date >>", date);
            Console.WriteLine(result);
        }
    }
}
