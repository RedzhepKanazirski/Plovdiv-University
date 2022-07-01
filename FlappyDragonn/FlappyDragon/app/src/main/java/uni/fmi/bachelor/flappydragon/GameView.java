package uni.fmi.bachelor.flappydragon;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.RectF;
import android.graphics.Typeface;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;

//START/START/START/START/START/START/START/START/START/START/START/START/START/START/START/START/START/START

public class GameView extends View {
    //CANVAS
    private int canvasWidth;
    private int canvasHeight;

    //THE DRAGON
    private Bitmap dragon[] = new Bitmap[2];
    private int dragonX = 10;
    private int dragonY;
    private  int dragonSpeed;

    //YELLOW BALL- The food
    private int foodX;
    private int foodY;
    private int foodSpeed = 15;
    private Paint foodShow = new Paint();

    //SNOW BALL
    private int snowX;
    private int snowY;
    private int snowSpeed = 35;
    private Paint snowShow = new Paint();

    //RED BALL
    private int redX;
    private int redY;
    private int redSpeed = 40;
    private Paint redShow = new Paint();

    //BACKGROUND IMAGE
    private Bitmap backgroundImage ;

    // SCORE
    private Paint scoreShow = new Paint();
    private int score;

    //LIFE
    private Bitmap life[]= new Bitmap[2];
    private int life_count;

    //STATUS
    private boolean touch_dragon = false;


    public GameView(Context context) {
        super(context);
        dragon[0] = BitmapFactory.decodeResource(getResources(),R.drawable.drago1);
        dragon[1] = BitmapFactory.decodeResource(getResources(),R.drawable.drago2);
        backgroundImage = BitmapFactory.decodeResource(getResources(),R.drawable.bck3);
        //backgroundImage = Bitmap.createScaledBitmap(backgroundImage,canvasHeight,canvasWidth, true);

        foodShow.setColor(Color.YELLOW);

        snowShow.setColor(Color.WHITE);

        redShow.setColor(Color.RED);

        scoreShow.setColor(Color.rgb(0, 255, 0));
        scoreShow.setTextSize(56);

        life[0] = BitmapFactory.decodeResource(getResources(),R.drawable.heart);
        life[1] = BitmapFactory.decodeResource(getResources(),R.drawable.heart_g);

        //POSITION WHEN THE GAME STARTS
        dragonY = 0;
        score= 0;
        life_count=3;
    }

    @Override
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        canvasWidth= canvas.getWidth();
        canvasHeight= canvas.getHeight();

        canvas.drawBitmap(backgroundImage,0,100,null);

        int minDragonY = dragon[0].getHeight();
        int maxDragonY = canvas.getHeight() - dragon[0].getHeight();

        dragonY += dragonSpeed;
        if(dragonY < minDragonY) dragonY = minDragonY;
        if(dragonY > maxDragonY) dragonY = maxDragonY;
        dragonSpeed += 2;

//FLAPPING
        if(touch_dragon){
         canvas.drawBitmap(dragon[1],dragonX,dragonY,null);
            touch_dragon= false;
        }else{
          canvas.drawBitmap(dragon[0],dragonX, dragonY, null);
         }

//THE FOOD
        foodX -= foodSpeed;
        if(hitCheck(foodX,foodY)){
            score += 5;
            foodX= -100;
        }
        if(foodX < 0){
            foodX= canvasWidth+200;
            foodY= (int)Math.floor(Math.random()*(maxDragonY-minDragonY))+ minDragonY;
        }
        canvas.drawCircle(foodX,foodY,15,foodShow);

  //RED BALL
        redX -= redSpeed;
        if(hitCheck(redX,redY)){
            redX= -100;
            life_count --;
        }

        if(redX< 0){
            redX= canvasWidth+200;
            redY= (int)Math.floor(Math.random()*(maxDragonY-minDragonY))+ minDragonY;
        }
        canvas.drawCircle(redX,redY,25,redShow);
//SNOW BALL
        snowX -= snowSpeed;
        if(hitCheck(snowX,snowY)){
            snowX= -100;
            life_count --;
        }

        if(snowX < 0){
            snowX= canvasWidth+200;
            snowY= (int)Math.floor(Math.random()*(maxDragonY-minDragonY))+ minDragonY;
        }
        canvas.drawCircle(snowX,snowY,40,snowShow);
        canvas.drawCircle(snowX,snowY,10,snowShow);

//SCORE
        canvas.drawText("Score : "+ score,70,70,scoreShow);

//LIFE
       for(int i = 0; i<3; i++){
            int x = (int) (800+ life[0].getWidth()*1.5*i);
            int y = 30;

            if (i<life_count){
                canvas.drawBitmap(life[0],x,y,null);
            }else {
                canvas.drawBitmap(life[1],x,y,null);
            }
       }
       // canvas.drawBitmap(life[0],800,30,null);
       // canvas.drawBitmap(life[0],900,30,null);
       // canvas.drawBitmap(life[1],1000,30,null);
    }
    public boolean hitCheck(int x,int y){
        if(dragonX<x && x<(dragon[0].getWidth())
                && dragonY<y&& y< (dragonY+dragon[0].getHeight())){
            return true;
        }
        return false;
    }
    @Override
   public boolean onTouchEvent(MotionEvent event) {
        if(event.getAction()==MotionEvent.ACTION_DOWN) {
           touch_dragon = true;
             dragonSpeed = -25;
        }
        return  true;
    }
}
