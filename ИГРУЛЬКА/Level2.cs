using System;
using System.Linq;
using System.Windows.Forms;

namespace ИГРУЛЬКА
{
    public partial class Level2 : Form
    {
        public int Score { get; private set; } = 0; //Начальные очки
        private Menu menu; //Ссылка на меню форму

        private int successfulSteps = 0; //Минимальное количество шагов
        private bool isAwaiting = false;
        int op_counter;
        int[] open;
        int[] game_picture2;
        int[] picture;
        PictureBox[] pikbox;

        public Level2(Menu menuForm)
        {
            InitializeComponent();
            menu = menuForm;

            picture = new int[8];
            open = new int[2];
            op_counter = 0;
            game_picture2 = new int[16];
            pikbox = new PictureBox[16];
            for (int i = 1; i <= 16; i++)
            {
                pikbox[i - 1] = Controls.Find("pictureBox" + i.ToString(), true).FirstOrDefault() as PictureBox;
            }
        }
        public void Picture()
        {
            for (int i = 1; i <= 16; i++)
            {
                PictureBox picBox = Controls.Find("pictureBox" + i.ToString(), true).FirstOrDefault() as PictureBox;
                if (picBox != null)
                {
                    picBox.BackgroundImage = imageList1.Images[8];
                }
            }
        }
        private void restart_button_Click(object sender, EventArgs e)
        {
            Score = 0; //Обнуляем счет текущей игры
            scoreOutput.Text = Score.ToString(); //Обновляем отображаемый счет

            op_counter = 0;
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                picture[i] = rnd.Next(8);
            }
            for (int i = 0; i < 16; i++)
            {
                pikbox[i].Visible = true;
                game_picture2[i] = -1;
            }
            int para = 0;
            while (para != 8)
            {
                int n1 = rnd.Next(16);
                int n2 = rnd.Next(16);
                if (n2 == n1) continue;
                if (game_picture2[n1] == -1 && game_picture2[n2] == -1)
                {
                    game_picture2[n1] = game_picture2[n2] = picture[para];
                    para++;
                }
            }
            Picture();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pikbox[open[0]].BackgroundImage = null;
            pikbox[open[1]].BackgroundImage = null;
            op_counter = 0;
            Picture();
            isAwaiting = false; //Позволяем снова обрабатывать клики
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            pikbox[open[0]].Visible = false;
            pikbox[open[1]].Visible = false;
            op_counter = 0;
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (isAwaiting) return;
            PictureBox p = (PictureBox)sender;
            int ind = Convert.ToInt32(p.Tag);

            if (op_counter == 1 && open[0] == ind) return;

            Score++; //Увеличение счета
            scoreOutput.Text = Score.ToString(); //Обновление очков
            successfulSteps++; //Увеличение количества минимальных шагов

            if (op_counter ==2)
            {
                Picture();
                op_counter = 0;
            }
            open[op_counter] = ind;
            op_counter++;
            if(op_counter == 2)
            {
               if(game_picture2[open[0]] == game_picture2[open[1]])
               {
                    timer2.Start();
               }
               else
               {
                    timer1.Start();
               }
            }
            p.BackgroundImage = imageList1.Images[game_picture2[ind]];
        }

        private void next_to_third_level_Click(object sender, EventArgs e)
        {
            if (successfulSteps >= 16)
            {
                //Разрешить переход на следующий уровень или выход из игры
                Level3 level3 = new Level3(menu); //Создаем форму 
                level3.Show(); //Переход на эту форму
                this.Close(); //Похоже на событие FormClosed 
            }
            else
                MessageBox.Show("Please take more steps!");
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            Picture();
            restart_button_Click(null, null);
        }

        private void Level2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (successfulSteps < 16)
            {
                MessageBox.Show("Please take more steps!");
                e.Cancel = true; //Отменяет закрытие формы
            }
            else
                menu.UpdatePlayerScoreLevel2(Score, true); //Обновляет счет, если условие выполнено
        }
    }
}