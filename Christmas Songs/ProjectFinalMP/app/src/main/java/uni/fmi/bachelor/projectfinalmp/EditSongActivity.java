package uni.fmi.bachelor.projectfinalmp;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import java.util.ArrayList;

public class EditSongActivity extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_update);

        DBHelper2 db2 = new DBHelper2(this);

        EditText edit_fill_name = findViewById(R.id.edit_fill_name);
        EditText edit_fill_genre = findViewById(R.id.edit_fill_genre);
        EditText edit_fill_year = findViewById(R.id.edit_fill_year);
        EditText edit_fill_album = findViewById(R.id.edit_fill_album);
        Button edit_btn_add = findViewById(R.id.edit_btn_add);

        Integer sent_id = getIntent().getExtras().getInt("send_id");
        String sent_name = getIntent().getExtras().getString("send_name");
        String sent_genre = getIntent().getExtras().getString("send_genre");
        String sent_year = getIntent().getExtras().getString("send_year");
        String sent_album = getIntent().getExtras().getString("send_album");

        edit_fill_name.setText(sent_name);
        edit_fill_genre.setText(sent_genre);
        edit_fill_year.setText(sent_year);
        edit_fill_album.setText(sent_album);

        edit_btn_add.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String new_name = edit_fill_name.getText().toString();
                String new_genre = edit_fill_genre.getText().toString();
                String new_year = edit_fill_year.getText().toString();
                String new_album = edit_fill_album.getText().toString();

                Song my_new_song = new Song(new_name,new_genre,new_year,new_album);

                my_new_song.setId(sent_id);

                db2.updateOne(my_new_song);
                boolean update_success = db2.updateOne(my_new_song);
                if (update_success)
                {
                    Toast.makeText(EditSongActivity.this, "Updated"+my_new_song.toString(),Toast.LENGTH_SHORT).show();
                }else
                {
                    Toast.makeText(EditSongActivity.this, "Not updated",Toast.LENGTH_SHORT).show();
                }

                ArrayList<Song> query_list = db2.getAllRecords();
                MyAdapter customAdapter = new MyAdapter(EditSongActivity.this,query_list);
                SongsActivity.view_all.setAdapter(customAdapter);
                customAdapter.notifyDataSetChanged();

                Intent intent_update_and_go_back = new Intent(EditSongActivity.this, SongsActivity.class);
                startActivity(intent_update_and_go_back);
                finish();
            }
        });
    }




}
