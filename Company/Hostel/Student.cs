using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Hostel
{
    public enum Sex { Male, Female }
    public enum FormOfEducation { ochka, zaochka }
    public struct Student
    {
        private string FullName_;
        public string FullName
        {
            get
            {
                return FullName_;
            }
            set
            {
                FullName_ = value.Replace("<center><b><font size=7>", "").Replace("</font></b></center>", "").Replace("\n", "");
            }
        }
        public int group { get; set; }
        public int avgScore { get; set; }
        public double salaryOnFamilyMember { get; set; }
        public Sex sex { get; set; }
        public FormOfEducation formOfEducation { get; set; }
    }
}
