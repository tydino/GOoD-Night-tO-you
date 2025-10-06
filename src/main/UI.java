package main;

import java.awt.*;

public class UI {

    GamePanel gp;
    Graphics2D g2;
    Font arial_40 = new Font("Arial", Font.PLAIN, 40);
    public int commandNum;

    public UI(GamePanel gp){
        this.gp = gp;
    }

    public void draw(Graphics2D g2){
        this.g2 = g2;

        g2.setFont(arial_40);
        g2.setColor(Color.WHITE);

        // STATES //
        if(gp.gameState == gp.titleState){
            drawTitleScreen();
        }
    }

    // STATE UI //

    //title//

    public void drawTitleScreen(){

        g2.setColor(new Color(56, 0, 56));
        g2.fillRect(0, 0, GamePanel.windowWidth, GamePanel.windowHeight);

        // TITLE NAME //
        /// replace later
        g2.setFont(g2.getFont().deriveFont(Font.BOLD, 75f));
        String text = "GOoD Night tO you";
        int x = getXForCenteredText(text);
        int y = 100;

        //shadow
        g2.setColor(Color.GRAY);
        g2.drawString(text, x+5, y+5);
        //main
        g2.setColor(Color.WHITE);
        g2.drawString(text, x, y);


        // MENU //
        g2.setFont(g2.getFont().deriveFont(Font.BOLD, 48));

        text ="New Game";
        x = getXForCenteredText(text);
        y+= 250;
        g2.drawString(text, x, y);
        if(commandNum == 0){
            g2.drawString(">", x-50, y);
        }

        text ="Load Game";
        x = getXForCenteredText(text);
        y+= 100;
        g2.drawString(text, x, y);
        if(commandNum == 1){
            g2.drawString(">", x-50, y);
        }

        text ="Settings";
        x = getXForCenteredText(text);
        y+= 100;
        g2.drawString(text, x, y);
        if(commandNum == 2){
            g2.drawString(">", x-50, y);
        }

        text ="Quit Game";
        x = getXForCenteredText(text);
        y+= 100;
        g2.drawString(text, x, y);
        if(commandNum == 3){
            g2.drawString(">", x-50, y);
        }
    }

    // VARIBLE THINGS //

    public int getXForCenteredText(String text){
        int length = (int)g2.getFontMetrics().getStringBounds(text, g2).getWidth();
        int x = GamePanel.windowWidth/2 - length/2;
        return x;
    }
}
