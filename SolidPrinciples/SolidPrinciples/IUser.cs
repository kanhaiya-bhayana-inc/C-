using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    /* Single Responsibility Principle */

    /* A class should do one thing and therefore it should have only a single responsibility */

    // *********************************************************************************

    interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
    }

    interface ILogger
    {
        void LogError(string error);
    }
    interface IEmail
    {
        bool SendEmail(string email, string messageContent);
    }
}
