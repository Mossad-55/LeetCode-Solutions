namespace Medium;

public class ValidSudoku{
    public static bool IsValidSudoku(char[][] board){
        // Map for rows, cols, squares (the key in squares will be a tuple).
        Dictionary<int, HashSet<int>> rows = new();
        Dictionary<int, HashSet<int>> cols = new();
        Dictionary<(int, int), HashSet<int>> squares = new();

        for(int r = 0; r < 9; r++){
            // We have to intialize the hash set in rows[r] first.
            rows[r] = new();
            for(int c = 0; c < 9; c++){
                // Remember we have to intialize the hash set for both cols and squares first.
                if(!cols.ContainsKey(c))
                    cols[c] = new();
                if(!squares.ContainsKey((r / 3, c / 3)))
                    squares[(r / 3, c / 3)] = new();

                if(board[r][c] == '.') continue;

                if(rows[r].Contains(board[r][c]) ||
                   cols[c].Contains(board[r][c]) ||
                   squares[(r / 3, c / 3)].Contains(board[r][c]))
                   return false;
                
                rows[r].Add(board[r][c]);
                cols[c].Add(board[r][c]);
                squares[(r / 3, c / 3)].Add(board[r][c]);
            }
        }

        return true;
    }
}