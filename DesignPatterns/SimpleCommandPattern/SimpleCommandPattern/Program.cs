using SimpleCommandPattern.Classes;
using SimpleCommandPattern.Classes.Commands;

namespace SimpleCommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of SimpleRemoteControl
            SimpleRemoteControl remote = new SimpleRemoteControl();

            // Create an instance of Light
            Light light = new Light("Living Room");

            // Create an instance of LightOnCommand, providing the Light instance
            LightOnCommand lightOn = new LightOnCommand(light);

            // Create an instance of LightOffCommand, providing the Light instance
            LightOffCommand lightOff = new LightOffCommand(light);

            // Set the command to the LightOnCommand instance
            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();

            // Set the command to the LightOffCommand instance
            remote.SetCommand(lightOff);
            remote.ButtonWasPressed();

            // Without creating another SimpleRemoteControl instance,
            // do the same for the GarageDoorOpenCommand
            GarageDoor garageDoor = new GarageDoor(light);
            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            garageDoorOpen.Execute();

            remote.SetCommand(garageDoorOpen);
            remote.ButtonWasPressed();
        }
    }
}