
namespace Lab5.Builders
{
    public class GamingLaptopBuilder : LaptopBuilder
    {
        public override void BuildCPU()
        {
            laptop.CPU = "Intel Core i7-14700HX";
        }

        public override void BuildGPU()
        {
            laptop.GPU = "NVIDIA GeForce RTX 4070";
        }

        public override void BuildRAM()
        {
            laptop.RAM = "32 GB DDR5";
        }

        public override void BuildStorage()
        {
            laptop.Storage = "1 TB NVMe SSD";
        }

        public override void BuildBattery()
        {
            laptop.Battery = "90 Wh";
        }
    }
}
