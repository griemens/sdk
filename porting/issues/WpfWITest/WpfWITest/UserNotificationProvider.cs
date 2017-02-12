using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfWITest
{
    /// <summary>
    /// A class required by VRViewerSdk.Create.
    /// Will implment the methods when the exceptions are hit.
    /// </summary>
    internal class UserNotificationProvider: vrcontext.walkinside.sdk.IVRUserNotificationProvider
    {
        public bool Confirm(string subject, string body, bool @default)
        {
            throw new NotImplementedException();
        }

        public void Notify(string subject, string body, vrcontext.walkinside.sdk.VRUserNotificationSeverity severity, vrcontext.walkinside.sdk.VRUserNotificationModality modality)
        {
            throw new NotImplementedException();
        }
    }
}
