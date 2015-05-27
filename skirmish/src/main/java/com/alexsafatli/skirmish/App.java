package com.alexsafatli.skirmish;

import java.awt.Color;
import java.awt.Font;
 
public class App implements Application {
    
    private Window window = null;
 
    @Override
    public void startup(Display display, Map<String, String> properties) {
        window = new Window();
 
        TablePane pane = new TablePane();
 
        window.setContent(pane);
        window.setTitle("Hello World!");
        window.setMaximized(true);
 
        window.open(display);
    }
 
    @Override
    public boolean shutdown(boolean optional) {
        if (window != null) {
            window.close();
        }
 
        return false;
    }
 
    @Override
    public void suspend() {
    }
 
    @Override
    public void resume() {
    }

    public static void main(String[] args) {
    	DesktopApplicationContext.main(App.class,args);
    }

}