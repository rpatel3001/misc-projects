package cs50final.runners;

import javax.swing.JApplet;
import javax.swing.JPanel;

import cs50final.Screen;

public class JAppletRunner extends JApplet {
	@Override
	public void start() {
		JPanel s = new Screen();
		setSize(s.getSize());
		add(s);
	}
}