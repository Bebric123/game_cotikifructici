using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИГРУЛЬКА
{
    public partial class Patches : Form
    {
        public Patches()
        {
            InitializeComponent();
        }

        private void Patches_Load(object sender, EventArgs e)
        {
            this.richTextBox = new RichTextBox();
            this.SuspendLayout();

            // Настройка RichTextBox
            this.richTextBox.Dock = DockStyle.Fill;
            this.richTextBox.ReadOnly = true;
            this.richTextBox.BorderStyle = BorderStyle.None;
            this.richTextBox.BackColor = this.BackColor; // Чтобы фон совпадал с фоном формы

            // Добавление RichTextBox на форму
            this.Controls.Add(this.richTextBox);

            // Настройки формы
            this.ClientSize = new Size(400, 300);
            this.ResumeLayout(false);

            string patchNotes = @"{\rtf1\ansi
{\b Обновления и Улучшения:}
\par\pard\li200 {\ul Оптимизация Рейтинга:} Устранена проблема с суммированием очков.
\par {\ul Рейтинг по Уровням:} Введение индивидуальных рейтингов.
\par {\ul Новые Уровни:} Добавлены два захватывающих уровня.
\par {\ul Исправлен 1 и 3 уровень:} Ошибка при нажатии на изображение устранена.
\par {\ul Фильтр Рейтинга:} Игроки с нулевым количеством очков больше не отображаются.
\par {\ul Порог Входа:} Необходимо набрать минимальное количество очков.
\par {\ul Исправление Игрового Процесса:} Исправлена ошибка многоразового нажатия.
\par {\ul Доработан дизайн игры:} Добавлены новые анимации и иконка игры в углу.
\par {\ul Опимизировано создание изображений: } Обновлена генерация изображений.
\par
}";
            this.richTextBox.Rtf = patchNotes;
        }
    }
}
