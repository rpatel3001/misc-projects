package cs50final;

import java.awt.Color;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;

public class T3 extends JPanel implements ActionListener {
	private JButton board[][] = new JButton[3][3];
	private static Screen mainGame;
	private final int ID;
	private char winner;
	
	public T3(Screen g, int id) {
		ID = id;
		mainGame = g;
		winner = ' ';
		
		this.setBackground(Color.BLACK);
		GridLayout layout = new GridLayout(3, 3);
		layout.setHgap(1);
		layout.setVgap(1);
		this.setLayout(layout);

		for(int i = 0; i < 3; i++) {
			for(int j = 0; j < 3; j++) {
				board[i][j] = new JButton("");
				board[i][j].setName(i+""+j);
				board[i][j].setBorderPainted(false);
				board[i][j].setOpaque(true);
				board[i][j].setBackground(Color.WHITE);
				board[i][j].addActionListener(this);
				board[i][j].setFont(new Font("Arial", Font.BOLD, 40));
				this.add(board[i][j]);
			}
		}
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		if(!(e.getSource() instanceof JButton)) return;
		
		JButton src = (JButton) e.getSource();
		int btnid = Integer.parseInt(src.getName());
		mainGame.handleClick(new ClickEvent(btnid/10, btnid%10, this.ID));
	}
	
	public void set(int row, int col, char player) {
		if(winner != ' ') {
			throw new UnsupportedOperationException("Cannot make a move on a completed board.");
		}
		
		board[row][col].setText(player+"");
		board[row][col].setEnabled(false);
	}
	
	@Override
	public void setEnabled(boolean e) {
		for(int i = 0; i < 3; i++) {
			for(int j = 0; j < 3; j++) {
				boolean done = !board[i][j].getText().equals("");
				if(e && !done) {
					board[i][j].setEnabled(true);
					board[i][j].setBackground(Color.WHITE);
				} else  {
					board[i][j].setEnabled(false);
					board[i][j].setBackground(Color.GRAY);
				}
			}
		}
	}
	
	public char checkWin() {	
		char winner = ' ';
		for(int i = 0; i < 3; i++) {
			if(board[i][0].getText().equals(board[i][1].getText()) && board[i][0].getText().equals(board[i][2].getText()) && !board[i][0].getText().equals("")) {
				winner = board[i][0].getText().charAt(0);
			} else if(board[0][i].getText().equals(board[1][i].getText()) && board[0][i].getText().equals(board[2][i].getText()) && !board[0][i].getText().equals("")) {
				winner = board[0][i].getText().charAt(0);
			}
		}
		if((board[0][0].getText().equals(board[1][1].getText()) && board[0][0].getText().equals(board[2][2].getText())
				|| board[0][2].getText().equals(board[1][1].getText()) && board[0][2].getText().equals(board[2][0].getText())) && !board[1][1].getText().equals("")) {
			winner = board[1][1].getText().charAt(0);
		}
		if(winner != ' ') {
			return winner;
		}

		for(int i = 0; i < 3; i++) {
			for(int j = 0; j < 3; j++) {
				if(board[i][j].getText().equals("")) {
					return winner;
				}
			}
		}
		return '-';
	}
	
	public class ClickEvent {
		public final int ROW, COL, ID;
		public ClickEvent(int r, int c, int id) {
			ROW = r;
			COL = c;
			ID = id;
		}
		@Override
		public String toString() {
			return ROW + "x" + COL + "@" + ID;
		}
	}

	public void setWinner(char w) {
		winner = w;
		this.removeAll();
		this.setLayout(new GridLayout(1,1));
		JLabel l = null;
		if(winner == '-') {
			l = new JLabel("Tie");
			l.setFont(new Font("Arial", Font.PLAIN, 100));
		} else  {
			l = new JLabel(w+"");
			l.setFont(new Font("Arial", Font.PLAIN, 200));
		}
		l.setHorizontalAlignment(JLabel.CENTER);
		l.setVerticalAlignment(JLabel.CENTER);
		this.setBackground(Color.WHITE);
		l.setForeground(Color.BLACK);
		this.add(l);
	}

	public char getWinner() {
		return winner;
	}
}