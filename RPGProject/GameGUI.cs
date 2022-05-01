namespace RPGProject
{
    public partial class GameGUI : Form
    {
        PictureBox[] heroPBs = new PictureBox[3];
        public GameGUI()
        {
            InitializeComponent();
            heroPBs[0] = heroPb1;
            heroPBs[1] = heroPb2;
            heroPBs[2] = heroPb3;
        }

        public void HeroesUpdateHandler(object? sender, HeroesUpdateEventArgs e)
        {
            for (int i = 0; i < e.Heroes.Count; i++)
            {
                heroPBs[i].Image = e.Heroes[i].MySprite;
            }
        }
    }
}