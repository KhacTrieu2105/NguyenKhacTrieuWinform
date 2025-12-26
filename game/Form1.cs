#nullable disable
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceShooterGame
{
    public partial class GameForm : Form
    {
        enum GameState { Menu, Playing, GameOver, Win }
        GameState gameState = GameState.Menu;

        private System.Windows.Forms.Timer gameTimer;
        private Random rand = new Random();

        private Rectangle player;
        private int playerHP = 100;
        private Image shipImg;

        private List<Rectangle> bullets = new();
        private bool shooting;
        private int shootCooldown;

        private List<Rectangle> enemies = new();
        private Image enemyImg;

        private Rectangle boss;
        private bool bossAlive;
        private int bossHP;
        private Image bossImg;

        private List<Rectangle> bossBullets = new();
        private int bossShootCooldown = 0;

        private bool left, right;
        private int score = 0;
        private int level = 1;
        private const int MAX_LEVEL = 7;

        private Button btnPlay;
        private Image bgMenu;

        class Star { public int X, Y, Speed, Size; }
        private List<Star> stars = new();

        public GameForm()
        {
            // ===== THIẾT LẬP TOÀN MÀN HÌNH =====
            this.FormBorderStyle = FormBorderStyle.None; // Bỏ thanh tiêu đề
            this.WindowState = FormWindowState.Maximized; // Phóng to tối đa
            this.TopMost = true; // Hiển thị trên cùng các ứng dụng khác

            Text = "Space Shooter Fullscreen";
            DoubleBuffered = true;
            BackColor = Color.Black;
            KeyPreview = true;

            // Load Assets
            try
            {
                shipImg = Image.FromFile("Assets/ship.png");
                enemyImg = Image.FromFile("Assets/enemy.png");
                bossImg = Image.FromFile("Assets/boss.png");
                bgMenu = Image.FromFile("Assets/bg_menu.jpg");
            }
            catch { }

            // Khởi tạo vị trí người chơi dựa trên kích thước màn hình thực tế
            InitPlayerPosition();
            InitStars();
            InitButton();

            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 16;
            gameTimer.Tick += GameLoop;
            gameTimer.Start();

            KeyDown += KeyDownHandler;
            KeyUp += KeyUpHandler;
        }

        private void InitPlayerPosition()
        {
            // Đặt máy bay ở giữa phía dưới màn hình
            player = new Rectangle(Screen.PrimaryScreen.Bounds.Width / 2 - 30,
                                   Screen.PrimaryScreen.Bounds.Height - 120, 60, 60);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Nhấn ESC để thoát game nhanh
            if (keyData == Keys.Escape) Application.Exit();

            if (keyData == Keys.Space && gameState != GameState.Playing) return true;
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void InitButton()
        {
            btnPlay = new Button
            {
                Text = "CHƠI",
                Size = new Size(200, 60),
                // Căn giữa nút bấm theo màn hình
                Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - 100,
                                    Screen.PrimaryScreen.Bounds.Height / 2 + 50),
                Font = new Font("Arial", 18, FontStyle.Bold),
                BackColor = Color.FromArgb(20, 20, 20),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                TabStop = false
            };

            btnPlay.Click += (s, e) =>
            {
                btnPlay.Visible = false;
                ResetGame();
                gameState = GameState.Playing;
                this.Focus();
            };

            Controls.Add(btnPlay);
        }

        private void GameLoop(object sender, EventArgs e)
        {
            MoveStars();
            if (gameState != GameState.Playing) { Invalidate(); return; }

            MovePlayer();
            Shoot();
            MoveBullets();
            MoveEnemies();
            SpawnEnemy();
            SpawnBoss();
            BossShoot();
            MoveBossBullets();
            CheckCollision();
            CheckLevelUp();

            Invalidate();
        }

        private void InitStars()
        {
            stars.Clear();
            // Tăng số lượng sao cho màn hình lớn (150 ngôi sao)
            for (int i = 0; i < 150; i++)
                stars.Add(new Star
                {
                    X = rand.Next(Screen.PrimaryScreen.Bounds.Width),
                    Y = rand.Next(Screen.PrimaryScreen.Bounds.Height),
                    Speed = rand.Next(2, 8),
                    Size = rand.Next(1, 4)
                });
        }

        private void MoveStars()
        {
            foreach (var s in stars)
            {
                s.Y += s.Speed;
                if (s.Y > this.Height)
                {
                    s.Y = 0;
                    s.X = rand.Next(this.Width);
                }
            }
        }

        private void MovePlayer()
        {
            if (left && player.Left > 0) player.X -= 10;
            if (right && player.Right < this.Width) player.X += 10;
        }

        private void Shoot()
        {
            if (shooting && shootCooldown == 0)
            {
                bullets.Add(new Rectangle(player.X + player.Width / 2 - 3, player.Y, 6, 20));
                shootCooldown = Math.Max(5, 12 - level);
            }
            if (shootCooldown > 0) shootCooldown--;
        }

        private void SpawnEnemy()
        {
            if (bossAlive) return;
            if (rand.Next(Math.Max(5, 50 - level * 5)) == 0)
                enemies.Add(new Rectangle(rand.Next(0, this.Width - 50), -50, 50, 50));
        }

        private void MoveEnemies()
        {
            for (int i = enemies.Count - 1; i >= 0; i--)
            {
                enemies[i] = new Rectangle(enemies[i].X, enemies[i].Y + level + 4, 50, 50);
                if (enemies[i].Top > this.Height)
                {
                    playerHP -= 10;
                    enemies.RemoveAt(i);
                }
            }
        }

        private void SpawnBoss()
        {
            if (level == MAX_LEVEL && !bossAlive)
            {
                bossAlive = true;
                bossHP = 1000; // Tăng máu Boss cho màn hình lớn
                boss = new Rectangle(this.Width / 2 - 200, 50, 400, 180);
                bossBullets.Clear();
                bossShootCooldown = 60;
            }
        }

        private void BossShoot()
        {
            if (!bossAlive) return;
            if (bossShootCooldown == 0)
            {
                // Bắn 3 tia
                bossBullets.Add(new Rectangle(boss.X + 50, boss.Bottom, 10, 25));
                bossBullets.Add(new Rectangle(boss.X + boss.Width / 2 - 5, boss.Bottom, 10, 25));
                bossBullets.Add(new Rectangle(boss.X + boss.Width - 60, boss.Bottom, 10, 25));
                bossShootCooldown = 35;
            }
            else bossShootCooldown--;
        }

        private void MoveBossBullets()
        {
            for (int i = bossBullets.Count - 1; i >= 0; i--)
            {
                bossBullets[i] = new Rectangle(bossBullets[i].X, bossBullets[i].Y + 10, 10, 25);
                if (bossBullets[i].Top > this.Height) bossBullets.RemoveAt(i);
            }
        }

        private void MoveBullets()
        {
            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                bullets[i] = new Rectangle(bullets[i].X, bullets[i].Y - 15, 6, 20);
                if (bullets[i].Bottom < 0) bullets.RemoveAt(i);
            }
        }

        private void CheckCollision()
        {
            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                for (int j = enemies.Count - 1; j >= 0; j--)
                {
                    if (bullets[i].IntersectsWith(enemies[j]))
                    {
                        bullets.RemoveAt(i);
                        enemies.RemoveAt(j);
                        score += 10;
                        goto NextBullet;
                    }
                }
                if (bossAlive && bullets[i].IntersectsWith(boss))
                {
                    bullets.RemoveAt(i);
                    bossHP -= 10;
                    if (bossHP <= 0) gameState = GameState.Win;
                    goto NextBullet;
                }
            NextBullet:;
            }

            foreach (var eb in bossBullets)
                if (eb.IntersectsWith(player)) { playerHP -= 1; } // Giảm nhẹ vì đạn boss nhiều

            if (playerHP <= 0) { playerHP = 0; gameState = GameState.GameOver; btnPlay.Visible = true; }
        }

        private void CheckLevelUp() { level = Math.Min(MAX_LEVEL, score / 150 + 1); }

        private void ResetGame()
        {
            bullets.Clear();
            enemies.Clear();
            bossBullets.Clear();
            score = 0;
            level = 1;
            playerHP = 100;
            bossAlive = false;
            InitPlayerPosition();
            InitStars();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (gameState == GameState.Menu)
            {
                if (bgMenu != null) g.DrawImage(bgMenu, 0, 0, this.Width, this.Height);
                DrawCenterText(g, "SPACE SHOOTER", 60, Brushes.White, this.Height / 3);
                return;
            }

            g.Clear(Color.Black);
            foreach (var s in stars) g.FillEllipse(Brushes.White, s.X, s.Y, s.Size, s.Size);

            if (gameState == GameState.GameOver)
            {
                DrawCenterText(g, "GAME OVER", 60, Brushes.Red, this.Height / 2 - 50);
                btnPlay.Text = "THỬ LẠI";
                return;
            }

            if (gameState == GameState.Win)
            {
                DrawCenterText(g, "YOU WIN!", 60, Brushes.Lime, this.Height / 2 - 50);
                btnPlay.Visible = true;
                return;
            }

            if (shipImg != null) g.DrawImage(shipImg, player);
            foreach (var b in bullets) g.FillRectangle(Brushes.Yellow, b);
            foreach (var en in enemies) if (enemyImg != null) g.DrawImage(enemyImg, en);

            if (bossAlive)
            {
                if (bossImg != null) g.DrawImage(bossImg, boss);
                foreach (var bb in bossBullets) g.FillRectangle(Brushes.Red, bb);
                // Thanh máu Boss
                g.FillRectangle(Brushes.Gray, this.Width / 2 - 200, 20, 400, 10);
                g.FillRectangle(Brushes.Red, this.Width / 2 - 200, 20, bossHP * 0.4f, 10);
            }

            // UI
            g.FillRectangle(Brushes.DarkRed, 20, 20, 300, 20);
            g.FillRectangle(Brushes.Lime, 20, 20, playerHP * 3, 20);
            g.DrawString($"SCORE: {score}", new Font("Arial", 16, FontStyle.Bold), Brushes.White, 20, 50);
            g.DrawString($"LEVEL: {level}/{MAX_LEVEL}", new Font("Arial", 16, FontStyle.Bold), Brushes.Cyan, this.Width - 180, 20);
            g.DrawString("ESC: Thoát", Font, Brushes.Gray, 20, this.Height - 30);
        }

        private void DrawCenterText(Graphics g, string text, int size, Brush color, int y)
        {
            using Font f = new Font("Arial", size, FontStyle.Bold);
            SizeF s = g.MeasureString(text, f);
            g.DrawString(text, f, color, (this.Width - s.Width) / 2, y);
        }

        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            if (gameState != GameState.Playing) return;
            if (e.KeyCode == Keys.Left) left = true;
            if (e.KeyCode == Keys.Right) right = true;
            if (e.KeyCode == Keys.Space) shooting = true;
        }

        private void KeyUpHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) left = false;
            if (e.KeyCode == Keys.Right) right = false;
            if (e.KeyCode == Keys.Space) shooting = false;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}