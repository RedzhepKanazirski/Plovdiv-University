package uni.fmi.bachelor.flappydragon;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.os.Handler;

import java.util.Timer;
import java.util.TimerTask;

public class MainActivity extends AppCompatActivity {

    private GameView gameView;
    private Handler handler = new Handler();
    private final static long TIMER_INERVAL = 30;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        gameView = new GameView(this);
        setContentView(gameView);

        Timer timer= new Timer();
        timer.schedule(new TimerTask() {
            @Override
            public void run() {
               handler.post(new Runnable() {
                   @Override
                   public void run() {
                      gameView.invalidate();
                   }
               });
            }
        },0,TIMER_INERVAL);
    }
}