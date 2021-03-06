using System.Collections.Generic;
using DigitalInput = EPTS.Models.Devices.SEAMAX.Core.DigitalInput;
using DigitalOutput = EPTS.Models.Devices.SEAMAX.Core.DigitalOutput;

namespace EPTS.Models.Devices.SEAMAX
{
    public class SeaLevel420:SeaMax
    {
        public delegate void SeaLevelDigitalOutputHandler(object sender, DigitalOutput digitalOutput);
        public event SeaLevelDigitalOutputHandler SeaLevelDigitalOutput;

        public delegate void SeaLevelDigitalInputHandler(object sender, DigitalInput digitalInput);
        public event SeaLevelDigitalInputHandler SeaLevelDigitalInput;

        public List<DigitalInput> DigitalInput { get; set; }
        public List<DigitalOutput> DigitalOutput { get; set; }


        public  virtual void OnSeaLevelDigitalOutput(DigitalOutput digitaloutput)
        {
            SeaLevelDigitalOutput?.Invoke(this, digitaloutput);
        }

        public virtual void OnSeaLevelDigitalInput(DigitalInput digitalinput)
        {
            SeaLevelDigitalInput?.Invoke(this, digitalinput);
        }
    }
}