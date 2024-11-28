using Timer = System.Windows.Forms.Timer;

namespace Task_7
{
    public partial class Form1 : Form
    {
        private const string LostMessage = "You lost";

        private const int BombPanelSize = 50;
        protected bool GameStarted = false;
        protected bool IsLeft = true;

        public Timer CreateBombTimer = new();
        public Timer FallBombTimer = new();

        public Random Random = new();

        private List<PictureBox> _bombList = new();

        System.Media.SoundPlayer Player = new System.Media.SoundPlayer(@"C:\Users\user\Desktop\University\3-cü kurs\1-ci semestr\Müasir proq. dilləri- Amin M\Ev tapşırıqları\Files\248822-Sci-Fi_Pulse_Grenade_Blast_3.wav");

        public Form1()
        {
            InitializeComponent();
            CreateBombTimer.Interval = 3000;
            CreateBombTimer.Tick += Create_Bomb;
            CreateBombTimer.Start();

            FallBombTimer.Interval = 5;
            FallBombTimer.Tick += Fall_Bomb;
            FallBombTimer.Start();
        }
        private void right_MouseDown(object sender, MouseEventArgs e)
        {
            if (GameStarted)
            {
                if (IsLeft)
                {
                 boy.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                 boy.Refresh();
                }
                var actionDestination = new Point(boy.Location.X + 10, boy.Location.Y);
                if (actionDestination.X + boy.Width >= background.Width)
                    actionDestination.X = background.Width - boy.Width;
                boy.Location = actionDestination;
                IsLeft = false;
            }
        }
        private void left_MouseDown(object sender, MouseEventArgs e)
        {
            if (GameStarted)
            {
                if (!IsLeft)
                {
                    boy.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    boy.Refresh();
                }
                var actionDestination = new Point(boy.Location.X - 10, boy.Location.Y);
                if (actionDestination.X <= 0) actionDestination.X = 0;
                boy.Location = actionDestination;
                IsLeft = true;
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
                PictureBox newPictureBox = new PictureBox
                {
                    Parent = background,
                    Location = new Point(X, 0),
                    Width = BombPanelSize,
                    Height = BombPanelSize,
                    Image = Image.FromFile(@"C:\Users\user\Desktop\Programming\back-end\WinForm\WinFormPractice\WinForm_Practice_Pictures\grenadepng.parspng.com_.png"),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = background.BackColor

                };
                _bombList.Add(newPictureBox);
                this.Controls.Add(newPictureBox);
                newPictureBox.BringToFront();
            }
        }
        private void Fall_Bomb(object sender, EventArgs e)
        {
            bombCount.Value = _bombList.Count;
            foreach (var bomb in _bombList)
            {
                bomb.Location = new Point(bomb.Location.X, bomb.Location.Y + 1);
                if (bomb.Location.Y >= boy.Location.Y + boy.Height)
                {
                    if(Controls.Contains(bomb))  Player.Play();
                    this.Controls.Remove(bomb);
                }
            }
            if (_bombList.Any(bomb => bomb.Location.Y + BombPanelSize - 10 >= boy.Location.Y && bomb.Location.Y <= boy.Location.Y + boy.Height - BombPanelSize / 2 &&
                                      bomb.Location.X + BombPanelSize >= boy.Location.X + 10 && bomb.Location.X <= boy.Location.X + boy.Width - 10))
            {
                Player.Play();
                menuBoard.Visible = true;
                GameStarted = false;
                foreach (var bomb in _bombList) Controls.Remove(bomb);
                
                lostMessage.Visible = true;
                _bombList = new();
            }
        }
    }
}
