using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfWITest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            UnloadWISDK();
            base.OnClosing(e);
        }
        
        #region Winhost loading and unloading
        // The Walkinside SDK instance, give same name as the property VRForm.SDKViewer.
        vrcontext.walkinside.sdk.IVRViewerSdk m_SDKViewer = null;
        public vrcontext.walkinside.sdk.IVRViewerSdk SDKViewer
        {
            get { return m_SDKViewer; }
            set { m_SDKViewer = value; }
        }
        
        private void m_WinFormHost_Loaded(object sender, RoutedEventArgs e)
        {
            // Create the Walkinside control and initialize the SDK.
            string error_string;
            vrcontext.walkinside.sdk.VR3DControl vr3Dcontrol = new vrcontext.walkinside.sdk.VR3DControl();
            var credentialprovider = (vrcontext.walkinside.sdk.IVRCredentialProvider)new CredentialProvider();
            var notificationprovider = (vrcontext.walkinside.sdk.IVRUserNotificationProvider)new UserNotificationProvider();
            SDKViewer = vrcontext.walkinside.sdk.VRViewerSdk.Create(
                null, vr3Dcontrol, (object)null, credentialprovider, notificationprovider, "", out error_string);
            if (error_string != null)
            {
                System.Windows.Forms.MessageBox.Show("Error creating SDKViewer: " + error_string);
            }
            else
            {
                vr3Dcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
                // Do some mocking, to avoid crashes.
                SDKViewer.UI.StatusMessage = new System.Windows.Forms.ToolStripLabel();
                SDKViewer.UI.StatusCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
                SDKViewer.UI.ProgressBar = new System.Windows.Forms.ProgressBar();
                SDKViewer.UI.StatusBar = new System.Windows.Forms.ToolStrip();
                // Do following mocking to allow the databases to load.
                SDKViewer.UI.Menu = new vrcontext.walkinside.sdk.VRMenuStrip();
                SDKViewer.UI.Menu.Items.Add("Database").Name = "VRDatabaseMenu"; // important else plugins can not register themselves.
                string startupproject = vrcontext.walkinside.sdk.VRPath.UserWalkinsideFolder + "/data/startupProject/startup.vrp";
                if (!System.IO.File.Exists(startupproject))
                {
                    System.Windows.Forms.MessageBox.Show("Startup project not found: " + startupproject);
                }
                bool? ok = SDKViewer.ProjectManager.LoadProject(startupproject, out error_string);
                if (ok.GetValueOrDefault(false))
                {
                    // Disable everything that could consume CPU resource when application is idle.
                    SDKViewer.Settings.Navigation.Gravity = false;
                    SDKViewer.Settings.Navigation.Collision = false;
                    SDKViewer.Settings.Navigation.ThirdPerson = false;
                    SDKViewer.Settings.Ocean.Mode = vrcontext.walkinside.sdk.VROceanSettings.VROceanMode.STATIC;
                    SDKViewer.Settings.Skybox.Mode = vrcontext.walkinside.sdk.VRSkyboxSettings.VRSkyType.STATIC;
                    SDKViewer.Settings.GlobalSettings.HighlightingTime = 3f;
                    SDKViewer.Settings.GlobalSettings.TypeOfHighlighting = vrcontext.walkinside.sdk.VRTypeOfHighlighting.VR_HIGHLIGHTING_TIMED;
                    // Enable the navigation module.
                    SDKViewer.PluginManager.Load("plugins/Application/dnSTDNav.dll");
                }
                else
                {
                    if (error_string != null)
                        System.Windows.Forms.MessageBox.Show("Error Loading Startup : " + error_string);
                    else
                        System.Windows.Forms.MessageBox.Show("Error Loading Startup");
                }
                // Add the Walkinside control to the host to get it displayed in the WPF control.
                m_WinFormHost.Child = vr3Dcontrol;
            }
        }

        private void m_WinFormHost_Unloaded(object sender, RoutedEventArgs e)
        {
            UnloadWISDK();
        }

        private void UnloadWISDK()
        {
            // Dispose all the Walkinside SDK related stuff. @todo : should there be any unloading of walkinside projects !
            vrcontext.walkinside.sdk.VR3DControl control = m_WinFormHost.Child as vrcontext.walkinside.sdk.VR3DControl;
            if (control != null)
            {
                control.Dispose();
                m_WinFormHost.Child = null;
                SDKViewer.Dispose();
            }
        }

        #endregion

    }
}
