
using System;
using System.Windows.Forms;
using Lab5.Builders;
using Lab5.Models;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private LaptopDirector director = new LaptopDirector();
        private LaptopBuilder currentBuilder;

        public Form1()
        {
            InitializeComponent();
        }

        private LaptopBuilder CreateBuilder()
        {
            switch (cmbType.SelectedIndex)
            {
                case 0:
                    return new OfficeLaptopBuilder();

                case 1:
                    return new GamingLaptopBuilder();

                case 2:
                    return new ProfessionalLaptopBuilder();

                default:
                    return null;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Спочатку оберіть тип ноутбука!",
                    "Увага",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            currentBuilder = CreateBuilder();
            director.SetBuilder(currentBuilder);

            tboxLog.Clear();
            tboxResult.Clear();

            tboxLog.AppendText(
                "Початок складання ноутбука...\r\n");

            tboxLog.AppendText(
                "Обрано: " + cmbType.Text + "\r\n\r\n");

            lbStep.Text =
                "Складання розпочато. Виконано 0 із 5 кроків.";

            tboxResult.Text =
                "Очікується завершення складання...";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentBuilder == null)
            {
                MessageBox.Show(
                    "Спочатку натисніть «Почати складання»!",
                    "Увага",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!director.BuildNextStep())
            {
                MessageBox.Show(
                    "Ноутбук уже повністю зібраний!",
                    "Інформація",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            ShowStepResult();
        }

        private void ShowStepResult()
        {
            Laptop laptop = director.GetLaptop();

            int step = director.CurrentStep;

            string stepName = "";

            switch (step)
            {
                case 1:
                    stepName = "Процесор";
                    tboxLog.AppendText(
                        "Встановлено процесор: " + laptop.CPU + "\r\n");
                    break;

                case 2:
                    stepName = "Відеокарта";
                    tboxLog.AppendText(
                        "Встановлено відеокарту: " + laptop.GPU + "\r\n");
                    break;

                case 3:
                    stepName = "Оперативна пам'ять";
                    tboxLog.AppendText(
                        "Встановлено оперативну пам'ять: " + laptop.RAM + "\r\n");
                    break;

                case 4:
                    stepName = "Накопичувач";
                    tboxLog.AppendText(
                        "Встановлено накопичувач: " + laptop.Storage + "\r\n");
                    break;

                case 5:
                    stepName = "Акумулятор";
                    tboxLog.AppendText(
                        "Встановлено акумулятор: " + laptop.Battery + "\r\n");
                    break;
            }

            lbStep.Text =
                "Поточний крок: " + stepName +
                " (" + step + " із 5)";

            if (step == LaptopBuilder.TotalSteps)
            {
                FinishBuild();
            }
        }

        private void FinishBuild()
        {
            Laptop laptop = director.GetLaptop();

            tboxLog.AppendText(
                "\r\nСкладання успішно завершено!\r\n");

            tboxResult.Text = laptop.ShowInfo();

            lbStep.Text =
                "Ноутбук повністю зібраний! Виконано 5 із 5 кроків.";

            MessageBox.Show(
                "Ноутбук успішно зібрано!",
                "Готово",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnBuildAll_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Спочатку оберіть тип ноутбука!",
                    "Увага",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            currentBuilder = CreateBuilder();
            director.SetBuilder(currentBuilder);

            tboxLog.Clear();
            tboxResult.Clear();

            tboxLog.AppendText(
                "Автоматичне складання ноутбука...\r\n");

            tboxLog.AppendText(
                "Обрано: " + cmbType.Text + "\r\n\r\n");

            while (director.BuildNextStep())
            {
                ShowStepResultWithoutMessage();
            }

            FinishBuild();
        }

        private void ShowStepResultWithoutMessage()
        {
            Laptop laptop = director.GetLaptop();

            switch (director.CurrentStep)
            {
                case 1:
                    tboxLog.AppendText(
                        "Встановлено процесор: " + laptop.CPU + "\r\n");
                    break;

                case 2:
                    tboxLog.AppendText(
                        "Встановлено відеокарту: " + laptop.GPU + "\r\n");
                    break;

                case 3:
                    tboxLog.AppendText(
                        "Встановлено оперативну пам'ять: " + laptop.RAM + "\r\n");
                    break;

                case 4:
                    tboxLog.AppendText(
                        "Встановлено накопичувач: " + laptop.Storage + "\r\n");
                    break;

                case 5:
                    tboxLog.AppendText(
                        "Встановлено акумулятор: " + laptop.Battery + "\r\n");
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            currentBuilder = null;

            tboxLog.Clear();
            tboxResult.Clear();

            lbStep.Text =
                "Оберіть тип ноутбука та натисніть «Почати складання»";

            tboxLog.AppendText(
                "Складання скинуто. Очікування нового запуску...");
        }
    }
}
