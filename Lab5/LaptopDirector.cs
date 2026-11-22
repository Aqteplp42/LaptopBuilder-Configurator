
using Lab5.Builders;
using Lab5.Models;

namespace Lab5
{
    public class LaptopDirector
    {
        private LaptopBuilder builder;

        public void SetBuilder(LaptopBuilder newBuilder)
        {
            builder = newBuilder;
            builder.Reset();
        }

        public bool BuildNextStep()
        {
            if (builder == null)
                return false;

            return builder.BuildNextStep();
        }

        public void ConstructLaptop()
        {
            if (builder == null)
                return;

            while (builder.BuildNextStep())
            {
            }
        }

        public Laptop GetLaptop()
        {
            return builder?.GetLaptop();
        }

        public int CurrentStep
        {
            get { return builder?.CurrentStep ?? 0; }
        }
    }
}
