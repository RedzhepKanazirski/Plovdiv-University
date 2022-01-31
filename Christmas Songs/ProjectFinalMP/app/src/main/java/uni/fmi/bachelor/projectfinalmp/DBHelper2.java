package uni.fmi.bachelor.projectfinalmp;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

import java.util.ArrayList;

public class DBHelper2 extends SQLiteOpenHelper {

    private static final String DATABASE_NAME = "songsManager";
    private static final int VERSION = 1;
    private static final String TABLE_SONGS = "songs";
    private static final String KEY_ID = "id";
    private static final String KEY_NAME = "name" ;
    private static final String KEY_GENRE = "genre" ;
    private static final String KEY_YEAR = "year" ;
    private static final String KEY_ALBUM = "album" ;

    //------------------------------Конструктора --------------------------------------------------------------
    public DBHelper2(@Nullable Context context) {
        super(context, "songsManager", null, 1);
    }

 //------------------------------задължителните методи--------------------------------------------------------------
    @Override
    public void onCreate(SQLiteDatabase db) {
        String CREATE_SONGS_TABLE = "CREATE TABLE " + TABLE_SONGS + "(" + KEY_ID    + " INTEGER PRIMARY KEY,"
                                                                        + KEY_NAME  + " TEXT,"
                                                                        + KEY_GENRE + " TEXT,"
                                                                        + KEY_YEAR + " TEXT,"
                                                                        + KEY_ALBUM + " TEXT"
                                                                                    + ")";
        db.execSQL(CREATE_SONGS_TABLE);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS " + TABLE_SONGS);
        onCreate(db);
    }
//-------------------------------------------INSERT-------------------------------------------------
    public boolean addSong(Song song){
        SQLiteDatabase db = this.getWritableDatabase();
         ContentValues values = new ContentValues();
         values.put(KEY_NAME, song.getName());
         values.put(KEY_GENRE, song.getGenre());
         values.put(KEY_YEAR, song.getYear());
         values.put(KEY_ALBUM, song.getAlbum());

        //wmykwane-----------------------------------
        long insert = db.insert(TABLE_SONGS, null,values);

    if (insert == -1)
    {
        return false;
    }else
    {
        return  true;
    }
}
// ---------------------------------------method GET_LIST(zapisi)-------------------------------------------------------------------------
public ArrayList<Song> getAllRecords(){
    SQLiteDatabase db = this.getReadableDatabase();
    Cursor cursor = db.query(TABLE_SONGS, null,null,null,null,null,null);
    ArrayList<Song> songs = new ArrayList<Song>();
    Song songModel;

    //obhojdane na zapisite
    if (cursor.getCount()> 0)
    {
        for (int i = 0; i<cursor.getCount(); i++)
        {
            cursor.moveToNext();
            songModel= new Song();
            songModel.setId(cursor.getInt(0));
            songModel.setName(cursor.getString(1));
            songModel.setGenre(cursor.getString(2));
            songModel.setYear(cursor.getString(3));
            songModel.setAlbum(cursor.getString(4));
            songs.add(songModel);
        }
    }
    cursor.close();
    db.close();

    return songs;
}
//--------------------------------------------------------------------------------------------
// ---------------------------------------------method DELETE-------------------------------------------------------------------
public  boolean deleteOne(Song song){
    SQLiteDatabase db = this.getWritableDatabase();
    String queryString = " DELETE FROM " + TABLE_SONGS + " WHERE " + KEY_ID + " = " + song.getId();

    Cursor cursor = db.rawQuery(queryString, null);

    if (cursor.moveToFirst())
    {
        return true;
    }else
    {
        return false;
    }
}
// -------------------------------------------------method UPDATE-------------------------------------------------------------------------
public  boolean updateOne(Song song) {
    SQLiteDatabase db = this.getWritableDatabase();
    ContentValues contentValues = new ContentValues();
    contentValues.put(KEY_NAME, song.getName());
    contentValues.put(KEY_GENRE, song.getGenre());
    contentValues.put(KEY_YEAR, song.getYear());
    contentValues.put(KEY_ALBUM, song.getAlbum());

    db.update(TABLE_SONGS, contentValues, "ID = ?", new String[]{String.valueOf(song.getId())});
    return true;
}
//-----------------------------------------------------------------------------------------------------------------------------------------





//--------------------------------------------------------------------------------------------




//--------------------------------------------------------------------------------------------
}
