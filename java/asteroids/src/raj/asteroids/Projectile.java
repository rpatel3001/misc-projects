package raj.asteroids;

import java.awt.*;
import java.awt.geom.Ellipse2D;
import java.util.Collection;

class Projectile extends Ellipse2D.Double {
    private double angle;
    private static final double SPEED = 5.0;

    Projectile(double x, double y, double angle) {
        super(x, y, 4, 4);
        this.angle = angle;
    }

    Asteroid update(Collection<Asteroid> asteroids, long delta) {
        x += delta / 10.0 * Math.cos(angle) * SPEED;
        y += delta / 10.0 * Math.sin(angle) * SPEED;

        for(Asteroid a : asteroids) {
            if(a.intersects(this)) {
                return a;
            }
        }
        return null;
    }

    void draw(Graphics g) {
        g.setColor(Color.ORANGE);
        ((Graphics2D)g).draw(this);
    }
}
