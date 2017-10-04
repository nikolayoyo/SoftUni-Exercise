using System.Collections;
using System.Collections.Generic;

public class Artist
{
    private string name;
    private List<Song> songs;

    public Artist(string name)
    {
        this.Name = name;
        songs = new List<Song>();
    }

    public IReadOnlyCollection<Song> Songs
    {
        get { return this.songs as IReadOnlyCollection<Song>; }
    }

    public void AddSong(Song song)
    {
        if (true)
        {

        }

        songs.Add(song);
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

}

