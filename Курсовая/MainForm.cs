using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Структура данных для хранения информации о графе.
        /// </summary>
        private struct GraphInfo
        {
            // Задаём структуру функций и универсальных методов для осуществления запросов получения (get) и установки (set) значений.
            public int Radius { get; set; } // Радиус графа.
            public int Diameter { get; set; } // Диаметр графа.
            public List<int> Centers { get; set; } // Список центральных вершин графа.
            public List<Tuple<int, int>> Bridges { get; set; } // Список мостов графа.
            public int ChromaticNumber { get; set; } // Хроматическое число графа.
        }

        // Задаём переменные для класса.
        private int mWidth = -1; // Делаем переменную количества столбцов матрицы смежности отрицательной, так как порядок нумерации начинается с 0.
        private int mTimer;
        private List<bool> mUsed = new List<bool>(); // Текущий узел в алгоритме нахождения мостов.
        private List<int> mTin = new List<int>(); // Время вхождения для нахождения мостов.
        private List<int> mFup = new List<int>(); // Время выхода для нахождения мостов.
        private List<Tuple<int, int>> mBridges = new List<Tuple<int, int>>(); // Инициализируем список мостов графа.

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Формируем матрицу смежности, заполненную нулями.
        /// </summary>
        private void GenerateMatrix()
        {
            mWidth = (int)WidthUpDown.Value; //Количество столбцов матрицы смежности.

            // Задаем размеры матрицы смежности.
            Matrix.ColumnCount = mWidth;
            Matrix.RowCount = 0;

            var row = new List<string>(); // Инициализируем список строк.

            // Заполняем список строк нулями.
            for (int j = 0; j < mWidth; ++j)
                row.Add("0");

            var array = row.ToArray(); // Инициализируем массив array и заполняем значениями из списка row.

            // Добавляем строки в массив.
            for (int i = 0; i < mWidth; ++i)
                Matrix.Rows.Add(array);

            // Задаем размеры ячеек в DataGridView.
            for (int i = 0; i < mWidth; ++i)
            {
                Matrix.Columns[i].Width = 22; // Задаём ширину ячеек таблицы.

                // Задаём нумерацию строк и столбцов в DataGridView.
                Matrix.Columns[i].HeaderText = (i + 1).ToString();
                Matrix.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        /// <summary>
        /// Заполнить матрицу значениями из DataGridView.
        /// </summary>
        /// <returns>Заполненная матрица.</returns>
        private List<List<int>> FillMatrix()
        {
            var m = new List<List<int>>(mWidth); // Инициализируем локальную переменную списка (для удобства).

            for (int i = 0; i < mWidth; ++i)
            {
                // Инициализируем новый список для каждой строки матрицы смежности.
                m.Add(new List<int>(mWidth));

                // Заполняем список.
                for (int j = 0; j < mWidth; ++j)
                    m[i].Add(int.Parse((string)Matrix.Rows[i].Cells[j].Value));
            }

            return m; // Возвращаем заполненный список.
        }

        /// <summary>
        /// Получить диаметр, радиус, центральные вершины графа.
        /// </summary>
        /// <returns>Структура с информацией.</returns>
        private GraphInfo GetGraphInfo()
        {
            var d = FillMatrix(); // Присваиваем переменной d заполненный функцией FillMatrix список.

            // Заполняем отсутствующие ребра большими числами для удобства выполнения алгоритма.
            for (int i = 0; i < mWidth; ++i)
                for (int j = 0; j < mWidth; ++j)
                    if (i != j && d[i][j] == 0)
                        d[i][j] = 1000000;

            // Алгоритм Флойда-Уоршелла.
            for (int k = 0; k < mWidth; ++k)
                for (int i = 0; i < mWidth; ++i)
                    for (int j = 0; j < mWidth; ++j)
                        d[i][j] = Math.Min(d[i][j], d[i][k] + d[k][j]);

            // Создаем список дистанций.
            var distances = (
                from v
                in d
                select v.Max()
            ).ToList();

            // Находим радиус и диаметр графа. 
            var min = distances.Min(); // Радиус графа. 
            var max = distances.Max(); // Диаметр графа. 

            var centers = new List<int>();

            // Составляем список центральных вершин графа. 
            for (int i = 0; i < distances.Count; ++i)
                if (distances[i] == min)
                    centers.Add(i + 1);

            /* var centers = ( 
            from v 
            in distances 
            where v == min 
            select v 
            ); */

            // Возвращаем структуру, содержащую информацию о графе. 
            return new GraphInfo
            {
                Radius = min,
                Diameter = max,
                Bridges = new List<Tuple<int, int>>(),
                Centers = centers, // .ToList(), 
                ChromaticNumber = 0
            };
        }

        /// <summary>
        /// Добавляем мост в коллекцию.
        /// </summary>
        /// <param name="from">Откуда.</param>
        /// <param name="to">Куда.</param>
        void IsBridge(int from, int to) 
            => mBridges.Add(new Tuple<int, int>(from, to));

        /// <summary>
        /// Поиск в глубину для нахождения мостов.
        /// </summary>
        /// <param name="graph">Граф для обработки.</param>
        /// <param name="v">Текущая вершина.</param>
        /// <param name="p">Предыдущая вершина.</param>
        void Dfs(List<List<int>> graph, int v, int p = -1)
        {
            mUsed[v] = true;
            mTin[v] = mFup[v] = mTimer++; // Время вхождения в текущую вершину, инкремент переменной таймера.

            // Обходим соседей.
            for (int i = 0; i < mWidth; ++i)
            {
                int to;

                if (graph[v][i] == 1)
                    to = i;
                else
                    continue;

                if (to == p)
                    continue;

                if (mUsed[to])
                {
                    mFup[v] = Math.Min(mFup[v], mTin[to]);
                }
                else
                {
                    Dfs(graph, to, v);
                    mFup[v] = Math.Min(mFup[v], mFup[to]);

                    if (mFup[to] > mTin[v])
                        IsBridge(v, to);
                }
            }
        }

        /// <summary>
        /// Найти мосты в заданном графе.
        /// </summary>
        /// <param name="graph">Граф, заданный матрицей смежности.</param>
        /// <returns>Список мостов.</returns>
        List<Tuple<int, int>> FindBridges(List<List<int>> graph)
        {
            // Обнуляем переменные и очищаем массивы.
            mTimer = 0;
            mBridges.Clear();
            mUsed.Clear();
            mTin.Clear();
            mFup.Clear();

            // Заполняем массивы нулями.
            for (int i = 0; i < mWidth; ++i)
            {
                mUsed.Add(false);
                mTin.Add(0);
                mFup.Add(0);
            }

            // Заупскаем поиск в глубину из каждой вершины.
            for (int i = 0; i < mWidth; ++i)
                if (!mUsed[i])
                    Dfs(graph, i);

            return mBridges;
        }

        /// <summary>
        /// Найти хроматическое число графа.
        /// </summary>
        /// <param name="graph">Граф.</param>
        /// <returns>Хроматическое число.</returns>
        int ChromaticNumber(List<List<int>> graph)
        {
            var colors = new List<int>(mWidth);

            // Заполняем список цветов "пустыми" значениями.
            for (int i = 0; i < mWidth; ++i)
                colors.Add(-1);

            // Поочерёдно расскрашиваем вершины графа, учитывая инцидентные вершины.
            for (int i = 0; i < mWidth; ++i)
            {
                var cols = new SortedSet<int>();

                for (int j = 0; j < mWidth; ++j)
                    if (graph[i][j] == 1)
                        cols.Add(colors[j]);

                int color = 0; // Порядковые номера цветов графа.

                while (cols.Contains(color))
                    ++color; // Инициализация нового цвета.

                colors[i] = color; // Присваивание нового цвета
            }

            return colors.Max() + 1; // Возвращает порядковый номер последнего использованного цвета, прибавляем 1, так как порядок начинается с 0.
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateMatrix();
        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {

            label3.Text = "Метрические характеристики (нумерация узлов с 1):";
            label4.Text = "Диаметр графа:";
            label5.Text = "Радиус графа:";
            label6.Text = "Центральные вершины графа:";
            label7.Text = "Мосты графа:";
            label8.Text = "Топологические характеристики:";
            label9.Text = "Хроматическое число графа:";
            DiameterLabel.Text = "-";
            RadiusLabel.Text = "-";
            CenterLabel.Text = "-";
            BridgesLabel.Text = "-";
            ChromaticLabel.Text = "-";
            // Приводим информацию о графе в формат вывода.

            var graph = FillMatrix();
            var gi = GetGraphInfo();

            gi.Bridges = FindBridges(graph); // Поиск мостов графа.
            gi.ChromaticNumber = ChromaticNumber(graph); // Нахождение хроматического числа графа.

            var sb = new StringBuilder(); // Используем класс для форматирования строковых данных StringBuilder.

            foreach (var v in gi.Bridges)
                sb.Append($"{v.Item1}-{v.Item2}, "); // Формируем строку, содержащую все мосты графа.

            if (sb.Length > 0)
                sb.Length -= 2; // Убираем 2 последних символа (запятая и пробел) в последней паре мостов графа.

            var bridgesString = sb.ToString();

            sb = new StringBuilder();

            foreach (var v in gi.Centers)
                sb.Append($"{v}, "); // Формируем строку, содержащую все центральные вершины графа.

            if (sb.Length > 0)
                sb.Length -= 2; // Убираем 2 последних символа (запятая и пробел) после последней центральной вершины графа.

            var centersString = sb.ToString();

            // Проверка наличия диаметра.
            if (gi.Diameter == 1000000)
                gi.Diameter = 0; 
            
            // Проверка наличия радиуса.
            if (gi.Radius == 1000000)
                gi.Radius = 0;

            // Меняем Label'ы на полученные данные.
            DiameterLabel.Text = Convert.ToString((int)gi.Diameter);
            RadiusLabel.Text = Convert.ToString((int)gi.Radius);
            CenterLabel.Text = centersString;
            BridgesLabel.Text = bridgesString;
            ChromaticLabel.Text = Convert.ToString((int)gi.ChromaticNumber);

            TabControl.SelectedTab = TabControl.TabPages[1]; // Переключаем вкладку для TabControl.
        }

        private void Matrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int num;
            DataGridViewCell c = null;
            
            // Проверка исключений, заполнять DataGridView можно только 0 или 1, в ином случае, ячейке указывается значение 1.
            try
            {
                c = Matrix.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (e.RowIndex == e.ColumnIndex) // Проверка главной диагонали, для того, чтобы не допустить ввод матрицы смежности графа с петлями.
                {
                    c.Value = "0";
                    return;
                }

                num = int.Parse((string)c.Value);

                if (num == 0)
                    c.Value = "0";
                else
                    c.Value = "1";
            }
            catch (FormatException)
            {
                c.Value = "1";
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }
    }
}
