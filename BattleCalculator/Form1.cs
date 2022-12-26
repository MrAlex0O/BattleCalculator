using BattleCalculator.Factories;

namespace BattleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AArmyListBox.Items.Add(new ElfFactory());
            AInfantryTrackBar.Minimum = 0;
            ACavalryTrackBar.Minimum = 0;
            ASiegeWeaponsTrackBar.Minimum = 0;
            AInfantryTrackBar.Maximum = Parameters.BaseArmyCost / Parameters.BaseInfantryCost;
            ACavalryTrackBar.Maximum = Parameters.BaseArmyCost / Parameters.BaseCavalryCost;
            ASiegeWeaponsTrackBar.Maximum = Parameters.BaseArmyCost / Parameters.BaseSiegeWeaponCost;
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
            int totalCost = infantryCost + cavalryCost + siegeWeaponsCost;

            string result = $@"Пехоты - {infantryCount}
Кавалерии - {cavalryCount}
Осадных орудий - {siegeWeaponsCount}
Использовано очков - {totalCost} из {Parameters.BaseArmyCost}" + Environment.NewLine;

            if (totalCost == Parameters.BaseArmyCost)
            {
                result += "Ваша армия идеально укомплектована, милорд";
            }
            if (totalCost < Parameters.BaseArmyCost)
            {
                result += "Ваша армия может быть сильнее, милорд";
            }
            if (totalCost > Parameters.BaseArmyCost)
            {
                result += "У нас нет средств для такой сильной армии, милорд";
            }
            AArmyTextBox.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BattleCalculator calculator = new BattleCalculator();
            //#TODO calculator.InitArmyA(AInfantryTrackBar.Value, ...);
            //#TODO calculator.InitArmyB();
        }
    }
}