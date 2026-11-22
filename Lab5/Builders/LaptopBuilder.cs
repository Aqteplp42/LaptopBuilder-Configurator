
using Lab5.Models;

namespace Lab5.Builders
{
    public abstract class LaptopBuilder
    {
        protected Laptop laptop = new Laptop();

        public int CurrentStep { get; private set; } = 0;

        public const int TotalSteps = 5;

        public void Reset()
        {
            laptop = new Laptop();
            CurrentStep = 0;
        }

        public bool BuildNextStep()
        {
            switch (CurrentStep)
            {
                case 0:
                    BuildCPU();
                    break;

                case 1:
                    BuildGPU();
                    break;

                case 2:
                    BuildRAM();
                    break;

                case 3:
                    BuildStorage();
                    break;

                case 4:
                    BuildBattery();
                    break;

                default:
                    return false;
            }

            CurrentStep++;
            return true;
        }

        public abstract void BuildCPU();
        public abstract void BuildGPU();
        public abstract void BuildRAM();
        public abstract void BuildStorage();
        public abstract void BuildBattery();

        public Laptop GetLaptop()
        {
            return laptop;
        }
    }
}
