using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Entities
{
   public class User
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Button_Label { get; set; }
        public string LinkPath { get; set; }
        public string PageTitle { get; set; }
        public string TagName { get; set; }
        public string LeftString { get; set; }
        public string RightString { get; set; }
        public string OutputColumnName { get; set; }
        public User Copy()
        {
            var result = new User()
            {
                UserID = this.UserID,
                Password = this.Password,
                Button_Label =this.Button_Label,
                LinkPath = this.LinkPath,
                PageTitle = this.PageTitle,
                TagName = this.TagName,
                LeftString = this.LeftString,
                RightString = this.RightString,
                OutputColumnName = this.OutputColumnName
            };
            return result;
        }
    }
}
