using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
            Light garageLight = new Light("garage ");
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor(garageLight);
            Stereo stereo = new Stereo();
            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */

            // Define and instantiate an Off and On command for each Vendor class
            Command livingRoomLightOn = new LightOnCommand(livingRoomLight);
            Command livingRoomLightOff = new LightOffCommand(livingRoomLight);

            Command kitchenLightOn = new LightOnCommand(kitchenLight);
            Command kitchenLightOff = new LightOffCommand(kitchenLight);

            Command garageLightOn = new LightOnCommand(garageLight);
            Command garageLightOff = new LightOffCommand(garageLight);

            Command livingRoomCeilingFanMedium = new CeilingFanMediumCommand(livingRoomCeilingFan);
            Command livingRoomCeilingFanLow = new CeilingFanOffCommand(livingRoomCeilingFan);
            Command livingRoomCeilingFanHigh = new CeilingFanHighCommand(livingRoomCeilingFan);
            Command livingRoomCeilingFanOff = new CeilingFanOffCommand(livingRoomCeilingFan);

            Command garageDoorUp = new GarageDoorUpCommand(garageDoor);
            Command garageDoorDown = new GarageDoorDownCommand(garageDoor);

            Command stereoOnWithCD = new StereoOnWithCdCommand(stereo);
            Command stereoOnWithDvd = new StereoOnWithDvdCommand(stereo);
            Command stereoOnWithRadio = new StereoOnWithRadioCommand(stereo);
            Command stereoOff = new StereoOffCommand(stereo);



            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */



            // Test the pressing of Buttons here. Don't forget to test the Undo button
            remoteControl.SetCommand(2, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(3, livingRoomCeilingFanHigh, livingRoomCeilingFanLow);

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);

            remoteControl.OffButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(3);
        }
    }
}