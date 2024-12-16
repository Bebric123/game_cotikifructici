using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ИГРУЛЬКА
{
    public partial class Rating_Level1 : Form
    {
        public Rating_Level1(BindingList<Player> playerData_Level1)
        {
            InitializeComponent();
            var sortedList = new BindingList<Player>(playerData_Level1.Where(p => p.Score > 0).OrderBy(p => p.Score).ToList()); //Сортировка очков от меньшего к большему
                                                                                                                          //и скрыть игроков у которых в рейтинге 0 очков
            dataGridView1.DataSource = sortedList; //Привязка листа с игроками к DataGridView

            //Запреты редактирования таблицы для игрока
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Rating_Level1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}