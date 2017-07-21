using System;
using System.Collections.Generic;
using System.Text;

namespace MoibhPlugin
{
    public class PluginEvent
    {
        public bool AtUserLogin()
        {
            return false;
        }
        public void OnUserLogin()
        {

        }
        public bool AtUserLogout()
        {
            return false;
        }
        public void OnUserLogout()
        {

        }
        public bool AtMoibhStart()
        {
            return false;
        }
        public void OnMoibhStart()
        {

        }
        public bool AtMoibhClose()
        {
            return false;
        }
        public void OnMoibhClose()
        {

        }
    }
}
