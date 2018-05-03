using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaTran_Server
{
    public class MaTran
    {
        private int[,] _table;

        public MaTran(Dimensions dimensions) : this(dimensions.Rows, dimensions.Columns) { }

        public MaTran(int rows, int columns) : this(new int[rows, columns]) { }

        public MaTran(int[,] table)
        {
            _table = table;
        }

        public int this[int row, int column]
        {
            get
            {
                return _table[row, column];
            }
            set
            {
                _table[row, column] = value;
            }
        }

        public Dimensions TableDimensions
        {
            get
            {
                return new Dimensions(_table.GetLength(0), _table.GetLength(1));
            }
        }

        public int Rows
        {
            get
            {
                return this.TableDimensions.Rows;
            }
        }

        public int Columns
        {
            get
            {
                return this.TableDimensions.Columns;
            }
        }

        private static Dimensions GetDestinationSize(MaTran table1, MaTran table2)
        {
            int rows;
            if (table1.Rows > table2.Rows)
            {
                rows = table1.Rows;
            }
            else
            {
                rows = table2.Rows;
            }

            int columns;
            if (table1.Columns > table2.Columns)
            {
                columns = table1.Columns;
            }
            else
            {
                columns = table2.Columns;
            }
            return new Dimensions(rows, columns);
        }

        public static MaTran operator *(MaTran table1, MaTran table2)
        {
            MaTran result = new MaTran(table1.Rows, table2.Columns);
            for (int i = 0; i < table1.Rows; i++)
            {
                for (int j = 0; j < table2.Columns; j++)
                {
                    for (int k = 0; k < table1.Columns; k++)
                    {
                        result[i, j] += table1[i, k] * table2[k, j];
                    }
                }
            }            
            return result;
        }
    }

    public struct Dimensions
    {
        public Dimensions(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
        }
        private int _rows;
        public int Rows
        {
            get
            {
                return _rows;
            }
        }
        private int _columns;
        public int Columns
        {
            get
            {
                return _columns;
            }
        }

        public override string ToString()
        {
            return string.Format("Rows:{0}, Columns:{1}", this._rows, this._columns);
        }
    }
}
