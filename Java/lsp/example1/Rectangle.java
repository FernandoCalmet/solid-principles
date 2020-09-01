package lsp.example1;

/**
 *
 * @author Fernando Calmet <https://github.com/FernandoCalmet>
 */
public class Rectangle {
    private int length;
    private int breadth;

    public int getLength() {
        return length;
    }

    public void setLength(int length) {
        this.length = length;
    }

    public int getBreadth() {
        return breadth;
    }

    public void setBreadth(int breadth) {
        this.breadth = breadth;
    }

    public int getArea() {
        return this.length * this.breadth;
    }
}