This is a VS2012 project with minimal code required to embed Walkinside 3D control in a WPF application using Walkinside 7.0.

Porting issue: With Walkinside 10.2 the constructor of the 3D control throws an error. 
  Error : Unable to cast object of type 'System.Windows.Threading.DispatcherSynchronizationContext' to type 'System.Windows.Forms.WindowsFormsSynchronizationContext'
  See issue #27: https://github.com/walkinside/sdk/issues/27
  
