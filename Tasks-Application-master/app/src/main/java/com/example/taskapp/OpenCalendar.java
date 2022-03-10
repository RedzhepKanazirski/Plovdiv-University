package com.example.taskapp;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CalendarView;
import android.widget.DatePicker;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;


public class OpenCalendar extends AppCompatActivity {

     Button btn_backFromCalendar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_calendar_main);
        getSupportActionBar().hide();

       btn_backFromCalendar = findViewById(R.id.buttonBackFromCalendar);

        btn_backFromCalendar.setOnClickListener(new View.OnClickListener() {
           @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(),MainActivity.class);
                startActivity(intent);
            }
        });

        CalendarView calendarView = findViewById(R.id.calendarView);
        final TextView selectedDay = findViewById(R.id.selectedDay);
        final  TextView selectedMonth = findViewById(R.id.selectedMonth);
        final  TextView selectedYear = findViewById(R.id.selectedYear);

        calendarView.setOnDateChangeListener(new CalendarView.OnDateChangeListener() {
            @Override
            public void onSelectedDayChange(@NonNull CalendarView view, int year, int month, int dayOfMonth) {
                selectedDay.setText("Selected Day: " + dayOfMonth);
                selectedMonth.setText("Selected Month: " + month);
                selectedYear.setText("Selected Year: " + year);
            }
        });

    }
}