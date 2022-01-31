package uni.fmi.bachelor.projectfinalmp;

import android.content.Intent;

public class Song {
//inicializaciq--------------------------------------------------------------------------------------------

    private Integer id;
    private String name;
    private String genre;
    private String year;
    private String album;

//empty constructor--------------------------------------------------------------------------------------------
    public Song() {
    }

//the construvturs--------------------------------------------------------------------------------------------
    public Song( String name, String genre, String year, String album) {
        this.id = id;
        this.name = name;
        this.genre = genre;
        this.year = year;
        this.album = album;
    }
 //--------------------------------GETERS and SETERS------------------------------------------------------------

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getGenre() {
        return genre;
    }

    public void setGenre(String genre) {
        this.genre = genre;
    }

    public String getYear() {
        return year;
    }

    public void setYear(String year) {
        this.year = year;
    }

    public String getAlbum() {
        return album;
    }

    public void setAlbum(String album) {
        this.album = album;
    }
//----------------------------------Method toString----------------------------------------------------------
    @Override
    public String toString() {
        return "Song{" +
                "id=" + id +
                ", name='" + name + '\'' +
                ", genre='" + genre + '\'' +
                ", year='" + year + '\'' +
                ", album='" + album + '\'' +
                '}';
    }
//--------------------------------------------------------------------------------------------
}
