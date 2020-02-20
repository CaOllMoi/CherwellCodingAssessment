using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangles
{
    public static class Triangles
    {
        private const int TriangleSideSize = 10;
        public const string ErrorInvalidInput = "Invalid input";

        public static string Question1A(string row, string col)
        {
            try
            {
                int x = Triangles.GetIntRow(row);
                int y = Convert.ToInt32(col);

                if (Triangles.ControlInputQuestion1A(x, y))
                    return Triangles.GetTriangleCoordinates(x, y);
                else
                    return ErrorInvalidInput;
            }
            catch (Exception)
            {
                return ErrorInvalidInput;
            }
            
        }

        public static string Question1B(string c1x, string c1y, string c2x, string c2y, string c3x, string c3y)
        {
            try
            {
                int ic1x = Convert.ToInt32(c1x);
                int ic1y = Convert.ToInt32(c1y);
                int ic2x = Convert.ToInt32(c2x);
                int ic2y = Convert.ToInt32(c2y);
                int ic3x = Convert.ToInt32(c3x);
                int ic3y = Convert.ToInt32(c3y);

                if (Triangles.ControlInputQuestion1B(ic1x, ic1y, ic2x, ic2y, ic3x, ic3y))
                    return Triangles.GetTriangleRowCol(ic1x, ic1y, ic2x, ic2y, ic3x, ic3y);
                else
                    return ErrorInvalidInput;
            }
            catch (Exception)
            {
                return ErrorInvalidInput;
            }
        }

        private static string GetTriangleCoordinates(int row, int col)
        {
            int c1x, c1y, c2x, c2y, c3x, c3y;

            if (col % 2 == 1)
            {
                //odd columns
                /*
                 *          (c2x,c2y)
                 *              |\
                 *              | \  
                 *              |  \ 
                 *              |___\    
                 *       (c1x,c1y)   (c3x,c3y)
                 */

                c1x = (col - 1) / 2 * TriangleSideSize;
                c1y = row * TriangleSideSize;

                c2x = c1x;
                c2y = (row - 1) * TriangleSideSize;

                c3x = (col + 1) / 2 * TriangleSideSize;
                c3y = c1y;

            }
            else
            {
                //even columns

                /*
                 *    (c3x,c3y) ____  (c1x,c1y)
                 *              \   |
                 *               \  |
                 *                \ | 
                 *                 \| (c2x,c2y)
                 *          
                 */

                c1x = col / 2 * TriangleSideSize;
                c1y = (row - 1) * TriangleSideSize;

                c2x = c1x;
                c2y = row * TriangleSideSize;

                c3x = ((col / 2) - 1) * TriangleSideSize;
                c3y = c1y;

            }

            return String.Format("({0},{1}) ({2},{3}) ({4},{5})", c1x, c1y, c2x, c2y, c3x, c3y);
        }

        private static string GetTriangleRowCol(int c1x, int c1y, int c2x, int c2y, int c3x, int c3y)
        {
            int row, col ;

            //odd columns
            /*
             *          (c2x,c2y)
             *              |\
             *              | \  
             *              |  \ 
             *              |___\    
             *       (c1x,c1y)   (c3x,c3y)
             */

            //even columns

            /*
             *    (c3x,c3y) ____  (c1x,c1y)
             *              \   |
             *               \  |
             *                \ | 
             *                 \| (c2x,c2y)
             *          
             */
            
            if (c3x > c1x)//odd columns
            {
                //c1y = row * TriangleSideSize;
                row = c1y/TriangleSideSize;
                //c1x = (col - 1) / 2 * TriangleSideSize;
                col = (c1x / TriangleSideSize * 2) + 1;
            }
            else // even columns
            {
                //c2y = row * TriangleSideSize;
                row = c2y / TriangleSideSize;
                //c1x = col / 2 * TriangleSideSize;
                col = c1x / TriangleSideSize * 2;
            }

 

            return string.Format("Row {0} - Column {1}", GetStringRow(row), col.ToString());
        }

        private static int GetIntRow(string row)
        {
            if (row.Length != 1 || row[0] < 'A' || row[0] > 'F')
                return 0;
            else
                return row[0] - 'A' + 1;
        }

        private static string GetStringRow(int row)
        {
            string[] array = { "A", "B", "C", "D", "E", "F" };
            return array[row-1];
        }

        private static bool ControlInputQuestion1A(int x, int y)
        {
            if(x >= 1 && x <= 6 && y >= 1 && y <= 12)
                return true;

            return false;
        }

        private static bool ControlInputQuestion1B(int c1x, int c1y, int c2x, int c2y, int c3x, int c3y)
        {
            bool ret = false;
            // Check if coordinates are between 0 and 60 and multiple of ten
            if (ValidCoordinate(c1x) && ValidCoordinate(c1y) && ValidCoordinate(c2x) && ValidCoordinate(c2y) && ValidCoordinate(c3x) && ValidCoordinate(c3y))
                ret = true;
            // Check if the triangle is valid
            if ((c1x + TriangleSideSize == c3x && c1y == c3y && c1x == c2x && c1y == c2y + 10 && c3y == c2y + TriangleSideSize)
                || (c3y == c1y && c1x == c3x + TriangleSideSize && c1x == c2x && c2y == c1y + TriangleSideSize && c2y == c3y + TriangleSideSize))
                ret = true;
            else
                ret = false;

            return ret;
        }

        private static bool ValidCoordinate(int coord)
        {
            if (coord >= 0 && coord <= 60 && coord %10 == 0)
                return true;

            return false;
        }
    }
}
