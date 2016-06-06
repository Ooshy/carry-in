using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carry_In.Services.Notification
{
    public class PushNotificationService : NotificationService, SystemService
    {
        public PushNotificationService(SystemService systemServices)
        {
            SystemServices = SystemServices;
        }
        public SystemServices SystemServices
        {
            get; private set;
        }

        public void Notify(Notification notification)
        {
           
        }
    }
}
