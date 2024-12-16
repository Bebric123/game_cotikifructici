using System;
using System.Linq;
using System.Windows.Forms;

namespace ИГРУЛЬКА
{
    public partial class Level1 : Form
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
        public Level1(Menu menuForm)
        {
            InitializeComponent();
            menu = menuForm;

            picture = new int[8];
            open = new int[2];
            op_counter = 0;
            game_picture2 = new int[4];
            pikbox = new PictureBox[4];
            for (int i = 1; i <= 4; i++)
            {
                pikbox[i - 1] = Controls.Find("pictureBox" + i.ToString(), true).FirstOrDefault() as PictureBox;
            }
        }
        public void Picture()
        {
            for (int i = 1; i <= 4; i++)
            {
                PictureBox picBox = Controls.Find("pictureBox" + i.ToString(), true).FirstOrDefault() as PictureBox;
                if (picBox != null)
                {
                    picBox.BackgroundImage = imageList1.Images[8];
                }
            }
        }
        private void Level1_Load(object sender, EventArgs e)
        {
            Picture();
            restart_button_Click(null, null);
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            Score = 0; // Обнуляем счет текущей игры
            scoreOutput.Text = Score.ToString(); // Обновляем отображаемый счет
            op_counter = 0;
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                picture[i] = rnd.Next(8);
            }
            for (int i = 0; i < 4; i++)
            {
                pikbox[i].Visible = true;
                game_picture2[i] = -1;
            }
            int para = 0;
            while (para != 2)
            {
                int n1 = rnd.Next(4);
                int n2 = rnd.Next(4);
                if (n2 == n1) continue;
                if (game_picture2[n1] == -1 && game_picture2[n2] == -1)
                {
                    game_picture2[n1] = game_picture2[n2] = picture[para];
                    para++;
                }
            }
            Picture();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            pikbox[open[0]].BackgroundImage = null;
            pikbox[open[1]].BackgroundImage = null;
            op_counter = 0;
            Picture();
            isAwaiting = false; //Позволяем снова обрабатывать клики
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isAwaiting) return;
            PictureBox p = (PictureBox)sender;
            int ind = Convert.ToInt32(p.Tag);

            if (op_counter == 1 && open[0] == ind) return;

            Score++; //Увеличение счета
            scoreOutput.Text = Score.ToString(); //Обновление очков
            successfulSteps++; //Увеличение количества минимальных шагов

            if (op_counter == 2)
            {
                Picture();
                op_counter = 0;
            }
            open[op_counter] = ind;
            op_counter++;
            if (op_counter == 2)
            {
                if (game_picture2[open[0]] == game_picture2[open[1]])
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

        private void next_to_second_level_Click(object sender, EventArgs e)
        {
            if (successfulSteps >= 2)
            {
                //Разрешить переход на следующий уровень или выход из игры
                Level2 level2 = new Level2(menu); //Создаем форму 
                level2.Show(); //Переход на эту форму
                this.Close(); //Похоже на событие FormClosed 
            }
            else
                MessageBox.Show("Please take more steps!");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            pikbox[open[0]].Visible = false;
            pikbox[open[1]].Visible = false;
            op_counter = 0;
        }

        private void Level1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (successfulSteps < 2)
            {
                MessageBox.Show("Please take more steps!");
                e.Cancel = true; //Отменяет закрытие формы
            }
            else
                menu.UpdatePlayerScoreLevel1(Score, true); //Обновляет счет, если условие выполнено
        }
    }
}