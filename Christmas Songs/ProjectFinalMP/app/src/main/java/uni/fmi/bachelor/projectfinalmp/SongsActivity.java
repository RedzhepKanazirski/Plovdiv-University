package uni.fmi.bachelor.projectfinalmp;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import java.util.ArrayList;

public class SongsActivity extends AppCompatActivity {

    static ListView view_all;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_songs);

        view_all = findViewById(R.id.view_all);
        DBHelper2 db2 = new DBHelper2(this);
        EditText fill_name = findViewById(R.id.fill_name);
        EditText fill_genre = findViewById(R.id.fill_genre);
        EditText fill_year = findViewById(R.id.fill_year);
        EditText fill_album = findViewById(R.id.fill_album);
        Button btn_add = findViewById(R.id.btn_add);
        Button btn_view_list = findViewById(R.id.btn_view_list);

        //ot toq buton da hodqt w drugoto aktiwiti--------------------------------------

//--------------------------------------------------------------------------------------
        btn_add.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {



                Song my_song;
                try {
                    my_song = new Song(fill_name.getText().toString(),
                                       fill_genre.getText().toString(),
                                       fill_year.getText().toString(),
                                       fill_album.getText().toString());


                    Toast.makeText(SongsActivity.this, my_song.toString(),Toast.LENGTH_SHORT).show();
                }catch (Exception e){
                    Toast.makeText(SongsActivity.this, "ERROR",Toast.LENGTH_SHORT).show();
                    my_song = new Song( " ", " ", " ","");
                }
                DBHelper2 databaseHelper = new DBHelper2(SongsActivity.this);
                boolean success = databaseHelper.addSong(my_song);
                Toast.makeText(SongsActivity.this, "SUCCESS",Toast.LENGTH_SHORT).show();

                //Intent intent = new Intent(getApplicationContext(),ViewSongsActivity.class);
               // startActivity(intent);
            }
        });
//--------------------------------------------------------------------------------------
        btn_view_list.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                ArrayList<Song> query_list = db2.getAllRecords();
                MyAdapter customAdapter = new MyAdapter(SongsActivity.this,query_list);
                view_all.setAdapter(customAdapter);

               // Intent intent2 = new Intent(getApplicationContext(),ViewSongsActivity.class);
                //startActivity(intent2);
            }
        });


//--------------------------------------------------------------------------------------
        ArrayList<Song> query_list = db2.getAllRecords();
        MyAdapter customAdapter = new MyAdapter(SongsActivity.this,query_list);
        view_all.setAdapter(customAdapter);
        view_all.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                AlertDialog.Builder builder = new AlertDialog.Builder(SongsActivity.this);
                builder.setTitle("Title");
                builder.setItems(new CharSequence[]{"DELETE", "UPDATE"}, new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {

                        switch (which)
                        {
                            case 0:
                                new AlertDialog.Builder(SongsActivity.this)
                                        .setIcon(android.R.drawable.ic_dialog_alert)
                                        .setTitle("DELETE an ITEM")
                                        .setMessage("Are you sure u want to delete this one")
                                        .setPositiveButton("Yes", new DialogInterface.OnClickListener() {
                                            @Override
                                            public void onClick(DialogInterface dialog, int which) {
                                                Song clicked_contact = (Song) parent.getItemAtPosition(position);
                                                db2.deleteOne(clicked_contact);
                                                customAdapter.notifyDataSetChanged();
                                                Toast.makeText(SongsActivity.this, "Deleted!",Toast.LENGTH_SHORT).show();
                                            }
                                        })
                                        .setNegativeButton("No", new DialogInterface.OnClickListener() {
                                            @Override
                                            public void onClick(DialogInterface dialog, int which) {
                                                Toast.makeText(SongsActivity.this, "OK",Toast.LENGTH_SHORT).show();
                                            }
                                        })
                                        .show();
                                break;

                            case 1:
                                new AlertDialog.Builder(SongsActivity.this)
                                        .setIcon(android.R.drawable.ic_dialog_alert)
                                        .setTitle("UPDATE an ITEM")
                                        .setMessage("Are you sure u want to update this one")
                                        .setPositiveButton("Yes", new DialogInterface.OnClickListener() {
                                            @Override
                                            public void onClick(DialogInterface dialog, int which) {
                                                Song clicked_contact = (Song) parent.getItemAtPosition(position);

                                                Integer send_id = clicked_contact.getId();
                                                String send_name = clicked_contact.getName();
                                                String send_genre = clicked_contact.getGenre();
                                                String send_year = clicked_contact.getYear();
                                                String send_album = clicked_contact.getAlbum();

                                                Intent intent_update = new Intent(SongsActivity.this, EditSongActivity.class);
                                                intent_update.putExtra("send_id",send_id);
                                                intent_update.putExtra("send_name",send_name);
                                                intent_update.putExtra("send_genre",send_genre);
                                                intent_update.putExtra("send_year",send_year);
                                                intent_update.putExtra("send_album",send_album);
                                                startActivity(intent_update);
                                                finish();
                                            }
                                        })
                                        .setNegativeButton("No", new DialogInterface.OnClickListener() {
                                            @Override
                                            public void onClick(DialogInterface dialog, int which) {
                                                Toast.makeText(SongsActivity.this, "OK",Toast.LENGTH_SHORT).show();
                                            }
                                        })
                                        .show();
                                break;
                        }
                    }
                });
                builder.create().show();

            }
        });
//--------------------------------------------------------------------------------------




//--------------------------------------------------------------------------------------




//--------------------------------------------------------------------------------------
    }
}