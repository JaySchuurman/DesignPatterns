using CommandPattern.Classes;
using CommandPattern.Classes.Commands;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            // Create the devices
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            Light garageLight = new Light("Garage");

            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor(garageLight);
            Stereo stereo = new Stereo();

            // Create the commands
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanHighCommand livingRoomCeilingFanOn =
                new CeilingFanHighCommand(livingRoomCeilingFan);
            CeilingFanOffCommand livingRoomCeilingFanOff =
                new CeilingFanOffCommand(livingRoomCeilingFan);

            GarageDoorUpCommand garageDoorOpen = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorClose = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCdCommand stereoOnWithCD = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            // Assign commands to remote control slots
            remoteControl.SetCommand(1, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(2, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(3, livingRoomCeilingFanOn, livingRoomCeilingFanOff);
            remoteControl.SetCommand(4, garageDoorOpen, garageDoorClose);
            remoteControl.SetCommand(5, stereoOnWithCD, stereoOff);

            Console.WriteLine(remoteControl);

            Console.WriteLine("\n Living Room Light");
            remoteControl.OnButtonWasPushed(1);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OffButtonWasPushed(1);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\n Kitchen Light");
            remoteControl.OnButtonWasPushed(2);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OffButtonWasPushed(2);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\n Ceiling Fan");
            remoteControl.OnButtonWasPushed(3);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OffButtonWasPushed(3);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\n Garage Door");
            remoteControl.OnButtonWasPushed(4);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OffButtonWasPushed(4);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\n Stereo");
            remoteControl.OnButtonWasPushed(5);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OffButtonWasPushed(5);
            remoteControl.UndoButtonWasPushed();


            Console.WriteLine("\n Preform Actions ");

            remoteControl.OnButtonWasPushed(1);  
            remoteControl.OnButtonWasPushed(2);  
            remoteControl.OnButtonWasPushed(3);  
            remoteControl.OnButtonWasPushed(5);  

            Console.WriteLine("\n Undo history");

            remoteControl.UndoButtonWasPushed(); 
            remoteControl.UndoButtonWasPushed();   
            remoteControl.UndoButtonWasPushed();   
            remoteControl.UndoButtonWasPushed();   

        }
    }
}