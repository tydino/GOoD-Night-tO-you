package main;

import javax.swing.*;
import java.awt.*;

public class GamePanel extends JPanel implements Runnable{

    // WINDOW //
    public static final int windowWidth = 1280;
    public static final int windowHeight = 720;

    // FPS //
    int FPS = 30;

    // SYSTEM //
    public KeyHandler keyH = new KeyHandler(this);
    public UI ui = new UI(this);
    public Thread gameThread;

    // GAME STATE //  NEGATIVES ARE NON-PLAYING STATES
    public int gameState;
    public final int titleState = 0;
    public final int settingsState = -1;
    public final int playState = 1;
    public final int pauseState = 2;
    public final int dialogueState = 3;
    public final int inventoryState = 4;

    // INITIALIZATION //

    public GamePanel(){

        this.setPreferredSize(new Dimension(windowWidth, windowHeight));
        this.setBackground(Color.PINK);//set to black when not testing otherwise pink.
        this.setDoubleBuffered(true);
        this.addKeyListener(keyH);
        this.setFocusable(true);
    }

    public void setupGame(){

        gameState = titleState;
    }

    public void startGameThread(){
        gameThread = new Thread(this);
        gameThread.start();
    }

    @Override
    public void run() {

        double drawInterval = 1000000000/FPS;
        double delta = 0;
        long lastTime = System.nanoTime();
        long currentTime;

        while(gameThread != null){

            currentTime = System.nanoTime();

            delta += (currentTime - lastTime) / drawInterval;

            lastTime = currentTime;

            if(delta >= 1){
                update();
                repaint();
                delta--;
            }


        }

    }

    public void update(){

    }

    public void paintComponent(Graphics g){
        super.paintComponent(g);
        Graphics2D g2 = (Graphics2D) g; //drawn bottom to top on screen is top to bottom here.

        // TITLE SCREEN //
        if(gameState == titleState){
            ui.draw(g2);
        }
    }
}
