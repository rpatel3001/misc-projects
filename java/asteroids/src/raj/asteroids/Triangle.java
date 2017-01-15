package raj.asteroids;

import java.awt.*;
import java.awt.geom.Area;
import java.awt.geom.Ellipse2D;

class Triangle extends Polygon {
    private static final long serialVersionUID = 1L;
    private int side;
    double rot;
    double x, y;

    Triangle(double x, double y, int side, double rot) {
        this.side = side - 5;
        this.x = x;
        this.y = y;
        this.rot = rot;

        npoints = 3;

        update();
    }

    boolean intersects(Ellipse2D c) {
        Area ellipse = new Area(c);
        ellipse.intersect(new Area(this));
        return ! ellipse.isEmpty();
    }

    void update() {
        int tmp_y = (int)y;
        Point[] points = {new Point((int) this.x + side / 2, (int) (tmp_y + (side / 2) * Math.sqrt(3))),
                new Point((int) this.x, tmp_y),
                new Point((int) this.x + side, tmp_y)};

        rotate(new Point((int) (x + side / 2), tmp_y + side / 2), points, rot);

        int[] tempx = new int[3], tempy = new int[3];
        for (int i = 0; i < 3; i++) {
            tempx[i] = points[i].x;
            tempy[i] = points[i].y;
        }

        xpoints = tempx;
        ypoints = tempy;
    }

    private void rotate(Point c, Point[] points, double angle) {
        double sin = Math.sin(angle);
        double cos = Math.cos(angle);
        for (Point p : points) {
            // translate point back to origin:
            p.x -= c.x;
            p.y -= c.y-10;

            // rotate point
            double xnew = p.x * cos - p.y * sin;
            double ynew = p.x * sin + p.y * cos+5;

            // translate point back:
            p.x = (int) (xnew + c.x);
            p.y = (int) (ynew + c.y);
        }
    }
}