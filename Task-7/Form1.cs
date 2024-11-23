using Timer = System.Windows.Forms.Timer;

namespace Task_7
{
    public partial class Form1 : Form
    {
        private const string LostMessage = "You lost";

        private const int BombPanelSize = 50;
        protected bool GameStarted = false;

        public Timer CreateBombTimer = new();
        public Timer FallBombTimer = new();

        public Random Random= new();

        private  List<Panel> _bombList = new();

        public Form1()
        {
            InitializeComponent();
            CreateBombTimer.Interval = 3500; 
            CreateBombTimer.Tick += Create_Bomb; 
            CreateBombTimer.Start();

            FallBombTimer.Interval = 300; 
            FallBombTimer.Tick += Fall_Bomb; 
            FallBombTimer.Start();
        }
        private void right_MouseDown(object sender, MouseEventArgs e)
        {
            if(GameStarted)
            {
                var actionDestination = new Point(boy.Location.X + 10, boy.Location.Y);
                if (actionDestination.X + boy.Width >= background.Width)
                    actionDestination.X = background.Width - boy.Width;
                boy.Location = actionDestination;
            }
        }
        private void left_MouseDown(object sender, MouseEventArgs e)
        { 
            if(GameStarted) 
            {
              var actionDestination = new Point(boy.Location.X - 10, boy.Location.Y);
             if (actionDestination.X <= 0) actionDestination.X = 0;
              boy.Location = actionDestination;
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            menuBoard.Visible = false;
            GameStarted = true;
        }
        private void Create_Bomb(object sender, EventArgs e)
        {
            if (GameStarted)
            {
             int X = new Random().Next(0, background.Width - BombPanelSize);
             Panel newPanel = new Panel
             {
                 Location = new Point(X,0),
                 Width = BombPanelSize,
                 Height = BombPanelSize,
                 BackColor = GetRandomColor()
             };
             _bombList.Add(newPanel);
             this.Controls.Add(newPanel);
             newPanel.BringToFront();

            }
        }
        private void Fall_Bomb(object sender, EventArgs e)
        {
            foreach (var bomb in _bombList)
            {
                bomb.Location = new Point(bomb.Location.X, bomb.Location.Y + 10);
                if (bomb.Location.Y >= boy.Location.Y + boy.Height)
                {
                    this.Controls.Remove(bomb);
                }
            }
            if (_bombList.Any(bomb => bomb.Location.Y + BombPanelSize/2 >= boy.Location.Y && bomb.Location.Y <= boy.Location.Y + boy.Height - BombPanelSize / 2 &&
                                      bomb.Location.X + BombPanelSize >= boy.Location.X + 10 && bomb.Location.X <= boy.Location.X + boy.Width - 10))
            {
                menuBoard.Visible = true;
                GameStarted = false;
                foreach (var bomb in _bombList)
                {
                    Controls.Remove(bomb);
                }
                lostMessage.Text = LostMessage;
                lostMessage.Visible = true;
                _bombList = new();
            }
        }
        private Color GetRandomColor()
        {
            Color randomColor;
            do randomColor = Color.FromArgb(Random.Next(256), Random.Next(256), Random.Next(256));
            while (randomColor.ToArgb() == background.BackColor.ToArgb());
            return randomColor;
        }
    }
}
