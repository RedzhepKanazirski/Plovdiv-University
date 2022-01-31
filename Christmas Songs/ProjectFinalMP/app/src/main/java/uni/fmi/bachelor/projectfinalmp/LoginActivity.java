package uni.fmi.bachelor.projectfinalmp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class LoginActivity extends AppCompatActivity {

    EditText username1, password1;
    Button signin1;
    DBHelper DB;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        username1 = findViewById(R.id.username1);
        password1 = findViewById(R.id.password1);
        signin1 = findViewById(R.id.btn_sign_in1);
        DB = new DBHelper(this);

        signin1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String user = username1.getText().toString();
                String pass = password1.getText().toString();

                if (TextUtils.isEmpty(user) || TextUtils.isEmpty(pass))
                {
                    Toast.makeText(LoginActivity.this, "Всички полета са задължителни", Toast.LENGTH_SHORT).show();
                }else
                {
                    Boolean checkuserpass = DB.checkusernamepassword(user,pass);
                    if (checkuserpass == true)
                    {
                        Toast.makeText(LoginActivity.this, "Вход успешен", Toast.LENGTH_SHORT).show();
                        Intent intent = new Intent(getApplicationContext(),HomeActivity.class);
                        startActivity(intent);
                    }else
                    {
                        Toast.makeText(LoginActivity.this, "Вход неуспешен", Toast.LENGTH_SHORT).show();
                    }
                }

             }
        });

    }
}