using BattleCalculator.Factories;

namespace BattleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int totalCostA = 0, totalCostB = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            AArmyListBox.Items.Add(new ElfFactory());
            AArmyListBox.Items.Add(new DwarfFactory());
            AArmyListBox.Items.Add(new HumanFactory());
            BArmyListBox.Items.Add(new ElfFactory());
            BArmyListBox.Items.Add(new DwarfFactory());
            BArmyListBox.Items.Add(new HumanFactory());
            AArmyListBox.SelectedIndex = 0;
            BArmyListBox.SelectedIndex = 0;
            AInfantryTrackBar.Minimum = 0;
            ACavalryTrackBar.Minimum = 0;
            ASiegeWeaponsTrackBar.Minimum = 0;
            BInfantryTrackBar.Minimum = 0;
            BCavalryTrackBar.Minimum = 0;
            BSiegeWeaponsTrackBar.Minimum = 0;
            AInfantryTrackBar.Maximum = Parameters.BaseArmyCost / Parameters.BaseInfantryCost;
            ACavalryTrackBar.Maximum = Parameters.BaseArmyCost / Parameters.BaseCavalryCost;
            ASiegeWeaponsTrackBar.Maximum = Parameters.BaseArmyCost / Parameters.BaseSiegeWeaponCost;
            BInfantryTrackBar.Maximum = Parameters.BaseArmyCost / Parameters.BaseInfantryCost;
            BCavalryTrackBar.Maximum = Parameters.BaseArmyCost / Parameters.BaseCavalryCost;
            BSiegeWeaponsTrackBar.Maximum = Parameters.BaseArmyCost / Parameters.BaseSiegeWeaponCost;
        }
        private void CheckAArmy()
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AArmyChange(object sender, EventArgs e)
        {
            int infantryCount = AInfantryTrackBar.Value;
            int cavalryCount = ACavalryTrackBar.Value;
            int siegeWeaponsCount = ASiegeWeaponsTrackBar.Value;
            int infantryCost = infantryCount * Parameters.BaseInfantryCost;
            int cavalryCost = cavalryCount * Parameters.BaseCavalryCost;
            int siegeWeaponsCost = siegeWeaponsCount * Parameters.BaseSiegeWeaponCost;
            totalCostA = infantryCost + cavalryCost + siegeWeaponsCost;

            string result = $@"Пехоты - {infantryCount}" + Environment.NewLine +
$@"Кавалерии - {cavalryCount}" + Environment.NewLine +
$@"Осадных орудий - {siegeWeaponsCount}" + Environment.NewLine +
$@"Использовано очков - {totalCostA} из {Parameters.BaseArmyCost}" + Environment.NewLine;

            if (totalCostA == Parameters.BaseArmyCost)
            {
                result += "Ваша армия идеально укомплектована, милорд";
            }
            if (totalCostA < Parameters.BaseArmyCost)
            {
                result += "Ваша армия может быть сильнее, милорд";
            }
            if (totalCostA > Parameters.BaseArmyCost)
            {
                result += "У нас нет средств для такой сильной армии, милорд";
            }
            AArmyTextBox.Text = result;
        }

        private void BArmyChange(object sender, EventArgs e)
        {
            int infantryCount = BInfantryTrackBar.Value;
            int cavalryCount = BCavalryTrackBar.Value;
            int siegeWeaponsCount = BSiegeWeaponsTrackBar.Value;
            int infantryCost = infantryCount * Parameters.BaseInfantryCost;
            int cavalryCost = cavalryCount * Parameters.BaseCavalryCost;
            int siegeWeaponsCost = siegeWeaponsCount * Parameters.BaseSiegeWeaponCost;
            totalCostB = infantryCost + cavalryCost + siegeWeaponsCost;

            string result = $@"Пехоты - {infantryCount}" + Environment.NewLine +
$@"Кавалерии - {cavalryCount}" + Environment.NewLine +
$@"Осадных орудий - {siegeWeaponsCount}" + Environment.NewLine +
$@"Использовано очков - {totalCostB} из {Parameters.BaseArmyCost}" + Environment.NewLine;

            if (totalCostB == Parameters.BaseArmyCost)
            {
                result += "Ваша армия идеально укомплектована, милорд";
            }
            if (totalCostB < Parameters.BaseArmyCost)
            {
                result += "Ваша армия может быть сильнее, милорд";
            }
            if (totalCostB > Parameters.BaseArmyCost)
            {
                result += "У нас нет средств для такой сильной армии, милорд";
            }
            BArmyTextBox.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (totalCostA > Parameters.BaseArmyCost)
            {
                MessageBox.Show($"Войско игрока А превышает установленный лимит очковой стоимости {Parameters.BaseArmyCost}");
                return;
            }if (totalCostB > Parameters.BaseArmyCost)
            {
                MessageBox.Show($"Войско игрока Б превышает установленный лимит очковой стоимости {Parameters.BaseArmyCost}");
                return;
            }
            BattleCalculator calculator = new BattleCalculator();
            calculator.InitArmyA((AbstractFactory)AArmyListBox.SelectedItem, AInfantryTrackBar.Value, ACavalryTrackBar.Value, ASiegeWeaponsTrackBar.Value);  //не хватает аргумента
            calculator.InitArmyB((AbstractFactory)BArmyListBox.SelectedItem, BInfantryTrackBar.Value, BCavalryTrackBar.Value, BSiegeWeaponsTrackBar.Value);  //?
            MessageBox.Show(calculator.Battle());
        }

    }
}