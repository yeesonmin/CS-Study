using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        Timer t = new Timer();
        int xSize, ySize;//칸크기
        const int xNum = 20, yNum = 20;//칸 개수
        int sx, sy, ex, ey;//먹이 위치 및 뱀머리 위치
        int snakeSize; //뱀 길이
        int[,] snake = new int[20,20];
        int keyNum = 5;//방향키 값 기억
        int levelEat = 1, levelSpeed = 1;//레벨에 따른 속도 및 먹이수
        int eat;



        private void Form4_Load(object sender, EventArgs e)
        {
            //한칸 크기 설정
            xSize = lbl_GameBord.Size.Width / xNum;
            ySize = lbl_GameBord.Size.Height / yNum;


        }

        /// <summary>
        /// ///////////////////////////////////////////////////방향키
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Left:
                    {
                        //키 입력값 기억 0:L, 1: R, 2:U, 3:D
                        keyNum = 0;

                        break;
                    }
                case Keys.Right:
                    {
                        keyNum = 1;

                        break;
                    }
                case Keys.Up:
                    {
                        keyNum = 2;

                        break;
                    }
                case Keys.Down:
                    {
                        keyNum = 3;

                        break;
                    }
                case Keys.Escape:
                    {
                        btn_Ok.Enabled = true;
                        numericUpDown1.Enabled = true;
                        t.Tick -= timer1_Tick;
                        t.Stop();
                        break;
                    }

            }
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////// 시간간격으로 움직임.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            switch(keyNum)
            {
                case 0:
                    {
                        SnakeEat();
                        SnakeHeadMovePoint();
                        lbl_GameBord.Invalidate();
                       
                        break;
                    }
                case 1:
                    {
                        SnakeEat();
                        SnakeHeadMovePoint();
                        lbl_GameBord.Invalidate();
                       
                        break;
                    }
                case 2:
                    {
                        SnakeEat();
                        SnakeHeadMovePoint();
                        lbl_GameBord.Invalidate();
                       
                        break;
                    }
                case 3:
                    {

                        SnakeEat();
                        SnakeHeadMovePoint();
                        lbl_GameBord.Invalidate();
                        
                        break;
                    }
            }

            

        }

        


        /// <summary>
        /// ///////////////////////////////////////////////////////화면 그리기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_GameBord_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //먹이그리기
            SolidBrush b = new SolidBrush(Color.Red);
            g.FillRectangle(b, ex * xSize, ey * ySize, xSize, ySize);



            //뱀 그리기
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (snake[i, j] > 0)
                    {
                        b = new SolidBrush(Color.Black);
                        g.FillRectangle(b, i * xSize, j * ySize, xSize, ySize);
                    }
                }
            }

            
        }



        public Form4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////시작버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            //레벨에 따른 먹이 수 증가 및 속도 증가
            levelEat = 4 + (int)numericUpDown1.Value;
            levelSpeed = 20 * (int)numericUpDown1.Value;
           

            //게임시작
            EatGage.Value = 0;
            t.Interval = 520 - levelSpeed;
            t.Tick += timer1_Tick;
            t.Start();

            SnakePoint();
            snakeSize = 1;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    snake[i, j] = 0;
                }
            }
            snake[sx, sy] = snakeSize;

            EatPoint();
            lbl_GameBord.Invalidate();
            numericUpDown1.Enabled = false;
            btn_Ok.Enabled = false;
            keyNum = 5;
            eat = 0;
            

           
           

        }

        /// <summary>
        /// ///////////////// 게임오버
        /// </summary>
        private void GameOver()
        {
            ///////////////////////////////////벽에 부딪힘.
            if (sx < 0 || sy < 0 || sx > 19 || sy >19)
            {
                t.Tick -= timer1_Tick;
                t.Stop();
                MessageBox.Show("게임오버");
                SnakePoint();
                snakeSize = 1;
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        snake[i, j] = 0;
                    }
                }
                snake[sx, sy] = snakeSize;

                EatPoint();
                btn_Ok.Enabled = true;
                numericUpDown1.Enabled = true;
            }
            ////////////////////////////////////몸에 부딪힘.
            if (snake[sx, sy] > 1)
            {
                t.Tick -= timer1_Tick;
                t.Stop();
                MessageBox.Show("게임오버");
                SnakePoint();
                snakeSize = 1;
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        snake[i, j] = 0;
                    }
                }
                snake[sx, sy] = snakeSize;

                EatPoint();
                btn_Ok.Enabled = true;
                numericUpDown1.Enabled = true;
            }
        }

        /////////////////////////////////////// 먹이위치 //////////////////////////////////////////
        private void EatPoint()
        {
            Random r = new Random();
            while (true)
            {

                ex = r.Next(0, 19);
                ey = r.Next(0,19);
                if (snake[ex, ey] == 0)
                {
                    break;
                }
               


            }
        }

        /// <summary>
        /// ///////////////////////////////////////초기 뱀위치//////////////////////////////////////////
        /// </summary>
        private void SnakePoint()
        {
            Random r = new Random();
            
            sx = r.Next(0, 20);
            sy = r.Next(0, 20);

        }

        /// <summary>
        /// ///////////////////////////////////////////////뱀머리 위치
        /// </summary>
        private void SnakeHeadMovePoint()
        {
            switch (keyNum)
            {
                case 0:
                    {
                        snake[sx, sy] = 0;
                        SnakeBodyPoint();
                        sx--;
                        GameOver();
                        snake[sx, sy] = 1;
                        break;
                    }
                case 1:
                    {
                        snake[sx, sy] = 0;
                        SnakeBodyPoint();
                        sx++;
                        GameOver();
                        snake[sx, sy] = 1;

                        break;
                    }
                case 2:
                    {
                        snake[sx, sy] = 0;
                        SnakeBodyPoint();
                        sy--;
                        GameOver();
                        snake[sx, sy] = 1;
                        break;
                    }
                case 3:
                    {
                        snake[sx, sy] = 0;
                        SnakeBodyPoint();
                        sy++;
                        GameOver();
                        snake[sx, sy] = 1;
                        break;
                    }
            }
            
        }

        
        private void SnakeBodyPoint()
        {
            int tx = 0, ty = 0;
            if(snakeSize > 1)
            {
               if(snakeSize == 2)
                {
                    for(int i = 0; i <20; i++)
                    {
                        for(int j = 0; j < 20; j++)
                        {
                            if(snake[i, j] == 2)
                            {
                                snake[i, j] = 0;
                            }
                        }
                    }
                    snake[sx, sy] = 2;
                }
                else
                {
                   for(int i = 0; i<20; i++)
                    {
                        for(int j = 0; j<20; j++)
                        {
                            if(snake[i,j] > 1)
                            {
                                if(snake[i, j] != snakeSize)
                                {
                                    snake[i, j] = snake[i, j] + 1;
                                }
                                else
                                {
                                    snake[i, j] = 0;
                                }
                                
                            }
                        }
                    }
                    snake[sx, sy] = 2;
                }

            }
        }


        ///////////////////////////////////////////////뱀이 먹이를 먹었을 때 동작/////////////////////////////////////////
        private void SnakeEat()
        {
            
            
            if (sx == ex && sy == ey)
            {
                //먹은 수 증가 및 뱀 크기 증가
                eat++;
                snakeSize = snakeSize + 1;
                

                //게이지 표시
                EatGage.Value = (100 / levelEat) * eat;


                if (eat == levelEat)
                {
                    t.Tick -= timer1_Tick;
                    t.Stop();
                    MessageBox.Show(numericUpDown1.Value + "레벨 클리어");

                    EatGage.Value = 0;
                    numericUpDown1.Value++;
                    levelEat = 4 + (int)numericUpDown1.Value;
                    levelSpeed = 20 * (int)numericUpDown1.Value;
                    eat = 0;
                    snakeSize = 1;
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            snake[i, j] = 0;
                        }
                    }
                    snake[sx, sy] = snakeSize;
                    keyNum = 5;

                    
                    t.Interval = 520 - levelSpeed;
                    t.Tick += timer1_Tick;
                    t.Start();
                  
                }
                EatPoint();
                lbl_GameBord.Invalidate();
            }
        }
    }
   
}

