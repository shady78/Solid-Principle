using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle.DIP
{
    public class Notification
    {
        private readonly IMessage mailService;

        public Notification(IMessage mailService)
        {
            this.mailService = mailService;
        }

        public void SendGmail() { mailService.Send(); }
        public void SendHotmail() { mailService.Send(); }
    }
}
