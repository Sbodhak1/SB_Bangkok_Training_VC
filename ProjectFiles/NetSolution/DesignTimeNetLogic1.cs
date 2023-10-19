#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Alarm;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.WebUI;
using FTOptix.CoreBase;
using FTOptix.Recipe;
using FTOptix.DataLogger;
using FTOptix.EventLogger;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.Retentivity;
using FTOptix.NetLogic;
using FTOptix.Core;
using FTOptix.RAEtherNetIP;
using FTOptix.CommunicationDriver;
#endregion

public class DesignTimeNetLogic1 : BaseNetLogic
{
    [ExportMethod]
    public void SingleVariable()
    {
        // Insert code to be executed by the method
        var myFolder = Project. Current.Get ("Model");
        var myVar = InformationModel. MakeVariable ("MayVariable", OpcUa.DataTypes.Int32);
        myVar.Value = 48;
        myFolder.Add(myVar);

    }

    [ExportMethod]

public void Create100Var()

    {
        for (int i = 0; i < 100; i++)
        {
        var myFolder = Project.Current.Get("Model");
        var myVar = InformationModel.MakeVariable("MyVariable"+ i, OpcUa.DataTypes.Int32);
        myFolder.Add(myVar);
        }

    }
    
    [ExportMethod]
    public void CreateWidget()

    {
        var myBasePanel = InformationModel.Make<Panel>("MyMotorWidget");
        myBasePanel.Width= 300;
        myBasePanel.Height=300;
        var myGauge = InformationModel.Make<CircularGauge>("MotorSpeed");
        myGauge.LeftMargin=50;
        myGauge.RightMargin=50;
    
        myBasePanel.Add(myGauge);
        Project.Current.Get("UI/Template").Add(myBasePanel);

    }
     [ExportMethod]
     public void ChangeValue()
     {
        var MyVar1 = Project.Current.GetVariable("Model/Varable1");
        MyVar1.Value =1;
        Log.Info("Variable 1 Completed");
        var MyVar2 = Project.Current.GetVariable("Model/Variable2");
        MyVar2.Value=2;
          Log.Info("Variable 2 Completed");
          Log.Warning("Warning Message");
          Log.Error("Error Message");

     }
}