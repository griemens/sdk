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
    internal class CredentialProvider : vrcontext.walkinside.sdk.IVRCredentialProvider
    {
        public void ConfirmCredential(System.Net.NetworkCredential credential, bool confirmed)
        {
            throw new NotImplementedException();
        }

        public System.Net.NetworkCredential GetCredential(string resourceName)
        {
            throw new NotImplementedException();
        }
    }
}
