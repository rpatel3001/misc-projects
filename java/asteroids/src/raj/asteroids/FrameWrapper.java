package raj.asteroids;

import javax.swing.*;
import java.awt.*;

public class FrameWrapper {
    public static void main(String[] args) {
        MainWindow mainWindow = new MainWindow();
        JFrame frame = new JFrame();
        frame.setResizable(false);
        frame.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
        frame.setBounds(0, 0, 500, 500);
        frame.setVisible(true);
        frame.add(mainWindow);
        frame.setBackground(Color.BLACK);
        mainWindow.init();
    }
}