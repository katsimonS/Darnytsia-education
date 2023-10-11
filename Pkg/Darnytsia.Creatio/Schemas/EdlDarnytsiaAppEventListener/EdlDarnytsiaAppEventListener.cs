using System;
using Terrasoft.Core;
using Terrasoft.Web.Common;

namespace Terrasoft.Configuration.EdenLab
{
    public class DarnytsiaAppEventListener : AppEventListenerBase
    {
        private Type _programType;
        
        public DarnytsiaAppEventListener()
        {
            _programType = Type.GetType("Darnytsia.Creatio.Program, Darnytsia.Creatio");
        }
        
        public override void OnAppStart(AppEventContext context)
        {
            var appConnection = context.Application["AppConnection"] as AppConnection;
            
            var mainMethod = _programType?.GetMethod("Main");
            mainMethod?.Invoke(null, new object[] { appConnection });
        }
        
        public override void OnAppEnd(AppEventContext context)
        {
            var mainMethod = _programType?.GetMethod("Shutdown");
            mainMethod?.Invoke(null, new object[] { });
        }
    }
    
}
