using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Canvas : Form
    {
        private List<Square> Snake = new List<Square>();
        private Square apple = new Square();
        public Canvas()
        {
            InitializeComponent();

            /* Reset settings */
            new Game();
            new Highscore();

            /* Initialize tick rate */
            tmrGame.Interval = 1000 / Game.Speed;
            tmrGame.Tick += Render;
            tmrGame.Start();

            /* Start game */
            StartGame();
        }

        private void StartGame()
        {
            /* Reset settings */
            new Game();

            /* Reinitialize snake object */
            Snake.Clear();
            Square snake = new Square();
            snake.x = 10;
            snake.y = 5;
            Snake.Add(snake);

            lblScore.Text = "Score: 0";
            GenerateApple();
        }

        private void GenerateApple()
        {
            int maximumX = pnlField.Size.Width / Game.Width;
            int maximumY = pnlField.Size.Height / Game.Height;

            Random rnd = new Random();
            apple = new Square();

            apple.x = rnd.Next(0, maximumX);
            apple.y = rnd.Next(0, maximumY);
        }

        private void Render(object sender, EventArgs e)
        {
            if (Game.GameOver)
            {
                if (Hook.KeyDown(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Hook.KeyDown(Keys.D) && Game.direction != Direction.West)
                    Game.direction = Direction.East;
                else if (Hook.KeyDown(Keys.A) && Game.direction != Direction.East)
                    Game.direction = Direction.West;
                else if (Hook.KeyDown(Keys.S) && Game.direction != Direction.North)
                    Game.direction = Direction.South;
                else if (Hook.KeyDown(Keys.W) && Game.direction != Direction.South)
                    Game.direction = Direction.North;

                MoveSnake();
            }

            pnlField.Invalidate();
        }

        private void PnlField_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (Game.GameOver != true)
            {
                /* Initalizing the snake's color */
                Brush snakeColor = Brushes.LimeGreen;
                for (int i = 0; i < Snake.Count; i++)
                {
                    /* Drawing snake */
                    canvas.FillRectangle(snakeColor, new Rectangle(Snake[i].x * Game.Width, Snake[i].y * Game.Height, Game.Width, Game.Height));

                    /* Drawing apple */
                    canvas.FillRectangle(Brushes.Red, new Rectangle(apple.x * Game.Width, apple.y * Game.Height, Game.Width, Game.Height));
                }
            }
            else
            {
                StartGame();
            }
        }

        private void MoveSnake()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                /* Move head */
                if (i == 0)
                {
                    switch (Game.direction)
                    {
                        case Direction.East:
                            Snake[i].x++;
                            break;
                        case Direction.West:
                            Snake[i].x--;
                            break;
                        case Direction.South:                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
                            Snake[i].y++;
                            break;
                        case Direction.North:
                            Snake[i].y--;
                            break;
                    }

                    /* Get position caps */
                    int maximumX = pnlField.Size.Width / Game.Width;
                    int maximumY = pnlField.Size.Height / Game.Height;

                    /* Border collision */
                    if (Snake[i].x < 0 || Snake[i].y < 0 || Snake[i].x >= maximumX || Snake[i].y >= maximumY)
                    {
                        GameOver();
                    }

                    /* Body collision */
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if(Snake[i].x == Snake[j].x && Snake[i].y == Snake[j].y)
                        {
                            GameOver();
                        }
                    }

                    /* Apple collision */
                    if(Snake[0].x == apple.x && Snake[0].y == apple.y)
                    {
                        Grow();
                    }

                }
                else
                {
                    Snake[i].x = Snake[i - 1].x;
                    Snake[i].y = Snake[i - 1].y;
                }
            }
        }

        private void GameOver()
        {
            Game.GameOver = true;
        }

        private void Grow()
        {
            /* Grow in size */
            Square apple = new Square();
            apple.x = Snake[Snake.Count - 1].x;
            apple.y = Snake[Snake.Count - 1].y;

            Snake.Add(apple);

            /* Update score */
            Game.Score++;
            lblScore.Text = $"Score: {Game.Score.ToString()}";

            /* Highscore refresh */
            if (Game.Score > Highscore.highestScore)
                Highscore.highestScore = Game.Score;
                lblHighscore.Text = $"Highscore: {Highscore.highestScore.ToString()}";

            GenerateApple();
        }

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            Hook.State(e.KeyCode, true);
        }

        private void Canvas_KeyUp(object sender, KeyEventArgs e)
        {
            Hook.State(e.KeyCode, false);
        }
    }
}
