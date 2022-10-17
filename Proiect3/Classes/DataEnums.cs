using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3.Classes
{
    internal class DataEnums
    {
        public enum Job{
            unemployed,
            services,
            management,
            bluecollar,
            selfemployed,
            technician,
            entrepreneur,
            admin,
            student,
            housemaid,
            retired,
            unknown
        }

        public enum MaritalStatus
        {
            married,
            single,
            divorced
        }

        public enum Education
        {
            primary,
            secondary,
            tertiary,
            unknown
        }

        public enum Default
        {
            no, 
            yes
        }

        public enum Housing
        {
            no,
            yes
        }

        public enum Loan
        {
            no,
            yes
        }

        public enum Contact
        {
            cellular,
            unknown,
            telephone
        }

        public enum Month
        {
            jan, 
            feb,
            mar,
            apr,
            may,
            jun,
            jul,
            aug,
            sep,
            oct,
            nov,
            dec
        }

        public enum PrevoisOutcome
        {
            unknown,
            failure, 
            success,
            other
        }

        public enum Outcome
        {
            no,
            yes
        }
    }
}
