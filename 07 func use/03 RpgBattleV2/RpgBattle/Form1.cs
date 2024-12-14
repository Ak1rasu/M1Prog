namespace RpgBattle
{
    public partial class Form1 : Form
    {
        int monsterHealth = 100;
        int playerAttack = 20;
        int playerMagicAttack = 50;

        public Form1()
        {
            InitializeComponent();
            UpdateMonsterHealth();
        }

        private void UpdateMonsterHealth()
        {
            monsterhealth.Text = monsterHealth.ToString();
        }

        private void DoDamage(int damage)
        {
            monsterHealth -= damage;
            UpdateMonsterHealth();
        }

        private void attack_Click(object sender, EventArgs e)
        {
            DoDamage(playerAttack);
        }

        private void fireball_Click(object sender, EventArgs e)
        {
            DoDamage(playerMagicAttack);
        }
    }
}
