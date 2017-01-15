package raj.asteroids;

import javax.imageio.ImageIO;
import java.awt.*;
import java.awt.geom.Area;
import java.awt.geom.Ellipse2D;
import java.awt.geom.Point2D;
import java.io.File;
import java.io.IOException;
import java.util.Collection;

class Asteroid extends Ellipse2D.Double {
    private static int size = 75;
    private Image sprite;
    private Point2D.Double vel;

    Asteroid() {
        super(Math.random() * (490-size), Math.random() * (455 - size), size, size);
        getSprite();
        double angle = Math.random() * Math.PI * 2;
        vel = new Point2D.Double(Math.cos(angle) / 3, Math.sin(angle) / 3);
    }

    Asteroid(double x, double y, int s) {
        super(x, y, s, s);
        size = s;
        getSprite();
        double angle = Math.random() * Math.PI * 2;
        vel = new Point2D.Double(Math.cos(angle) / 3, Math.sin(angle) / 3);
    }

    private void getSprite() {
        try {
            sprite = ImageIO.read(new File("res/asteroid.png")).getScaledInstance(size, size, Image.SCALE_SMOOTH);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private void move(long delta) {
        if(x <= 0 || x + size >= 490) {
            vel.x *= -1;
        }
        if(y <= 0 || y + size >= 455) {
            vel.y *= -1;
        }

        x += delta / 10 * vel.x;
        y += delta / 10 * vel.y;
    }

    void update(Collection<Asteroid> asteroids, long delta) {
        move(delta);

        for (Asteroid a : asteroids) {
            if (a != this && intersects(a)) {
                collide(a);
                int i = 0;
                while (intersects(a)) {
                    if (i++ % 2 == 0)
                        move(delta);
                    else
                        a.move(delta);
                }
            }
        }
    }

    private void collide(Asteroid a) {
        double newVelX1 = (vel.x * (getRadius() - a.getRadius()) + (2 * a.getRadius() * a.vel.x)) / (getRadius() + a.getRadius());
        double newVelY1 = (vel.y * (getRadius() - a.getRadius()) + (2 * a.getRadius() * a.vel.y)) / (getRadius() + a.getRadius());
        double newVelX2 = (a.vel.x * (a.getRadius() - getRadius()) + (2 * getRadius() * vel.x)) / (getRadius() + a.getRadius());
        double newVelY2 = (a.vel.y * (a.getRadius() - getRadius()) + (2 * getRadius() * vel.y)) / (getRadius() + a.getRadius());
        vel.x = newVelX1;
        a.vel.x = newVelX2;
        vel.y = newVelY1;
        a.vel.y = newVelY2;
    }

    double getRadius() {
        return getWidth() / 2;
    }

    boolean intersects(Ellipse2D a) {
        Area other = new Area(a);
        Area me = new Area(this);
        other.intersect(me);
        return !other.isEmpty();
    }

    void draw(Graphics g) {
        g.drawImage(sprite, (int) x, (int) y, null);
        ((Graphics2D) g).draw(this);
    }
}