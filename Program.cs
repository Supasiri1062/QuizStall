class program {
    static void Main (string[] args) {
    char[] board = {'_','_','_','_','_','_','_'};
        int space = int.Parse(Console.ReadLine());
        int[] num = new int[space];
        for(int i = 0; i < space; i++) {
            num[i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < space; i++) {
            if( num[i] % 2 == 0 ) {
                Console.WriteLine(num[i]);
            }
        }
        Console.Write("Select your Stall : ");
        int reserved1 = int.Parse(Console.ReadLine());
        int reserved2 = int.Parse(Console.ReadLine());

        
    static bool CheckInvalidInput(int space, char[] board) {
        return ((space < 1 || space > 7)
        || (board[space - 1] == 'X' || board[space - 1] == '_'));
    }
   
    }
}