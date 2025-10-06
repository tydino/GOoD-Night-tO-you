package main;

import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class KeyHandler implements KeyListener {
    public int upKey = KeyEvent.VK_W, downKey = KeyEvent.VK_S, leftKey = KeyEvent.VK_A, rightKey = KeyEvent.VK_D, enterKey = KeyEvent.VK_ENTER;
    public int pauseKey = KeyEvent.VK_ESCAPE, inventoryKey = KeyEvent.VK_E;

    GamePanel gp;
    public boolean upPressed, downPressed, leftPressed, rightPressed, enterPressed;

    public KeyHandler(GamePanel gp){
        this.gp = gp;
    }

    @Override
    public void keyTyped(KeyEvent e) {
    }

    @Override
    public void keyPressed(KeyEvent e) {
        int code = e.getKeyCode();

        // Title State //
        if(gp.gameState == gp.titleState){
            titleState(code);
        }

        // PLAY STATE //
        else if(gp.gameState == gp.playState) {
            playState(code);
        }

        // PAUSE STATE //
        else if(gp.gameState == gp.pauseState){
            pauseState(code);
        }
    }

    @Override
    public void keyReleased(KeyEvent e) {
        int code = e.getKeyCode();

        if(code == upKey){
            upPressed = false;
        }
        if(code == leftKey){
            leftPressed = false;
        }
        if(code == rightKey){
            rightPressed = false;
        }
        if(code == downKey){
            downPressed = false;
        }
        if(code == enterKey){
            enterPressed = false;
        }
    }

    // STATES //

    //title//

    public void titleState(int code){
        if(code == upKey){
            upPressed = true;
        }
        if(code == downKey){
            downPressed = true;
        }
        if(code == enterKey){
            enterPressed = true;
        }
    }

    //play//

    public void playState(int code){
        if(code == upKey){
            upPressed = true;
        }
        if(code == leftKey){
            leftPressed = true;
        }
        if(code == rightKey){
            rightPressed = true;
        }
        if(code == downKey){
            downPressed = true;
        }
        if(code == enterKey){
            enterPressed = true;
        }
        if(code == pauseKey){
            gp.gameState = gp.pauseState;
        }
    }

    //pause//

    public void pauseState(int code){
        if(code == pauseKey){
            gp.gameState = gp.playState;
        }
    }
}
