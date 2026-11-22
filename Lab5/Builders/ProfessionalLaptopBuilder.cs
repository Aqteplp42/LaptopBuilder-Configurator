
namespace Lab5.Builders
{
    public class ProfessionalLaptopBuilder : LaptopBuilder
    {
        public override void BuildCPU()
        {
            laptop.CPU = "Intel Core i9-14900HX";
        }

        public override void BuildGPU()
        {
            laptop.GPU = "NVIDIA RTX 4000 Ada";
        }

        public override void BuildRAM()
        {
            laptop.RAM = "64 GB DDR5";
        }

        public override void BuildStorage()
        {
            laptop.Storage = "2 TB NVMe SSD";
        }

        public override void BuildBattery()
        {
            laptop.Battery = "99 Wh";
        }
    }
}
