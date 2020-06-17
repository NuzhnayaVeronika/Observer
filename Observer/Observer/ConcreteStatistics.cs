using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ConcreteStatistics
        : IStatistics
    {
        private List<IUser> users;

        public ConcreteStatistics()
        {
            users = new List<IUser>();
        }

        public void AddUser(IUser obs)
        {
            users.Add(obs);
        }
        
        public void RemoveUser(IUser obs)
        {
            users.Remove(obs);
        }
        
        public void NotifyUsers()
        {
            foreach (IUser observer in users)
                observer.Update();
        }
    }
}