namespace TicTacToeNamespace;
public class Game
{
    public char [] game_field = new char [9];
    public Game(){
        for(int i =0; i<9;i++) game_field[i]=' ';
    }
    
    public void fill_cell(int i, char mark){
            this.game_field[i] = mark;
    }

    public bool is_over(){
        if ((game_field[0].Equals('X')&&game_field[1].Equals('X')&&game_field[2].Equals('X'))||
            (game_field[3].Equals('X')&&game_field[4].Equals('X')&&game_field[5].Equals('X'))||
            (game_field[6].Equals('X')&&game_field[7].Equals('X')&&game_field[8].Equals('X'))||
            (game_field[0].Equals('X')&&game_field[3].Equals('X')&&game_field[6].Equals('X'))||
            (game_field[1].Equals('X')&&game_field[4].Equals('X')&&game_field[7].Equals('X'))||
            (game_field[2].Equals('X')&&game_field[5].Equals('X')&&game_field[8].Equals('X'))||
            (game_field[0].Equals('X')&&game_field[4].Equals('X')&&game_field[8].Equals('X'))||
            (game_field[2].Equals('X')&&game_field[4].Equals('X')&&game_field[6].Equals('X'))){
                Console.WriteLine("X Wins!");
                return true;
            }else if((game_field[0].Equals('0')&&game_field[1].Equals('0')&&game_field[2].Equals('0'))||
            (game_field[3].Equals('0')&&game_field[4].Equals('0')&&game_field[5].Equals('0'))||
            (game_field[6].Equals('0')&&game_field[7].Equals('0')&&game_field[8].Equals('0'))||
            (game_field[0].Equals('0')&&game_field[3].Equals('0')&&game_field[6].Equals('0'))||
            (game_field[1].Equals('0')&&game_field[4].Equals('0')&&game_field[7].Equals('0'))||
            (game_field[2].Equals('0')&&game_field[5].Equals('0')&&game_field[8].Equals('0'))||
            (game_field[0].Equals('0')&&game_field[4].Equals('0')&&game_field[8].Equals('0'))||
            (game_field[2].Equals('0')&&game_field[4].Equals('0')&&game_field[6].Equals('0'))){
                Console.WriteLine("0 Wins!");
                return true;
            }else{
                for(int i = 0; i<9; i++){
                    if (game_field[i]==' ') return false;
                }
            Console.WriteLine("Draw!");
            return true;
            }
    }

    public void print_game_field(){
        for (int i = 0; i<9;i++){
            if(i%3 == 0 && i!=0){
                Console.Write("\n");
            }
            Console.Write("|" + this.game_field[i] + "|");
        }
        Console.Write("\n"); 
    }
}

public class Player{
    char fig;
    public Player(char fig){
        this.fig = fig;
    }
    public int mark(int pos, Game tic){
        if (tic.game_field[pos-1]==' '){
            tic.fill_cell(pos-1, this.fig);
            return 0;
        }else return 1;
    }  
}

public class Computer{
    char fig1, fig2;
    public Computer(char fig1, char fig2){
        this.fig1 = fig1;
        this.fig2 = fig2;
    }
    public int mark(Game tic){
        int count_row1 = 0, count_row2 = 0, count_row3 = 0, count_col1 = 0, count_col2 = 0, count_col3 = 0, count_diag1 = 0, count_diag2 = 0;

        for(int i = 0; i<3; i++){
            if(tic.game_field[i]==this.fig2) count_row1++;
            if(tic.game_field[i+3]==this.fig2) count_row2++;
            if(tic.game_field[i+6]==this.fig2) count_row3++;
            if(tic.game_field[i*3]==this.fig2) count_col1++;
            if(tic.game_field[(i*3)+1]==this.fig2) count_col2++;
            if(tic.game_field[(i*3)+2]==this.fig2) count_col3++;
            if(tic.game_field[(i*3)+i]==this.fig2) count_diag1++;
            if(tic.game_field[(i+3)+i]==this.fig2) count_diag2++;
        }
        if(count_row1==2){
            if(tic.game_field[0]==' ') {tic.fill_cell(0, this.fig1); return 0;}
            if(tic.game_field[1]==' ') {tic.fill_cell(1, this.fig1);return 0;}
            if(tic.game_field[2]==' ') {tic.fill_cell(2, this.fig1);return 0;}
        }
        if(count_row2==2){
            if(tic.game_field[3]==' ') {tic.fill_cell(3, this.fig1); return 0;}
            if(tic.game_field[4]==' ') {tic.fill_cell(4, this.fig1); return 0;}
            if(tic.game_field[5]==' ') {tic.fill_cell(5, this.fig1); return 0;}
        }
        if(count_row3==2){
            if(tic.game_field[6]==' ') {tic.fill_cell(6, this.fig1); return 0;}
            if(tic.game_field[7]==' ') {tic.fill_cell(7, this.fig1); return 0;}
            if(tic.game_field[8]==' ') {tic.fill_cell(8, this.fig1); return 0;}
        }
        if(count_col1==2){
            if(tic.game_field[0]==' ') {tic.fill_cell(0, this.fig1); return 0;}
            if(tic.game_field[3]==' ') {tic.fill_cell(3, this.fig1); return 0;}
            if(tic.game_field[6]==' ') {tic.fill_cell(6, this.fig1); return 0;}
        }
        if(count_col2==2){
            if(tic.game_field[1]==' ') {tic.fill_cell(1, this.fig1); return 0;}
            if(tic.game_field[4]==' ') {tic.fill_cell(4, this.fig1); return 0;}
            if(tic.game_field[7]==' ') {tic.fill_cell(7, this.fig1); return 0;}
        }
        if(count_col3==2){
            if(tic.game_field[2]==' ') {tic.fill_cell(2, this.fig1); return 0;}
            if(tic.game_field[5]==' ') {tic.fill_cell(5, this.fig1); return 0;}
            if(tic.game_field[8]==' ') {tic.fill_cell(8, this.fig1); return 0;}
        }
        if(count_diag1==2){
            if(tic.game_field[0]==' ') {tic.fill_cell(0, this.fig1); return 0;}
            if(tic.game_field[4]==' ') {tic.fill_cell(4, this.fig1); return 0;}
            if(tic.game_field[8]==' ') {tic.fill_cell(8, this.fig1); return 0;}
        }
        if(count_diag2==2){
            if(tic.game_field[2]==' ') {tic.fill_cell(2, this.fig1); return 0;}
            if(tic.game_field[4]==' ') {tic.fill_cell(4, this.fig1); return 0;}
            if(tic.game_field[6]==' ') {tic.fill_cell(6, this.fig1); return 0;}
        }
        int rnd = new Random().Next(1,10);
        if(tic.game_field[rnd-1]==' '){
            tic.fill_cell(rnd-1, this.fig1);
            return 0;
        }else return 1;
    }  
}