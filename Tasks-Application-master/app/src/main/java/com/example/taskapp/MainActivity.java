package com.example.taskapp;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.CheckBox;

import com.example.taskapp.Adapter.ToDoAdapter;
import com.example.taskapp.Model.ToDoModel;
import com.example.taskapp.Utils.DBHelper;
import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class MainActivity extends AppCompatActivity implements DialogCloseListener{

//----------------------------------------initializations------------------------------------------------------------
    private RecyclerView tasksRV;
    private ToDoAdapter tasksAdapter;
    private List<ToDoModel> taskList;

    private FloatingActionButton fab;
     private Button btnGoToCalendar;
    private CheckBox cb;
    private DBHelper db;
//------------------------------------------------------------------------------------------------------------------
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        getSupportActionBar().hide();

        //opening DB-------------------------------------------------------------------------
        db = new DBHelper(this);
        db.openDatabase();

        //the array with the TASKS-----------------------------------------------------------
        taskList = new ArrayList<>();
        cb = findViewById(R.id.todoCheckbox);

        //connection between the button and his action---------------------------------------
        tasksRV = findViewById(R.id.tasksRecycleView);
        //podrejda gi edno pod drugo---------------------------------------------------------
        tasksRV.setLayoutManager(new LinearLayoutManager(this));
        //inicializirane na TaskAdopter-----------------------------------------------------
        tasksAdapter = new ToDoAdapter(db, this);
        //svyrzwane na TaskAdopter s taskovete-----------------------------------------------------
        tasksRV.setAdapter(tasksAdapter);

        // connection between the button and his action--------------------------------------
        fab = findViewById(R.id.actionButton);

        btnGoToCalendar = findViewById(R.id.buttonCalendar);


        //pylnene na task lista(array) -----------------------------------------------------
        taskList = db.getAllTasks();
        //reversing the array again-----------------------------------------------------
        Collections.reverse(taskList);
        //priemane na array-a from the adopter-----------------------------------------------------
        tasksAdapter.setTask(taskList);


        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                AddTask.newInstance().show(getSupportFragmentManager(), AddTask.TAG);
            }
        });

        btnGoToCalendar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(),OpenCalendar.class);
                startActivity(intent);
            }
        });
    }
//---------------------------------------------The INTERFACE---------------------------------------------------------------------
    @Override
    public void handleDialogClose(DialogInterface dialog)
    {
        taskList = db.getAllTasks();
        Collections.reverse(taskList);
        tasksAdapter.setTask(taskList);
        tasksAdapter.notifyDataSetChanged();
    }
//------------------------------------------------------------------------------------------------------------------







}