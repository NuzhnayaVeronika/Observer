using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IStatistics
    {
        void AddUser(IUser obs);
        void RemoveUser(IUser obs);
        void NotifyUsers();
    }
}