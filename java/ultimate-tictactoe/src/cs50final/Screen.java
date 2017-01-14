package cs50final;

import java.awt.Color;
import java.awt.Font;
import java.awt.GridLayout;

import javax.swing.JLabel;
import javax.swing.JPanel;

import cs50final.T3.ClickEvent;

public class Screen extends JPanel {
	T3 games[][] = new T3[3][3];
	T3 ugame;
	char currTurn;
	
	public Screen() {
		this.setSize(618, 618);
		this.setBackground(Color.BLACK);
		
		GridLayout layout = new GridLayout(3, 3);
		layout.setHgap(5);
		layout.setVgap(5);
		this.setLayout(layout);

		for(int i = 0; i < 3; i++) {
			for(int j = 0; j < 3; j++) {
				games[i][j] = new T3(this, i*10+j);
				this.add(games[i][j]);
			}
		}
		ugame = new T3(this, -1);
		currTurn = 'X';
	}
	
	public void handleClick(ClickEvent e) {
		T3 g = games[e.ID/10][e.ID%10];
		g.set(e.ROW, e.COL, currTurn);
		
		if(currTurn == 'X')
			currTurn = 'O';
		else
			currTurn = 'X';

		for(int i = 0; i < 3; i++) {
			for(int j = 0; j < 3; j++) {
				games[i][j].setEnabled(games[e.ROW][e.COL].getWinner() != ' ' || i == e.ROW && j == e.COL);
			}
		}
		checkWin(e);
	}
	
	public void checkWin(ClickEvent e) {
		int row = e.ID/10;
		int col = e.ID%10;
		char subwinner = games[row][col].checkWin();
		if(subwinner != ' ') {
			games[row][col].setWinner(subwinner);
			ugame.set(row, col, subwinner);
			if(e.ROW == row && e.COL == col) {
				for(T3[] gs : games) 
					for(T3 g : gs) {
						g.setEnabled(true);
					}
			}
			char winner = ugame.checkWin();
			if(winner != ' ') {
				this.removeAll();
				this.setLayout(new GridLayout(1,1));
				JLabel l = null;
				if(winner == '-') {
					l = new JLabel("Tie");
					l.setFont(new Font("Arial", Font.PLAIN, 400));
				} else  {
					l = new JLabel(winner+"");
					l.setFont(new Font("Arial", Font.PLAIN, 600));
				}
				l.setHorizontalAlignment(JLabel.CENTER);
				l.setVerticalAlignment(JLabel.CENTER);
				this.setBackground(Color.WHITE);
				l.setForeground(Color.BLACK);
				this.add(l);
			}
		}
	}
}