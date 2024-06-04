namespace LeetCodeSolutions.BackTracking
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> children;
        public bool isWord;
        public TrieNode() 
        {
            children = new Dictionary<char, TrieNode>();
            isWord = false;
        }

        public void AddWord(string word)
        {
            TrieNode curr = this;
            foreach (char ch in word)
            {
                if(!curr.children.ContainsKey(ch))
                    curr.children[ch] = new TrieNode();
                curr = curr.children[ch];
            }

            curr.isWord = true;
        }
    }

    public class WordSearch
    {
        HashSet<string> res = new HashSet<string>();

        public IList<string> FindWords(char[][] board, string[] words)
        {
            var root = new TrieNode();

            foreach(string word in words) 
            {
                root.AddWord(word);
            }

            int rows = board.Length;
            int columns = board[0].Length;

            for(int i = 0; i<rows; i++)
            {
                for(int j = 0; j<columns; j++)
                {
                    BackTrack(board, i, j, rows, columns, root, "");
                }
            }

            return res.ToList();
        }

        private void BackTrack(char[][] board, int row, int column, int rows, int columns, TrieNode node, string word)
        {
            if (row < 0 || column < 0 || row >= rows || column >= columns || board[row][column] == '1' || !node.children.ContainsKey(board[row][column]))
                return;

            
            node = node.children[board[row][column]];
            word += board[row][column];

            if(node.isWord)
                res.Add(word);

            char temp = board[row][column];
            board[row][column] = '1';

            BackTrack(board, row - 1, column, rows, columns, node, word);
            BackTrack(board, row + 1, column, rows, columns, node, word);
            BackTrack(board, row, column -1, rows, columns, node, word);
            BackTrack(board, row, column +1, rows, columns, node, word);

            board[row][column] = temp;

        }

        //public IList<string> FindWords(char[][] board, string[] words)
        //{
        //    IList<string> result = new List<string>();

        //    bool wordFound = false;

        //    foreach (var word in words)
        //    {
        //        wordFound = false;

        //        if (word.Length == 0) { continue; }

        //        for (int i = 0; i < board.Length; i++)
        //        {
        //            for (int j = 0; j < board[i].Length; j++)
        //            {
        //                if(FindWord(board, i, j, word, 0))
        //                {  
        //                   result.Add(word); 
        //                   wordFound = true;
        //                   break; 
        //                }
        //            }
        //            if (wordFound) { break; }
        //        }
        //    }

        //    return result;
        //}

        //private bool FindWord(char[][] board, int i, int j, string word, int wordPosition)
        //{
        //    if (word.Length == wordPosition) //word is found
        //        return true;

        //    if(i<0 || j<0 || i >= board.Length || j >= board[0].Length || board[i][j] == '1' || board[i][j] != word[wordPosition]) 
        //        return false;

        //    char temp;

        //    bool matchFound = false;

        //    if (board[i][j] == word[wordPosition])
        //    {
        //        temp = board[i][j];
        //        board[i][j] = '1';

        //        matchFound = FindWord(board, i, j + 1, word, wordPosition + 1)
        //                    || FindWord(board, i, j - 1, word, wordPosition + 1)
        //                    || FindWord(board, i - 1, j, word, wordPosition + 1)
        //                    || FindWord(board, i + 1, j, word, wordPosition + 1);

        //        board[i][j] = temp;

        //    }

        //    return matchFound;

        //}
    }
}
