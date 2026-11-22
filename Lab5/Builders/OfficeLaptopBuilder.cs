
namespace Lab5.Builders
{
    public class OfficeLaptopBuilder : LaptopBuilder
    {
        public override void BuildCPU()
        {
            laptop.CPU = "Intel Core i5-13420H";
        }

        public override void BuildGPU()
        {
            laptop.GPU = "Intel UHD Graphics";
        }

        public override void BuildRAM()
        {
            laptop.RAM = "16 GB DDR4";
        }

        public override void BuildStorage()
        {
            laptop.Storage = "512 GB SSD";
        }

        public override void BuildBattery()
        {
            laptop.Battery = "50 Wh";
        }
    }
}
