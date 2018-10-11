using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace ExportsRepro
{
    public class Main : BaseScript
    {
        public Main()
        {
            EventHandlers.Add("onClientMapStart", new Action(OnClientMapStart));
        }

        private void OnClientMapStart()
        {
            Exports["spawnmanager"].setAutoSpawn(true);
            Exports["spawnmanager"].forceRespawn();
        }
    }
}
