using System;
namespace BridgeDesignPattern
{
    public interface LEDTV
    {
         void SwitchOn();
         void SwitchOff();
         void SetChannel(int channelNumber);
    }
    public class SamsungLedTv : LEDTV
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Samsung TV");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Samsung TV");
        }
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Samsung TV");
        }
    }
    public abstract class AbstractRemoteControl
    {
        protected LEDTV ledTv;
        protected AbstractRemoteControl(LEDTV ledTv)
        {
            this.ledTv = ledTv;
        }
        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }
    public class SamsungRemoteControl : AbstractRemoteControl
    {
        public SamsungRemoteControl(LEDTV ledTv) : base(ledTv)
        {
        }
        
        public override void SwitchOn()
        {
            ledTv.SwitchOn();
        }
        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }
        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SamsungRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
            samsungRemoteControl.SwitchOn();
            samsungRemoteControl.SetChannel(202);
            samsungRemoteControl.SwitchOff();
            
            Console.ReadKey();
        }
    }
}
