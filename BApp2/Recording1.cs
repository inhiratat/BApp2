﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace BApp2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("316e4ca6-9fba-4d68-bd1c-73b694850492", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BApp2Repository repository.
        /// </summary>
        public static BApp2Repository repo = BApp2Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
            Usuario = "";
            Contrasena = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Usuario;

        /// <summary>
        /// Gets or sets the value of variable Usuario.
        /// </summary>
        [TestVariable("bb9e6cdb-1bd6-4201-bfc0-c5ec3f211936")]
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        string _Contrasena;

        /// <summary>
        /// Gets or sets the value of variable Contrasena.
        /// </summary>
        [TestVariable("b6a4b33f-1d20-4aff-a563-243c37b577ab")]
        public string Contrasena
        {
            get { return _Contrasena; }
            set { _Contrasena = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run mobile app 'com.thebapp.android' on device 'USB-ZY223S395C'.", new RecordItemIndex(0));
            Host.Local.RunMobileApp("USB-ZY223S395C", "com.thebapp.android", true);
            Delay.Milliseconds(3500);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ComThebappAndroid.IndexHtml.TxtUsuario'", repo.ComThebappAndroid.IndexHtml.TxtUsuarioInfo, new ActionTimeout(10000), new RecordItemIndex(1));
            repo.ComThebappAndroid.IndexHtml.TxtUsuarioInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$Usuario' on item 'ComThebappAndroid.IndexHtml.TxtUsuario'.", repo.ComThebappAndroid.IndexHtml.TxtUsuarioInfo, new RecordItemIndex(2));
            repo.ComThebappAndroid.IndexHtml.TxtUsuario.Element.SetAttributeValue("Value", Usuario);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Value' to equal the specified value $Usuario. Associated repository item: 'ComThebappAndroid.IndexHtml.TxtUsuario'", repo.ComThebappAndroid.IndexHtml.TxtUsuarioInfo, new RecordItemIndex(3));
            //repo.ComThebappAndroid.IndexHtml.TxtUsuarioInfo.WaitForAttributeEqual(5000, "Value", Usuario);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComThebappAndroid.IndexHtml.RdbUs' at Center", repo.ComThebappAndroid.IndexHtml.RdbUsInfo, new RecordItemIndex(4));
            repo.ComThebappAndroid.IndexHtml.RdbUs.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ComThebappAndroid.IndexHtml.TxtPassword'", repo.ComThebappAndroid.IndexHtml.TxtPasswordInfo, new ActionTimeout(10000), new RecordItemIndex(5));
            repo.ComThebappAndroid.IndexHtml.TxtPasswordInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$Contrasena' on item 'ComThebappAndroid.IndexHtml.TxtPassword'.", repo.ComThebappAndroid.IndexHtml.TxtPasswordInfo, new RecordItemIndex(6));
            repo.ComThebappAndroid.IndexHtml.TxtPassword.Element.SetAttributeValue("Value", Contrasena);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Value' to equal the specified value $Contrasena. Associated repository item: 'ComThebappAndroid.IndexHtml.TxtPassword'", repo.ComThebappAndroid.IndexHtml.TxtPasswordInfo, new RecordItemIndex(7));
            //repo.ComThebappAndroid.IndexHtml.TxtPasswordInfo.WaitForAttributeEqual(5000, "Value", Contrasena);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComThebappAndroid.IndexHtml.RdbUs' at Center", repo.ComThebappAndroid.IndexHtml.RdbUsInfo, new RecordItemIndex(8));
            repo.ComThebappAndroid.IndexHtml.RdbUs.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ComThebappAndroid.IndexHtml.SIGNIN'", repo.ComThebappAndroid.IndexHtml.SIGNINInfo, new ActionTimeout(10000), new RecordItemIndex(9));
            repo.ComThebappAndroid.IndexHtml.SIGNINInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComThebappAndroid.IndexHtml.SIGNIN' at Center", repo.ComThebappAndroid.IndexHtml.SIGNINInfo, new RecordItemIndex(10));
            repo.ComThebappAndroid.IndexHtml.SIGNIN.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ComThebappAndroid.VISITS'.", repo.ComThebappAndroid.VISITSInfo, new RecordItemIndex(11));
            Validate.Exists(repo.ComThebappAndroid.VISITSInfo);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ComThebappAndroid.SignOut'", repo.ComThebappAndroid.SignOutInfo, new ActionTimeout(10000), new RecordItemIndex(12));
            //repo.ComThebappAndroid.SignOutInfo.WaitForExists(10000);
            
            //Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComThebappAndroid.SignOut' at Center", repo.ComThebappAndroid.SignOutInfo, new RecordItemIndex(13));
            //repo.ComThebappAndroid.SignOut.Touch();
            //Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'ComThebappAndroid'.", repo.ComThebappAndroid.SelfInfo, new RecordItemIndex(14));
            repo.ComThebappAndroid.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
