package cs50final.runners;

import javax.swing.JFrame;
import javax.swing.JPanel;

import cs50final.Screen;

public class FrameRunner extends JFrame {
	public static void main(String[] args) {
		JFrame f = new FrameRunner();
		JPanel s = new Screen();
		f.setSize(s.getSize());
		f.add(s);
		f.setDefaultCloseOperation(EXIT_ON_CLOSE);
		f.setVisible(true);
	}
}