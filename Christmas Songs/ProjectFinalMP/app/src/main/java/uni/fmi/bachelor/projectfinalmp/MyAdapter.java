package uni.fmi.bachelor.projectfinalmp;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import androidx.annotation.NonNull;

import java.util.ArrayList;
import java.util.List;

public class MyAdapter extends ArrayAdapter<Song> {

    //----------------------------------------inicialization------------------------------------------------------------------
    private final LayoutInflater inflater;
    private final ArrayList<Song>objects;

    private static  class ViewHolder{
        TextView a1;
        TextView a2;
        TextView a3;
        TextView a4;

    }

    public MyAdapter( Context context, ArrayList<Song> objects) {
        super(context, R.layout.ac_listview, objects);
        inflater = LayoutInflater.from(context);
        this.objects = objects;
    }
    //----------------------------------------------SHORT--METHOSD--------------------------------------------------------------------------------------
    public  int getCount(){
        return objects.size();
    }

    public  Song getItem(int position){
        return objects.get(position);
    }

    public  long getToItem (int position){
        return  position;
    }

    public View getView(int position, View convertView, ViewGroup parent){
        ViewHolder holder = null;
        if (convertView == null)
        {
            holder = new ViewHolder();
            convertView = inflater.inflate(R.layout.ac_listview, null);
            holder.a1 = convertView.findViewById(R.id.a1);
            holder.a2 = convertView.findViewById(R.id.a2);
            holder.a3 = convertView.findViewById(R.id.a3);
            holder.a4 = convertView.findViewById(R.id.a4);

            convertView.setTag(holder);
        }else
        {
            holder = (ViewHolder) convertView.getTag();
        }


        holder.a1.setText(objects.get(position).getName());
        holder.a2.setText(objects.get(position).getGenre());
        holder.a3.setText(objects.get(position).getYear());
        holder.a4.setText(objects.get(position).getAlbum());

        return  convertView;
    }
//------------------------------------------------------------------------------------------------------------------------------------

}
