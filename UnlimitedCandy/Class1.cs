using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Scp330;
using Exiled.Events.Handlers;

namespace UnlimitedCandy
{
    public class Class1 : Plugin<Config>
    {
        public override void OnEnabled()
        {
            Scp330.InteractingScp330 += CandyInteract;
            base.OnEnabled();
        }

        public void CandyInteract(InteractingScp330EventArgs ev)
        {
            Config config = new Config();
            if (config.Max == -1)
            {
                ev.ShouldSever = false;
                ev.IsAllowed = true;
            }
            if (ev.UsageCount < config.Max)
            {
                ev.ShouldSever = false;
                ev.IsAllowed = true;
            }
        }
    }
}
