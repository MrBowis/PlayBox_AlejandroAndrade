namespace Tetris
{
    public class GameGrid
    {

        //Crear una matriz bidimencional
        //La primera dimensión es la fila y la segunda dimensi{on es la columna
        //line1
        private readonly int[,] grid;

        //Propiedades para la cantidad de filas y columnas
        //Indexador para facilitar el acceso a la matriz
        //line2
        public int Rows { get; }
        public int Columns { get; }

        //line3 
        public int this[int r, int c]
        {
            get => grid[r, c];
            set => grid[r, c] = value;
        }
        //Con está indexación se puede ingresar directamente a un objeto de Gamegrid
        //El constructor tomará la cantidad de filas y columnas de los parametros. 
        //Número de columnas
        //Número de filas
        //line4
        public GameGrid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            grid = new int[rows, columns];
        }
        //En el body, se guarda el número de fila, columnas y se inicializa la matriz. 

        //Metodos convenciales
        //Verificar si una fila y una columan están dentro de la matriz o no.
        //line5
        
    }
}
