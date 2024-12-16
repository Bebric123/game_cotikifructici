using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ИГРУЛЬКА
{
    public partial class Rating_Level2 : Form
    {
        public Rating_Level2(BindingList<Player> playerData_Level2)
        {
            InitializeComponent();
            var sortedList = new BindingList<Player>(playerData_Level2.Where(p => p.Score > 0).OrderBy(p => p.Score).ToList()); //Сортировка очков от меньшего к большему
                                                                                                                        //и скрыть игроков у которых в рейтинге 0 очков
            ratingTable.DataSource = sortedList; //Привязка листа с игроками к DataGridView

            //Запреты редактирования таблицы для игрока
            ratingTable.AllowUserToAddRows = false;
            ratingTable.ReadOnly = true;
            ratingTable.AllowUserToDeleteRows = false;
            ratingTable.AllowUserToOrderColumns = false;
            ratingTable.AllowUserToResizeColumns = false;
            ratingTable.AllowUserToResizeRows = false;
            ratingTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Rating_Level2_Load(object sender, EventArgs e)
        {

        }

        private void ratingTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}