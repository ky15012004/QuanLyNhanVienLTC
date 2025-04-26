using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectASP01.Models.Request
{
    public class EmployeeRequest
    {
        public int id_224 { get; set; }
        public string Name_224 { get; set; }
        public string email_224 { get; set; }
        public string phone_224 { get; set; }
        public string position_224 { get; set; }
        public int departmentId_224 { get; set; }

        public EmployeeRequest() { }

        public EmployeeRequest(string Name_224, string email_224, string phone_224, string position_224, int departmentId_224)
        {
            this.Name_224 = Name_224;
            this.email_224 = email_224;
            this.phone_224 = phone_224;
            this.position_224 = position_224;
            this.departmentId_224 = departmentId_224;
        }
    }
}