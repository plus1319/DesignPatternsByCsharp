using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Command.Sample1;
using Command.Sample2;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 2 
            //IElectronicDevice newDevice = new Television();
            //ICommand onCommand = new TurnTVUp(newDevice);

            //DeviceButton onPressed= new DeviceButton(onCommand);
            //onPressed.Press();
            //onPressed.Press();
            //Console.WriteLine("---------------");
            ////--------------------------------------------------
            //IElectronicDevice theTv = new Television();
            //IElectronicDevice theRadio = new Radio();

            //IList<IElectronicDevice> allDevices= new List<IElectronicDevice>();
            //allDevices.Add(theTv);
            //allDevices.Add(theRadio);

            //ICommand onCommandTurnItOff = new TurnItAllOff(allDevices);

            //DeviceButton turnThemOff = new DeviceButton(onCommandTurnItOff);
            //turnThemOff.Press();
            //Console.WriteLine("--------------- Undo");
            ////undo
            //turnThemOff.Undo();

            //sample 1
            ShutDownCommand shutDownCommand = new ShutDownCommand(new EuropeServer());

            ServerCommandInvoker serverCommandInvoker = new ServerCommandInvoker(shutDownCommand);
            serverCommandInvoker.run();

            Console.ReadKey();
        }
    }
}
