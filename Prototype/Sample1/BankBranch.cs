using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Sample1
{
    public class BankBranch
    {
        public string Code { get; set; }
        public string ManagerName { get; set; }

        public BankBranch(string code,string managerName)
        {
            Code = code;
            ManagerName = managerName;
        }

        public BankBranch Clone()
        {
            //this method copy as BankBranch
            return MemberwiseClone() as BankBranch;
        }
    }
}
