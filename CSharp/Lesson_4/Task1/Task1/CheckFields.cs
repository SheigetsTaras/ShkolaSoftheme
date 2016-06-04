using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Task1
{
    class CheckFields
    {
        enum errorList
        {
            Ok = 1,
            BadLastName = 2,
            BadFirstName = 3,
            BadDayOfBirth = 4,
            BadEMail = 5,
            BadPhoneNumber = 6,
            BadAdditional = 7
        }

        public bool CheckField(string firstName, string lastName, string birthday, string mail, string number, string additional)
        {
            if ((CheckFirstName(firstName)) == errorList.Ok.ToString() && (CheckLastName(lastName)) == errorList.Ok.ToString() && (CheckDateOfBirth(birthday)) == errorList.Ok.ToString() && (CheckEMail((mail)) == errorList.Ok.ToString() && (CheckPhoneNumber(number)) == errorList.Ok.ToString()) && (CheckAdditionalInfo(additional)) == errorList.Ok.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private string CheckFirstName(string name)
        {
            if (name.Length < 255 && name.Length != Regex.Matches(name, "[A-Za-z]").Count)
            {
                return errorList.BadLastName.ToString();
            }
            else
            {
                return errorList.Ok.ToString();
            }
        }

        private string CheckLastName(string name)
        {
            if (name.Length < 255 && name.Length != Regex.Matches(name, "[A-Za-z]").Count)
            {
                return errorList.BadFirstName.ToString();
            }
            else
            {
                return errorList.Ok.ToString();
            }
        }

        private string CheckDateOfBirth(string date)
        {
            string[] stringDate = date.Split(new char[] { '.' });

            try
            {
                DateTime dateOfBirth = new DateTime();
                dateOfBirth = new DateTime(int.Parse(stringDate[2]), int.Parse(stringDate[1]), int.Parse(stringDate[0]));
                if (dateOfBirth < DateTime.Now)
                {
                    return errorList.Ok.ToString();
                }
                else
                {
                    return errorList.BadDayOfBirth.ToString();
                }
            }
            catch (Exception)
            {
                return errorList.BadDayOfBirth.ToString();
            }
        }

        private string CheckEMail(string mail)
        {
            if ((mail.Length < 255 && Regex.Matches(mail, "@").Count != 1))
            {
                return errorList.BadEMail.ToString();
            }
            else
            {
                return errorList.Ok.ToString();
            }
        }

        private string CheckPhoneNumber(string numb)
        {
            if (numb.Length == 12 && Regex.Matches(numb, "[0-9]").Count == numb.Length)
            {
                return errorList.Ok.ToString();
            }
            else
            {
                return errorList.BadPhoneNumber.ToString();
            }

        }

        private string CheckAdditionalInfo(string info)
        {
            if (info.Length < 2000)
            {
                return errorList.Ok.ToString();
            }
            else
            {
                return errorList.BadAdditional.ToString();
            }
        }




    }
}
