using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int players = 2;
        int moves = 0;
       

        bool player_vs_computer = true;
       

        private void ClickingButton(object sender, EventArgs e)
        {
            Button tic_tac = (Button)sender;

            if (tic_tac.Text == "")
            {
                if(flag_forplayers == true)
                {
                    if (players % 2 == 0)
                    {
                        tic_tac.Text = "X";
                        players++;
                        moves++;
                    }

                    else
                    {
                        tic_tac.Text = "O";
                        players++;
                        moves++;
                       
                    }
                }
                else if (flag_for_computer == true)
                {
                    if (player_vs_computer)
                    {
                        tic_tac.Text = "X";
                    }
                    else
                    {
                        tic_tac.Text = "O";
                    }

                    player_vs_computer = !player_vs_computer;                    
                    moves++;

                    if (!player_vs_computer)
                    {
                        computer_make_move();
                    }
                }


                if (Winner() == true) {

                    if (tic_tac.Text == "X")
                    {
                        MessageBox.Show("Player 1 win", "Result");
                        newgame();
                    }
                    else {
                        if (flag_forplayers == true)
                        {
                            MessageBox.Show("Player 2 win", "Result");
                        }
                        else if (flag_for_computer == true) {
                            MessageBox.Show("Computer win", "Result");
                        }
                        newgame();
                    }                
                }
                if (drawgame() == true) {
                    MessageBox.Show("Draw", "Result");
                    newgame();
                }
                
                
            }
        }



        public bool Winner(){
        
            if( (Board00.Text == Board01.Text) && ( Board00.Text == Board02.Text) && Board00.Text != "" ){
                    return true;
               }
            else if ((Board10.Text == Board11.Text) && (Board10.Text == Board12.Text) && Board10.Text != "")
            {
                return true;
            }
            else if ((Board20.Text == Board21.Text) && (Board20.Text == Board22.Text) && Board20.Text != "")
            {
                return true;
            }


            else if ((Board00.Text == Board10.Text) && (Board00.Text == Board20.Text) && Board00.Text != "")
            {
                return true;
            }
            else if ((Board01.Text == Board11.Text) && (Board01.Text == Board21.Text) && Board01.Text != "")
            {
                return true;
            }
            else if ((Board02.Text == Board12.Text) && (Board02.Text == Board22.Text) && Board02.Text != "")
            {
                return true;
            }


            else if ((Board00.Text == Board11.Text) && (Board00.Text == Board22.Text) && Board00.Text != "")
            {
                return true;
            }
            else if ((Board02.Text == Board11.Text) && (Board02.Text == Board20.Text) && Board02.Text != "")
            {
                return true;
            }

            else {
                return false;
            }
        }

        public bool drawgame() {

            if (moves == 9)
                {
                    return true;
                }else{
                    return false; 
                }
       }


        private void computer_make_move()
        {

            Button computer_move = null;

            computer_move = for_win_or_draw("O");

            if (computer_move == null)
            {
                computer_move = for_win_or_draw("X");

                if (computer_move == null)
                {
                    computer_move = for_corner();

                }
            }

           // if (moves < 9)
           // {
                computer_move.PerformClick();
           // }
        }


        private Button for_corner()
        {
            if (Board00.Text == "O")
            {
                if (Board02.Text == "")
                    return Board02;
                if (Board22.Text == "")
                    return Board22;
                if (Board20.Text == "")
                    return Board20;
            }

            if (Board02.Text == "O")
            {
                if (Board00.Text == "")
                    return Board00;
                if (Board22.Text == "")
                    return Board22;
                if (Board20.Text == "")
                    return Board20;
            }

            if (Board22.Text == "O")
            {
                if (Board00.Text == "")
                    return Board02;
                if (Board02.Text == "")
                    return Board02;
                if (Board20.Text == "")
                    return Board20;
            }

            if (Board20.Text == "O")
            {
                if (Board00.Text == "")
                    return Board02;
                if (Board02.Text == "")
                    return Board02;
                if (Board22.Text == "")
                    return Board22;
            }

            if (Board00.Text == "")
                return Board00;
            if (Board02.Text == "")
                return Board02;
            if (Board20.Text == "")
                return Board20;
            if (Board22.Text == "")
                return Board22;

            return null;
        }

        private Button for_win_or_draw(string symbol)
        {

            if ((Board00.Text == symbol) && (Board01.Text == symbol) && (Board02.Text == ""))
                return Board02;
            if ((Board01.Text == symbol) && (Board02.Text == symbol) && (Board00.Text == ""))
                return Board00;
            if ((Board00.Text == symbol) && (Board02.Text == symbol) && (Board01.Text == ""))
                return Board01;

            if ((Board10.Text == symbol) && (Board11.Text == symbol) && (Board12.Text == ""))
                return Board12;
            if ((Board11.Text == symbol) && (Board12.Text == symbol) && (Board10.Text == ""))
                return Board10;
            if ((Board10.Text == symbol) && (Board12.Text == symbol) && (Board11.Text == ""))
                return Board11;

            if ((Board20.Text == symbol) && (Board21.Text == symbol) && (Board22.Text == ""))
                return Board22;
            if ((Board21.Text == symbol) && (Board22.Text == symbol) && (Board20.Text == ""))
                return Board20;
            if ((Board20.Text == symbol) && (Board22.Text == symbol) && (Board21.Text == ""))
                return Board21;



            if ((Board00.Text == symbol) && (Board10.Text == symbol) && (Board20.Text == ""))
                return Board20;
            if ((Board10.Text == symbol) && (Board20.Text == symbol) && (Board00.Text == ""))
                return Board00;
            if ((Board00.Text == symbol) && (Board20.Text == symbol) && (Board10.Text == ""))
                return Board10;

            if ((Board01.Text == symbol) && (Board11.Text == symbol) && (Board21.Text == ""))
                return Board21;
            if ((Board11.Text == symbol) && (Board21.Text == symbol) && (Board01.Text == ""))
                return Board01;
            if ((Board01.Text == symbol) && (Board21.Text == symbol) && (Board11.Text == ""))
                return Board11;

            if ((Board02.Text == symbol) && (Board12.Text == symbol) && (Board22.Text == ""))
                return Board22;
            if ((Board12.Text == symbol) && (Board22.Text == symbol) && (Board02.Text == ""))
                return Board02;
            if ((Board02.Text == symbol) && (Board22.Text == symbol) && (Board12.Text == ""))
                return Board12;



            if ((Board00.Text == symbol) && (Board11.Text == symbol) && (Board22.Text == ""))
                return Board22;
            if ((Board11.Text == symbol) && (Board22.Text == symbol) && (Board00.Text == ""))
                return Board00;
            if ((Board00.Text == symbol) && (Board22.Text == symbol) && (Board11.Text == ""))
                return Board11;

            if ((Board02.Text == symbol) && (Board11.Text == symbol) && (Board20.Text == ""))
                return Board20;
            if ((Board11.Text == symbol) && (Board20.Text == symbol) && (Board02.Text == ""))
                return Board02;
            if ((Board02.Text == symbol) && (Board20.Text == symbol) && (Board11.Text == ""))
                return Board11;

            return null;
        }

        public void newgame(){
            players=2;
            moves=0;
            Board00.Text = Board01.Text = Board02.Text = Board10.Text = Board11.Text = Board12.Text = Board20.Text = Board21.Text = Board22.Text = "";
        }

        bool flag_forplayers,flag_for_computer;
        
        private void via_players_Click(object sender, EventArgs e)
        {
            flag_forplayers = true;
            flag_for_computer = false;
        }

        private void via_computer_Click(object sender, EventArgs e)
        {
            flag_for_computer = true;
            flag_forplayers = false;
        }
    }
}
