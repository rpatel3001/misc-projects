package raj.asteroids;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.util.Vector;

public class MainWindow extends JPanel implements ActionListener, KeyListener {
    private static final long serialVersionUID = 1L;
    private Timer timer;
    private long startTime;
    private Ship player;
    private Vector<Asteroid> asteroids;
    private static final int splashDelay = 3000;
    private long lastFrame;
    private Vector<Projectile> shots;
    private String done;

    void init() {
        asteroids = new Vector<>(10);
        shots = new Vector<>(10);
        lastFrame = System.currentTimeMillis();
        startTime = System.currentTimeMillis();
        setBackground(Color.BLACK);
        setBounds(0, 0, 500, 500);
        setVisible(true);
        setFocusable(true);

        player = new Ship();
        for (int a = 0; a < 7; a++) {
            Asteroid as;
            do {
                as = new Asteroid();
            } while(player.intersects(as));
            asteroids.add(as);
        }
        addKeyListener(this);
        timer = new Timer(30, this);
        timer.setInitialDelay(0);
        timer.start();
    }

    public void paint(Graphics g) {
        super.paint(g);

        if(done != null) {
            g.setColor(Color.LIGHT_GRAY);
            g.setFont(new Font("Arial", Font.BOLD, 80));
            FontMetrics metric = g.getFontMetrics();
            g.drawString(done, (getWidth() - metric.stringWidth(done)) / 2, getHeight() / 2 - 100);
            return;
        }

        if (asteroids != null)
            for (Asteroid a : asteroids)
                a.draw(g);

        if (shots != null)
            for (Projectile s : shots)
                s.draw(g);

        if (player != null)
            player.draw(g);

        if (System.currentTimeMillis() - startTime < splashDelay) {
            g.setColor(Color.LIGHT_GRAY);
            g.setFont(new Font("Arial", Font.BOLD, 80));
            FontMetrics metric = g.getFontMetrics();
            String str = "ASTEROIDS";
            g.drawString(str, (getWidth() - metric.stringWidth(str)) / 2, getHeight() / 2 - 100);
            g.setFont(new Font("Arial", Font.BOLD, 35));
            metric = g.getFontMetrics();
            str = "Press P to Pause";
            g.drawString(str, (getWidth() - metric.stringWidth(str)) / 2, getHeight() / 2);
            str = "WASD / SPACE to control";
            g.drawString(str, (getWidth() - metric.stringWidth(str)) / 2, getHeight() / 2 + 100);
        }
    }

    private void finish(String s) {
        removeKeyListener(this);
        shots.removeAllElements();
        player = null;
        done = s;
        lastFrame = System.currentTimeMillis();
    }


    public void actionPerformed(ActionEvent e) {
        if(done != null) {
            repaint();
            if(System.currentTimeMillis() - lastFrame > splashDelay) {
                System.exit(0);
            } else {
                return;
            }
        }

        long delta = System.currentTimeMillis() - lastFrame;
        lastFrame = System.currentTimeMillis();

        player.update(delta);
        if (System.currentTimeMillis() - startTime >= splashDelay)
            if (player.checkForHit(asteroids)) {
                finish("You lose!");
                return;
        }

        for (Asteroid a : asteroids)
            a.update(asteroids, delta);

        Vector<Projectile> removeShots = new Vector<>();
        Vector<Asteroid> removeAsteroids = new Vector<>();
        Vector<Asteroid> addAsteroids = new Vector<>();
        for (Projectile s : shots) {
            if (s.x < 0 || s.y < 0 || s.x > 490 || s.y > 455) {
                removeShots.add(s);
                continue;
            }
            Asteroid hit = s.update(asteroids, delta);
            if (hit != null) {
                removeShots.add(s);
                removeAsteroids.add(hit);
                if (hit.getRadius() > 25) {
                    addAsteroids.add(new Asteroid(hit.getCenterX(), hit.getCenterY(), (int) hit.getRadius()));
                    addAsteroids.add(new Asteroid(hit.getCenterX(), hit.getCenterY(), (int) hit.getRadius()));
                }
            }
        }
        shots.removeAll(removeShots);
        asteroids.removeAll(removeAsteroids);
        asteroids.addAll(addAsteroids);
        if (asteroids.size() == 0) {
            finish("You win!");
            return;
        }

        repaint();
    }

    public void keyPressed(KeyEvent k) {
        int code = k.getKeyCode();

        if (code == KeyEvent.VK_W)
            player.activeMoving = true;

        if (code == KeyEvent.VK_A)
            player.rotDir = -1;
        else if (code == KeyEvent.VK_D)
            player.rotDir = 1;

        if (code == KeyEvent.VK_SPACE)
            shots.add(player.shoot());
    }

    public void keyReleased(KeyEvent k) {
        int code = k.getKeyCode();

        if (code == KeyEvent.VK_W)
            player.activeMoving = false;

        if (code == KeyEvent.VK_A || code == KeyEvent.VK_D)
            player.rotDir = 0;

        if (code == KeyEvent.VK_P) {
            if (timer.isRunning())
                timer.stop();
            else {
                lastFrame = System.currentTimeMillis();
                timer.start();
            }
        }
    }

    public void keyTyped(KeyEvent k) {}
}