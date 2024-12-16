using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ИГРУЛЬКА
{
    public partial class Menu : Form
    {
        private BindingList<Player> playerData_Level2 = new BindingList<Player>(); //Лист с игроками
        private BindingList<Player> playerData_Level1 = new BindingList<Player>();
        private BindingList<Player> playerData_Level3 = new BindingList<Player>(); 
        private const string FILEPATH_LEVEL1 = "players_level1.xml"; //Имя сохранения XML файла
        private const string FILEPATH_LEVEL2 = "players_level2.xml";
        private const string FILEPATH_LEVEL3 = "players_level3.xml";
        public string currentPlayerName; //Текущий игрок
        public int score = 0; //Счётчик

        public Menu()
        {
            InitializeComponent();
            LoadPlayerToXMLLevel1();
            LoadPlayerToXMLLevel2();
            LoadPlayerToXMLLevel3(); //Загрузка данных о игроках при старте
            start_button.Enabled = false; //Запрет на нажатие
            label1.BackColor = Color.Transparent;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            start_button.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text); //Кнопка может быть нажата если там есть текст
        }
        private void start_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) //Если TextBox не пуст
            {
                currentPlayerName = textBox1.Text; //Присваиваем имя текущему игроку
                var existingPlayer = playerData_Level1.FirstOrDefault(p => p.Name == currentPlayerName); //Ищем есть ли такой игрок
                if (existingPlayer == null) //Если такого нет
                {
                    playerData_Level1.Add(new Player { Name = currentPlayerName, Score = 0 }); //Добавляем нового игрока
                    SavePlayersToXMLLevel1(); //И сохраняем
                }
                Level1 level1 = new Level1(this); //Создаем форму 
                level1.Show(); //Переход на эту форму
            }
        }

        public void SavePlayersToXMLLevel2()
        {
            XmlSerializer serialize = new XmlSerializer(typeof(BindingList<Player>));
            using (StreamWriter sw = new StreamWriter(FILEPATH_LEVEL2)) //Открывает файл для записи, если этот файл уже есть, то он его перезаписывает
            {
                serialize.Serialize(sw, playerData_Level2); //Запись данных в XML файл
            }
        }
        private void SavePlayersToXMLLevel1()
        {
            XmlSerializer serialize = new XmlSerializer(typeof(BindingList<Player>));
            using (StreamWriter sw = new StreamWriter(FILEPATH_LEVEL1)) //Открывает файл для записи, если этот файл уже есть, то он его перезаписывает
            {
                serialize.Serialize(sw, playerData_Level1); //Запись данных в XML файл
            }
        }
        private void SavePlayersToXMLLevel3()
        {
            XmlSerializer serialize = new XmlSerializer(typeof(BindingList<Player>));
            using (StreamWriter sw = new StreamWriter(FILEPATH_LEVEL3)) //Открывает файл для записи, если этот файл уже есть, то он его перезаписывает
            {
                serialize.Serialize(sw, playerData_Level3); //Запись данных в XML файл
            }
        }

        private void LoadPlayerToXMLLevel2()
        {
            if (File.Exists(FILEPATH_LEVEL2)) //Существует ли этот файл
            {
                XmlSerializer serialize = new XmlSerializer(typeof(BindingList<Player>));
                using (StreamReader sr = new StreamReader(FILEPATH_LEVEL2))
                {
                    playerData_Level2 = (BindingList<Player>)serialize.Deserialize(sr); //Десериализация содержимого в BindingList
                }
            }
        }
        private void LoadPlayerToXMLLevel1()
        {
            if (File.Exists(FILEPATH_LEVEL1)) //Существует ли этот файл
            {
                XmlSerializer serialize = new XmlSerializer(typeof(BindingList<Player>));
                using (StreamReader sr = new StreamReader(FILEPATH_LEVEL1))
                {
                    playerData_Level1 = (BindingList<Player>)serialize.Deserialize(sr); //Десериализация содержимого в BindingList
                }
            }
        }
        private void LoadPlayerToXMLLevel3()
        {
            if (File.Exists(FILEPATH_LEVEL3)) //Существует ли этот файл
            {
                XmlSerializer serialize = new XmlSerializer(typeof(BindingList<Player>));
                using (StreamReader sr = new StreamReader(FILEPATH_LEVEL3))
                {
                    playerData_Level3 = (BindingList<Player>)serialize.Deserialize(sr); //Десериализация содержимого в BindingList
                }
            }
        }

        private void clearData_button_Click(object sender, EventArgs e)
        {
            playerData_Level1.Clear();
            playerData_Level2.Clear();
            playerData_Level3.Clear();//Очищаем данные из DataGridView для разработчика
            if (File.Exists(FILEPATH_LEVEL1) && (File.Exists(FILEPATH_LEVEL2)) && (File.Exists(FILEPATH_LEVEL3))) //Если такой файл существует
            {
                SavePlayersToXMLLevel1(); //Перезаписываем данные
                SavePlayersToXMLLevel2(); //Перезаписываем данные
                SavePlayersToXMLLevel3(); //Перезаписываем данные
            }
        }

        public void UpdatePlayerScoreLevel2(int score, bool reset = false)
        {
            var player = playerData_Level2.FirstOrDefault(p => p.Name == currentPlayerName);
            if (player == null)
            {
                // Add a new player if not found
                playerData_Level2.Add(new Player { Name = currentPlayerName, Score = score });
            }
            else if (reset)
            {
                player.Score = score;
            }
            else
            {
                player.Score += score;
            }
            SavePlayersToXMLLevel2(); //Save changes
        }
        public void UpdatePlayerScoreLevel1(int score, bool reset = false)
        {
            var player = playerData_Level1.FirstOrDefault(p => p.Name == currentPlayerName);
            if (player == null)
            {
                // Add a new player if not found
                playerData_Level1.Add(new Player { Name = currentPlayerName, Score = score });
            }
            else if (reset)
            {
                player.Score = score;
            }
            else
            {
                player.Score += score;
            }
            SavePlayersToXMLLevel1(); // Save changes
        }
        public void UpdatePlayerScoreLevel3(int score, bool reset = false)
        {
            var player = playerData_Level3.FirstOrDefault(p => p.Name == currentPlayerName);
            if (player == null)
            {
                //Add a new player if not found
                playerData_Level3.Add(new Player { Name = currentPlayerName, Score = score });
            }
            else if (reset)
            {
                player.Score = score;
            }
            else
            {
                player.Score += score;
            }
            SavePlayersToXMLLevel3(); //Save changes
        }

        private void showRatingLevel1_button_Click(object sender, EventArgs e)
        {
            Rating_Level1 rating_level1 = new Rating_Level1(playerData_Level1); //Создание формы
            rating_level1.Show(); //Переход на новую форму
        }
        private void showRatingLevel3_button_Click(object sender, EventArgs e)
        {
            Rating_Level3 rating_Level3 = new Rating_Level3(playerData_Level3);
            rating_Level3.Show();
        }
        private void showRating_button_Click(object sender, EventArgs e)
        {
            Rating_Level2 rating_level2 = new Rating_Level2(playerData_Level2); //Создание формы
            rating_level2.Show(); //Переход на новую форму
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patches patches = new Patches();
            patches.Show();
        }
    }
}