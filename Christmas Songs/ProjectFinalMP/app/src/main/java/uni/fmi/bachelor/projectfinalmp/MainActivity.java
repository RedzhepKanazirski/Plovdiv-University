package uni.fmi.bachelor.projectfinalmp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    EditText username, password;
    Button signup, signin;
    DBHelper DB;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        username = findViewById(R.id.username);
        password = findViewById(R.id.password);
        signup = findViewById(R.id.btn_register);
        signin = findViewById(R.id.btn_sign_in);
        DB = new DBHelper(this);
//-------------------------------------------------------------------------------------------------------
        signup.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String user = username.getText().toString();
                String pass = password.getText().toString();
               // String reppass = reppassword.getText().toString();

                if (TextUtils.isEmpty(user) || TextUtils.isEmpty(pass))
                {
                    Toast.makeText(MainActivity.this, "Всички полета са задължителни", Toast.LENGTH_SHORT).show();
                }else
                {

                        Boolean checkuser = DB.checkusername(user);
                        if (checkuser == false)
                        {
                            Boolean insert = DB.insertData(user,pass);
                            if (insert == true)
                            {
                                Toast.makeText(MainActivity.this, "Успешна регистрация", Toast.LENGTH_SHORT).show();
                                Intent intent = new Intent(getApplicationContext(),HomeActivity.class);
                                startActivity(intent);
                            }else
                            {
                                Toast.makeText(MainActivity.this, "Неуспешна регистрация", Toast.LENGTH_SHORT).show();
                            }
                        }else
                        {
                            Toast.makeText(MainActivity.this, "Има съществуващ потребител с тов име", Toast.LENGTH_SHORT).show();
                        }

                }
            }
        });
//-------------------------------------------------------------------------------------------------------
        signin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(),LoginActivity.class);
                startActivity(intent);

            }
        });
//-------------------------------------------------------------------------------------------------------


        //-------------------------------------------------------------------------------------------------------



        //-------------------------------------------------------------------------------------------------------


        //-------------------------------------------------------------------------------------------------------

    }
}