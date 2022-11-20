using TicTacToeNamespace;

Game ng = new Game();
Player human = new Player('X');
Computer comp = new Computer('0', 'X');
ng.print_game_field();
Console.WriteLine("Player 1, enter position from 1 to 9");
int pos = int.Parse(Console.ReadLine());
while (!ng.is_over()){    
    while(human.mark(pos, ng)!=0){
        ng.print_game_field();
        Console.WriteLine("Player 1, enter position from 1 to 9");
        pos = int.Parse(Console.ReadLine());
        int end = human.mark(pos, ng);
        if (end==0) break;
        if (ng.is_over()) break;
    }
    while(comp.mark(ng)!=0){
        int end = comp.mark(ng);
        if (end==0) break;
        if (ng.is_over()) break;
    }        
}