#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.WebUI;
using FTOptix.CoreBase;
using FTOptix.Alarm;
using FTOptix.Recipe;
using FTOptix.DataLogger;
using FTOptix.EventLogger;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.Retentivity;
using FTOptix.Core;
using System.Buffers;
#endregion

public class RuntimeNetLogic2 : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]
    public void Addition()

    {
        
        var Num01 = Owner.Get<SpinBox>("SpinBox6");
        var Num02 = Owner.Get<SpinBox>("SpinBox7");
        var Num03 = Owner.Get<SpinBox>("SpinBox8");
        Num03.Value = Num01.Value + Num02.Value;
    }
    
    [ExportMethod]
    public void Subtraction()

    {
        
        var Num01 = Owner.Get<SpinBox>("SpinBox6");
        var Num02 = Owner.Get<SpinBox>("SpinBox7");
        var Num03 = Owner.Get<SpinBox>("SpinBox8");
        Num03.Value = Num01.Value - Num02.Value;
    }

    [ExportMethod]
    public void Multipication()

    {
        
        var Num01 = Owner.Get<SpinBox>("SpinBox6");
        var Num02 = Owner.Get<SpinBox>("SpinBox7");
        var Num03 = Owner.Get<SpinBox>("SpinBox8");
        Num03.Value = Num01.Value * Num02.Value;
    }
    
    [ExportMethod]
    public void Division()

    {
        
        var Num01 = Owner.Get<SpinBox>("SpinBox6");
        var Num02 = Owner.Get<SpinBox>("SpinBox7");
        var Num03 = Owner.Get<SpinBox>("SpinBox8");
        Num03.Value = Num01.Value / Num02.Value;
    }
}
