using WinFormGame.Game;
using WinFormGame.Game.GameFormElement;

namespace WinFormGame
{
    public partial class FormTesting : Form
    {
        public FormTesting()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Block?[,] card = new Block[,]
            {
                { new Block()
            {
                BackColor = Color.Green,
                IsEmpty = false
            }, new Block()
            {
                BackColor = Color.Green,
                IsEmpty = false
            }, new Block()
            {
                BackColor = Color.Red,
                IsEmpty = false
            }},
                { new Block()
            {
                BackColor = Color.Red,
                IsEmpty = false
            }, new Block()
            {
                BackColor = Color.Green,
                IsEmpty = false
            }, new Block()
            {
                BackColor = Color.Green,
                IsEmpty = false
            }},
                { new Block()
            {
                BackColor = Color.Green,
                IsEmpty = false
            }, new Block()
            {
                BackColor = Color.Red,
                IsEmpty = false
            }, new Block()
            {
                BackColor = Color.Green,
                IsEmpty = false
            }}
            };

            Map map = new Map(panelTest, panelHeader, card);

            GameSilonov gameSilonov = new GameSilonov(map);

            
            
            
        }
    }
}
