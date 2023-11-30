namespace HomeAutomationCORApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeAutomationSetting dto = new HomeAutomationSetting();
            dto.LightsOff = true;
            dto.AlarmsOn = false;
            dto.LocksOn = true;

            LightCheckHandler lights = new LightCheckHandler();
            AlaramCheckHandler alarm = new AlaramCheckHandler();
            LockCheckHandler locks = new LockCheckHandler();

            lights.SucceedWith(alarm);
            alarm.SucceedWith(locks);


            lights.Handle(dto);
            Console.WriteLine("Good bye");
        }
    }
}