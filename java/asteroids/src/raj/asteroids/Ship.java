package raj.asteroids;

import javax.imageio.ImageIO;
import java.awt.*;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.util.Collection;

class Ship extends Triangle {
    private static final double SPEED = 1.0;
    private static final double DECELERATION = 1.02;

    int rotDir = 0;

    private Image sprite, spriteon, spriteoff;
    private double velx, vely;
    boolean activeMoving;

    Ship() {
        super(250, 250, (int) (40 / Math.sqrt(3)) * 2, Math.PI);
        setImage();
    }

    private void setImage() {
        try {
            spriteoff = ImageIO.read(new File("res/ship.png")).getScaledInstance(40, 40, Image.SCALE_SMOOTH);
            spriteon = ImageIO.read(new File("res/shipon.png")).getScaledInstance(40, 40, Image.SCALE_SMOOTH);
            sprite = spriteoff;
        } catch (IOException e) {e.printStackTrace();}
    }

    boolean checkForHit(Collection<Asteroid> asteroids) {
        for (Asteroid a : asteroids) {
            if (intersects(a))
                return true;
        }
        return false;
    }

    void update(long d) {
        super.update();
        double delta = d / 10.0;
        if (activeMoving) {
            velx = Math.cos(rot + Math.PI / 2) / SPEED;
            vely = Math.sin(rot + Math.PI / 2) / SPEED;
            sprite = spriteon;
        } else {
            sprite = spriteoff;
            velx /= Math.pow(DECELERATION, delta);
            vely /= Math.pow(DECELERATION, delta);
        }

        x += velx * delta;
        y += vely * delta;

        rot += delta * rotDir * 2 * Math.PI / 180;

        if (x > 490)
            x = -10;
        if (x < -10)
            x = 490;

        if (y > 455)
            y = -45;
        if (y < -45)
            y = 455;
    }

    void draw(Graphics g) {
        BufferedImage ri = new BufferedImage(50, 50, BufferedImage.TYPE_INT_ARGB);
        ri.createGraphics();
        Graphics2D g2 = (Graphics2D) ri.getGraphics();
        //g2.fillRect(0, 0, 50, 50);
        g2.rotate(rot, 25, 25);
        g2.drawImage(sprite, 5, 5, null);

        g.drawImage(ri, (int) x - 5, (int) y, null);
        //g.setColor(Color.BLUE);
        //g.fillPolygon(this);
    }

    Projectile shoot() {
        return new Projectile(xpoints[0], ypoints[0], rot + Math.PI / 2);
    }
}